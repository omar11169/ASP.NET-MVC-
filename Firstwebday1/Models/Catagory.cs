﻿namespace Firstwebday1.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> ProductList { get; set; }
    }
}