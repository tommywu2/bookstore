namespace bookstore
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.dgvmembers = new System.Windows.Forms.DataGridView();
            this.btnguid = new System.Windows.Forms.Button();
            this.lblguid = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.btnname = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnphone = new System.Windows.Forms.Button();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnemail = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnaddress = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnzip = new System.Windows.Forms.Button();
            this.lblzip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnregion = new System.Windows.Forms.Button();
            this.lblregion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.btncountry = new System.Windows.Forms.Button();
            this.lblcountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmembers
            // 
            this.dgvmembers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmembers.Location = new System.Drawing.Point(12, 240);
            this.dgvmembers.Name = "dgvmembers";
            this.dgvmembers.Size = new System.Drawing.Size(776, 200);
            this.dgvmembers.TabIndex = 1;
            this.dgvmembers.SelectionChanged += new System.EventHandler(this.dgvmembers_SelectionChanged);
            // 
            // btnguid
            // 
            this.btnguid.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguid.Location = new System.Drawing.Point(165, 12);
            this.btnguid.Name = "btnguid";
            this.btnguid.Size = new System.Drawing.Size(75, 23);
            this.btnguid.TabIndex = 24;
            this.btnguid.Text = "GUID";
            this.btnguid.UseVisualStyleBackColor = true;
            // 
            // lblguid
            // 
            this.lblguid.AutoSize = true;
            this.lblguid.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguid.Location = new System.Drawing.Point(18, 16);
            this.lblguid.Name = "lblguid";
            this.lblguid.Size = new System.Drawing.Size(35, 15);
            this.lblguid.TabIndex = 23;
            this.lblguid.Text = "GUID";
            // 
            // txtGuid
            // 
            this.txtGuid.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuid.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuid.Location = new System.Drawing.Point(59, 13);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(100, 23);
            this.txtGuid.TabIndex = 22;
            // 
            // btnname
            // 
            this.btnname.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnname.Location = new System.Drawing.Point(165, 41);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(75, 23);
            this.btnname.TabIndex = 27;
            this.btnname.Text = "Name";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(18, 45);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 15);
            this.lblname.TabIndex = 26;
            this.lblname.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(59, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 25;
            // 
            // btnphone
            // 
            this.btnphone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphone.Location = new System.Drawing.Point(165, 70);
            this.btnphone.Name = "btnphone";
            this.btnphone.Size = new System.Drawing.Size(75, 23);
            this.btnphone.TabIndex = 30;
            this.btnphone.Text = "Phone";
            this.btnphone.UseVisualStyleBackColor = true;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(18, 74);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(42, 15);
            this.lblphone.TabIndex = 29;
            this.lblphone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(59, 71);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 28;
            // 
            // btnemail
            // 
            this.btnemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemail.Location = new System.Drawing.Point(165, 99);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(75, 23);
            this.btnemail.TabIndex = 33;
            this.btnemail.Text = "Email";
            this.btnemail.UseVisualStyleBackColor = true;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(18, 103);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 15);
            this.lblemail.TabIndex = 32;
            this.lblemail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(59, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 31;
            // 
            // btnaddress
            // 
            this.btnaddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddress.Location = new System.Drawing.Point(165, 128);
            this.btnaddress.Name = "btnaddress";
            this.btnaddress.Size = new System.Drawing.Size(75, 23);
            this.btnaddress.TabIndex = 36;
            this.btnaddress.Text = "Address";
            this.btnaddress.UseVisualStyleBackColor = true;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(18, 132);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(56, 15);
            this.lbladdress.TabIndex = 35;
            this.lbladdress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(59, 129);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 34;
            // 
            // btnzip
            // 
            this.btnzip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzip.Location = new System.Drawing.Point(165, 157);
            this.btnzip.Name = "btnzip";
            this.btnzip.Size = new System.Drawing.Size(75, 23);
            this.btnzip.TabIndex = 39;
            this.btnzip.Text = "Postal/Zip";
            this.btnzip.UseVisualStyleBackColor = true;
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzip.Location = new System.Drawing.Point(18, 161);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(77, 15);
            this.lblzip.TabIndex = 38;
            this.lblzip.Text = "Postal/Zip";
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.SystemColors.Window;
            this.txtZip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(59, 158);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 23);
            this.txtZip.TabIndex = 37;
            // 
            // btnregion
            // 
            this.btnregion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregion.Location = new System.Drawing.Point(165, 186);
            this.btnregion.Name = "btnregion";
            this.btnregion.Size = new System.Drawing.Size(75, 23);
            this.btnregion.TabIndex = 42;
            this.btnregion.Text = "Region";
            this.btnregion.UseVisualStyleBackColor = true;
            // 
            // lblregion
            // 
            this.lblregion.AutoSize = true;
            this.lblregion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregion.Location = new System.Drawing.Point(18, 190);
            this.lblregion.Name = "lblregion";
            this.lblregion.Size = new System.Drawing.Size(49, 15);
            this.lblregion.TabIndex = 41;
            this.lblregion.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(59, 187);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 23);
            this.txtRegion.TabIndex = 40;
            // 
            // btncountry
            // 
            this.btncountry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncountry.Location = new System.Drawing.Point(165, 215);
            this.btncountry.Name = "btncountry";
            this.btncountry.Size = new System.Drawing.Size(75, 23);
            this.btncountry.TabIndex = 45;
            this.btncountry.Text = "Country";
            this.btncountry.UseVisualStyleBackColor = true;
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(18, 219);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(56, 15);
            this.lblcountry.TabIndex = 44;
            this.lblcountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(59, 216);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 23);
            this.txtCountry.TabIndex = 43;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncountry);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnregion);
            this.Controls.Add(this.lblregion);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.btnzip);
            this.Controls.Add(this.lblzip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnguid);
            this.Controls.Add(this.lblguid);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.dgvmembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Members";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmembers;
        private System.Windows.Forms.Button btnguid;
        private System.Windows.Forms.Label lblguid;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnzip;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnregion;
        private System.Windows.Forms.Label lblregion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Button btncountry;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.TextBox txtCountry;
    }
}