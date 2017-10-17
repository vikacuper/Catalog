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
    public class Person
    {
        public string Name {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        public string Telefon_number
        {
            get; set;
        }
        public int Count
        {
            get; set;
        }
        public List<RentalDisk> disks
        {
            get; set;
        }
        public List<Disk> diskWish
        {
            get; set;
        }
        public Person(string name_, string surname_, string tel_)
        {
            Name = name_;
            Surname = surname_;
            Telefon_number = tel_;
            Count = 0;
            disks = new List<RentalDisk>();
            diskWish = new List<Disk>();
        }
        public RentalDisk GetRentalDisk(string title)
        {
            Count++;
            return disks.Find(disk => disk.Title == title);
        }
        public bool Del_Rental(string title)
        {
            return disks.Remove(disks.Find(disk => disk.Title == title));
        }
        public bool Change_Renal(string title, RentalDisk newDisk)
        {
            if (disks.Exists(disk => disk.Title == newDisk.Title))
                return false;
            RentalDisk oldDisk = disks.Find(disk => disk.Title == title);
            if (oldDisk == null)
                return false;
            oldDisk.Title = newDisk.Title;
            oldDisk.Status = newDisk.Status;
            oldDisk.Number = newDisk.Number;
            oldDisk.Description = newDisk.Description;
            oldDisk.price = newDisk.price;
            oldDisk.Period = newDisk.Period;
            return true;
        }

        public int C_()
        {
            return (++Count);
        }
        public bool Add_Disk(RentalDisk newDisk)
        {
            if (disks.Exists(disk => disk.Title == newDisk.Title))
                return false;
            Count = C_();
            disks.Add(newDisk);
            return true;
        }
        public bool Add_Disk_Wish(Disk newDisk)
        {
            if (disks.Exists(disk => disk.Title == newDisk.Title))
                return false;
            Count = C_();
            diskWish.Add(newDisk);
            return true;
        }
    }
}
