using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs3_app_elem
{
   
    public partial class Form1 : Form
    {
        Element obiect_element;

        public Form1()
        {
            InitializeComponent();
            obiect_element.Ev_Modificare_Valoare += Obiect_element_Ev_Modificare_Valoare;
        }

        private void Obiect_element_Ev_Modificare_Valoare(Element obj)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
