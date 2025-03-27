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
using System.Windows.Forms;

namespace Memory_4
{
    public partial class Form1 : Form
    {
        public static Form1 SelfRef { get; set; }
        static int Tema;
        static int min_record;
        static int Poin;

        public Form1()
        {
            InitializeComponent();
            SelfRef = this;
            //this.dataGridView1.Rows.Add(5);
            Refresh_record();
        }

        private void Refresh_record()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            int[] itog = new int[6];
            string[,] mass = new string[6, 2];

            // чтение текста из файла
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '\n';
                }
                string[] words = ses.Split('\n');

                for (int i = 0; i < words.Length - 1; i++)
                {
                    string ce = words[i];
                    for (int j = 0; j < 2; j++)
                    {
                        mass[i, j] = ce.Split(' ')[j];
                    }
                }

                for (int i = 0; i < words.Length - 1; i++)
                {
                    int ff = Convert.ToInt32(mass[i, 1]);
                    itog[i] = ff;
                }
            }

            //for (int i = 0; i < 5;  i++)
            //{
                //this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
                //this.dataGridView1.Rows[i].Cells[1].Value = mass[i,0];
                //this.dataGridView1.Rows[i].Cells[2].Value = itog[i];
            //}

            this.label1_1.Text = mass[0, 0];
            this.label1_2.Text = mass[1, 0];
            this.label1_3.Text = mass[2, 0];
            this.label1_4.Text = mass[3, 0];
            this.label1_5.Text = mass[4, 0];

            this.label2_1.Text = mass[0, 1];
            this.label2_2.Text = mass[1, 1];
            this.label2_3.Text = mass[2, 1];
            this.label2_4.Text = mass[3, 1];
            this.label2_5.Text = mass[4, 1];
        }

        private void button_game_Click(object sender, EventArgs e)
        {
            Form2_8x8 form2 = new Form2_8x8(SelfRef, Tema, min_record);
            form2.Show();
            this.Hide();
        }

        private void button_menu_1_game_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void button_menu_1_rec_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
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
            this.tabControl1.SelectedIndex = 1;
        }

        private void button_menu_4_back_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        public void set() //закрытие дочерней формы, после возращения в меню
        {
            this.tabControl1.SelectedIndex = 0;
            try
            {
                Form2_8x8 f2 = (Form2_8x8)Application.OpenForms["Form2_8x8"];
                f2.Close();
                //Form3_4x4 f3 = (Form3_4x4)Application.OpenForms["Form3_4x4"];
                //f3.Close(); 
            }
            catch (NullReferenceException ne)
            {

            }
        }

        public void set_2() //закрытие дочерней формы, после возращения в меню
        {
            this.tabControl1.SelectedIndex = 0;
            try
            {
                Form3_4x4 f3 = (Form3_4x4)Application.OpenForms["Form3_4x4"];
                f3.Close();
            }
            catch (NullReferenceException ne)
            {
                
            }
        }

        public void set_3(int point, string hero) //закрытие дочерней формы, после возращения в меню
        {
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
        {
            //string hero = null;
            int rer = result;
            string[,] mass = new string[6, 2];

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
            FileInfo fileInfo = new FileInfo(filePath);

            // чтение текста из файла
            using (StreamReader reader = fileInfo.OpenText())
            {
                string s = "";
                string ses = null;
                while ((s = reader.ReadLine()) != null)
                {
                    ses += s + '\n';
                }
                string[] words = ses.Split('\n');

                for (int i = 0; i < words.Length - 1; i++)
                {
                    string ce = words[i];
                    for (int j = 0; j < 2; j++)
                    {
                        mass[i, j] = ce.Split(' ')[j];
                    }
                }

                int min = int.Parse(mass[words.Length - 2, 1]);

                if (rer > min)
                {
                    mass[5, 0] = hero;
                    mass[5, 1] = rer.ToString();
                }

                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    for (int i = 0; i < mass.GetLength(0) - 1; i++)
                    {
                        int first = Convert.ToInt32(mass[i, 1]);
                        int second = Convert.ToInt32(mass[i + 1, 1]);

                        if (first < second)
                        {
                            (mass[i + 1, 1], mass[i, 1]) = (mass[i, 1], mass[i + 1, 1]);
                            (mass[i + 1, 0], mass[i, 0]) = (mass[i, 0], mass[i + 1, 0]);
                        }
                    }
                }
            }

            File.Delete(filePath);
            File.Create(filePath).Close();

            using (StreamWriter writer = fileInfo.AppendText())
            {
                for (int i = 0; i < mass.GetLength(0) - 1; i++)
                {
                    writer.WriteLine(mass[i, 0] + " " + mass[i, 1]);
                }
            }
            Refresh_record();
        }

        private void button_game_easy_Click(object sender, EventArgs e)
        {
            //min_record = Convert.ToInt32(dataGridView1.Rows[4].Cells[2].Value.ToString());
            min_record = Convert.ToInt32(label2_5.Text);
            Form3_4x4 form3 = new Form3_4x4(SelfRef, Tema, min_record);
            form3.Show();
            this.Hide();
        }

        public void new_record(int point) 
        {
            Poin = point;
            Form_record form_r = new Form_record(SelfRef, Poin);
            form_r.Show();
        }
    }
}
