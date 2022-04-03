namespace WindowsFormsApplication1
{
    partial class searchMovieForm
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
            this.searchOptions = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchOptions
            // 
            this.searchOptions.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchOptions.DropDownHeight = 150;
            this.searchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOptions.DropDownWidth = 120;
            this.searchOptions.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOptions.ForeColor = System.Drawing.Color.Black;
            this.searchOptions.FormattingEnabled = true;
            this.searchOptions.IntegralHeight = false;
            this.searchOptions.Items.AddRange(new object[] {
            "Movie\'s Name",
            "Celebrity\'s Name",
            "Year"});
            this.searchOptions.Location = new System.Drawing.Point(12, 35);
            this.searchOptions.Name = "searchOptions";
            this.searchOptions.Size = new System.Drawing.Size(171, 28);
            this.searchOptions.TabIndex = 0;
            this.searchOptions.TabStop = false;
            this.searchOptions.SelectedIndexChanged += new System.EventHandler(this.searchOptionSelected);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search1;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(588, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(42, 43);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.TabStop = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.searchForMovie);
            // 
            // searchMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchOptions);
            this.Name = "searchMovieForm";
            this.Text = "searchMovieForm";
            this.Load += new System.EventHandler(this.searchMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}