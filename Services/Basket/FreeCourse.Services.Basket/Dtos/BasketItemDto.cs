﻿namespace FreeCourse.Services.Basket.Dtos
{
    public class BasketItemDto
    {
        public int Quantity { get; set; } = 1;

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public decimal Price { get; set; }

    }
}
