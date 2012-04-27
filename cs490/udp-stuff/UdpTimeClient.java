import java.net.*;
import java.io.*;

public class UdpTimeClient
{
	public static void main(String args[])
	{
		DatagramSocket socket = null;
		if (args.length < 2)
		{
			System.out.println("Usage: java UDPClient <host> <port> [<message>]");
			System.exit(1);
		}
		
		try
		{
			socket = new DatagramSocket();
			
			InetAddress host = InetAddress.getByName(args[0]);
			int serverPort = Integer.valueOf(args[1]).intValue();
			
			// Combine any remaining arguments into one
			String message = "";
			for (int i = 2; i < args.length; i++)
			{
				message += args[i];
			}
			
			if (message.length() == 0)
			{
				message = "time";
			}
			
			byte[] m = message.getBytes();
			
			DatagramPacket request = new DatagramPacket(m, m.length, host, serverPort);
			socket.send(request);
			
			byte[] buffer = new byte[1000];
			DatagramPacket reply = new DatagramPacket(buffer, buffer.length);
			socket.receive(reply);
			
			System.out.println(new String(reply.getData(), 0, reply.getLength()));
		}
		catch (SocketException e)
		{
			System.out.println("Socket: " + e.getMessage());
		}
		catch (IOException e)
		{
			System.out.println("IO: " + e.getMessage());
		}
		finally
		{
			if (socket != null)
			{
				socket.close();
			}
		}
	}
}