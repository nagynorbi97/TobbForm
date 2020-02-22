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
    public partial class fooldal : Form {
        public ablak parent;                                        //  Kell egy ablak típusú parent. Ez a főablakunk, amiben van minden.
        public fooldal(ablak parent) {                              //  Paraméterben megkapjuk az ablak.cs-től, hogy this, ez lesz az ablak maga.
            InitializeComponent();
            this.parent = parent;                                   //  Ezt eltároljuk a parent-be
        }
        private void button1_Click(object sender, EventArgs e) {
            this.parent.loadForm(new teszt1(parent));               //  Betöltjük a tesztet a parent metódusával
        }
        private void button2_Click(object sender, EventArgs e) {
            this.parent.loadForm(new leiras(parent));               // Betöltjük a leírást a parent metódusával
        }
    }
}
