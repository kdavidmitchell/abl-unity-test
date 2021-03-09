package proxy;

import java.io.IOException;

import abl.generated.ChaserAgent;
import io.grpc.Server;
import io.grpc.ServerBuilder;

public class Proxy {
	
	// A reference to the proxy.
	private static Proxy _proxy;
	
	// Starts the proxy and the ABL agent.
	public static void main(String[] args) throws IOException, InterruptedException {
		_proxy = new Proxy();
		//_proxy.startAgent();
		_proxy.startServer();
	}
	
	// Returns a reference to the proxy.
	public static Proxy getInstance() {
		return _proxy;
	}
	
	// Starts the ABL agent attached to this proxy.
	public void startAgent() {
		 ChaserAgent agent = new ChaserAgent();
		 agent.startBehaving();
	}
	
	// Starts the Unity-ABL server.
	public void startServer() throws IOException, InterruptedException {
		Server server = ServerBuilder.
				forPort(50050).addService(new UnityABLHandlerImpl()).build();
		
		server.start();
		
		System.out.println("server started at "+ server.getPort());
        server.awaitTermination();
	}
}
