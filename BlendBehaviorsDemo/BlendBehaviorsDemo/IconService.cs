using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;

namespace BlendBehaviorsDemo
{
    public class IconService
    {
        public static List<IconInfo> GetIcons()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@".\icons");
            var files = dirInfo.GetFiles();
            List<IconInfo> results = new List<IconInfo>();
            foreach (var file in files)
            {
                IconInfo ii = new IconInfo();
                ii.Image = new BitmapImage(new Uri(@".\icons\" + file.Name, UriKind.Relative));
                ii.Name = file.Name;
                results.Add(ii);
            }
            return results;
        }
    }
}
