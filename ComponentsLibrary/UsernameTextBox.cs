using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentsLibrary
{
    public partial class UsernameTextBox : System.Windows.Forms.TextBox
    {
        public UsernameTextBox()
        {
            InitializeComponent();
        }

        public UsernameTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            // Only allow letters and numbers to be input.
            this.Text = string.Concat(this.Text.Where(char.IsLetterOrDigit));
            this.SelectionStart = this.Text.Length + 1;
        }
    }
}
