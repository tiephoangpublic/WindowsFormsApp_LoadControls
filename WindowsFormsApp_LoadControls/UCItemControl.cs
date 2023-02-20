using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_LoadControls
{
    public partial class UCItemControl : UserControl
    {
        public UCItemControl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get => this.label1.Text;
            set => this.label1.Text = value;
        }
    }
}
