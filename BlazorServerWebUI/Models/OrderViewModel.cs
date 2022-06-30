namespace BlazorServerWebUI.Models
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderedOn { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }

    public class OrderDetailViewModel
    {
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
