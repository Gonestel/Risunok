using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double[] A = {1, -2, -1, 2};
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.SetBackColor(Color.Violet);
            userControl11.AddCell(5, 4, Color.Green, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.DeleteCell();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.AddPolinomGraphic();
        }
    }
}
