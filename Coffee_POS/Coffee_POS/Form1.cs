using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_POS
{
    public partial class Form1 : Form
    {
        string Save_F = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();


        }

        public void Menu_(string menu, string bath)
        {
            string[] Me_z = { menu, bath };
            var Addlist = new ListViewItem(Me_z);
            listView1.Items.Add(Addlist);
            Show_T();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Menu_("Esspesso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_("Esspesso(Cold)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_("Esspesso(Frappe)", "50");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Menu_("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu_("Americano(Cold)", "45");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu_("Americano(Frappe)", "50");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Menu_("Latte(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu_("Latte(Cold)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Menu_("Latte(Frappe)", "50");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Menu_("Mocha(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Menu_("Mocha(Cold)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Menu_("Mocha(Frappe)", "50");
        }
        private void button25_Click(object sender, EventArgs e)
        {
            Menu_("Cappuccino(Hot)", "35");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Menu_("Cappuccino(Cold)", "45");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Menu_("Cappuccino(Frappe)", "50");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Menu_("Green Tea(Hot)", "20");
        }
        private void button27_Click(object sender, EventArgs e)
        {
            Menu_("Green Tea(Cold)", "25");
        }
        private void button35_Click(object sender, EventArgs e)
        {
            Menu_("Green Tea(Frappe)", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Menu_("Cocoa(Hot)", "20");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Menu_("Cocoa(Cold)", "25");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Menu_("Cocoa(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Menu_("Milk(Hot)", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Menu_("Milk(Cold)", "25");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Menu_("Milk(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Menu_("Thai Tea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Menu_("Thai Tea(Cold)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Menu_("Thai Tea(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Menu_("Milk Tea(Cold)", "25");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Menu_("Milk Tea(Frappe)", "30");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Menu_("Lemon Tea(Cold)", "25");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Menu_("Lemon Tea(Frappe)", "30");
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Menu_("Milo(Hot)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Menu_("Milo(Cold)", "25");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Menu_("Milo(Frappe)", "30");
        }
        private void button36_Click(object sender, EventArgs e)
        {
            Menu_("Nescafe(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Menu_("Nescafe(Cold)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Menu_("Nescafe(Frappe)", "30");
        }
        private void button30_Click(object sender, EventArgs e)
        {
            Menu_("Italian Soda(Cold)", "25");
        }
        private void button31_Click(object sender, EventArgs e)
        {
            Menu_("Red lime Soda(Cold)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Menu_("Honey lime Soda(Cold)", "25");
        }
        double Pa;
        private int i;

        public string[] Show_T()
        {
            Pa = 0;
            string[] Za = new string[listView1.Items.Count];
            int S = listView1.Items.Count;
            for (int i = 0; i < S; i++)
            {
                Pa += double.Parse(listView1.Items[i].SubItems[1].Text);
                Za[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            LB_Total.Text = Pa.ToString();
            return Za;
        }
        public string[] Show_T1()
        {
          string[]  Za = new string[listView1.Items.Count];
          int S = listView1.Items.Count;
          for (int i = 0; i < S; i++)
          {
             Za[i] = listView1.Items[i].SubItems[0].Text.ToString();
          }
          return Za;
        }
        public void Show_bill()
        {
            string[] Sh = Show_T();
            string[] Sh1 = Show_T1();
            string DT = "Zak Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string DT_ = "                                     Be more cafe                               \r\n" + "                                     สาขาที่ 1(112)                            ";
            DT_ += "\r\n" +"Time :"+ DateTime.Now.ToString("hh:mm:ss")  +"                                           "+ "Date :" + DateTime.Now.ToString("dd:mm:yyyy") + "\r\n" + "\r\n"+
                "\r\n"+ "                      ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ                      " + "\r\n";
            
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                DT_ += Sh[i] + new String(' ', 20) + "                     "+"\r\n";
            }
            DT_ += "\r\n";
            DT_ += "Total Price : " + LB_Total.Text;
            System.IO.File.WriteAllText(Save_F + @"\" + DT + ".txt", DT_);
            TB_bill.Text += DT_ + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at : " + Save_F + @"\" + DT + ".txt";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl2.Controls.Remove(Payment);
        }
        bool Sa = false;

        private void button46_Click(object sender, EventArgs e)
        {
            TB_bill.Text = "";
            if (Sa == false)
            {
                tabControl2.TabPages.Insert(1, Payment); Sa = true;
                tabControl2.SelectedTab = Payment;
            }
            else
            {
                tabControl2.SelectedTab = Payment;
            }
            if (listView1.Items.Count > 0)
                Show_bill();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Sa = false;
            tabControl2.Controls.Remove(Payment);
            LB_Total.Text = "";
            TB_bill.Text = "";
        }

    }
}
