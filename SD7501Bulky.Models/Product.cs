using System;


namespace BulkWeb.Models 
{

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public double ListPrice { get; set; }
        public double Price { get; set; }
        public double Price50 { get; set; }
        public double Price100 { get; set; }

    }

}




