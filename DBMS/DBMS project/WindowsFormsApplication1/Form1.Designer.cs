﻿namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.searchMovieButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchMovieButton
            // 
            this.searchMovieButton.Location = new System.Drawing.Point(56, 19);
            this.searchMovieButton.Name = "searchMovieButton";
            this.searchMovieButton.Size = new System.Drawing.Size(229, 36);
            this.searchMovieButton.TabIndex = 0;
            this.searchMovieButton.Text = "search for movie";
            this.searchMovieButton.UseVisualStyleBackColor = true;
            this.searchMovieButton.Click += new System.EventHandler(this.searchMovieButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "movies prizes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "celebrity prizes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "search for celebrity";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 372);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchMovieButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchMovieButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

