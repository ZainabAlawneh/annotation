namespace Simple_annotation_tool
{
    partial class Classification
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            AddClass = new Button();
            label1 = new Label();
            label2 = new Label();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(371, 143);
            button1.Name = "button1";
            button1.Size = new Size(70, 26);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(467, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "C:\\Users\\Omar Shidaifat\\Downloads\\random\\random";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 8;
            // 
            // AddClass
            // 
            AddClass.Location = new Point(352, 349);
            AddClass.Name = "AddClass";
            AddClass.Size = new Size(63, 24);
            AddClass.TabIndex = 9;
            AddClass.Text = "add class";
            AddClass.UseVisualStyleBackColor = true;
            AddClass.Click += AddClass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 149);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 15;
            label1.Text = "1. Folder Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 351);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 16;
            label2.Text = "2. Class Name";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(10, 10);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(77, 26);
            BackButton.TabIndex = 17;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Classification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 572);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddClass);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Classification";
            Text = "Classification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddClass;
        private Label label1;
        private Label label2;
        private Button BackButton;
    }
}