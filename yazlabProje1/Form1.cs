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
            this.IsMdiContainer = true;
        }

        private void menubutonu_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            menuformu menuformu1 = new menuformu();
            menuformu1.MdiParent = this;
            menuformu1.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(menuformu1);
            menuformu1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            MalzemeForm malzemeForm = new MalzemeForm();
            malzemeForm.MdiParent = this;
            malzemeForm.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(malzemeForm);
            malzemeForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void tarifgoruntulebutonu_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            tarifgoruntuleformu tarifgoruntuleformu = new tarifgoruntuleformu();
            tarifgoruntuleformu.MdiParent= this;
            tarifgoruntuleformu.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(tarifgoruntuleformu);
            tarifgoruntuleformu.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            siralamaformu siralamaForm = new siralamaformu();
            siralamaForm.MdiParent = this;
            siralamaForm.FormBorderStyle= FormBorderStyle.None;
            panel3.Controls.Add(siralamaForm);
            siralamaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Tarifonerisi tarifonerisi = new Tarifonerisi();
            tarifonerisi.MdiParent=this;
            tarifonerisi.FormBorderStyle= FormBorderStyle.None;
            panel3.Controls.Add(tarifonerisi);
            tarifonerisi.Show();
        }

        
    }
}
