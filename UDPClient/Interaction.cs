using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPClient
{
    public class Interaction
    {
        UdpClient client;
        int LOCALPORT = 3333; // порт для приема сообщений
        int REMOTEPORT = 3333; // порт для отправки сообщений
        const int TTL = 20;
        string ip = "127.0.0.1"; // хост для групповой рассылки
        IPAddress groupAddress; // адрес для групповой рассылки

        public void Connect(string ip, int port)
        {
            this.ip = ip;
            this.LOCALPORT = port;
            groupAddress = IPAddress.Parse(ip);
            
            try
            {
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Send(string message)
        {
            try
            {
                client = new UdpClient(REMOTEPORT);
                byte[] arrayData = Encoding.Unicode.GetBytes(message);
                client.Send(arrayData, arrayData.Length, ip, REMOTEPORT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
