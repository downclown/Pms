using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class Sale
    {
        private int saleId;
        private string customerName;
        private decimal totalAmount;
        private string date;

        public int SaleId { get { return saleId; } set { saleId = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public decimal TotalAmount { get {  return totalAmount; } set { totalAmount = value; } }
        public string Date { get { return date; } set { date = value; } }


        public Sale( string customerName, decimal totalAmount, string date)
            
        {
            this.CustomerName = customerName;
            this.TotalAmount = totalAmount;
            this.Date = date;
            
        }
    }
}
