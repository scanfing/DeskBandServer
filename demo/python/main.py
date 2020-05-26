# -*- coding: utf-8 -*-
# python -m grpc_tools.protoc -I ./ --python_out=./ --grpc_python_out=./ DeskBandServer.proto
import grpc
import DeskBandServer_pb2
import DeskBandServer_pb2_grpc

_HOST = '127.0.0.1'
_PORT = '33752'


def main():
    with grpc.insecure_channel("{0}:{1}".format(_HOST, _PORT)) as channel:
        client = DeskBandServer_pb2_grpc.DeskBandServiceStub(channel=channel)
        response = client.ShowTextMessage(
            DeskBandServer_pb2.ShowTextMessageRequest(Content="Hello form python"))
    print("done")


if __name__ == '__main__':
    main()
