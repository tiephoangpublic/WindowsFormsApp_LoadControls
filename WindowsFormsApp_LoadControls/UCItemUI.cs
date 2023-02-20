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
    public partial class UCItemUI : UserControl
    {
        public UCItemUI()
        {
            InitializeComponent();
        }

        public string NameUI
        {
            get => Controls[0].Text;
            set => Controls.Cast<Control>().ToList().ForEach(q => q.Text = value);
        }
    }
}
