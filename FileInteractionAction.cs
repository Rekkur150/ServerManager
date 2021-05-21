using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServerManager
{
    class FileInteractionAction: Action
    {
        string source;
        string destination;

        public FileInteractionAction(string sourceFileOrFolder, string destinationFileOrFolder)
        {
            source = sourceFileOrFolder;
            destination = destinationFileOrFolder;
        }

        protected override void action()
        {
            System.IO.File.Move(source, destination);
            base.action();
        }
    }
}
