using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiloStarter
{
    public class VersionUtil
    {

        public static int compareVersions(string pVersion1, string pVersion2)
        {
            int result = 0;
            int valueVersion1 = getVersionValue(pVersion1);
            int valueVersion2 = getVersionValue(pVersion2);
            if (valueVersion1 > valueVersion2)
            {
                result = 1;
            }
            else
            {
                if (valueVersion1 < valueVersion2)
                {
                    result = -1;
                }
            }
            return result;
        }

        public static int getVersionValue(string pVersionString)
        {
            int value = 0;
            String[] tokenArray = pVersionString.Split('.');
            for (int i = 0; i < tokenArray.Length; i++)
            {
                value += Int32.Parse(tokenArray[i]) * i;
            }
            return value;
        }

        public static string getApplicationVersion(string pExePath)
        {
            string version = SystemConst.DEFAULT_PROGRAM_VERSION;
            try
            {
                FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(pExePath);
                version = versionInfo.ProductVersion;
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            return version;
        }

        public static string getLastVersionFromServer()
        {
            string serverVersion = SystemConst.DEFAULT_PROGRAM_VERSION;
            string pServiceURL = SystemConst.MAX_RELEASE_VERSION_SERVICE_URL;
            try
            {
                RestClientService restClient = new RestClientService();
                ServiceResponseResult responseResult = restClient.processGetRequest(pServiceURL);
                if (ServiceValidator.isValidAndNotEmptyServiceResponse(responseResult))
                {
                    serverVersion = responseResult.result.ToString();
                }
                else
                {
                    MessageService.displayWarningMessage(
                        "No se encontraron actualizaciones en el servidor.\n" + responseResult.message + ".",
                        "SIN ACTUALIZACIONES PENDIENTES"
                        );
                    serverVersion = getApplicationVersion(SystemConst.APPLICATION_RELATIVE_PATH);
                }
            }
            catch (Exception)
            {
                MessageService.displayErrorMessage(
                        "No fue posible conectar con el servidor.\nVerifique las actualizaciones posteriormente.",
                        "ERROR DE CONEXIÓN"
                        );
                serverVersion = getApplicationVersion(SystemConst.APPLICATION_RELATIVE_PATH);
            }
            return serverVersion;
        }

    }
}
