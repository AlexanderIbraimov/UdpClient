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
        UdpClient client;
        int port; 
        string ip;

        public Interaction(string ip, int port) 
        {
            this.port = port;
            this.ip = ip;
        }

        public void Send(string message)
        {
            client = new UdpClient();
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse(ip), port);

            try
            {
                byte[] arrayData = Encoding.Unicode.GetBytes(message);
                client.Send(arrayData, arrayData.Length, ipendpoint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                client.Close();
            }
        }
    }
}
