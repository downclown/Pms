
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class Medicine
    {
        private int mId;
        private string mName;
        private string mCompanyName;
        private string mDate;
        private string eDate;
        private int quantity;
        private decimal pricePerUnit;

        public int MId { get => mId; set => mId = value; }
        public string MName { get => mName; set => mName = value; }
        public string MCompanyName { get => mCompanyName; set => mCompanyName = value; }
        public string MDate { get => mDate; set => mDate = value; }
        public string EDate { get => eDate; set => eDate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal PricePerUnit { get => pricePerUnit; set => pricePerUnit = value; }

        public Medicine()
        {
        }

        public Medicine(int mId, string mName, string mCompanyName, string mDate, string eDate, int quantity, decimal pricePerUnit)
        {

            this.MId = mId;
            this.MName = mName;
            this.MCompanyName = mCompanyName;
            this.MDate = mDate;
            this.EDate = eDate;
            this.Quantity = quantity;
            this.PricePerUnit = pricePerUnit;
        }
    }
}
