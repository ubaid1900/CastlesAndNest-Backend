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

    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        [Column(TypeName = "money")] public decimal Price { get; set; }

        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        public int AvailableQuantity { get; set; }
        public ICollection<BookImages> Images { get; set; }
        public bool Exclude { get; set; }
        public int ReorderLevel { get; set; }
    }

    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BookImages
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Cart
    {
        public ICollection<CartItem> Items { get; set; }
        public decimal Total { get; internal set; }
        public decimal Savings { get; internal set; }
    }

    public class CartItemBase
    {
        public CartItemType ItemType { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }

    public class CartItem : CartItemBase
    {
        public CartItem(CartItemBase cartItemBase)
        {
            ItemType = cartItemBase.ItemType;
            ItemId = cartItemBase.ItemId;
            Quantity = cartItemBase.Quantity;
        }
        public decimal BookPrice { get; set; }
        public OfferPricingDetails OfferPricingDetails { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int AvailableQuantity { get; set; }
    }

    public class OfferPricingDetails
    {
        public decimal PriceBeforeDiscount { get; set; }
        public decimal PriceAfterDiscount { get; set; }
        public decimal SavingsAmount { get; set; }
    }

    public enum CartItemType
    {
        Book,
        Offer
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
        public List<OrderBookItem> BookItems { get; set; }
        public List<OrderOfferItem> OfferItems { get; set; }
        [NotMapped]
        public List<CartItemBase> Items { get; set; }
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
    public class OrderBookItem
    {
        public int OrderId { get; set; }
        // TODO:https://stackoverflow.com/questions/65873276/createdataction-returns-500-on-success#comment116486452_65875132
        //public Order Order { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
    public class OrderOfferItem
    {
        public int OrderId { get; set; }
        // TODO:https://stackoverflow.com/questions/65873276/createdataction-returns-500-on-success#comment116486452_65875132
        //public Order Order { get; set; } 
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        // field to save book ids and their prices at the order time
        public string OfferDetails { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercentage { get; set; }
    }

    public class Offer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Starts { get; set; }
        public DateTime? Deadline { get; set; }
        public int DiscountPercentage { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<OfferItem> OfferItems { get; set; }
    }
    public class OfferItem
    {
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
    public class Author
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
    }
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
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