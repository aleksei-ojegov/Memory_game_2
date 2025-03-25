using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_4
{
    public partial class Form1 : Form
    {
        public static Form1 SelfRef { get; set; }
        static int Tema;
        
        public Form1()
        {
            InitializeComponent();
            SelfRef = this;
        }

        private void button_game_Click(object sender, EventArgs e)
        {
            Form2_8x8 form2 = new Form2_8x8(SelfRef, Tema);
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

        public void set() //после перехода из окна игры, устанавливает нача
        {
            this.tabControl1.SelectedIndex = 0;
            try
            {
                Form2_8x8 f2 = (Form2_8x8)Application.OpenForms["Form2_8x8"];
                f2.Close();
            }
            catch (NullReferenceException ne)
            {

            }
        }
    }
}
