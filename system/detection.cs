using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
// using System.Windows.Forms;

using System.Linq;


namespace Loom
{    
    public class Sys{
        public string[] ver;
        public string dist = "";
        
        public void DetectParams(){
            dist = Environment.OSVersion.ToString();
            ver = dist.Split(' ');

            if(ver[0] == "Unix"){ ver[0] = "Linux"; }

            Console.WriteLine(@"Running on {0}, kernel {1}", ver[0], ver[1]);
            
        }
    }
}