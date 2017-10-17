using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cours_project_val_4
{
  
    public partial class FormMain : Form
    {
 
        public  void dateNow()
        {
            Program.DateNow = dateTimePickerNow.Value;
        }

        private void PersonListener(object source, MyEventArgs args)
        {
            Person person = (Person)source;
            switch(args.Info)
            {
                case "Add":
                    listViewListPerson.Items.Add(person.Name).SubItems.Add(person.Surname);
                    break;
                case "Change":
                    listViewListPerson.Items[args.Index].SubItems[0].Text = person.Name;
                    listViewListPerson.Items[args.Index].SubItems[1].Text = person.Surname;
                    break;
                case "Del":
                    listViewListPerson.Items[args.Index].Remove();
                    break;
            }
        }
        private void Show_()
        {
            for (int i = 0; i < Program.list_person.Persons.Count; ++i)
                listViewListPerson.Items.Add(Program.list_person.Persons[i].Name).SubItems.Add(Program.list_person.Persons[i].Surname);
        }
        public FormMain()
        {
            InitializeComponent();
            if (File.Exists("Person_list.txt"))
                Program.list_person.Load("Person_list.txt");
            if (File.Exists("Catalog.txt"))
                Program.catalog.Load("Catalog.txt");
            if (File.Exists("Reguests.txt"))
                Program.requests.Load("Reguests.txt");
            Show_();
            dateNow(); 
            Program.list_person.List_PersonEvent += PersonListener;
            buttonDelete.Enabled = listViewListPerson.SelectedIndices.Count != 0;
        }
        
        private void listViewListPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonShow.Enabled = listViewListPerson.SelectedIndices.Count != 0;
            buttonDelete.Enabled = listViewListPerson.SelectedIndices.Count != 0;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {   dateNow();
            FormShow.list_Rental = new List_Rental();
            FormShow.wish = new List<Disk>();
            int index = listViewListPerson.SelectedIndices[0];
            string name = listViewListPerson.Items[index].SubItems[0].Text;
            string surname = listViewListPerson.Items[index].SubItems[1].Text;
            if (Program.list_person.GetPerson(name, surname).disks.Count != 0)
                foreach (RentalDisk Rental in Program.list_person.GetPerson(name, surname).disks)
                FormShow.list_Rental.Add_Disk(Rental);
            if (Program.list_person.GetPerson(name, surname).diskWish.Count != 0)
                foreach (Disk Rental in Program.list_person.GetPerson(name, surname).diskWish)
                FormShow.wish.Add(Rental);
            FormShow formshow = new FormShow();
          
            formshow.person = Program.list_person.GetPerson(name, surname);
           
            foreach (RentalDisk Rent in Program.list_person.GetPerson(name, surname).disks)
                if (Rent.Period < Program.DateNow)
                { MessageBox.Show(this, "You don't return disk at time", Text, MessageBoxButtons.OK, MessageBoxIcon.Information); break; }       
            if (formshow.ShowDialog() == DialogResult.OK)
                Program.list_person.Change_Inf(name, surname, formshow.person);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listViewListPerson.SelectedIndices[0];
            string name = listViewListPerson.Items[index].SubItems[0].Text;
            string surname = listViewListPerson.Items[index].SubItems[1].Text;
            Program.list_person.Del_person(name, surname);
        }

        private void buttonAdd_new_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            if (formAddNew.ShowDialog() == DialogResult.OK)
                if (!Program.list_person.Add_Person(formAddNew.person))
                    MessageBox.Show(this, "This Person is already exist", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            if (formRequest.ShowDialog() == DialogResult.OK)
            {
                Program.requests.Add_Disk(formRequest.DISK);
               
            }
        }

        private void buttonListRequest_Click(object sender, EventArgs e)
        {
            FormRequestList formRequestList = new FormRequestList(Program.requests);               
            formRequestList.ShowDialog();
        }

        private void buttonAddDisk_Click(object sender, EventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            if (formRequest.ShowDialog() == DialogResult.OK)
            {
                Program.catalog.Add_Disk(formRequest.DISK);
                
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.list_person.Save("Person_list.txt");
            Program.catalog.Save("Catalog.txt");
            Program.requests.Save("Reguests.txt");
        }
    }
}