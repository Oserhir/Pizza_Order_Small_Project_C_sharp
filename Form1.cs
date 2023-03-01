using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void disableAllControls()
        {
            gbSize.Enabled = false;
            gbTopping.Enabled = false;
            gbCrushType.Enabled = false;
            gbWhereToEat.Enabled = false;
            btnOrder.Enabled = false;
        }

        void resetForm()
        {
            //reset Groups
            gbSize.Enabled = true;
            gbTopping.Enabled = true;
            gbCrushType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMeduim.Checked = true;

            //reset Toppings.
            cbExtraCheese.Checked = false;
            cbOnion.Checked = false;
            cbMushrooms.Checked = false;
            cbOlives.Checked = false;
            cbTomatoes.Checked = false;
            cbGreenPeppers.Checked = false;

            //reset CrustType
            rbThinCrust.Checked = true;

            //reset WhereToEat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;

        }

        // Update Text
        void updateSize()
        {
            updateTotalPrice();

            // Size 

            if (rbSmall.Checked)
            {
                lbSize.Text = rbSmall.Text;
                return;
            }

            if (rbMeduim.Checked)
            {
                lbSize.Text = rbMeduim.Text;
                return;
            }

            if (rbLarge.Checked)
            {
                lbSize.Text = rbMeduim.Text;
                return;
            }
        }

        void updateCrushType()
        {
            updateTotalPrice();

            // Crush Type
            if (rbThinCrust.Checked)
            {
                lbThick.Text = rbThinCrust.Text;
                return;
            }

            if (rbThinkCrust.Checked)
            {
                lbThick.Text = rbThinkCrust.Text;
                return;
            }
        }

        void updateWhereToEat()
        {
            updateTotalPrice();

            // Where To Eat
            if (rbEatIn.Checked)
            {
                lbWhereToEAT.Text = rbEatIn.Text;
            }

            if (rbEatOut.Checked)
            {
                lbWhereToEAT.Text = rbEatOut.Text;
            }

        }

        void updateToppings()
        {
            updateTotalPrice();

            string s1 = "";

            // Topping
            if (cbExtraCheese.Checked)
            {
                s1 += ", " + cbExtraCheese.Text;
            }

            if (cbOnion.Checked)
            {
                s1 += ", " + cbOnion.Text;
            }

            if (cbMushrooms.Checked)
            {
                s1 += ", " + cbMushrooms.Text;
            }

            if (cbOlives.Checked)
            {
                s1 += ", " + cbOlives.Text;
            }

            if (cbTomatoes.Checked)
            {
                s1 += ", " + cbTomatoes.Text;
            }

            if (cbGreenPeppers.Checked)
            {
                s1 += ", " + cbGreenPeppers.Text;
            }

            if (s1.StartsWith(","))
            {
                s1 = s1.Substring(1 , s1.Length - 1 ).Trim();
            }

            if (s1 == "")
                s1 = "No Toppings";

            lbTopping.Text = s1;
        }

        // Get Price
        float getSelectedSizesPrice()
        {
           
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag); 
            }

            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }

            else 
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
            
        }

        float getSelectedCrushPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(  rbThinCrust.Tag );
            }
            else 
            {
                return Convert.ToSingle(rbThinkCrust.Tag);
            }

           
        }

        float calculateToppingPrice()
        {
            float ToppingPrice = 0;

            // Topping
            if (cbExtraCheese.Checked)
            {
                ToppingPrice += Convert.ToSingle(cbExtraCheese.Tag);
            }

            if (cbOnion.Checked)
            {
                ToppingPrice += Convert.ToSingle(cbOnion.Tag);
            }

            if (cbMushrooms.Checked)
            {
                ToppingPrice += Convert.ToSingle(cbMushrooms.Tag);
            }

            if (cbOlives.Checked)
            {
                ToppingPrice += Convert.ToSingle(cbOlives.Tag);
            }

            if (cbTomatoes.Checked)
            {
                ToppingPrice += Convert.ToSingle(cbTomatoes.Tag);
            }

            if (cbGreenPeppers.Checked)
            {
                ToppingPrice += Convert.ToSingle(cbGreenPeppers.Tag);
            }

            return ToppingPrice;
        }

        float calculateTotalPrice()
        {
            return getSelectedSizesPrice() + calculateToppingPrice() + getSelectedCrushPrice();
        }

        void updateTotalPrice()
        {
            lbPrice.Text = "$" + Convert.ToString(calculateTotalPrice() );
        }


        // Summary
        void updateOrderSummary()
        {
            updateSize();
            updateCrushType();
            updateWhereToEat();
            updateToppings();
            updateTotalPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateOrderSummary();
        }

        private void lbSize_Click(object sender, EventArgs e)
        {
             
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
            // updateOrderSummary();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
            // updateOrderSummary();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
            // updateOrderSummary();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrushType();
            // updateOrderSummary();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrushType();
            // updateOrderSummary();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateOrderSummary();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            updateOrderSummary();
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
            // updateOrderSummary();
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
            // updateOrderSummary();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
           // updateOrderSummary();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
            // updateOrderSummary();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
            // updateOrderSummary();
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
            // updateOrderSummary();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Succesfully", "Success", MessageBoxButtons.OKCancel
             , MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    disableAllControls();
              };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }
 
    }
}
