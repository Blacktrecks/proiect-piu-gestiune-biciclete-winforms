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
            this.buttonAfisareBicicleta = new System.Windows.Forms.Button();
            this.buttonAdaugareBicicleta = new System.Windows.Forms.Button();
            this.buttonIncarcareDate = new System.Windows.Forms.Button();
            this.buttonSalvareFisier = new System.Windows.Forms.Button();
            this.buttonAfisareCautare = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // buttonAfisareBicicleta
            // 
            this.buttonAfisareBicicleta.Location = new System.Drawing.Point(47, 358);
            this.buttonAfisareBicicleta.Name = "buttonAfisareBicicleta";
            this.buttonAfisareBicicleta.Size = new System.Drawing.Size(118, 23);
            this.buttonAfisareBicicleta.TabIndex = 0;
            this.buttonAfisareBicicleta.Text = "Afisare";
            this.buttonAfisareBicicleta.UseVisualStyleBackColor = true;
            this.buttonAfisareBicicleta.Click += new System.EventHandler(this.buttonAfisareBicicleta_Click);
            // 
            // buttonAdaugareBicicleta
            // 
            this.buttonAdaugareBicicleta.Location = new System.Drawing.Point(47, 300);
            this.buttonAdaugareBicicleta.Name = "buttonAdaugareBicicleta";
            this.buttonAdaugareBicicleta.Size = new System.Drawing.Size(118, 23);
            this.buttonAdaugareBicicleta.TabIndex = 1;
            this.buttonAdaugareBicicleta.Text = "Adaugare Bicicleta";
            this.buttonAdaugareBicicleta.UseVisualStyleBackColor = true;
            this.buttonAdaugareBicicleta.Click += new System.EventHandler(this.buttonAdaugareBicicleta_Click);
            // 
            // buttonIncarcareDate
            // 
            this.buttonIncarcareDate.Location = new System.Drawing.Point(47, 387);
            this.buttonIncarcareDate.Name = "buttonIncarcareDate";
            this.buttonIncarcareDate.Size = new System.Drawing.Size(118, 23);
            this.buttonIncarcareDate.TabIndex = 2;
            this.buttonIncarcareDate.Text = "Incarcare Date";
            this.buttonIncarcareDate.UseVisualStyleBackColor = true;
            this.buttonIncarcareDate.Click += new System.EventHandler(this.buttonIncarcareDate_Click);
            // 
            // buttonSalvareFisier
            // 
            this.buttonSalvareFisier.Location = new System.Drawing.Point(47, 329);
            this.buttonSalvareFisier.Name = "buttonSalvareFisier";
            this.buttonSalvareFisier.Size = new System.Drawing.Size(122, 23);
            this.buttonSalvareFisier.TabIndex = 3;
            this.buttonSalvareFisier.Text = "Salvare Bicicleta";
            this.buttonSalvareFisier.UseVisualStyleBackColor = true;
            this.buttonSalvareFisier.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonCautare
            // 
            this.buttonAfisareCautare.Location = new System.Drawing.Point(47, 262);
            this.buttonAfisareCautare.Name = "buttonCautare";
            this.buttonAfisareCautare.Size = new System.Drawing.Size(118, 23);
            this.buttonAfisareCautare.TabIndex = 4;
            this.buttonAfisareCautare.Text = "Cautare Bicicleta";
            this.buttonAfisareCautare.UseVisualStyleBackColor = true;
            this.buttonAfisareCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
           
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 450);
           
            this.Controls.Add(this.buttonAfisareCautare);
            this.Controls.Add(this.buttonSalvareFisier);
            this.Controls.Add(this.buttonIncarcareDate);
            this.Controls.Add(this.buttonAdaugareBicicleta);
            this.Controls.Add(this.buttonAfisareBicicleta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
   }
}

