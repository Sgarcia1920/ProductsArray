using Microsoft.VisualBasic.Logging;
using System.Data.Common;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classroomdata
{
	public partial class Form1 : Form
	{
		int index;
		int[] myarray;
		Products[,,] products;
		
		public Form1()
		{
			InitializeComponent();
			index = 0;
			products = new Products[5, 5, 2];
			myarray = new int[50];
			
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			//if the array is full, display a message
			if (index == myarray.Length)
			{
				string data = "";
				for (int row = 0; row < products.GetLength(0); row++)
				{
					for (int column = 0; column < products.GetLength(1); column++)
					{
						for (int layer = 0; layer < products.GetLength(2); layer++)
						{

							data += products[row, column, layer] + " ";

						}
					}

				}

				MessageBox.Show("Array is full");

				return;
			}
			try
			{
				products[index / (products.GetLength(1) * products.GetLength(2)), (index / products.GetLength(2)) % products.GetLength(1), index % products.GetLength(2)] = new Products()
				{
					Product = txt_product.Text,
					Category = txtCategory.Text,
					Purchase_price = double.Parse(txtpurchaseprice.Text),
					Selling_price = double.Parse(txtsellingprice.Text),
					Existing_amount = int.Parse(txtexistingamout.Text),
				};

				index++;

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " ");
			}



		}

		private void btnreview_Click(object sender, EventArgs e)
		{

			string data = "";
			for (int row = 0; row < products.GetLength(0); row++)
			{
				for (int column = 0; column < products.GetLength(1); column++)
				{
					for (int layer = 0; layer < products.GetLength(2); layer++)
					{

						data += products[row, column, layer] + "\n";

					}
				}

			}
			lbtotalproducts.Text = data;

		}

		private void btnanalyze_Click(object sender, EventArgs e)
		{
			double total_purchase = 0.0;
			double total_sales = 0.0;

			foreach (Products product in products)
			{
				if (product != null)
				{
					total_purchase += product.Purchase_price * product.Existing_amount;

					total_sales += product.Selling_price * product.Existing_amount;
				}
			}
			txttotalpurchases.Text = total_purchase.ToString();
			txttotalsales.Text = total_sales.ToString();
		}
	}
}
