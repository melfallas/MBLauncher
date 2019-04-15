using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiloStarter
{
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            InitializeComponent();
            this.loadControls();
        }

        public void loadControls()
        {
            this.versionAppLabel.Text = "";
            this.titleLabel.Text = "";
            this.updateProgressBar.Hide();
            this.loadStatusLabel.Hide();
            this.welcomeLabel.Text = "Este es el MB Launcher.";
            this.indicationLabel.Text = "Por favor autorice la aplicación para buscar actualizaciones.";
            this.loadStatusLabel.Text = "Buscando actualizaciones...";
        }

        public void showUpdateControls() {
            this.updateProgressBar.Show();
            this.loadStatusLabel.Show();
        }


        // Evento que lanza el chequeo de actualización
        private void updateButton_Click(object sender, EventArgs e)
        {
            this.showUpdateControls();
            this.checkVersionAndStart();
        }

        // Chequea la versión del sistema, actualiza de ser necesario y lanza la aplicación
        public void checkVersionAndStart()
        {
            bool availableUpdate = this.checkProgramVersion(SystemConst.APPLICATION_RELATIVE_PATH);
            // Si hay actualización disponible, descargarla
            this.loadStatusLabel.Text = "Actualizando la aplicación...";
            if (availableUpdate)
            {
                this.downloadProgramUpdate();
            }
            // Iniciar la aplicación
            this.loadStatusLabel.Text = "Iniciando la aplicación...";
            this.startApplicationProcess();
            this.Dispose();
        }

        // Obtiene la última versión del servidor
        public string getLastVersionFromServer()
        {
            //VersionUtil versionUtil = new VersionUtil();
            return VersionUtil.getLastVersionFromServer();
        }

        // Método para chequeo de la versión del programa
        public bool checkProgramVersion(string pExePath)
        {
            bool availableUpdate = false;
            string localVersion = VersionUtil.getApplicationVersion(pExePath);
            string serverVersion = this.getLastVersionFromServer();
            string resultString = "L: " + localVersion + " | S: " + serverVersion + " | " + VersionUtil.compareVersions(localVersion, serverVersion);
            Console.WriteLine(resultString);
            //if (String.Compare(localVersion, serverVersion) < 0)
            if (VersionUtil.compareVersions(localVersion, serverVersion) < 0)
            {
                // Si la versión local es menor, se debe realizar actualización
                availableUpdate = true;
                Console.WriteLine("Versión Local " + localVersion + " menor. Se requiere actualización.");
            }
            return availableUpdate;
        }

        // Método que realiza la actualización de la aplicación a su última versión 
        public void downloadProgramUpdate()
        {
            Console.WriteLine("Descargando fichero del ftp ...");
            string fileName = SystemConst.PROGRAM_EXE_NAME;
            string inputFilePath = Directory.GetCurrentDirectory();
            FTP_Utilities ftpUtil = new FTP_Utilities();
            ftpUtil.downloadFTPFile(inputFilePath, fileName);
            Console.WriteLine("Fichero descargado correctamente ...");
        }

        // Método que lanza el proceso de la aplicación
        public bool startApplicationProcess()
        {
            bool successInit = true;
            try
            {
                string domainBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                // Crear el proceso con base en la ruta y el directorio de la aplicación
                Process process = new Process();
                process.StartInfo.WorkingDirectory = domainBaseDirectory + SystemConst.PROGRAM_RELATIVE_DIRECTORY;
                process.StartInfo.FileName = domainBaseDirectory + SystemConst.APPLICATION_RELATIVE_PATH;
                // Configurar propiedade del proceso
                //process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                // Iniciar la aplicación
                process.Start();
            }
            catch (Win32Exception e)
            {
                successInit = false;
                MessageService.displayErrorMessage(
                        "No fue posible iniciar la aplicación.\nPor favor contacte al administrador.\n\nDetalle: " + e.Message + ".",
                        "ERROR AL INICIAR LA APLICACIÓN"
                );
            }
            catch (Exception e)
            {
                successInit = false;
                MessageService.displayErrorMessage(
                        "No fue posible iniciar la aplicación.\nPor favor contacte al administrador.\n\nDetalle: " + e.Message + ".",
                        "ERROR AL INICIAR LA APLICACIÓN"
                );
            }
            return successInit;
        }

        private void StartScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Cerrando SiloStarter");
        }
    }
}
