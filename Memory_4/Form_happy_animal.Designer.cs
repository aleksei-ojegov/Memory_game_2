namespace Memory_4
{
    partial class Form_happy_animal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_happy_animal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_fon_1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_good = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fon_1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Image = global::Memory_4.Properties.Resources.krisa;
            this.pictureBox1.Location = new System.Drawing.Point(140, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_fon_1
            // 
            this.pictureBox_fon_1.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox_fon_1.Location = new System.Drawing.Point(132, 18);
            this.pictureBox_fon_1.Name = "pictureBox_fon_1";
            this.pictureBox_fon_1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox_fon_1.TabIndex = 6;
            this.pictureBox_fon_1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ты открыл свою новую личность - Крыса !!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поздравляю !";
            // 
            // button_good
            // 
            this.button_good.BackColor = System.Drawing.Color.LightBlue;
            this.button_good.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_good.FlatAppearance.BorderSize = 0;
            this.button_good.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button_good.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button_good.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_good.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_good.ForeColor = System.Drawing.Color.Black;
            this.button_good.Location = new System.Drawing.Point(110, 201);
            this.button_good.Name = "button_good";
            this.button_good.Size = new System.Drawing.Size(130, 30);
            this.button_good.TabIndex = 10;
            this.button_good.Text = "Хорошо";
            this.button_good.UseVisualStyleBackColor = false;
            this.button_good.Click += new System.EventHandler(this.button_good_Click);
            // 
            // Form_happy_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 273);
            this.Controls.Add(this.button_good);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_fon_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_happy_animal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Открыта новая личность !";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fon_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_fon_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_good;
    }
}