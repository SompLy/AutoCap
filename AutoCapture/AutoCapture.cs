using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AutoCapture
{
    public partial class AutoCapture : Form
    {
        int totalSeconds = 0;
        int totalMinutes = 0;
        int totalHours   = 0;

        int nextCaptureSeconds = 0;
        int nextCaptureMinutes = 0;
        int nextCaptureHours   = 0;

        public AutoCapture()
        {
            InitializeComponent();

            lbl_Path.Text = Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
        }

        private void btn_Start_Click( object sender, EventArgs e )
        {
            nextCaptureSeconds = dtp_Minutes.Value.Second;
            nextCaptureMinutes = dtp_Minutes.Value.Minute;
            nextCaptureHours = dtp_Minutes.Value.Hour;

            timer_Total.Start();
            timer_NextCapture.Start();
        }

        private void btn_Stop_Click( object sender, EventArgs e )
        {
            timer_Total.Stop();
            timer_NextCapture.Stop();
        }

        private void btn_SetPath_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
            //dialog.title = "Choose your favorite place to store all your epic screenshots :)";

            DialogResult result = dialog.ShowDialog();
            if ( result == DialogResult.OK )
            {
                lbl_Path.Text = dialog.SelectedPath.ToString();
            }
        }

        private void timer_Total_Tick( object sender, EventArgs e )
        {
            totalSeconds += 1;

            if ( totalSeconds >= 60 )
            {
                totalSeconds = 0;
                totalMinutes += 1;
            }
            if ( totalMinutes >= 60 )
            {
                totalMinutes = 0;
                totalHours += 1;
            }

            lbl_TimeAlive.Text = "Time Alive : " + totalHours + ":" + totalMinutes + ":" + totalSeconds;
        }
        private void timer_NextCapture_Tick( object sender, EventArgs e )
        {
            if ( nextCaptureHours <= 0 && nextCaptureMinutes <= 0 && nextCaptureSeconds <= 0 )
            {
                Capture();

                nextCaptureSeconds = dtp_Minutes.Value.Second;
                nextCaptureMinutes = dtp_Minutes.Value.Minute;
                nextCaptureHours = dtp_Minutes.Value.Hour;
            }


            if ( nextCaptureSeconds <= 0 && nextCaptureMinutes > 0 )
            {
                nextCaptureSeconds = 59;
                nextCaptureMinutes -= 1;
            }
            if ( nextCaptureMinutes <= 0 && nextCaptureHours > 0 )
            {
                nextCaptureMinutes = 59;
                nextCaptureHours -= 1;
            }

            nextCaptureSeconds -= 1;

            lbl_NextCapture.Text = "Next Capture In : " + nextCaptureHours + ":" + nextCaptureMinutes + ":" + nextCaptureSeconds;
        }
        private void Capture()
        {

            Bitmap captureBitmap = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            captureGraphics.CopyFromScreen( captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size );

            captureBitmap.Save( lbl_Path.Text + "/" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day
                + " " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".png", ImageFormat.Png );
        }

    }
}