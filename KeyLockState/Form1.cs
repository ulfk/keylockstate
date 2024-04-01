namespace KeyLockState
{
    public partial class Form1 : Form
    {
        public string KeyPressed { get; set; }
        private bool numLock = false;
        private bool prevNumLock = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numLock = IsKeyLocked(Keys.NumLock);
            if (numLock != prevNumLock)
            {
                prevNumLock = numLock;
                this.notifyIcon1.Icon = numLock ? Resource1.NumOn : Resource1.NumOff;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonHideForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}