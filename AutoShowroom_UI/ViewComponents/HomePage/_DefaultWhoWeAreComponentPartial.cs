using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AutoShowroom_UI.Dtos.WhoWeAreDtos;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync() 
        {   
            var client1 = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();

            var responseMessage1 = await client1.GetAsync("https://localhost:44337/api/WhoWeAreDetail");
            var responseMessage2 = await client2.GetAsync("https://localhost:44337/api/Service");

            if (responseMessage1.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode) 
            {
                var jsonData1= await responseMessage1.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                var value1 = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData1);
                var value2 = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);

                ViewBag.Title = value1.Select(x => x.Title).FirstOrDefault();
                ViewBag.Subtitle = value1.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.Description1 = value1.Select(x => x.Description1).FirstOrDefault();
                ViewBag.Description2 = value1.Select(x => x.Description2).FirstOrDefault();

                return View(value2);

            }

            return View();
        }

    }
}
