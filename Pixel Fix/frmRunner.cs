namespace PixelFix
{
    public partial class frmRunner : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;

        public frmRunner()
        {
            InitializeComponent();
        }

        int state = 0;
        private void tmrRunner_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                red = 255;
                green = 0;
                blue = 0;

                state++;
            } else if (state == 1)
            {
                green = 255;
                red = 0;
                blue= 0;

                state++;
            } else if (state == 2)
            {
                blue = 255;
                green= 0;
                red = 0;

                state++;
            } else if (state == 3)
            {
                red = 255;
                green = 255;
                blue = 255;

                state++;
            } else if (state == 4)
            {
                red = 0;
                green = 0;
                blue = 0;

                state = 0;
            }
            /*if (red < 255)
            {
                red++;
            }
            else
            {
                if (green < 255)
                {
                    green++;
                } else
                {
                    if (blue < 255)
                    {
                        blue++;
                    } else
                    {
                        red = 0;
                        green = 0;
                        blue = 0;
                    }
                }
            }*/

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
