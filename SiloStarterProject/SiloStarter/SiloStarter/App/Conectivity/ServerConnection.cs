using Newtonsoft.Json;
using SiloStarter.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiloStarter.App.Conectivity
{
    public class ServerConnection
    {
        public ServiceResponseResult getServerParams(string pUrl) {
            RestClientService restService = new RestClientService();
            ServiceResponseResult response = restService.processGetRequest(pUrl + ConectionProperties.PARAMS_SERVICE_URL);
            return response;
        }

        public void getServerParams(ref ConfigModel pConfigParams)
        {
            ServiceResponseResult response = this.getServerParams(pConfigParams.mainUrl);
            if (response != null && response.type == "success")
            {
                List<ServiceParam> serverParamList = JsonConvert.DeserializeObject<List<ServiceParam>>(response.result.ToString());
                // Obtener el EndPoint
                string param = this.getParamByName(serverParamList, ConectionProperties.PARAM_LABEL_ENDPOINT);
                pConfigParams.mainUrl = param.Trim() == "" ? pConfigParams.mainUrl : param;
                // Obtener Servidor FTP
                param = this.getParamByName(serverParamList, ConectionProperties.PARAM_LABEL_FTP_HOST);
                pConfigParams.updAccess = param.Trim() == "" ? pConfigParams.updAccess : param;
                // Obtener Path FTP
                param = this.getParamByName(serverParamList, ConectionProperties.PARAM_LABEL_FTP_PATH);
                pConfigParams.updPath = param.Trim() == "" ? pConfigParams.updPath : param;
                // Obtener User FTP
                param = this.getParamByName(serverParamList, ConectionProperties.PARAM_LABEL_FTP_USER);
                pConfigParams.updUser = param.Trim() == "" ? pConfigParams.updUser : param;
                // Obtener Pass FTP
                param = this.getParamByName(serverParamList, ConectionProperties.PARAM_LABEL_FTP_PASS);
                pConfigParams.updPass = param.Trim() == "" ? pConfigParams.updPass : param;
            }
            else
            {
                // TODO: Error
            }
        }

        public string getParamByName(List<ServiceParam> pParamList, string pParamName)
        {
            string paramValue = "";
            List<ServiceParam> paramObjectList = pParamList.Where(param => param.name == pParamName).ToList();
            if (paramObjectList.Count > 0)
            {
                paramValue = paramObjectList[0].value;
            }
            return paramValue;
        }

    }
}
