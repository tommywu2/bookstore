namespace bookstore
{
    partial class books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            this.dgvbooks = new System.Windows.Forms.DataGridView();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPubYear = new System.Windows.Forms.Label();
            this.txtPubYear = new System.Windows.Forms.TextBox();
            this.lblFiction = new System.Windows.Forms.Label();
            this.txtFiction = new System.Windows.Forms.TextBox();
            this.lblCoverType = new System.Windows.Forms.Label();
            this.txtCoverType = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.btnIsbn = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnPubYear = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnFiction = new System.Windows.Forms.Button();
            this.btnCoverType = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnPages = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbooks
            // 
            this.dgvbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbooks.Location = new System.Drawing.Point(12, 288);
            this.dgvbooks.Name = "dgvbooks";
            this.dgvbooks.Size = new System.Drawing.Size(776, 150);
            this.dgvbooks.TabIndex = 0;
            this.dgvbooks.SelectionChanged += new System.EventHandler(this.dgvbooks_SelectionChanged);
            // 
            // txtIsbn
            // 
            this.txtIsbn.BackColor = System.Drawing.SystemColors.Window;
            this.txtIsbn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(100, 6);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 23);
            this.txtIsbn.TabIndex = 1;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(59, 9);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 15);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(52, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 15);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(100, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 23);
            this.txtTitle.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(45, 67);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(49, 15);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(100, 64);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 23);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(52, 154);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 15);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.SystemColors.Window;
            this.txtGenre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(100, 151);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 23);
            this.txtGenre.TabIndex = 11;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(24, 125);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(70, 15);
            this.lblPublisher.TabIndex = 10;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublisher.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(100, 122);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 23);
            this.txtPublisher.TabIndex = 9;
            // 
            // lblPubYear
            // 
            this.lblPubYear.AutoSize = true;
            this.lblPubYear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubYear.Location = new System.Drawing.Point(31, 96);
            this.lblPubYear.Name = "lblPubYear";
            this.lblPubYear.Size = new System.Drawing.Size(63, 15);
            this.lblPubYear.TabIndex = 8;
            this.lblPubYear.Text = "Pub Year";
            // 
            // txtPubYear
            // 
            this.txtPubYear.BackColor = System.Drawing.SystemColors.Window;
            this.txtPubYear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubYear.Location = new System.Drawing.Point(100, 93);
            this.txtPubYear.Name = "txtPubYear";
            this.txtPubYear.Size = new System.Drawing.Size(100, 23);
            this.txtPubYear.TabIndex = 7;
            // 
            // lblFiction
            // 
            this.lblFiction.AutoSize = true;
            this.lblFiction.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiction.Location = new System.Drawing.Point(38, 212);
            this.lblFiction.Name = "lblFiction";
            this.lblFiction.Size = new System.Drawing.Size(56, 15);
            this.lblFiction.TabIndex = 16;
            this.lblFiction.Text = "Fiction";
            // 
            // txtFiction
            // 
            this.txtFiction.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiction.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiction.Location = new System.Drawing.Point(100, 209);
            this.txtFiction.Name = "txtFiction";
            this.txtFiction.Size = new System.Drawing.Size(100, 23);
            this.txtFiction.TabIndex = 15;
            // 
            // lblCoverType
            // 
            this.lblCoverType.AutoSize = true;
            this.lblCoverType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoverType.Location = new System.Drawing.Point(17, 183);
            this.lblCoverType.Name = "lblCoverType";
            this.lblCoverType.Size = new System.Drawing.Size(77, 15);
            this.lblCoverType.TabIndex = 14;
            this.lblCoverType.Text = "Cover Type";
            // 
            // txtCoverType
            // 
            this.txtCoverType.BackColor = System.Drawing.SystemColors.Window;
            this.txtCoverType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoverType.Location = new System.Drawing.Point(100, 180);
            this.txtCoverType.Name = "txtCoverType";
            this.txtCoverType.Size = new System.Drawing.Size(100, 23);
            this.txtCoverType.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(52, 270);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 15);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(100, 267);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 19;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(52, 241);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(42, 15);
            this.lblPages.TabIndex = 18;
            this.lblPages.Text = "Pages";
            // 
            // txtPages
            // 
            this.txtPages.BackColor = System.Drawing.SystemColors.Window;
            this.txtPages.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPages.Location = new System.Drawing.Point(100, 238);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 23);
            this.txtPages.TabIndex = 17;
            // 
            // btnIsbn
            // 
            this.btnIsbn.BackColor = System.Drawing.Color.LightCoral;
            this.btnIsbn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsbn.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIsbn.Location = new System.Drawing.Point(206, 5);
            this.btnIsbn.Name = "btnIsbn";
            this.btnIsbn.Size = new System.Drawing.Size(75, 23);
            this.btnIsbn.TabIndex = 21;
            this.btnIsbn.Text = "ISBN";
            this.btnIsbn.UseVisualStyleBackColor = false;
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.LightCoral;
            this.btnTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTitle.Location = new System.Drawing.Point(206, 34);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 22;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnPubYear
            // 
            this.btnPubYear.BackColor = System.Drawing.Color.LightCoral;
            this.btnPubYear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPubYear.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPubYear.Location = new System.Drawing.Point(206, 92);
            this.btnPubYear.Name = "btnPubYear";
            this.btnPubYear.Size = new System.Drawing.Size(75, 23);
            this.btnPubYear.TabIndex = 24;
            this.btnPubYear.Text = "Pub Year";
            this.btnPubYear.UseVisualStyleBackColor = false;
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.LightCoral;
            this.btnAuthor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAuthor.Location = new System.Drawing.Point(206, 63);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAuthor.TabIndex = 23;
            this.btnAuthor.Text = "Author";
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // btnFiction
            // 
            this.btnFiction.BackColor = System.Drawing.Color.LightCoral;
            this.btnFiction.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiction.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFiction.Location = new System.Drawing.Point(206, 208);
            this.btnFiction.Name = "btnFiction";
            this.btnFiction.Size = new System.Drawing.Size(75, 23);
            this.btnFiction.TabIndex = 28;
            this.btnFiction.Text = "Fiction";
            this.btnFiction.UseVisualStyleBackColor = false;
            // 
            // btnCoverType
            // 
            this.btnCoverType.BackColor = System.Drawing.Color.LightCoral;
            this.btnCoverType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoverType.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCoverType.Location = new System.Drawing.Point(206, 179);
            this.btnCoverType.Name = "btnCoverType";
            this.btnCoverType.Size = new System.Drawing.Size(75, 23);
            this.btnCoverType.TabIndex = 27;
            this.btnCoverType.Text = "Cover Type";
            this.btnCoverType.UseVisualStyleBackColor = false;
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.LightCoral;
            this.btnGenre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGenre.Location = new System.Drawing.Point(206, 150);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(75, 23);
            this.btnGenre.TabIndex = 26;
            this.btnGenre.Text = "Genre";
            this.btnGenre.UseVisualStyleBackColor = false;
            // 
            // btnPublisher
            // 
            this.btnPublisher.BackColor = System.Drawing.Color.LightCoral;
            this.btnPublisher.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPublisher.Location = new System.Drawing.Point(206, 121);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnPublisher.TabIndex = 25;
            this.btnPublisher.Text = "Publisher";
            this.btnPublisher.UseVisualStyleBackColor = false;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrice.Location = new System.Drawing.Point(206, 266);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPrice.TabIndex = 30;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            // 
            // btnPages
            // 
            this.btnPages.BackColor = System.Drawing.Color.LightCoral;
            this.btnPages.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPages.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPages.Location = new System.Drawing.Point(206, 237);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(75, 23);
            this.btnPages.TabIndex = 29;
            this.btnPages.Text = "Pages";
            this.btnPages.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightCoral;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSave.Location = new System.Drawing.Point(363, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.LightCoral;
            this.btnRead.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRead.Location = new System.Drawing.Point(363, 185);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 32;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteBook.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteBook.Location = new System.Drawing.Point(363, 243);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 33;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnPages);
            this.Controls.Add(this.btnFiction);
            this.Controls.Add(this.btnCoverType);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.btnPublisher);
            this.Controls.Add(this.btnPubYear);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnIsbn);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.lblFiction);
            this.Controls.Add(this.txtFiction);
            this.Controls.Add(this.lblCoverType);
            this.Controls.Add(this.txtCoverType);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lblPubYear);
            this.Controls.Add(this.txtPubYear);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.dgvbooks);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbooks;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPubYear;
        private System.Windows.Forms.TextBox txtPubYear;
        private System.Windows.Forms.Label lblFiction;
        private System.Windows.Forms.TextBox txtFiction;
        private System.Windows.Forms.Label lblCoverType;
        private System.Windows.Forms.TextBox txtCoverType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Button btnIsbn;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnPubYear;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnFiction;
        private System.Windows.Forms.Button btnCoverType;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnPages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDeleteBook;
    }
}

