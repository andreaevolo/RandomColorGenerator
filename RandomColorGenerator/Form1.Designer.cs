namespace RandomColorGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GenerateRandColorBtn = new System.Windows.Forms.Button();
            this.KeepGeneratingRandColorBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.rgb_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rgbLabelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // GenerateRandColorBtn
            // 
            this.GenerateRandColorBtn.Location = new System.Drawing.Point(495, 278);
            this.GenerateRandColorBtn.Name = "GenerateRandColorBtn";
            this.GenerateRandColorBtn.Size = new System.Drawing.Size(223, 55);
            this.GenerateRandColorBtn.TabIndex = 0;
            this.GenerateRandColorBtn.Text = "Generate Random Color";
            this.GenerateRandColorBtn.UseVisualStyleBackColor = true;
            this.GenerateRandColorBtn.Click += new System.EventHandler(this.GenerateRandColorBtn_Click);
            // 
            // KeepGeneratingRandColorBtn
            // 
            this.KeepGeneratingRandColorBtn.Location = new System.Drawing.Point(495, 348);
            this.KeepGeneratingRandColorBtn.Name = "KeepGeneratingRandColorBtn";
            this.KeepGeneratingRandColorBtn.Size = new System.Drawing.Size(223, 55);
            this.KeepGeneratingRandColorBtn.TabIndex = 1;
            this.KeepGeneratingRandColorBtn.Text = "Keep Generating Random Color";
            this.KeepGeneratingRandColorBtn.UseVisualStyleBackColor = true;
            this.KeepGeneratingRandColorBtn.Click += new System.EventHandler(this.KeepGeneratingRandColorBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(495, 409);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(223, 55);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "StopBtn";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // rgb_label
            // 
            this.rgb_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rgb_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgb_label.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgb_label.Location = new System.Drawing.Point(0, 0);
            this.rgb_label.Name = "rgb_label";
            this.rgb_label.Size = new System.Drawing.Size(1204, 46);
            this.rgb_label.TabIndex = 3;
            this.rgb_label.Text = "0,0,0";
            this.rgb_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rgbLabelToolTip.SetToolTip(this.rgb_label, "Double Click to Copy");
            this.rgb_label.DoubleClick += new System.EventHandler(this.copyRGB_DoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // rgbLabelToolTip
            // 
            this.rgbLabelToolTip.AutoPopDelay = 5000;
            this.rgbLabelToolTip.InitialDelay = 350;
            this.rgbLabelToolTip.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 624);
            this.Controls.Add(this.rgb_label);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.KeepGeneratingRandColorBtn);
            this.Controls.Add(this.GenerateRandColorBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button GenerateRandColorBtn;
        private Button KeepGeneratingRandColorBtn;
        private Button StopBtn;
        private Label rgb_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolTip rgbLabelToolTip;
    }
}