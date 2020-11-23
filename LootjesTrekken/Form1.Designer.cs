namespace LootjesTrekken
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
            this.lstLootjesNamen = new System.Windows.Forms.ListBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLootjesNamen
            // 
            this.lstLootjesNamen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstLootjesNamen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstLootjesNamen.FormattingEnabled = true;
            this.lstLootjesNamen.ItemHeight = 16;
            this.lstLootjesNamen.Location = new System.Drawing.Point(268, 34);
            this.lstLootjesNamen.Name = "lstLootjesNamen";
            this.lstLootjesNamen.Size = new System.Drawing.Size(288, 260);
            this.lstLootjesNamen.TabIndex = 0;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(268, 365);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(102, 23);
            this.btnOpslaan.TabIndex = 1;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(268, 312);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 22);
            this.txtName.TabIndex = 2;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(408, 364);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(148, 23);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Toevoegen";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::LootjesTrekken.Properties.Resources.saint_nicholas_2965161;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lstLootjesNamen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLootjesNamen;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddName;
    }
}

