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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rasgele = new Random();
            string secim = "10B";
            if (radioButton1.Checked)
            {
                secim = "9";
            }
            if (radioButton2.Checked)
            {
                secim = "10";
            }
            if (radioButton3.Checked)
            {
                secim = "11";
            }
            if (radioButton4.Checked)
            {
                secim = "12";
            }
            if (radioButton5.Checked)
            {
                secim = secim + "A";
            }
            if (radioButton6.Checked)
            {
                secim = secim + "B";
            }
            if (radioButton7.Checked)
            {
                secim = secim + "C";
            }
            if (radioButton8.Checked)
            {
                secim = secim + "D";
            }
            if (radioButton9.Checked)
            {
                secim = secim + "E";
            }
            if (secim == "9A")
            {
                int sirano = rasgele.Next(32);
                label1.Text = a9.Items[sirano].ToString();
            }
            if (secim == "9B")
            {
                int sirano = rasgele.Next(32);
                label1.Text = b9.Items[sirano].ToString();
            }
            if (secim == "9C")
            {
                int sirano = rasgele.Next(27);
                label1.Text = c9.Items[sirano].ToString();
            }
            if (secim == "9D")
            {
                int sirano = rasgele.Next(31);
                label1.Text = d9.Items[sirano].ToString();
            }
            if (secim == "9E")
            {
                int sirano = rasgele.Next(29);
                label1.Text = e9.Items[sirano].ToString();
            }
            if (secim == "10A")
            {
                int sirano = rasgele.Next(30);
                label1.Text = a10.Items[sirano].ToString();
            }
            if (secim == "10B")
            {
                int sirano = rasgele.Next(29);
                label1.Text = b10.Items[sirano].ToString();
            }
            if (secim == "10C")
            {
                int sirano = rasgele.Next (34);
                label1.Text = c10.Items[sirano].ToString();
            }
            if (secim== "10D")
            {
                int sirano = rasgele.Next(22);
                label1.Text = d10.Items[sirano].ToString();
            }
            if (secim == "10E")
            {
                int sirano = rasgele.Next(23);
                label1.Text = e10.Items[sirano].ToString(); 
            }
            if (secim == "11A")
            {
                int sirano = rasgele.Next(30);
                label1.Text = a11.Items[sirano].ToString();
            }
            if (secim == "11B")
            {
                int sirano = rasgele.Next(24);
                label1.Text = b11.Items[sirano].ToString();
            }
            if (secim == "11C")
            {
                int sirano = rasgele.Next(24);
                label1.Text = c11.Items[sirano].ToString();
            }
            if (secim == "11D")
            {
                int sirano = rasgele.Next(22);
                label1.Text = d11.Items[sirano].ToString();
            }
            if (secim == "11E")
            {
                int sirano = rasgele.Next(18);
                label1.Text = e11.Items[sirano].ToString();
            }
            if (secim == "12A")
            {
                int sirano = rasgele.Next(26);
                label1.Text = a12.Items[sirano].ToString();
            }
            if (secim == "12B")
            {
                int sirano = rasgele.Next(20);
                label1.Text = b12.Items[sirano].ToString();
            }
            if (secim == "12C")
            {
                int sirano = rasgele.Next(24);
                label1.Text = c12.Items[sirano].ToString();
            }
            if (secim == "12D")
            {
                int sirano = rasgele.Next(15);
                label1.Text = d12.Items[sirano].ToString();
            }
            if (secim == "12E")
            {
                int sirano = rasgele.Next(15);
                label1.Text = e12.Items[sirano].ToString();
            }
        }

    }
}
