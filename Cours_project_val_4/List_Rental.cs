using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Cours_project_val_4
{
    public delegate void List_RentalEvent(object source, MyEventArgs args);
    [Serializable]
   public class List_Rental
    {
        public List<RentalDisk> list_rental = new List<RentalDisk>();

        public Action<object, MyEventArgs> List_PersonEvent { get; internal set; }

        public event List_RentalEvent List_RentalEvent;
        public RentalDisk GetRentalDisk(string title)
        {
            return list_rental.Find(disk => disk.Title == title);
        }
        public bool Del_Rental(string title)
        {
            RentalDisk rental = list_rental.Find(disk => disk.Title == title);
            int index = list_rental.IndexOf(rental);
            if (list_rental.Remove(rental))
            {
                List_RentalEvent.Invoke(rental, new MyEventArgs("Del", index));
                return true;
            }
            else return false;
           
        }
        public bool Change_Renal(string title, RentalDisk newDisk)
        {
            if (list_rental.Exists(disk => disk.Title == newDisk.Title))
                return false;
            RentalDisk oldDisk = list_rental.Find(disk => disk.Title == title);
            if (oldDisk == null)
                return false;
            int index = list_rental.IndexOf(oldDisk);
            oldDisk.Title = newDisk.Title;
            oldDisk.Status = newDisk.Status;
            oldDisk.Number = newDisk.Number;
            oldDisk.Description = newDisk.Description;
            oldDisk.price = newDisk.price;
            oldDisk.Period = newDisk.Period;
            List_RentalEvent.Invoke(newDisk, new MyEventArgs("Change", index));
            return true;
        }
        public bool Add_Disk(RentalDisk newDisk)
        {
            if (list_rental.Exists(disk => disk.Title == newDisk.Title))
                return false;
            list_rental.Add(newDisk);
            List_RentalEvent.Invoke(newDisk, new MyEventArgs("Add", -1));
            return true;
        }
        public override string ToString()
        {
            if (list_rental != null)
            {
                string str = "";
                foreach (RentalDisk r in list_rental)
                    str += r.ToString();
                return str;
            }
            return "No rental list";
        }
        public bool Save1()
        {
            FileStream fs = new FileStream("Rental_list", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException)
            {
                throw;
            }
            finally
            {
                fs.Close();
            }
            return true;
        }
        public bool Load1()
        {
            FileStream fs = new FileStream("Rental_list", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                List_Rental listRental = (List_Rental)formatter.Deserialize(fs);
                list_rental = listRental.list_rental;
            }
            catch (SerializationException)
            {

                throw;
            }
            finally
            {
                fs.Close();
            }

            return true;
        }
    }
}
