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
   public class Disk
    {
       public string Title
        {
            get; set;
        }
       public bool Status
        {
            get; set;
        }
       public int Number
        {
            get; set;
        }
       public string Description
        {
            get; set;
        }
        public Disk(string title, int number, string description)
        {
            Title = title;
            Number = number;
            Status = true;
            Description = description;
        }
    }
}
