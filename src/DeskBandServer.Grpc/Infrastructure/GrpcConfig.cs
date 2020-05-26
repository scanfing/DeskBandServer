namespace DeskBandServer.Grpc.Infrastructure
{
    public class GrpcConfig : ConfigBase
    {
        #region Properties

        /// <summary>
        /// 启动时默认显示的内容
        /// </summary>
        public string DefaultContent { get; set; } = "Ready";

        /// <summary>
        /// 只接受本机的消息
        /// </summary>
        public bool OnlyAcceptLocalhost { get; set; } = true;

        /// <summary>
        /// Grpc 服务端口
        /// </summary>
        public int ServerPort { get; set; } = 33752;

        #endregion Properties
    }
}