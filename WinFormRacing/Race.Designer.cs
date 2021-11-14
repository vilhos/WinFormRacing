
using System.Windows.Forms;

namespace WinFormRacing
{
    partial class Race
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.car1 = new System.Windows.Forms.Button();
            this.car2 = new System.Windows.Forms.Button();
            this.car3 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.track = new System.Windows.Forms.PictureBox();
            this.finish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            this.SuspendLayout();
            Control.CheckForIllegalCrossThreadCalls = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.SystemColors.Highlight;
            this.car1.Location = new System.Drawing.Point(48, 51);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(101, 37);
            this.car1.TabIndex = 0;
            this.car1.Text = "car1";
            this.car1.UseVisualStyleBackColor = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.car2.Location = new System.Drawing.Point(48, 138);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(101, 37);
            this.car2.TabIndex = 1;
            this.car2.Text = "car2";
            this.car2.UseVisualStyleBackColor = false;
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.SystemColors.Info;
            this.car3.Location = new System.Drawing.Point(48, 227);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(101, 37);
            this.car3.TabIndex = 2;
            this.car3.Text = "car3";
            this.car3.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(326, 320);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(150, 49);
            this.start.TabIndex = 3;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartClick);
            // 
            // pictureBox1
            // 
            this.track.BackColor = System.Drawing.SystemColors.ControlDark;
            this.track.Location = new System.Drawing.Point(48, 51);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(710, 213);
            this.track.TabIndex = 4;
            this.track.TabStop = false;

            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finish.Location = new System.Drawing.Point(727, 51);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(31, 213);
            this.finish.TabIndex = 5;
            this.finish.TabStop = false;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.track);
            this.Name = "Race";
            this.Text = "Race";
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button car1;
        private System.Windows.Forms.Button car2;
        private System.Windows.Forms.Button car3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox track;
        private System.Windows.Forms.PictureBox finish;
    }
}