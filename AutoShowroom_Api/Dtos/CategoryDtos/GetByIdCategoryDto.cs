﻿namespace AutoShowroom_Api.Dtos.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
