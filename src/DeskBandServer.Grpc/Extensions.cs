using System;
using DeskBandServer.Grpc.Infrastructure;
using Newtonsoft.Json;

namespace DeskBandServer.Grpc
{
    public static class Extensions
    {
        #region Methods

        public static ConfigColor ToConfig(this CustomColor csC)
        {
            var cfgC = new ConfigColor
            {
                A = (byte)Math.Min(255, csC.A),
                R = (byte)Math.Min(255, csC.R),
                G = (byte)Math.Min(255, csC.G),
                B = (byte)Math.Min(255, csC.B)
            };
            return cfgC;
        }

        public static CustomColor ToCustom(this ConfigColor cfgC)
        {
            var csC = new CustomColor
            {
                A = cfgC.A,
                R = cfgC.R,
                G = cfgC.G,
                B = cfgC.B
            };
            return csC;
        }

        public static string ToJson(this ConfigBase cfg)
        {
            return JsonConvert.SerializeObject(cfg);
        }

        #endregion Methods
    }
}