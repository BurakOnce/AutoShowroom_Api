﻿namespace AutoShowroom_UI.Dtos.ProductDtos
{
    public class ResultProductDto
    {

            public int productId { get; set; }
            public string title { get; set; }
            public decimal price { get; set; }
            public string city { get; set; }
            public string district { get; set; }
            public string categoryName { get; set; }
            public string categoryId { get; set; }
            public string CoverImage { get; set; }
            public string Type { get; set; }
            public string Address { get; set; }
            public bool dealOfTheDay { get; set; }

    }
}
