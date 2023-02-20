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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            var list = new List<UCItemUI>();
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    var ui = new UCItemUI();
                    ui.NameUI = $"{row}x{col}";
                    list.Add(ui);
                }
            }
            this.flowLayoutPanel1.Controls.AddRange(list.ToArray());
            this.ResumeLayout(true);
        }
    }
}
