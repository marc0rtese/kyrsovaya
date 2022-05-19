
namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTick = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.infoTick = new System.Windows.Forms.Label();
            this.infoWigth = new System.Windows.Forms.Label();
            this.infoSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(-1, -1);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(540, 540);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTick
            // 
            this.tbTick.Location = new System.Drawing.Point(557, 176);
            this.tbTick.Maximum = 100;
            this.tbTick.Minimum = 10;
            this.tbTick.Name = "tbTick";
            this.tbTick.Size = new System.Drawing.Size(180, 45);
            this.tbTick.TabIndex = 1;
            this.tbTick.Value = 10;
            this.tbTick.Scroll += new System.EventHandler(this.tbTick_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Частиц в тик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Направление";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(558, 321);
            this.tbWidth.Maximum = 360;
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(180, 45);
            this.tbWidth.TabIndex = 5;
            this.tbWidth.Value = 1;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(558, 482);
            this.tbSpeed.Maximum = 7;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(180, 45);
            this.tbSpeed.TabIndex = 7;
            this.tbSpeed.Value = 2;
            this.tbSpeed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(608, 45);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(64, 49);
            this.colorButton.TabIndex = 8;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // infoTick
            // 
            this.infoTick.AutoSize = true;
            this.infoTick.Location = new System.Drawing.Point(694, 160);
            this.infoTick.Name = "infoTick";
            this.infoTick.Size = new System.Drawing.Size(13, 13);
            this.infoTick.TabIndex = 9;
            this.infoTick.Text = "1";
            // 
            // infoWigth
            // 
            this.infoWigth.AutoSize = true;
            this.infoWigth.Location = new System.Drawing.Point(695, 305);
            this.infoWigth.Name = "infoWigth";
            this.infoWigth.Size = new System.Drawing.Size(13, 13);
            this.infoWigth.TabIndex = 10;
            this.infoWigth.Text = "2";
            // 
            // infoSpeed
            // 
            this.infoSpeed.AutoSize = true;
            this.infoSpeed.Location = new System.Drawing.Point(695, 455);
            this.infoSpeed.Name = "infoSpeed";
            this.infoSpeed.Size = new System.Drawing.Size(13, 13);
            this.infoSpeed.TabIndex = 11;
            this.infoSpeed.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 540);
            this.Controls.Add(this.infoSpeed);
            this.Controls.Add(this.infoWigth);
            this.Controls.Add(this.infoTick);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTick);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label infoTick;
        private System.Windows.Forms.Label infoWigth;
        private System.Windows.Forms.Label infoSpeed;
    }
}

