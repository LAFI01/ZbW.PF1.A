using System;
using System.Windows.Forms;

namespace MB06.A11_1._2
{
    public partial class A11_1_2 : Form
    {
        private Product[] products = new Product[3];
        private int productCounter = 0;

        public A11_1_2()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string name = TxtbxProductName.Text;
            double purchasingPrice = 0.0;
            double retailPrice = 0.0;
            try
            {
                purchasingPrice = Convert.ToDouble(TxtpurchasingPrice.Text);
                retailPrice = Convert.ToDouble(TxtRetailPrice.Text);

                if (productCounter < products.Length)
                {
                    products[productCounter] = new Product();
                    products[productCounter].Name = name;
                    products[productCounter].PurchasingPrice = purchasingPrice;
                    products[productCounter].RetailPrice = retailPrice;
                    productCounter++;
                    ClearTextBoxes();
                    LblProductCount.Text = Convert.ToString(productCounter);
                }
                else
                {
                    MessageBox.Show(this, "Speicher voll. Es können keine weiteren Produkte mehr " +
                        "erfasst werden");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Bitte benutzen Sie das , anstelle des .tes");
            }
        }

        private void ClearTextBoxes()
        {
            TxtbxProductName.Text = "";
            TxtpurchasingPrice.Text = "";
            TxtRetailPrice.Text = "";
        }

        private void ShowProducts(object sender, TabControlCancelEventArgs e)
        {
            TxtProductList.Text = "";
            for (int c = 0; c < productCounter; c++)
            {
                TxtProductList.Text += products[c].ShowValue() + "\r\n";
            }
        }
    }
}