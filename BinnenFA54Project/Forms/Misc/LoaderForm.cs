using System.Windows.Forms;

namespace BinnenFA54Project.Forms.Misc
{
    /// <summary>
    /// Process Loader that will be displayed with spinning gif image.
    /// Can be used from the Loaders.cs class as:
    /// Loader.StartLoader(LoaderSelector.Loader);
    /// and to end:
    /// Loader.Stoploader(this.Handle);
    /// Which will end the background thread so application doesn't freeze while we displaying the loaders.
    /// </summary>
    public partial class LoaderForm : Form
    {
        public LoaderForm()
        {
            InitializeComponent();
        }
    }
}
