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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            listener = new LowLevelKeyboardListener();
            KeygasmService service;
            listener.HookKeyboard();

            //ServicesToRun = new ServiceBase[]
            //{
            service = new KeygasmService();
            //};

            listener.OnKeyPressed += service.OnKeyPressed;
            //ServiceBase.Run(ServicesToRun);

            while (true)
            {

            }
        }
    }
}
