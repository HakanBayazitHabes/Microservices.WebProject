using FreeCourse.Web.Models.Discounts;

namespace FreeCourse.Web.Services.Interface
{
    public interface IDiscountService
    {
        Task<DiscountViewModel> GetDiscount(string discountCode);
    }
}
