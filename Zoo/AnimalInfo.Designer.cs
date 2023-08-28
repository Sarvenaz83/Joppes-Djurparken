namespace Zoo
{
    partial class AnimalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalInfo));
            this.panelAnimal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelAnimal
            // 
            this.panelAnimal.BackgroundImage = global::Zoo.Properties.Resources.zoo_bg;
            this.panelAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnimal.Location = new System.Drawing.Point(0, 0);
            this.panelAnimal.Name = "panelAnimal";
            this.panelAnimal.Size = new System.Drawing.Size(800, 450);
            this.panelAnimal.TabIndex = 0;
            // 
            // AnimalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnimal;
    }
}