namespace Classroomdata
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			txt_product = new TextBox();
			label2 = new Label();
			txtpurchaseprice = new TextBox();
			txtsellingprice = new TextBox();
			label3 = new Label();
			txtexistingamout = new TextBox();
			label4 = new Label();
			btnsave = new Button();
			txtCategory = new TextBox();
			label6 = new Label();
			label8 = new Label();
			txttotalpurchases = new TextBox();
			txttotalsales = new TextBox();
			label9 = new Label();
			btnanalyze = new Button();
			label5 = new Label();
			lbtotalproducts = new Label();
			btnreview = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(57, 43);
			label1.Name = "label1";
			label1.Size = new Size(63, 19);
			label1.TabIndex = 0;
			label1.Text = "Product";
			// 
			// txt_product
			// 
			txt_product.Font = new Font("Tahoma", 12F);
			txt_product.Location = new Point(129, 40);
			txt_product.Name = "txt_product";
			txt_product.Size = new Size(209, 27);
			txt_product.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(51, 88);
			label2.Name = "label2";
			label2.Size = new Size(72, 38);
			label2.TabIndex = 2;
			label2.Text = "Purchase\r\n Price";
			// 
			// txtpurchaseprice
			// 
			txtpurchaseprice.Font = new Font("Tahoma", 12F);
			txtpurchaseprice.Location = new Point(129, 95);
			txtpurchaseprice.Name = "txtpurchaseprice";
			txtpurchaseprice.Size = new Size(209, 27);
			txtpurchaseprice.TabIndex = 3;
			// 
			// txtsellingprice
			// 
			txtsellingprice.Font = new Font("Tahoma", 12F);
			txtsellingprice.Location = new Point(476, 95);
			txtsellingprice.Name = "txtsellingprice";
			txtsellingprice.Size = new Size(209, 27);
			txtsellingprice.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(401, 88);
			label3.Name = "label3";
			label3.Size = new Size(56, 38);
			label3.TabIndex = 4;
			label3.Text = "Selling\r\n Price";
			// 
			// txtexistingamout
			// 
			txtexistingamout.Font = new Font("Tahoma", 12F);
			txtexistingamout.Location = new Point(129, 155);
			txtexistingamout.Name = "txtexistingamout";
			txtexistingamout.Size = new Size(209, 27);
			txtexistingamout.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F);
			label4.Location = new Point(57, 155);
			label4.Name = "label4";
			label4.Size = new Size(69, 38);
			label4.TabIndex = 6;
			label4.Text = "Existing \r\namount";
			// 
			// btnsave
			// 
			btnsave.Font = new Font("Tahoma", 12F);
			btnsave.Location = new Point(420, 148);
			btnsave.Name = "btnsave";
			btnsave.Size = new Size(162, 34);
			btnsave.TabIndex = 8;
			btnsave.Text = "Save";
			btnsave.UseVisualStyleBackColor = true;
			btnsave.Click += btnsave_Click;
			// 
			// txtCategory
			// 
			txtCategory.Font = new Font("Tahoma", 12F);
			txtCategory.Location = new Point(476, 38);
			txtCategory.Name = "txtCategory";
			txtCategory.Size = new Size(209, 27);
			txtCategory.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Tahoma", 12F);
			label6.Location = new Point(388, 43);
			label6.Name = "label6";
			label6.Size = new Size(72, 19);
			label6.TabIndex = 10;
			label6.Text = "Category";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Tahoma", 12F);
			label8.Location = new Point(36, 243);
			label8.Name = "label8";
			label8.Size = new Size(131, 19);
			label8.TabIndex = 15;
			label8.Text = "Total purchases :";
			// 
			// txttotalpurchases
			// 
			txttotalpurchases.Font = new Font("Tahoma", 12F);
			txttotalpurchases.Location = new Point(36, 275);
			txttotalpurchases.Name = "txttotalpurchases";
			txttotalpurchases.ReadOnly = true;
			txttotalpurchases.Size = new Size(151, 27);
			txttotalpurchases.TabIndex = 16;
			// 
			// txttotalsales
			// 
			txttotalsales.Font = new Font("Tahoma", 12F);
			txttotalsales.Location = new Point(36, 352);
			txttotalsales.Name = "txttotalsales";
			txttotalsales.ReadOnly = true;
			txttotalsales.Size = new Size(151, 27);
			txttotalsales.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Tahoma", 12F);
			label9.Location = new Point(36, 322);
			label9.Name = "label9";
			label9.Size = new Size(162, 19);
			label9.TabIndex = 17;
			label9.Text = "Total expected sales :";
			// 
			// btnanalyze
			// 
			btnanalyze.Font = new Font("Tahoma", 12F);
			btnanalyze.Location = new Point(36, 404);
			btnanalyze.Name = "btnanalyze";
			btnanalyze.Size = new Size(151, 34);
			btnanalyze.TabIndex = 19;
			btnanalyze.Text = "Analyze";
			btnanalyze.UseVisualStyleBackColor = true;
			btnanalyze.Click += btnanalyze_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(293, 223);
			label5.Name = "label5";
			label5.Size = new Size(129, 19);
			label5.TabIndex = 20;
			label5.Text = "Products Entered";
			// 
			// lbtotalproducts
			// 
			lbtotalproducts.AutoSize = true;
			lbtotalproducts.Font = new Font("Tahoma", 8F);
			lbtotalproducts.Location = new Point(235, 257);
			lbtotalproducts.Name = "lbtotalproducts";
			lbtotalproducts.Size = new Size(0, 13);
			lbtotalproducts.TabIndex = 21;
			// 
			// btnreview
			// 
			btnreview.Location = new Point(444, 218);
			btnreview.Name = "btnreview";
			btnreview.Size = new Size(84, 24);
			btnreview.TabIndex = 22;
			btnreview.Text = "Review";
			btnreview.UseVisualStyleBackColor = true;
			btnreview.Click += btnreview_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnreview);
			Controls.Add(lbtotalproducts);
			Controls.Add(label5);
			Controls.Add(btnanalyze);
			Controls.Add(txttotalsales);
			Controls.Add(label9);
			Controls.Add(txttotalpurchases);
			Controls.Add(label8);
			Controls.Add(txtCategory);
			Controls.Add(label6);
			Controls.Add(btnsave);
			Controls.Add(txtexistingamout);
			Controls.Add(label4);
			Controls.Add(txtsellingprice);
			Controls.Add(label3);
			Controls.Add(txtpurchaseprice);
			Controls.Add(label2);
			Controls.Add(txt_product);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txt_product;
		private Label label2;
		private TextBox txtpurchaseprice;
		private TextBox txtsellingprice;
		private Label label3;
		private TextBox txtexistingamout;
		private Label label4;
		private Button btnsave;
		private TextBox txtCategory;
		private Label label6;
		private Label label8;
		private TextBox txttotalpurchases;
		private TextBox txttotalsales;
		private Label label9;
		private Button btnanalyze;
		private Label label5;
		private Label lbtotalproducts;
		private Button btnreview;
	}
}
