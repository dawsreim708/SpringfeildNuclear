namespace SpringfeildNuclear
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ReactorLabel1 = new System.Windows.Forms.Label();
            this.ReactorLabel2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(156, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(474, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ReactorLabel1
            // 
            this.ReactorLabel1.AutoSize = true;
            this.ReactorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorLabel1.Location = new System.Drawing.Point(159, 162);
            this.ReactorLabel1.Name = "ReactorLabel1";
            this.ReactorLabel1.Size = new System.Drawing.Size(114, 25);
            this.ReactorLabel1.TabIndex = 1;
            this.ReactorLabel1.Text = "Reactor 1";
            // 
            // ReactorLabel2
            // 
            this.ReactorLabel2.AutoSize = true;
            this.ReactorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorLabel2.Location = new System.Drawing.Point(516, 162);
            this.ReactorLabel2.Name = "ReactorLabel2";
            this.ReactorLabel2.Size = new System.Drawing.Size(114, 25);
            this.ReactorLabel2.TabIndex = 3;
            this.ReactorLabel2.Text = "Reactor 2";
            this.ReactorLabel2.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.PaleGreen;
            this.Button1.Location = new System.Drawing.Point(161, 201);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(112, 81);
            this.Button1.TabIndex = 4;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.PaleGreen;
            this.Button2.Location = new System.Drawing.Point(518, 201);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(112, 81);
            this.Button2.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Moccasin;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.startButton.Location = new System.Drawing.Point(343, 308);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 36);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(304, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reactor Stable";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reset.Location = new System.Drawing.Point(338, 136);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(123, 25);
            this.reset.TabIndex = 8;
            this.reset.Text = "Reset Button";
            this.reset.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ReactorLabel2);
            this.Controls.Add(this.ReactorLabel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ReactorLabel1;
        private System.Windows.Forms.Label ReactorLabel2;
        private System.Windows.Forms.Label Button1;
        private System.Windows.Forms.Label Button2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reset;
    }
}

