using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class contact : UserControl
    {
        public contact()
        {
            InitializeComponent();
            LabelJovan.Text = "Rodjen sam 27.05.1999 " +
                "godine u mestu Sokolac, RS, BIH. Maturirao 2018. godine sa" + " " +
                "odlicnim uspehom. Student sam trece godine smera informacionih " +
                "tehnologija na fakultetu tehnickih nauka u Cacku." + "\n" +
                "Email: jocololika9@gmail.com";
            LabelIvan.Text = "Rodjen u Beogradu 1999. godine, trenutno zivim u Gorazdevcu nadomak Peci. " +
                "Student sam trece godine na smeru IT. " +
                "Hobiji: sport, putovanja, muzika, filmovi. " + "\n" +
                "Email: krstic8687@yahoo.com";
            LabelMarko.Text = "Dolazim iz Vranja, student sam trece godine na smeru IT. " +
                "Hobiji: Angular, stoni tenis, filmovi i muzika. " + "\n" +
                "Iskustva: Edit Comtrade, Centar za mlade talente Novi Sad." + "\n" +
                "Email: srecanmare9@gmail.com";

        }

        private void Contact_Load(object sender, EventArgs e)
        {
            panelMarko.SendToBack();
            panelIvan.BringToFront();
            panelJovan.SendToBack();
        }
        
        private void BtnIvanLeft_Click(object sender, EventArgs e)
        {
            panelMarko.BringToFront();
            panelIvan.SendToBack();
            panelJovan.SendToBack();
        }

        private void BtnIvanRight_Click(object sender, EventArgs e)
        {
            panelIvan.SendToBack();
            panelMarko.SendToBack();
            
            panelJovan.BringToFront();
        }

        private void BtnIvanCenter_Click(object sender, EventArgs e)
        {
            panelIvan.BringToFront();
            panelMarko.SendToBack();
            panelJovan.SendToBack();
        }

        
    }
}
