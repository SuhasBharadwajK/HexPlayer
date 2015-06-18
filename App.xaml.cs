using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HexPlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public string color, name;        
        public void onStartup(object sender, StartupEventArgs args)
        {
            if (args.Args.Length != 0)
            {
                name = args.Args[1];
                if (args.Args[0] == "blue")
                {
                    color = "#0066FF";
                }
                else
                {
                    color = "#FF2A2A";
                }
            }            
        }
    }
}
