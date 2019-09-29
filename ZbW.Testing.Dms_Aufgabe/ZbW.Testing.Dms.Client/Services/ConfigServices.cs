using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.Testing.Dms.Client.Services
{
    public static class ConfigServices
    {
        public static string GetConfigValueByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
