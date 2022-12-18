using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace spoofer
{
    class customer
    {
        public string Name { get; set; }
        public string date { get; set; }
        public string subk1 { get; set; }


        public static bool IsEqual(customer cst1, customer cst2)
        {
                if (cst1 == null || cst2 == null) { return false; }
                if (cst1.subk1 == cst2.subk1) { return true; }
                return false;
            
        }

        public static bool IsExpire(customer cst1)
        {
            //Date of client registration
            DateTime ValidDate = Convert.ToDateTime(cst1.date);

            //Date Now
            var today = DateTime.Now;

            //get difference of two dates
            var diffOfDates = ValidDate.Subtract(today);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            //MessageBox.Show(diffOfDates.ToString()+today+ValidDate);
            if ((int)diffOfDates.TotalDays < 0)
            {
                return false;
            }
            return true;
        }
    }
}
