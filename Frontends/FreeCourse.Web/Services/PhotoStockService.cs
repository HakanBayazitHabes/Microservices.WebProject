using FreeCourse.Web.Models.PhotoStock;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{
    public class PhotoStockService : IPhotoStockService
    {
        private readonly HttpClient _httpClient;

        public PhotoStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> DeletePhoto(string photoUrl)
        {
            var response =await _httpClient.DeleteAsync($"photos?photoUrl={photoUrl}");
            return response.IsSuccessStatusCode;
        }

        public async Task<PhotoViewModel> UploadPhoto(IFormFile photo)
        {
            if (photo == null || photo.Length <= 0)
            {
                return null;
            }
            // örnek dosya ismi = 22323230003.jpg
            var randomFilename = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photo.FileName)}";

            using var ms = new MemoryStream();

            await photo.CopyToAsync(ms);

            var multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new ByteArrayContent(ms.ToArray()), "photo", randomFilename);

            var response = await _httpClient.PostAsync("photos", multipartContent);


            return await response.Content.ReadFromJsonAsync<PhotoViewModel>();
            /*
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                var photoViewModel = JsonConvert.DeserializeObject<PhotoViewModel>(responseContent);

                return photoViewModel;
            }
            */

        }
    }
}
