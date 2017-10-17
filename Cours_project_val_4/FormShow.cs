using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_project_val_4
{
    [Serializable]
    public partial class FormShow : Form
    {
       public static List_Rental list_Rental = new List_Rental();
       public static List<Disk> wish = new List<Disk>();
        public Person person {
            get
            {
                try
                {
                    if (textBoxName.Text.Length < 3)
                        throw new Exception("Uncorrect name");
                    if (textBoxSurname.Text.Length < 3)
                        throw new Exception("Uncorrect Surname"); 
                    return new Person(textBoxName.Text, textBoxSurname.Text, textBoxTel.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            set
            {
                textBoxName.Text = value.Name;
                textBoxSurname.Text = value.Surname;
                textBoxTel.Text = value.Telefon_number;
            }
        }
        private void RentalListener(object source, MyEventArgs args)
        {
            RentalDisk rental = (RentalDisk)source;
            switch (args.Info)
            {
                case "Add":
                    listViewRentalList.Items.Add(rental.Title).SubItems.Add(rental.Period.ToShortDateString());
                    break;
                case "Change":
                    listViewRentalList.Items[args.Index].SubItems[0].Text = person.Name;
                    listViewRentalList.Items[args.Index].SubItems[1].Text = person.Surname;
                    break;
                case "Del":
                    listViewRentalList.Items[args.Index].Remove();
                    break;
            }
        }

        internal List_Rental List_Rental
        {
            get
            {
                return list_Rental;
            }
            set
            {
                list_Rental = value;
            }
        }
        internal List<Disk> Wish
        {
            get
            {
                return wish;
            }
            set
            {
                wish = value;
            }
        }
        private void PersonListener(object source, MyEventArgs args)
        {
            Person person = (Person)source;
            switch (args.Info)
            {
              
                case "Change":
                    textBoxName.Text = person.Name;
                    textBoxSurname.Text = person.Surname;
                    break;
                
            }
        }

       
        public void SetTableData()
        {
          foreach (RentalDisk Rental in List_Rental.list_rental)
                listViewRentalList.Items.Add(Rental.Title).SubItems.Add(Rental.Period.ToShortDateString());
            for(int i=0; i<wish.Count; i++)
                listView1.Items.Add(wish[i].Title);
        }
        public FormShow()
        {
            InitializeComponent();
           list_Rental.List_RentalEvent += RentalListener;
           buttonReturn.Enabled = listViewRentalList.SelectedIndices.Count != 0;
            SetTableData();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            FormListDisk formListDisk = new FormListDisk(Program.catalog);
            formListDisk.person = person;
            formListDisk.count = Program.list_person.GetPerson(textBoxName.Text, textBoxSurname.Text).Count;
            if (formListDisk.ShowDialog() == DialogResult.OK)
            {
                Program.list_person.ChangeInf(textBoxName.Text, textBoxSurname.Text, formListDisk.person);
                Program.list_person.GetPerson(textBoxName.Text, textBoxSurname.Text).Count = formListDisk.count;
                foreach (RentalDisk Rental in Program.list_person.GetPerson(textBoxName.Text, textBoxSurname.Text).disks)
                   List_Rental.Add_Disk(Rental);
                foreach (Disk Rental in Program.list_person.GetPerson(textBoxName.Text, textBoxSurname.Text).diskWish)
                    wish.Add(Rental);
            }
            SetTableData();
        }
        int number;
        public void ReturnDisk()
        {
                number++;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {           
                int index = listViewRentalList.SelectedIndices[0];
                string title = listViewRentalList.Items[index].SubItems[0].Text;
            Program.list_person.GetPerson(textBoxName.Text, textBoxSurname.Text).Del_Rental(title);
            Disk disk = Program.catalog.GetDisk(title);
            number = disk.Number;
            ReturnDisk();
            disk.Number = number;
            Program.catalog.ChangeDisk(title, disk);
            list_Rental.Del_Rental(title);
        }

        private void listViewRentalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonReturn.Enabled = listViewRentalList.SelectedIndices.Count != 0;
        }
    }
}
