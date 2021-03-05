// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: services/unity_abl_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace unity_abl_service_pb {
  /// <summary>
  /// The Unity-ABL service definition.
  /// </summary>
  public static partial class Unity_ABL_Handler
  {
    static readonly string __ServiceName = "generated_pb.Unity_ABL_Handler";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::data_pb.Data> __Marshaller_generated_pb_Data = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::data_pb.Data.Parser));
    static readonly grpc::Marshaller<global::unity_abl_service_pb.Data_Response> __Marshaller_generated_pb_Data_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::unity_abl_service_pb.Data_Response.Parser));

    static readonly grpc::Method<global::data_pb.Data, global::unity_abl_service_pb.Data_Response> __Method_Send_Action = new grpc::Method<global::data_pb.Data, global::unity_abl_service_pb.Data_Response>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "Send_Action",
        __Marshaller_generated_pb_Data,
        __Marshaller_generated_pb_Data_Response);

    static readonly grpc::Method<global::data_pb.Data, global::unity_abl_service_pb.Data_Response> __Method_Send_WME = new grpc::Method<global::data_pb.Data, global::unity_abl_service_pb.Data_Response>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "Send_WME",
        __Marshaller_generated_pb_Data,
        __Marshaller_generated_pb_Data_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::unity_abl_service_pb.UnityAblServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Unity_ABL_Handler</summary>
    [grpc::BindServiceMethod(typeof(Unity_ABL_Handler), "BindService")]
    public abstract partial class Unity_ABL_HandlerBase
    {
      /// <summary>
      /// Sends an action packet from ABL to the game engine.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::unity_abl_service_pb.Data_Response> Send_Action(grpc::IAsyncStreamReader<global::data_pb.Data> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Sends a WME packet from the game engine to ABL.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::unity_abl_service_pb.Data_Response> Send_WME(grpc::IAsyncStreamReader<global::data_pb.Data> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Unity_ABL_Handler</summary>
    public partial class Unity_ABL_HandlerClient : grpc::ClientBase<Unity_ABL_HandlerClient>
    {
      /// <summary>Creates a new client for Unity_ABL_Handler</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public Unity_ABL_HandlerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Unity_ABL_Handler that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public Unity_ABL_HandlerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected Unity_ABL_HandlerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected Unity_ABL_HandlerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends an action packet from ABL to the game engine.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::data_pb.Data, global::unity_abl_service_pb.Data_Response> Send_Action(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Send_Action(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends an action packet from ABL to the game engine.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::data_pb.Data, global::unity_abl_service_pb.Data_Response> Send_Action(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_Send_Action, null, options);
      }
      /// <summary>
      /// Sends a WME packet from the game engine to ABL.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::data_pb.Data, global::unity_abl_service_pb.Data_Response> Send_WME(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Send_WME(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a WME packet from the game engine to ABL.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::data_pb.Data, global::unity_abl_service_pb.Data_Response> Send_WME(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_Send_WME, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override Unity_ABL_HandlerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new Unity_ABL_HandlerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(Unity_ABL_HandlerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Send_Action, serviceImpl.Send_Action)
          .AddMethod(__Method_Send_WME, serviceImpl.Send_WME).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, Unity_ABL_HandlerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Send_Action, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::data_pb.Data, global::unity_abl_service_pb.Data_Response>(serviceImpl.Send_Action));
      serviceBinder.AddMethod(__Method_Send_WME, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::data_pb.Data, global::unity_abl_service_pb.Data_Response>(serviceImpl.Send_WME));
    }

  }
}
#endregion