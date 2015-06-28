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
            color = "#0066FF";
            name = "1";
            if (args.Args.Length != 0)
            {
                name = args.Args[1];
                color = args.Args[0];
            }            
        }
    }
}
