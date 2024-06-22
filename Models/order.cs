using System;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

public class Order
{
    [Key]
    public int OrderId { get; set; }

    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime OrderDate { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }

    // Navigation properties
    public User User { get; set; }
    public Product Product { get; set; }
}
