namespace WinFormsApp1
{
    // This is a simple Windows Forms application that demonstrates a button click event.
    // why we start New thread in the button click event?
    // to  prevent the UI from freezing or becoming unresponsive during long-running operations, we can start a new thread to handle the operation. This allows the UI to remain responsive and allows the user to interact with it while the operation is being performed in the background.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMesssage.Text = "Button 1 clicked!";
            Thread.Sleep(3000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMesssage.Text = "Button 2 clicked!";
            Thread.Sleep(3000);
        }
    }
}
