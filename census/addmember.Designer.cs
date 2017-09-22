namespace census
{
    partial class addmember
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
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.cnictextbox = new System.Windows.Forms.TextBox();
            this.btAddCitizen = new System.Windows.Forms.Button();
            this.textboxlabel = new System.Windows.Forms.Label();
            this.cniclabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.provincelabel = new System.Windows.Forms.Label();
            this.cbMaleFemale = new System.Windows.Forms.ComboBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(113, 48);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(120, 20);
            this.nametextbox.TabIndex = 0;
            this.nametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cnictextbox
            // 
            this.cnictextbox.Location = new System.Drawing.Point(113, 91);
            this.cnictextbox.Name = "cnictextbox";
            this.cnictextbox.Size = new System.Drawing.Size(120, 20);
            this.cnictextbox.TabIndex = 1;
            // 
            // btAddCitizen
            // 
            this.btAddCitizen.Location = new System.Drawing.Point(71, 208);
            this.btAddCitizen.Name = "btAddCitizen";
            this.btAddCitizen.Size = new System.Drawing.Size(75, 23);
            this.btAddCitizen.TabIndex = 4;
            this.btAddCitizen.Text = "Add Citizen";
            this.btAddCitizen.UseVisualStyleBackColor = true;
            this.btAddCitizen.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxlabel
            // 
            this.textboxlabel.AutoSize = true;
            this.textboxlabel.Location = new System.Drawing.Point(12, 55);
            this.textboxlabel.Name = "textboxlabel";
            this.textboxlabel.Size = new System.Drawing.Size(60, 13);
            this.textboxlabel.TabIndex = 7;
            this.textboxlabel.Text = "enter name";
            // 
            // cniclabel
            // 
            this.cniclabel.AutoSize = true;
            this.cniclabel.Location = new System.Drawing.Point(12, 98);
            this.cniclabel.Name = "cniclabel";
            this.cniclabel.Size = new System.Drawing.Size(54, 13);
            this.cniclabel.TabIndex = 8;
            this.cniclabel.Text = "enter cnic";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Location = new System.Drawing.Point(11, 125);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(67, 13);
            this.genderlabel.TabIndex = 9;
            this.genderlabel.Text = "enter gender";
            // 
            // provincelabel
            // 
            this.provincelabel.AutoSize = true;
            this.provincelabel.Location = new System.Drawing.Point(11, 170);
            this.provincelabel.Name = "provincelabel";
            this.provincelabel.Size = new System.Drawing.Size(79, 13);
            this.provincelabel.TabIndex = 10;
            this.provincelabel.Text = "select province";
            // 
            // cbMaleFemale
            // 
            this.cbMaleFemale.FormattingEnabled = true;
            this.cbMaleFemale.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbMaleFemale.Location = new System.Drawing.Point(113, 125);
            this.cbMaleFemale.Name = "cbMaleFemale";
            this.cbMaleFemale.Size = new System.Drawing.Size(121, 21);
            this.cbMaleFemale.TabIndex = 11;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Sindh",
            "Punjab",
            "Balochistan",
            "KPK"});
            this.cbProvince.Location = new System.Drawing.Point(113, 167);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(121, 21);
            this.cbProvince.TabIndex = 12;
            // 
            // addmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.cbMaleFemale);
            this.Controls.Add(this.provincelabel);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.cniclabel);
            this.Controls.Add(this.textboxlabel);
            this.Controls.Add(this.btAddCitizen);
            this.Controls.Add(this.cnictextbox);
            this.Controls.Add(this.nametextbox);
            this.Name = "addmember";
            this.Text = "addmember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox cnictextbox;
        private System.Windows.Forms.Button btAddCitizen;
        private System.Windows.Forms.Label textboxlabel;
        private System.Windows.Forms.Label cniclabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label provincelabel;
        private System.Windows.Forms.ComboBox cbMaleFemale;
        private System.Windows.Forms.ComboBox cbProvince;
    }
}