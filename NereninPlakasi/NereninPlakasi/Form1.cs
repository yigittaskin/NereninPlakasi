//YGT
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NereninPlakasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);

            switch (plaka)
            {
                case 1:
                    label2.Text = "Adana";
                    break;
                case 2:
                    label2.Text = "Adıyaman";
                    break;
                case 3:
                    label2.Text = "Afyon";
                    break;
                case 4:
                    label2.Text = "Ağrı";
                    break;
                case 5:
                    label2.Text = "Amasya";
                    break;
                case 6:
                    label2.Text = "Ankara";
                    break;
                case 7:
                    label2.Text = "Antalya";
                    break;
                case 8:
                    label2.Text = "Artvin";
                    break;
                case 9:
                    label2.Text = "Aydın";
                    break;
                case 10:
                    label2.Text = "Balıkesir";
                    break;
                case 11:
                    label2.Text = "Bilecik";
                    break;
                case 12:
                    label2.Text = "Bingöl";
                    break;
                case 13:
                    label2.Text = "Bitlis";
                    break;
                case 14:
                    label2.Text = "Bolu";
                    break;
                case 15:
                    label2.Text = "Burdur";
                    break;
                case 16:
                    label2.Text = "Bursa";
                    break;
                case 17:
                    label2.Text = "Çanakkale";
                    break;
                case 18:
                    label2.Text = "Çankırı";
                    break;
                case 19:
                    label2.Text = "Çorum";
                    break;
                case 20:
                    label2.Text = "Denizli";
                    break;
                case 21:
                    label2.Text = "Diyarbakır";
                    break;
                case 22:
                    label2.Text = "Edirne";
                    break;
                case 23:
                    label2.Text = "Elazığ";
                    break;
                case 24:
                    label2.Text = "Erzincan";
                    break;
                case 25:
                    label2.Text = "Erzurum";
                    break;
                case 26:
                    label2.Text = "Eskişehir";
                    break;
                case 27:
                    label2.Text = "Gaziantep";
                    break;
                case 28:
                    label2.Text = "Giresun";
                    break;
                case 29:
                    label2.Text = "Gümüşhane";
                    break;
                case 30:
                    label2.Text = "Hakkari";
                    break;
                case 31:
                    label2.Text = "Hatay";
                    break;
                case 32:
                    label2.Text = "Isparta";
                    break;
                case 33:
                    label2.Text = "MERSİN";
                    break;
                case 34:
                    label2.Text = "İstanbul";
                    break;
                case 35:
                    label2.Text = "İzmir";
                    break;
                case 36:
                    label2.Text = "Kars";
                    break;
                case 37:
                    label2.Text = "Kastamonu";
                    break;
                case 38:
                    label2.Text = "Kayseri";
                    break;
                case 39:
                    label2.Text = "Kırklareli";
                    break;
                case 40:
                    label2.Text = "Kırşehir";
                    break;
                case 41:
                    label2.Text = "KOCAELİ";
                    break;
                case 42:
                    label2.Text = "Konya";
                    break;
                case 43:
                    label2.Text = "Kütahya";
                    break;
                case 44:
                    label2.Text = "Malatya";
                    break;
                case 45:
                    label2.Text = "Manisa";
                    break;
                case 46:
                    label2.Text = "K.Maraş";
                    break;
                case 47:
                    label2.Text = "Mardin";
                    break;
                case 48:
                    label2.Text = "Muğla";
                    break;
                case 49:
                    label2.Text = "Muş";
                    break;
                case 50:
                    label2.Text = "Nevşehir";
                    break;
                case 51:
                    label2.Text = "Niğde";
                    break;
                case 52:
                    label2.Text = "Ordu";
                    break;
                case 53:
                    label2.Text = "Rize";
                    break;
                case 54:
                    label2.Text = "Sakarya";
                    break;
                case 55:
                    label2.Text = "Samsun";
                    break;
                case 56:
                    label2.Text = "Siirt";
                    break;
                case 57:
                    label2.Text = "Sinop";
                    break;
                case 58:
                    label2.Text = "Sivas";
                    break;
                case 59:
                    label2.Text = "Tekirdağ";
                    break;
                case 60:
                    label2.Text = "Tokat";
                    break;
                case 61:
                    label2.Text = "Trabzon";
                    break;
                case 62:
                    label2.Text = "Tunceli";
                    break;
                case 63:
                    label2.Text = "Şanlıurfa";
                    break;
                case 64:
                    label2.Text = "Uşak";
                    break;
                case 65:
                    label2.Text = "Van";
                    break;
                case 66:
                    label2.Text = "Yozgat";
                    break;
                case 67:
                    label2.Text = "Zonguldak";
                    break;
                case 68:
                    label2.Text = "Aksaray";
                    break;
                case 69:
                    label2.Text = "Bayburt";
                    break;
                case 70:
                    label2.Text = "Karaman";
                    break;
                case 71:
                    label2.Text = "Kırıkkale";
                    break;
                case 72:
                    label2.Text = "Batman";
                    break;
                case 73:
                    label2.Text = "Şırnak";
                    break;
                case 74:
                    label2.Text = "Bartın";
                    break;
                case 75:
                    label2.Text = "Ardahan";
                    break;
                case 76:
                    label2.Text = "Iğdır";
                    break;
                case 77:
                    label2.Text = "Yalova";
                    break;
                case 78:
                    label2.Text = "Karabük";
                    break;
                case 79:
                    label2.Text = "Kilis";
                    break;
                case 80:
                    label2.Text = "Osmaniye";
                    break;
                case 81:
                    label2.Text = "Düzce";
                    break;
                case 82:
                    label2.Text = "Musul";
                    break;
                case 83:label2.Text = "Kerkük";
                    break;
                default:label2.Text = "Geçersiz plaka kodu girdiniz...";
                    break;
            }
        }
    }
}
