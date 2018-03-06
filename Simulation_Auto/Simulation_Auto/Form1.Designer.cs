namespace Simulation_Auto
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
            this.cmd_Erstellen = new System.Windows.Forms.Button();
            this.txt_BoxMarke = new System.Windows.Forms.TextBox();
            this.txtBox_Ps = new System.Windows.Forms.TextBox();
            this.txtBoxTankgröße = new System.Windows.Forms.TextBox();
            this.txt_BoxVerbrauch = new System.Windows.Forms.TextBox();
            this.cmbo_BoxFarbe = new System.Windows.Forms.ComboBox();
            this.label__1 = new System.Windows.Forms.Label();
            this.label__2 = new System.Windows.Forms.Label();
            this.label__3 = new System.Windows.Forms.Label();
            this.label__4 = new System.Windows.Forms.Label();
            this.label__5 = new System.Windows.Forms.Label();
            this.rTB_Info = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_BoxFahren = new System.Windows.Forms.TextBox();
            this.cmd_Tanken = new System.Windows.Forms.Button();
            this.cmd_Fahren = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmd_Erstellen
            // 
            this.cmd_Erstellen.Location = new System.Drawing.Point(379, 121);
            this.cmd_Erstellen.Name = "cmd_Erstellen";
            this.cmd_Erstellen.Size = new System.Drawing.Size(125, 50);
            this.cmd_Erstellen.TabIndex = 0;
            this.cmd_Erstellen.Text = "Auto erstellen";
            this.cmd_Erstellen.UseVisualStyleBackColor = true;
            this.cmd_Erstellen.Click += new System.EventHandler(this.cmd_Erstellen_Click);
            // 
            // txt_BoxMarke
            // 
            this.txt_BoxMarke.Location = new System.Drawing.Point(82, 12);
            this.txt_BoxMarke.Name = "txt_BoxMarke";
            this.txt_BoxMarke.Size = new System.Drawing.Size(121, 20);
            this.txt_BoxMarke.TabIndex = 1;
            // 
            // txtBox_Ps
            // 
            this.txtBox_Ps.Location = new System.Drawing.Point(82, 121);
            this.txtBox_Ps.Name = "txtBox_Ps";
            this.txtBox_Ps.Size = new System.Drawing.Size(121, 20);
            this.txtBox_Ps.TabIndex = 2;
            // 
            // txtBoxTankgröße
            // 
            this.txtBoxTankgröße.Location = new System.Drawing.Point(404, 12);
            this.txtBoxTankgröße.Name = "txtBoxTankgröße";
            this.txtBoxTankgröße.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTankgröße.TabIndex = 3;
            // 
            // txt_BoxVerbrauch
            // 
            this.txt_BoxVerbrauch.Location = new System.Drawing.Point(404, 63);
            this.txt_BoxVerbrauch.Name = "txt_BoxVerbrauch";
            this.txt_BoxVerbrauch.Size = new System.Drawing.Size(100, 20);
            this.txt_BoxVerbrauch.TabIndex = 4;
            // 
            // cmbo_BoxFarbe
            // 
            this.cmbo_BoxFarbe.FormattingEnabled = true;
            this.cmbo_BoxFarbe.Items.AddRange(new object[] {
            "Rot",
            "Gelb",
            "Grün",
            "Blau",
            "Grau"});
            this.cmbo_BoxFarbe.Location = new System.Drawing.Point(82, 63);
            this.cmbo_BoxFarbe.Name = "cmbo_BoxFarbe";
            this.cmbo_BoxFarbe.Size = new System.Drawing.Size(121, 21);
            this.cmbo_BoxFarbe.TabIndex = 5;
            // 
            // label__1
            // 
            this.label__1.AutoSize = true;
            this.label__1.Location = new System.Drawing.Point(325, 12);
            this.label__1.Name = "label__1";
            this.label__1.Size = new System.Drawing.Size(62, 13);
            this.label__1.TabIndex = 6;
            this.label__1.Text = "Tankgröße:";
            // 
            // label__2
            // 
            this.label__2.AutoSize = true;
            this.label__2.Location = new System.Drawing.Point(325, 66);
            this.label__2.Name = "label__2";
            this.label__2.Size = new System.Drawing.Size(59, 13);
            this.label__2.TabIndex = 7;
            this.label__2.Text = "Verbrauch:";
            // 
            // label__3
            // 
            this.label__3.AutoSize = true;
            this.label__3.Location = new System.Drawing.Point(12, 15);
            this.label__3.Name = "label__3";
            this.label__3.Size = new System.Drawing.Size(40, 13);
            this.label__3.TabIndex = 8;
            this.label__3.Text = "Marke:";
            // 
            // label__4
            // 
            this.label__4.AutoSize = true;
            this.label__4.Location = new System.Drawing.Point(12, 66);
            this.label__4.Name = "label__4";
            this.label__4.Size = new System.Drawing.Size(37, 13);
            this.label__4.TabIndex = 9;
            this.label__4.Text = "Farbe:";
            // 
            // label__5
            // 
            this.label__5.AutoSize = true;
            this.label__5.Location = new System.Drawing.Point(12, 124);
            this.label__5.Name = "label__5";
            this.label__5.Size = new System.Drawing.Size(24, 13);
            this.label__5.TabIndex = 10;
            this.label__5.Text = "PS:";
            // 
            // rTB_Info
            // 
            this.rTB_Info.Location = new System.Drawing.Point(373, 325);
            this.rTB_Info.Name = "rTB_Info";
            this.rTB_Info.Size = new System.Drawing.Size(285, 188);
            this.rTB_Info.TabIndex = 11;
            this.rTB_Info.Text = "";
            this.rTB_Info.TextChanged += new System.EventHandler(this.rTB_Info_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_BoxFahren
            // 
            this.txt_BoxFahren.Location = new System.Drawing.Point(28, 479);
            this.txt_BoxFahren.Name = "txt_BoxFahren";
            this.txt_BoxFahren.Size = new System.Drawing.Size(100, 20);
            this.txt_BoxFahren.TabIndex = 13;
            this.txt_BoxFahren.TextChanged += new System.EventHandler(this.txt_BoxFahren_TextChanged);
            // 
            // cmd_Tanken
            // 
            this.cmd_Tanken.Location = new System.Drawing.Point(161, 325);
            this.cmd_Tanken.Name = "cmd_Tanken";
            this.cmd_Tanken.Size = new System.Drawing.Size(125, 50);
            this.cmd_Tanken.TabIndex = 14;
            this.cmd_Tanken.Text = "Tanken";
            this.cmd_Tanken.UseVisualStyleBackColor = true;
            this.cmd_Tanken.Click += new System.EventHandler(this.cmd_Tanken_Click);
            // 
            // cmd_Fahren
            // 
            this.cmd_Fahren.Location = new System.Drawing.Point(161, 463);
            this.cmd_Fahren.Name = "cmd_Fahren";
            this.cmd_Fahren.Size = new System.Drawing.Size(125, 50);
            this.cmd_Fahren.TabIndex = 15;
            this.cmd_Fahren.Text = "Fahren";
            this.cmd_Fahren.UseVisualStyleBackColor = true;
            this.cmd_Fahren.Click += new System.EventHandler(this.cmd_Fahren_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 525);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmd_Fahren);
            this.Controls.Add(this.cmd_Tanken);
            this.Controls.Add(this.txt_BoxFahren);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rTB_Info);
            this.Controls.Add(this.label__5);
            this.Controls.Add(this.label__4);
            this.Controls.Add(this.label__3);
            this.Controls.Add(this.label__2);
            this.Controls.Add(this.label__1);
            this.Controls.Add(this.cmbo_BoxFarbe);
            this.Controls.Add(this.txt_BoxVerbrauch);
            this.Controls.Add(this.txtBoxTankgröße);
            this.Controls.Add(this.txtBox_Ps);
            this.Controls.Add(this.txt_BoxMarke);
            this.Controls.Add(this.cmd_Erstellen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Erstellen;
        private System.Windows.Forms.TextBox txt_BoxMarke;
        private System.Windows.Forms.TextBox txtBox_Ps;
        private System.Windows.Forms.TextBox txtBoxTankgröße;
        private System.Windows.Forms.TextBox txt_BoxVerbrauch;
        private System.Windows.Forms.ComboBox cmbo_BoxFarbe;
        private System.Windows.Forms.Label label__1;
        private System.Windows.Forms.Label label__2;
        private System.Windows.Forms.Label label__3;
        private System.Windows.Forms.Label label__4;
        private System.Windows.Forms.Label label__5;
        private System.Windows.Forms.RichTextBox rTB_Info;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_BoxFahren;
        private System.Windows.Forms.Button cmd_Tanken;
        private System.Windows.Forms.Button cmd_Fahren;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

