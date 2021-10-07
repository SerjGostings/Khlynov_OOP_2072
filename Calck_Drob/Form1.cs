using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calck_Drob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            sign_label.Text = "-";
        }
        private void multiply_button_Click(object sender, EventArgs e)
        {
            sign_label.Text = "*";
        }
        private void div_button_Click(object sender, EventArgs e)
        {
            sign_label.Text = "/";
        }
        private void plus_button_Click(object sender, EventArgs e)
        {
            sign_label.Text = "+";
        }

        private void Get_Rez_Click(object sender, EventArgs e)
        {

            if ((int.TryParse(Devided_1.Text, out int devd_1) == false) || ((int.TryParse(Devider_1.Text, out int devr_1) == false)) || 
                (devr_1 == 0) || (int.TryParse(Devided_2.Text, out int devd_2) == false) || ((int.TryParse(Devider_2.Text, out int devr_2) == false) || (devr_2 == 0)))
            {
             MessageBox.Show("Неверные входные данные");
            }
            else
            {
                Fraction frc1 = new Fraction(devd_1, devr_1);
                Fraction frc2 = new Fraction(devd_2, devr_2);

                switch (sign_label.Text)
                {
                    case "+":
                       // Fraction res_summ = frc1.Summ(frc2);
                       Fraction res_summ = frc1 + frc2;
                         Ans_Label.Text = res_summ.ToString();
                        break;
                    case "-":
                        //Fraction res_subtr = frc1.Subtr(frc2);
                        Fraction res_subtr = frc1 - frc2;
                         Ans_Label.Text = res_subtr.ToString();
                        break;
                    case "*":
                        //Fraction res_mult = frc1.Mult(frc2);
                        Fraction res_mult = frc1 * frc2;
                        Ans_Label.Text = res_mult.ToString();
                        break;
                    case "/":
                        //Fraction res_div = frc1.Div(frc2);
                        Fraction res_div = frc1 / frc2;
                         Ans_Label.Text = res_div.ToString();
                        break;
                }
            }
        }
    }
}

