using System;
using System.Threading.Tasks;
using System.Windows.Media;
using DeskBandServer.Grpc.Services;
using Grpc.Core;
using static DeskBandServer.Grpc.DeskBandService;

namespace DeskBandServer.Grpc
{
    public class DeskBandGrpcServiceImpl : DeskBandServiceBase
    {
        #region Fields

        private LogService _logSrv;
        private DeskBandViewModel _viewModel;

        #endregion Fields

        #region Constructors

        public DeskBandGrpcServiceImpl(DeskBandViewModel viewModel, LogService logSrv)
        {
            _viewModel = viewModel;
            _logSrv = logSrv;
        }

        #endregion Constructors

        #region Methods

        public async override Task<GetSizeReply> GetSize(GetSizeRequest request, ServerCallContext context)
        {
            var actualSize = await _viewModel.GetDeskBandSize();
            var reply = new GetSizeReply
            {
                Width = (int)actualSize.Width,
                Height = (int)actualSize.Height
            };
            return reply;
        }

        public async override Task<ShowTextMessageReply> ShowTextMessage(ShowTextMessageRequest request, ServerCallContext context)
        {
            if (request.Foreground != null)
            {
                var color = Color.FromArgb((byte)Math.Min(255, request.Foreground.A), (byte)Math.Min(255, request.Foreground.R), (byte)Math.Min(255, request.Foreground.G), (byte)Math.Min(255, request.Foreground.B));
                _viewModel.SetMessage(request.Content, color);
            }
            else
            {
                _viewModel.SetMessage(request.Content);
            }

            var reply = new ShowTextMessageReply
            {
                MsgID = request.MsgID
            };
            return await Task.FromResult(reply);
        }

        #endregion Methods
    }
}