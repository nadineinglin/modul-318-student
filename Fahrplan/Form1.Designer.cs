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
            this.listboxausgabe = new System.Windows.Forms.ListBox();
            this.labelfahrplan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonverbindungen
            // 
            this.buttonverbindungen.Location = new System.Drawing.Point(87, 176);
            this.buttonverbindungen.Name = "buttonverbindungen";
            this.buttonverbindungen.Size = new System.Drawing.Size(411, 34);
            this.buttonverbindungen.TabIndex = 0;
            this.buttonverbindungen.Text = "Vebindungen suchen";
            this.buttonverbindungen.UseVisualStyleBackColor = true;
            this.buttonverbindungen.Click += new System.EventHandler(this.buttonverbindungen_Click);
            // 
            // textboxvon
            // 
            this.textboxvon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textboxvon.Location = new System.Drawing.Point(87, 88);
            this.textboxvon.Name = "textboxvon";
            this.textboxvon.Size = new System.Drawing.Size(169, 20);
            this.textboxvon.TabIndex = 2;
            this.textboxvon.DoubleClick += new System.EventHandler(this.double_clickvon);
            this.textboxvon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxvon_KeyUp);
            // 
            // textboxnach
            // 
            this.textboxnach.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textboxnach.Location = new System.Drawing.Point(315, 88);
            this.textboxnach.Name = "textboxnach";
            this.textboxnach.Size = new System.Drawing.Size(183, 20);
            this.textboxnach.TabIndex = 3;
            this.textboxnach.DoubleClick += new System.EventHandler(this.double_clicknach);
            this.textboxnach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxnach_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(87, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 56);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(315, 114);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 56);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // datetimepickerabfahrt
            // 
            this.datetimepickerabfahrt.Location = new System.Drawing.Point(381, 53);
            this.datetimepickerabfahrt.Name = "datetimepickerabfahrt";
            this.datetimepickerabfahrt.Size = new System.Drawing.Size(117, 20);
            this.datetimepickerabfahrt.TabIndex = 6;
            // 
            // listboxausgabe
            // 
            this.listboxausgabe.FormattingEnabled = true;
            this.listboxausgabe.Location = new System.Drawing.Point(87, 216);
            this.listboxausgabe.Name = "listboxausgabe";
            this.listboxausgabe.Size = new System.Drawing.Size(411, 108);
            this.listboxausgabe.TabIndex = 7;
            // 
            // labelfahrplan
            // 
            this.labelfahrplan.AutoSize = true;
            this.labelfahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfahrplan.Location = new System.Drawing.Point(82, 27);
            this.labelfahrplan.Name = "labelfahrplan";
            this.labelfahrplan.Size = new System.Drawing.Size(108, 29);
            this.labelfahrplan.TabIndex = 8;
            this.labelfahrplan.Text = "Fahrplan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nach:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelfahrplan);
            this.Controls.Add(this.listboxausgabe);
            this.Controls.Add(this.datetimepickerabfahrt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textboxnach);
            this.Controls.Add(this.textboxvon);
            this.Controls.Add(this.buttonverbindungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListBox listboxausgabe;
        private System.Windows.Forms.Label labelfahrplan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

