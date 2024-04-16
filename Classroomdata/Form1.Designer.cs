namespace ProductsArrays
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
			label7 = new Label();
			label10 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label1.ForeColor = Color.OliveDrab;
			label1.Location = new Point(44, 81);
			label1.Name = "label1";
			label1.Size = new Size(72, 19);
			label1.TabIndex = 0;
			label1.Text = "Product";
			// 
			// txt_product
			// 
			txt_product.Font = new Font("Tahoma", 12F);
			txt_product.Location = new Point(122, 81);
			txt_product.Name = "txt_product";
			txt_product.Size = new Size(209, 27);
			txt_product.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label2.ForeColor = Color.OliveDrab;
			label2.Location = new Point(38, 190);
			label2.Name = "label2";
			label2.Size = new Size(83, 38);
			label2.TabIndex = 2;
			label2.Text = "Purchase\r\n Price";
			// 
			// txtpurchaseprice
			// 
			txtpurchaseprice.Font = new Font("Tahoma", 12F);
			txtpurchaseprice.Location = new Point(122, 200);
			txtpurchaseprice.Name = "txtpurchaseprice";
			txtpurchaseprice.Size = new Size(209, 27);
			txtpurchaseprice.TabIndex = 3;
			// 
			// txtsellingprice
			// 
			txtsellingprice.Font = new Font("Tahoma", 12F);
			txtsellingprice.Location = new Point(122, 252);
			txtsellingprice.Name = "txtsellingprice";
			txtsellingprice.Size = new Size(209, 27);
			txtsellingprice.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label3.ForeColor = Color.OliveDrab;
			label3.Location = new Point(50, 242);
			label3.Name = "label3";
			label3.Size = new Size(64, 38);
			label3.TabIndex = 4;
			label3.Text = "Selling\r\n Price";
			// 
			// txtexistingamout
			// 
			txtexistingamout.Font = new Font("Tahoma", 12F);
			txtexistingamout.Location = new Point(120, 310);
			txtexistingamout.Name = "txtexistingamout";
			txtexistingamout.Size = new Size(209, 27);
			txtexistingamout.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label4.ForeColor = Color.OliveDrab;
			label4.Location = new Point(42, 307);
			label4.Name = "label4";
			label4.Size = new Size(79, 38);
			label4.TabIndex = 6;
			label4.Text = "Existing \r\namount";
			// 
			// btnsave
			// 
			btnsave.BackColor = Color.OliveDrab;
			btnsave.FlatStyle = FlatStyle.Flat;
			btnsave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			btnsave.ForeColor = SystemColors.Control;
			btnsave.Location = new Point(100, 377);
			btnsave.Name = "btnsave";
			btnsave.Size = new Size(162, 45);
			btnsave.TabIndex = 8;
			btnsave.Text = "Save";
			btnsave.UseVisualStyleBackColor = false;
			btnsave.Click += btnsave_Click;
			// 
			// txtCategory
			// 
			txtCategory.Font = new Font("Tahoma", 12F);
			txtCategory.Location = new Point(122, 146);
			txtCategory.Name = "txtCategory";
			txtCategory.Size = new Size(209, 27);
			txtCategory.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label6.ForeColor = Color.OliveDrab;
			label6.Location = new Point(37, 146);
			label6.Name = "label6";
			label6.Size = new Size(83, 19);
			label6.TabIndex = 10;
			label6.Text = "Category";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label8.ForeColor = Color.DarkOrange;
			label8.Location = new Point(751, 112);
			label8.Name = "label8";
			label8.Size = new Size(149, 19);
			label8.TabIndex = 15;
			label8.Text = "Total purchases :";
			// 
			// txttotalpurchases
			// 
			txttotalpurchases.Font = new Font("Tahoma", 12F);
			txttotalpurchases.Location = new Point(761, 146);
			txttotalpurchases.Name = "txttotalpurchases";
			txttotalpurchases.ReadOnly = true;
			txttotalpurchases.Size = new Size(151, 27);
			txttotalpurchases.TabIndex = 16;
			// 
			// txttotalsales
			// 
			txttotalsales.Font = new Font("Tahoma", 12F);
			txttotalsales.Location = new Point(761, 223);
			txttotalsales.Name = "txttotalsales";
			txttotalsales.ReadOnly = true;
			txttotalsales.Size = new Size(151, 27);
			txttotalsales.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			label9.ForeColor = Color.DarkOrange;
			label9.Location = new Point(740, 190);
			label9.Name = "label9";
			label9.Size = new Size(189, 19);
			label9.TabIndex = 17;
			label9.Text = "Total expected sales :";
			// 
			// btnanalyze
			// 
			btnanalyze.BackColor = Color.Gold;
			btnanalyze.FlatStyle = FlatStyle.Flat;
			btnanalyze.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			btnanalyze.ForeColor = SystemColors.Control;
			btnanalyze.Location = new Point(761, 278);
			btnanalyze.Name = "btnanalyze";
			btnanalyze.Size = new Size(151, 45);
			btnanalyze.TabIndex = 19;
			btnanalyze.Text = "Analyze";
			btnanalyze.UseVisualStyleBackColor = false;
			btnanalyze.Click += btnanalyze_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.MidnightBlue;
			label5.Location = new Point(437, 34);
			label5.Name = "label5";
			label5.Size = new Size(192, 25);
			label5.TabIndex = 20;
			label5.Text = "Products Entered";
			// 
			// lbtotalproducts
			// 
			lbtotalproducts.AutoSize = true;
			lbtotalproducts.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbtotalproducts.ForeColor = Color.MidnightBlue;
			lbtotalproducts.Location = new Point(390, 84);
			lbtotalproducts.Name = "lbtotalproducts";
			lbtotalproducts.Size = new Size(0, 19);
			lbtotalproducts.TabIndex = 21;
			// 
			// btnreview
			// 
			btnreview.BackColor = Color.CadetBlue;
			btnreview.FlatStyle = FlatStyle.Flat;
			btnreview.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			btnreview.ForeColor = SystemColors.ControlLightLight;
			btnreview.Location = new Point(483, 377);
			btnreview.Name = "btnreview";
			btnreview.Size = new Size(135, 45);
			btnreview.TabIndex = 22;
			btnreview.Text = "Review";
			btnreview.UseVisualStyleBackColor = false;
			btnreview.Click += btnreview_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.OliveDrab;
			label7.Location = new Point(73, 34);
			label7.Name = "label7";
			label7.Size = new Size(238, 25);
			label7.TabIndex = 23;
			label7.Text = "Products Information";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.DarkOrange;
			label10.Location = new Point(788, 34);
			label10.Name = "label10";
			label10.Size = new Size(77, 25);
			label10.TabIndex = 24;
			label10.Text = "Totals";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(956, 450);
			Controls.Add(label10);
			Controls.Add(label7);
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
		private Label label7;
		private Label label10;
	}
}
