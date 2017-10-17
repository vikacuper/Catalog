namespace Cours_project_val_4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAdd_new = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.buttonListRequest = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerNow = new System.Windows.Forms.DateTimePicker();
            this.listViewListPerson = new System.Windows.Forms.ListView();
            this.ColumnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddDisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd_new
            // 
            this.buttonAdd_new.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.buttonAdd_new.Location = new System.Drawing.Point(306, 13);
            this.buttonAdd_new.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd_new.Name = "buttonAdd_new";
            this.buttonAdd_new.Size = new System.Drawing.Size(122, 40);
            this.buttonAdd_new.TabIndex = 0;
            this.buttonAdd_new.Text = "Add new";
            this.buttonAdd_new.UseVisualStyleBackColor = true;
            this.buttonAdd_new.Click += new System.EventHandler(this.buttonAdd_new_Click);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(306, 61);
            this.buttonRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(122, 40);
            this.buttonRequest.TabIndex = 1;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonListRequest
            // 
            this.buttonListRequest.Location = new System.Drawing.Point(308, 370);
            this.buttonListRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListRequest.Name = "buttonListRequest";
            this.buttonListRequest.Size = new System.Drawing.Size(122, 40);
            this.buttonListRequest.TabIndex = 2;
            this.buttonListRequest.Text = "Requests";
            this.buttonListRequest.UseVisualStyleBackColor = true;
            this.buttonListRequest.Click += new System.EventHandler(this.buttonListRequest_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Enabled = false;
            this.buttonShow.Location = new System.Drawing.Point(16, 322);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(118, 40);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(164, 322);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerNow
            // 
            this.dateTimePickerNow.Location = new System.Drawing.Point(16, 383);
            this.dateTimePickerNow.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNow.Name = "dateTimePickerNow";
            this.dateTimePickerNow.Size = new System.Drawing.Size(266, 27);
            this.dateTimePickerNow.TabIndex = 5;
            // 
            // listViewListPerson
            // 
            this.listViewListPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderName,
            this.ColumnHeaderSurname});
            this.listViewListPerson.FullRowSelect = true;
            this.listViewListPerson.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListPerson.LabelWrap = false;
            this.listViewListPerson.Location = new System.Drawing.Point(16, 13);
            this.listViewListPerson.Margin = new System.Windows.Forms.Padding(4);
            this.listViewListPerson.MultiSelect = false;
            this.listViewListPerson.Name = "listViewListPerson";
            this.listViewListPerson.ShowGroups = false;
            this.listViewListPerson.Size = new System.Drawing.Size(266, 292);
            this.listViewListPerson.TabIndex = 6;
            this.listViewListPerson.UseCompatibleStateImageBehavior = false;
            this.listViewListPerson.View = System.Windows.Forms.View.Details;
            this.listViewListPerson.SelectedIndexChanged += new System.EventHandler(this.listViewListPerson_SelectedIndexChanged);
            // 
            // ColumnHeaderName
            // 
            this.ColumnHeaderName.Text = "Name";
            this.ColumnHeaderName.Width = 113;
            // 
            // ColumnHeaderSurname
            // 
            this.ColumnHeaderSurname.Text = "Surname";
            this.ColumnHeaderSurname.Width = 145;
            // 
            // buttonAddDisk
            // 
            this.buttonAddDisk.Location = new System.Drawing.Point(308, 322);
            this.buttonAddDisk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDisk.Name = "buttonAddDisk";
            this.buttonAddDisk.Size = new System.Drawing.Size(122, 40);
            this.buttonAddDisk.TabIndex = 7;
            this.buttonAddDisk.Text = "Add Disk";
            this.buttonAddDisk.UseVisualStyleBackColor = true;
            this.buttonAddDisk.Click += new System.EventHandler(this.buttonAddDisk_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 417);
            this.Controls.Add(this.buttonAddDisk);
            this.Controls.Add(this.listViewListPerson);
            this.Controls.Add(this.dateTimePickerNow);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonListRequest);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.buttonAdd_new);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Rental Disk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd_new;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonListRequest;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerNow;
        private System.Windows.Forms.ListView listViewListPerson;
        private System.Windows.Forms.ColumnHeader ColumnHeaderName;
        private System.Windows.Forms.ColumnHeader ColumnHeaderSurname;
        private System.Windows.Forms.Button buttonAddDisk;
    }
}

