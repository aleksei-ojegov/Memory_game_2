namespace Memory_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_game = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_menu_1_game = new System.Windows.Forms.Button();
            this.button_menu_1_rec = new System.Windows.Forms.Button();
            this.button_menu_2_tema_2 = new System.Windows.Forms.Button();
            this.button_menu_2_tem_1 = new System.Windows.Forms.Button();
            this.button_menu_2_back = new System.Windows.Forms.Button();
            this.button_menu_3_back = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_menu_4_back = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_game
            // 
            this.button_game.Location = new System.Drawing.Point(87, 67);
            this.button_game.Name = "button_game";
            this.button_game.Size = new System.Drawing.Size(151, 25);
            this.button_game.TabIndex = 0;
            this.button_game.Text = "Игра 8х8";
            this.button_game.UseVisualStyleBackColor = true;
            this.button_game.Click += new System.EventHandler(this.button_game_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 294);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_menu_1_rec);
            this.tabPage1.Controls.Add(this.button_menu_1_game);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_menu_2_back);
            this.tabPage2.Controls.Add(this.button_menu_2_tema_2);
            this.tabPage2.Controls.Add(this.button_menu_2_tem_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_menu_3_back);
            this.tabPage3.Controls.Add(this.button_game);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(319, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_menu_1_game
            // 
            this.button_menu_1_game.Location = new System.Drawing.Point(94, 56);
            this.button_menu_1_game.Name = "button_menu_1_game";
            this.button_menu_1_game.Size = new System.Drawing.Size(132, 26);
            this.button_menu_1_game.TabIndex = 0;
            this.button_menu_1_game.Text = "Игра";
            this.button_menu_1_game.UseVisualStyleBackColor = true;
            this.button_menu_1_game.Click += new System.EventHandler(this.button_menu_1_game_Click);
            // 
            // button_menu_1_rec
            // 
            this.button_menu_1_rec.Location = new System.Drawing.Point(94, 106);
            this.button_menu_1_rec.Name = "button_menu_1_rec";
            this.button_menu_1_rec.Size = new System.Drawing.Size(132, 26);
            this.button_menu_1_rec.TabIndex = 1;
            this.button_menu_1_rec.Text = "Рекорды";
            this.button_menu_1_rec.UseVisualStyleBackColor = true;
            this.button_menu_1_rec.Click += new System.EventHandler(this.button_menu_1_rec_Click);
            // 
            // button_menu_2_tema_2
            // 
            this.button_menu_2_tema_2.Location = new System.Drawing.Point(95, 101);
            this.button_menu_2_tema_2.Name = "button_menu_2_tema_2";
            this.button_menu_2_tema_2.Size = new System.Drawing.Size(132, 26);
            this.button_menu_2_tema_2.TabIndex = 3;
            this.button_menu_2_tema_2.Text = "Тема 2";
            this.button_menu_2_tema_2.UseVisualStyleBackColor = true;
            this.button_menu_2_tema_2.Click += new System.EventHandler(this.button_menu_2_tema_2_Click);
            // 
            // button_menu_2_tem_1
            // 
            this.button_menu_2_tem_1.Location = new System.Drawing.Point(95, 56);
            this.button_menu_2_tem_1.Name = "button_menu_2_tem_1";
            this.button_menu_2_tem_1.Size = new System.Drawing.Size(132, 26);
            this.button_menu_2_tem_1.TabIndex = 2;
            this.button_menu_2_tem_1.Text = "Тема 1";
            this.button_menu_2_tem_1.UseVisualStyleBackColor = true;
            this.button_menu_2_tem_1.Click += new System.EventHandler(this.button_menu_2_tem_1_Click);
            // 
            // button_menu_2_back
            // 
            this.button_menu_2_back.Location = new System.Drawing.Point(95, 151);
            this.button_menu_2_back.Name = "button_menu_2_back";
            this.button_menu_2_back.Size = new System.Drawing.Size(132, 26);
            this.button_menu_2_back.TabIndex = 4;
            this.button_menu_2_back.Text = "Назад";
            this.button_menu_2_back.UseVisualStyleBackColor = true;
            this.button_menu_2_back.Click += new System.EventHandler(this.button_menu_2_back_Click);
            // 
            // button_menu_3_back
            // 
            this.button_menu_3_back.Location = new System.Drawing.Point(87, 113);
            this.button_menu_3_back.Name = "button_menu_3_back";
            this.button_menu_3_back.Size = new System.Drawing.Size(151, 26);
            this.button_menu_3_back.TabIndex = 5;
            this.button_menu_3_back.Text = "Назад";
            this.button_menu_3_back.UseVisualStyleBackColor = true;
            this.button_menu_3_back.Click += new System.EventHandler(this.button_menu_3_back_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_menu_4_back);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(319, 268);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_menu_4_back
            // 
            this.button_menu_4_back.Location = new System.Drawing.Point(84, 121);
            this.button_menu_4_back.Name = "button_menu_4_back";
            this.button_menu_4_back.Size = new System.Drawing.Size(151, 26);
            this.button_menu_4_back.TabIndex = 6;
            this.button_menu_4_back.Text = "Назад";
            this.button_menu_4_back.UseVisualStyleBackColor = true;
            this.button_menu_4_back.Click += new System.EventHandler(this.button_menu_4_back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 294);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Игра на память";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_game;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_menu_1_rec;
        private System.Windows.Forms.Button button_menu_1_game;
        private System.Windows.Forms.Button button_menu_2_tema_2;
        private System.Windows.Forms.Button button_menu_2_tem_1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_menu_2_back;
        private System.Windows.Forms.Button button_menu_3_back;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_menu_4_back;
    }
}

