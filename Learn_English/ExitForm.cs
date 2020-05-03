using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_English
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void noExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartMenu.ActiveForm.Close();
        }
    }
}
