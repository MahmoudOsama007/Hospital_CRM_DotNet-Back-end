using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Models;

namespace Test1_Blue_Api.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<CallType> CallTypes { get; set; }
        public DbSet<CallAbout> CallAbouts { get; set; }
        public DbSet<CallService> CallServices { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<MajorSpecialist> MajorSpecialists { get; set; }
        public DbSet<MinorSpecialist> MinorSpecialists { get; set; }
        public DbSet<VerySpecificSpecialist> VerySpecificSpecialists { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            // Seed data for Cities
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Cairo" },
                new City { Id = 2, Name = "Alexandria" },
                new City { Id = 3, Name = "Giza" },
                new City { Id = 4, Name = "Aswan" },
                new City { Id = 5, Name = "Luxor" },
                new City { Id = 6, Name = "Sharm El-Sheikh" },
                new City { Id = 7, Name = "Hurghada" },
                new City { Id = 8, Name = "Port Said" },
                new City { Id = 9, Name = "Suez" },
                new City { Id = 10, Name = "Ismailia" }
            );

            // Seed data for Areas
            modelBuilder.Entity<Area>().HasData(
                // Cairo Areas
                new Area { Id = 1, Name = "Zamalek", CityId = 1 },
                new Area { Id = 2, Name = "Maadi", CityId = 1 },
                new Area { Id = 3, Name = "Heliopolis", CityId = 1 },
                new Area { Id = 4, Name = "Nasr City", CityId = 1 },
                new Area { Id = 5, Name = "Downtown", CityId = 1 },

                // Alexandria Areas
                new Area { Id = 6, Name = "Smouha", CityId = 2 },
                new Area { Id = 7, Name = "Sidi Gaber", CityId = 2 },
                new Area { Id = 8, Name = "Montaza", CityId = 2 },
                new Area { Id = 9, Name = "Stanley", CityId = 2 },
                new Area { Id = 10, Name = "Sporting", CityId = 2 },

                // Giza Areas
                new Area { Id = 11, Name = "Mohandessin", CityId = 3 },
                new Area { Id = 12, Name = "6th of October City", CityId = 3 },
                new Area { Id = 13, Name = "Dokki", CityId = 3 },
                new Area { Id = 14, Name = "Haram", CityId = 3 },
                new Area { Id = 15, Name = "Sheikh Zayed", CityId = 3 },

                // Aswan Areas
                new Area { Id = 16, Name = "Daraw", CityId = 4 },
                new Area { Id = 17, Name = "Kom Ombo", CityId = 4 },
                new Area { Id = 18, Name = "Edfu", CityId = 4 },

                // Luxor Areas
                new Area { Id = 19, Name = "Al Bayadiyah", CityId = 5 },
                new Area { Id = 20, Name = "Karnak", CityId = 5 },
                new Area { Id = 21, Name = "Al Mabad", CityId = 5 },

                // Sharm El-Sheikh Areas
                new Area { Id = 22, Name = "Naama Bay", CityId = 6 },
                new Area { Id = 23, Name = "Ras Nasrani", CityId = 6 },
                new Area { Id = 24, Name = "Shark's Bay", CityId = 6 },

                // Hurghada Areas
                new Area { Id = 25, Name = "El Gouna", CityId = 7 },
                new Area { Id = 26, Name = "Sahl Hasheesh", CityId = 7 },
                new Area { Id = 27, Name = "Al Kawthar", CityId = 7 },

                // Port Said Areas
                new Area { Id = 28, Name = "Al Manakh", CityId = 8 },
                new Area { Id = 29, Name = "Al Arab", CityId = 8 },
                new Area { Id = 30, Name = "Al Sharq", CityId = 8 },

                // Suez Areas
                new Area { Id = 31, Name = "Al Arbaeen", CityId = 9 },
                new Area { Id = 32, Name = "Faisal", CityId = 9 },
                new Area { Id = 33, Name = "Ataka", CityId = 9 },

                // Ismailia Areas
                new Area { Id = 34, Name = "El Salam", CityId = 10 },
                new Area { Id = 35, Name = "Sheikh Zayed", CityId = 10 },
                new Area { Id = 36, Name = "Al Sabah", CityId = 10 }
            );

            // Seed CallTypes
            // Seed CallTypes
            modelBuilder.Entity<CallType>().HasData(
                new CallType { Id = 1, Name = "Technical Support" },
                new CallType { Id = 2, Name = "Billing" },
                new CallType { Id = 3, Name = "General Inquiry" },
                new CallType { Id = 4, Name = "Appointment Scheduling" },
                new CallType { Id = 5, Name = "Patient Information" },
                new CallType { Id = 6, Name = "Medical Records" },
                new CallType { Id = 7, Name = "Insurance Inquiry" }
            );

            // Seed CallAbouts
            modelBuilder.Entity<CallAbout>().HasData(
                new CallAbout { Id = 1, Name = "Product Issue", CallTypeId = 1 },
                new CallAbout { Id = 2, Name = "Account Access", CallTypeId = 1 },
                new CallAbout { Id = 3, Name = "Payment Method", CallTypeId = 2 },
                new CallAbout { Id = 4, Name = "Invoice Query", CallTypeId = 2 },
                new CallAbout { Id = 5, Name = "Service Availability", CallTypeId = 3 },
                new CallAbout { Id = 6, Name = "Schedule an Appointment", CallTypeId = 4 },
                new CallAbout { Id = 7, Name = "Change Appointment", CallTypeId = 4 },
                new CallAbout { Id = 8, Name = "Check Appointment Status", CallTypeId = 4 },
                new CallAbout { Id = 9, Name = "Update Patient Info", CallTypeId = 5 },
                new CallAbout { Id = 10, Name = "Request Medical Records", CallTypeId = 6 },
                new CallAbout { Id = 11, Name = "Insurance Coverage Details", CallTypeId = 7 },
                new CallAbout { Id = 12, Name = "Claim Status", CallTypeId = 7 }
            );

            // Seed CallServices
            modelBuilder.Entity<CallService>().HasData(
                new CallService { Id = 1, Name = "Reset Password", CallAboutId = 2 },
                new CallService { Id = 2, Name = "Check Order Status", CallAboutId = 1 },
                new CallService { Id = 3, Name = "Update Payment Info", CallAboutId = 3 },
                new CallService { Id = 4, Name = "Request Invoice Copy", CallAboutId = 4 },
                new CallService { Id = 5, Name = "Check Service Location", CallAboutId = 5 },
                new CallService { Id = 6, Name = "Book Appointment", CallAboutId = 6 },
                new CallService { Id = 7, Name = "Cancel Appointment", CallAboutId = 7 },
                new CallService { Id = 8, Name = "View Appointment Details", CallAboutId = 8 },
                new CallService { Id = 9, Name = "Edit Patient Information", CallAboutId = 9 },
                new CallService { Id = 10, Name = "Get Medical Records", CallAboutId = 10 },
                new CallService { Id = 11, Name = "Submit Insurance Claim", CallAboutId = 11 },
                new CallService { Id = 12, Name = "Check Claim Status", CallAboutId = 12 }
            );


            modelBuilder.Entity<Hospital>().HasData(
                  new Hospital { Id = 1, Name = "City Hospital", Address = "123 Main St, Downtown" },
                  new Hospital { Id = 2, Name = "General Hospital", Address = "456 Elm St, Uptown" }
              );

            // Seed data for MajorSpecialists
            modelBuilder.Entity<MajorSpecialist>().HasData(
                new MajorSpecialist { Id = 1, Name = "Internal Medicine", HospitalId = 1 },
                new MajorSpecialist { Id = 2, Name = "Surgery", HospitalId = 1 },
                new MajorSpecialist { Id = 3, Name = "Pediatrics", HospitalId = 2 },
                new MajorSpecialist { Id = 4, Name = "Orthopedics", HospitalId = 2 }
            );

            // Seed data for MinorSpecialists
            modelBuilder.Entity<MinorSpecialist>().HasData(
                new MinorSpecialist { Id = 1, Name = "Cardiology", MajorSpecialistId = 2 },
                new MinorSpecialist { Id = 2, Name = "Gastroenterology", MajorSpecialistId = 1 },
                new MinorSpecialist { Id = 3, Name = "Neonatology", MajorSpecialistId = 3 },
                new MinorSpecialist { Id = 4, Name = "Sports Medicine", MajorSpecialistId = 4 }
            );

            // Seed data for VerySpecificSpecialists
            modelBuilder.Entity<VerySpecificSpecialist>().HasData(
                new VerySpecificSpecialist { Id = 1, Name = "Heart Surgeon", MinorSpecialistId = 1 },
                new VerySpecificSpecialist { Id = 2, Name = "Liver Specialist", MinorSpecialistId = 2 },
                new VerySpecificSpecialist { Id = 3, Name = "Neonatal Surgeon", MinorSpecialistId = 3 },
                new VerySpecificSpecialist { Id = 4, Name = "Sports Physiotherapist", MinorSpecialistId = 4 }
            );

            // Seed data for Doctors
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. John Smith", Qualification = "MD, Cardiology", VerySpecificSpecialistId = 1 },
                new Doctor { Id = 2, Name = "Dr. Jane Doe", Qualification = "MD, Hepatology", VerySpecificSpecialistId = 2 },
                new Doctor { Id = 3, Name = "Dr. Emily Johnson", Qualification = "MD, Pediatric Surgery", VerySpecificSpecialistId = 3 },
                new Doctor { Id = 4, Name = "Dr. Michael Brown", Qualification = "DPT, Sports Medicine", VerySpecificSpecialistId = 4 }
            );

            base.OnModelCreating(modelBuilder);



        }



    }
}
