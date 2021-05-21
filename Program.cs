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

            Proceedure stopServer = new Proceedure();
            stopServer.AddAction(new ProcessInteractionAction(appy, "/say Stopping Server in 10 seconds"));
            stopServer.AddAction(new WaitAction(1000));
            stopServer.AddAction(new ProcessInteractionAction(appy, "/say Stopping Server in 9 seconds"));
            stopServer.AddAction(new WaitAction(1000));
            stopServer.AddAction(new ProcessInteractionAction(appy, "/say Stopping Server in 8 seconds"));
            stopServer.AddAction(new WaitAction(1000));
            stopServer.AddAction(new ProcessInteractionAction(appy, "/stop"));


            while (true)
            {

                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    stopServer.Execute();

                if (input.ToLower() == "exit") 
                    break;
                //else
                    //appy.Run(input);
            }
        }
    }
}
