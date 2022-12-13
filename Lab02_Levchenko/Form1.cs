using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02_Levchenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_xor_Click(object sender, EventArgs e)
        {
            string strP = textBox_p.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_key.Text;
            int intKey = Convert.ToInt32(strKey, 16);

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC,16);
            textBox_c.Text = strC;


            label_p_hex.Text = Convert.ToString(intP, 16);
            label_p_10.Text = Convert.ToString(intP, 10);
            label_p_2.Text = Convert.ToString(intP, 2);

            label_key_hex.Text = Convert.ToString(intKey, 16);
            label_key_10.Text = Convert.ToString(intKey, 10);
            label_key_2.Text = Convert.ToString(intKey, 2);

            label_c_hex.Text = Convert.ToString(intC, 16);
            label_c_10.Text = Convert.ToString(intC, 10);
            label_c_2.Text = Convert.ToString(intC, 2);

            

            
            textBox_c_OUT.Text = strC;
            textBox_key_OUT.Text = strKey;
            int intP_OUT = intC ^ intKey;
            string strP_OUT = Convert.ToString(intP_OUT, 16);
            textBox_p_OUT.Text = strP_OUT;


        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_p.Text = "";
            textBox_key.Text = "";
            textBox_c.Text = "";

            label_p_hex.Text = "x";
            label_p_10.Text = "x";
            label_p_2.Text = "x";

            label_key_hex.Text = "x";
            label_key_10.Text = "x";
            label_key_2.Text = "x";

            label_c_hex.Text = "x";
            label_c_10.Text = "x";
            label_c_2.Text = "x";

            textBox_c_OUT.Text = "";
            textBox_key_OUT.Text = "";
            textBox_p_OUT.Text = "";
        }
    }
}
