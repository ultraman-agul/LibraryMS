using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class ReaderMain : Sunny.UI.UIForm
    {
        public ReaderMain()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void ReaderMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ReaderMain_Load(object sender, EventArgs e)
        {
            uiLabel3.Text = global.username;
        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
