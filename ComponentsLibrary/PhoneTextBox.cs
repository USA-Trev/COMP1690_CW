using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ComponentsLibrary
{
    public partial class PhoneTextBox : System.Windows.Forms.TextBox
    {
        public TextBox tb = new TextBox();
        public PhoneTextBox()
        {
            InitializeComponent();
        }

        public PhoneTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Prevent letters from being input in the textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // Text turns red if more than 11 numbers are input
            if (this.Text.Length > 11)
            {
                this.ForeColor = Color.Red;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
            base.OnTextChanged(e);
        }
    }
}
