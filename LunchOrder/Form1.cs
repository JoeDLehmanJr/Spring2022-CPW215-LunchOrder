namespace LunchOrder
{
    public partial class FrmLunchOrder : Form
    {
        public FrmLunchOrder()
        {
            InitializeComponent();
            RdoFirstItem.Checked = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdoFirstItem_CheckedChanged(object sender, EventArgs e)
        {
            setAddOns("Add-on ($.75/each)", "Lettuce, tomato, and onions", "Ketchup mayonnaise and mustard", "French fries");
        }

        private void RdoSecondItem_CheckedChanged(object sender, EventArgs e)
        {
            setAddOns("Add-on ($.50/each)", "Pepperoni", "Sausage", "Olives");
        }

        private void RdoThirdItem_CheckedChanged(object sender, EventArgs e)
        {
            setAddOns("Add-on ($.25/each)", "Croutons", "Bacon bits", "Bread sticks");
        }

        private void ChkItemOne_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotal();
        }

        private void ChkItemTwo_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotal();
        }

        private void ChkItemThree_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotal();
        }


        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (RdoFirstItem.Checked)
            {
                CalcTotal(.75m, 6.95m);
            }
            else if (RdoSecondItem.Checked)
            {
                CalcTotal(.50m, 5.95m);
            }
            else
            {
                CalcTotal(.25m, 4.95m);
            }
        }

        /// <summary>
        /// This method clears the subtotal, tax, and total text boxes.
        /// </summary>
        private void ClearOrderTotal()
        {
            TxtSubTotal.Clear();
            TxtTax.Clear();
            TxtTotal.Clear();
        }

        /// <summary>
        /// This method calculates the subtotal by counting the number of add ons and multiplies the number of 
        /// add-ons by the cost of add-on. It then adds the cost of add-ons with the cost for the main course 
        /// to get the subtotal. It then calculates the tax by multiplying .0775 by the subtotal. Finally we 
        /// get the total by adding the subtotal and the tax.
        /// </summary>
        /// <param name="addOnCost">The cost per add-on</param>
        /// <param name="mainCourse">The cost of the main course</param>
        private void CalcTotal(decimal addOnCost, decimal mainCourse)
        {
            ClearOrderTotal();

            decimal numChecked = 0.0m, subTotal, tax, total;
            foreach (Control currControl in GrpAddOn.Controls)
            {
                // CheckBox currCheckbox = currControl as CheckBox
                if (currControl is CheckBox currCheckbox)
                {
                    if (currCheckbox.Checked)
                    {
                        numChecked++;
                    }
                }
            }
            subTotal = numChecked * addOnCost + mainCourse;
            TxtSubTotal.Text = subTotal.ToString("c");

            tax = .0775m * subTotal;
            TxtTax.Text = tax.ToString("c");

            total = tax + subTotal;
            TxtTotal.Text = total.ToString("c");
        }

        /// <summary>
        /// This method sets the Add-on options.
        /// </summary>
        /// <param name="addOnGroupBox">The text for the group box label.</param>
        /// <param name="itemOneText">First check box text</param>
        /// <param name="itemTwoText">Second check box text</param>
        /// <param name="itemThreeText">Third check box text</param>
        private void setAddOns (string addOnGroupBox, string itemOneText, string itemTwoText, string itemThreeText)
        {
            GrpAddOn.Text = addOnGroupBox;
            ChkItemOne.Checked = false;
            ChkItemOne.Text = itemOneText;
            ChkItemTwo.Checked = false;
            ChkItemTwo.Text = itemTwoText;
            ChkItemThree.Checked = false;
            ChkItemThree.Text = itemThreeText;
        }
    }
}