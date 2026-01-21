using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PMS.Models
{
    public class SaleDetails
    {
        // Properties matching the table columns
        public int SaleDetailId { get; set; }    // Primary Key
        public int SaleId { get; set; }          // Foreign Key to Sale
        public int MId { get; set; }             // Foreign Key to Medicine
      //  public string MName { get; set; }        // Medicine Name at time of sale
        public int Quantity { get; set; }        // Quantity sold
        public decimal PricePerUnit { get; set; } // Price at time of sale

        // Default constructor
        public SaleDetails()
        {
        }

        // Parameterized constructor
        public SaleDetails(int saleId, int mId,  int quantity, decimal pricePerUnit)
        {
            SaleId = saleId;
            MId = mId;
          //  MName = mName;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

        // Optional: calculate total price for this sale detail
        public decimal TotalPrice()
        {
            return Quantity * PricePerUnit;
        }
    }
}

