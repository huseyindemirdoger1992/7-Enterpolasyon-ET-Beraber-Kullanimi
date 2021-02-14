using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Enterpolasyon_ET_Beraber_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = 8;
            s2 = 4;
            int Sonuc = 8 / 4;
            // Dolar işareti ile skop içlerine değer ataması yapılabilirken 
            // @ işareti ile de sağ ve sol slaş lar kullanılabilinir.
            string Ornek = $@"{s1} \ {s2} Sonucu  {Sonuc}";

        }
    }
}
