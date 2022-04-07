namespace MidProject
{
    partial class WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherApp));
            this.label1 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.desc = new System.Windows.Forms.Label();
            this.gradus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(237, 107);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(185, 33);
            this.city.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(450, 104);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(92, 36);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(179, 146);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(136, 81);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desc.Location = new System.Drawing.Point(223, 240);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(188, 39);
            this.desc.TabIndex = 4;
            this.desc.Text = "Descreption";
            // 
            // gradus
            // 
            this.gradus.AutoSize = true;
            this.gradus.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradus.Location = new System.Drawing.Point(349, 164);
            this.gradus.Name = "gradus";
            this.gradus.Size = new System.Drawing.Size(73, 39);
            this.gradus.TabIndex = 5;
            this.gradus.Text = "0 °C";
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 391);
            this.Controls.Add(this.gradus);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.search);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label1);
            this.Name = "WeatherApp";
            this.Text = "Kyrgyzstan";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox city;
        private Button search;
        private PictureBox picIcon;
        private Label desc;
        private Label gradus;
    }
}