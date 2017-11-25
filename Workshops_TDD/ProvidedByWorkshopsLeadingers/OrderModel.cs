namespace Workshops_TDD
{
    public class OrderModel
    {
        public string CustomerUsername { get; set; }
        public ItemModel[] Items { get; set; }

        public OrderModel()
        {
            Items = new ItemModel[] { };
        }
    }
}