using System;
using System.Windows.Forms;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
            this.Close();
        }
    }
}
