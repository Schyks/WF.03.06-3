namespace TimeRemained
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = dateTimePicker2.Value;
            TimeSpan difference = date2 - date1;
            int seconds = (int)difference.TotalSeconds;
            label4.Text = "" + seconds;
        }
    }
}