// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DeskBandServer.proto
// </auto-generated>
// Original file comments:
// 指定protobuf语法版本
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DeskBandServer.Grpc {
  /// <summary>
  ///DeskBand服务
  /// </summary>
  public static partial class DeskBandService
  {
    static readonly string __ServiceName = "DeskBandServer.Grpc.DeskBandService";

    static readonly grpc::Marshaller<global::DeskBandServer.Grpc.GetSizeRequest> __Marshaller_DeskBandServer_Grpc_GetSizeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DeskBandServer.Grpc.GetSizeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DeskBandServer.Grpc.GetSizeReply> __Marshaller_DeskBandServer_Grpc_GetSizeReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DeskBandServer.Grpc.GetSizeReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DeskBandServer.Grpc.ShowTextMessageRequest> __Marshaller_DeskBandServer_Grpc_ShowTextMessageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DeskBandServer.Grpc.ShowTextMessageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DeskBandServer.Grpc.ShowTextMessageReply> __Marshaller_DeskBandServer_Grpc_ShowTextMessageReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DeskBandServer.Grpc.ShowTextMessageReply.Parser.ParseFrom);

    static readonly grpc::Method<global::DeskBandServer.Grpc.GetSizeRequest, global::DeskBandServer.Grpc.GetSizeReply> __Method_GetSize = new grpc::Method<global::DeskBandServer.Grpc.GetSizeRequest, global::DeskBandServer.Grpc.GetSizeReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSize",
        __Marshaller_DeskBandServer_Grpc_GetSizeRequest,
        __Marshaller_DeskBandServer_Grpc_GetSizeReply);

    static readonly grpc::Method<global::DeskBandServer.Grpc.ShowTextMessageRequest, global::DeskBandServer.Grpc.ShowTextMessageReply> __Method_ShowTextMessage = new grpc::Method<global::DeskBandServer.Grpc.ShowTextMessageRequest, global::DeskBandServer.Grpc.ShowTextMessageReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ShowTextMessage",
        __Marshaller_DeskBandServer_Grpc_ShowTextMessageRequest,
        __Marshaller_DeskBandServer_Grpc_ShowTextMessageReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DeskBandServer.Grpc.DeskBandServerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DeskBandService</summary>
    [grpc::BindServiceMethod(typeof(DeskBandService), "BindService")]
    public abstract partial class DeskBandServiceBase
    {
      /// <summary>
      ///获取DeskBand区域大小
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DeskBandServer.Grpc.GetSizeReply> GetSize(global::DeskBandServer.Grpc.GetSizeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///在DeskBand区域内显示文本内容
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DeskBandServer.Grpc.ShowTextMessageReply> ShowTextMessage(global::DeskBandServer.Grpc.ShowTextMessageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DeskBandService</summary>
    public partial class DeskBandServiceClient : grpc::ClientBase<DeskBandServiceClient>
    {
      /// <summary>Creates a new client for DeskBandService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DeskBandServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DeskBandService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DeskBandServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DeskBandServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DeskBandServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///获取DeskBand区域大小
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DeskBandServer.Grpc.GetSizeReply GetSize(global::DeskBandServer.Grpc.GetSizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///获取DeskBand区域大小
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DeskBandServer.Grpc.GetSizeReply GetSize(global::DeskBandServer.Grpc.GetSizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSize, null, options, request);
      }
      /// <summary>
      ///获取DeskBand区域大小
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DeskBandServer.Grpc.GetSizeReply> GetSizeAsync(global::DeskBandServer.Grpc.GetSizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSizeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///获取DeskBand区域大小
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DeskBandServer.Grpc.GetSizeReply> GetSizeAsync(global::DeskBandServer.Grpc.GetSizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSize, null, options, request);
      }
      /// <summary>
      ///在DeskBand区域内显示文本内容
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DeskBandServer.Grpc.ShowTextMessageReply ShowTextMessage(global::DeskBandServer.Grpc.ShowTextMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShowTextMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///在DeskBand区域内显示文本内容
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DeskBandServer.Grpc.ShowTextMessageReply ShowTextMessage(global::DeskBandServer.Grpc.ShowTextMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ShowTextMessage, null, options, request);
      }
      /// <summary>
      ///在DeskBand区域内显示文本内容
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DeskBandServer.Grpc.ShowTextMessageReply> ShowTextMessageAsync(global::DeskBandServer.Grpc.ShowTextMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShowTextMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///在DeskBand区域内显示文本内容
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DeskBandServer.Grpc.ShowTextMessageReply> ShowTextMessageAsync(global::DeskBandServer.Grpc.ShowTextMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ShowTextMessage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DeskBandServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DeskBandServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DeskBandServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSize, serviceImpl.GetSize)
          .AddMethod(__Method_ShowTextMessage, serviceImpl.ShowTextMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DeskBandServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetSize, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DeskBandServer.Grpc.GetSizeRequest, global::DeskBandServer.Grpc.GetSizeReply>(serviceImpl.GetSize));
      serviceBinder.AddMethod(__Method_ShowTextMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DeskBandServer.Grpc.ShowTextMessageRequest, global::DeskBandServer.Grpc.ShowTextMessageReply>(serviceImpl.ShowTextMessage));
    }

  }
}
#endregion