namespace Cours_project_val_4
{
    partial class FormShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewRentalList = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.buttonRent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(147, 337);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(229, 337);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listViewRentalList
            // 
            this.listViewRentalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderPeriod});
            this.listViewRentalList.FullRowSelect = true;
            this.listViewRentalList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRentalList.HideSelection = false;
            this.listViewRentalList.LabelWrap = false;
            this.listViewRentalList.Location = new System.Drawing.Point(24, 102);
            this.listViewRentalList.MultiSelect = false;
            this.listViewRentalList.Name = "listViewRentalList";
            this.listViewRentalList.ShowGroups = false;
            this.listViewRentalList.Size = new System.Drawing.Size(280, 97);
            this.listViewRentalList.TabIndex = 2;
            this.listViewRentalList.UseCompatibleStateImageBehavior = false;
            this.listViewRentalList.View = System.Windows.Forms.View.Details;
            this.listViewRentalList.SelectedIndexChanged += new System.EventHandler(this.listViewRentalList_SelectedIndexChanged);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 146;
            // 
            // columnHeaderPeriod
            // 
            this.columnHeaderPeriod.Text = "Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telephone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rental Dist:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(122, 39);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(122, 65);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel.TabIndex = 9;
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(24, 308);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(107, 23);
            this.buttonRent.TabIndex = 10;
            this.buttonRent.Text = "Rent a disk";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(197, 308);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(107, 23);
            this.buttonReturn.TabIndex = 11;
            this.buttonReturn.Text = "Return a disk";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(24, 205);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(280, 97);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 146;
            // 
            // FormShow
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(318, 402);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewRentalList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewRentalList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderPeriod;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}