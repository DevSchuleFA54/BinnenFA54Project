using System.Drawing;
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
