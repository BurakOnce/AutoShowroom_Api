using AutoShowroom_UI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoShowroom_UI.ViewComponents.Dashboard
{
    public class _DashboardLast5ProductComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast5ProductComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44337/api/Products/Last5ProductList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5ProductWithCategortyDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
