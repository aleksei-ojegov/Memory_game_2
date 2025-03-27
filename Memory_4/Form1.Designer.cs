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
            this.button_menu_1_rec = new System.Windows.Forms.Button();
            this.button_menu_1_game = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_menu_2_back = new System.Windows.Forms.Button();
            this.button_menu_2_tema_2 = new System.Windows.Forms.Button();
            this.button_menu_2_tem_1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_game_easy = new System.Windows.Forms.Button();
            this.button_menu_3_back = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_menu_4_back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1_1 = new System.Windows.Forms.Label();
            this.label1_2 = new System.Windows.Forms.Label();
            this.label1_3 = new System.Windows.Forms.Label();
            this.label1_4 = new System.Windows.Forms.Label();
            this.label1_5 = new System.Windows.Forms.Label();
            this.label2_1 = new System.Windows.Forms.Label();
            this.label2_2 = new System.Windows.Forms.Label();
            this.label2_3 = new System.Windows.Forms.Label();
            this.label2_4 = new System.Windows.Forms.Label();
            this.label2_5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_game
            // 
            this.button_game.Location = new System.Drawing.Point(98, 87);
            this.button_game.Name = "button_game";
            this.button_game.Size = new System.Drawing.Size(132, 26);
            this.button_game.TabIndex = 0;
            this.button_game.Text = "Игра 6х6";
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
            this.tabControl1.Size = new System.Drawing.Size(327, 280);
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
            this.tabPage1.Size = new System.Drawing.Size(319, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_menu_2_back);
            this.tabPage2.Controls.Add(this.button_menu_2_tema_2);
            this.tabPage2.Controls.Add(this.button_menu_2_tem_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // button_menu_2_tema_2
            // 
            this.button_menu_2_tema_2.Location = new System.Drawing.Point(95, 88);
            this.button_menu_2_tema_2.Name = "button_menu_2_tema_2";
            this.button_menu_2_tema_2.Size = new System.Drawing.Size(132, 26);
            this.button_menu_2_tema_2.TabIndex = 3;
            this.button_menu_2_tema_2.Text = "Живопись";
            this.button_menu_2_tema_2.UseVisualStyleBackColor = true;
            this.button_menu_2_tema_2.Click += new System.EventHandler(this.button_menu_2_tema_2_Click);
            // 
            // button_menu_2_tem_1
            // 
            this.button_menu_2_tem_1.Location = new System.Drawing.Point(95, 56);
            this.button_menu_2_tem_1.Name = "button_menu_2_tem_1";
            this.button_menu_2_tem_1.Size = new System.Drawing.Size(132, 26);
            this.button_menu_2_tem_1.TabIndex = 2;
            this.button_menu_2_tem_1.Text = "Места";
            this.button_menu_2_tem_1.UseVisualStyleBackColor = true;
            this.button_menu_2_tem_1.Click += new System.EventHandler(this.button_menu_2_tem_1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_game_easy);
            this.tabPage3.Controls.Add(this.button_menu_3_back);
            this.tabPage3.Controls.Add(this.button_game);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(319, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_game_easy
            // 
            this.button_game_easy.Location = new System.Drawing.Point(98, 55);
            this.button_game_easy.Name = "button_game_easy";
            this.button_game_easy.Size = new System.Drawing.Size(132, 26);
            this.button_game_easy.TabIndex = 6;
            this.button_game_easy.Text = "Игра 4х4";
            this.button_game_easy.UseVisualStyleBackColor = true;
            this.button_game_easy.Click += new System.EventHandler(this.button_game_easy_Click);
            // 
            // button_menu_3_back
            // 
            this.button_menu_3_back.Location = new System.Drawing.Point(98, 159);
            this.button_menu_3_back.Name = "button_menu_3_back";
            this.button_menu_3_back.Size = new System.Drawing.Size(132, 26);
            this.button_menu_3_back.TabIndex = 5;
            this.button_menu_3_back.Text = "Назад";
            this.button_menu_3_back.UseVisualStyleBackColor = true;
            this.button_menu_3_back.Click += new System.EventHandler(this.button_menu_3_back_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Controls.Add(this.button_menu_4_back);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(319, 254);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_menu_4_back
            // 
            this.button_menu_4_back.Location = new System.Drawing.Point(90, 198);
            this.button_menu_4_back.Name = "button_menu_4_back";
            this.button_menu_4_back.Size = new System.Drawing.Size(151, 26);
            this.button_menu_4_back.TabIndex = 6;
            this.button_menu_4_back.Text = "Назад";
            this.button_menu_4_back.UseVisualStyleBackColor = true;
            this.button_menu_4_back.Click += new System.EventHandler(this.button_menu_4_back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.label2_5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2_4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2_1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1_3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1_4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1_5, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 140);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_1
            // 
            this.label1_1.AutoSize = true;
            this.label1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_1.Location = new System.Drawing.Point(31, 1);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(115, 26);
            this.label1_1.TabIndex = 9;
            this.label1_1.Text = " ";
            this.label1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_2
            // 
            this.label1_2.AutoSize = true;
            this.label1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_2.Location = new System.Drawing.Point(31, 28);
            this.label1_2.Name = "label1_2";
            this.label1_2.Size = new System.Drawing.Size(115, 26);
            this.label1_2.TabIndex = 10;
            this.label1_2.Text = " ";
            this.label1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_3
            // 
            this.label1_3.AutoSize = true;
            this.label1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_3.Location = new System.Drawing.Point(31, 55);
            this.label1_3.Name = "label1_3";
            this.label1_3.Size = new System.Drawing.Size(115, 26);
            this.label1_3.TabIndex = 14;
            this.label1_3.Text = " ";
            this.label1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_4
            // 
            this.label1_4.AutoSize = true;
            this.label1_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_4.Location = new System.Drawing.Point(31, 82);
            this.label1_4.Name = "label1_4";
            this.label1_4.Size = new System.Drawing.Size(115, 26);
            this.label1_4.TabIndex = 15;
            this.label1_4.Text = " ";
            this.label1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_5
            // 
            this.label1_5.AutoSize = true;
            this.label1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_5.Location = new System.Drawing.Point(31, 109);
            this.label1_5.Name = "label1_5";
            this.label1_5.Size = new System.Drawing.Size(115, 30);
            this.label1_5.TabIndex = 16;
            this.label1_5.Text = " ";
            this.label1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_1
            // 
            this.label2_1.AutoSize = true;
            this.label2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_1.Location = new System.Drawing.Point(153, 1);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(116, 26);
            this.label2_1.TabIndex = 17;
            this.label2_1.Text = " ";
            this.label2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_2
            // 
            this.label2_2.AutoSize = true;
            this.label2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_2.Location = new System.Drawing.Point(153, 28);
            this.label2_2.Name = "label2_2";
            this.label2_2.Size = new System.Drawing.Size(116, 26);
            this.label2_2.TabIndex = 18;
            this.label2_2.Text = " ";
            this.label2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_3
            // 
            this.label2_3.AutoSize = true;
            this.label2_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_3.Location = new System.Drawing.Point(153, 55);
            this.label2_3.Name = "label2_3";
            this.label2_3.Size = new System.Drawing.Size(116, 26);
            this.label2_3.TabIndex = 19;
            this.label2_3.Text = " ";
            this.label2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_4
            // 
            this.label2_4.AutoSize = true;
            this.label2_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_4.Location = new System.Drawing.Point(153, 82);
            this.label2_4.Name = "label2_4";
            this.label2_4.Size = new System.Drawing.Size(116, 26);
            this.label2_4.TabIndex = 20;
            this.label2_4.Text = " ";
            this.label2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_5
            // 
            this.label2_5.AutoSize = true;
            this.label2_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_5.Location = new System.Drawing.Point(153, 109);
            this.label2_5.Name = "label2_5";
            this.label2_5.Size = new System.Drawing.Size(116, 30);
            this.label2_5.TabIndex = 21;
            this.label2_5.Text = " ";
            this.label2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Игра на память";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button button_game_easy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2_5;
        private System.Windows.Forms.Label label2_4;
        private System.Windows.Forms.Label label2_3;
        private System.Windows.Forms.Label label2_2;
        private System.Windows.Forms.Label label2_1;
        private System.Windows.Forms.Label label1_2;
        private System.Windows.Forms.Label label1_1;
        private System.Windows.Forms.Label label1_3;
        private System.Windows.Forms.Label label1_4;
        private System.Windows.Forms.Label label1_5;
    }
}

