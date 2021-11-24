using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{

    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "decimal(18,2)")] public decimal Length { get; set; }
        public string LengthUnit { get; set; }
        [Column(TypeName = "decimal(18,2)")] public decimal Width { get; set; }
        public string WidthUnit { get; set; }
        [Column(TypeName = "decimal(18,2)")] public decimal Height { get; set; }
        public string HeightUnit { get; set; }
        [Column(TypeName = "decimal(18,2)")] public decimal Weight { get; set; }
        public string WeightUnit { get; set; }
        public string AmazonLink { get; set; }
        public string FlipkartLink { get; set; }
        [Column(TypeName = "money")] public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        public ICollection<ProductImages> Images { get; set; }
        public DateTime DateAvailable { get; set; }
        public bool Exclude { get; set; }
        public bool Featured { get; set; }
        public int? ReorderLevel { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }

    public class SubCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class ProductImages
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Cart
    {
        public ICollection<CartItem> Items { get; set; }
        public decimal Total { get; internal set; }
        public decimal Savings { get; internal set; }
    }

    public class CartItem
    {
        public int ItemId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int AvailableQuantity { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Subtotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ShippingCost { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
        public int BillingAddressId { get; set; }
        public string BillingAddressStreetnumber { get; set; }
        public string BillingAddressStreetname { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressZip { get; set; }
        public int ShippingAddressId { get; set; }
        public string ShippingAddressStreetnumber { get; set; }
        public string ShippingAddressStreetname { get; set; }
        public string ShippingAddressCity { get; set; }
        public string ShippingAddressState { get; set; }
        public string ShippingAddressZip { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public List<Product> OrderItems { get; set; }
        [NotMapped]
        public List<CartItem> CartItems { get; set; }
    }
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }
    }

    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        UPI
    }
    public class User : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Address> Addresses { get; set; }

        public string AuthToken { get; set; }
        public string IdToken { get; set; }
        public string PhotoUrl { get; set; }
        public string Provider { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Streetnumber { get; set; }
        public string Streetname { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phonenumber { get; set; }
    }
}