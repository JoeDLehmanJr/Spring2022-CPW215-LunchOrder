namespace LunchOrder
{
    partial class FrmLunchOrder
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
            this.RdoFirstItem = new System.Windows.Forms.RadioButton();
            this.RdoSecondItem = new System.Windows.Forms.RadioButton();
            this.RdoThirdItem = new System.Windows.Forms.RadioButton();
            this.GrpMainCourse = new System.Windows.Forms.GroupBox();
            this.GrpAddOn = new System.Windows.Forms.GroupBox();
            this.ChkItemThree = new System.Windows.Forms.CheckBox();
            this.ChkItemOne = new System.Windows.Forms.CheckBox();
            this.ChkItemTwo = new System.Windows.Forms.CheckBox();
            this.GrpOrderTotal = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.LblTax = new System.Windows.Forms.Label();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpMainCourse.SuspendLayout();
            this.GrpAddOn.SuspendLayout();
            this.GrpOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdoFirstItem
            // 
            this.RdoFirstItem.AutoSize = true;
            this.RdoFirstItem.Location = new System.Drawing.Point(9, 21);
            this.RdoFirstItem.Name = "RdoFirstItem";
            this.RdoFirstItem.Size = new System.Drawing.Size(124, 19);
            this.RdoFirstItem.TabIndex = 0;
            this.RdoFirstItem.TabStop = true;
            this.RdoFirstItem.Text = "Hamburger - $6.95";
            this.RdoFirstItem.UseVisualStyleBackColor = true;
            this.RdoFirstItem.CheckedChanged += new System.EventHandler(this.RdoFirstItem_CheckedChanged);
            // 
            // RdoSecondItem
            // 
            this.RdoSecondItem.AutoSize = true;
            this.RdoSecondItem.Location = new System.Drawing.Point(9, 45);
            this.RdoSecondItem.Name = "RdoSecondItem";
            this.RdoSecondItem.Size = new System.Drawing.Size(89, 19);
            this.RdoSecondItem.TabIndex = 1;
            this.RdoSecondItem.TabStop = true;
            this.RdoSecondItem.Text = "Pizza - $5.95";
            this.RdoSecondItem.UseVisualStyleBackColor = true;
            this.RdoSecondItem.CheckedChanged += new System.EventHandler(this.RdoSecondItem_CheckedChanged);
            // 
            // RdoThirdItem
            // 
            this.RdoThirdItem.AutoSize = true;
            this.RdoThirdItem.Location = new System.Drawing.Point(9, 69);
            this.RdoThirdItem.Name = "RdoThirdItem";
            this.RdoThirdItem.Size = new System.Drawing.Size(91, 19);
            this.RdoThirdItem.TabIndex = 2;
            this.RdoThirdItem.TabStop = true;
            this.RdoThirdItem.Text = "Salad - $4.95";
            this.RdoThirdItem.UseVisualStyleBackColor = true;
            this.RdoThirdItem.CheckedChanged += new System.EventHandler(this.RdoThirdItem_CheckedChanged);
            // 
            // GrpMainCourse
            // 
            this.GrpMainCourse.Controls.Add(this.RdoThirdItem);
            this.GrpMainCourse.Controls.Add(this.RdoFirstItem);
            this.GrpMainCourse.Controls.Add(this.RdoSecondItem);
            this.GrpMainCourse.Location = new System.Drawing.Point(21, 22);
            this.GrpMainCourse.Name = "GrpMainCourse";
            this.GrpMainCourse.Size = new System.Drawing.Size(200, 100);
            this.GrpMainCourse.TabIndex = 3;
            this.GrpMainCourse.TabStop = false;
            this.GrpMainCourse.Text = "Main course";
            // 
            // GrpAddOn
            // 
            this.GrpAddOn.Controls.Add(this.ChkItemThree);
            this.GrpAddOn.Controls.Add(this.ChkItemOne);
            this.GrpAddOn.Controls.Add(this.ChkItemTwo);
            this.GrpAddOn.Location = new System.Drawing.Point(246, 22);
            this.GrpAddOn.Name = "GrpAddOn";
            this.GrpAddOn.Size = new System.Drawing.Size(247, 100);
            this.GrpAddOn.TabIndex = 4;
            this.GrpAddOn.TabStop = false;
            // 
            // ChkItemThree
            // 
            this.ChkItemThree.AutoSize = true;
            this.ChkItemThree.Location = new System.Drawing.Point(15, 74);
            this.ChkItemThree.Name = "ChkItemThree";
            this.ChkItemThree.Size = new System.Drawing.Size(15, 14);
            this.ChkItemThree.TabIndex = 10;
            this.ChkItemThree.UseVisualStyleBackColor = true;
            this.ChkItemThree.CheckedChanged += new System.EventHandler(this.ChkItemThree_CheckedChanged);
            // 
            // ChkItemOne
            // 
            this.ChkItemOne.AutoSize = true;
            this.ChkItemOne.Location = new System.Drawing.Point(17, 24);
            this.ChkItemOne.Name = "ChkItemOne";
            this.ChkItemOne.Size = new System.Drawing.Size(15, 14);
            this.ChkItemOne.TabIndex = 8;
            this.ChkItemOne.UseVisualStyleBackColor = true;
            this.ChkItemOne.CheckedChanged += new System.EventHandler(this.ChkItemOne_CheckedChanged);
            // 
            // ChkItemTwo
            // 
            this.ChkItemTwo.AutoSize = true;
            this.ChkItemTwo.Location = new System.Drawing.Point(16, 49);
            this.ChkItemTwo.Name = "ChkItemTwo";
            this.ChkItemTwo.Size = new System.Drawing.Size(15, 14);
            this.ChkItemTwo.TabIndex = 9;
            this.ChkItemTwo.UseVisualStyleBackColor = true;
            this.ChkItemTwo.CheckedChanged += new System.EventHandler(this.ChkItemTwo_CheckedChanged);
            // 
            // GrpOrderTotal
            // 
            this.GrpOrderTotal.Controls.Add(this.TxtTotal);
            this.GrpOrderTotal.Controls.Add(this.LblTotal);
            this.GrpOrderTotal.Controls.Add(this.TxtTax);
            this.GrpOrderTotal.Controls.Add(this.LblSubtotal);
            this.GrpOrderTotal.Controls.Add(this.TxtSubTotal);
            this.GrpOrderTotal.Controls.Add(this.LblTax);
            this.GrpOrderTotal.Location = new System.Drawing.Point(93, 159);
            this.GrpOrderTotal.Name = "GrpOrderTotal";
            this.GrpOrderTotal.Size = new System.Drawing.Size(200, 127);
            this.GrpOrderTotal.TabIndex = 5;
            this.GrpOrderTotal.TabStop = false;
            this.GrpOrderTotal.Text = "Order total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(102, 89);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(54, 23);
            this.TxtTotal.TabIndex = 16;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(29, 89);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(67, 15);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "Order total:";
            // 
            // TxtTax
            // 
            this.TxtTax.Location = new System.Drawing.Point(102, 58);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.ReadOnly = true;
            this.TxtTax.Size = new System.Drawing.Size(54, 23);
            this.TxtTax.TabIndex = 15;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(42, 35);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(54, 15);
            this.LblSubtotal.TabIndex = 11;
            this.LblSubtotal.Text = "Subtotal:";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(102, 29);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.ReadOnly = true;
            this.TxtSubTotal.Size = new System.Drawing.Size(54, 23);
            this.TxtSubTotal.TabIndex = 14;
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Location = new System.Drawing.Point(27, 62);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(69, 15);
            this.LblTax.TabIndex = 12;
            this.LblTax.Text = "Tax (7.75%):";
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.Location = new System.Drawing.Point(407, 159);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(86, 23);
            this.BtnPlaceOrder.TabIndex = 6;
            this.BtnPlaceOrder.Text = "Place Order";
            this.BtnPlaceOrder.UseVisualStyleBackColor = true;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(407, 263);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(86, 23);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 303);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPlaceOrder);
            this.Controls.Add(this.GrpOrderTotal);
            this.Controls.Add(this.GrpAddOn);
            this.Controls.Add(this.GrpMainCourse);
            this.Name = "FrmLunchOrder";
            this.Text = "Lunch Order";
            this.GrpMainCourse.ResumeLayout(false);
            this.GrpMainCourse.PerformLayout();
            this.GrpAddOn.ResumeLayout(false);
            this.GrpAddOn.PerformLayout();
            this.GrpOrderTotal.ResumeLayout(false);
            this.GrpOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton RdoFirstItem;
        private RadioButton RdoSecondItem;
        private RadioButton RdoThirdItem;
        private GroupBox GrpMainCourse;
        private GroupBox GrpAddOn;
        private GroupBox GrpOrderTotal;
        private Button BtnPlaceOrder;
        private Button BtnExit;
        private CheckBox ChkItemOne;
        private CheckBox ChkItemTwo;
        private CheckBox ChkItemThree;
        private Label LblSubtotal;
        private Label LblTax;
        private Label LblTotal;
        private TextBox TxtSubTotal;
        private TextBox TxtTax;
        private TextBox TxtTotal;
    }
}