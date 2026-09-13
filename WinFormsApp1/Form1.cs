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
           var task =new  Thread(() => showMessage("Button 1 clicked!", 3000));
           task.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var task = Task.Run(() => showMessage("Button 2 clicked!", 3000));
        }
        private void showMessage(string message,int delay)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => showMessage(message, delay)));
                return;
            }
            else
            {
                Thread.Sleep(delay);
                lblMesssage.Text = message;
            }
        }
    }
}
