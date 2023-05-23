
namespace Farmacie
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
            this.buttonAdaugaMedicament = new System.Windows.Forms.Button();
            this.buttonAfiseazaMedicamente = new System.Windows.Forms.Button();
            this.buttonCauta_Medicament = new System.Windows.Forms.Button();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonIncarcare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdaugaMedicament
            // 
            this.buttonAdaugaMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdaugaMedicament.Location = new System.Drawing.Point(21, 30);
            this.buttonAdaugaMedicament.Name = "buttonAdaugaMedicament";
            this.buttonAdaugaMedicament.Size = new System.Drawing.Size(167, 34);
            this.buttonAdaugaMedicament.TabIndex = 0;
            this.buttonAdaugaMedicament.Text = "Adauga Medicament";
            this.buttonAdaugaMedicament.UseVisualStyleBackColor = false;
            this.buttonAdaugaMedicament.Click += new System.EventHandler(this.buttonAdaugaMedicament_Click);
            // 
            // buttonAfiseazaMedicamente
            // 
            this.buttonAfiseazaMedicamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAfiseazaMedicamente.Location = new System.Drawing.Point(21, 110);
            this.buttonAfiseazaMedicamente.Name = "buttonAfiseazaMedicamente";
            this.buttonAfiseazaMedicamente.Size = new System.Drawing.Size(167, 34);
            this.buttonAfiseazaMedicamente.TabIndex = 1;
            this.buttonAfiseazaMedicamente.Text = "Afiseaza Medicamente";
            this.buttonAfiseazaMedicamente.UseVisualStyleBackColor = false;
            this.buttonAfiseazaMedicamente.Click += new System.EventHandler(this.buttonAfiseazaMedicamente_Click);
            // 
            // buttonCauta_Medicament
            // 
            this.buttonCauta_Medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCauta_Medicament.Location = new System.Drawing.Point(21, 190);
            this.buttonCauta_Medicament.Name = "buttonCauta_Medicament";
            this.buttonCauta_Medicament.Size = new System.Drawing.Size(167, 34);
            this.buttonCauta_Medicament.TabIndex = 2;
            this.buttonCauta_Medicament.Text = "Cauta Medicament";
            this.buttonCauta_Medicament.UseVisualStyleBackColor = false;
            this.buttonCauta_Medicament.Click += new System.EventHandler(this.buttonCauta_Medicament_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSalvare.Location = new System.Drawing.Point(21, 285);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(167, 34);
            this.buttonSalvare.TabIndex = 3;
            this.buttonSalvare.Text = "Salvare Medicamente";
            this.buttonSalvare.UseVisualStyleBackColor = false;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonIncarcare
            // 
            this.buttonIncarcare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonIncarcare.Location = new System.Drawing.Point(21, 375);
            this.buttonIncarcare.Name = "buttonIncarcare";
            this.buttonIncarcare.Size = new System.Drawing.Size(167, 34);
            this.buttonIncarcare.TabIndex = 4;
            this.buttonIncarcare.Text = "Incarcare Medicamente";
            this.buttonIncarcare.UseVisualStyleBackColor = false;
            this.buttonIncarcare.Click += new System.EventHandler(this.buttonIncarcare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Farmacie.Properties.Resources._220px_Pharmacy_Green_Cross_svg;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
             
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1144, 491);
           
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonIncarcare);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.buttonCauta_Medicament);
            this.Controls.Add(this.buttonAfiseazaMedicamente);
            this.Controls.Add(this.buttonAdaugaMedicament);
            this.Name = "Form1";
            this.Text = "Farmacia Inimii";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdaugaMedicament;
        private System.Windows.Forms.Button buttonAfiseazaMedicamente;
        private System.Windows.Forms.Button buttonCauta_Medicament;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonIncarcare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdaugaNume;
        private System.Windows.Forms.TextBox textBoxNumeMedicament;
        private System.Windows.Forms.TextBox textBoxAgaudaCantitate;
        private System.Windows.Forms.Label labelAdaugaCantitate;
        private System.Windows.Forms.GroupBox groupBoxCategorievarsta;
        private System.Windows.Forms.RadioButton radioButtonVarstnici;
        private System.Windows.Forms.RadioButton radioButtonBebelusi;
        private System.Windows.Forms.RadioButton radiobuttonAdulti;
        private System.Windows.Forms.RadioButton radioButtonCopii;
        private System.Windows.Forms.CheckBox checkBoxStoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdaugaMed;
        private System.Windows.Forms.Label labelcauta;
        private System.Windows.Forms.TextBox textBoxCauta;
        private System.Windows.Forms.Button buttonCauta;
    }
}

