namespace ECommerceApi.DTO
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ReviewerName { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
