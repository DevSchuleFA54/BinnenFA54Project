using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BinnenFA54Project.Forms.Misc;

namespace BinnenFA54Project.Main
{
    /// <summary>
    /// We use this enum to define what kind of loader we want to load.
    /// </summary>
    public enum LoaderSelector
    {
        /// <summary>
        /// The normal process loader.
        /// </summary>
        Loader        = 0,

        /// <summary>
        /// The splash screen loader.
        /// </summary>
        MainAppLoader = 1
    }

    class Loader
    {

        /// <summary>
        /// Importing this windows dll in order to set the focus of the window when loader finishes.
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);


        #region --- Variables -----------------------------------------------------------------

        private static LoaderSelector _loaderSelector;

        // Forms
        private static LoaderForm loaderForm;
        private static MainAppLoader mainAppLoader;
        #endregion // Variables -----------------------------------------------------------------


        /// <summary>
        /// With this method we start the loader we want by receiving an enum value which will
        /// tell what kind of loader we want to load.
        /// </summary>
        /// <param name="loader"></param>
        public static void StartLoader(LoaderSelector loader)
        {
            _loaderSelector = loader;

            switch (loader)
            {
                case LoaderSelector.Loader:
                    LoadFormOnThread(loaderForm = new LoaderForm());
                    break;
                case LoaderSelector.MainAppLoader:
                    LoadFormOnThread(mainAppLoader = new MainAppLoader());
                    break;
            }
        }

        
        /// <summary>
        /// With this method we stopping the running thread loader and sending the Handlers pointer
        /// so we can call the windows API method to set the window focus of the form from the
        /// form that uses the loader when the loader finishes.
        /// </summary>
        /// <param name="handle"></param>
        public static void StopLoader(IntPtr handle)
        {
            WindowToFront(handle);

            switch (_loaderSelector)
            {
                case LoaderSelector.Loader:
                    
                    loaderForm.Invoke((MethodInvoker)delegate
                    {
                        loaderForm?.Close();
                    });
                    break;
                case LoaderSelector.MainAppLoader:

                    mainAppLoader.Invoke((MethodInvoker)delegate
                    {
                        mainAppLoader?.Close();
                    });
                    break;
            }
        }


        /// <summary>
        /// Loads the loader on a separate thread so the main thread UI will be free while we displaying 
        /// another form.
        /// </summary>
        /// <param name="form"></param>
        private static void LoadFormOnThread(Form form)
        {
            new Thread(() => form.ShowDialog()).Start(); // same as delegate
        }


        /// <summary>
        /// Brings the window on front.
        /// Useful when using loaders.
        /// </summary>
        /// <param name="handle"></param>
        private static void WindowToFront(IntPtr handle)
        {
            SetForegroundWindow(handle.ToInt32());
        }

    }
}
