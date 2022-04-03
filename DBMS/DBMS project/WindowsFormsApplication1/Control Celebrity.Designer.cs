namespace WindowsFormsApplication1
{
    partial class Control_Celebrity
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.celeName_txt = new System.Windows.Forms.TextBox();
            this.insert_Btn = new System.Windows.Forms.Button();
            this.celebName = new System.Windows.Forms.ComboBox();
            this.newName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameToDel = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 637);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.insert_Btn);
            this.tabPage1.Controls.Add(this.celeName_txt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Save);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.newName);
            this.tabPage2.Controls.Add(this.celebName);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "update";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteBtn);
            this.tabPage3.Controls.Add(this.nameToDel);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celebrity Name";
            // 
            // celeName_txt
            // 
            this.celeName_txt.Location = new System.Drawing.Point(383, 164);
            this.celeName_txt.Name = "celeName_txt";
            this.celeName_txt.Size = new System.Drawing.Size(196, 24);
            this.celeName_txt.TabIndex = 1;
            // 
            // insert_Btn
            // 
            this.insert_Btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_Btn.Location = new System.Drawing.Point(369, 289);
            this.insert_Btn.Name = "insert_Btn";
            this.insert_Btn.Size = new System.Drawing.Size(135, 46);
            this.insert_Btn.TabIndex = 2;
            this.insert_Btn.Text = "Insert";
            this.insert_Btn.UseVisualStyleBackColor = true;
            this.insert_Btn.Click += new System.EventHandler(this.insert_Btn_Click);
            // 
            // celebName
            // 
            this.celebName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.celebName.FormattingEnabled = true;
            this.celebName.Location = new System.Drawing.Point(348, 113);
            this.celebName.Name = "celebName";
            this.celebName.Size = new System.Drawing.Size(193, 24);
            this.celebName.TabIndex = 0;
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(404, 262);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(220, 24);
            this.newName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit Celebrity Name";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(377, 420);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(149, 43);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save change";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Celebrity Name";
            // 
            // nameToDel
            // 
            this.nameToDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameToDel.FormattingEnabled = true;
            this.nameToDel.Location = new System.Drawing.Point(370, 140);
            this.nameToDel.Name = "nameToDel";
            this.nameToDel.Size = new System.Drawing.Size(233, 24);
            this.nameToDel.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(407, 277);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(106, 44);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Control_Celebrity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "Control_Celebrity";
            this.Text = "Control_Celebrity";
            this.Load += new System.EventHandler(this.Control_Celebrity_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button insert_Btn;
        private System.Windows.Forms.TextBox celeName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.ComboBox celebName;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox nameToDel;
        private System.Windows.Forms.Label label3;
    }
}