using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Cours_project_val_4
{
    [Serializable]
    public class RentalDisk:Disk
    {
  
        public DateTime Period
        {
            get; set;
        }
   
public double price
        {
            get; set;
        }
        public RentalDisk(string title, int number, string description, DateTime date,  double pr):base (title, number, description)
        {
           
            Period = date;
            price = pr;
        } 

    }
}
