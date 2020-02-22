using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Test {
    public partial class ablak : Form {
        public ablak() {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;                   //  A panelt dokkoljuk az ablakba (vele együtt méreteződik)
            panel1.BringToFront();                          //  A panelt előtérbe kell hozni
            loadForm(new fooldal(this));                    //  Betöltéskor jelenítsük meg a főoldalt
        }
        public void loadForm(Form form) {
            if (panel1.Controls.Count>0) {                  //  Ha van bármilyen ablakunk...
                panel1.Controls.RemoveAt(0);                //  töröljük ki
            }
            form.TopLevel = false;                          //  Ezzel adjuk meg, hogy az új form nem megjelenő ablak
            form.AutoScroll = true;                         //  Legyen azért görgethető
            panel1.Controls.Add(form);                      //  Belerakjuk a panelbe
            form.FormBorderStyle = FormBorderStyle.None;    //  Ne legyen ablak kerete (tesztből kommenteljétek ki, rohadt menő)
            form.Dock = DockStyle.Fill;                     //  A formot dokkoljuk a panelbe (vele együtt méreteződik)
            form.Show();                                    //  Jelenítsük meg
        }
    }
}
