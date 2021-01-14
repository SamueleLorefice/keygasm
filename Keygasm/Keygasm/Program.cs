using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Keygasm
{
    class Program
    {
        public static LowLevelKeyboardListener listener;

        static void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
        }

        //

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            listener = new LowLevelKeyboardListener();
            listener.OnKeyPressed += _listener_OnKeyPressed;

            listener.HookKeyboard();
            ServicesToRun = new ServiceBase[]
            {
                new KeygasmService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
