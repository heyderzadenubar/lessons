using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
        
        PictureBox[] pictures = new PictureBox[20];
        int i;

        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            for (i = 0; i < pictures.Length; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].Size = new Size(100, 100);
                pictures[i].Tag = i;    //  in "Set image()" method must use
                pictures[i].BackColor = Color.Gray;
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictures[i].Click += PictureBoxClick;
                pictures[i].MouseHover += PictureBoxMouseHover;
                pictures[i].MouseLeave += PictureBoxMouseLeave;
                ButtonFlowLayoutPanel.Controls.Add(pictures[i]);
            }
        }

        private void PictureBoxMouseHover(object sender, EventArgs e)
        {
            int index = int.Parse(((PictureBox)sender).Tag.ToString());
            if (pictures[index].Image == null)
            {
                pictures[index].Cursor = Cursors.Hand;
            }
            else
            {
                pictures[index].Cursor = Cursors.Default;
            }

        }

        private void PictureBoxMouseLeave(object sender, EventArgs e)
        {
            int index = int.Parse(((PictureBox)sender).Tag.ToString());
             pictures[index].Cursor = Cursors.Default;
        }

        bool isFirstClick = false, isSecondClick = false;
        int firstClickTag, secondClickTag, moveCount = 0, findSamePicturesCount = 0;

        private void PictureBoxClick(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image == null)
            {

                int index = int.Parse(((PictureBox)sender).Tag.ToString());
                if (isFirstClick == false)
                {
                    isFirstClick = true;
                    firstClickTag = index;
                    SetImage(index);
                }
                else if (isSecondClick == false)
                {
                    isSecondClick = true;
                    secondClickTag = index;
                    SetImage(index);
                    if (findSamePicturesCount == 9)
                    {
                        DialogResult Result = MessageBox.Show("You win! Do you want play again?","",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        if (Result == DialogResult.Yes)
                        {
                            for(int i = 0; i < 20; i++)
                            {
                                pictures[i].Image = null;
                                moveCount = 0;
                                findSamePicturesCount = 0;
                            }
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
                else if (isFirstClick == true && isSecondClick == true)
                {
                    if (pictures[firstClickTag].ImageLocation != pictures[secondClickTag].ImageLocation)
                    {
                        moveCount++;
                        MoveCountLabel.Text = moveCount.ToString();
                        isFirstClick = true;
                        isSecondClick = false;
                        RemoveImage(firstClickTag, secondClickTag);
                        firstClickTag = index;
                        SetImage(index);
                    }
                    else
                    {
                        moveCount++;
                        findSamePicturesCount++;
                        MoveCountLabel.Text = moveCount.ToString();
                        isFirstClick = true;
                        isSecondClick = false;
                        firstClickTag = index;
                        SetImage(index);
                    }
                }
            }
        }

        private void SetImage(int index)
        {
            switch (index)
            {
                case 0:
                    pictures[index].Image = Image.FromFile("E:\\images\\0.png");
                    pictures[index].ImageLocation = "E:\\images\\0.png";
                    break;
                case 1:
                    pictures[index].Image = Image.FromFile("E:\\images\\1.png");
                    pictures[index].ImageLocation = "E:\\images\\1.png";
                    break;
                case 2:
                    pictures[index].Image = Image.FromFile("E:\\images\\6.png");
                    pictures[index].ImageLocation = "E:\\images\\6.png";
                    break;
                case 3:
                    pictures[index].Image = Image.FromFile("E:\\images\\2.png");
                    pictures[index].ImageLocation = "E:\\images\\2.png";
                    break;
                case 4:
                    pictures[index].Image = Image.FromFile("E:\\images\\4.png");
                    pictures[index].ImageLocation = "E:\\images\\4.png";
                    break;
                case 5:
                    pictures[index].Image = Image.FromFile("E:\\images\\5.png");
                    pictures[index].ImageLocation = "E:\\images\\5.png";
                    break;
                case 6:
                    pictures[index].Image = Image.FromFile("E:\\images\\7.png");
                    pictures[index].ImageLocation = "E:\\images\\7.png";
                    break;
                case 7:
                    pictures[index].Image = Image.FromFile("E:\\images\\3.png");
                    pictures[index].ImageLocation = "E:\\images\\3.png";
                    break;
                case 8:
                    pictures[index].Image = Image.FromFile("E:\\images\\0.png");
                    pictures[index].ImageLocation = "E:\\images\\0.png";
                    break;
                case 9:
                    pictures[index].Image = Image.FromFile("E:\\images\\1.png");
                    pictures[index].ImageLocation = "E:\\images\\1.png";
                    break;
                case 10:
                    pictures[index].Image = Image.FromFile("E:\\images\\2.png");
                    pictures[index].ImageLocation = "E:\\images\\2.png";
                    break;
                case 11:
                    pictures[index].Image = Image.FromFile("E:\\images\\9.png");
                    pictures[index].ImageLocation = "E:\\images\\9.png";
                    break;
                case 12:
                    pictures[index].Image = Image.FromFile("E:\\images\\3.png");
                    pictures[index].ImageLocation = "E:\\images\\3.png";
                    break;
                case 13:
                    pictures[index].Image = Image.FromFile("E:\\images\\4.png");
                    pictures[index].ImageLocation = "E:\\images\\4.png";
                    break;
                case 14:
                    pictures[index].Image = Image.FromFile("E:\\images\\5.png");
                    pictures[index].ImageLocation = "E:\\images\\5.png";
                    break;
                case 15:
                    pictures[index].Image = Image.FromFile("E:\\images\\6.png");
                    pictures[index].ImageLocation = "E:\\images\\6.png";
                    break;
                case 16:
                    pictures[index].Image = Image.FromFile("E:\\images\\7.png");
                    pictures[index].ImageLocation = "E:\\images\\7.png";
                    break;
                case 17:
                    pictures[index].Image = Image.FromFile("E:\\images\\8.png");
                    pictures[index].ImageLocation = "E:\\images\\8.png";
                    break;
                case 18:
                    pictures[index].Image = Image.FromFile("E:\\images\\8.png");
                    pictures[index].ImageLocation = "E:\\images\\8.png";
                    break;
                case 19:
                    pictures[index].Image = Image.FromFile("E:\\images\\9.png");
                    pictures[index].ImageLocation = "E:\\images\\9.png";
                    break;
                default:
                    break;
            }
        }

        private void RemoveImage(int firstClickindex, int secondClickIndex)
        {
            pictures[firstClickindex].Image = null;
            pictures[secondClickIndex].Image = null;
        }
    }
    
}
