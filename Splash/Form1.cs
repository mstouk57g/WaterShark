namespace Splash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent; // Color.Red\Color.BlueµÈ
            this.TopMost = true;
            this.TransparencyKey = this.BackColor;
        }
    }
}
