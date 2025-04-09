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

namespace Memory_4
{
    public partial class Form_avatarka : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> pictureBoxes_2 = new List<PictureBox>();
        List<Label> labels = new List<Label>();

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
        
        int first = 0;
        int second = 0;

        bool enu_petux = false;
        bool enu_svinia = false;
        bool enu_kozel = false;
        bool enu_baran = false;

        string[] words = new string[18];

        public Form_avatarka(Form1 ParentRef)
        {
            InitializeComponent();

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            pictureBox2.Region = rg;
            pictureBox3.Region = rg;
            pictureBox4.Region = rg;
            pictureBox5.Region = rg;

            GraphicsPath gp_2 = new GraphicsPath();
            gp_2.AddEllipse(0, 0, pictureBox_fon_1.Width - 3, pictureBox_fon_1.Height - 3);
            Region rg_2 = new Region(gp_2);
            pictureBox_fon_1.Region = rg_2;
            pictureBox_fon_2.Region = rg_2;
            pictureBox_fon_3.Region = rg_2;
            pictureBox_fon_4.Region = rg_2;
            pictureBox_fon_5.Region = rg_2;

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

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);

            label1.Text = "Крыса";
            label2.Text = "Петух";
            label3.Text = "Свинья";
            label4.Text = "Козёл";
            label5.Text = "Баран";

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
                    labels[i + 1].Text = words[i+6];
                    labels[i + 1].ForeColor = Color.Red;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            first = pictureBoxes_2.IndexOf(pictureBox);

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
            PictureBox door = pictureBoxes[second];
            door.BackColor = Color.Khaki;

            PictureBox rety = pictureBoxes[first];
            rety.BackColor = Color.Orange;
            second = first;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profil.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < words.GetLength(0); i++)
                {
                    writer.WriteLine(words[i]);
                }
            }
            Form1.SelfRef.new_avatar();
        }
    }
}
