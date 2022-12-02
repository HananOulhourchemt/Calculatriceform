using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatriceform
{
    public partial class Form1 : Form
    {
        private List<Button> buttons = new List<Button>();

        char op;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text="0";
        }


        private void Btn0_Click(object sender, EventArgs e)
        {
            label1.Text +="0";
        }
        private void btn_virgule_Click(object sender, EventArgs e)
        {
            label1.Text +=",";
        }

        private void btnsom_Click(object sender, EventArgs e)
        {
            label1.Text+="+";
            op= '+';
        }

        private void btnPlusMoins_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="1";
            else
                label1.Text +="1";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="5";
            else
                label1.Text +="5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="6";
            else
                label1.Text +="6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="7";
            else
                label1.Text +="7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="8";
            else
                label1.Text +="8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="9";
            else
                label1.Text +="9";
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            label1.Text+="*";
            op='*';
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            label1.Text ="0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label1.Text ="0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            label1.Text+="/";
            op='/';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Text +="2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="3";
            else
                label1.Text +="3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (label1.Text=="0")
                label1.Text="4";
            else
                label1.Text +="4";
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            label1.Text+="-";
            op='-';
        }

        private void btnEgale_Click(object sender, EventArgs e)
        {
            double resultat = 0;
            string[] operation = label1.Text.Split(op);
            switch (op)
            {
                case '+':
                    resultat=double.Parse(operation[0])+double.Parse(operation[1]);
                    break;
                case '-':
                    resultat=double.Parse(operation[0])-double.Parse(operation[1]);
                    break;
                case '*':
                    resultat=double.Parse(operation[0])*double.Parse(operation[1]);
                    break;
                case '/':
                    resultat=double.Parse(operation[0])/double.Parse(operation[1]);
                    break;
                default:
                    break;
            }
            label1.Text=resultat.ToString();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            int longueure = label1.Text.Length - 1;
            string texte = label1.Text;
            label1.Text=" ";
            for (int i = 0; i<longueure; i++)
                label1.Text+=texte[i];

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button button in buttons)
            {
                if (char.ToString(e.KeyChar) == button.Text)
                {
                    button.PerformClick();
                }

            }
            if (char.ToString(e.KeyChar) == "c")
            {
                btnCE.PerformClick();
            }
         
        }
    }
}
