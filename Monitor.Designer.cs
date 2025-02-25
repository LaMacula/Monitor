namespace Monitor_Invoice_Application
{
    partial class Form1
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
            this.lblMonitorApp = new System.Windows.Forms.Label();
            this.lblinvoiceNumber = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtinvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAdress1 = new System.Windows.Forms.TextBox();
            this.lblAdress2 = new System.Windows.Forms.Label();
            this.txtAdress2 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.lbl27 = new System.Windows.Forms.Label();
            this.lbl32 = new System.Windows.Forms.Label();
            this.txtQuantity3 = new System.Windows.Forms.TextBox();
            this.txtQuantity2 = new System.Windows.Forms.TextBox();
            this.txtQuantity1 = new System.Windows.Forms.TextBox();
            this.txtTotal3 = new System.Windows.Forms.TextBox();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtTotalAfterTaxes = new System.Windows.Forms.TextBox();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.dtInoviceDate = new System.Windows.Forms.DateTimePicker();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblTotalAfterTaxes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonitorApp
            // 
            this.lblMonitorApp.AutoSize = true;
            this.lblMonitorApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitorApp.Location = new System.Drawing.Point(92, 25);
            this.lblMonitorApp.Name = "lblMonitorApp";
            this.lblMonitorApp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMonitorApp.Size = new System.Drawing.Size(365, 31);
            this.lblMonitorApp.TabIndex = 0;
            this.lblMonitorApp.Text = "Monitor Invoice Application";
            this.lblMonitorApp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblinvoiceNumber
            // 
            this.lblinvoiceNumber.AutoSize = true;
            this.lblinvoiceNumber.Location = new System.Drawing.Point(100, 114);
            this.lblinvoiceNumber.Name = "lblinvoiceNumber";
            this.lblinvoiceNumber.Size = new System.Drawing.Size(85, 13);
            this.lblinvoiceNumber.TabIndex = 1;
            this.lblinvoiceNumber.Text = "Invoice Number:";
            this.lblinvoiceNumber.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(100, 163);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Company Name:";
            this.lblCompanyName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // lblAdress1
            // 
            this.lblAdress1.AutoSize = true;
            this.lblAdress1.Location = new System.Drawing.Point(100, 214);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(77, 13);
            this.lblAdress1.TabIndex = 3;
            this.lblAdress1.Text = "Adress (Line1):";
            this.lblAdress1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(280, 110);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(71, 13);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // txtinvoiceNumber
            // 
            this.txtinvoiceNumber.Location = new System.Drawing.Point(191, 111);
            this.txtinvoiceNumber.Name = "txtinvoiceNumber";
            this.txtinvoiceNumber.Size = new System.Drawing.Size(69, 20);
            this.txtinvoiceNumber.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(191, 163);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(260, 20);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAdress1
            // 
            this.txtAdress1.Location = new System.Drawing.Point(191, 211);
            this.txtAdress1.Name = "txtAdress1";
            this.txtAdress1.Size = new System.Drawing.Size(260, 20);
            this.txtAdress1.TabIndex = 7;
            this.txtAdress1.TextChanged += new System.EventHandler(this.txtAdress1_TextChanged);
            // 
            // lblAdress2
            // 
            this.lblAdress2.AutoSize = true;
            this.lblAdress2.Location = new System.Drawing.Point(100, 255);
            this.lblAdress2.Name = "lblAdress2";
            this.lblAdress2.Size = new System.Drawing.Size(80, 13);
            this.lblAdress2.TabIndex = 9;
            this.lblAdress2.Text = "Adress (Line 2):";
            this.lblAdress2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtAdress2
            // 
            this.txtAdress2.Location = new System.Drawing.Point(191, 252);
            this.txtAdress2.Name = "txtAdress2";
            this.txtAdress2.Size = new System.Drawing.Size(260, 20);
            this.txtAdress2.TabIndex = 10;
            this.txtAdress2.TextChanged += new System.EventHandler(this.txtAdress2_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(125, 348);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(217, 348);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(427, 348);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Totals:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lbl24
            // 
            this.lbl24.AutoSize = true;
            this.lbl24.Location = new System.Drawing.Point(125, 391);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(19, 13);
            this.lbl24.TabIndex = 14;
            this.lbl24.Text = "24";
            this.lbl24.Click += new System.EventHandler(this.lbl24_Click);
            // 
            // lbl27
            // 
            this.lbl27.AutoSize = true;
            this.lbl27.Location = new System.Drawing.Point(125, 434);
            this.lbl27.Name = "lbl27";
            this.lbl27.Size = new System.Drawing.Size(19, 13);
            this.lbl27.TabIndex = 15;
            this.lbl27.Text = "27";
            this.lbl27.Click += new System.EventHandler(this.lbl27_Click);
            // 
            // lbl32
            // 
            this.lbl32.AutoSize = true;
            this.lbl32.Location = new System.Drawing.Point(125, 482);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new System.Drawing.Size(19, 13);
            this.lbl32.TabIndex = 16;
            this.lbl32.Text = "32";
            this.lbl32.Click += new System.EventHandler(this.lbl32_Click);
            // 
            // txtQuantity3
            // 
            this.txtQuantity3.Location = new System.Drawing.Point(200, 482);
            this.txtQuantity3.Name = "txtQuantity3";
            this.txtQuantity3.Size = new System.Drawing.Size(66, 20);
            this.txtQuantity3.TabIndex = 22;
            // 
            // txtQuantity2
            // 
            this.txtQuantity2.Location = new System.Drawing.Point(200, 427);
            this.txtQuantity2.Name = "txtQuantity2";
            this.txtQuantity2.Size = new System.Drawing.Size(66, 20);
            this.txtQuantity2.TabIndex = 21;
            this.txtQuantity2.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.Location = new System.Drawing.Point(200, 384);
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Size = new System.Drawing.Size(66, 20);
            this.txtQuantity1.TabIndex = 20;
            this.txtQuantity1.TextChanged += new System.EventHandler(this.txtQuantity1_TextChanged);
            // 
            // txtTotal3
            // 
            this.txtTotal3.Location = new System.Drawing.Point(412, 486);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.Size = new System.Drawing.Size(66, 20);
            this.txtTotal3.TabIndex = 25;
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(412, 431);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(66, 20);
            this.txtTotal2.TabIndex = 24;
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(412, 388);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(66, 20);
            this.txtTotal1.TabIndex = 23;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(317, 348);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtPrice3
            // 
            this.txtPrice3.Location = new System.Drawing.Point(301, 482);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.ReadOnly = true;
            this.txtPrice3.Size = new System.Drawing.Size(66, 20);
            this.txtPrice3.TabIndex = 29;
            this.txtPrice3.Text = "7.25";
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(301, 427);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.ReadOnly = true;
            this.txtPrice2.Size = new System.Drawing.Size(66, 20);
            this.txtPrice2.TabIndex = 28;
            this.txtPrice2.Text = "5.00";
            this.txtPrice2.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(301, 384);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.ReadOnly = true;
            this.txtPrice1.Size = new System.Drawing.Size(66, 20);
            this.txtPrice1.TabIndex = 27;
            this.txtPrice1.Text = "6.25";
            this.txtPrice1.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtTotalAfterTaxes
            // 
            this.txtTotalAfterTaxes.Location = new System.Drawing.Point(412, 635);
            this.txtTotalAfterTaxes.Name = "txtTotalAfterTaxes";
            this.txtTotalAfterTaxes.Size = new System.Drawing.Size(66, 20);
            this.txtTotalAfterTaxes.TabIndex = 32;
            this.txtTotalAfterTaxes.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(412, 580);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(66, 20);
            this.txtTaxes.TabIndex = 31;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(412, 537);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(66, 20);
            this.txtSubtotal.TabIndex = 30;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(333, 544);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 33;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // dtInoviceDate
            // 
            this.dtInoviceDate.Location = new System.Drawing.Point(348, 107);
            this.dtInoviceDate.Name = "dtInoviceDate";
            this.dtInoviceDate.Size = new System.Drawing.Size(183, 20);
            this.dtInoviceDate.TabIndex = 34;
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(333, 583);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(39, 13);
            this.lblTaxes.TabIndex = 35;
            this.lblTaxes.Text = "Taxes:";
            // 
            // lblTotalAfterTaxes
            // 
            this.lblTotalAfterTaxes.AutoSize = true;
            this.lblTotalAfterTaxes.Location = new System.Drawing.Point(333, 642);
            this.lblTotalAfterTaxes.Name = "lblTotalAfterTaxes";
            this.lblTotalAfterTaxes.Size = new System.Drawing.Size(34, 13);
            this.lblTotalAfterTaxes.TabIndex = 36;
            this.lblTotalAfterTaxes.Text = "Total:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(103, 688);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 42);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(384, 688);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 42);
            this.btnOrder.TabIndex = 38;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 742);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalAfterTaxes);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.dtInoviceDate);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtTotalAfterTaxes);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPrice3);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtTotal3);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.txtQuantity3);
            this.Controls.Add(this.txtQuantity2);
            this.Controls.Add(this.txtQuantity1);
            this.Controls.Add(this.lbl32);
            this.Controls.Add(this.lbl27);
            this.Controls.Add(this.lbl24);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtAdress2);
            this.Controls.Add(this.lblAdress2);
            this.Controls.Add(this.txtAdress1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtinvoiceNumber);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblAdress1);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblinvoiceNumber);
            this.Controls.Add(this.lblMonitorApp);
            this.Controls.Add(this.lblType);
            this.Name = "Form1";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonitorApp;
        private System.Windows.Forms.Label lblinvoiceNumber;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtinvoiceNumber;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAdress1;
        private System.Windows.Forms.Label lblAdress2;
        private System.Windows.Forms.TextBox txtAdress2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Label lbl27;
        private System.Windows.Forms.Label lbl32;
        private System.Windows.Forms.TextBox txtQuantity3;
        private System.Windows.Forms.TextBox txtQuantity2;
        private System.Windows.Forms.TextBox txtQuantity1;
        private System.Windows.Forms.TextBox txtTotal3;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtTotalAfterTaxes;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.DateTimePicker dtInoviceDate;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTotalAfterTaxes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOrder;
    }
}

