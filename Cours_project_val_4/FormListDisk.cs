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
    public partial class FormListDisk : Form
    {
        public Catalog Cat = new Catalog();
        public int count=0;
        public void Set(Catalog catalog)
        {
            Cat = catalog;
        }
        public Person person { get; set; }
        public void SetTableData()
        {
            for (int i = 0; i < Cat.diskList.Count; i++)
            {
                if(Cat.diskList[i].Number!=0)
              listViewRentalList.Items.Add(Cat.diskList[i].Title).SubItems.Add(Cat.diskList[i].Number.ToString());
            }
        }

        public FormListDisk(Catalog catalog)
        {
            InitializeComponent();  
            Set(catalog);
            SetTableData();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;           
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            FormRentalDisk formRentalDisk = new FormRentalDisk();
            int index = listViewRentalList.SelectedIndices[0];
            string title = listViewRentalList.Items[index].SubItems[0].Text;
            formRentalDisk.person = person;
            formRentalDisk.count = count;
            formRentalDisk.disk = Program.catalog.GetDisk(title);
            if (formRentalDisk.ShowDialog() == DialogResult.OK)
            {
                if (person.Add_Disk(formRentalDisk.rentalDisk))
                {
                    Program.catalog.ChangeDisk(title, formRentalDisk.disk);
                    count = formRentalDisk.count;
                    MessageBox.Show(count.ToString());
                }
                else
                    MessageBox.Show("You already have this Disk");
                    listViewRentalList.Items.Clear();
                SetTableData();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listViewRentalList.SelectedIndices[0];
            string title = listViewRentalList.Items[index].SubItems[0].Text;
            Disk wish = Program.catalog.GetDisk(title);
            person.Add_Disk_Wish(wish);
            MessageBox.Show(person.diskWish.Count.ToString());
        }
    }
}
