namespace ZarAtma
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            pb2 = new PictureBox();
            pb1 = new PictureBox();
            ımageList1 = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textzar1 = new TextBox();
            textzar2 = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(83, 15);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(531, 322);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oyuncular";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 263);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 31);
            textBox2.TabIndex = 5;
            textBox2.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 263);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "0";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(301, 87);
            listBox2.Margin = new Padding(4, 3, 4, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(157, 154);
            listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(23, 87);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(157, 154);
            listBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(301, 33);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(113, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Oyuncu 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 33);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Oyuncu 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pb2);
            groupBox2.Controls.Add(pb1);
            groupBox2.Location = new Point(83, 343);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(531, 243);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zarlar";
            // 
            // pb2
            // 
            pb2.Location = new Point(301, 33);
            pb2.Margin = new Padding(4, 3, 4, 3);
            pb2.Name = "pb2";
            pb2.Size = new Size(176, 168);
            pb2.TabIndex = 1;
            pb2.TabStop = false;
            // 
            // pb1
            // 
            pb1.Location = new Point(23, 33);
            pb1.Margin = new Padding(4, 3, 4, 3);
            pb1.Name = "pb1";
            pb1.Size = new Size(176, 168);
            pb1.TabIndex = 0;
            pb1.TabStop = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "zar_1.jpg");
            ımageList1.Images.SetKeyName(1, "zar_2.jpg");
            ımageList1.Images.SetKeyName(2, "zar_3.jpg");
            ımageList1.Images.SetKeyName(3, "zar_4.jpg");
            ımageList1.Images.SetKeyName(4, "zar_5.jpg");
            ımageList1.Images.SetKeyName(5, "zar_6.jpg");
            ımageList1.Images.SetKeyName(6, "zar_1.jpg");
            // 
            // button1
            // 
            button1.Location = new Point(146, 605);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 2;
            button1.Text = "Zarları at";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(384, 605);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 3;
            button2.Text = "Skora Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(689, 397);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 4;
            label1.Text = "zar 1";
            // 
            // textzar1
            // 
            textzar1.Location = new Point(767, 393);
            textzar1.Margin = new Padding(4, 3, 4, 3);
            textzar1.Name = "textzar1";
            textzar1.Size = new Size(155, 31);
            textzar1.TabIndex = 5;
            // 
            // textzar2
            // 
            textzar2.Location = new Point(767, 467);
            textzar2.Margin = new Padding(4, 3, 4, 3);
            textzar2.Name = "textzar2";
            textzar2.Size = new Size(155, 31);
            textzar2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(689, 470);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 6;
            label2.Text = "zar 2";
            // 
            // timer1
            // 
            timer1.Interval = 150;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(663, 48);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 8;
            label3.Text = "21220030008";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 660);
            Controls.Add(label3);
            Controls.Add(textzar2);
            Controls.Add(label2);
            Controls.Add(textzar1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox2;
        private ListBox listBox1;
        private ImageList ımageList1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textzar1;
        private TextBox textzar2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pb2;
        private PictureBox pb1;
        private Label label3;
    }
}