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
    public partial class FormRequest : Form
    {
        public Disk DISK
        {
            get
            {
                try
                {
                    int c;

                    if (!int.TryParse(textBoxNumber.Text, out c)&&Convert.ToInt16(textBoxNumber.Text)<=0)
                        throw new Exception("Uncorrect Number of Disk");
                       return new Disk(textBoxTitle.Text, Convert.ToInt32(textBoxNumber.Text), textBoxDescription.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                
            }
            set
            {
                textBoxTitle.Text = value.Title;
                textBoxNumber.Text = Convert.ToString(value.Number);
                textBoxDescription.Text = value.Description;
            }
        }
        public FormRequest()
        {
            InitializeComponent();
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            if (DISK != null)
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
    }
}
