namespace Age
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
            System.Windows.Forms.Label label4;
            this.Copy = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.BackColor = System.Drawing.Color.Black;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Location = new System.Drawing.Point(37, 133);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(275, 109);
            label4.TabIndex = 1;
            // 
            // Copy
            // 
            this.Copy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Copy.Location = new System.Drawing.Point(140, 328);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(68, 37);
            this.Copy.TabIndex = 0;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Settings.Image = global::Age.Properties.Resources.gear2;
            this.Settings.Location = new System.Drawing.Point(323, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(24, 24);
            this.Settings.TabIndex = 3;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "stop wasting your life";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "The problem is\r\nyou think you have time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your age is:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Output
            // 
            this.Output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Output.Location = new System.Drawing.Point(47, 186);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(254, 44);
            this.Output.TabIndex = 7;
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(348, 377);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(label4);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Copy);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Age counter";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Copy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Output;
        public System.Windows.Forms.Timer timer1;
        public Button Settings;
    }
}