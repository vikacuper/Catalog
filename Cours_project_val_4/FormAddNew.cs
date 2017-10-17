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
  
    public partial class FormAddNew : Form
    {
        public Person person {
            get
            {
                try
                {
                    if (textBoxName.Text.Length < 3) 
                        throw new Exception("Uncorrect name");
                    if(textBoxSurname.Text.Length < 3)
                        throw new Exception("Uncorrect Surname");
                    if(textBoxTel.Text.Length != textBoxTel.Mask.Length)
                        throw new Exception("Uncorrect Telephone number");
                 return new Person(textBoxName.Text, textBoxSurname.Text, textBoxTel.Text);
                }
                catch(Exception ex)
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
        public FormAddNew()
        {
            InitializeComponent();
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

        private void textBoxTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (textBoxTel.Text.Length != textBoxTel.Mask.Length || textBoxSurname.Text.Length < 3 || textBoxName.Text.Length < 3)
            //    buttonOK.Enabled = false;
            //else
            //    buttonOK.Enabled = true;
        }
    }
}
