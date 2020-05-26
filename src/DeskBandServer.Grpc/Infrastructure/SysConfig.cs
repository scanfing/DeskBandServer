namespace DeskBandServer.Grpc.Infrastructure
{
    public class SysConfig : ConfigBase
    {
        #region Properties

        public bool EnableGrpcManager { get; set; } = false;

        /// <summary>
        /// 管理服务的端口
        /// </summary>
        public int ManagePort { get; set; } = 56645;

        #endregion Properties
    }
}