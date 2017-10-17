namespace Cours_project_val_4
{
    partial class FormListDisk
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
            this.columnHeaderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(242, 435);
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
            this.buttonCancel.Location = new System.Drawing.Point(337, 435);
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
            this.columnHeaderCount});
            this.listViewRentalList.FullRowSelect = true;
            this.listViewRentalList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRentalList.HideSelection = false;
            this.listViewRentalList.LabelWrap = false;
            this.listViewRentalList.Location = new System.Drawing.Point(24, 51);
            this.listViewRentalList.MultiSelect = false;
            this.listViewRentalList.Name = "listViewRentalList";
            this.listViewRentalList.ShowGroups = false;
            this.listViewRentalList.Size = new System.Drawing.Size(377, 335);
            this.listViewRentalList.TabIndex = 2;
            this.listViewRentalList.UseCompatibleStateImageBehavior = false;
            this.listViewRentalList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 174;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Number";
            this.columnHeaderCount.Width = 197;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rental list:";
            // 
            // buttonRent
            // 
            this.buttonRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRent.Location = new System.Drawing.Point(28, 392);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(143, 37);
            this.buttonRent.TabIndex = 10;
            this.buttonRent.Text = "Rent a disk";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(242, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Wish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListDisk
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(424, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewRentalList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListDisk";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderCount;
        private System.Windows.Forms.Button button1;
    }
}