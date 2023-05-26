namespace Magazin_Biciclete
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.buttonAfisareBicicleta = new System.Windows.Forms.Button();
         this.buttonAdaugareBicicleta = new System.Windows.Forms.Button();
         this.buttonIncarcareDate = new System.Windows.Forms.Button();
         this.buttonSalvareFisier = new System.Windows.Forms.Button();
         this.buttonAfisareCautare = new System.Windows.Forms.Button();
         this.buttonInfoAutor = new System.Windows.Forms.Button();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.labelAutorInfo = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.labelMeniu = new System.Windows.Forms.Label();
         this.buttonIesire = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // buttonAfisareBicicleta
         // 
         this.buttonAfisareBicicleta.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonAfisareBicicleta.Location = new System.Drawing.Point(47, 349);
         this.buttonAfisareBicicleta.Name = "buttonAfisareBicicleta";
         this.buttonAfisareBicicleta.Size = new System.Drawing.Size(118, 23);
         this.buttonAfisareBicicleta.TabIndex = 0;
         this.buttonAfisareBicicleta.Text = "Afisare";
         this.buttonAfisareBicicleta.UseVisualStyleBackColor = true;
         this.buttonAfisareBicicleta.Click += new System.EventHandler(this.buttonAfisareBicicleta_Click);
         // 
         // buttonAdaugareBicicleta
         // 
         this.buttonAdaugareBicicleta.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonAdaugareBicicleta.Location = new System.Drawing.Point(47, 291);
         this.buttonAdaugareBicicleta.Name = "buttonAdaugareBicicleta";
         this.buttonAdaugareBicicleta.Size = new System.Drawing.Size(118, 23);
         this.buttonAdaugareBicicleta.TabIndex = 1;
         this.buttonAdaugareBicicleta.Text = "Adaugare Bicicleta";
         this.buttonAdaugareBicicleta.UseVisualStyleBackColor = true;
         this.buttonAdaugareBicicleta.Click += new System.EventHandler(this.buttonAdaugareBicicleta_Click);
         // 
         // buttonIncarcareDate
         // 
         this.buttonIncarcareDate.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonIncarcareDate.Location = new System.Drawing.Point(47, 378);
         this.buttonIncarcareDate.Name = "buttonIncarcareDate";
         this.buttonIncarcareDate.Size = new System.Drawing.Size(118, 23);
         this.buttonIncarcareDate.TabIndex = 2;
         this.buttonIncarcareDate.Text = "Incarcare Date";
         this.buttonIncarcareDate.UseVisualStyleBackColor = true;
         this.buttonIncarcareDate.Click += new System.EventHandler(this.buttonIncarcareDate_Click);
         // 
         // buttonSalvareFisier
         // 
         this.buttonSalvareFisier.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonSalvareFisier.Location = new System.Drawing.Point(47, 320);
         this.buttonSalvareFisier.Name = "buttonSalvareFisier";
         this.buttonSalvareFisier.Size = new System.Drawing.Size(118, 23);
         this.buttonSalvareFisier.TabIndex = 3;
         this.buttonSalvareFisier.Text = "Salvare Bicicleta";
         this.buttonSalvareFisier.UseVisualStyleBackColor = true;
         this.buttonSalvareFisier.Click += new System.EventHandler(this.buttonSalvare_Click);
         // 
         // buttonAfisareCautare
         // 
         this.buttonAfisareCautare.BackColor = System.Drawing.Color.White;
         this.buttonAfisareCautare.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonAfisareCautare.Location = new System.Drawing.Point(47, 262);
         this.buttonAfisareCautare.Name = "buttonAfisareCautare";
         this.buttonAfisareCautare.Size = new System.Drawing.Size(118, 23);
         this.buttonAfisareCautare.TabIndex = 4;
         this.buttonAfisareCautare.Text = "Cautare Bicicleta";
         this.buttonAfisareCautare.UseVisualStyleBackColor = false;
         this.buttonAfisareCautare.Click += new System.EventHandler(this.buttonCautare_Click);
         // 
         // buttonInfoAutor
         // 
         this.buttonInfoAutor.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonInfoAutor.Location = new System.Drawing.Point(47, 407);
         this.buttonInfoAutor.Name = "buttonInfoAutor";
         this.buttonInfoAutor.Size = new System.Drawing.Size(118, 23);
         this.buttonInfoAutor.TabIndex = 5;
         this.buttonInfoAutor.Text = "Info Autor";
         this.buttonInfoAutor.UseVisualStyleBackColor = true;
         this.buttonInfoAutor.Click += new System.EventHandler(this.buttonInfoAutor_Click);
         // 
         // labelAutorInfo
         // 
         this.labelAutorInfo.AutoSize = true;
         this.labelAutorInfo.Location = new System.Drawing.Point(176, 426);
         this.labelAutorInfo.Name = "labelAutorInfo";
         this.labelAutorInfo.Size = new System.Drawing.Size(0, 13);
         this.labelAutorInfo.TabIndex = 6;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
         this.panel1.Controls.Add(this.buttonIesire);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(5, 460);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(803, 81);
         this.panel1.TabIndex = 7;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
         this.panel2.Controls.Add(this.labelMeniu);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel2.Location = new System.Drawing.Point(519, 5);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(289, 455);
         this.panel2.TabIndex = 0;
         // 
         // labelMeniu
         // 
         this.labelMeniu.AutoSize = true;
         this.labelMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
         this.labelMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelMeniu.ForeColor = System.Drawing.SystemColors.HighlightText;
         this.labelMeniu.Location = new System.Drawing.Point(83, 223);
         this.labelMeniu.Name = "labelMeniu";
         this.labelMeniu.Size = new System.Drawing.Size(130, 20);
         this.labelMeniu.TabIndex = 8;
         this.labelMeniu.Text = "Meniu Principal";
         // 
         // buttonIesire
         // 
         this.buttonIesire.Location = new System.Drawing.Point(42, 34);
         this.buttonIesire.Name = "buttonIesire";
         this.buttonIesire.Size = new System.Drawing.Size(118, 23);
         this.buttonIesire.TabIndex = 10;
         this.buttonIesire.Text = "Iesire";
         this.buttonIesire.UseVisualStyleBackColor = true;
         this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightCyan;
         this.ClientSize = new System.Drawing.Size(813, 546);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.labelAutorInfo);
         this.Controls.Add(this.buttonInfoAutor);
         this.Controls.Add(this.buttonAfisareCautare);
         this.Controls.Add(this.buttonSalvareFisier);
         this.Controls.Add(this.buttonIncarcareDate);
         this.Controls.Add(this.buttonAfisareBicicleta);
         this.Controls.Add(this.buttonAdaugareBicicleta);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Form1";
         this.Padding = new System.Windows.Forms.Padding(5);
         this.Text = "Meniu";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonAfisareBicicleta;
      private System.Windows.Forms.Button buttonAdaugareBicicleta;
      private System.Windows.Forms.Button buttonIncarcareDate;
      private System.Windows.Forms.Button buttonSalvareFisier;
      private System.Windows.Forms.GroupBox groupBoxCuloare;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
      private System.Windows.Forms.RadioButton radioButtonVerde;
      private System.Windows.Forms.RadioButton radioButtonAlbastru;
      private System.Windows.Forms.RadioButton radioButtonAlb;
      private System.Windows.Forms.Label labelBrand;
      private System.Windows.Forms.Label labelCuloare;
      private System.Windows.Forms.Label labelStoc;
      private System.Windows.Forms.Label labelPret;
      private System.Windows.Forms.Label labelModel;
      private System.Windows.Forms.Label labelTip;
      private System.Windows.Forms.TextBox textBoxBrand;
      private System.Windows.Forms.TextBox textBoxPret;
      private System.Windows.Forms.TextBox textBoxModel;
      private System.Windows.Forms.CheckBox checkBoxStoc;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton radioButtonPliabila;
      private System.Windows.Forms.RadioButton radioButtonMini;
      private System.Windows.Forms.RadioButton radioButtonElectrica;
      private System.Windows.Forms.Button buttonSalvare;
      private System.Windows.Forms.Button buttonAfisareCautare;
      private System.Windows.Forms.TextBox textBoxCautare;
      private System.Windows.Forms.Label labelCautare;
      private System.Windows.Forms.Button buttonCauta;
      private System.Windows.Forms.Button buttonInfoAutor;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.Label labelAutorInfo;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label labelMeniu;
      private System.Windows.Forms.Button buttonIesire;
   }
}

