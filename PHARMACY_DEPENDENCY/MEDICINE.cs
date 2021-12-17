using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHARMACY_DEPENDENCY
{
    public class MEDICINE
    {
        public string medicineName;
        public double sellPrice, buyPrice;
        public int medicineAmount;

        public string getMedicineInfo()
        {
            string medName = Convert.ToString(medicineAmount);
            return medicineName + "\t\t\t"  + medName;
        }
    }
}
