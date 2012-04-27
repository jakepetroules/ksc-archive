import java.net.*;
import java.io.*;
import java.util.*;

public class UdpTimeServer
{
	public static void main(String args[])
	{
		DatagramSocket socket = null;
		if (args.length < 1)
		{
			System.out.println("Usage: java UdpTimeServer <host> <port>");
			System.exit(1);
		}
		
		try
		{
			System.out.println("Server is starting up...");
			socket = new DatagramSocket(Integer.valueOf(args[1]).intValue(), InetAddress.getByName(args[0]));
			System.out.println("...ready!");
			
			boolean running = true;
			while (running)
			{
				byte[] buffer = new byte[1000];
				DatagramPacket request = new DatagramPacket(buffer, buffer.length);
				socket.receive(request);
				
				String message = new String(request.getData(), 0, request.getLength());
				System.out.println("Received command: " + message);
				if (message.equalsIgnoreCase("exit"))
				{
					message = "Server is shutting down...";
					System.out.println(message);
					running = false;
				}
				else
				{
					message = "Current time: " + new Date().toString();
				}
				
				byte[] messageBytes = message.getBytes();
				DatagramPacket reply = new DatagramPacket(messageBytes, messageBytes.length, request.getAddress(), request.getPort());
				socket.send(reply);
			}
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