namespace RatingApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.text_p1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.text_p2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_p3 = new System.Windows.Forms.TextBox();
            this.new_p2_rating = new System.Windows.Forms.TextBox();
            this.Game1_P2 = new System.Windows.Forms.NumericUpDown();
            this.Game1_P1 = new System.Windows.Forms.NumericUpDown();
            this.new_p1_rating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Game2_P3 = new System.Windows.Forms.NumericUpDown();
            this.Game2_P2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Game3_P3 = new System.Windows.Forms.NumericUpDown();
            this.Game3_P1 = new System.Windows.Forms.NumericUpDown();
            this.new_p3_rating = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Game1_P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game1_P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game2_P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game2_P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game3_P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game3_P1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(347, 310);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // text_p1
            // 
            this.text_p1.Location = new System.Drawing.Point(12, 25);
            this.text_p1.Name = "text_p1";
            this.text_p1.Size = new System.Drawing.Size(100, 20);
            this.text_p1.TabIndex = 1;
            this.text_p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // text_p2
            // 
            this.text_p2.Location = new System.Drawing.Point(118, 25);
            this.text_p2.Name = "text_p2";
            this.text_p2.Size = new System.Drawing.Size(100, 20);
            this.text_p2.TabIndex = 2;
            this.text_p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "P1 rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "P2 rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "P3 rating";
            // 
            // text_p3
            // 
            this.text_p3.Location = new System.Drawing.Point(224, 25);
            this.text_p3.Name = "text_p3";
            this.text_p3.Size = new System.Drawing.Size(100, 20);
            this.text_p3.TabIndex = 12;
            this.text_p3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // new_p2_rating
            // 
            this.new_p2_rating.Location = new System.Drawing.Point(118, 275);
            this.new_p2_rating.Name = "new_p2_rating";
            this.new_p2_rating.Size = new System.Drawing.Size(100, 20);
            this.new_p2_rating.TabIndex = 10;
            // 
            // Game1_P2
            // 
            this.Game1_P2.Location = new System.Drawing.Point(41, 95);
            this.Game1_P2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Game1_P2.Name = "Game1_P2";
            this.Game1_P2.Size = new System.Drawing.Size(31, 20);
            this.Game1_P2.TabIndex = 8;
            // 
            // Game1_P1
            // 
            this.Game1_P1.Location = new System.Drawing.Point(41, 69);
            this.Game1_P1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Game1_P1.Name = "Game1_P1";
            this.Game1_P1.Size = new System.Drawing.Size(31, 20);
            this.Game1_P1.TabIndex = 7;
            // 
            // new_p1_rating
            // 
            this.new_p1_rating.Location = new System.Drawing.Point(12, 275);
            this.new_p1_rating.Name = "new_p1_rating";
            this.new_p1_rating.Size = new System.Drawing.Size(100, 20);
            this.new_p1_rating.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "P1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "P2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "P3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "P2";
            // 
            // Game2_P3
            // 
            this.Game2_P3.Location = new System.Drawing.Point(41, 173);
            this.Game2_P3.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Game2_P3.Name = "Game2_P3";
            this.Game2_P3.Size = new System.Drawing.Size(31, 20);
            this.Game2_P3.TabIndex = 16;
            // 
            // Game2_P2
            // 
            this.Game2_P2.Location = new System.Drawing.Point(41, 147);
            this.Game2_P2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Game2_P2.Name = "Game2_P2";
            this.Game2_P2.Size = new System.Drawing.Size(31, 20);
            this.Game2_P2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "P3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "P1";
            // 
            // Game3_P3
            // 
            this.Game3_P3.Location = new System.Drawing.Point(41, 249);
            this.Game3_P3.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Game3_P3.Name = "Game3_P3";
            this.Game3_P3.Size = new System.Drawing.Size(31, 20);
            this.Game3_P3.TabIndex = 20;
            // 
            // Game3_P1
            // 
            this.Game3_P1.Location = new System.Drawing.Point(41, 223);
            this.Game3_P1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Game3_P1.Name = "Game3_P1";
            this.Game3_P1.Size = new System.Drawing.Size(31, 20);
            this.Game3_P1.TabIndex = 19;
            // 
            // new_p3_rating
            // 
            this.new_p3_rating.Location = new System.Drawing.Point(224, 275);
            this.new_p3_rating.Name = "new_p3_rating";
            this.new_p3_rating.Size = new System.Drawing.Size(100, 20);
            this.new_p3_rating.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.new_p3_rating);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Game3_P3);
            this.Controls.Add(this.Game3_P1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Game2_P3);
            this.Controls.Add(this.Game2_P2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_p3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_p2_rating);
            this.Controls.Add(this.new_p1_rating);
            this.Controls.Add(this.Game1_P2);
            this.Controls.Add(this.Game1_P1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_p2);
            this.Controls.Add(this.text_p1);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Game1_P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game1_P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game2_P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game2_P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game3_P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game3_P1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox text_p1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox text_p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_p3;
        private System.Windows.Forms.TextBox new_p2_rating;
        private System.Windows.Forms.NumericUpDown Game1_P2;
        private System.Windows.Forms.NumericUpDown Game1_P1;
        private System.Windows.Forms.TextBox new_p1_rating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Game2_P3;
        private System.Windows.Forms.NumericUpDown Game2_P2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Game3_P3;
        private System.Windows.Forms.NumericUpDown Game3_P1;
        private System.Windows.Forms.TextBox new_p3_rating;
    }
}

