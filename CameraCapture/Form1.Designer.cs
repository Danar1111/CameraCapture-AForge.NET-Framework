namespace CameraCapture
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
            WebcamList = new ComboBox();
            Start = new Button();
            Capture = new Button();
            SaveImage = new Button();
            Exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // WebcamList
            // 
            WebcamList.FormattingEnabled = true;
            WebcamList.Location = new Point(20, 20);
            WebcamList.Name = "WebcamList";
            WebcamList.Size = new Size(145, 23);
            WebcamList.TabIndex = 0;
            // 
            // Start
            // 
            Start.Location = new Point(171, 20);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Capture
            // 
            Capture.Location = new Point(252, 20);
            Capture.Name = "Capture";
            Capture.Size = new Size(75, 23);
            Capture.TabIndex = 2;
            Capture.Text = "Capture";
            Capture.UseVisualStyleBackColor = true;
            Capture.Click += Capture_Click;
            // 
            // SaveImage
            // 
            SaveImage.Location = new Point(333, 20);
            SaveImage.Name = "SaveImage";
            SaveImage.Size = new Size(75, 23);
            SaveImage.TabIndex = 3;
            SaveImage.Text = "Save Image";
            SaveImage.UseVisualStyleBackColor = true;
            SaveImage.Click += SaveImage_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(778, 20);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(20, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(833, 454);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(419, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(411, 448);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 534);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Exit);
            Controls.Add(SaveImage);
            Controls.Add(Capture);
            Controls.Add(Start);
            Controls.Add(WebcamList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox WebcamList;
        private Button Start;
        private Button Capture;
        private Button SaveImage;
        private Button Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}