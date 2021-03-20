using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace CtrldeCredito
{

    public class clsSocketServidor
    {
        // Incoming data from the client.
//        public static string data = null;
        private Socket handler;
        private byte[] bytes;
        frmListenerMarceloApp objformListener = new frmListenerMarceloApp();

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            try
            {
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                string dts = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                //byte[] msg = Encoding.ASCII.GetBytes(dts);
                //handler.Send(msg);
                handler.Send(bytes);

                objformListener.CdgoTarjetaReady(dts);

                if (dts.IndexOf("$") != -1)
                {
                    myTimer.Stop();
                    byte[] msg = Encoding.ASCII.GetBytes("%");
                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                    //return;
                }
            }
            catch (SocketException e) {
                MessageBox.Show(e.ToString());
            }
            catch (ObjectDisposedException e) {
                MessageBox.Show(e.ToString());
            }
        }

        public void StartListening(frmListenerMarceloApp objform)
        {
            if (handler != null)
            {
                StartTimer(); return;
            }
            objformListener = objform;
            // Data buffer for incoming data.
            //        IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            //        IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPAddress tl = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(tl, 27015);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                // Start listening for connections.
//                while (true)  {                
                Console.WriteLine("Waiting for a connection...");
                // Program is suspended while waiting for an incoming connection.
                handler = listener.Accept();
                //handler.ReceiveTimeout = 1024*3;      // 3 sgdos. sin recibir pack, cierra socket!

                StartTimer();

            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return;
        }
        public void StartTimer() 
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 3000;
            myTimer.Start();
                // An incoming connection needs to be processed.                
        }
    }
}