namespace LootjesTrekken
{
    partial class Form2
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
            this.btnVersturen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVersturen
            // 
            this.btnVersturen.Location = new System.Drawing.Point(510, 299);
            this.btnVersturen.Name = "btnVersturen";
            this.btnVersturen.Size = new System.Drawing.Size(75, 23);
            this.btnVersturen.TabIndex = 0;
            this.btnVersturen.Text = "Versturen";
            this.btnVersturen.UseVisualStyleBackColor = true;
            this.btnVersturen.Click += new System.EventHandler(this.btnVersturen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVersturen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVersturen;
    }
}

