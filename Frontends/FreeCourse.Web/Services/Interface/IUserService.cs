using FreeCourse.Web.Models;

namespace FreeCourse.Web.Services.Interface
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}
