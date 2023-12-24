namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; } // public -> accessor , int -> type , MyProperty -> name
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price {get; set;} //set long for payment system for later
        public string PictureUrl { get; set; }
        public string type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; } 
    }
}