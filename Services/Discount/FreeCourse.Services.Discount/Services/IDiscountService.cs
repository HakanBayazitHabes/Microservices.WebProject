﻿using FreeCourse.Services.Discount.Model;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<Model.Discount>>> GetAll();
        Task<Response<Model.Discount>> GetById(int id);
        Task<Response<NoContent>> Save(Model.Discount discount);
        Task<Response<NoContent>> Update(Model.Discount discount);
        Task<Response<NoContent>> DeleteById(int id);
        Task<Response<Model.Discount>> GetByCodeAndUserId(string code, string userId);
    }
}
