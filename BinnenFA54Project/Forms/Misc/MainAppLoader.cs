using System.Drawing;
using System.Windows.Forms;

namespace BinnenFA54Project.Forms.Misc
{
    public partial class MainAppLoader : Form
    {
        /// <summary>
        /// Splash screen that will be displayed with animated water background and loading gif image as 
        /// soon as the application started.
        /// Can be used from the Loaders.cs class like:
        /// Loader.StartLoader(LoaderSelector.MainAppLoader);
        /// and to end:
        /// Loader.Stoploader(this.Handle);
        /// Which will end the background thread so application doesn't freeze while we displaying the loaders.
        /// </summary>
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
