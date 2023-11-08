using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data;

namespace GameMini
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        
    }

    
    public static class Share
    {
        static public WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer();
        static public bool Mute;
        static public string Topic;
        static public string result;
    }

    

}
