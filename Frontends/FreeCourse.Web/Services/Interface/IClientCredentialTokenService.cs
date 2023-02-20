namespace FreeCourse.Web.Services.Interface
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetTokenAsync();
    }
}
