
namespace StudenskiObrok
{
    partial class Tekovno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tekovno));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Прикажи = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 183);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Прикажи
            // 
            this.Прикажи.Location = new System.Drawing.Point(42, 131);
            this.Прикажи.Name = "Прикажи";
            this.Прикажи.Size = new System.Drawing.Size(149, 29);
            this.Прикажи.TabIndex = 1;
            this.Прикажи.Text = "Прикажи";
            this.Прикажи.UseVisualStyleBackColor = true;
            this.Прикажи.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(28, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 2;
            // 
            // Tekovno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 435);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Прикажи);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Tekovno";
            this.Text = "Tekovno";
            this.Load += new System.EventHandler(this.Tekovno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Прикажи;
        private System.Windows.Forms.TextBox textBox1;
    }
}