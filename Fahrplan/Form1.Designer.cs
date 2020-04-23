namespace Fahrplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonverbindungen = new System.Windows.Forms.Button();
            this.textboxvon = new System.Windows.Forms.TextBox();
            this.textboxnach = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.datetimepickerabfahrt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonverbindungen
            // 
            this.buttonverbindungen.Location = new System.Drawing.Point(46, 189);
            this.buttonverbindungen.Name = "buttonverbindungen";
            this.buttonverbindungen.Size = new System.Drawing.Size(381, 34);
            this.buttonverbindungen.TabIndex = 0;
            this.buttonverbindungen.Text = "Vebindungen suchen";
            this.buttonverbindungen.UseVisualStyleBackColor = true;
            this.buttonverbindungen.Click += new System.EventHandler(this.buttonverbindungen_Click);
            // 
            // textboxvon
            // 
            this.textboxvon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textboxvon.Location = new System.Drawing.Point(46, 25);
            this.textboxvon.Name = "textboxvon";
            this.textboxvon.Size = new System.Drawing.Size(169, 20);
            this.textboxvon.TabIndex = 2;
            this.textboxvon.Text = "Von";
            this.textboxvon.DoubleClick += new System.EventHandler(this.double_clickvon);
            this.textboxvon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxvon_KeyUp);
            // 
            // textboxnach
            // 
            this.textboxnach.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textboxnach.Location = new System.Drawing.Point(244, 25);
            this.textboxnach.Name = "textboxnach";
            this.textboxnach.Size = new System.Drawing.Size(183, 20);
            this.textboxnach.TabIndex = 3;
            this.textboxnach.Text = "Nach";
            this.textboxnach.DoubleClick += new System.EventHandler(this.double_clicknach);
            this.textboxnach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxnach_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 95);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(244, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 95);
            this.listBox2.TabIndex = 5;
            // 
            // datetimepickerabfahrt
            // 
            this.datetimepickerabfahrt.Location = new System.Drawing.Point(478, 25);
            this.datetimepickerabfahrt.Name = "datetimepickerabfahrt";
            this.datetimepickerabfahrt.Size = new System.Drawing.Size(117, 20);
            this.datetimepickerabfahrt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datetimepickerabfahrt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textboxnach);
            this.Controls.Add(this.textboxvon);
            this.Controls.Add(this.buttonverbindungen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonverbindungen;
        private System.Windows.Forms.TextBox textboxvon;
        private System.Windows.Forms.TextBox textboxnach;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DateTimePicker datetimepickerabfahrt;
    }
}

