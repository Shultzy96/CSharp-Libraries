using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLager;

namespace UtilityLager
{
    public class Lager
    {
        public void logErrors(Exception Error)
        {
            string Message = string.Format("Time: {0}", DateTime.Now.ToString(""));
            Message += Environment.NewLine;
            Message += "--------------------------------------------------------------------------------------------------------------";
            Message += string.Format("Message: {0}", Error.Message);
            Message += Environment.NewLine;
            Message += string.Format("StackTrace: {0}", Error.StackTrace);
            Message += Environment.NewLine;
            Message += string.Format("Source: {0}", Error.Source);
            Message += Environment.NewLine;
            Message += string.Format("TargetSite: {0}", Error.TargetSite.ToString());
            Message += Environment.NewLine;
            Message += "--------------------------------------------------------------------------------------------------------------";
            Message += Environment.NewLine;

            using(StreamWriter writer = new StreamWriter("C:\\user\\Desktop\\ErrorLog.txt", true))
            {
                writer.WriteLine(Message);
            }

        }
    }
}
