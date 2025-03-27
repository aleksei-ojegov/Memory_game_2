using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_4
{
    public partial class Form3_4x4 : Form
    {
        private Form1 ParentRef;

        Random random = new Random();
        Timer timer = new Timer { Interval = 1000 };
        string[,] data = new string[16, 2];
        string[] proverka = new string[16];
        string[] baza = new string[16];

        PictureBox firstClicked = null;
        PictureBox secondClicked = null;

        Image newImag = Properties.Resources.question;

        string firstClick = null;
        string secondClick = null;

        int ff = 0;
        int time = 120;
        int points = 0;
        int nazhat = 0;
        int tema_vidor = 0;
        int min_record_buf = 0;

        bool ender = false;

        List<string> icons = new List<string>();
        List<string> icons_reserv = new List<string>();

        List<string> icons_loc = new List<string>()
        {
            "im1", "im1", "im2", "im2", "im3", "im3", "im4", "im4",
            "im5", "im5", "im6", "im6", "im7", "im7", "im8", "im8",
            "im9", "im9", "im10", "im10", "im11", "im11", "im12", "im12",
            "im13", "im13", "im14", "im14", "im15", "im15", "im16", "im16",
            "im17", "im17", "im18", "im18"
        };

        List<string> icons_art = new List<string>()
        {
            "art1", "art1", "art2", "art2", "art3", "art3", "art4", "art4",
            "art5", "art5", "art6", "art6", "art7", "art7", "art8", "art8",
            "art9", "art9", "art10", "art10", "art11", "art11", "art12", "art12",
            "art13", "art13", "art14", "art14", "art15", "art15", "art16", "art16",
            "art17", "art17", "art18", "art18"
        };

        public Form3_4x4(Form1 ParentRef, int Tema, int min_record)
        {
            InitializeComponent();
            tema_vidor = Tema;
            min_record_buf = min_record;
            AssignIconsToSquares();
            this.ParentRef = ParentRef;
            this.FormClosed += Form3_Closed;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form3_Closed(object sender, System.EventArgs e)
        {
            timer.Stop();
            if (!ender)
            {
                Form1.SelfRef.Close();
            }
        }

        private void AssignIconsToSquares()
        {
            icons.Clear();
            icons_reserv.Clear();
            switch (tema_vidor)
            {
                case 1:
                    icons.AddRange(icons_loc);
                    icons_reserv.AddRange(icons_loc);
                    newImag = Properties.Resources.question;
                    break;
                case 2:
                    icons.AddRange(icons_art);
                    icons_reserv.AddRange(icons_art);
                    newImag = Properties.Resources.question1;
                    break;
                default: break;
            }

            for(int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(icons.Count);
                if(randomNumber % 2 == 0)
                {
                    icons.RemoveAt(randomNumber);
                    icons.RemoveAt(randomNumber);
                }
                else
                {
                    icons.RemoveAt(randomNumber);
                    icons.RemoveAt(randomNumber - 1);
                }
            }

            int n = 0;
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                PictureBox pictureBox = control as PictureBox;
                if (pictureBox != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    //pictureBox.Image = Properties.Resources.question;
                    pictureBox.Image = newImag;
                    //pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(icons[randomNumber]);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    data[n, 0] = pictureBox.Name.ToString();
                    data[n, 1] = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                    n++;
                }
            }
            startGameTimer();
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nazhat++;
            if (timer1.Enabled == true)
                return;

            PictureBox pictureBox = sender as PictureBox;
            int ss = 0;

            if (pictureBox != null)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (data[i, 0] == pictureBox.Name.ToString())
                    {
                        ss = i; break;
                    }
                }

                for (int i = 0; i < 16; i++)
                {
                    if (pictureBox.Name.ToString() == baza[i])
                    {
                        return;
                    }
                }

                if (firstClicked == null)
                {
                    firstClicked = pictureBox;
                    firstClick = data[ss, 1];
                    ff = ss;
                    firstClicked.Image = (Image)Properties.Resources.ResourceManager.GetObject(data[ss, 1]);
                    return;
                }

                if (pictureBox == firstClicked)
                    return;

                secondClicked = pictureBox;
                secondClick = data[ss, 1];
                secondClicked.Image = (Image)Properties.Resources.ResourceManager.GetObject(data[ss, 1]);

                if (firstClick == secondClick)
                {
                    proverka[ss] = secondClick;
                    proverka[ff] = firstClick;
                    baza[ss] = firstClicked.Name.ToString();
                    baza[ff] = secondClicked.Name.ToString();
                    firstClicked = null;
                    secondClicked = null;
                    firstClick = null;
                    secondClick = null;

                    CheckForWinner();
                    return;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //firstClicked.Image = Properties.Resources.question;
            //secondClicked.Image = Properties.Resources.question;
            firstClicked.Image = newImag;
            secondClicked.Image = newImag;

            firstClicked = null;
            secondClicked = null;

            firstClick = null;
            secondClick = null;
        }

        private void CheckForWinner()
        {
            int i = 0;
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                PictureBox pictureBox = control as PictureBox;

                if (pictureBox != null)
                {
                    //if (pictureBox.Image != (Image)Properties.Resources.ResourceManager.GetObject("question"))
                    //    return;
                    if (proverka[i] == null)
                        return;

                }
                i++;
            }
            timer.Stop();
            //nazhat
            points = time * 2 - (nazhat - 32);
            MessageBox.Show($"Ты нашёл все картинки!\n\nТы набрал {points} очков!", "Победа");
            if(points > min_record_buf)
            {
                //MessageBox.Show($"гнида черножопая");
                //timer.Stop();
                Form1.SelfRef.new_record(points);
                //Form1.SelfRef.Show();
                //Form1.SelfRef.set_2();
            }
            //Form1.SelfRef.tabl_rec(points);

            Array.Clear(baza, 0, 16);
            Array.Clear(proverka, 0, 16);
            //Close();
            ResetImages();
            Reset_time();

        }

        private void ResetImages() //функция сброса графичиских полей после раунда
        {
            //time = 60;
            //startGameTimer();
            icons.Clear();
            icons.AddRange(icons_reserv);
            Array.Clear(baza, 0, 16);
            Array.Clear(proverka, 0, 16);
            int n = 0;

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(icons.Count);
                if (randomNumber % 2 == 0)
                {
                    icons.RemoveAt(randomNumber);
                    icons.RemoveAt(randomNumber);
                }
                else
                {
                    icons.RemoveAt(randomNumber);
                    icons.RemoveAt(randomNumber - 1);
                }
            }

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                PictureBox pictureBox = control as PictureBox;
                if (pictureBox != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    pictureBox.Image = newImag;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    data[n, 0] = pictureBox.Name.ToString();
                    data[n, 1] = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                    n++;
                }
            }
        }

        private void Reset_time()
        {
            nazhat = 0;
            time = 120;
            timer.Start();
        }

        private void startGameTimer()
        {
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Время вышло");
                    ResetImages();
                    Reset_time();
                }

                if (time == 120)
                {
                    toolStripTextBox1.Text = "02: 00";
                }
                else
                {
                    if (time < 60)
                    {
                        if (time < 10)
                        {
                            toolStripTextBox1.Text = "00: 0" + time.ToString();
                        }
                        else
                        {
                            toolStripTextBox1.Text = "00: " + time.ToString();
                        }
                    }
                    else
                    {
                        if (time < 70)
                        {
                            toolStripTextBox1.Text = "01: 0" + (time - 60).ToString();
                        }
                        else
                        {
                            toolStripTextBox1.Text = "01: " + (time - 60).ToString();
                        }
                    }
                }
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //функция определения нажатия кнопки клавы
        {
            switch (keyData)
            {
                case Keys.W:
                    for (int i = 0; i < 16; i++)
                    {
                        proverka[i] = "123";
                    }

                    int ss = 0;
                    foreach (Control control in tableLayoutPanel1.Controls)
                    {
                        PictureBox pictureBox = control as PictureBox;
                        pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(data[ss, 1]);
                        ss++;
                    }

                    CheckForWinner();
                    break;
                default:
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены ?", "Вернуться в меню", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ender = true;
                timer.Stop();
                Form1.SelfRef.Show();
                Form1.SelfRef.set_2();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            nazhat = 0;
            ResetImages();
            toolStripTextBox1.Text = "02: 00";
            time = 120;
        }
    }
}
