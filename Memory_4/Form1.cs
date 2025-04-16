using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using ToolTip = System.Windows.Forms.ToolTip;
using System.Security.Cryptography;

namespace Memory_4
{
    public partial class Form1 : Form
    {
        public static Form1 SelfRef { get; set; }
        static int Tema;
        static int min_record;
        static int Poin;
        string[] profil = new string[18];
        string[] temi = new string[18];
        string[] tem_set = new string[2];
        string[] words = new string[18];
        string[] slovo = new string[3];
        string[] baza = new string[18];
        string[] baza_loc = new string[18]
        {
            "im1", "im2", "im3", "im4",
            "im5", "im6", "im7",  "im8",
            "im9", "im10",  "im11",  "im12",
            "im13", "im14",  "im15", "im16",
            "im17",  "im18"
        };
        string[] baza_art = new string[18]
        {
            "art1", "art2", "art3", "art4",
            "art5", "art6", "art7",  "art8",
            "art9", "art10",  "art11",  "art12",
            "art13", "art14",  "art15", "art16",
            "art17",  "art18"
        };
        string[] animal = new string[4]
        {
            "petux", "svinia", "kozel", "baran"
        };
        string[] color = new string[4]
        {
            "Gainsboro", "LightPink", "SandyBrown", "LightGreen"
        };
        string heros = "Player1";
        string old_name = "Player1";

        bool record = false;

        int chislo_record = 0;
        int nomer_image = 0;
        int nomer_hero = 0;
        int nomer_color = 1;
        int counter_game = 0;
        int counter_level_game = 0;
        int counter_tema_game = 0;
        int victory_count = 0;
        int para_count = 0;
        int vidor_icon_tem = 0;

        int[] level_game = new int[2];
        int[] tema_game = new int[2];
        int[] set_game = new int[2];

        Color disco = new Color();
        Font font_winner = new Font("Microsoft Sans Serif", 9.0f,
                        FontStyle.Regular);
        Font font_draw = new Font("Microsoft Sans Serif", 9.0f,
                        FontStyle.Regular);

        ToolTip toolTip1 = new ToolTip();
        ListViewItem lvi_2 = new ListViewItem();
        public Form1()
        {
            InitializeComponent();
            SelfRef = this;
            Refresh_record();
            //tabControl1.BackColor = Color.White;

            //GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox_fon_1.Width - 3, pictureBox_fon_1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox_fon_1.Region = rg;

            //GraphicsPath gp_2 = new GraphicsPath();
            //gp_2.AddEllipse(0, 0, pictureBox2.Width - 3, pictureBox2.Height - 3);
            //Region rg_2 = new Region(gp_2);
            //pictureBox2.Region = rg_2;

            string filePath_2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profil.txt");
            FileInfo fileInfo_2 = new FileInfo(filePath_2);
            using (StreamReader reader = fileInfo_2.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                profil = ses.Split('!');
            }
            old_name = profil[10];
            counter_game = Convert.ToInt32(profil[11]);
            level_game[0] = Convert.ToInt32(profil[12]);
            level_game[1] = Convert.ToInt32(profil[13]);
            tema_game[0] = Convert.ToInt32(profil[14]);
            tema_game[1] = Convert.ToInt32(profil[15]);
            victory_count = Convert.ToInt32(profil[16]);
            para_count = Convert.ToInt32(profil[17]);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tema.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            string sesi = null;
            int count_tem = 0;

            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    sesi += s + '!';
                    count_tem++;
                }
                temi = sesi.Split('!');
            }
            //comboBox1.Items.AddRange(temi);
            //comboBox1.Items.RemoveAt(count_tem);
            //comboBox1.SelectedIndex = 0;
            //radioButton2.Select();

            

            this.FormClosed += Form1_Closed;

            toolTip1.InitialDelay = 100;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.pictureBox_fon_1, "Это вы !");
            toolTip1.SetToolTip(this.pictureBox2, "Это вы !");
        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            //MessageBox.Show("End");
            write_statistik();
        }

        private void Refresh_record()
        {//расстановка рекордстменов в таблице
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            int[] itog = new int[6];
            string[,] mass = new string[6, 4];

            using (StreamReader reader = fileInfo.OpenText())
            {// чтение текста из файла
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                string[] words = ses.Split('!');

                for (int i = 0; i < words.Length - 1; i++)
                {
                    string ce = words[i];
                    for (int j = 0; j < 4; j++)
                    {
                        mass[i, j] = ce.Split('_')[j];
                    }
                }
            }

            label1_1.Text = mass[0, 0];
            label1_2.Text = mass[1, 0];
            label1_3.Text = mass[2, 0];
            label1_4.Text = mass[3, 0];
            label1_5.Text = mass[4, 0];

            label2_1.Text = mass[0, 1];
            label2_2.Text = mass[1, 1];
            label2_3.Text = mass[2, 1];
            label2_4.Text = mass[3, 1];
            label2_5.Text = mass[4, 1];

            picture_rec_1.Image = (Image)Properties.Resources.ResourceManager.GetObject(mass[0, 2]);
            picture_rec_2.Image = (Image)Properties.Resources.ResourceManager.GetObject(mass[1, 2]);
            picture_rec_3.Image = (Image)Properties.Resources.ResourceManager.GetObject(mass[2, 2]);
            picture_rec_4.Image = (Image)Properties.Resources.ResourceManager.GetObject(mass[3, 2]);
            picture_rec_5.Image = (Image)Properties.Resources.ResourceManager.GetObject(mass[4, 2]);
        }

        private void button_game_Click(object sender, EventArgs e)
        {
            min_record = Convert.ToInt32(label2_5.Text);
            Form2_8x8 form2 = new Form2_8x8(SelfRef, Tema, min_record);
            form2.Okrugli_pictire();
            //form2.Show();
            this.Hide();
        }

        private void button_menu_1_game_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = Convert.ToInt32(tem_set[0]) - 1;
            string filePath_3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.txt");
            FileInfo fileInfo_3 = new FileInfo(filePath_3);
            using (StreamReader reader = fileInfo_3.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                tem_set = ses.Split('!');
            }

            if (tem_set[1] == "1")
            {
                radioButton1.Select();
            }
            else
            {
                radioButton2.Select();
            }

            listView1.Clear();
            for (int i = 0; i < 2; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = temi[i];
                lvi.ImageIndex = i;
                listView1.Items.Add(lvi);
            }
            int select_icon = Convert.ToInt32(tem_set[0]) - 1;
            listView1.Items[select_icon].BackColor = Color.Aqua;
            this.tabControl1.SelectedIndex = 2;
        }

        private void button_menu_1_rec_Click(object sender, EventArgs e)
        {//открыть таблицу рекордов
            obnova_tabliz();
            Refresh_record();
            this.tabControl1.SelectedIndex = 3;
        }

        public void obnova_tabliz()
        {
            string[] profile = new string[18];
            string[,] mass = new string[6, 4];
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            // чтение текста из файла
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                string[] words = ses.Split('!');

                for (int i = 0; i < words.Length - 1; i++)
                {
                    string ce = words[i];
                    for (int j = 0; j < 4; j++)
                    {
                        mass[i, j] = ce.Split('_')[j];
                    }
                }
            }

            string filePath_2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profil.txt");
            FileInfo fileInfo_2 = new FileInfo(filePath_2);
            using (StreamReader reader = fileInfo_2.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                profile = ses.Split('!');
            }

            for (int i = 0; i < mass.GetUpperBound(0); i++)
            {
                if (mass[i, 0] == old_name)
                {
                    mass[i, 0] = profile[10];
                    mass[i, 2] = profile[4];
                }
            }

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < mass.GetLength(0) - 1; i++)
                {
                    writer.WriteLine(mass[i, 0] + "_" + mass[i, 1] + "_" + mass[i, 2] + "_" + i);
                }
            }
        }

        private void button_menu_2_tem_1_Click(object sender, EventArgs e)
        {
            Tema = 1;
            this.tabControl1.SelectedIndex = 2;
        }

        private void button_menu_2_tema_2_Click(object sender, EventArgs e)
        {
            Tema = 2;
            this.tabControl1.SelectedIndex = 2;
        }

        private void button_menu_2_back_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void button_menu_3_back_Click(object sender, EventArgs e)
        {
            switch (vidor_icon_tem)
            {
                case 0:
                    Tema = 1;
                    break;
                case 1:
                    Tema = 2;
                    break;
                default: break;
            }

            min_record = Convert.ToInt32(label2_5.Text);

            if (radioButton1.Checked)
            {
                set_game[1] = 1;
            }

            if (radioButton2.Checked)
            {
                set_game[1] = 2;
            }

            if (checkBox1.Checked)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.txt");
                FileInfo fileInfo = new FileInfo(filePath);

                File.Delete(filePath);
                File.Create(filePath).Close();

                set_game[0] = Tema;
                using (StreamWriter writer = fileInfo.AppendText())
                {
                    for (int i = 0; i < set_game.GetLength(0); i++)
                    {
                        writer.WriteLine(set_game[i]);
                    }
                }
            }
            this.tabControl1.SelectedIndex = 0;
        }

        private void button_menu_4_back_Click(object sender, EventArgs e)
        {//выход из вкладки Рекорды
            this.tabControl1.SelectedIndex = 0;
            label1_1.ForeColor = Color.SteelBlue;
            label2_1.ForeColor = Color.SteelBlue;
            label1.ForeColor = Color.SteelBlue;
            label1_2.ForeColor = Color.SteelBlue;
            label2_2.ForeColor = Color.SteelBlue;
            label2.ForeColor = Color.SteelBlue;
            label1_3.ForeColor = Color.SteelBlue;
            label2_3.ForeColor = Color.SteelBlue;
            label3.ForeColor = Color.SteelBlue;
            label1_4.ForeColor = Color.SteelBlue;
            label2_4.ForeColor = Color.SteelBlue;
            label4.ForeColor = Color.SteelBlue;
            label1_5.ForeColor = Color.SteelBlue;
            label2_5.ForeColor = Color.SteelBlue;
            label5.ForeColor = Color.SteelBlue;

            timer1.Stop();
        }

        public void set(bool new_record, int points)
        {//закрытие дочерней формы игры 6 на 6
            this.tabControl1.SelectedIndex = 0;
            record = new_record;
            try
            {
                Form2_8x8 f2 = (Form2_8x8)Application.OpenForms["Form2_8x8"];
                f2.Close();
                if (record)
                {
                    chislo_record = points;
                    this.new_record(chislo_record);
                }
            }
            catch (NullReferenceException ne)
            {

            }
        }

        public void set_2(bool new_record, int points)
        {//закрытие дочерней формы игры 4 на 4
            this.tabControl1.SelectedIndex = 0;
            record = new_record;
            try
            {
                Form3_4x4 f3 = (Form3_4x4)Application.OpenForms["Form3_4x4"];
                f3.Close();
                if (record)
                {
                    chislo_record = points;
                    this.new_record(chislo_record);
                }
            }
            catch (NullReferenceException ne)
            {

            }
        }

        public void set_3(int point, string hero)
        {//закрытие дочерней формы рекорда
            this.tabControl1.SelectedIndex = 3;
            tabl_rec(point, hero);
            try
            {
                Form_record fr = (Form_record)Application.OpenForms["Form_record"];
                fr.Close();
            }
            catch (NullReferenceException ne)
            {

            }
        }

        public void tabl_rec(int result, string hero)
        {//обновление данных рекордов после нового рекорда

            int nomer_6 = 6;
            int rer = result;
            string[,] mass = new string[6, 4];
            string[] mas = new string[6];
            string[] profile = new string[18];

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            string filePath_2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profil.txt");
            FileInfo fileInfo_2 = new FileInfo(filePath_2);
            using (StreamReader reader = fileInfo_2.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                profile = ses.Split('!');
            }

            // чтение текста из файла
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '!';
                }
                string[] words = ses.Split('!');

                for (int i = 0; i < words.Length - 1; i++)
                {
                    string ce = words[i];
                    for (int j = 0; j < 4; j++)
                    {
                        mass[i, j] = ce.Split('_')[j];
                    }
                }

                int min = int.Parse(mass[words.Length - 2, 1]);

                if (rer > min)
                {
                    mass[5, 0] = hero;
                    mass[5, 1] = rer.ToString();
                    mass[5, 2] = profile[4];
                    mass[5, 3] = 6.ToString();
                }

                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    for (int i = 0; i < mass.GetLength(0) - 1; i++)
                    {
                        int first = Convert.ToInt32(mass[i, 1]);
                        int second = Convert.ToInt32(mass[i + 1, 1]);

                        if (first < second)
                        {
                            (mass[i + 1, 3], mass[i, 3]) = (mass[i, 3], mass[i + 1, 3]);
                            (mass[i + 1, 2], mass[i, 2]) = (mass[i, 2], mass[i + 1, 2]);
                            (mass[i + 1, 1], mass[i, 1]) = (mass[i, 1], mass[i + 1, 1]);
                            (mass[i + 1, 0], mass[i, 0]) = (mass[i, 0], mass[i + 1, 0]);
                        }
                    }
                }

                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    mas[i] = mass[i, 3];
                }
                nomer_hero = Array.IndexOf(mas, "6");
            }

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < mass.GetLength(0) - 1; i++)
                {
                    writer.WriteLine(mass[i, 0] + "_" + mass[i, 1] + "_" + mass[i, 2] + "_" + i);
                }
            }
            timer1.Start();
            Refresh_record();
        }

        private void button_game_easy_Click(object sender, EventArgs e)
        {
            min_record = Convert.ToInt32(label2_5.Text);
            Form3_4x4 form3 = new Form3_4x4(SelfRef, Tema, min_record);
            form3.Okrugli_pictire();
            //form3.Show();
            this.Hide();
        }

        public void new_record(int point)
        {//новый рекорд после игры
            Poin = point;
            //Form_record form_r = new Form_record(SelfRef, Poin);
            //form_r.Show();
            this.tabControl1.SelectedIndex = 3;
            tabl_rec(point, profil[10]);
            this.Show();
        }

        private void button_bock_Click(object sender, EventArgs e)
        {//открытие энциклопедии из главного меню
            this.tabControl1.SelectedIndex = 4;
            button_next.Enabled = true;
            button_next.BackColor = Color.LightBlue;
            baza = baza_loc;
            nomer_image = 0;
            pictureBox_book.Image = (Image)Properties.Resources.ResourceManager.GetObject(baza[0]);
            label_nomer_book.Text = $"{nomer_image + 1} / 18";
            button_back.Enabled = false;
            button_back.BackColor = Color.DarkSlateGray;

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "loc.txt");
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
            slovo = words[nomer_image].Split('_');
            textBox1.Text = slovo[0];
            textBox2.Text = slovo[1];
            textBox3.Text = slovo[2];
        }

        private void button_back_Click(object sender, EventArgs e)
        {//кнопка предыдущая картинка в энциклопедии
            nomer_image--;
            pictureBox_book.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(baza[nomer_image]);
            label_nomer_book.Text = $"{nomer_image + 1} / 18";
            //textBox1.Text = words[nomer_image];
            slovo = words[nomer_image].Split('_');
            textBox1.Text = slovo[0];
            textBox2.Text = slovo[1];
            textBox3.Text = slovo[2];
            if (nomer_image < 17)
            {
                button_next.Enabled = true;
                button_next.BackColor = Color.LightBlue;
            }

            if (nomer_image == 0)
            {
                button_back.Enabled = false;
                button_back.BackColor = Color.DarkSlateGray;
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {//кнопка следующая картинка в энциклопедии
            nomer_image++;
            pictureBox_book.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(baza[nomer_image]);
            label_nomer_book.Text = $"{nomer_image + 1} / 18";
            //textBox1.Text = words[nomer_image];
            slovo = words[nomer_image].Split('_');
            textBox1.Text = slovo[0];
            textBox2.Text = slovo[1];
            textBox3.Text = slovo[2];
            if (nomer_image > 0)
            {
                button_back.Enabled = true;
                button_back.BackColor = Color.LightBlue;
            }

            if (nomer_image == 17)
            {
                button_next.Enabled = false;
                button_next.BackColor = Color.DarkSlateGray;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {//возрат в меню из энциклопедии
            this.tabControl1.SelectedIndex = 0;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {//выбор темы география в энциклопедии
            button_next.Enabled = true;
            button_next.BackColor = Color.LightBlue;
            nomer_image = 0;
            baza = baza_loc;
            pictureBox_book.Image = (Image)Properties.Resources.ResourceManager.GetObject(baza[0]);
            label_nomer_book.Text = $"{nomer_image + 1} / 18";
            button_back.Enabled = false;
            button_back.BackColor = Color.DarkSlateGray;

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "loc.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '\n';
                }
                words = ses.Split('\n');
            }
            //textBox1.Text = words[nomer_image];
            slovo = words[nomer_image].Split('_');
            textBox1.Text = slovo[0];
            textBox2.Text = slovo[1];
            textBox3.Text = slovo[2];
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {//выбор темы живопись в энциклопедии
            button_next.Enabled = true;
            button_next.BackColor = Color.LightBlue;
            nomer_image = 0;
            baza = baza_art;
            pictureBox_book.Image = (Image)Properties.Resources.ResourceManager.GetObject(baza[0]);
            label_nomer_book.Text = $"{nomer_image + 1} / 18";
            button_back.Enabled = false;
            button_back.BackColor = Color.DarkSlateGray;

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "art.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '\n';
                }
                words = ses.Split('\n');
            }
            //textBox1.Text = words[nomer_image];
            slovo = words[nomer_image].Split('_');
            textBox1.Text = slovo[0];
            textBox2.Text = slovo[1];
            textBox3.Text = slovo[2];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (nomer_hero)
            {
                case 0:
                    label1_1.ForeColor = disco;
                    label2_1.ForeColor = disco;
                    label1.ForeColor = disco; break;

                case 1:
                    label1_2.ForeColor = disco;
                    label2_2.ForeColor = disco;
                    label2.ForeColor = disco; break;

                case 2:
                    label1_3.ForeColor = disco;
                    label2_3.ForeColor = disco;
                    label3.ForeColor = disco; break;

                case 3:
                    label1_4.ForeColor = disco;
                    label2_4.ForeColor = disco;
                    label4.ForeColor = disco; break;

                case 4:
                    label1_5.ForeColor = disco;
                    label2_5.ForeColor = disco;
                    label5.ForeColor = disco; break;
                default: break;
            }

            switch (nomer_color)
            {
                case 1: disco = Color.Fuchsia; break;
                case 2:
                    disco = Color.LimeGreen;
                    nomer_color = 0; break;
                default: break;
            }
            nomer_color++;
        }

        private void button_profil_Click(object sender, EventArgs e)
        {
            string[] profile = new string[18];
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
                profile = ses.Split('!');
            }
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(profile[4]);
            pictureBox2.BackColor = Color.FromName(profile[5]);
            textBox_name_profil.Text = profile[10];
            old_name = textBox_name_profil.Text;
            
            write_statistik();
            read_statistik();
            this.tabControl1.SelectedIndex = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_avatarka form_Avatarka = new Form_avatarka(SelfRef);
            form_Avatarka.Show();
        }

        private void button_back_profil_Click(object sender, EventArgs e)
        {
            obnova_tabliz();
            this.tabControl1.SelectedIndex = 0;
        }

        public void new_avatar()
        {
            string[] profil = new string[18];
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
                profil = ses.Split('!');
            }
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(profil[4]);
            pictureBox2.BackColor = Color.FromName(profil[5]);

            try
            {
                Form_avatarka fr = (Form_avatarka)Application.OpenForms["Form_avatarka"];
                fr.Close();
            }
            catch (NullReferenceException ne)
            {

            }
        }

        public void close_happy_animal()
        {
            try
            {
                Form_happy_animal fr = (Form_happy_animal)Application.OpenForms["Form_happy_animal"];
                fr.Close();
            }
            catch (NullReferenceException ne)
            {

            }
        }

        private void button_save_name_Click(object sender, EventArgs e)
        {//сохранить имя пользователя в профиле
            string der = textBox_name_profil.Text;

            if (der.Length == 0)
            {
                MessageBox.Show($"Нужно ввести хотя бы один символ");
                return;
            }

            if (der.Length > 21)
            {
                MessageBox.Show($"Допустимый диапозон 21 символов, вы ввели {der.Length}");
                return;
            }

            for (int i = 1; i < der.Length; i++)
            {
                char c = der[i];
                //if (c == ' ')
                //{
                //    MessageBox.Show($"Нельзя использовать пробелы в имени");
                //    return;
                //}
                if (c == '_')
                {
                    MessageBox.Show($"Нельзя использовать '_' в имени");
                    return;
                }
                if (c == '!')
                {
                    MessageBox.Show($"Нельзя использовать '!' в имени");
                    return;
                }
            }

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
            words[10] = der;

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < words.GetLength(0) - 1; i++)
                {
                    writer.WriteLine(words[i]);
                }
            }
        }

        private void picture_profil_hover(object sender, EventArgs e)
        {
            pictureBox_fon_1.BackColor = Color.Gold;
        }

        private void picture_profil_leave(object sender, EventArgs e)
        {
            pictureBox_fon_1.BackColor = Color.Khaki;
        }

        private void picture_profil_down(object sender, MouseEventArgs e)
        {
            pictureBox_fon_1.BackColor = Color.Orange;
        }

        public void statistica_game(int level, int tema, int victory, int para)
        {
            counter_game++;
            if( level == 0 )
            {
                level_game[0] ++;
            }
            else
            {
                level_game[1] ++;
            }

            switch(tema)
            {
                case 1: tema_game[0] ++; break;
                case 2: tema_game[1] ++; break;
                default: break;
            }

            victory_count += victory;
            para_count += para;
            //MessageBox.Show("statistica_game - " + counter_game);
            //write_statistik();
        }

        public void write_statistik()
        {
            string[] profil = new string[18];
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
                profil = ses.Split('!');
            }

            profil[11] = counter_game.ToString();
            profil[12] = level_game[0].ToString();
            profil[13] = level_game[1].ToString();
            profil[14] = tema_game[0].ToString();
            profil[15] = tema_game[1].ToString();
            profil[16] = victory_count.ToString();
            profil[17] = para_count.ToString();

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < profil.GetLength(0) - 1; i++)
                {
                    writer.WriteLine(profil[i]);
                }
            }
        }

        public void read_statistik()
        {
            string[] profil = new string[18];
            int[] level = new int[2];
            //int[,] tema = new int[2,2];
            string[,] tema = new string[2, 2];
            string tema_string = "";
            string level_string = "";

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
                profil = ses.Split('!');
            }

            level[0] = Convert.ToInt32(profil[12]);
            level[1] = Convert.ToInt32(profil[13]);

            tema[0, 0] = profil[14];
            tema[0, 1] = "География";
            tema[1, 0] = profil[15];
            tema[1, 1] = "Живопись";

            for (int j = 0; j < tema.GetLength(0); j++)
            {
                for(int i = tema.GetLength(0) - 1; i > 0; i--)
                {
                    if (Convert.ToInt32(tema[i, 0]) > Convert.ToInt32(tema[i - 1, 0]))
                    {
                        (tema[i - 1, 0], tema[i, 0]) = (tema[i, 0], tema[i - 1, 0]);
                        (tema[i - 1, 1], tema[i, 1]) = (tema[i, 1], tema[i - 1, 1]);
                    }
                }
            }

            if (tema[0, 0] == tema[1, 0])
            {
                tema_string = $"{tema[0, 1]} ({tema[0, 0]}), {tema[1, 1]} ({tema[1, 0]})";
                label_pro_2_2.Font = font_draw;
            }
            else
            {
                tema_string = $"{tema[0, 1]} ({tema[0, 0]})";
                label_pro_2_2.Font = font_winner;
            }

            if(level[0] == level[1])
            {
                level_string = $"Сложный ({level[1]}), легкий ({level[0]})";
                label_pro_3_2.Font = font_draw;
            }
            else
            {
                if (level[0] > level[1])
                {
                    level_string = $"Легкая ({level[0]})";
                    label_pro_3_2.Font = font_winner;
                }
                else
                {
                    level_string = $"Сложная ({level[1]})";
                    label_pro_3_2.Font = font_winner;
                }
            }
            
            double procent = Convert.ToDouble(profil[16]) / Convert.ToDouble(profil[11]);
            procent = Math.Round(procent*100,2);

            if(procent >= 80)
            {
                label_pro_4_2.ForeColor = Color.DarkViolet;
            }
            else if(procent >= 50)
            {
                label_pro_4_2.ForeColor = Color.ForestGreen;
            }
            else if(procent >= 25)
            {
                label_pro_4_2.ForeColor = Color.Goldenrod;
            }
            else if (procent > 0)
            {
                label_pro_4_2.ForeColor = Color.Crimson;
            }

            if (Convert.ToInt32(profil[11]) != 0)
            {
                label_pro_1_2.Text = profil[11];
                label_pro_2_2.Text = tema_string;
                label_pro_3_2.Text = level_string;
                label_pro_4_2.Text = procent.ToString() + " %";
                label_pro_5_2.Text = profil[17];
            }
            else
            {
                label_pro_1_2.Text = "--";
                label_pro_2_2.Text = "--";
                label_pro_3_2.Text = "--";
                label_pro_4_2.Text = "--";
                label_pro_5_2.Text = "--";
            }
        }

        private void button1_game_start(object sender, EventArgs e)
        {
            //int[] set = new int[2];
            //switch (comboBox1.SelectedIndex)
            //{
            //    case 0:
            //        Tema = 1;
            //        break;
            //    case 1:
            //        Tema = 2;
            //        break;
            //    default: break;
            //}

            switch (vidor_icon_tem)
            {
                case 0:
                    Tema = 1;
                    break;
                case 1:
                    Tema = 2;
                    break;
                default: break;
            }
            
            min_record = Convert.ToInt32(label2_5.Text);

            if (radioButton1.Checked)
            {
                set_game[1] = 1;
                Form3_4x4 form3 = new Form3_4x4(SelfRef, Tema, min_record);
                form3.Okrugli_pictire();
                this.Hide();
            }

            if (radioButton2.Checked)
            {
                set_game[1] = 2;
                Form2_8x8 form2 = new Form2_8x8(SelfRef, Tema, min_record);
                form2.Okrugli_pictire();
                this.Hide();
            }

            if(checkBox1.Checked)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.txt");
                FileInfo fileInfo = new FileInfo(filePath);

                File.Delete(filePath);
                File.Create(filePath).Close();

                set_game[0] = Tema;
                using (StreamWriter writer = fileInfo.AppendText())
                {
                    for (int i = 0; i < set_game.GetLength(0); i++)
                    {
                        writer.WriteLine(set_game[i]);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select_icon = Convert.ToInt32(tem_set[0]) - 1;
            listView1.Items[select_icon].BackColor = Color.White;

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                lvi_2.BackColor = Color.White;
                item.Selected = false;
                item.BackColor = Color.Aqua;
                lvi_2 = item;
                //int der = item.Index;
                vidor_icon_tem = item.Index;
            }
        }
    }
}
