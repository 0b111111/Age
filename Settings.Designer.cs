namespace Age
{
    partial class Settings
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(78, 12);
            this.Input.MaxLength = 19;
            this.Input.Name = "Input";
            this.Input.PlaceholderText = "Enter a date here";
            this.Input.Size = new System.Drawing.Size(150, 23);
            this.Input.TabIndex = 1;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input.TextChanged += new System.EventHandler(this.Settings_Validate);
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Settings_Validate);
            this.Input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Settings_IsEnter);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(8, 63);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(70, 25);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // OK
            // 
            this.OK.Enabled = false;
            this.OK.Location = new System.Drawing.Point(158, 63);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(70, 25);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "I was born:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Age.Properties.Resources.frame;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Help_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Age.Properties.Resources.frame550x100;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(550, 100);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "valid input:\r\n\r\nYYYY-MM-DD\r\nYYYY-MM-DD HH:MM:SS";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(428, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "example:\r\n\r\n2026-12-31\r\n2026-12-31 23:46:12";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(240, 100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 100);
            this.MinimumSize = new System.Drawing.Size(240, 100);
            this.Name = "Settings";
            this.Text = "Settings";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Input;
        private Button Cancel;
        private Button OK;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}