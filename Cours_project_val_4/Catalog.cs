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
    public delegate void CatalogEvent(object source, MyEventArgs args);
    [Serializable]
    public class  Catalog
    {
        public List<Disk> diskList=new List<Disk>();
        MemoryStream stream;
        public event CatalogEvent CatalogEvent;
        public Disk GetDisk(string title)
        {
            return diskList.Find(disk => disk.Title == title);
        }
        
        public bool Del_disk(string title)
        {
            Disk disk = diskList.Find(disks => disks.Title == title);
            int index = diskList.IndexOf(disk);
            if (diskList.Remove(disk))
            {
                CatalogEvent.Invoke(disk, new MyEventArgs("Del", index));
                return true;
            }
            else return false;         
        }
        public bool Change_disk(string title, Disk newDisk)
        {
            if (diskList.Exists(disk => disk.Title == newDisk.Title))
                return false;
            Disk oldDisk = diskList.Find(disk => disk.Title == title);
            if (oldDisk == null)
                return false;
            int index = diskList.IndexOf(oldDisk);
            oldDisk.Title = newDisk.Title;
            oldDisk.Status = newDisk.Status;
            oldDisk.Number = newDisk.Number;
            oldDisk.Description = newDisk.Description;
            CatalogEvent.Invoke(newDisk, new MyEventArgs("Change", index));
            return true;
        }
        public bool ChangeDisk(string title, Disk newDisk)
        {
          
            Disk oldDisk = diskList.Find(disk => disk.Title == title);
            if (oldDisk == null)
                return false;
            int index = diskList.IndexOf(oldDisk);
            oldDisk.Title = newDisk.Title;
            oldDisk.Status = newDisk.Status;
            oldDisk.Number = newDisk.Number;
            oldDisk.Description = newDisk.Description;
            return true;
        }
        public bool Add_Disk(Disk newDisk)
        {
            if (diskList.Exists(disk => disk.Title == newDisk.Title))
                return false;
            diskList.Add(newDisk);
         
            return true;
        }
       

        public object DeepCopy()
        {
            Catalog NewList = new Catalog();
            if (diskList != null) NewList.diskList.AddRange(this.diskList);
            return NewList;
        }
        public MemoryStream SerializeToStream(object o)
        {
            MemoryStream stream1 = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream1, o);
            return stream1;
        }
        public void SDeepCopt()
        {
            stream = SerializeToStream(this.DeepCopy());
        }
        public bool Save(string filename)
        {
            Catalog s = DeepCopy() as Catalog;
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    formatter.Serialize(fs, s);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Load(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    Catalog newS = (Catalog)formatter.Deserialize(fs);
                    this.diskList = newS.diskList;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
