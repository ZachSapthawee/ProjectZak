using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_POS
{
    public partial class Menu : UserControl
    {
        int i = 0;
        string[] Num= new string[1500];
        string[] Me_nu = new string[1500];
        string[] Price = new string[1500];
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Num[i] = (i + 1).ToString();
           Me_nu[i] = "Esspresso_Hot";
           Price[i] = "35";
    }
    }
}
