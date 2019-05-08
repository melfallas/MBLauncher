using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiloStarter.App.Model
{
    public class ConfigModel
    {
        public string mainUrl { get; set; }
        public string updAccess { get; set; }
        public string updUser { get; set; }
        public string updPass { get; set; }
        public string updPath { get; set; }
        public string appVersion { get; set; }


        public void copy(ConfigModel pOtherConfig)
        {
            this.mainUrl = pOtherConfig.mainUrl;
            this.updAccess = pOtherConfig.updAccess;
            this.updUser = pOtherConfig.updUser;
            this.updPass = pOtherConfig.updPass;
            this.updPath = pOtherConfig.updPath;
            this.appVersion = pOtherConfig.appVersion;
        }

        public void load()
        {
            string configString = File.ReadAllText(SystemConst.CONFIG_FILE_RELATIVE_PATH);
            ConfigModel previosConfig = JsonConvert.DeserializeObject<ConfigModel>(configString);
            this.copy(previosConfig);
        }

        public void save()
        {
            string jsonConfigString = JsonConvert.SerializeObject(this);
            //Console.WriteLine(jsonConfigString);
            File.WriteAllText(SystemConst.CONFIG_FILE_RELATIVE_PATH, jsonConfigString);
        }

    }
}
