using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    partial class Manual
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.myButton2);
            this.splitContainer1.Size = new System.Drawing.Size(915, 488);
            this.splitContainer1.TabIndex = 0;
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(290, 71);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 0;
            this.myButton2.Text = "myButton2";
            this.myButton2.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Manual
            // 
            this.Controls.Add(this.splitContainer1);
            this.Name = "Manual";
            this.Size = new System.Drawing.Size(915, 488);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Controls.MyButton myButton1;
        private SplitContainer splitContainer1;
        private Controls.MyButton myButton2;
    }
}
