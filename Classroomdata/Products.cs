using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsArrays
{
	public class Products
	{
		private string product;

		public string Product
		{
			get { return product; }
			set { product = value; }
		}

		private string category;

		public string Category
		{
			get { return category; }
			set { category = value; }
		}
		private double purchase_price;

		public double Purchase_price
		{
			get { return purchase_price; }
			set { purchase_price = value; }
		}
		private double selling_price;

		public double Selling_price
		{
			get { return selling_price; }
			set { selling_price = value; }
		}

		private int existing_amount;

		public int Existing_amount
		{
			get { return existing_amount; }
			set { existing_amount = value; }
		}
		public Products()
		{
			this.product = "";
			this.category = "";
			this.purchase_price = 0.0;
			this.selling_price = 0.0;
			this.existing_amount = 0;
		}
		public Products(string product, string category, double purchase_p, double selling_p, int existing_amount)
		{
			this.product = product;
			this.category = category;
			this.purchase_price = purchase_p;
			this.selling_price = selling_p;
			this.existing_amount = existing_amount;
		}

		public override string ToString()
		{
			return "" + Product + " -  " + Category + " -  $" + Purchase_price + " -  $" + Selling_price + " -  " + Existing_amount; 	
		}
	}
}
