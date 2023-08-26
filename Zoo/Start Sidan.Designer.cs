namespace Zoo
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pStart = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.lblWellcome = new System.Windows.Forms.Label();
            this.pStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStart
            // 
            this.pStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pStart.BackgroundImage")));
            this.pStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pStart.Controls.Add(this.button1);
            this.pStart.Controls.Add(this.buttonVisitor);
            this.pStart.Controls.Add(this.lblWellcome);
            this.pStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStart.Location = new System.Drawing.Point(0, 0);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(800, 450);
            this.pStart.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(462, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Djurskötare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonVisitor.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisitor.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonVisitor.Location = new System.Drawing.Point(243, 196);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(138, 50);
            this.buttonVisitor.TabIndex = 1;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = false;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonVisitor_Click);
            // 
            // lblWellcome
            // 
            this.lblWellcome.AutoSize = true;
            this.lblWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWellcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWellcome.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWellcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWellcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWellcome.Location = new System.Drawing.Point(281, 66);
            this.lblWellcome.Name = "lblWellcome";
            this.lblWellcome.Size = new System.Drawing.Size(283, 42);
            this.lblWellcome.TabIndex = 0;
            this.lblWellcome.Text = "Wellcome To The Jozoo";
            this.lblWellcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pStart.ResumeLayout(false);
            this.pStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Label lblWellcome;
        private System.Windows.Forms.Button buttonVisitor;
        private System.Windows.Forms.Button button1;
    }
}

