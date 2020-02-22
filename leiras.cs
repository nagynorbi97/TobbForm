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
    public partial class leiras : Form {
        public ablak parent;
        public leiras(ablak parent) {
            InitializeComponent();
            this.parent = parent;
        }
        private void button1_Click(object sender, EventArgs e) {
            this.parent.loadForm(new fooldal(parent));
        }
    }
}
