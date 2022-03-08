using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HallamNathan_Lab04.ViewModels;

namespace HallamNathan_Lab04
{
    class Connection
    {
        public string GetConnection()
        {
            string url = "http://64.72.2.60/rest";

            return url;
        }
    }
}
