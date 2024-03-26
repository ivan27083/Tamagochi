namespace Tamagochi
{
    partial class Pets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pets));
            this.dog = new System.Windows.Forms.Button();
            this.lion = new System.Windows.Forms.Button();
            this.tiger = new System.Windows.Forms.Button();
            this.cow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dog
            // 
            this.dog.BackColor = System.Drawing.Color.PapayaWhip;
            this.dog.BackgroundImage = global::Tamagochi.Properties.Resources.dog;
            this.dog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog.Location = new System.Drawing.Point(96, 82);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(170, 152);
            this.dog.TabIndex = 0;
            this.dog.UseVisualStyleBackColor = false;
            this.dog.Click += new System.EventHandler(this.button_Click);
            // 
            // lion
            // 
            this.lion.BackColor = System.Drawing.Color.PapayaWhip;
            this.lion.BackgroundImage = global::Tamagochi.Properties.Resources.lion;
            this.lion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lion.Location = new System.Drawing.Point(363, 82);
            this.lion.Name = "lion";
            this.lion.Size = new System.Drawing.Size(170, 152);
            this.lion.TabIndex = 1;
            this.lion.UseVisualStyleBackColor = false;
            this.lion.Click += new System.EventHandler(this.button_Click);
            // 
            // tiger
            // 
            this.tiger.BackColor = System.Drawing.Color.PapayaWhip;
            this.tiger.BackgroundImage = global::Tamagochi.Properties.Resources.tiger;
            this.tiger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tiger.Location = new System.Drawing.Point(363, 287);
            this.tiger.Name = "tiger";
            this.tiger.Size = new System.Drawing.Size(170, 152);
            this.tiger.TabIndex = 3;
            this.tiger.UseVisualStyleBackColor = false;
            this.tiger.Click += new System.EventHandler(this.button_Click);
            // 
            // cow
            // 
            this.cow.BackColor = System.Drawing.Color.PapayaWhip;
            this.cow.BackgroundImage = global::Tamagochi.Properties.Resources.cow;
            this.cow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cow.Location = new System.Drawing.Point(96, 287);
            this.cow.Name = "cow";
            this.cow.Size = new System.Drawing.Size(170, 152);
            this.cow.TabIndex = 2;
            this.cow.UseVisualStyleBackColor = false;
            this.cow.Click += new System.EventHandler(this.button_Click);
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tamagochi.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(645, 524);
            this.Controls.Add(this.tiger);
            this.Controls.Add(this.cow);
            this.Controls.Add(this.lion);
            this.Controls.Add(this.dog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pets";
            this.Text = "Pets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dog;
        private System.Windows.Forms.Button lion;
        private System.Windows.Forms.Button tiger;
        private System.Windows.Forms.Button cow;
    }
}