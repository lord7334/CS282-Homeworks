using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class Camera
    {
        private IFilter filter;

        private string image = "原始圖片";

        public string private void GerImage()

        {
            if (filter == null)
                return image;
            elsereturn filter.GerImage(image);
        }
    }
}