﻿namespace Test1_Blue_Api.Models.Dtos
{
    public class AreaDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
    }
}
