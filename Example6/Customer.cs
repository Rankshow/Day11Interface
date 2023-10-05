namespace Example6
{
    public class Customer
    {
        public Customer()
        {
            CustomerId = Guid.NewGuid();
        }
        public Guid CustomerId { get; private set; }
        public string? Name { set; get; }
        public string? Email { set; get; }
        public string? Country { set; get; }
    }
}