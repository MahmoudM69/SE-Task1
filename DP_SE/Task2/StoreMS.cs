namespace Task2.StoreMS
{
    public class Payment
    {
        public void DeductPayment()
        {

            Console.WriteLine("Payment Deducted");
        }
    }
    public class Inventory
    {
        public void CheckInventory()
        {

            Console.WriteLine("Item is available in the inventory");
            
        }        
    }
    public class OrderFacade
    {

        Inventory inventory = new Inventory();
        Payment payment = new Payment();
        public void PlaceOrder()
        {
            Console.WriteLine("Checking the inventory");
            inventory.CheckInventory();
            Console.WriteLine("Deducting payment");
            payment.DeductPayment();
        }
    }

    public class Clinet
    {
        public OrderFacade myOrderFacade = new OrderFacade();
        public void Order()
        {
            Console.WriteLine("Making an order");
            myOrderFacade.PlaceOrder();
        }
    }
}