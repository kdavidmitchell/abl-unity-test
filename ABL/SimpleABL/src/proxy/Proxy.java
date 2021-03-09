package proxy;

import abl.generated.ChaserAgent;

public class Proxy {
	
	// A reference to the proxy.
	private static Proxy _proxy;
	
	// Starts the proxy and the ABL agent.
	public static void main(String[] args) {
		_proxy = new Proxy();
		_proxy.startAgent();
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
	
	
}
