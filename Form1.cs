using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using YoutubeExtractor;
using System.Threading;

namespace AdvancedYoutubeDownloader
{
    public partial class MainWindow : Form
    {

        public static IEnumerable<VideoInfo> videoInfos;

        public MainWindow()
        {
            InitializeComponent();
            txtPath.Text = ConfigurationManager.AppSettings["lastPath"];
            labCheckURLStatus.Text = "";
            this.logBox("Program version v" + ProgramInfo.appVersion, newLine: false);
            this.logBox("  |  release: " + ProgramInfo.releaseDate);
        }

        private void btnCheckURL_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            try
            {
                videoInfos = DownloadUrlResolver.GetDownloadUrls(url);

                labCheckURLStatus.Text = "OK!";
                comBoxRes.Items.Clear();
                foreach (var a in videoInfos)
                {
                    if (a.VideoType != VideoType.Mp4)
                        continue;
 
                    //String s = a.VideoType + " " + a.VideoExtension + " " + a.Resolution;
                    String s = a.Resolution.ToString();
                    Console.WriteLine(a);
                    comBoxRes.Items.Add(s);
                    comBoxRes.SelectedIndex = 0;
                }
                this.logBox("Correct URL. Select resolution and destination folder.", Color.Green);
            }
            catch (System.ArgumentException)
            {
                labCheckURLStatus.Text = "Not a valid URL!";
                this.logBox("Wrong URL. Paste correct.", Color.Red);
            }
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            txtBoxLog.AppendText("Downloading " + comBoxRes.Text);
            txtBoxLog.AppendText("\n");

            VideoInfo vid = videoInfos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(comBoxRes.Text));
            if (vid.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(vid);
            //var vidDown = new VideoDownloader(vid, txtPath.ToString() + "\\" + vid.Title + vid.VideoExtension);
            var vidDown = new VideoDownloader(vid, txtPath.Text + "\\" + vid.Title + ".mp4");

            vidDown.DownloadProgressChanged += Downloader_DownloadProgressChanged;

            vidDown.Execute();
            //Thread thr = new Thread(() => { vidDown.Execute(); }) { IsBackground = true };
            //thr.Start();
            progBar.Value = 0;
        }


        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progBar.Value = (int)e.ProgressPercentage;
                progBar.Update();
            }));
        }


        private void txtPath_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);


            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select download path";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String selectedPath = fbd.SelectedPath.ToString();
                txtPath.Text = selectedPath;
                config.AppSettings.Settings["lastPath"].Value = selectedPath;
                config.Save(ConfigurationSaveMode.Modified);
            }
        }

        private void logBox(string toPrint, Color col = default(Color), bool newLine = true)
        {
            this.txtBoxLog.SelectionColor = col;
            this.txtBoxLog.AppendText(toPrint);
            if (newLine)
                this.txtBoxLog.AppendText(Environment.NewLine);
        }
    }
}
