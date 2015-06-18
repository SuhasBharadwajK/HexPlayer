using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.Diagnostics;

namespace HexPlayer
{
    class PipeClient
    {
        public void Send(string pipeName, string position)
        {
            try
            {
                NamedPipeClientStream pipe = new NamedPipeClientStream(".", pipeName, PipeDirection.Out, PipeOptions.Asynchronous);
                pipe.Connect();

                byte[] positionReceived = Encoding.UTF8.GetBytes(position);
                pipe.BeginWrite(positionReceived, 0, positionReceived.Length, DoneWriting, pipe);
            }
            catch (Exception e)
            {
                //Show error message message connection
                Debug.WriteLine(e.Message);
            }
        }

        private void DoneWriting(IAsyncResult result)
        {
            try
            {
                NamedPipeClientStream pipe = (NamedPipeClientStream)result.AsyncState;

                pipe.EndWrite(result);
                pipe.Flush();
                pipe.Close();
                pipe.Dispose();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
