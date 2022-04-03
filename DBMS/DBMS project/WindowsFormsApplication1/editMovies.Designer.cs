namespace WindowsFormsApplication1
{
    partial class editMovies
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
            this.loadMoviesButton = new System.Windows.Forms.Button();
            this.saveMoviesButton = new System.Windows.Forms.Button();
            this.moviesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadMoviesButton
            // 
            this.loadMoviesButton.Location = new System.Drawing.Point(400, 22);
            this.loadMoviesButton.Name = "loadMoviesButton";
            this.loadMoviesButton.Size = new System.Drawing.Size(181, 44);
            this.loadMoviesButton.TabIndex = 0;
            this.loadMoviesButton.Text = "Load Movies";
            this.loadMoviesButton.UseVisualStyleBackColor = true;
            this.loadMoviesButton.Click += new System.EventHandler(this.loadMoviesButton_Click);
            // 
            // saveMoviesButton
            // 
            this.saveMoviesButton.Location = new System.Drawing.Point(370, 497);
            this.saveMoviesButton.Name = "saveMoviesButton";
            this.saveMoviesButton.Size = new System.Drawing.Size(181, 44);
            this.saveMoviesButton.TabIndex = 1;
            this.saveMoviesButton.Text = "Save Changes";
            this.saveMoviesButton.UseVisualStyleBackColor = true;
            this.saveMoviesButton.Click += new System.EventHandler(this.saveMoviesButton_Click);
            // 
            // moviesGridView
            // 
            this.moviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGridView.Location = new System.Drawing.Point(12, 86);
            this.moviesGridView.Name = "moviesGridView";
            this.moviesGridView.RowTemplate.Height = 26;
            this.moviesGridView.Size = new System.Drawing.Size(936, 405);
            this.moviesGridView.TabIndex = 2;
            // 
            // editMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 553);
            this.Controls.Add(this.moviesGridView);
            this.Controls.Add(this.saveMoviesButton);
            this.Controls.Add(this.loadMoviesButton);
            this.Name = "editMovies";
            this.Text = "editMovies";
            this.Load += new System.EventHandler(this.editMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadMoviesButton;
        private System.Windows.Forms.Button saveMoviesButton;
        private System.Windows.Forms.DataGridView moviesGridView;
    }
}