using System;
using System.IO;
using System.Timers;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace Roger_That
{
 public partial class Customer_Analyzer : Form
    {

        private Capture cap;
        Image<Bgr, byte> template;
        private HaarCascade gender, frontal_face, neutral_mood, happy_mood, botheyes, lefteye, mouth, nose, righteye;
        Bitmap img;
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        Image<Bgr, byte> Img;
        Image<Bgr, byte> t_Image;
        int count = 1, count1 = 0;
        bool isRunning = true;
        int lastfps;
        Bitmap Image;
        bool gender_find = false, find_mood = false, male = false, female = false;
        bool isStopped = false, CheckingFromImage = false, feature = false;
        Stopwatch watch, watch2;
        int male_count = 0, female_count = 0, happy_count = 0, neutral_count = 0;
        //Graphics myGraphics;
        Rectangle rect;
        bool isdown = false;
        int i = 0, i_for_text = 0;
        Bitmap temp;
        bool check_from_folder= true;
        bool check_catch = false;
        bool template_matched = false;
        List<Bitmap> bit;
        public Customer_Analyzer()
        {
            InitializeComponent();
            watch = new Stopwatch();
            watch2 = new Stopwatch();
            bit = new List<Bitmap>();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Roger\Documents\GitHub\Customer-Analyzer\Roger That\bin\Debug\Templates");
            FileInfo[] Images = di.GetFiles("*.jpg");
            foreach (FileInfo info in Images)
            {
                info.Delete();
            }
            System.IO.File.WriteAllText(@"test.txt", string.Empty);
        }
        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                CamList_Box.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    CamList_Box.Items.Add(device.Name);
                }
                CamList_Box.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                CamList_Box.Items.Add("No capture device on your system");
            }
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            img = (Bitmap)eventArgs.Frame.Clone();
            try
            {
                Picture_Box.Image = img;
            }
            catch { };

        }
        private void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }

        bool femalefound = false;
      //  bool male = true;
        bool malefound = false;
        bool human_face = true;
        bool human_true = false;
        int malecount = 0;
        bool found = false;
        int x = 0;
        TemplateMatch[] matchings;
        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideoSource();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Roger\Documents\GitHub\Customer-Analyzer\Roger That\bin\Debug\Templates");
            FileInfo[] Images = di.GetFiles("*.jpg");
            foreach (FileInfo info in Images)
            {
                info.Delete();
            }
            gender = new HaarCascade("Latest.xml");
            frontal_face = new HaarCascade("haarcascade_frontalface_default.xml");
            neutral_mood = new HaarCascade("neutral.xml");
            happy_mood = new HaarCascade("happy.xml");
            botheyes = new HaarCascade("botheye.xml");
            lefteye = new HaarCascade("lefteye.xml");
            mouth = new HaarCascade("mouth.xml");
            nose = new HaarCascade("nose.xml");
            righteye = new HaarCascade("righteye.xml");
            if (Image_Radio_Button.Checked)//&& isStopped) 
            {
                Timer_Loop.Enabled = false;
                CloseVideoSource();
                isStopped = true;
                Open_Img.Enabled = true;
                Webcam_Panel.Enabled = false;
            }
            else if (!Image_Radio_Button.Checked)
            {
                isStopped = false;
                Open_Img.Enabled = false;
                Webcam_Panel.Enabled = true;
                CheckingFromImage = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isStopped && !CheckingFromImage)
            {
                try { x = x + videoSource.FramesReceived; }

                catch { };
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lastfps = x;
            x = 0;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Image_Radio_Button.Checked)//&& isStopped)
            {
                Timer_Loop.Enabled = false;
                CloseVideoSource();
                isStopped = true;
                Open_Img.Enabled = true;
                Webcam_Panel.Enabled = false;
            }
            else if (!Image_Radio_Button.Checked)
            {
                isStopped = false;
                Open_Img.Enabled = false;
                Webcam_Panel.Enabled = true;
                CheckingFromImage = false;
            }
        }
        private void Refresh(object sender, EventArgs e)
        {
            getCamList();
        }

        private void Open_Image(object sender, EventArgs e)
        {
            CheckingFromImage = true;
            OpenFileDialog dailog = new OpenFileDialog();
            dailog.ShowDialog();
            Image = new Bitmap(dailog.FileName);
            Picture_Box.Image = Image;
            Timer_Loop.Enabled = true;
        }

        private void Start_Streaming(object sender, EventArgs e)
        {

            if (Default_Camera.Checked)
            {
                getCamList();
            }
            timer_Loop_2.Enabled = true;
            timer_Loop_3.Enabled = true;
            if (isRunning)
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[CamList_Box.SelectedIndex].MonikerString); // 
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    CloseVideoSource();
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    //videoSource.DesiredFrameRate = 10;
                    videoSource.Start();
                    Frams.Text = "Device Running";
                    //  start.Text = "Stop";
                    Timer_Loop.Enabled = true;
                }
                else
                {
                    Frams.Text = "Error: No Device selected.";
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    Timer_Loop.Enabled = false;
                    CloseVideoSource();
                    Frams.Text = "Device stopped.";
                }
            }
        }

        private void Stop_Streaming(object sender, EventArgs e)
        {
            // isRunning = false;
            Timer_Loop.Enabled = false;
            CloseVideoSource();
            isStopped = true;
        }

        private void Extract_Feature(object sender, EventArgs e)
        {
            
                Mood_TextBox.Text = " ";
                Gender_TextBox.Text = " ";
            
        }
        private void chart_button_Click(object sender, EventArgs e)
        {
            this.chart.Series["Customer"].Points.AddXY("Male", male_count);
            this.chart.Series["Customer"].Points.AddXY("Female", female_count);
            this.chart.Series["Customer"].Points.AddXY("Happy", happy_count);
            this.chart.Series["Customer"].Points.AddXY("Neutral", neutral_count);
        }

        private void results_Click(object sender, EventArgs e)
        {
            isStopped = false;
            Frams.Text = lastfps.ToString("00");
         //   count = 0;
            human_face = true;
            template_matched = false;
            male = false;
            female = false;
          //  i_for_text = 0;
          //  count = 0;
          //  count1 = 0;
            try
            {
                //Img = new Image<Bgr, byte>("C:\\Users\\BlakeBoyGames\\Desktop\\Roger That\\Afemale20.bmp");
                if (CheckingFromImage)
                    Img = new Image<Bgr, byte>(Image);
                else
                    Img = new Image<Bgr, byte>(img);
            }
            catch
            { };
            using (Image<Bgr, byte> nextFrame = Img)
            {
                if (nextFrame != null)
                {
                    if (!watch.IsRunning)
                        watch.Start();

                    if (!watch2.IsRunning)
                        watch2.Start();

                    if (watch2.Elapsed.Seconds == 2)
                    {
                        Mood_TextBox.Text = " ";
                        Gender_TextBox.Text = " ";
                        watch2.Reset();
                    }


                    if (human_face)
                    {
                        //  Bitmap bmp;
                        Image<Gray, byte> grayframe_frontal_face = nextFrame.Convert<Gray, byte>();
                        //   bmp = new Bitmap(nextFrame.Bitmap);
                        var frontal_facefaces =
                                 grayframe_frontal_face.DetectHaarCascade(
                                         frontal_face, 1.4, 4,
                                         HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                         new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                         )[0];
                        femalefound = false;
                        template_matched = false;
                        foreach (var face in frontal_facefaces)
                        {
                            // nextFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 6);

                            // human_face = false;
                            human_true = true;
                            //  femalefound = true;
                            //  Gender_TextBox.Text = "Human";

                        }
                        if (human_true)
                        {
                            bit.RemoveRange(0, bit.Count);
                            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Roger\Documents\GitHub\Customer-Analyzer\Roger That\bin\Debug\Templates");
                            FileInfo[] Images = di.GetFiles("*.jpg");
                            foreach(FileInfo info in Images)
                            {
                                bit.Add(new Bitmap(info.FullName));
                            }
                            data_set_count.Text = bit.Count.ToString();
                            foreach(Bitmap b in bit)
                            {
                                Image<Bgr, byte> source = new Image<Bgr, byte>(nextFrame.Bitmap);
                                template = new Image<Bgr, byte>(new Bitmap(b));
                                Image<Bgr, byte> imageToShow = source.Copy();
                                try
                                {
                                    using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCOEFF_NORMED))
                                    {
                                        double[] minValues, maxValues;
                                        Point[] minLocations, maxLocations;
                                        result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                                        if (maxValues[0] > 0.8)
                                        {
                                            Rectangle match = new Rectangle(maxLocations[0], template.Size);
                                            imageToShow.Draw(match, new Bgr(Color.Red), 3);
                                            template_matched = true;
                                            Picture_Box.Image = imageToShow.Bitmap;
                                            break;
                                        }
                                        if (template_matched)
                                        {
                                            Eyes.Text = template_matched.ToString();
                                        }
                                    }
                                }
                                catch { };
                            }
                            if(!template_matched)
                            {
                                Image<Gray, byte> grayframe_gender = nextFrame.Convert<Gray, byte>();
                                var genderface =
                                        grayframe_gender.DetectHaarCascade(
                                                gender, 1.4, 4,
                                                HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                                )[0];
                                found = false;
                                Bitmap bmp = new Bitmap(nextFrame.Bitmap);
                                foreach (var face in genderface)
                                {
                                    Gender_TextBox.Text = "Male";
                                    nextFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 6);
                                    bmp = bmp.Clone(face.rect, bmp.PixelFormat);
                                    male = true;
                                    female = false;
                                    male_count++;
                                }
                                if (male)
                                {
                                    Bitmap qwerty = new Bitmap(bmp);
                                   
                                    bmp.Dispose();
                                    bmp = null;
                                    qwerty.Save("Templates\\" + count1.ToString() + ".jpg");
                                    using (StreamWriter objWriter = new StreamWriter("TestFile1.txt"))
                                    {
                                        File.AppendAllText("test.txt", i_for_text.ToString() + " : " + Gender_TextBox.Text + "\r\n");
                                    }
                                    i_for_text++;
                                    count1++;
                                   
                                    Image<Gray, byte> grayframe_happy_mood = nextFrame.Convert<Gray, byte>();
                                    var happy_moodfaces =
                                            grayframe_happy_mood.DetectHaarCascade(
                                                    happy_mood, 1.4, 4,
                                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                    new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                                    )[0];

                                    foreach (var face in happy_moodfaces)
                                    {
                                        Mood_TextBox.Text = "Happy";
                                        happy_count++;
                                    }
                                    Image<Gray, byte> grayframe_neutral_mood = nextFrame.Convert<Gray, byte>();
                                    var neutral_moodfaces =
                                            grayframe_neutral_mood.DetectHaarCascade(
                                                    neutral_mood, 1.4, 4,
                                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                    new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                                    )[0];

                                    foreach (var face in neutral_moodfaces)
                                    {
                                        Mood_TextBox.Text = "Neutral";
                                        neutral_count++;
                                    }
                                    
                                }
                                else if(!male)
                                {
                                    Image<Gray, byte> grayframe_frontal_face2 = nextFrame.Convert<Gray, byte>();
                                    var frontal_facefaces2 =
                                            grayframe_frontal_face2.DetectHaarCascade(
                                                    frontal_face, 1.4, 4,
                                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                    new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                                    )[0];
                                    Bitmap bmp2 = new Bitmap(nextFrame.Bitmap);
                                    Bitmap sara = new Bitmap(bmp2);
                                    foreach (var face in frontal_facefaces2)
                                    {
                                        nextFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 6);
                                        Gender_TextBox.Text = "Female";
                                        female = true;
                                        male = false;
                                        sara = bmp2.Clone(face.rect, bmp2.PixelFormat);
                                        female_count++;
                                    }
                                    if(female)
                                    {
                                        Bitmap qwerty = new Bitmap(sara);
                                        bmp2.Dispose();
                                        bmp2 = null;
                                        sara.Dispose();
                                        sara = null;
                                        qwerty.Save("Templates\\" + count1.ToString() + ".jpg");
                                        count1++;
                                        using (StreamWriter objWriter = new StreamWriter("TestFile1.txt"))
                                        {
                                            File.AppendAllText("test.txt", i_for_text.ToString() + " : " + Gender_TextBox.Text + "\r\n");
                                            i_for_text++;
                                        }
                                        
                                        Image<Gray, byte> grayframe_happy_mood = nextFrame.Convert<Gray, byte>();
                                        var happy_moodfaces =
                                                grayframe_happy_mood.DetectHaarCascade(
                                                        happy_mood, 1.4, 4,
                                                        HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                        new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                                        )[0];

                                        foreach (var face in happy_moodfaces)
                                        {
                                            Mood_TextBox.Text = "Happy";
                                            happy_count++;
                                        }
                                        Image<Gray, byte> grayframe_neutral_mood = nextFrame.Convert<Gray, byte>();
                                        var neutral_moodfaces =
                                                grayframe_neutral_mood.DetectHaarCascade(
                                                        neutral_mood, 1.4, 4,
                                                        HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                        new Size(nextFrame.Width / 8, nextFrame.Height / 8)
                                                        )[0];

                                        foreach (var face in neutral_moodfaces)
                                        {
                                            Mood_TextBox.Text = "Neutral";
                                            neutral_count++;
                                        }
                                       
                                    }
                                }
                            }
                          //  Eyes.Text = template_matched.ToString();
                        }
                    }
                }
                //   Picture_Box.Image = nextFrame.ToBitmap();
            }
        }

        private void Customer_Analyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
           // DirectoryInfo di = new DirectoryInfo(@"C:\Users\BlakeBoyGames\Downloads\Roger That version 2\Roger That - Copy\Roger That\bin\Debug\Templates");
         //   FileInfo[] Images = di.GetFiles("*.jpg");
         //   foreach (FileInfo info in Images)
          //  {
           //     info.Delete();
          //  }
        }

        private void DataSet_Count_Panel(object sender, PaintEventArgs e)
        {

        }
    }
}

