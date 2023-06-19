using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoLaDrinkManager
{
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        private void itLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itPersonalInfo_Click(object sender, EventArgs e)
        {
            FrmAccountInfo f = new FrmAccountInfo();
            f.ShowDialog();
        }

        private void itAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin f = new FrmAdmin();
            f.ShowDialog();
        }
    }
}
