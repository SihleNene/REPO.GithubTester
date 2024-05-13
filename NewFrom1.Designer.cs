namespace Dragon_Game_gui
{
    partial class NewFrom1
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radEarthDragon1 = new System.Windows.Forms.RadioButton();
            this.radWindDragon1 = new System.Windows.Forms.RadioButton();
            this.radIceDragon1 = new System.Windows.Forms.RadioButton();
            this.radFireDragon1 = new System.Windows.Forms.RadioButton();
            this.radWindDragon2 = new System.Windows.Forms.RadioButton();
            this.radIceDragon2 = new System.Windows.Forms.RadioButton();
            this.radFireDragon2 = new System.Windows.Forms.RadioButton();
            this.radEarthDragon2 = new System.Windows.Forms.RadioButton();
            this.txtDragonName1 = new System.Windows.Forms.TextBox();
            this.txtDragonName2 = new System.Windows.Forms.TextBox();
            this.txtPlayerName2 = new System.Windows.Forms.TextBox();
            this.txtPlayerName1 = new System.Windows.Forms.TextBox();
            this.btnPlayerSave2 = new System.Windows.Forms.Button();
            this.btnPlayerSave1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Silver;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(46, 500);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(1000, 91);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "START";
            this.btnStartGame.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Dragon_Game_gui.Properties.Resources.gui_dragon_game;
            this.pictureBox2.Location = new System.Drawing.Point(46, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 373);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dragon_Game_gui.Properties.Resources.gui_dragon_game;
            this.pictureBox1.Location = new System.Drawing.Point(642, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 373);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radEarthDragon1
            // 
            this.radEarthDragon1.AutoSize = true;
            this.radEarthDragon1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radEarthDragon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEarthDragon1.ForeColor = System.Drawing.Color.Lime;
            this.radEarthDragon1.Location = new System.Drawing.Point(79, 346);
            this.radEarthDragon1.Name = "radEarthDragon1";
            this.radEarthDragon1.Size = new System.Drawing.Size(100, 17);
            this.radEarthDragon1.TabIndex = 6;
            this.radEarthDragon1.TabStop = true;
            this.radEarthDragon1.Text = "Earth Dragon";
            this.radEarthDragon1.UseVisualStyleBackColor = false;
            // 
            // radWindDragon1
            // 
            this.radWindDragon1.AutoSize = true;
            this.radWindDragon1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radWindDragon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWindDragon1.ForeColor = System.Drawing.Color.Cyan;
            this.radWindDragon1.Location = new System.Drawing.Point(80, 304);
            this.radWindDragon1.Name = "radWindDragon1";
            this.radWindDragon1.Size = new System.Drawing.Size(99, 17);
            this.radWindDragon1.TabIndex = 7;
            this.radWindDragon1.TabStop = true;
            this.radWindDragon1.Text = "Wind Dragon";
            this.radWindDragon1.UseVisualStyleBackColor = false;
            // 
            // radIceDragon1
            // 
            this.radIceDragon1.AutoSize = true;
            this.radIceDragon1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radIceDragon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIceDragon1.ForeColor = System.Drawing.Color.Blue;
            this.radIceDragon1.Location = new System.Drawing.Point(79, 265);
            this.radIceDragon1.Name = "radIceDragon1";
            this.radIceDragon1.Size = new System.Drawing.Size(88, 17);
            this.radIceDragon1.TabIndex = 8;
            this.radIceDragon1.TabStop = true;
            this.radIceDragon1.Text = "Ice Dragon";
            this.radIceDragon1.UseVisualStyleBackColor = false;
            // 
            // radFireDragon1
            // 
            this.radFireDragon1.AutoSize = true;
            this.radFireDragon1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radFireDragon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFireDragon1.ForeColor = System.Drawing.Color.Red;
            this.radFireDragon1.Location = new System.Drawing.Point(79, 228);
            this.radFireDragon1.Name = "radFireDragon1";
            this.radFireDragon1.Size = new System.Drawing.Size(91, 17);
            this.radFireDragon1.TabIndex = 9;
            this.radFireDragon1.TabStop = true;
            this.radFireDragon1.Text = "Fire Dragon";
            this.radFireDragon1.UseVisualStyleBackColor = false;
            // 
            // radWindDragon2
            // 
            this.radWindDragon2.AutoSize = true;
            this.radWindDragon2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radWindDragon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWindDragon2.ForeColor = System.Drawing.Color.Cyan;
            this.radWindDragon2.Location = new System.Drawing.Point(680, 304);
            this.radWindDragon2.Name = "radWindDragon2";
            this.radWindDragon2.Size = new System.Drawing.Size(99, 17);
            this.radWindDragon2.TabIndex = 10;
            this.radWindDragon2.TabStop = true;
            this.radWindDragon2.Text = "Wind Dragon";
            this.radWindDragon2.UseVisualStyleBackColor = false;
            // 
            // radIceDragon2
            // 
            this.radIceDragon2.AutoSize = true;
            this.radIceDragon2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radIceDragon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIceDragon2.ForeColor = System.Drawing.Color.Blue;
            this.radIceDragon2.Location = new System.Drawing.Point(680, 265);
            this.radIceDragon2.Name = "radIceDragon2";
            this.radIceDragon2.Size = new System.Drawing.Size(88, 17);
            this.radIceDragon2.TabIndex = 11;
            this.radIceDragon2.TabStop = true;
            this.radIceDragon2.Text = "Ice Dragon";
            this.radIceDragon2.UseVisualStyleBackColor = false;
            this.radIceDragon2.CheckedChanged += new System.EventHandler(this.radIceDragon2_CheckedChanged);
            // 
            // radFireDragon2
            // 
            this.radFireDragon2.AutoSize = true;
            this.radFireDragon2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radFireDragon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFireDragon2.ForeColor = System.Drawing.Color.Red;
            this.radFireDragon2.Location = new System.Drawing.Point(680, 228);
            this.radFireDragon2.Name = "radFireDragon2";
            this.radFireDragon2.Size = new System.Drawing.Size(91, 17);
            this.radFireDragon2.TabIndex = 12;
            this.radFireDragon2.TabStop = true;
            this.radFireDragon2.Text = "Fire Dragon";
            this.radFireDragon2.UseVisualStyleBackColor = false;
            // 
            // radEarthDragon2
            // 
            this.radEarthDragon2.AutoSize = true;
            this.radEarthDragon2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radEarthDragon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEarthDragon2.ForeColor = System.Drawing.Color.Lime;
            this.radEarthDragon2.Location = new System.Drawing.Point(680, 346);
            this.radEarthDragon2.Name = "radEarthDragon2";
            this.radEarthDragon2.Size = new System.Drawing.Size(100, 17);
            this.radEarthDragon2.TabIndex = 13;
            this.radEarthDragon2.TabStop = true;
            this.radEarthDragon2.Text = "Earth Dragon";
            this.radEarthDragon2.UseVisualStyleBackColor = false;
            // 
            // txtDragonName1
            // 
            this.txtDragonName1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDragonName1.Location = new System.Drawing.Point(219, 196);
            this.txtDragonName1.Name = "txtDragonName1";
            this.txtDragonName1.Size = new System.Drawing.Size(197, 20);
            this.txtDragonName1.TabIndex = 14;
            // 
            // txtDragonName2
            // 
            this.txtDragonName2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDragonName2.Location = new System.Drawing.Point(818, 196);
            this.txtDragonName2.Name = "txtDragonName2";
            this.txtDragonName2.Size = new System.Drawing.Size(197, 20);
            this.txtDragonName2.TabIndex = 15;
            // 
            // txtPlayerName2
            // 
            this.txtPlayerName2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPlayerName2.Location = new System.Drawing.Point(818, 146);
            this.txtPlayerName2.Name = "txtPlayerName2";
            this.txtPlayerName2.Size = new System.Drawing.Size(197, 20);
            this.txtPlayerName2.TabIndex = 16;
            // 
            // txtPlayerName1
            // 
            this.txtPlayerName1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPlayerName1.Location = new System.Drawing.Point(219, 146);
            this.txtPlayerName1.Name = "txtPlayerName1";
            this.txtPlayerName1.Size = new System.Drawing.Size(197, 20);
            this.txtPlayerName1.TabIndex = 17;
            // 
            // btnPlayerSave2
            // 
            this.btnPlayerSave2.BackColor = System.Drawing.Color.Silver;
            this.btnPlayerSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerSave2.Location = new System.Drawing.Point(659, 389);
            this.btnPlayerSave2.Name = "btnPlayerSave2";
            this.btnPlayerSave2.Size = new System.Drawing.Size(374, 34);
            this.btnPlayerSave2.TabIndex = 18;
            this.btnPlayerSave2.Text = "SAVE";
            this.btnPlayerSave2.UseVisualStyleBackColor = false;
            // 
            // btnPlayerSave1
            // 
            this.btnPlayerSave1.BackColor = System.Drawing.Color.Silver;
            this.btnPlayerSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerSave1.Location = new System.Drawing.Point(63, 389);
            this.btnPlayerSave1.Name = "btnPlayerSave1";
            this.btnPlayerSave1.Size = new System.Drawing.Size(374, 34);
            this.btnPlayerSave1.TabIndex = 19;
            this.btnPlayerSave1.Text = "SAVE";
            this.btnPlayerSave1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(654, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Player2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(676, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Player Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Player Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(676, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Dragon Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(75, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Dragon Name:";
            // 
            // NewFrom1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dragon_Game_gui.Properties.Resources.OIP;
            this.ClientSize = new System.Drawing.Size(1096, 627);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayerSave1);
            this.Controls.Add(this.btnPlayerSave2);
            this.Controls.Add(this.txtPlayerName1);
            this.Controls.Add(this.txtPlayerName2);
            this.Controls.Add(this.txtDragonName2);
            this.Controls.Add(this.txtDragonName1);
            this.Controls.Add(this.radEarthDragon2);
            this.Controls.Add(this.radFireDragon2);
            this.Controls.Add(this.radIceDragon2);
            this.Controls.Add(this.radWindDragon2);
            this.Controls.Add(this.radFireDragon1);
            this.Controls.Add(this.radIceDragon1);
            this.Controls.Add(this.radWindDragon1);
            this.Controls.Add(this.radEarthDragon1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnStartGame);
            this.Name = "NewFrom1";
            this.Text = "Ice Dragon";
            this.Load += new System.EventHandler(this.NewFrom1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radEarthDragon1;
        private System.Windows.Forms.RadioButton radWindDragon1;
        private System.Windows.Forms.RadioButton radIceDragon1;
        private System.Windows.Forms.RadioButton radFireDragon1;
        private System.Windows.Forms.RadioButton radWindDragon2;
        private System.Windows.Forms.RadioButton radIceDragon2;
        private System.Windows.Forms.RadioButton radFireDragon2;
        private System.Windows.Forms.RadioButton radEarthDragon2;
        private System.Windows.Forms.TextBox txtDragonName1;
        private System.Windows.Forms.TextBox txtDragonName2;
        private System.Windows.Forms.TextBox txtPlayerName2;
        private System.Windows.Forms.TextBox txtPlayerName1;
        private System.Windows.Forms.Button btnPlayerSave2;
        private System.Windows.Forms.Button btnPlayerSave1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}