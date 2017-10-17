namespace Cours_project_val_4
{
    partial class FormRequestList
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
            this.listViewRequestList = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInf = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(147, 255);
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
            this.buttonCancel.Location = new System.Drawing.Point(229, 255);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listViewRequestList
            // 
            this.listViewRequestList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderDescr});
            this.listViewRequestList.FullRowSelect = true;
            this.listViewRequestList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRequestList.LabelWrap = false;
            this.listViewRequestList.Location = new System.Drawing.Point(13, 47);
            this.listViewRequestList.MultiSelect = false;
            this.listViewRequestList.Name = "listViewRequestList";
            this.listViewRequestList.ShowGroups = false;
            this.listViewRequestList.Size = new System.Drawing.Size(280, 152);
            this.listViewRequestList.TabIndex = 2;
            this.listViewRequestList.UseCompatibleStateImageBehavior = false;
            this.listViewRequestList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // columnHeaderDescr
            // 
            this.columnHeaderDescr.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rental list:";
            // 
            // buttonInf
            // 
            this.buttonInf.Location = new System.Drawing.Point(28, 205);
            this.buttonInf.Name = "buttonInf";
            this.buttonInf.Size = new System.Drawing.Size(107, 23);
            this.buttonInf.TabIndex = 10;
            this.buttonInf.Text = "Information";
            this.buttonInf.UseVisualStyleBackColor = true;
            this.buttonInf.Click += new System.EventHandler(this.buttonInf_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(186, 205);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(107, 23);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormRequestList
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(318, 304);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonInf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewRequestList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRequestList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewRequestList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInf;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDescr;
    }
}