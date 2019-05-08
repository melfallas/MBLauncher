using SiloStarter.App.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SiloStarter
{
    public class FTP_Utilities
    {

        private ConfigModel configModel;


        public FTP_Utilities(ConfigModel pConfig)
        {
            this.configModel = pConfig;
        }

        public bool downloadFTPFile(string inputfilepath, string fileName)
        {
            bool successDownload = true;
            inputfilepath = inputfilepath + SystemConst.FTP_DOWNLOAD_FILE_PATH + fileName;
            string ftphost = configModel.updAccess;
            string ftpfilepath = configModel.updPath + fileName;
            string ftpfullpath = SystemConst.FTP_PROTOCOL_PREFIX + ftphost + ftpfilepath;
            try
            {
                using (WebClient request = new WebClient())
                {
                    request.Credentials = new NetworkCredential(configModel.updUser, configModel.updPass);
                    byte[] fileData = request.DownloadData(ftpfullpath);
                    using (FileStream file = File.Create(inputfilepath))
                    {
                        file.Write(fileData, 0, fileData.Length);
                        file.Close();
                    }
                }
            }
            //catch (WebException e) {
            catch (Exception e)
            {
                successDownload = false;
                MessageService.displayWarningMessage(
                        "No fue posible descargar la actualización.\nPor favor contacte al administrador.\n\nDetalle: " + e.Message + ".",
                        "ERROR EN LA DESCARGA"
                );
                // TODO: Log
                Console.WriteLine("ERROR descargando fichero: ", e.Message);
            }
            return successDownload;
        }

        /*
        public bool downloadFTPFile(string inputfilepath, string fileName)
        {
            bool successDownload = true;
            inputfilepath = inputfilepath + SystemConst.FTP_DOWNLOAD_FILE_PATH + fileName;
            string ftphost = SystemConst.FTP_ROOT_HOST;
            string ftpfilepath = SystemConst.FTP_ROOT_PATH + fileName;
            string ftpfullpath = SystemConst.FTP_PROTOCOL_PREFIX + ftphost + ftpfilepath;
            try
            {
                using (WebClient request = new WebClient())
                {
                    request.Credentials = new NetworkCredential(SystemConst.FTP_USER, SystemConst.FTP_PASS);
                    byte[] fileData = request.DownloadData(ftpfullpath);
                    using (FileStream file = File.Create(inputfilepath))
                    {
                        file.Write(fileData, 0, fileData.Length);
                        file.Close();
                    }
                }
            }
            //catch (WebException e) {
            catch (Exception e)
            {
                successDownload = false;
                MessageService.displayWarningMessage(
                        "No fue posible descargar la actualización.\nPor favor contacte al administrador.\n\nDetalle: " + e.Message + ".",
                        "ERROR EN LA DESCARGA"
                );
                // TODO: Log
                Console.WriteLine("ERROR descargando fichero: ", e.Message);
            }
            return successDownload;
        }
        */

    }
}
