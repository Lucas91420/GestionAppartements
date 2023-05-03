using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gestiondeappartement
{
    public partial class FormButtonHome : Form
    {
        public FormButtonHome()
        {
            InitializeComponent();
        }

        private void btnCasqueHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManteauHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMasqueHome_Click(object sender, EventArgs e)
        {
            lblTitleChildForm lblTitleChildForm = new lblTitleChildForm();
            lblTitleChildForm.Show();
        }
    }
}
