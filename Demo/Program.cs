﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Demo
{
    class Program
    {
        public static Dictionary<string, object> Properties = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        static void Main(string[] args)
        {
            string dirname = AppDomain.CurrentDomain.SetupInformation.DynamicBase;
            var pat1h = HttpRuntime.CodegenDir;
            string path = Path.Combine(HttpRuntime.CodegenDir, "MS-ApiControllerTypeCache.xml");

            DateTime dt = new DateTime(2016, 10, 12, 09, 09, 09);
            var t22 = dt.ToString("yyyy-mm-dd hh:mm:ss ");
            var ttt = dt.Minute.ToString("dd");
            dt.ToString("");

        }

    }

}
