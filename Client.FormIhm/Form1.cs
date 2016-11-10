using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Sql;

namespace Client.FormIhm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sql test = new Sql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bagage = MyAirport.Pim.Model.Factory.Model.GetBagage(10);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
