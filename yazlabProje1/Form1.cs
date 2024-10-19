using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlabProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menubutonu_Click(object sender, EventArgs e)
        {
            menuformu menuformu = new menuformu();
            menuformu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MalzemeForm malzemeForm = new MalzemeForm();
            malzemeForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void tarifgoruntulebutonu_Click(object sender, EventArgs e)
        {
            tarifgoruntuleformu tarifgoruntuleformu = new tarifgoruntuleformu();
            tarifgoruntuleformu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            siralamaformu siralamaForm = new siralamaformu();
            siralamaForm.Show();
        }
    }
}
