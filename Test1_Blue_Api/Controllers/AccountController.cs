using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;

namespace Test1_Blue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
           // SeedAdminUserAsync().Wait(); // Call the seeding method here
        }

        private async Task SeedAdminUserAsync()
        {
            var adminEmail = _configuration["AdminSettings:Email"];
            var adminPassword = _configuration["AdminSettings:Password"];

            if (string.IsNullOrEmpty(adminEmail) || string.IsNullOrEmpty(adminPassword))
            {
                throw new Exception("Admin Email and Password must be provided in the appsettings.json");
            }

            // Create roles if they don't exist
            string[] roleNames = { "Admin", "User" };
            foreach (var roleName in roleNames)
            {
                var roleExists = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var adminUser = await _userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                var admin = new AppUser
                {
                    UserName = adminEmail,
                    Email = adminEmail
                };

                var createAdmin = await _userManager.CreateAsync(admin, adminPassword);
                if (createAdmin.Succeeded)
                {
                    await _userManager.AddToRoleAsync(admin, "Admin");
                }
                else
                {
                    throw new Exception($"Failed to create admin user: {string.Join(", ", createAdmin.Errors)}");
                }
            }
            else
            {
                // Ensure the admin user has the Admin role
                if (!await _userManager.IsInRoleAsync(adminUser, "Admin"))
                {
                    await _userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegistrationNewUser(NewUserDto user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber // Set phone number if provided
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                {
                    // Assign default user role
                    await _userManager.AddToRoleAsync(appUser, "User");
                    return Ok("Registration successful");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return BadRequest(ModelState);
        }


        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn(LoginDto login)
        {
            if (ModelState.IsValid)
            {
                // Find user by username
                AppUser? user = await _userManager.FindByNameAsync(login.userName);
                if (user != null)
                {
                    // Check password
                    if (await _userManager.CheckPasswordAsync(user, login.password))
                    {
                        // Create claims for the token
                        var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                        // Get user roles
                        var roles = await _userManager.GetRolesAsync(user);
                        foreach (var role in roles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }

                        // Signing credentials
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
                        var sc = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        // Create the token
                        var token = new JwtSecurityToken(
                            claims: claims,
                            issuer: _configuration["JWT:Issuer"],
                            audience: _configuration["JWT:Audience"],
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: sc
                        );

                        // Return the token, expiration, username, and roles
                        var _token = new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo,
                            username = user.UserName, // Add username to response
                            roles = roles // Add roles to response
                        };

                        return Ok(_token);
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User not found");
                }
            }

            return BadRequest(ModelState);
        }
    








    }
}
