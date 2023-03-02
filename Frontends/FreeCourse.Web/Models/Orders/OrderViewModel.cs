namespace FreeCourse.Web.Models.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        //Ödeme geçmişinde adres bilgileri gösterilmeyecek because ihtiyacımız yok
        //public AddressDto Address { get; set; }
        public string BuyerId { get; set; }

        public List<OrderItemViewModel> OrderItems { get; set; }
    }
}
