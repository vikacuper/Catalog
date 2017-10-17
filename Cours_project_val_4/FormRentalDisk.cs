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
    public partial class FormRentalDisk : Form
    {
        public int count = 0;
            int number = 0;
        public Disk disk
        {
            get
            {
               
                return new Disk(textBoxTitle.Text, number, textBoxDescription.Text);
            }
            set
            {
                textBoxTitle.Text = value.Title;
                textBoxDescription.Text = value.Description;
                number = value.Number;
            }
        }
        public void TakeDisk()
        {
            if (number > 0)
                number--;
        }
        public RentalDisk rentalDisk
        {
            get
            { try
                {
                    double c;
                    DateTime k;
                    if (!Double.TryParse(textBoxCost.Text, out c))
                        throw new Exception("Cost must be double");
                    if (count >= 5)
                        textBoxCost.Text =Convert.ToString(Convert.ToDouble(textBoxCost.Text)*0.15);
                    k = Convert.ToDateTime(dateTimePickerPeriod.Text);
                    if (k <= Program.DateNow)
                        throw new Exception("Unccorect date");
                     return new RentalDisk(textBoxTitle.Text, 1, textBoxDescription.Text, dateTimePickerPeriod.Value, Convert.ToDouble(textBoxCost.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null; 

                }
               
            }
        }
        public Person person
        { get; set; }

        public FormRentalDisk()
        {
            InitializeComponent();
            buttonOK.Enabled = true;


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {   
            if (rentalDisk != null)
            {
                TakeDisk();
                count++;
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
