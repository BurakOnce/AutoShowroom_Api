﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AutoShowroom_UI.Dtos.PopularLocationDtos;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultProductListExploreCitiesComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultProductListExploreCitiesComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44337/api/PopularLocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultPopularLocationDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
