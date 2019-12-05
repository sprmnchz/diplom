using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tech_spech_2
{
    public partial class new_cartridge : Form
    {
        public new_cartridge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client client_form = new client();
            client_form.Show();
        }
    }
}
