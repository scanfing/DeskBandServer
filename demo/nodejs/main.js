//GrpcMessageSrv 依赖 grpc 与 @grpc/proto-loader

const msgApi = require('./GrpcMessageSrv.js');

(async () => {
    await msgApi.LoadProto();
    msgApi.SendMsg('Hello from nodejs');
})();