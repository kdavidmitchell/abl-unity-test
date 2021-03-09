package proxy;

import generated_pb.UnityABLHandlerGrpc.UnityABLHandlerImplBase;
import generated_pb.unity_abl_service_pb.DataResponse;
import generated_pb.data_pb.Data;
import io.grpc.stub.StreamObserver;

public class UnityABLHandlerImpl extends UnityABLHandlerImplBase {
	@Override
	  public void sendData(Data request, StreamObserver<DataResponse> responseObserver) {
	    // You must use a builder to construct a new protobuf object
	    DataResponse response = DataResponse.newBuilder()
	      .setResponse("Received: " + request.getDataList())
	      .build();

	    // Use responseObserver to send a single response back
	    responseObserver.onNext(response);

	    // When you are done, you must call onCompleted.
	    responseObserver.onCompleted();
	  }
}
