using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiloStarter
{
    class ApplicationLauncher : Form
    {
        private StartScreenForm starterScreen;
        public static EventWaitHandle waitHandle = new AutoResetEvent(false);

        public ApplicationLauncher() {
            this.starterScreen = null;
            this.launchSplashThread();
        }


        private void launchSplashThread()
        {
            // Lanzar el Thread para el Splash Screen
            Thread starterThread = new Thread(new ThreadStart(launchAppUpdater));
            starterThread.Start();
        }

        private void launchAppUpdater()
        {
            this.starterScreen = new StartScreenForm();
            ApplicationLauncher.waitHandle.Set();
            Application.Run(this.starterScreen);
        }



    }
}
