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
    public partial class Form_record : Form
    {
        private Form1 ParentRef;
        int point = 0;

        public Form_record(Form1 ParentRef, int Poin)
        {
            InitializeComponent();
            this.ParentRef = ParentRef;
            this.FormClosed += Form_Closed;
            point = Poin;
        }

        private void Form_Closed(object sender, System.EventArgs e)
        {
            //Form1.SelfRef.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hero = textBox1.Text;
            
            if(hero.Length == 0)
            {
                MessageBox.Show($"Нужно ввести хотя бы один символ");
                return;
            }
            
            for( int i = 1; i < hero.Length; i++ )
            {
                char c = hero[i];
                if( c == ' ' )
                {
                    MessageBox.Show($"Нельзя использовать пробелы в имени");
                    return;
                }
            }

            Form1.SelfRef.Show();
            Form1.SelfRef.set_3(point, hero);
        }
    }
}
