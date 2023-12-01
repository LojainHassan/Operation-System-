namespace OperationSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? BarCode { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string? ImageUrl { get; set; }

        public bool isStcok { get; set; }
        public Size Size { get; set; }
        public bool isDeleted { get; set; }

    }
}


public enum Size
{
    Small , L , Xl
}