namespace WindowsFormsApplication1
{
    partial class CelebrityPrizes
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
            this.prizeNames = new System.Windows.Forms.ComboBox();
            this.celebPrizeData = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.celebPrizeData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prizes Name";
            // 
            // prizeNames
            // 
            this.prizeNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prizeNames.FormattingEnabled = true;
            this.prizeNames.Location = new System.Drawing.Point(323, 86);
            this.prizeNames.Name = "prizeNames";
            this.prizeNames.Size = new System.Drawing.Size(233, 24);
            this.prizeNames.TabIndex = 1;
            // 
            // celebPrizeData
            // 
            this.celebPrizeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.celebPrizeData.Location = new System.Drawing.Point(4, 156);
            this.celebPrizeData.Name = "celebPrizeData";
            this.celebPrizeData.RowTemplate.Height = 26;
            this.celebPrizeData.Size = new System.Drawing.Size(893, 503);
            this.celebPrizeData.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(631, 76);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(93, 39);
            this.Search.TabIndex = 3;
            this.Search.Text = "search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CelebrityPrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 664);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.celebPrizeData);
            this.Controls.Add(this.prizeNames);
            this.Controls.Add(this.label1);
            this.Name = "CelebrityPrizes";
            this.Text = "CelebrityPrizes";
            this.Load += new System.EventHandler(this.CelebrityPrizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.celebPrizeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prizeNames;
        private System.Windows.Forms.DataGridView celebPrizeData;
        private System.Windows.Forms.Button Search;
    }
}