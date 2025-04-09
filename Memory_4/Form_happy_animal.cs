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
    public partial class Form_happy_animal : Form
    {
        string[] words = new string[18];
        string[] animal = new string[4]
        {
            "petux", "svinia", "kozel", "baran"
        };
        string[] color = new string[4]
        {
            "Gainsboro", "LightPink", "SandyBrown", "LightGreen"
        };
        string[] stroka = new string[4]
        {
            "Ты открыл свою новую личность - Петух !!!",
            "Ты открыл свою новую личность - Свинья !!!",
            "Ты открыл свою новую личность - Козёл !!!",
            "Ты открыл свою новую личность - Баран !!!"
        };
        string[] button_stroka = new string[4]
        {
            "Стать петухом",
            "Стать свиньёй",
            "Стать козлом",
            "Стать бараном"
        };
        int tipaz = 1;

        public Form_happy_animal(int tip)
        {
            InitializeComponent();

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

            GraphicsPath gp_2 = new GraphicsPath();
            gp_2.AddEllipse(0, 0, pictureBox_fon_1.Width - 3, pictureBox_fon_1.Height - 3);
            Region rg_2 = new Region(gp_2);
            pictureBox_fon_1.Region = rg_2;

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(animal[tip]);
            pictureBox1.BackColor = Color.FromName(color[tip]);
            label2.Text = stroka[tip];

            tipaz = tip;
        }

        private void button_good_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.close_happy_animal();
        }
    }
}
