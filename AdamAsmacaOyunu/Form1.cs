using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<string> Kelimeler = new List<string> { "MANİSA", "MALATYA", "KASTAMONU", "KAYSERİ", "KIRŞEHİR", "İZMİR", "ANKARA", "İSTANBUL" };
        string secilen;
        int sayac = 0;
        int hak = 6;
        int harf;
        Random rnd= new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Kelimeler = new List<string> { "MANİSA", "MALATYA", "KASTAMONU","KAYSERİ","KIRŞEHİR","İZMİR","ANKARA","İSTANBUL" };
            
            pictureBox1.Load("Gorseller/aa" + sayac + ".png");
            secilen=Kelimeler[rnd.Next(Kelimeler.Count)];
            label5.Text= secilen;
            harf = secilen.Length;
            label6.Text =Convert.ToString(harf);
            label7.Text = Convert.ToString(hak);
            for (int i=0;i<secilen.Length;i++)
            {
                label4.Text += "_ ";
            }
             
        }


        private void HarfSec(object sender, EventArgs e)
        {
            Button seciliBtn = sender as Button;
           
            if (secilen.Contains(seciliBtn.Text) == false)
            {
                sayac++;
                hak--;
                label7.Text = Convert.ToString(hak);
                pictureBox1.Load("Gorseller/aa" + sayac + ".png");
            }
           
            else
            {
                string text = label4.Text.Replace(" ", "");
                for (int i = 0; i < secilen.Length; i++)
                {
                    if (secilen[i].ToString() == seciliBtn.Text)
                    {

                        text = ReplaceAt(text, i, 1, seciliBtn.Text);

                    }
                }
                string sonuc = "";
                for (int i = 0; i < text.Length; i++)
                {
                    sonuc += text[i].ToString() + " ";
                    label4.Text = sonuc;
                   
                }
            }
            if (hak == 0)
            {
                DialogResult dialogResult = MessageBox.Show("KAYBETTİNİZ... Kelime : " + secilen + " Yeniden Oynamak İster Misiniz?", "Adam Asmaca ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Application.Restart();
                else
                    Application.Exit();
            }
            if (label4.Text.Replace(" ", "") == secilen)
            {

                DialogResult dialogResult = MessageBox.Show("KAZANDINIZ...  Kelime : " + secilen + " Yeniden Oynamak İster Misiniz?", "Adam Asmaca ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Application.Restart();
                else
                    Application.Exit();
            }

        }

        public string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }


        
    }
}
