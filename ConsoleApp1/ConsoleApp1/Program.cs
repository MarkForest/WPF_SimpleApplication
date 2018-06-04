using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConsoleApp1
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Window window = new Window();
            Button button = new Button();
            window.Content = button;
            button.Content = "Click Button";
            window.Title = "Yours First WPF Application";
            new Application().Run(window);
        }
    }
}
