namespace WindowsFormsApplication1
{
    partial class MoviesGetYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.moviesData = new System.Windows.Forms.ComboBox();
            this.moviesYear = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.Year_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies Name";
            // 
            // moviesData
            // 
            this.moviesData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moviesData.FormattingEnabled = true;
            this.moviesData.Location = new System.Drawing.Point(304, 103);
            this.moviesData.Name = "moviesData";
            this.moviesData.Size = new System.Drawing.Size(201, 24);
            this.moviesData.TabIndex = 1;
            // 
            // moviesYear
            // 
            this.moviesYear.Enabled = false;
            this.moviesYear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesYear.Location = new System.Drawing.Point(366, 261);
            this.moviesYear.Name = "moviesYear";
            this.moviesYear.Size = new System.Drawing.Size(84, 32);
            this.moviesYear.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(625, 103);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 24);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_label.Location = new System.Drawing.Point(259, 264);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(51, 24);
            this.Year_label.TabIndex = 4;
            this.Year_label.Text = "Year";
            // 
            // MoviesGetYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 537);
            this.Controls.Add(this.Year_label);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.moviesYear);
            this.Controls.Add(this.moviesData);
            this.Controls.Add(this.label1);
            this.Name = "MoviesGetYear";
            this.Text = "MoviesGetYear";
            this.Load += new System.EventHandler(this.MoviesGetYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox moviesData;
        private System.Windows.Forms.TextBox moviesYear;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label Year_label;
    }
}