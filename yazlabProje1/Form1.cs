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

            //FotoClass.FotoDictionary.Clear();
            for (int i = 21; i <= 70; i++)
            {
                FotoClass.FotoDictionary.Remove(i);
            }

            FotoClass.FotoDictionary.Add(21, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sutlac.jpg");
            FotoClass.FotoDictionary.Add(22, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//baklava.jpg");
            FotoClass.FotoDictionary.Add(23, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//revani.jpeg");
            FotoClass.FotoDictionary.Add(24, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//muhallebi.jpg");
            FotoClass.FotoDictionary.Add(25, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sekerpare.jpg");
            FotoClass.FotoDictionary.Add(26, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//supangle.jpg");
            FotoClass.FotoDictionary.Add(27, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kazandibi.jpg");
            FotoClass.FotoDictionary.Add(28, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//trilece.jpg");
            FotoClass.FotoDictionary.Add(29, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//asure.jpg");
            FotoClass.FotoDictionary.Add(30, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//gullac.jpg");
            FotoClass.FotoDictionary.Add(31, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//mercimekcorbasi.jpg");
            FotoClass.FotoDictionary.Add(32, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//taratorcorbasi.jpg");
            FotoClass.FotoDictionary.Add(33, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//domatescorbasi.jpg");
            FotoClass.FotoDictionary.Add(34, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//yaylacorbasi.jpg");
            FotoClass.FotoDictionary.Add(35, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//tavukcorbasi.jpg");
            FotoClass.FotoDictionary.Add(36, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sehriyecorbasi.jpg");
            FotoClass.FotoDictionary.Add(37, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kiscorbasi.jpg");
            FotoClass.FotoDictionary.Add(38, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//brokolicorbasi.jpg");
            FotoClass.FotoDictionary.Add(39, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sebzecorbasi.jpg");
            FotoClass.FotoDictionary.Add(40, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//mantarcorbasi.jpg");
            FotoClass.FotoDictionary.Add(41, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//ayran.jpg");
            FotoClass.FotoDictionary.Add(42, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//limonata.jpg");
            FotoClass.FotoDictionary.Add(43, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//turkkahvesi.jpg");
            FotoClass.FotoDictionary.Add(44, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//meyvesuyu.jpg");
            FotoClass.FotoDictionary.Add(45, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//mocha.jpg");
            FotoClass.FotoDictionary.Add(46, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//smoothie.jpg");
            FotoClass.FotoDictionary.Add(47, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//bitkicayi.jpg");
            FotoClass.FotoDictionary.Add(48, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sut.jpg");
            FotoClass.FotoDictionary.Add(49, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//tazenanelimonata.jpg");
            FotoClass.FotoDictionary.Add(50, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//chai.jpg");
            FotoClass.FotoDictionary.Add(51, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//tavuksote.jpg");
            FotoClass.FotoDictionary.Add(52, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kumpir.jpg");
            FotoClass.FotoDictionary.Add(53, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//zeytinyaglienginar.jpg");
            FotoClass.FotoDictionary.Add(54, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//firindakumpir.jpg");
            FotoClass.FotoDictionary.Add(55, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kiymalipide.jpg");
            FotoClass.FotoDictionary.Add(56, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//karniyarik.jpg");
            FotoClass.FotoDictionary.Add(57, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//besamelsoslukarnabahar.jpg");
            FotoClass.FotoDictionary.Add(58, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//tavuksnitzel.jpg");
            FotoClass.FotoDictionary.Add(59, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kabakmucver.jpg");
            FotoClass.FotoDictionary.Add(60, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//spaghettiaglioeolio.jpg");
            FotoClass.FotoDictionary.Add(61, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sadepilav.jpg");
            FotoClass.FotoDictionary.Add(62, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//sebzelipilav.jpg");
            FotoClass.FotoDictionary.Add(63, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//tavuklupilav.jpg");
            FotoClass.FotoDictionary.Add(64, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kiymalipilav.jpg");
            FotoClass.FotoDictionary.Add(65, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//nohutlupilav.jpg");
            FotoClass.FotoDictionary.Add(66, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//kuruuzumlupilav.jpg");
            FotoClass.FotoDictionary.Add(67, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//fistiklipilav.jpg");
            FotoClass.FotoDictionary.Add(68, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//mantarlipilav.jpg");
            FotoClass.FotoDictionary.Add(69, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//taratorlupilav.jpg");
            FotoClass.FotoDictionary.Add(70, "C://Users//yilma//OneDrive//Masaüstü//yazlabresimler//zeytinyaglipilav.jpg");
            
             

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
            panel3.Controls.Clear();
            TumTariflerinListelenmesi tariflistele = new TumTariflerinListelenmesi();
            tariflistele.MdiParent = this;
            tariflistele.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(tariflistele);
            tariflistele.Show();

           
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

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            TumTariflerinListelenmesi tariflistele =new TumTariflerinListelenmesi();
            tariflistele.MdiParent = this;
            tariflistele.FormBorderStyle= FormBorderStyle.None;
            panel3.Controls.Add(tariflistele);
            tariflistele.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
