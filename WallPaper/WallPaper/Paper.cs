using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using System.Net;

namespace WallPaper
{
    class Paper
    {
        string dir;

        int WallpaperStyle;
        int TileWallpaper;

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public Paper(string dir)
        {
            this.dir = dir;
            if (!Directory.Exists(dir)) // create folder that consist papers
                Directory.CreateDirectory(dir);
        }

        public void SaveImageFromLink(string link)
        {
            WebClient web=new WebClient();
            string name = DateTime.Now.Ticks.ToString() + ".jpg";
            web.DownloadFile(link, dir+name);            
        }

        public void PlacePicture(string name)
        {
            if (name == "")
                return;
            string path=dir+name;
            if (!File.Exists(path)) return;
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public void SetStyle(int style)
        {
            //fill: 0; 10
            //fit: 1;  6
            //stretch: 2; 2
            //tile: 3; 0    
            //center: 4; 0
            TileWallpaper = style == 3 ? 1 : 0;

            switch (style)
            {
                case 0: WallpaperStyle = 10; break;
                case 1: WallpaperStyle = 6; break;
                case 2: WallpaperStyle = 2; break;
                case 3: WallpaperStyle = 0; break;
                case 4: WallpaperStyle = 0; break;
            }
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            key.SetValue("WallpaperStyle", WallpaperStyle.ToString());
            key.SetValue("TileWallpaper", TileWallpaper.ToString());    
        }
    }
}
