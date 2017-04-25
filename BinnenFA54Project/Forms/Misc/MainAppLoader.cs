using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinnenFA54Project.Forms.Misc
{
    public partial class MainAppLoader : Form
    {
        public MainAppLoader()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(231, 145);
            pictureBox2.BackColor = Color.Transparent;
        }
    }
}
