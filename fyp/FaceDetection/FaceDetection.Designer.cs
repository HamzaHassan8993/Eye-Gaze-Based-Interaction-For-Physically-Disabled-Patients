namespace CameraCapture
{
    partial class FaceDetection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceDetection));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.webCameraImageBoxRGB = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbDetectFaceFile = new System.Windows.Forms.CheckBox();
            this.cbDetectEyeFile = new System.Windows.Forms.CheckBox();
            this.cbDetectMouthFile = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webCameraImageBoxRGB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files (*.bmp;*.gif;*.exif;*.jpg;*.png;*.tiff)|*.bmp;*.gif;*.exif;*.jpg;*.jp" +
    "eg;*.png;*.tiff|All Files (*.*)|*.*";
            // 
            // webCameraImageBoxRGB
            // 
            this.webCameraImageBoxRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webCameraImageBoxRGB.Location = new System.Drawing.Point(1119, 8);
            this.webCameraImageBoxRGB.Margin = new System.Windows.Forms.Padding(2);
            this.webCameraImageBoxRGB.Name = "webCameraImageBoxRGB";
            this.webCameraImageBoxRGB.Size = new System.Drawing.Size(225, 162);
            this.webCameraImageBoxRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.webCameraImageBoxRGB.TabIndex = 2;
            this.webCameraImageBoxRGB.TabStop = false;
            this.webCameraImageBoxRGB.Click += new System.EventHandler(this.webCameraImageBoxRGB_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Webcam";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbDetectFaceFile
            // 
            this.cbDetectFaceFile.AutoSize = true;
            this.cbDetectFaceFile.Checked = true;
            this.cbDetectFaceFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDetectFaceFile.Location = new System.Drawing.Point(166, 18);
            this.cbDetectFaceFile.Name = "cbDetectFaceFile";
            this.cbDetectFaceFile.Size = new System.Drawing.Size(85, 17);
            this.cbDetectFaceFile.TabIndex = 7;
            this.cbDetectFaceFile.Text = "Detect Face";
            this.cbDetectFaceFile.UseVisualStyleBackColor = true;
            // 
            // cbDetectEyeFile
            // 
            this.cbDetectEyeFile.AutoSize = true;
            this.cbDetectEyeFile.Checked = true;
            this.cbDetectEyeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDetectEyeFile.Location = new System.Drawing.Point(257, 18);
            this.cbDetectEyeFile.Name = "cbDetectEyeFile";
            this.cbDetectEyeFile.Size = new System.Drawing.Size(79, 17);
            this.cbDetectEyeFile.TabIndex = 8;
            this.cbDetectEyeFile.Text = "Detect Eye";
            this.cbDetectEyeFile.UseVisualStyleBackColor = true;
            this.cbDetectEyeFile.CheckedChanged += new System.EventHandler(this.cbDetectEyeFile_CheckedChanged);
            // 
            // cbDetectMouthFile
            // 
            this.cbDetectMouthFile.AutoSize = true;
            this.cbDetectMouthFile.Checked = true;
            this.cbDetectMouthFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDetectMouthFile.Location = new System.Drawing.Point(342, 18);
            this.cbDetectMouthFile.Name = "cbDetectMouthFile";
            this.cbDetectMouthFile.Size = new System.Drawing.Size(91, 17);
            this.cbDetectMouthFile.TabIndex = 9;
            this.cbDetectMouthFile.Text = "Detect Mouth";
            this.cbDetectMouthFile.UseVisualStyleBackColor = true;
            this.cbDetectMouthFile.CheckedChanged += new System.EventHandler(this.cbDetectMouthFile_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1191, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(1150, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 352);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.webCameraImageBoxRGB);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 817);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(120, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(282, 299);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(468, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(282, 299);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(827, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(282, 299);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(827, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 299);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(468, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 299);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(120, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 299);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FaceDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 749);
            this.Controls.Add(this.cbDetectMouthFile);
            this.Controls.Add(this.cbDetectEyeFile);
            this.Controls.Add(this.cbDetectFaceFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FaceDetection";
            this.Text = "Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CameraCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webCameraImageBoxRGB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Emgu.CV.UI.ImageBox webCameraImageBoxRGB;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbDetectFaceFile;
        private System.Windows.Forms.CheckBox cbDetectEyeFile;
        private System.Windows.Forms.CheckBox cbDetectMouthFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

