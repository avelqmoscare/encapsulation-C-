using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncapsulationAndMethods
{
    public partial class frmPrivateAccess : Form
    {
        public frmPrivateAccess()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            AccessSpecifier ResultMessage = new AccessSpecifier();
            MessageBox.Show(ResultMessage.ShowMessage());
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            frmPublicAccess frmPublic = new frmPublicAccess();
            frmPublic.Show();
            this.Hide();
        }
    }
}
