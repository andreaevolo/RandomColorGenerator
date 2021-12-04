namespace RandomColorGenerator
{
    public partial class Form1 : Form
    {
        private Generator _generator = Generator.Instance;
        private Boolean _keep_generating = true;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private Color LabelTextColor(int[] rgb)
        {
            double rgb_intensity = rgb[0] * 0.299 + rgb[1] * 0.587 + rgb[2] * 0.114;
            // pick a text color based on color intensity
            if ((rgb_intensity) > 186) {
                return Color.Black;
            }
            return Color.White;
        }
        private int[] calcArgb(string rgb)
        {
            string[]? splittedStr = rgb.Split(',');
            // convert rgb string into argb
            int[]? splitInts = splittedStr.Select(item => int.Parse(item)).ToArray();
            return splitInts;
        }

        private void GenerateColor()
        {
            _generator.generateColor();
            string color_str = _generator.Color();
            int[] rgb = calcArgb(color_str);
            rgb_label.Invoke((MethodInvoker)delegate
            {
                rgb_label.Text = color_str;
                rgb_label.ForeColor = LabelTextColor(rgb);
            });
            this.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }
        private void GenerateRandColorBtn_Click(object sender, EventArgs e)
        {
            GenerateColor();
        }

        private void KeepGeneratingRandColorBtn_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        

        private void StopBtn_Click(object sender, EventArgs e)
        {
            _keep_generating = false;
            if(backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _keep_generating = true;
            while (_keep_generating)
            {
                GenerateColor();
                Thread.Sleep(2000);
            }
        }

        private void copyRGB_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}