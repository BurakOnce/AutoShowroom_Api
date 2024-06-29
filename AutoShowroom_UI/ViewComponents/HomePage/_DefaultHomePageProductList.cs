using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AutoShowroom_UI.Dtos.ProductDtos;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultHomePageProductList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44337/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode) 
            {   
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
