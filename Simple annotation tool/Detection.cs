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

/*  SECOND COMMETMENT NOTES:
* Made the buttons adaptive (the user can create infinite buttons)
* added a color generator to create different rectangle colors for each class
* added a back button to the pages/ made the height, width,...etc. more flexible for each picture size
* allowed only the rectangles to be drawn from top left to bottom right (to stop the creation of invisible rectangles)
*/


namespace Simple_annotation_tool
{
    public partial class Detection : Form
    {
        public Detection()
        {
            InitializeComponent();
        }


        static class Globals
        {
            public static int x1;
            public static int y1;
            public static int x2;
            public static int y2;
            public static int tempx2, tempy2;

            public static float X_relative_ratio, Y_relative_ratio;

            public static float Center_X;
            public static float Center_Y;
            public static float Width;
            public static float Height;


            public static string Index;
            public static int Number_Of_Columns = 5;

            public static bool click;
            public static string col;
            public static Pen myPen;
            public static float Boarder_Thickness = 3;
            public static string color;

            public static int i;
            public static string[] Pictures_Paths;
            public static string path;
            public static string File_Name;
            public static string One_Picture_Only;
            public static bool Browsed = false;
            public static bool Class_selected = false;

            public static bool Pictures_Are_Imported = false;
        }

        List<int> classtype = new List<int>();
        List<Rectangle> Finished_Rectangles = new List<Rectangle>();
        List<string> Rectangle_Info = new List<string>();               //the output text file is saved in this list

        Rectangle rect = new Rectangle();

        Color[] Array_Of_Colors = GetUniqueRandomColor(1000);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (Globals.click == true && Globals.Width > 0 && Globals.Height > 0)
            {
                e.Graphics.DrawRectangle(Globals.myPen, rect);
                Finished_Rectangles.Add(rect);
                classtype.Add(j); //adds the color of the rectangle in a list to be called back on, when the same class is called again


                Globals.Width *= Globals.X_relative_ratio;
                Globals.Height *= Globals.Y_relative_ratio;
                Globals.Center_X *= Globals.X_relative_ratio;
                Globals.Center_Y *= Globals.Y_relative_ratio;

                Rectangle_Info.Add(Globals.Index + ",(" + Globals.Center_X + "," + Globals.Center_Y + ")," + Globals.Width + "," + Globals.Height); //the output in the text file


                int Rectangles_Count = 0;
                while (Rectangles_Count < Finished_Rectangles.Count)
                {
                    Globals.myPen = new Pen(Array_Of_Colors[classtype[Rectangles_Count]], Globals.Boarder_Thickness);
                    e.Graphics.DrawRectangle(Globals.myPen, Finished_Rectangles[Rectangles_Count]);
                    Rectangles_Count++;
                }

                Globals.click = false;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Globals.x1 = e.X;
            Globals.y1 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Globals.x2 = e.X;
            Globals.y2 = e.Y;

            rect.X = Globals.x1;
            rect.Y = Globals.y1;
            rect.Width = Globals.x2 - Globals.x1;
            rect.Height = Globals.y2 - Globals.y1;

            Globals.Width = (Globals.x2 - Globals.x1);
            Globals.Height = (Globals.y2 - Globals.y1);
            Globals.Center_X = (Globals.x1 + (Globals.Width / 2));
            Globals.Center_Y = (Globals.y1 + (Globals.Height / 2));

            if (Globals.click == true && Globals.Width > 0 && Globals.Height > 0)
                Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Globals.tempx2 = e.X;
            Globals.tempy2 = e.Y;
        }



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Globals.click = true;
        }



        int counter = 0; // count of new buttons 
        int col = 0;
        int row = 0;
        int buttons_count = 0;
        int j;

        private void AddClass_Click(object sender, EventArgs e) // adding classes
        {
            if (textBox2.Text.Length > 0 && Globals.Pictures_Are_Imported == true)
            {
                //Create new button
                Button button = new Button();
                button.Name = "Button" + counter;
                button.Text = textBox2.Text;
                textBox2.Clear();


                button.Location = new Point(50 + col * 62, 200 + row * 62);
                button.Size = new Size(60, 60);

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
                buttons_count++;


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

            for (j = 0; j < counter; j++)
            {
                if (btn.Name == ("Button" + j))
                {
                    // When the loop finds the specific button. Then do the following:
                    Globals.myPen = new Pen(Array_Of_Colors[j], Globals.Boarder_Thickness);
                    Globals.Index = btn.Text;
                    Globals.Class_selected = true;
                    if (Globals.Browsed == true && Globals.Class_selected == true) // REDUNTANT
                    {
                        pictureBox1.Enabled = true;
                    }

                    //Then exit from loop by break (because you found the needed button).
                    break;
                }
            }
        }
        public static Color[] GetUniqueRandomColor(int count) // Making new colors for the regtagles (max of 1000 / can be increased in code line 72 [could change])
        {
            Color[] colors = new Color[count];
            HashSet<Color> hs = new HashSet<Color>();

            Random randomColor = new Random();

            for (int i = 0; i < count; i++)
            {
                Color color;
                while (!hs.Add(color = Color.FromArgb(randomColor.Next(70, 200), randomColor.Next(100, 225), randomColor.Next(100, 230)))) ;
                colors[i] = color;
            }

            return colors;
        }




        private void Save_and_Next(object sender, EventArgs e)  //save button 
        {
            Globals.File_Name = Path.GetFileName(Globals.Pictures_Paths[Globals.i]);
            StreamWriter sw = new StreamWriter("D:\\Test\\" + Globals.File_Name + ".txt");

            int x = 0;
            while (x < Finished_Rectangles.Count)
            {
                sw.WriteLine(Rectangle_Info[x]);
                x++;
            }

            sw.Close();

            Globals.i++;
            if (Globals.i < Globals.Pictures_Paths.Length)
            {
                pictureBox1.Image = Image.FromFile(Globals.Pictures_Paths[Globals.i]);
                Globals.Y_relative_ratio = Image.FromFile(Globals.Pictures_Paths[Globals.i]).Width / Convert.ToSingle(pictureBox1.Width);
                Globals.X_relative_ratio = Image.FromFile(Globals.Pictures_Paths[Globals.i]).Height / Convert.ToSingle(pictureBox1.Height);
            }
            else
            {
                MessageBox.Show("This was The last Picture");
                Globals.i = 0;
                pictureBox1.Image = Image.FromFile(Globals.Pictures_Paths[Globals.i]);
            }

            Finished_Rectangles.Clear();
            Rectangle_Info.Clear();
            Refresh();
        }

        private void Clear(object sender, EventArgs e)  //clear
        {
            Finished_Rectangles.Clear();
            Rectangle_Info.Clear();
            Refresh();
        }

        private void Browse(object sender, EventArgs e)
        {

            Finished_Rectangles.Clear();
            Rectangle_Info.Clear();
            Refresh();


            if (textBox1.Text.Length > 0)
            {

                string path = textBox1.Text;

                int i = 0;
                Globals.Pictures_Paths = Directory.GetFiles(path, "*.jpg");
                if (Globals.Pictures_Paths.Length > 0)
                {
                    Globals.One_Picture_Only = Globals.Pictures_Paths[Globals.i];
                    pictureBox1.Image = Image.FromFile(Globals.One_Picture_Only);
                    Globals.Pictures_Are_Imported = true;

                    Globals.Y_relative_ratio = Image.FromFile(Globals.Pictures_Paths[Globals.i]).Width / 390f;
                    Globals.X_relative_ratio = Image.FromFile(Globals.Pictures_Paths[Globals.i]).Height / 390f;

                    Globals.Browsed = true;
                    if (Globals.Browsed == true && Globals.Class_selected == true)
                    {
                        pictureBox1.Enabled = true;
                    }

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MainPage = new Form1();
            MainPage.ShowDialog();
            this.Close();
        }
    }
}
