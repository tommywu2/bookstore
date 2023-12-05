namespace bookstore
{
    partial class members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(members));
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.lblguid = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblzip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblregion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblcountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(223, 12);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(565, 428);
            this.dgvMembers.TabIndex = 1;
            this.dgvMembers.SelectionChanged += new System.EventHandler(this.dgvmembers_SelectionChanged);
            // 
            // lblguid
            // 
            this.lblguid.AutoSize = true;
            this.lblguid.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguid.Location = new System.Drawing.Point(12, 12);
            this.lblguid.Name = "lblguid";
            this.lblguid.Size = new System.Drawing.Size(35, 15);
            this.lblguid.TabIndex = 23;
            this.lblguid.Text = "GUID";
            // 
            // txtGuid
            // 
            this.txtGuid.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuid.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuid.Location = new System.Drawing.Point(11, 30);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(100, 23);
            this.txtGuid.TabIndex = 22;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 56);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 15);
            this.lblname.TabIndex = 26;
            this.lblname.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(11, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 25;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(12, 100);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(42, 15);
            this.lblphone.TabIndex = 29;
            this.lblphone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(11, 118);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 28;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(12, 144);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 15);
            this.lblemail.TabIndex = 32;
            this.lblemail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(11, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 31;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(12, 188);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(56, 15);
            this.lbladdress.TabIndex = 35;
            this.lbladdress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(11, 206);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 34;
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzip.Location = new System.Drawing.Point(12, 232);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(77, 15);
            this.lblzip.TabIndex = 38;
            this.lblzip.Text = "Postal/Zip";
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.SystemColors.Window;
            this.txtZip.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(11, 250);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 23);
            this.txtZip.TabIndex = 37;
            // 
            // lblregion
            // 
            this.lblregion.AutoSize = true;
            this.lblregion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregion.Location = new System.Drawing.Point(12, 276);
            this.lblregion.Name = "lblregion";
            this.lblregion.Size = new System.Drawing.Size(49, 15);
            this.lblregion.TabIndex = 41;
            this.lblregion.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(11, 294);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 23);
            this.txtRegion.TabIndex = 40;
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(12, 320);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(56, 15);
            this.lblcountry.TabIndex = 44;
            this.lblcountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(11, 338);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 23);
            this.txtCountry.TabIndex = 43;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddMember.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddMember.Location = new System.Drawing.Point(117, 182);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(100, 50);
            this.btnAddMember.TabIndex = 50;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteMember.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteMember.Location = new System.Drawing.Point(117, 124);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteMember.TabIndex = 49;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.LightCoral;
            this.btnRead.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRead.Location = new System.Drawing.Point(117, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 50);
            this.btnRead.TabIndex = 48;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightCoral;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSave.Location = new System.Drawing.Point(117, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblregion);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblzip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblguid);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.dgvMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "members";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblguid;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblregion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
    }
}