namespace Networking
{
	public class HttpCommunicator
	{
		const string Protocol = "HTTP";
		int _messages;

		public HttpCommunicator()
		{
			_messages = 0;
			Console.WriteLine("HttpCommunicator initialized.");
		}

		public void SendMessage(string message, string ipAddress)
		{
			OpenSocket();
			SetProtocol();
			HandShake();
			SendData(message, ipAddress);
			CloseSocket();
		}

		public int MessageCount
		{
			get
			{
				return _messages;
			}
		}

		private void OpenSocket()
		{
			Console.WriteLine("Opening socket...");
		}

		private void CloseSocket()
		{
			Console.WriteLine("Closing socket...");
		}

		private void SetProtocol()
		{
			Console.WriteLine($"Setting protocol to {Protocol}");
			// Do protocol specific setup here which is different for various protocols.
		}

		private void HandShake()
		{
			Console.WriteLine("Performing handshake...");
		}

		private void SendData(string data, string ipAddress)
		{
			Console.WriteLine($"Sending data to {ipAddress} via {Protocol}: {data}");
			File.AppendAllText($"{ipAddress}.txt", $"Sending via {Protocol} - {Environment.NewLine}{data}{Environment.NewLine}");
			_messages++;
		}
	}
}
