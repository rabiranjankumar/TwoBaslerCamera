using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwoBaslerCamera.Service
{
    class ServiceUtils
    {
        // print line no file name and others 
        public static void Log(string text,
                     [CallerFilePath] string file = "",
                     [CallerMemberName] string member = "",
                     [CallerLineNumber] int line = 0)
        {
            Console.WriteLine("{0}  _ {1} ({2}) :  {3}  ", Path.GetFileName(file), member, line, text);
        }

    }
}
