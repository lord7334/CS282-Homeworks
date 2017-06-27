using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LomoFilter : CameraPlugin, IFilter

    {
        public string GetImage(string image)
        {
            return "這是LOMO風格化" + image;
        }
    }
}