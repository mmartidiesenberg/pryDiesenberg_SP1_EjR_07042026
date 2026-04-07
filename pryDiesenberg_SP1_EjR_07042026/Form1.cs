using System;
using System.Windows.Forms;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public partial class Form1 : Form
    {
        public Form1()
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
