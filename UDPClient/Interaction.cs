using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPClient
{
    public class Interaction
    {
        int port; 
        string ip;

        public Interaction(string ip, int port) 
        {
            this.port = port;
            this.ip = ip;
        }

        public void Send(string message)
        {
            IPEndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                server.SendTo(data, data.Length, SocketFlags.None, RemoteEndPoint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                server.Close();
            }
        }
    }
}
