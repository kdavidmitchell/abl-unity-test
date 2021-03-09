package generated_pb;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * The Unity-ABL service definition.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler (version 1.36.0)",
    comments = "Source: services/unity_abl_service.proto")
public final class UnityABLHandlerGrpc {

  private UnityABLHandlerGrpc() {}

  public static final String SERVICE_NAME = "generated_pb.UnityABLHandler";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<generated_pb.data_pb.Data,
      generated_pb.unity_abl_service_pb.DataResponse> getSendDataMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SendData",
      requestType = generated_pb.data_pb.Data.class,
      responseType = generated_pb.unity_abl_service_pb.DataResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<generated_pb.data_pb.Data,
      generated_pb.unity_abl_service_pb.DataResponse> getSendDataMethod() {
    io.grpc.MethodDescriptor<generated_pb.data_pb.Data, generated_pb.unity_abl_service_pb.DataResponse> getSendDataMethod;
    if ((getSendDataMethod = UnityABLHandlerGrpc.getSendDataMethod) == null) {
      synchronized (UnityABLHandlerGrpc.class) {
        if ((getSendDataMethod = UnityABLHandlerGrpc.getSendDataMethod) == null) {
          UnityABLHandlerGrpc.getSendDataMethod = getSendDataMethod =
              io.grpc.MethodDescriptor.<generated_pb.data_pb.Data, generated_pb.unity_abl_service_pb.DataResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SendData"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  generated_pb.data_pb.Data.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  generated_pb.unity_abl_service_pb.DataResponse.getDefaultInstance()))
              .setSchemaDescriptor(new UnityABLHandlerMethodDescriptorSupplier("SendData"))
              .build();
        }
      }
    }
    return getSendDataMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static UnityABLHandlerStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UnityABLHandlerStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UnityABLHandlerStub>() {
        @java.lang.Override
        public UnityABLHandlerStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UnityABLHandlerStub(channel, callOptions);
        }
      };
    return UnityABLHandlerStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static UnityABLHandlerBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UnityABLHandlerBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UnityABLHandlerBlockingStub>() {
        @java.lang.Override
        public UnityABLHandlerBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UnityABLHandlerBlockingStub(channel, callOptions);
        }
      };
    return UnityABLHandlerBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static UnityABLHandlerFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UnityABLHandlerFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UnityABLHandlerFutureStub>() {
        @java.lang.Override
        public UnityABLHandlerFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UnityABLHandlerFutureStub(channel, callOptions);
        }
      };
    return UnityABLHandlerFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * The Unity-ABL service definition.
   * </pre>
   */
  public static abstract class UnityABLHandlerImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Sends a data packet.
     * </pre>
     */
    public void sendData(generated_pb.data_pb.Data request,
        io.grpc.stub.StreamObserver<generated_pb.unity_abl_service_pb.DataResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSendDataMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getSendDataMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                generated_pb.data_pb.Data,
                generated_pb.unity_abl_service_pb.DataResponse>(
                  this, METHODID_SEND_DATA)))
          .build();
    }
  }

  /**
   * <pre>
   * The Unity-ABL service definition.
   * </pre>
   */
  public static final class UnityABLHandlerStub extends io.grpc.stub.AbstractAsyncStub<UnityABLHandlerStub> {
    private UnityABLHandlerStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UnityABLHandlerStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UnityABLHandlerStub(channel, callOptions);
    }

    /**
     * <pre>
     * Sends a data packet.
     * </pre>
     */
    public void sendData(generated_pb.data_pb.Data request,
        io.grpc.stub.StreamObserver<generated_pb.unity_abl_service_pb.DataResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSendDataMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * The Unity-ABL service definition.
   * </pre>
   */
  public static final class UnityABLHandlerBlockingStub extends io.grpc.stub.AbstractBlockingStub<UnityABLHandlerBlockingStub> {
    private UnityABLHandlerBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UnityABLHandlerBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UnityABLHandlerBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Sends a data packet.
     * </pre>
     */
    public generated_pb.unity_abl_service_pb.DataResponse sendData(generated_pb.data_pb.Data request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSendDataMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * The Unity-ABL service definition.
   * </pre>
   */
  public static final class UnityABLHandlerFutureStub extends io.grpc.stub.AbstractFutureStub<UnityABLHandlerFutureStub> {
    private UnityABLHandlerFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UnityABLHandlerFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UnityABLHandlerFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Sends a data packet.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<generated_pb.unity_abl_service_pb.DataResponse> sendData(
        generated_pb.data_pb.Data request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSendDataMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_SEND_DATA = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final UnityABLHandlerImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(UnityABLHandlerImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_SEND_DATA:
          serviceImpl.sendData((generated_pb.data_pb.Data) request,
              (io.grpc.stub.StreamObserver<generated_pb.unity_abl_service_pb.DataResponse>) responseObserver);
          break;
        default:
          throw new AssertionError();
      }
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public io.grpc.stub.StreamObserver<Req> invoke(
        io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        default:
          throw new AssertionError();
      }
    }
  }

  private static abstract class UnityABLHandlerBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    UnityABLHandlerBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return generated_pb.unity_abl_service_pb.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("UnityABLHandler");
    }
  }

  private static final class UnityABLHandlerFileDescriptorSupplier
      extends UnityABLHandlerBaseDescriptorSupplier {
    UnityABLHandlerFileDescriptorSupplier() {}
  }

  private static final class UnityABLHandlerMethodDescriptorSupplier
      extends UnityABLHandlerBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    UnityABLHandlerMethodDescriptorSupplier(String methodName) {
      this.methodName = methodName;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.MethodDescriptor getMethodDescriptor() {
      return getServiceDescriptor().findMethodByName(methodName);
    }
  }

  private static volatile io.grpc.ServiceDescriptor serviceDescriptor;

  public static io.grpc.ServiceDescriptor getServiceDescriptor() {
    io.grpc.ServiceDescriptor result = serviceDescriptor;
    if (result == null) {
      synchronized (UnityABLHandlerGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new UnityABLHandlerFileDescriptorSupplier())
              .addMethod(getSendDataMethod())
              .build();
        }
      }
    }
    return result;
  }
}
