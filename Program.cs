using System;

namespace ServerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager appy = new ApplicationManager("C:\\Users\\minec\\Documents\\VisualStudio\\ServerManager\\Servers\\MinecraftTest\\");
            appy.Open("C:\\Program Files\\Java\\jre1.8.0_291\\bin\\java.exe", "-Xmx1024M -Xms1024M -jar server.jar nogui");
            appy.Output(Console.Out);


            while (true)
            {

                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;
                else
                    appy.Run(input);
            }
        }
    }
}
