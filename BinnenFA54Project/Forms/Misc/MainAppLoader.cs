using System.Drawing;
using System.Windows.Forms;

namespace BinnenFA54Project.Forms.Misc
{
    public partial class MainAppLoader : Form
    {
        public MainAppLoader()
        {
            InitializeComponent();
            pbBackground.BackColor = Color.Transparent;
            pbBackground.Controls.Add(pbLoading);
            pbLoading.Location = new Point(231, 145);
            pbLoading.BackColor = Color.Transparent;
        }
    }
}
