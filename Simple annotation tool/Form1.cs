using System.Diagnostics.Metrics;

namespace Simple_annotation_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classification classification = new Classification();
            classification.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detection detection = new Detection();
            detection.ShowDialog();
            this.Close();

        }

    }
}
