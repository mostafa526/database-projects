namespace WindowsFormsApplication1
{
    partial class displayMovies
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
            this.moviesData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moviesData)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesData
            // 
            this.moviesData.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.moviesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesData.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.moviesData.Location = new System.Drawing.Point(2, 63);
            this.moviesData.Name = "moviesData";
            this.moviesData.RowTemplate.Height = 26;
            this.moviesData.Size = new System.Drawing.Size(801, 432);
            this.moviesData.TabIndex = 0;
            // 
            // displayMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 498);
            this.Controls.Add(this.moviesData);
            this.Name = "displayMovies";
            this.Text = "displayMovies";
            this.Load += new System.EventHandler(this.displayMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView moviesData;
    }
}