using System;
using System.IO;
using DeskBandServer.Grpc.Infrastructure;
using Newtonsoft.Json;

namespace DeskBandServer.Grpc.Services
{
    public class ConfigService
    {
        #region Fields

        private string _cfgDir;

        #endregion Fields

        #region Constructors

        public ConfigService()
        {
            _cfgDir = Path.GetDirectoryName(GetType().Assembly.Location);
        }

        #endregion Constructors

        #region Methods

        public T LoadConfig<T>() where T : ConfigBase
        {
            var cfgFile = Path.Combine(_cfgDir, typeof(T).Name + ".json");
            T cfg;
            if (File.Exists(cfgFile))
            {
                var content = File.ReadAllText(cfgFile);
                cfg = JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                var instance = Activator.CreateInstance(typeof(T), false);
                cfg = instance as T;
                if (typeof(T).Equals(typeof(StyleConfig)))
                {
                    cfg = GetDefaultStyle() as T;
                }
                SaveConfig(cfg);
            }
            return cfg;
        }

        public void SaveConfig<T>(T cfg) where T : ConfigBase
        {
            var cfgFile = Path.Combine(_cfgDir, typeof(T).Name + ".json");
            var content = JsonConvert.SerializeObject(cfg);
            File.WriteAllText(cfgFile, content);
        }

        private StyleConfig GetDefaultStyle()
        {
            var cfg = new StyleConfig
            {
                FontSize = 12,
                CornerRadius = 3,
                BorderThickness = 0,
                Background = new ConfigColor() { A = 0, R = 0, G = 0, B = 0 },
                Foreground = new ConfigColor() { A = 255, R = 255, G = 255, B = 255 },
                BorderColor = new ConfigColor() { A = 255, R = 255, G = 255, B = 255 }
            };
            return cfg;
        }

        #endregion Methods
    }
}