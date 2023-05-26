using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Magazin_Biciclete
{
   public partial class Form1 : Form
   {
      private MagazinBicicleta _magazinBiciclete;
        private int PAS_Y = 21;
        private const int MAX_LENGHT = 30;
        private HashSet<IDisposable> labels = new HashSet<IDisposable>();
      private bool isPictureVisible = true;
      public Form1(MagazinBicicleta magazinBiciclete)
      {
         InitializeComponent();
         _magazinBiciclete = magazinBiciclete;
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         buttonAfisareBicicleta.FlatStyle = FlatStyle.Flat;
         buttonAdaugareBicicleta.FlatStyle = FlatStyle.Flat;
         buttonAfisareCautare.FlatStyle = FlatStyle.Flat;
         buttonIncarcareDate.FlatStyle = FlatStyle.Flat;
         buttonSalvareFisier.FlatStyle = FlatStyle.Flat;
         buttonInfoAutor.FlatStyle = FlatStyle.Flat;
         buttonExit.FlatStyle = FlatStyle.Flat;
        
         
      }

      private void buttonAfisareBicicleta_Click(object sender, EventArgs e)
      {
          CleanItems();
         var labelId = new System.Windows.Forms.Label();
         var labelBrand = new System.Windows.Forms.Label();
         var labelModel = new System.Windows.Forms.Label();
         var labelPret = new System.Windows.Forms.Label();
         var labelTip = new System.Windows.Forms.Label();
         var labelCuloare = new System.Windows.Forms.Label();
         var labelStoc = new System.Windows.Forms.Label();


         // labelId
         // 
          labelId.AutoSize = true;
         labelId.BackColor = System.Drawing.Color.Transparent;
         labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelId.Location = new System.Drawing.Point(43, 9);
          labelId.Name = "labelId";
          labelId.Size = new System.Drawing.Size(23, 19);
          labelId.TabIndex = 4;
          labelId.Text = "Id";
         // 
         // labelBrand
         // 
          labelBrand.AutoSize = true;
         labelBrand.BackColor = System.Drawing.Color.Transparent;
         labelBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelBrand.Location = new System.Drawing.Point(132, 9);
          labelBrand.Name = "labelBrand";
          labelBrand.Size = new System.Drawing.Size(56, 19);
          labelBrand.TabIndex = 5;
          labelBrand.Text = "Brand";
         // 
         // labelModel
         // 
          labelModel.AutoSize = true;
         labelModel.BackColor = System.Drawing.Color.Transparent;
         labelModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelModel.Location = new System.Drawing.Point(265, 9);
          labelModel.Name = "labelModel";
          labelModel.Size = new System.Drawing.Size(55, 19);
          labelModel.TabIndex = 6;
          labelModel.Text = "Model";
         // 
         // labelPret
         // 
          labelPret.AutoSize = true;
         labelPret.BackColor = System.Drawing.Color.Transparent;
         labelPret.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelPret.Location = new System.Drawing.Point(427, 9);
          labelPret.Name = "labelPret";
          labelPret.Size = new System.Drawing.Size(40, 19);
          labelPret.TabIndex = 7;
          labelPret.Text = "Pret";
         // 
         // labelTip
         // 
          labelTip.AutoSize = true;
         labelTip.BackColor = System.Drawing.Color.Transparent;
         labelTip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelTip.Location = new System.Drawing.Point(1069, 9);
          labelTip.Name = "labelTip";
          labelTip.Size = new System.Drawing.Size(33, 19);
          labelTip.TabIndex = 8;
          labelTip.Text = "Tip";
         // 
         // labelCuloare
         // 
          labelCuloare.AutoSize = true;
         labelCuloare.BackColor = System.Drawing.Color.Transparent;
         labelCuloare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelCuloare.Location = new System.Drawing.Point(805, 9);
          labelCuloare.Name = "labelCuloare";
          labelCuloare.Size = new System.Drawing.Size(69, 19);
          labelCuloare.TabIndex = 9;
          labelCuloare.Text = "Culoare";
         // 
         // labelStoc
         // 
          labelStoc.AutoSize = true;
         labelStoc.BackColor = System.Drawing.Color.Transparent;
         labelStoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          labelStoc.Location = new System.Drawing.Point(588, 9);
          labelStoc.Name = "labelStoc";
          labelStoc.Size = new System.Drawing.Size(44, 19);
          labelStoc.TabIndex = 10;
          labelStoc.Text = "Stoc";

         this.Controls.Add(labelStoc);
         this.Controls.Add(labelCuloare);
         this.Controls.Add(labelTip);
         this.Controls.Add(labelPret);
         this.Controls.Add(labelModel);
         this.Controls.Add(labelBrand);
         this.Controls.Add(labelId);


            this.labels.Add(labelStoc);
            this.labels.Add(labelCuloare);
            this.labels.Add(labelTip);
            this.labels.Add(labelPret);
            this.labels.Add(labelModel);
            this.labels.Add(labelBrand);
            this.labels.Add(labelId);
            var pas_y_current = PAS_Y;

        foreach(var bicicleta in _magazinBiciclete.biciclete)
            {
                labelId = new System.Windows.Forms.Label();
                labelBrand = new System.Windows.Forms.Label();
                labelModel = new System.Windows.Forms.Label();
                labelPret = new System.Windows.Forms.Label();
                labelTip = new System.Windows.Forms.Label();
                labelCuloare = new System.Windows.Forms.Label();
                labelStoc = new System.Windows.Forms.Label();


                // labelId
                // 
                labelId.AutoSize = true;
            labelId.BackColor = System.Drawing.Color.Transparent;
            labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelId.Location = new System.Drawing.Point(43, 9 + pas_y_current);
                labelId.Name = "labelId";
                labelId.Size = new System.Drawing.Size(23, 19 );
                labelId.TabIndex = 4;
                labelId.Text = bicicleta.Id.ToString();
                // 
                // labelBrand
                // 
                labelBrand.AutoSize = true;
                labelBrand.BackColor = System.Drawing.Color.Transparent;
                labelBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelBrand.Location = new System.Drawing.Point(132, 9 + pas_y_current);
                labelBrand.Name = "labelBrand";
                labelBrand.Size = new System.Drawing.Size(56, 19 );
                labelBrand.TabIndex = 5;
                labelBrand.Text = bicicleta.Brand;
                // 
                // labelModel
                // 
                labelModel.AutoSize = true;
            labelModel.BackColor = System.Drawing.Color.Transparent;
            labelModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelModel.Location = new System.Drawing.Point(265, 9 + pas_y_current);
                labelModel.Name = "labelModel";
                labelModel.Size = new System.Drawing.Size(55, 19 );
                labelModel.TabIndex = 6;
                labelModel.Text = bicicleta.Model;
                // 
                // labelPret
                // 
                labelPret.AutoSize = true;
            labelPret.BackColor = System.Drawing.Color.Transparent;
            labelPret.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPret.Location = new System.Drawing.Point(427, 9 + pas_y_current);
                labelPret.Name = "labelPret";
                labelPret.Size = new System.Drawing.Size(40, 19 );
                labelPret.TabIndex = 7;
                labelPret.Text = bicicleta.Pret.ToString();
                // 
                // labelTip
                // 
                labelTip.AutoSize = true;
            labelTip.BackColor = System.Drawing.Color.Transparent;
            labelTip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTip.Location = new System.Drawing.Point(1069, 9 + pas_y_current);
                labelTip.Name = "labelTip";
                labelTip.Size = new System.Drawing.Size(33, 19 );
                labelTip.TabIndex = 8;
                labelTip.Text = bicicleta.TipBicicleta.ToString();
                // 
                // labelCuloare
                // 
                labelCuloare.AutoSize = true;
                  labelCuloare.BackColor = System.Drawing.Color.Transparent;
            labelCuloare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCuloare.Location = new System.Drawing.Point(805, 9 + pas_y_current);
                labelCuloare.Name = "labelCuloare";
                labelCuloare.Size = new System.Drawing.Size(69, 19 );
                labelCuloare.TabIndex = 9;
                labelCuloare.Text = bicicleta.Culoare.ToString();
                // 
                // labelStoc
                // 
                labelStoc.AutoSize = true;
                  labelStoc.BackColor = System.Drawing.Color.Transparent;
            labelStoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelStoc.Location = new System.Drawing.Point(588, 9 + pas_y_current);
                labelStoc.Name = "labelStoc";
                labelStoc.Size = new System.Drawing.Size(44, 19 );
                labelStoc.TabIndex = 10;
                labelStoc.Text = bicicleta.Stoc ? "DA" : "NU";

                this.Controls.Add(labelStoc);
                this.Controls.Add(labelCuloare);
                this.Controls.Add(labelTip);
                this.Controls.Add(labelPret);
                this.Controls.Add(labelModel);
                this.Controls.Add(labelBrand);
                this.Controls.Add(labelId);



                this.labels.Add(labelStoc);
                this.labels.Add(labelCuloare);
                this.labels.Add(labelTip);
                this.labels.Add(labelPret);
                this.labels.Add(labelModel);
                this.labels.Add(labelBrand);
                this.labels.Add(labelId);

                pas_y_current += PAS_Y;
            }
      }
        private void CleanItems()
        {
           
            foreach (var label in labels)
            {
                label.Dispose();
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
      {
            CleanItems();
            _magazinBiciclete.SalveazaBiciclete("biciclete.txt");
            MessageBox.Show("Toate bicicletele au fost salvate in fisier ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      private void buttonAdaugareBicicleta_Click(object sender, EventArgs e)
      {
            CleanItems();
           pictureBoxMagazin.Hide();
         this.groupBoxCuloare = new System.Windows.Forms.GroupBox();
            this.radioButtonAlbastru = new System.Windows.Forms.RadioButton();
            this.radioButtonAlb = new System.Windows.Forms.RadioButton();
            this.radioButtonVerde = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelCuloare = new System.Windows.Forms.Label();
            this.labelStoc = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.checkBoxStoc = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPliabila = new System.Windows.Forms.RadioButton();
            this.radioButtonMini = new System.Windows.Forms.RadioButton();
            this.radioButtonElectrica = new System.Windows.Forms.RadioButton();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.groupBoxCuloare.SuspendLayout();
            this.groupBox1.SuspendLayout();


         // 
         // groupBoxCuloare
         // 
            this.groupBoxCuloare.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCuloare.Controls.Add(this.radioButtonAlbastru);
            this.groupBoxCuloare.Controls.Add(this.radioButtonAlb);
            this.groupBoxCuloare.Controls.Add(this.radioButtonVerde);
            this.groupBoxCuloare.Location = new System.Drawing.Point(297, 57);
            this.groupBoxCuloare.Name = "groupBoxCuloare";
            this.groupBoxCuloare.Size = new System.Drawing.Size(266, 100);
            this.groupBoxCuloare.TabIndex = 4;
            this.groupBoxCuloare.TabStop = false;
            this.groupBoxCuloare.Enter += new System.EventHandler(this.groupBox1_Enter);
         this.groupBoxCuloare.ForeColor = System.Drawing.Color.Silver;
         // 
         // radioButtonAlbastru
         // 
         this.radioButtonAlbastru.AutoSize = true;
            this.radioButtonAlbastru.Location = new System.Drawing.Point(21, 51);
            this.radioButtonAlbastru.Name = "radioButtonAlbastru";
            this.radioButtonAlbastru.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAlbastru.TabIndex = 2;
            this.radioButtonAlbastru.TabStop = true;
            this.radioButtonAlbastru.Text = "Albastru";
            this.radioButtonAlbastru.UseVisualStyleBackColor = true;
         this.radioButtonAlbastru.ForeColor = System.Drawing.Color.Silver;
         // 
         // radioButtonAlb
         // 
         this.radioButtonAlb.AutoSize = true;
            this.radioButtonAlb.Location = new System.Drawing.Point(21, 74);
            this.radioButtonAlb.Name = "radioButtonAlb";
            this.radioButtonAlb.Size = new System.Drawing.Size(40, 17);
            this.radioButtonAlb.TabIndex = 1;
            this.radioButtonAlb.TabStop = true;
            this.radioButtonAlb.Text = "Alb";
            this.radioButtonAlb.UseVisualStyleBackColor = true;
         this.radioButtonAlb.ForeColor = System.Drawing.Color.Silver;
         // 
         // radioButtonVerde
         // 
         this.radioButtonVerde.AutoSize = true;
            this.radioButtonVerde.Location = new System.Drawing.Point(21, 28);
            this.radioButtonVerde.Name = "radioButtonVerde";
            this.radioButtonVerde.Size = new System.Drawing.Size(53, 17);
            this.radioButtonVerde.TabIndex = 0;
            this.radioButtonVerde.TabStop = true;
            this.radioButtonVerde.Text = "Verde";
            this.radioButtonVerde.UseVisualStyleBackColor = true;
         this.radioButtonVerde.ForeColor = System.Drawing.Color.Silver;
         // 
         // labelBrand
         // 
         this.labelBrand.BackColor = System.Drawing.Color.Transparent;
         this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(44, 18);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(35, 13);
            this.labelBrand.TabIndex = 5;
            this.labelBrand.Text = "Brand";
         this.labelBrand.ForeColor = System.Drawing.Color.Silver;
         // 
         // labelCuloare
         // 
         this.labelCuloare.BackColor = System.Drawing.Color.Transparent;
         this.labelCuloare.AutoSize = true;
            this.labelCuloare.Location = new System.Drawing.Point(298, 22);
            this.labelCuloare.Name = "labelCuloare";
            this.labelCuloare.Size = new System.Drawing.Size(43, 13);
            this.labelCuloare.TabIndex = 6;
            this.labelCuloare.Text = "Culoare";
         this.labelCuloare.ForeColor = System.Drawing.Color.Silver;
         // 
         // labelStoc
         // 
         this.labelStoc.BackColor = System.Drawing.Color.Transparent;
         this.labelStoc.AutoSize = true;
            this.labelStoc.Location = new System.Drawing.Point(45, 146);
            this.labelStoc.Name = "labelStoc";
            this.labelStoc.Size = new System.Drawing.Size(29, 13);
            this.labelStoc.TabIndex = 7;
            this.labelStoc.Text = "Stoc";
         this.labelStoc.ForeColor = System.Drawing.Color.Silver;
         // 
         // labelPret
         // 
         this.labelPret.BackColor = System.Drawing.Color.Transparent;
         this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(44, 103);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(26, 13);
            this.labelPret.TabIndex = 8;
            this.labelPret.Text = "Pret";
         this.labelPret.ForeColor = System.Drawing.Color.Silver;
         // 
         // labelModel
         // 
         this.labelModel.BackColor = System.Drawing.Color.Transparent;
         this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(44, 60);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 9;
            this.labelModel.Text = "Model";
         this.labelModel.ForeColor = System.Drawing.Color.Silver;
         // 
         // labelTip
         // 
         this.labelTip.BackColor = System.Drawing.Color.Transparent;
         this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(597, 22);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(22, 13);
            this.labelTip.TabIndex = 10;
            this.labelTip.Text = "Tip";
         this.labelTip.ForeColor = System.Drawing.Color.Silver;
         // 
         // textBoxBrand
         // 

         this.textBoxBrand.Location = new System.Drawing.Point(107, 15);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 11;
         


         // 
         // textBoxPret
         // 
         this.textBoxPret.Location = new System.Drawing.Point(107, 100);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 20);
            this.textBoxPret.TabIndex = 12;
       
         // 
         // textBoxModel
         // 
         this.textBoxModel.Location = new System.Drawing.Point(107, 57);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 13;
       
         // 
         // checkBoxStoc
         // 
         checkBoxStoc.BackColor = System.Drawing.Color.Transparent;
         checkBoxStoc.AutoSize = true;
            checkBoxStoc.Location = new Point(107, 143);
            checkBoxStoc.Name = "checkBoxStoc";
            checkBoxStoc.Size = new Size(235, 24);
            checkBoxStoc.TabIndex = 11;
            checkBoxStoc.Text = "Este in stoc?";
            checkBoxStoc.UseVisualStyleBackColor = true;
         checkBoxStoc.ForeColor = System.Drawing.Color.Silver;



         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Transparent;
         this.groupBox1.Controls.Add(this.radioButtonPliabila);
            this.groupBox1.Controls.Add(this.radioButtonMini);
            this.groupBox1.Controls.Add(this.radioButtonElectrica);
            this.groupBox1.Location = new System.Drawing.Point(600, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
         this.groupBox1.ForeColor = System.Drawing.Color.Silver;
     


         // 
         // radioButtonPliabila
         // 
         this.radioButtonPliabila.AutoSize = true;
            this.radioButtonPliabila.Location = new System.Drawing.Point(21, 51);
            this.radioButtonPliabila.Name = "radioButtonPliabila";
            this.radioButtonPliabila.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPliabila.TabIndex = 2;
            this.radioButtonPliabila.TabStop = true;
            this.radioButtonPliabila.Text = "Pliabila";
            this.radioButtonPliabila.UseVisualStyleBackColor = true;
         this.radioButtonPliabila.ForeColor = System.Drawing.Color.Silver;
         // 
         // radioButtonMini
         // 
         this.radioButtonMini.AutoSize = true;
            this.radioButtonMini.Location = new System.Drawing.Point(21, 74);
            this.radioButtonMini.Name = "radioButtonMini";
            this.radioButtonMini.Size = new System.Drawing.Size(44, 17);
            this.radioButtonMini.TabIndex = 1;
            this.radioButtonMini.TabStop = true;
            this.radioButtonMini.Text = "Mini";
            this.radioButtonMini.UseVisualStyleBackColor = true;
         this.radioButtonMini.ForeColor = System.Drawing.Color.Silver;
         // 
         // radioButtonElectrica
         // 
         this.radioButtonElectrica.AutoSize = true;
            this.radioButtonElectrica.Location = new System.Drawing.Point(21, 28);
            this.radioButtonElectrica.Name = "radioButtonElectrica";
            this.radioButtonElectrica.Size = new System.Drawing.Size(66, 17);
            this.radioButtonElectrica.TabIndex = 0;
            this.radioButtonElectrica.TabStop = true;
            this.radioButtonElectrica.Text = "Electrica";
            this.radioButtonElectrica.UseVisualStyleBackColor = true;
         this.radioButtonElectrica.ForeColor = System.Drawing.Color.Silver;
         // 
         // buttonSalvare
         // 
         this.buttonSalvare.Location = new System.Drawing.Point(107, 187);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvare.TabIndex = 3;
            this.buttonSalvare.Text = "Salvare";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            this.buttonSalvare.Click += new System.EventHandler(this.ButonSalvareClick);
           

         this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxStoc);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelStoc);
            this.Controls.Add(this.labelCuloare);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.groupBoxCuloare);

            this.groupBoxCuloare.ResumeLayout(false);
            this.groupBoxCuloare.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();


            this.labels.Add(this.buttonSalvare);
            this.labels.Add(this.groupBox1);
            this.labels.Add(this.checkBoxStoc);
            this.labels.Add(this.textBoxModel);
            this.labels.Add(this.textBoxPret);
            this.labels.Add(this.textBoxBrand);
            this.labels.Add(this.labelTip);
            this.labels.Add(this.labelModel);
            this.labels.Add(this.labelPret);
            this.labels.Add(this.labelStoc);
            this.labels.Add(this.labelCuloare);
            this.labels.Add(this.labelBrand);
            this.labels.Add(this.groupBoxCuloare);
        }

      

      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }
        private void ButonSalvareClick(object sender, EventArgs e)
        {
            string brand = string.Empty;
            string model = string.Empty;
            double pret =  0;
            bool stoc =  true;
            Culoare culoare =  0;
            Tip tip = 0;


            if(string.IsNullOrEmpty(textBoxBrand.Text))
            {
                MessageBox.Show("Va rugam introduceti brandul inainte de salvare ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if( textBoxBrand.Text.Length > MAX_LENGHT)
            {
                MessageBox.Show("Prea lung brandul ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            brand = textBoxBrand.Text;
            //Model
           
            if (string.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Va rugam introduceti modelul inainte de salvare ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxModel.Text.Length > MAX_LENGHT)
            {
                MessageBox.Show("Prea lung modelul ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            model = textBoxModel.Text;

            //pret
            var result = double.TryParse(textBoxPret.Text, out pret);
            if(!result)
            {
                MessageBox.Show("Va rugam introduceti un numar pentru pret. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxPret.Text))
            {
                MessageBox.Show("Va rugam introduceti pretul inainte de salvare ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stoc = checkBoxStoc.Checked;

            //culoare
            if(radioButtonVerde.Checked)
            {
                culoare = Culoare.Verde;
            }
            else if(radioButtonAlbastru.Checked) 
            {
                culoare = Culoare.Albastru;
            }

            else if (radioButtonAlb.Checked)
            {
                culoare = Culoare.Alb;
            }
            else
            {
                MessageBox.Show("Va rugam selectati o culoare ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tip bicicleta
            if (radioButtonPliabila.Checked)
            {
                tip = Tip.Pliabila;
            }
            else if (radioButtonElectrica.Checked)
            {

                tip = Tip.Electrica;
            }

            else if (radioButtonMini.Checked)
            {

                tip = Tip.Mini;
            }
            else
            {
                MessageBox.Show("Va rugam selectati un tip  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bicicletanoua = new Bicicleta(brand, model, pret, stoc, culoare, tip);
            _magazinBiciclete.AdaugaBicicleta(bicicletanoua);
            MessageBox.Show("Bicicleta a fost adaugata ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanItems();
        }

      private void buttonIncarcareDate_Click(object sender, EventArgs e)
      {
            CleanItems();
            _magazinBiciclete.ReadBicyclesFromFile("biciclete.txt");
            MessageBox.Show("Bicicletele au fost incarcate  din fisier ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      private void buttonCautare_Click(object sender, EventArgs e)
      {
            //buton afisare textBox cautare
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.labelCautare = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();

            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(197, 264);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(100, 20);
            this.textBoxCautare.TabIndex = 5;
         // 
         // labelCautare
         // 
         this.labelCautare.BackColor = System.Drawing.Color.Transparent;
         this.labelCautare.AutoSize = true;
            this.labelCautare.Location = new System.Drawing.Point(312, 267);
            this.labelCautare.Name = "labelCautare";
            this.labelCautare.Size = new System.Drawing.Size(161, 13);
            this.labelCautare.TabIndex = 6;
            this.labelCautare.Text = "Introduceti datele pentru cautare";
             this.labelCautare.ForeColor = System.Drawing.Color.Silver;
         // 
         // buttonCauta
         // 
         this.buttonCauta.Location = new System.Drawing.Point(492, 262);
         this.buttonCauta.Name = "buttonCauta";
         this.buttonCauta.Size = new System.Drawing.Size(118, 23);
         this.buttonCauta.TabIndex = 7;
         this.buttonCauta.Text = "Cauta";
         this.buttonCauta.ForeColor = System.Drawing.Color.DarkRed;
         this.buttonCauta.BackColor = System.Drawing.Color.LightSteelBlue;
         this.buttonCauta.UseVisualStyleBackColor = false;
         this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.buttonCauta.FlatAppearance.BorderSize = 0;
         this.buttonCauta.Cursor = System.Windows.Forms.Cursors.Hand;
         this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);



         this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.labelCautare);
            this.Controls.Add(this.textBoxCautare);

            this.labels.Add(this.buttonCauta);
            this.labels.Add(this.labelCautare);
            this.labels.Add(this.textBoxCautare);
        }

        private void buttonCauta_Click(object sender, EventArgs e)
      {
            //buton cautare
            var criteria = textBoxCautare.Text;
            CleanItems();
            //buton afisare textBox cautare
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.labelCautare = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();

            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(197, 264);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(100, 20);
            this.textBoxCautare.TabIndex = 5;
         // 
         // labelCautare
         // 
         this.labelCautare.BackColor = System.Drawing.Color.Transparent;
         this.labelCautare.AutoSize = true;
            this.labelCautare.Location = new System.Drawing.Point(312, 267);
            this.labelCautare.Name = "labelCautare";
            this.labelCautare.Size = new System.Drawing.Size(161, 13);
            this.labelCautare.TabIndex = 6;
            this.labelCautare.Text = "Introduceti datele pentru cautare";
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(492, 262);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(118, 23);
            this.buttonCauta.TabIndex = 7;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);

            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.labelCautare);
            this.Controls.Add(this.textBoxCautare);

            this.labels.Add(this.buttonCauta);
            this.labels.Add(this.labelCautare);
            this.labels.Add(this.textBoxCautare);

            
            var labelId = new System.Windows.Forms.Label();
            var labelBrand = new System.Windows.Forms.Label();
            var labelModel = new System.Windows.Forms.Label();
            var labelPret = new System.Windows.Forms.Label();
            var labelTip = new System.Windows.Forms.Label();
            var labelCuloare = new System.Windows.Forms.Label();
            var labelStoc = new System.Windows.Forms.Label();


         // labelId
         // 
         labelId.BackColor = System.Drawing.Color.Transparent;
         labelId.AutoSize = true;
            labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelId.Location = new System.Drawing.Point(43, 9);
            labelId.Name = "labelId";
            labelId.Size = new System.Drawing.Size(23, 19);
            labelId.TabIndex = 4;
            labelId.Text = "Id";
         // 
         // labelBrand
         // 
         labelBrand.BackColor = System.Drawing.Color.Transparent;
         labelBrand.AutoSize = true;
            labelBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelBrand.Location = new System.Drawing.Point(132, 9);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new System.Drawing.Size(56, 19);
            labelBrand.TabIndex = 5;
            labelBrand.Text = "Brand";
         // 
         // labelModel
         // 
         labelModel.BackColor = System.Drawing.Color.Transparent;
         labelModel.AutoSize = true;
            labelModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelModel.Location = new System.Drawing.Point(265, 9);
            labelModel.Name = "labelModel";
            labelModel.Size = new System.Drawing.Size(55, 19);
            labelModel.TabIndex = 6;
            labelModel.Text = "Model";
         // 
         // labelPret
         // 
         labelPret.BackColor = System.Drawing.Color.Transparent;
         labelPret.AutoSize = true;
            labelPret.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPret.Location = new System.Drawing.Point(427, 9);
            labelPret.Name = "labelPret";
            labelPret.Size = new System.Drawing.Size(40, 19);
            labelPret.TabIndex = 7;
            labelPret.Text = "Pret";
         // 
         // labelTip
         // 
         labelTip.BackColor = System.Drawing.Color.Transparent;
         labelTip.AutoSize = true;
            labelTip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTip.Location = new System.Drawing.Point(1069, 9);
            labelTip.Name = "labelTip";
            labelTip.Size = new System.Drawing.Size(33, 19);
            labelTip.TabIndex = 8;
            labelTip.Text = "Tip";
         // 
         // labelCuloare
         // 
         labelCuloare.BackColor = System.Drawing.Color.Transparent;
         labelCuloare.AutoSize = true;
            labelCuloare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCuloare.Location = new System.Drawing.Point(805, 9);
            labelCuloare.Name = "labelCuloare";
            labelCuloare.Size = new System.Drawing.Size(69, 19);
            labelCuloare.TabIndex = 9;
            labelCuloare.Text = "Culoare";
         // 
         // labelStoc
         // 
         labelStoc.BackColor = System.Drawing.Color.Transparent;
         labelStoc.AutoSize = true;
            labelStoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStoc.Location = new System.Drawing.Point(588, 9);
            labelStoc.Name = "labelStoc";
            labelStoc.Size = new System.Drawing.Size(44, 19);
            labelStoc.TabIndex = 10;
            labelStoc.Text = "Stoc";

            this.Controls.Add(labelStoc);
            this.Controls.Add(labelCuloare);
            this.Controls.Add(labelTip);
            this.Controls.Add(labelPret);
            this.Controls.Add(labelModel);
            this.Controls.Add(labelBrand);
            this.Controls.Add(labelId);


            this.labels.Add(labelStoc);
            this.labels.Add(labelCuloare);
            this.labels.Add(labelTip);
            this.labels.Add(labelPret);
            this.labels.Add(labelModel);
            this.labels.Add(labelBrand);
            this.labels.Add(labelId);
            var pas_y_current = PAS_Y;

            foreach (var bicicleta in _magazinBiciclete.SearchBiciclete(criteria)) 
            {
                labelId = new System.Windows.Forms.Label();
                labelBrand = new System.Windows.Forms.Label();
                labelModel = new System.Windows.Forms.Label();
                labelPret = new System.Windows.Forms.Label();
                labelTip = new System.Windows.Forms.Label();
                labelCuloare = new System.Windows.Forms.Label();
                labelStoc = new System.Windows.Forms.Label();


            // labelId
            // 
            labelId.BackColor = System.Drawing.Color.Transparent;
            labelId.AutoSize = true;
                labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelId.Location = new System.Drawing.Point(43, 9 + pas_y_current);
                labelId.Name = "labelId";
                labelId.Size = new System.Drawing.Size(23, 19);
                labelId.TabIndex = 4;
                labelId.Text = bicicleta.Id.ToString();
            // 
            // labelBrand
            // 
            labelBrand.BackColor = System.Drawing.Color.Transparent;
            labelBrand.AutoSize = true;
                labelBrand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelBrand.Location = new System.Drawing.Point(132, 9 + pas_y_current);
                labelBrand.Name = "labelBrand";
                labelBrand.Size = new System.Drawing.Size(56, 19);
                labelBrand.TabIndex = 5;
                labelBrand.Text = bicicleta.Brand;
            // 
            // labelModel
            // 
            labelModel.BackColor = System.Drawing.Color.Transparent;
            labelModel.AutoSize = true;
                labelModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelModel.Location = new System.Drawing.Point(265, 9 + pas_y_current);
                labelModel.Name = "labelModel";
                labelModel.Size = new System.Drawing.Size(55, 19);
                labelModel.TabIndex = 6;
                labelModel.Text = bicicleta.Model;
            // 
            // labelPret
            // 
            labelPret.BackColor = System.Drawing.Color.Transparent;
            labelPret.AutoSize = true;
                labelPret.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPret.Location = new System.Drawing.Point(427, 9 + pas_y_current);
                labelPret.Name = "labelPret";
                labelPret.Size = new System.Drawing.Size(40, 19);
                labelPret.TabIndex = 7;
                labelPret.Text = bicicleta.Pret.ToString();
            // 
            // labelTip
            // 
            labelTip.BackColor = System.Drawing.Color.Transparent;
            labelTip.AutoSize = true;
                labelTip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTip.Location = new System.Drawing.Point(1069, 9 + pas_y_current);
                labelTip.Name = "labelTip";
                labelTip.Size = new System.Drawing.Size(33, 19);
                labelTip.TabIndex = 8;
                labelTip.Text = bicicleta.TipBicicleta.ToString();
            // 
            // labelCuloare
            // 
            labelCuloare.BackColor = System.Drawing.Color.Transparent;
            labelCuloare.AutoSize = true;
                labelCuloare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCuloare.Location = new System.Drawing.Point(805, 9 + pas_y_current);
                labelCuloare.Name = "labelCuloare";
                labelCuloare.Size = new System.Drawing.Size(69, 19);
                labelCuloare.TabIndex = 9;
                labelCuloare.Text = bicicleta.Culoare.ToString();
            // 
            // labelStoc
            // 
            labelStoc.BackColor = System.Drawing.Color.Transparent;
            labelStoc.AutoSize = true;
                labelStoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelStoc.Location = new System.Drawing.Point(588, 9 + pas_y_current);
                labelStoc.Name = "labelStoc";
                labelStoc.Size = new System.Drawing.Size(44, 19);
                labelStoc.TabIndex = 10;
                labelStoc.Text = bicicleta.Stoc ? "DA" : "NU";

                this.Controls.Add(labelStoc);
                this.Controls.Add(labelCuloare);
                this.Controls.Add(labelTip);
                this.Controls.Add(labelPret);
                this.Controls.Add(labelModel);
                this.Controls.Add(labelBrand);
                this.Controls.Add(labelId);



                this.labels.Add(labelStoc);
                this.labels.Add(labelCuloare);
                this.labels.Add(labelTip);
                this.labels.Add(labelPret);
                this.labels.Add(labelModel);
                this.labels.Add(labelBrand);
                this.labels.Add(labelId);

                pas_y_current += PAS_Y;
            }
        

    }

      private void buttonInfoAutor_Click(object sender, EventArgs e)
      {
       
         // Arata notificare prin ToolTip COntrol
         toolTip1.Show("Sectiune cu Informatii despre autor", buttonInfoAutor, 0, -50, 3000); // Afiseaza notificarea pentru 3 secunde
                                                           
         labelAutorInfo.Visible = !labelAutorInfo.Visible;

         // Seteaza textul din label cand e vizibil
         if (labelAutorInfo.Visible)
         {
            labelAutorInfo.Text = "Program Realizat de Roman Petrica";
         }
      }


      private void buttonExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void pictureBoxMagazin_Click(object sender, EventArgs e)
      {
         pictureBoxMagazin = new System.Windows.Forms.PictureBox();
         pictureBoxMagazin.Location = new System.Drawing.Point(10, 10);
         pictureBoxMagazin.Size = new System.Drawing.Size(200, 200);
         pictureBoxMagazin.Image = Image.FromFile("\"C:\\Users\\petri\\Downloads\\wallpaperflare.com_wallpaper (2).jpg\"");

      }
   }
}
