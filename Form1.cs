using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Sifre_Click(object sender, EventArgs e)
        {
            string sifreliMetin = coz(textBoxCumle.Text);
            cozumGoster("Şifreli Metin:", sifreliMetin);
        }
        void cozumGoster(string sifreliMetin, string cozulecekMetin)
        {
            label1.Text = sifreliMetin;
            label2.Text = cozulecekMetin;
        }
        string coz(string cozulecekMetin)
        {

            string cozulmusSonuc = "";
            foreach (char karakter in cozulecekMetin)
            {
                int ascii = (int)karakter;
                int yeniMetin = ascii - 1;
                char yeniKarakter = (char)yeniMetin;
                cozulmusSonuc += yeniMetin.ToString();


            }
            return cozulmusSonuc;
        }
    }
}
