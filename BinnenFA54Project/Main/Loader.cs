using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        private static Thread _loader;
        private static LoaderSelector _loaderSelector;



        public static void StartLoader(LoaderSelector loader)
        {
            _loaderSelector = loader;
            _loader = new Thread(new ThreadStart(Load));
            _loader.Start();
        }



        public static void StopLoader()
        {
            try
            {
                _loader.Abort(); // if failed to kill thread
            }
            catch (ThreadAbortException)
            {
                _loader.Abort(); // try again
            }
            finally
            {
                _loader.Abort(); // if it didn't manage, give last shot.
            }

        }


        private static void Load()
        {
            if (LoaderSelector.MainAppLoader == _loaderSelector)
            {
                MainAppLoader appMainLoader = new MainAppLoader();
                Application.Run(appMainLoader);
            }
            else
            {
                LoaderForm loader = new LoaderForm();
                Application.Run(loader);
            }
        }


    }
}
