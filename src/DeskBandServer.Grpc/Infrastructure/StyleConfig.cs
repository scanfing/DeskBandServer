namespace DeskBandServer.Grpc.Infrastructure
{
    public class ConfigColor
    {
        #region Properties

        public byte A { get; set; }
        public byte B { get; set; }
        public byte G { get; set; }
        public byte R { get; set; }

        #endregion Properties
    }

    public class StyleConfig : ConfigBase
    {
        #region Properties

        public ConfigColor Background { get; set; }

        public ConfigColor BorderColor { get; set; }

        public uint BorderThickness { get; set; }

        public uint CornerRadius { get; set; }

        public uint FontSize { get; set; }

        public ConfigColor Foreground { get; set; }

        #endregion Properties
    }
}