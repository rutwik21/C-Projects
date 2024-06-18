using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomClass.Properties
{
    public class Error_Handler
    {
        public static void logError(string message)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Administrator\\Desktop\\C#\\log.txt", true);
            sw.WriteLine($"Error ({DateTime.Now}) : " + message);
            sw.Close();

        }
    }
}
