using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTogether
{
    public class AppSettings
    {
        public static string DataDirectoryPath 
        { 
            get
            { 
                return Directory.GetParent(Directory.GetCurrentDirectory()) + @"\data\";
            }
            private set { }
        }
    }
}
