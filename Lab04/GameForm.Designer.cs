namespace lab04
{
    partial class GameForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new lab04.Door();
            this.pictureBox2 = new lab04.Door();
            this.pictureBox1 = new lab04.Door();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбирайте Дверь!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::lab04.Properties.Resources.start_image2;
            this.pictureBox3.IsCarHere = false;
            this.pictureBox3.isChecked = false;
            this.pictureBox3.isOpened = false;
            this.pictureBox3.Location = new System.Drawing.Point(559, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Position = 0;
            this.pictureBox3.Size = new System.Drawing.Size(144, 200);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lab04.Properties.Resources.start_image2;
            this.pictureBox2.IsCarHere = false;
            this.pictureBox2.isChecked = false;
            this.pictureBox2.isOpened = false;
            this.pictureBox2.Location = new System.Drawing.Point(409, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Position = 0;
            this.pictureBox2.Size = new System.Drawing.Size(144, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab04.Properties.Resources.start_image2;
            this.pictureBox1.IsCarHere = false;
            this.pictureBox1.isChecked = false;
            this.pictureBox1.isOpened = false;
            this.pictureBox1.Location = new System.Drawing.Point(259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Position = 0;
            this.pictureBox1.Size = new System.Drawing.Size(144, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Door pictureBox1;
        private Door pictureBox2;
        private Door pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}