
namespace FractalWinForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btZoom = new System.Windows.Forms.Button();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbUp = new System.Windows.Forms.TextBox();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btUnzoom = new System.Windows.Forms.Button();
            this.tbZoomFactor = new System.Windows.Forms.TextBox();
            this.tbMotionFactor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 368);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(11, 104);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(113, 33);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "Left / a";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(225, 104);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(113, 33);
            this.btRight.TabIndex = 2;
            this.btRight.Text = "Right / d";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(119, 20);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(113, 33);
            this.btUp.TabIndex = 3;
            this.btUp.Text = "Up / w";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(119, 183);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(113, 33);
            this.btDown.TabIndex = 4;
            this.btDown.Text = "Down / s";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btZoom
            // 
            this.btZoom.Location = new System.Drawing.Point(145, 59);
            this.btZoom.Name = "btZoom";
            this.btZoom.Size = new System.Drawing.Size(68, 32);
            this.btZoom.TabIndex = 5;
            this.btZoom.Text = "Zoom / ↑";
            this.btZoom.UseVisualStyleBackColor = true;
            this.btZoom.Click += new System.EventHandler(this.btZoom_Click);
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(11, 114);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(238, 23);
            this.tbLeft.TabIndex = 6;
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(258, 114);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(186, 23);
            this.tbRight.TabIndex = 7;
            // 
            // tbUp
            // 
            this.tbUp.Location = new System.Drawing.Point(149, 41);
            this.tbUp.Name = "tbUp";
            this.tbUp.Size = new System.Drawing.Size(199, 23);
            this.tbUp.TabIndex = 8;
            // 
            // tbDown
            // 
            this.tbDown.Location = new System.Drawing.Point(149, 183);
            this.tbDown.Name = "tbDown";
            this.tbDown.Size = new System.Drawing.Size(199, 23);
            this.tbDown.TabIndex = 9;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(28, 93);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(27, 15);
            this.lblLeft.TabIndex = 10;
            this.lblLeft.Text = "Left";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(268, 93);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(35, 15);
            this.lblRight.TabIndex = 11;
            this.lblRight.Text = "Right";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(149, 20);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(22, 15);
            this.lblUp.TabIndex = 12;
            this.lblUp.Text = "Up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Down";
            // 
            // btUnzoom
            // 
            this.btUnzoom.Location = new System.Drawing.Point(145, 145);
            this.btUnzoom.Name = "btUnzoom";
            this.btUnzoom.Size = new System.Drawing.Size(68, 32);
            this.btUnzoom.TabIndex = 14;
            this.btUnzoom.Text = "UnZoom / ↓";
            this.btUnzoom.UseVisualStyleBackColor = true;
            this.btUnzoom.Click += new System.EventHandler(this.btUnzoom_Click);
            // 
            // tbZoomFactor
            // 
            this.tbZoomFactor.Location = new System.Drawing.Point(15, 20);
            this.tbZoomFactor.Name = "tbZoomFactor";
            this.tbZoomFactor.Size = new System.Drawing.Size(58, 23);
            this.tbZoomFactor.TabIndex = 15;
            this.tbZoomFactor.Text = "1.1";
            // 
            // tbMotionFactor
            // 
            this.tbMotionFactor.Location = new System.Drawing.Point(20, 22);
            this.tbMotionFactor.Name = "tbMotionFactor";
            this.tbMotionFactor.Size = new System.Drawing.Size(58, 23);
            this.tbMotionFactor.TabIndex = 16;
            this.tbMotionFactor.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbZoomFactor);
            this.groupBox1.Location = new System.Drawing.Point(130, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 51);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoom Factor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMotionFactor);
            this.groupBox2.Location = new System.Drawing.Point(7, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 59);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motion Factor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblUp);
            this.groupBox3.Controls.Add(this.lblRight);
            this.groupBox3.Controls.Add(this.lblLeft);
            this.groupBox3.Controls.Add(this.tbRight);
            this.groupBox3.Controls.Add(this.tbDown);
            this.groupBox3.Controls.Add(this.tbUp);
            this.groupBox3.Controls.Add(this.tbLeft);
            this.groupBox3.Location = new System.Drawing.Point(1, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 232);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Screen positions in complex plan";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btUnzoom);
            this.groupBox4.Controls.Add(this.btZoom);
            this.groupBox4.Controls.Add(this.btDown);
            this.groupBox4.Controls.Add(this.btUp);
            this.groupBox4.Controls.Add(this.btRight);
            this.groupBox4.Controls.Add(this.btLeft);
            this.groupBox4.Location = new System.Drawing.Point(450, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 232);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motion Controls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btZoom;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbUp;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUnzoom;
        private System.Windows.Forms.TextBox tbZoomFactor;
        private System.Windows.Forms.TextBox tbMotionFactor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

