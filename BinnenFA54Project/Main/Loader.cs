using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BinnenFA54Project.Forms.Misc;

namespace BinnenFA54Project.Main
{
    public enum LoaderSelector
    {
        Loader        = 0,
        MainAppLoader = 1
    }

    class Loader
    {
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);



        private static LoaderSelector _loaderSelector;

        // Forms
        private static LoaderForm loaderForm;
        private static MainAppLoader mainAppLoader;

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


        public static void StopLoader(IntPtr handle)
        {
            WindowToFront(handle);

            switch (_loaderSelector)
            {
                case LoaderSelector.Loader:
                    loaderForm?.Close();
                    break;
                case LoaderSelector.MainAppLoader:
                    mainAppLoader?.Close();
                    break;
            }
        }


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
