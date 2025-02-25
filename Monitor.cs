using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_Invoice_Application
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        
            {
                // Configurar eventos para calcular total cuando cambien cantidad o precio
                txtQuantity1.TextChanged += CalculateTotal;
                txtPrice1.TextChanged += CalculateTotal;
                txtQuantity2.TextChanged += CalculateTotal;
                txtPrice2.TextChanged += CalculateTotal;
                txtQuantity3.TextChanged += CalculateTotal;
                txtPrice3.TextChanged += CalculateTotal;
            }

        private void CalculateTotal(object sender, EventArgs e)
        {
            try
            {
                // Convertir valores de cantidad y precio, y calcular el total de cada tipo
                decimal q1 = string.IsNullOrWhiteSpace(txtQuantity1.Text) ? 0 : Convert.ToDecimal(txtQuantity1.Text);
                decimal p1 = string.IsNullOrWhiteSpace(txtPrice1.Text) ? 0 : Convert.ToDecimal(txtPrice1.Text);
                txtTotal1.Text = (q1 * p1).ToString("F2");

                decimal q2 = string.IsNullOrWhiteSpace(txtQuantity2.Text) ? 0 : Convert.ToDecimal(txtQuantity2.Text);
                decimal p2 = string.IsNullOrWhiteSpace(txtPrice2.Text) ? 0 : Convert.ToDecimal(txtPrice2.Text);
                txtTotal2.Text = (q2 * p2).ToString("F2");

                decimal q3 = string.IsNullOrWhiteSpace(txtQuantity3.Text) ? 0 : Convert.ToDecimal(txtQuantity3.Text);
                decimal p3 = string.IsNullOrWhiteSpace(txtPrice3.Text) ? 0 : Convert.ToDecimal(txtPrice3.Text);
                txtTotal3.Text = (q3 * p3).ToString("F2");

                // Calcular subtotal
                decimal subtotal = (q1 * p1) + (q2 * p2) + (q3 * p3);
                txtSubtotal.Text = subtotal.ToString("F2");

                // Calcular impuestos (ejemplo: 18%)
                decimal taxes = subtotal * 0.18m;
                txtTaxes.Text = taxes.ToString("F2");

                // Calcular total final
                decimal total = subtotal + taxes;
                txtTotalAfterTaxes.Text = total.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Factura guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Orden procesada con éxito.", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lbl24_Click(object sender, EventArgs e)
        {

        }

        private void lbl27_Click(object sender, EventArgs e)
        {

        }

        private void lbl32_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
