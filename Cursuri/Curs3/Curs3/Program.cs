using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs3
{
    class Fer_mea : Form
    {
        Button bt1,bt2;
        public Fer_mea()
        {
           this.Text = "Prima APP WF";
           bt1 = new Button();
           bt1.Text = "Apasa";
           bt1.Location = new Point(20,30);
           bt1.Width = 150;
           bt1.Click += Bt1_Click;

           bt2 = new Button();
           bt2.Text = "Push";
           bt2.Location = new Point(20, 30+bt1.Height+3);
           bt2.Width = 150;
           bt2.Click += Bt1_Click;
           this.Controls.Add(bt1);
           this.Controls.Add(bt2);

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            MessageBox.Show("Ai apasat "+s);
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new Fer_mea());
        }
    }
}
