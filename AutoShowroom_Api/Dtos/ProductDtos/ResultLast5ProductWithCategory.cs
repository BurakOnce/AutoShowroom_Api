namespace AutoShowroom_Api.Dtos.ProductDtos
{
    public class ResultLast5ProductWithCategory
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public string CategoryName { get; set; }
        public string Type { get; set; }

        public DateTime AdvertisementDate { get; set; }
    }
}
