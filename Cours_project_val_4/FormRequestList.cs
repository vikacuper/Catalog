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
    public partial class FormRequestList : Form
    {
        public void CatalogListener(object source, MyEventArgs args)
        {

            Disk disk = (Disk)source;
            switch (args.Info)
            {              
                case "Del":
                    listViewRequestList.Items[args.Index].Remove();
                    break;
            }
        }
        public void Set(Catalog catalog)
        {
            this.Cat = catalog;
        }
        public Catalog Cat = new Catalog();
       
        public void SetTableData()
        {
            for (int i = 0; i < Cat.diskList.Count; i++)
            {
                listViewRequestList.Items.Add(Cat.diskList[i].Title).SubItems.Add(Cat.diskList[i].Description);
            }
        }
        public FormRequestList(Catalog catalog)
        {
            InitializeComponent();
            this.Set(catalog);
            SetTableData();
            Cat.CatalogEvent += CatalogListener;
          
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

        public void listViewRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonInf.Enabled = listViewRequestList.SelectedIndices.Count != 0;
            buttonDel.Enabled = listViewRequestList.SelectedIndices.Count != 0;
        }

        private void buttonInf_Click(object sender, EventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            int index = listViewRequestList.SelectedIndices[0];
            string title = listViewRequestList.Items[index].SubItems[0].Text;
            formRequest.DISK = Program.requests.GetDisk(title);
            formRequest.ShowDialog();
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int index = listViewRequestList.SelectedIndices[0];
            string title = listViewRequestList.Items[index].SubItems[0].Text;             
                 Cat.Del_disk(title);
        }
    }
}
