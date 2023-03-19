using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Simple_annotation_tool
{
    public partial class Classification : Form
    {
        public Classification()
        {
            InitializeComponent();
        }

        static class Globals
        {
            public static int i;
            public static string[] Pictures_Paths;
            public static string path;
            public static string One_Picture_Only;
            public static string Distination_Folder;
            public static string Distination_File;
            public static string File_Name;
            public static bool Pictures_Are_Imported = false;
            public static int Number_Of_Columns = 3;
        }

        private int counter = 0;

        private void button1_Click(object sender, EventArgs e) // if upload button is pressed
        {



            if (textBox1.Text.Length > 0)
            {
                string path = "C:\\Users\\Omar Shidaifat\\Downloads\\random\\random\\";

                int i = 0;
                Globals.Pictures_Paths = Directory.GetFiles(path, "*.jpg");
                if (Globals.Pictures_Paths.Length > 0)
                {
                    Globals.One_Picture_Only = Globals.Pictures_Paths[Globals.i];
                    pictureBox1.Image = Image.FromFile(Globals.One_Picture_Only);
                    Globals.i++;
                    Globals.Pictures_Are_Imported = true;
                }
                else
                {
                    MessageBox.Show("This Path Doesn't Contain Pictures");
                }
            }
            else
            {
                MessageBox.Show("Please Select A Path");
            }



        }

        int col = 0;
        int row = 0;
        private void AddClass_Click(object sender, EventArgs e) // adding classes
        {
            if (textBox2.Text.Length > 0 && Globals.Pictures_Are_Imported == true)
            {

                Button button = new Button();
                button.Name = "Button" + counter;
                // Addabt the class name and clear the textbox
                button.Text = textBox2.Text;
                textBox2.Clear();


                button.Location = new Point(450 + col * 152, 350 + row * 26);
                button.Size = new Size(150, 25);

                if (col >= Globals.Number_Of_Columns - 1)
                {
                    col = 0;
                    row++;
                }
                else
                    col++;

                // Increase counter for adding new button later.
                counter++;

                // add click event to the button.
                button.Click += new EventHandler(NewButton_Click);
                this.Controls.Add(button);


            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please Enter A Class Name");
            }

            else if (Globals.Pictures_Are_Imported != true)
            {
                MessageBox.Show("Please Import Pictures First");
            }
        }


        private void NewButton_Click(object sender, EventArgs e)  // The event for a new class
        {
            Button btn = (Button)sender;

            for (int j = 0; j < counter; j++)
            {
                if (btn.Name == ("Button" + j))
                {
                    // When the loop finds the specific button. Then do the following:
                    if (Globals.i < Globals.Pictures_Paths.Length)
                    {
                        Globals.File_Name = Path.GetFileName(Globals.Pictures_Paths[Globals.i]);
                        Globals.Distination_Folder = "D:\\Test\\" + btn.Text;
                        Globals.Distination_File = "D:\\Test\\" + btn.Text + "\\" + Globals.File_Name + ".jpg";

                        if (!Directory.Exists(Globals.Distination_Folder))      //make the distination folder
                        {
                            Directory.CreateDirectory(Globals.Distination_Folder);
                        }


                        File.Copy(Globals.One_Picture_Only, Globals.Distination_File, true);
                        Globals.i++;
                        Globals.One_Picture_Only = Globals.Pictures_Paths[Globals.i];
                        pictureBox1.Image = Image.FromFile(Globals.One_Picture_Only);  //change picture


                    }

                    else
                    {
                        MessageBox.Show("All Pictures Are Classified");
                        Globals.i = 0;
                    }
                    //Then exit from loop by break (because you found the needed button).
                    break;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MainPage = new Form1();
            MainPage.ShowDialog();
            this.Close();
        }
    }
}
