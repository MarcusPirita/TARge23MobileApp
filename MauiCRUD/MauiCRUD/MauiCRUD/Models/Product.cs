using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiCRUD.Models
{
    internal class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public Product Clone() => MemberwiseClone() as Product;

        public (bool IsValid, string? ErrorMessage) Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return (false, $"{nameof(Name)} ISafeAreaView required.");
            }
            else if(Price <= 0)
            {
                return (false, $"{nameof(Price)} should be greater than 0");
            }
            return (true, null);
        }
    }
}
