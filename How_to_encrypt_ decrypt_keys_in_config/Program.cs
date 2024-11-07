using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_encrypt__decrypt_keys_in_config
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNameWithoutEncryption = ConfigurationManager.AppSettings["username"];
            Console.WriteLine(userNameWithoutEncryption);
            EncryptAppSettings("appSettings");
            string userNameWithEncrytionApplied = ConfigurationManager.AppSettings["username"];
            Console.WriteLine(userNameWithoutEncryption);
            string userNameWithDecrypt = ConfigurationManager.AppSettings["username"];
            Console.WriteLine(userNameWithDecrypt);
            DecryptAppSettings("appSettings");
            string userNameWithEncrytionApplied1 = ConfigurationManager.AppSettings["username"];
            Console.WriteLine(userNameWithEncrytionApplied1);
        }
        private static void EncryptAppSettings(string section)
        {
            Configuration objConfig = ConfigurationManager.OpenExeConfiguration(GetAppPath() + "AppKeyEncryption.exe");
            AppSettingsSection objAppsettings = (AppSettingsSection)objConfig.GetSection(section);
            if (!objAppsettings.SectionInformation.IsProtected)
            {
                objAppsettings.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
                objAppsettings.SectionInformation.ForceSave = true;
                objConfig.Save(ConfigurationSaveMode.Modified);
            }
        }

        private static void DecryptAppSettings(string section)
        {
            Configuration objConfig = ConfigurationManager.OpenExeConfiguration(GetAppPath() + "AppKeyEncryption.exe");
            AppSettingsSection objAppsettings = (AppSettingsSection)objConfig.GetSection(section);
            if (objAppsettings.SectionInformation.IsProtected)
            {
                objAppsettings.SectionInformation.UnprotectSection();
                objAppsettings.SectionInformation.ForceSave = true;
                objConfig.Save(ConfigurationSaveMode.Modified);
            }
        }
        private static string GetAppPath()
        {
            System.Reflection.Module[] modules = System.Reflection.Assembly.GetExecutingAssembly().GetModules();
            string location = System.IO.Path.GetDirectoryName(modules[0].FullyQualifiedName);
            if ((location != "") && (location[location.Length - 1] != '\\'))
                location += '\\';
            return location;
        }
        private static void UpdateKey(string newValue)
        {
            ExeConfigurationFileMap configFile = new ExeConfigurationFileMap();
            configFile.ExeConfigFilename = ConfigurationManager.AppSettings["configPath"];
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);
            config.AppSettings.Settings["password"].Value = newValue;
            config.Save();
        }
    }
}
