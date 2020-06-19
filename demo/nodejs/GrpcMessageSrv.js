const grpc = require('grpc');
const protoloader = require('@grpc/proto-loader');

class GrpcMessageSrv {

    async LoadProto() {
        var protoFile = __dirname + '/DeskBandServer.proto';
        var protoDescriptor = await protoloader.loadSync(protoFile);
        var d = grpc.loadPackageDefinition(protoDescriptor);
        var pkg = d.DeskBandServer.Grpc;
        this._deskBandService = new pkg.DeskBandService('127.0.0.1:33752', grpc.credentials.createInsecure());
    }

    SendMsg(content) {
        var msg = {
            Content: content
        };
        this._deskBandService.ShowTextMessage(msg, (err, response) => {
            if (err) {
                console.log("error");
            } else {

            }
        });

    }

}

module.exports = new GrpcMessageSrv();