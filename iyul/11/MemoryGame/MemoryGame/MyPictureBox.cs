using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public class MyPictureBox:PictureBox
    {
        public static List<string> imagePathList = new List<string>()
        {
                "E:\\images\\0.png",
                "E:\\images\\1.png",
                "E:\\images\\2.png",
                "E:\\images\\3.png",
                "E:\\images\\4.png",
                "E:\\images\\5.png",
                "E:\\images\\6.png",
                "E:\\images\\7.png",
                "E:\\images\\8.png",
                "E:\\images\\9.png",
                "E:\\images\\0.png",
                "E:\\images\\1.png",
                "E:\\images\\2.png",
                "E:\\images\\3.png",
                "E:\\images\\4.png",
                "E:\\images\\5.png",
                "E:\\images\\6.png",
                "E:\\images\\7.png",
                "E:\\images\\8.png",
                "E:\\images\\9.png",
        };
        public static PictureBox[] pictures = new PictureBox[20];
        Random rand = new Random();

        
    }
}
