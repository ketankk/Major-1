namespace WindowsFormsApplication4
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
            this.button1 = new System.Windows.Forms.Button();
            this.hello = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dept = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Location = new System.Drawing.Point(454, 53);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(0, 13);
            this.hello.TabIndex = 3;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(55, 198);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(343, 140);
            this.message.TabIndex = 4;
            this.message.Text = "";
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(55, 143);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(143, 20);
            this.title.TabIndex = 5;
            this.title.Text = "Enter Message here";
            this.title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.title_MouseClick);
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 104);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(152, 53);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(175, 13);
            this.dept.TabIndex = 6;
            this.dept.Text = "Department of Applied Mathematics";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(143, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(200, 13);
            this.header.TabIndex = 7;
            this.header.Text = "DELHI TECHNOLOGICAL UNIVERSITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "© Copy Right 2014";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "To be used only for Departmental purpose";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "ALL"});
            this.comboBox1.Location = new System.Drawing.Point(277, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.title);
            this.Controls.Add(this.message);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}