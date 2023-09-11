using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scharp_bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        String Can, Chi;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(txtduonglich.Text.Substring(3,1)))
            {
                case 0:
                    Can = "Canh";
                    break;
                case 1:
                    Can = "tam";
                    break;
                case 2:
                    Can = "nham";
                    break;
                case 3:
                    Can = " Quy";
                    break;
                case 4:
                    Can = " giáp";
                    break;
                case 5:
                    Can = "Ất";
                    break;
                case 6:
                    Can = "Bính";
                    break;
                case 7:
                    Can = "Đinh";
                    break;
                case 8:
                    Can = "Mậu";
                    break;
                case 9:
                    Can = "kỵ";
                    break;

            }
            switch (Convert.ToInt32(txtduonglich.Text) % 12)
            {

                case 0:
                    Chi = "thân";
                    break;
                case 1:
                    Chi = "Dậu";
                    break;
                case 2:
                    Chi = "Tuất";
                    break;
                case 3:
                    Chi = "Hợi";
                    break;
                case 4:
                    Chi = "tý";
                    break;
                case 5:
                    Chi = "sửu";
                    break;
                case 6:
                    Chi = "Dần";
                    break;
                case 7:
                    Chi = "Mão";
                    break;
                case 8:
                    Chi = "Thìn";
                    break;
                case 9:
                    Chi = "tị";
                    break;
               case 10:
                    Chi = "Ngọ";
                    break;
                case 11:
                    Chi = "Mùi";
                    break;
            }
            txtamlich.Text = Can + " " + Chi;
        }
    }
}