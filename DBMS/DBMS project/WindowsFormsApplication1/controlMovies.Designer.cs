namespace WindowsFormsApplication1
{
    partial class controlMovies
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.insertTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.prizeType = new System.Windows.Forms.ComboBox();
            this.prize_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prizeName = new System.Windows.Forms.Label();
            this.editTab = new System.Windows.Forms.TabPage();
            this.newType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prizeData = new System.Windows.Forms.ComboBox();
            this.saveNewData = new System.Windows.Forms.Button();
            this.deleteTab = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.prize_data = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.insertTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.deleteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.insertTab);
            this.tabControl1.Controls.Add(this.editTab);
            this.tabControl1.Controls.Add(this.deleteTab);
            this.tabControl1.Location = new System.Drawing.Point(-5, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 543);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // insertTab
            // 
            this.insertTab.BackColor = System.Drawing.Color.Gray;
            this.insertTab.Controls.Add(this.button1);
            this.insertTab.Controls.Add(this.prizeType);
            this.insertTab.Controls.Add(this.prize_name_txt);
            this.insertTab.Controls.Add(this.label2);
            this.insertTab.Controls.Add(this.prizeName);
            this.insertTab.Location = new System.Drawing.Point(4, 25);
            this.insertTab.Name = "insertTab";
            this.insertTab.Padding = new System.Windows.Forms.Padding(3);
            this.insertTab.Size = new System.Drawing.Size(872, 514);
            this.insertTab.TabIndex = 0;
            this.insertTab.Text = "insert";
            this.insertTab.Click += new System.EventHandler(this.insertTab_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prizeType
            // 
            this.prizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prizeType.FormattingEnabled = true;
            this.prizeType.Location = new System.Drawing.Point(340, 201);
            this.prizeType.Name = "prizeType";
            this.prizeType.Size = new System.Drawing.Size(164, 24);
            this.prizeType.TabIndex = 3;
            // 
            // prize_name_txt
            // 
            this.prize_name_txt.Location = new System.Drawing.Point(340, 159);
            this.prize_name_txt.Name = "prize_name_txt";
            this.prize_name_txt.Size = new System.Drawing.Size(164, 24);
            this.prize_name_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // prizeName
            // 
            this.prizeName.AutoSize = true;
            this.prizeName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeName.Location = new System.Drawing.Point(233, 154);
            this.prizeName.Name = "prizeName";
            this.prizeName.Size = new System.Drawing.Size(75, 29);
            this.prizeName.TabIndex = 0;
            this.prizeName.Text = "Name";
            // 
            // editTab
            // 
            this.editTab.BackColor = System.Drawing.Color.DimGray;
            this.editTab.Controls.Add(this.newType);
            this.editTab.Controls.Add(this.label4);
            this.editTab.Controls.Add(this.label3);
            this.editTab.Controls.Add(this.newName);
            this.editTab.Controls.Add(this.label1);
            this.editTab.Controls.Add(this.prizeData);
            this.editTab.Controls.Add(this.saveNewData);
            this.editTab.Location = new System.Drawing.Point(4, 25);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(872, 514);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "edit";
            this.editTab.Click += new System.EventHandler(this.editTab_Click);
            // 
            // newType
            // 
            this.newType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newType.FormattingEnabled = true;
            this.newType.Items.AddRange(new object[] {
            "collective",
            "individual"});
            this.newType.Location = new System.Drawing.Point(267, 231);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(167, 24);
            this.newType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prize Name";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(267, 157);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(167, 24);
            this.newName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prizes";
            // 
            // prizeData
            // 
            this.prizeData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prizeData.FormattingEnabled = true;
            this.prizeData.Location = new System.Drawing.Point(323, 71);
            this.prizeData.Name = "prizeData";
            this.prizeData.Size = new System.Drawing.Size(192, 24);
            this.prizeData.TabIndex = 2;
            this.prizeData.SelectedIndexChanged += new System.EventHandler(this.prizeData_SelectedIndexChanged);
            // 
            // saveNewData
            // 
            this.saveNewData.Location = new System.Drawing.Point(358, 326);
            this.saveNewData.Name = "saveNewData";
            this.saveNewData.Size = new System.Drawing.Size(136, 33);
            this.saveNewData.TabIndex = 1;
            this.saveNewData.Text = "save changes";
            this.saveNewData.UseVisualStyleBackColor = true;
            this.saveNewData.Click += new System.EventHandler(this.saveNewData_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.BackColor = System.Drawing.Color.DimGray;
            this.deleteTab.Controls.Add(this.deleteBtn);
            this.deleteTab.Controls.Add(this.prize_data);
            this.deleteTab.Controls.Add(this.label5);
            this.deleteTab.Location = new System.Drawing.Point(4, 25);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTab.Size = new System.Drawing.Size(872, 514);
            this.deleteTab.TabIndex = 2;
            this.deleteTab.Text = "Delete";
            this.deleteTab.Click += new System.EventHandler(this.deleteTab_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(355, 226);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(126, 41);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // prize_data
            // 
            this.prize_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prize_data.FormattingEnabled = true;
            this.prize_data.Location = new System.Drawing.Point(343, 105);
            this.prize_data.Name = "prize_data";
            this.prize_data.Size = new System.Drawing.Size(211, 24);
            this.prize_data.TabIndex = 1;
            this.prize_data.SelectedIndexChanged += new System.EventHandler(this.prize_data_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prizes name";
            // 
            // controlMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "controlMovies";
            this.Text = "controlMovies";
            this.Load += new System.EventHandler(this.controlMovies_Load);
            this.tabControl1.ResumeLayout(false);
            this.insertTab.ResumeLayout(false);
            this.insertTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.deleteTab.ResumeLayout(false);
            this.deleteTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage insertTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.TabPage deleteTab;
        private System.Windows.Forms.ComboBox prizeType;
        private System.Windows.Forms.TextBox prize_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prizeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveNewData;
        private System.Windows.Forms.ComboBox newType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prizeData;
        private System.Windows.Forms.ComboBox prize_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;

    }
}