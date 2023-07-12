using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryGameForm : Form
    {
        /*
             Homework1:
             Bir Memory Game yığmalısınız. Məsələn 20 dənə button olacaq və button'ların rəngi oyun başlayanda boz olacaq. Button'ların hər birində bir şəkil
             gizlənəcək. Button'a click edən zaman həmin button'un şəkli o button'un arxa fonu olacaq. Eyni anda 2 button'un arxa fon şəkli görsənəcək və 3-cü
             button'a click edəndə digər 2 button təkrar boz olacaq və 3-cü click edilən button'un arxa fonunda öz şəkli çıxacaq. Ancaq 3-cü button'a click edəndə
             əgər ondan əvvəlki 2 button'un arxa fon şəkli eyni olubsa bağlanmayacaq onlar açıq qalacaq və 4-cü button'a click edəndə 3 və 4'ün şəkilləri fərqlidirsə
             5-ci button'a click edəndə 3 və 4 boz olacaq 5 açılacaq. Ümumi 10 ədəd şəkil lazımdır 20 button üçün çünkü 1 şəkil 2 button'da gizlənəcək.
             Google'da Memory Game yazıb nümunələrinə baxa bilərsiniz. Reset Game button'u olacaq və click olunan zaman şəkillərin yerləri random dəyişdirilib 
             button'lar yenidən boz olacaq. Oyun bitəndə isə ilk açılan buttonla son button arasında yəni oyun müddətində keçən zaman bir label'ə yazılacaq.
             Oyun ilk dəfə run olunanda "Rekord: -" yazılacaq. İlk oyunda əgər 40 saniyəyə bitirmişəmsə "Rekord: 00:40:00.000" yazılacaq (millisaniyələr də nəzərə
             alınır). Növbəti oyunların birində əgər 40 saniyə rekordum qırılarsa onda ekrana "Rekord yeniləndi!" popup mesajı çıxacaq. Əgər rekord yenilənməzsə
             oyun bitəndə "Uduzdunuz!" mesajı çıxacaq. Oyun resetlənən zaman rekord dəyəri sıfırlanmayacaq sadəcə button'lar sıfırlanacaq.
             */

        //Nümunə: https://www.helpfulgames.com/subjects/brain-training/memory.html
        public MemoryGameForm()
        {
            InitializeComponent();
        }

        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            List<PictureBox> PictureBoxList = new List<PictureBox>();
            List<string> imagePathList = new List<string>()
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
            PictureBox[] pictures = new PictureBox[20];
            Random rand = new Random();
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].Size = new Size(100, 100);
                pictures[i].Tag = i;    //  in "Set image()" method must use
                pictures[i].BackColor = Color.Gray;
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                BeginAgainForRandom:
                int imageIndex = rand.Next(0, 10);
                string imagePath = imagePathList.Find(path => path.Contains("E:\\images\\" + imageIndex + ".png"));

                if (imagePath != null)
                {
                    pictures[i].Image = Image.FromFile("E:\\images\\" + imageIndex + ".png");
                }
                else
                {
                    goto BeginAgainForRandom;  
                }
                imagePathList.Remove("E:\\images\\" + imageIndex + ".png");  // imagepathda sekilin olub olmadigini yoxlamaliyam
                ButtonFlowLayoutPanel.Controls.Add(pictures[i]);
            }

            for (int i = 0; i < 20; i++)
            {
                PictureBoxList.Add(pictures[i]);
            }
        }


    }
    
}
