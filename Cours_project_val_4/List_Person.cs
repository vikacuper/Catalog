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
    public delegate void List_PersonEvent(object source, MyEventArgs args);
    [Serializable]
    public class List_Person
    {
        public List<Person> Persons = new List<Person>();
        MemoryStream stream;
        public event List_PersonEvent List_PersonEvent;

      
        public Person GetPerson(string name, string surname)
        {
            return Persons.Find(pers => pers.Name == name && pers.Surname == surname);
        }
        public bool Add_Person( Person p)
        {
            if (Persons.Exists(person => person.Name == p.Name && person.Surname == p.Surname))
                return false;
            Persons.Add(p);
            List_PersonEvent.Invoke(p, new MyEventArgs("Add", -1));
            return true;
        }
        public bool Del_person( string name, string surname)
        {
            Person person = Persons.Find(pers => pers.Name == name && pers.Surname == surname);
            int index = Persons.IndexOf(person);
            if (Persons.Remove(person))
            {
                List_PersonEvent.Invoke(person, new MyEventArgs("Del", index));
                return true;
            }
            else return false;
        }
        public bool Change_Inf(string name, string surname, Person newPerson)
        {
            if (Persons.Exists(pers => pers.Name == newPerson.Name && pers.Surname == newPerson.Surname))
                return false;
            Person oldPerson = Persons.Find(pers => pers.Name == name && pers.Surname == surname);
            if (oldPerson == null)
                return false;
            int index = Persons.IndexOf(oldPerson);
            oldPerson.Name = newPerson.Name;
            oldPerson.Surname = newPerson.Surname;
            oldPerson.Telefon_number = newPerson.Telefon_number;
            oldPerson.Count = newPerson.Count;
            oldPerson.disks = newPerson.disks;
            oldPerson.diskWish = newPerson.diskWish;
            List_PersonEvent.Invoke(newPerson, new MyEventArgs("Change", index));
            return true;
        }
        public bool ChangeInf(string name, string surname, Person newPerson)
        {
            Person oldPerson = Persons.Find(pers => pers.Name == name && pers.Surname == surname);
            if (oldPerson == null)
                return false;
            int index = Persons.IndexOf(oldPerson);
            oldPerson.Name = newPerson.Name;
            oldPerson.Surname = newPerson.Surname;
            oldPerson.Telefon_number = newPerson.Telefon_number;
            oldPerson.Count = newPerson.Count;
            oldPerson.disks = newPerson.disks;
            oldPerson.diskWish = newPerson.diskWish;
            List_PersonEvent.Invoke(newPerson, new MyEventArgs("Change", index));
            return true;
        }
      
        public object DeepCopy()
        {
            List_Person NewList = new List_Person();
            if (Persons != null) NewList.Persons.AddRange(this.Persons);
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
            List_Person s = DeepCopy() as List_Person;
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
                    List_Person newS = (List_Person)formatter.Deserialize(fs);
                    this.Persons = newS.Persons;
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
