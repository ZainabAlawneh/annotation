namespace Simple_annotation_tool
{
    partial class Detection
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
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            AddClass = new Button();
            textBox2 = new TextBox();
            BackButton = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(442, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // button3
            // 
            button3.Location = new Point(442, 435);
            button3.Name = "button3";
            button3.Size = new Size(131, 31);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Clear;
            // 
            // button4
            // 
            button4.Location = new Point(709, 435);
            button4.Name = "button4";
            button4.Size = new Size(123, 31);
            button4.TabIndex = 4;
            button4.Text = "Save and Next";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Save_and_Next;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "D:\\slides\\";
            // 
            // button5
            // 
            button5.Location = new Point(333, 88);
            button5.Name = "button5";
            button5.Size = new Size(87, 24);
            button5.TabIndex = 6;
            button5.Text = "Browse";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Browse;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "1. Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 172);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 19;
            label2.Text = "2. Class Name";
            // 
            // AddClass
            // 
            AddClass.Location = new Point(333, 167);
            AddClass.Name = "AddClass";
            AddClass.Size = new Size(87, 24);
            AddClass.TabIndex = 18;
            AddClass.Text = "Add Class";
            AddClass.UseVisualStyleBackColor = true;
            AddClass.Click += AddClass_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 17;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(78, 25);
            BackButton.TabIndex = 20;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 3);
            label3.Name = "label3";
            label3.Size = new Size(292, 15);
            label3.TabIndex = 21;
            label3.Text = "Draw the rectangle from top left towards bottom right";
            // 
            // Detection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 550);
            Controls.Add(label3);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(AddClass);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Name = "Detection";
            Text = "Detection";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Label label1;
        private Label label2;
        private Button AddClass;
        private TextBox textBox2;
        private Button BackButton;
        private Label label3;
    }
}