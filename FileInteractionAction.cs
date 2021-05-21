using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
