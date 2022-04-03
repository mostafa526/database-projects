namespace WindowsFormsApplication1
{
    partial class searchMoviePrize
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
            this.prizeEntered = new System.Windows.Forms.TextBox();
            this.prizeSearchButton = new System.Windows.Forms.Button();
            this.movieWinPrize = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.movieWinPrize)).BeginInit();
            this.SuspendLayout();
            // 
            // prizeEntered
            // 
            this.prizeEntered.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.prizeEntered.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.prizeEntered.Location = new System.Drawing.Point(57, 26);
            this.prizeEntered.Name = "prizeEntered";
            this.prizeEntered.Size = new System.Drawing.Size(389, 24);
            this.prizeEntered.TabIndex = 0;
            // 
            // prizeSearchButton
            // 
            this.prizeSearchButton.Location = new System.Drawing.Point(552, 26);
            this.prizeSearchButton.Name = "prizeSearchButton";
            this.prizeSearchButton.Size = new System.Drawing.Size(79, 24);
            this.prizeSearchButton.TabIndex = 1;
            this.prizeSearchButton.Text = "Search";
            this.prizeSearchButton.UseVisualStyleBackColor = true;
            this.prizeSearchButton.Click += new System.EventHandler(this.prizeSearchButton_Click);
            // 
            // movieWinPrize
            // 
            this.movieWinPrize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieWinPrize.Location = new System.Drawing.Point(10, 92);
            this.movieWinPrize.Name = "movieWinPrize";
            this.movieWinPrize.RowTemplate.Height = 26;
            this.movieWinPrize.Size = new System.Drawing.Size(672, 355);
            this.movieWinPrize.TabIndex = 2;
            // 
            // searchMoviePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 452);
            this.Controls.Add(this.movieWinPrize);
            this.Controls.Add(this.prizeSearchButton);
            this.Controls.Add(this.prizeEntered);
            this.Name = "searchMoviePrize";
            this.Text = "searchMoviePrize";
            this.Load += new System.EventHandler(this.searchMoviePrize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieWinPrize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prizeEntered;
        private System.Windows.Forms.Button prizeSearchButton;
        private System.Windows.Forms.DataGridView movieWinPrize;
    }
}