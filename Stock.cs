using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class Stock
    {
        private int stockId;
        private int medicineId;
        private int quantity;

        public int StockId
        {
            get { return stockId; }
            set { stockId = value; }
        }

        public int MedicineId
        {
            get { return medicineId; }
            set { medicineId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        

        public Stock() { }

        public Stock(int medicineId, int quantity)
        {
            this.medicineId = medicineId;
            this.quantity = quantity;
        }
    }
}
