using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Memory_4
{
    public partial class Form_avatarka : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> pictureBoxes_2 = new List<PictureBox>();
        List<TextBox> textBoxes = new List<TextBox>();

        string[] dark_animal = new string[4]
        {
            "petux_dark", "svinia_dark", "kozel_dark", "baran_dark"
        };
        string[] animal = new string[5]
        {
            "krisa", "petux", "svinia", "kozel", "baran"
        };
        string[] color = new string[5]
        {
            "LightBlue", "Gainsboro", "LightPink", "SandyBrown", "LightGreen"
        };
        string[] color_font = new string[5]
        {
            "SteelBlue", "DimGray", "MediumVioletRed", "SaddleBrown", "SeaGreen"
        };

        int first = 0;
        int second = 0;

        bool enu_petux = false;
        bool enu_svinia = false;
        bool enu_kozel = false;
        bool enu_baran = false;

        string[] words = new string[18];

        Font font = new Font("Microsoft Sans Serif", 14.0f,
                        FontStyle.Bold );

        public Form_avatarka(Form1 ParentRef)
        {
            InitializeComponent();

            //GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox1.Region = rg;
            //pictureBox2.Region = rg;
            //pictureBox3.Region = rg;
            //pictureBox4.Region = rg;
            //pictureBox5.Region = rg;

            //GraphicsPath gp_2 = new GraphicsPath();
            //gp_2.AddEllipse(0, 0, pictureBox_fon_1.Width - 3, pictureBox_fon_1.Height - 3);
            //Region rg_2 = new Region(gp_2);
            //pictureBox_fon_1.Region = rg_2;
            //pictureBox_fon_2.Region = rg_2;
            //pictureBox_fon_3.Region = rg_2;
            //pictureBox_fon_4.Region = rg_2;
            //pictureBox_fon_5.Region = rg_2;

            pictureBoxes.Add(pictureBox_fon_1);
            pictureBoxes.Add(pictureBox_fon_2);
            pictureBoxes.Add(pictureBox_fon_3);
            pictureBoxes.Add(pictureBox_fon_4);
            pictureBoxes.Add(pictureBox_fon_5);

            pictureBoxes_2.Add(pictureBox1);
            pictureBoxes_2.Add(pictureBox2);
            pictureBoxes_2.Add(pictureBox3);
            pictureBoxes_2.Add(pictureBox4);
            pictureBoxes_2.Add(pictureBox5);

            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);

            textBox1.Text = "Крыса";
            textBox2.Text = "Петух";
            textBox3.Text = "Свинья";
            textBox4.Text = "Козёл";
            textBox5.Text = "Баран";

            textBoxes[0].Font = font;
            textBoxes[0].ForeColor = Color.SteelBlue;

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profil.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                words = ses.Split('!');
            }

            for(int i = 0; i < 4;  i++)
            {
                if (words[i] == "false")
                {
                    pictureBoxes[i + 1].BackColor = Color.FromArgb(64, 64, 64);
                    pictureBoxes_2[i + 1].BackColor = Color.Gray;
                    pictureBoxes_2[i + 1].Image = (Image)Properties.Resources.ResourceManager.GetObject(dark_animal[i]);
                    textBoxes[i + 1].Text = words[i + 6];
                    textBoxes[i + 1].Enabled = false;
                    //textBoxes[i + 1].ForeColor = Color.Red;
                }
                else
                {
                    textBoxes[i + 1].Font = font;
                    textBoxes[i + 1].ForeColor = Color.FromName(color_font[i + 1]);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            first = pictureBoxes_2.IndexOf(pictureBox);

            if (first == -1) //если навели на фоновую рамку
            {
                first = pictureBoxes.IndexOf(pictureBox);
            }

            switch (first)
            {
                case 1:
                    if (words[0] == "false")
                        return;
                    break;
                case 2:
                    if (words[1] == "false")
                        return;
                    break;
                case 3:
                    if (words[2] == "false")
                        return;
                    break;
                case 4:
                    if (words[3] == "false")
                        return;
                    break;
                default: break;
            }

            words[4] = animal[first];
            words[5] = color[first];

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profil.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < words.GetLength(0) - 1; i++)
                {
                    writer.WriteLine(words[i]);
                }
            }
            Form1.SelfRef.new_avatar();
        }

        private void picture_move(object sender, MouseEventArgs e)
        {//при указании мыши на компонент
            PictureBox pictureBox = sender as PictureBox;
            first = pictureBoxes_2.IndexOf(pictureBox);

            if (first == -1) //если навели на фоновую рамку
            {
                first = pictureBoxes.IndexOf(pictureBox);
            }

            switch (first)
            {
                case 1:
                    if (words[0] == "false")
                        return;
                    break;
                case 2:
                    if (words[1] == "false")
                        return;
                    break;
                case 3:
                    if (words[2] == "false")
                        return;
                    break;
                case 4:
                    if (words[3] == "false")
                        return;
                    break;
                default: break;
            }

            PictureBox rety = pictureBoxes[first];
            rety.BackColor = Color.Gold;
        }

        private void picture_leave(object sender, EventArgs e)
        {//при выходе курсора за пределы картинки
            PictureBox pictureBox = sender as PictureBox;
            first = pictureBoxes_2.IndexOf(pictureBox);

            if (first == -1) //если навели на фоновую рамку
            {
                first = pictureBoxes.IndexOf(pictureBox);
            }

            switch (first)
            {
                case 1:
                    if (words[0] == "false")
                        return;
                    break;
                case 2:
                    if (words[1] == "false")
                        return;
                    break;
                case 3:
                    if (words[2] == "false")
                        return;
                    break;
                case 4:
                    if (words[3] == "false")
                        return;
                    break;
                default: break;
            }

            PictureBox rety = pictureBoxes[first];
            rety.BackColor = Color.Khaki;
        }

        private void picture_double_click(object sender, MouseEventArgs e)
        {
            
        }

        private void Form_avatarka_Load(object sender, EventArgs e)
        {

        }
    }
}
