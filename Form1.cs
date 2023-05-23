using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacie
{
    public partial class Form1 : Form
    {
        private readonly Farmacie _farmacie;
        private int dimensiune_pass_y=27;
        private int dimensiuneSirMax = 30;
        private List<IDisposable> componenteCurente = new List<IDisposable>();
        public Form1(Farmacie farmacie)
        {
            InitializeComponent();
            _farmacie = farmacie;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAfiseazaMedicamente_Click(object sender, EventArgs e)
        {
            curataEcran();
            var labelID = new System.Windows.Forms.Label();
            var labelNume = new System.Windows.Forms.Label();
            var labelCantitate = new System.Windows.Forms.Label();
            var labelCategorieVarsta = new System.Windows.Forms.Label();
            var labelStoc = new System.Windows.Forms.Label();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelID.Location = new System.Drawing.Point(275, 30);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(33, 25);
            labelID.TabIndex = 6;
            labelID.Text = "ID";
            labelID.Click += new System.EventHandler(label1_Click);
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNume.Location = new System.Drawing.Point(349, 30);
            labelNume.Name = "labelNume";
            labelNume.Size = new System.Drawing.Size(68, 25);
            labelNume.TabIndex = 7;
            labelNume.Text = "Nume";
            // 
            // labelCantitate
            // 
            labelCantitate.AutoSize = true;
            labelCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCantitate.Location = new System.Drawing.Point(529, 30);
            labelCantitate.Name = "labelCantitate";
            labelCantitate.Size = new System.Drawing.Size(99, 25);
            labelCantitate.TabIndex = 8;
            labelCantitate.Text = "Cantitate";
            // 
            // labelCategorieVarsta
            // 
            labelCategorieVarsta.AutoSize = true;
            labelCategorieVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCategorieVarsta.Location = new System.Drawing.Point(654, 30);
            labelCategorieVarsta.Name = "labelCategorieVarsta";
            labelCategorieVarsta.Size = new System.Drawing.Size(175, 25);
            labelCategorieVarsta.TabIndex = 9;
            labelCategorieVarsta.Text = "Categorie Varsta";
            // 
            // labelStoc
            // 
            labelStoc.AutoSize = true;
            labelStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStoc.Location = new System.Drawing.Point(844, 30);
            labelStoc.Name = "labelStoc";
            labelStoc.Size = new System.Drawing.Size(80, 25);
            labelStoc.TabIndex = 10;
            labelStoc.Text = "In Stoc";
            //adauga componentele pe formular
            Controls.Add(labelStoc);
            Controls.Add(labelCategorieVarsta);
            Controls.Add(labelCantitate);
            Controls.Add(labelNume);
            Controls.Add(labelID);
            
            
            componenteCurente.Add(labelStoc);
            componenteCurente.Add(labelCategorieVarsta);
            componenteCurente.Add(labelCantitate);
            componenteCurente.Add(labelNume);
            componenteCurente.Add(labelID);

            var pass_y_curent = dimensiune_pass_y ;
            foreach(Medicament medicament in _farmacie.medicamente)
            {
                labelID = new System.Windows.Forms.Label();
                labelNume = new System.Windows.Forms.Label();
                labelCantitate = new System.Windows.Forms.Label();
                labelCategorieVarsta = new System.Windows.Forms.Label();
                labelStoc = new System.Windows.Forms.Label();
                // 
                // labelID
                // 
                labelID.AutoSize = true;
                labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelID.Location = new System.Drawing.Point(275, 30+pass_y_curent);
                labelID.Name = "labelID";
                labelID.Size = new System.Drawing.Size(33, 25);
                labelID.TabIndex = 6;
                labelID.Text = medicament.IdMedicament.ToString() ;
                labelID.Click += new System.EventHandler(label1_Click);
                // 
                // labelNume
                // 
                labelNume.AutoSize = true;
                labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelNume.Location = new System.Drawing.Point(349, 30 + pass_y_curent);
                labelNume.Name = "labelNume";
                labelNume.Size = new System.Drawing.Size(68, 25);
                labelNume.TabIndex = 7;
                labelNume.Text = medicament.Nume;
                // 
                // labelCantitate
                // 
                labelCantitate.AutoSize = true;
                labelCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCantitate.Location = new System.Drawing.Point(529, 30 + pass_y_curent);
                labelCantitate.Name = "labelCantitate";
                labelCantitate.Size = new System.Drawing.Size(99, 25);
                labelCantitate.TabIndex = 8;
                labelCantitate.Text = medicament.Cantitate.ToString();
                // 
                // labelCategorieVarsta
                // 
                labelCategorieVarsta.AutoSize = true;
                labelCategorieVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCategorieVarsta.Location = new System.Drawing.Point(654, 30 + pass_y_curent);
                labelCategorieVarsta.Name = "labelCategorieVarsta";
                labelCategorieVarsta.Size = new System.Drawing.Size(175, 25);
                labelCategorieVarsta.TabIndex = 9;
                labelCategorieVarsta.Text = medicament.CategorieVarsta;
                // 
                // labelStoc
                // 
                labelStoc.AutoSize = true;
                labelStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelStoc.Location = new System.Drawing.Point(844, 30 + pass_y_curent);
                labelStoc.Name = "labelStoc";
                labelStoc.Size = new System.Drawing.Size(80, 25);
                labelStoc.TabIndex = 10;
                labelStoc.Text = medicament.InStoc.ToString();
                pass_y_curent += dimensiune_pass_y;
                //adauga componentele pe formular
                Controls.Add(labelStoc);
                Controls.Add(labelCategorieVarsta);
                Controls.Add(labelCantitate);
                Controls.Add(labelNume);
                Controls.Add(labelID);

                componenteCurente.Add(labelStoc);
                componenteCurente.Add(labelCategorieVarsta);
                componenteCurente.Add(labelCantitate);
                componenteCurente.Add(labelNume);
                componenteCurente.Add(labelID);
            }
        }

        private void buttonAdaugaMedicament_Click(object sender, EventArgs e)
        {
            curataEcran();
            this.labelAdaugaNume = new System.Windows.Forms.Label();
            this.textBoxNumeMedicament = new System.Windows.Forms.TextBox();
            this.textBoxAgaudaCantitate = new System.Windows.Forms.TextBox();
            this.labelAdaugaCantitate = new System.Windows.Forms.Label();
            this.groupBoxCategorievarsta = new System.Windows.Forms.GroupBox();
            this.radioButtonCopii = new System.Windows.Forms.RadioButton();
            this.radiobuttonAdulti = new System.Windows.Forms.RadioButton();
            this.radioButtonBebelusi = new System.Windows.Forms.RadioButton();
            this.radioButtonVarstnici = new System.Windows.Forms.RadioButton();
            this.checkBoxStoc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdaugaMed = new System.Windows.Forms.Button();
            this.groupBoxCategorievarsta.SuspendLayout();
            // 
            // labelAdaugaNume
            // 
            this.labelAdaugaNume.AutoSize = true;
            this.labelAdaugaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdaugaNume.Location = new System.Drawing.Point(229, 30);
            this.labelAdaugaNume.Name = "labelAdaugaNume";
            this.labelAdaugaNume.Size = new System.Drawing.Size(176, 25);
            this.labelAdaugaNume.TabIndex = 6;
            this.labelAdaugaNume.Text = "Nume Medicament";
            // 
            // textBoxNumeMedicament
            // 
            this.textBoxNumeMedicament.Location = new System.Drawing.Point(234, 58);
            this.textBoxNumeMedicament.Multiline = true;
            this.textBoxNumeMedicament.Name = "textBoxNumeMedicament";
            this.textBoxNumeMedicament.Size = new System.Drawing.Size(171, 38);
            this.textBoxNumeMedicament.TabIndex = 7;
            // 
            // textBoxAgaudaCantitate
            // 
            this.textBoxAgaudaCantitate.Location = new System.Drawing.Point(234, 161);
            this.textBoxAgaudaCantitate.Multiline = true;
            this.textBoxAgaudaCantitate.Name = "textBoxAgaudaCantitate";
            this.textBoxAgaudaCantitate.Size = new System.Drawing.Size(171, 38);
            this.textBoxAgaudaCantitate.TabIndex = 9;
            this.textBoxAgaudaCantitate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelAdaugaCantitate
            // 
            this.labelAdaugaCantitate.AutoSize = true;
            this.labelAdaugaCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdaugaCantitate.Location = new System.Drawing.Point(229, 133);
            this.labelAdaugaCantitate.Name = "labelAdaugaCantitate";
            this.labelAdaugaCantitate.Size = new System.Drawing.Size(202, 25);
            this.labelAdaugaCantitate.TabIndex = 8;
            this.labelAdaugaCantitate.Text = "Cantitate Medicament";
            this.labelAdaugaCantitate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBoxCategorievarsta
            // 
            this.groupBoxCategorievarsta.Controls.Add(this.radioButtonVarstnici);
            this.groupBoxCategorievarsta.Controls.Add(this.radioButtonBebelusi);
            this.groupBoxCategorievarsta.Controls.Add(this.radiobuttonAdulti);
            this.groupBoxCategorievarsta.Controls.Add(this.radioButtonCopii);
            this.groupBoxCategorievarsta.Location = new System.Drawing.Point(234, 240);
            this.groupBoxCategorievarsta.Name = "groupBoxCategorievarsta";
            this.groupBoxCategorievarsta.Size = new System.Drawing.Size(214, 134);
            this.groupBoxCategorievarsta.TabIndex = 10;
            this.groupBoxCategorievarsta.TabStop = false;
            this.groupBoxCategorievarsta.Text = "Categorie Varsta";
            this.groupBoxCategorievarsta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonCopii
            // 
            this.radioButtonCopii.AutoSize = true;
            this.radioButtonCopii.Location = new System.Drawing.Point(23, 55);
            this.radioButtonCopii.Name = "radioButtonCopii";
            this.radioButtonCopii.Size = new System.Drawing.Size(60, 21);
            this.radioButtonCopii.TabIndex = 0;
            this.radioButtonCopii.TabStop = true;
            this.radioButtonCopii.Text = "Copii";
            this.radioButtonCopii.UseVisualStyleBackColor = true;
            // 
            // radiobuttonAdulti
            // 
            this.radiobuttonAdulti.AutoSize = true;
            this.radiobuttonAdulti.Location = new System.Drawing.Point(23, 82);
            this.radiobuttonAdulti.Name = "radiobuttonAdulti";
            this.radiobuttonAdulti.Size = new System.Drawing.Size(64, 21);
            this.radiobuttonAdulti.TabIndex = 1;
            this.radiobuttonAdulti.TabStop = true;
            this.radiobuttonAdulti.Text = "Adulti";
            this.radiobuttonAdulti.UseVisualStyleBackColor = true;
            // 
            // radioButtonBebelusi
            // 
            this.radioButtonBebelusi.AutoSize = true;
            this.radioButtonBebelusi.Location = new System.Drawing.Point(23, 28);
            this.radioButtonBebelusi.Name = "radioButtonBebelusi";
            this.radioButtonBebelusi.Size = new System.Drawing.Size(83, 21);
            this.radioButtonBebelusi.TabIndex = 2;
            this.radioButtonBebelusi.TabStop = true;
            this.radioButtonBebelusi.Text = "Bebelusi";
            this.radioButtonBebelusi.UseVisualStyleBackColor = true;
            // 
            // radioButtonVarstnici
            // 
            this.radioButtonVarstnici.AutoSize = true;
            this.radioButtonVarstnici.Location = new System.Drawing.Point(23, 109);
            this.radioButtonVarstnici.Name = "radioButtonVarstnici";
            this.radioButtonVarstnici.Size = new System.Drawing.Size(83, 21);
            this.radioButtonVarstnici.TabIndex = 3;
            this.radioButtonVarstnici.TabStop = true;
            this.radioButtonVarstnici.Text = "Varstnici";
            this.radioButtonVarstnici.UseVisualStyleBackColor = true;
            // 
            // checkBoxStoc
            // 
            this.checkBoxStoc.AutoSize = true;
            this.checkBoxStoc.Location = new System.Drawing.Point(248, 407);
            this.checkBoxStoc.Name = "checkBoxStoc";
            this.checkBoxStoc.Size = new System.Drawing.Size(73, 21);
            this.checkBoxStoc.TabIndex = 11;
            this.checkBoxStoc.Text = "In Stoc";
            this.checkBoxStoc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAdaugaMed
            // 
            this.buttonAdaugaMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAdaugaMed.Location = new System.Drawing.Point(242, 434);
            this.buttonAdaugaMed.Name = "buttonAdaugaMed";
            this.buttonAdaugaMed.Size = new System.Drawing.Size(79, 45);
            this.buttonAdaugaMed.TabIndex = 13;
            this.buttonAdaugaMed.Text = "Adauga!";
            this.buttonAdaugaMed.UseVisualStyleBackColor = false;
            this.buttonAdaugaMed.Click += new System.EventHandler(this.buttonAdaugaMed_Click);
            this.Controls.Add(this.buttonAdaugaMed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxStoc);
            this.Controls.Add(this.groupBoxCategorievarsta);
            this.Controls.Add(this.textBoxAgaudaCantitate);
            this.Controls.Add(this.labelAdaugaCantitate);
            this.Controls.Add(this.textBoxNumeMedicament);
            this.Controls.Add(this.labelAdaugaNume);
            this.groupBoxCategorievarsta.ResumeLayout(false);
            this.groupBoxCategorievarsta.PerformLayout();
            this.componenteCurente.Add(this.buttonAdaugaMed);
            this.componenteCurente.Add(this.button1);
            this.componenteCurente.Add(this.checkBoxStoc);
            this.componenteCurente.Add(this.groupBoxCategorievarsta);
            this.componenteCurente.Add(this.textBoxAgaudaCantitate);
            this.componenteCurente.Add(this.labelAdaugaCantitate);
            this.componenteCurente.Add(this.textBoxNumeMedicament);
            this.componenteCurente.Add(this.labelAdaugaNume);

        }
        private void curataEcran()
        {
            foreach(var componenta in componenteCurente)
            {
                componenta.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaMed_Click(object sender, EventArgs e)
        {
            string nume = string.Empty;
            int cantitate=0;
            string categorievarsta=string.Empty;
            bool stoc;
            if(string.IsNullOrEmpty(textBoxNumeMedicament.Text))
            {
                MessageBox.Show("Va rugam introduceti numele medicamnetului inainte de salvare", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBoxNumeMedicament.Text.Length>dimensiuneSirMax)
            {
                MessageBox.Show("Numele medicamentului este prea lung", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nume = textBoxNumeMedicament.Text;
            if(!int.TryParse(textBoxAgaudaCantitate.Text,out cantitate))
            {
                MessageBox.Show("Introduceti un numar pentru cantitate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(radiobuttonAdulti.Checked)
            {
                categorievarsta = "Adulti";
            }
            else if(radioButtonBebelusi.Checked)
            {
                categorievarsta = "Bebelusi";
            }
            else if(radioButtonCopii.Checked)
            {
                categorievarsta = "Copii";
            }
            else if(radioButtonVarstnici.Checked)
            {
                categorievarsta = "Varstnici";
            }
            else
            {
                MessageBox.Show("Alegeti o categorie de varsta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stoc = checkBoxStoc.Checked;

            Medicament medicament = new Medicament(nume, cantitate, categorievarsta, stoc);
            _farmacie.AdaugMed(medicament);
            MessageBox.Show("Medicamentul a fost adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            curataEcran();
            return;

        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            _farmacie.SalvareMedicamenteInFisier("medicament.txt");
            MessageBox.Show("Medicamentul a fost adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            curataEcran();
            return;
        }

        private void buttonIncarcare_Click(object sender, EventArgs e)
        {
            _farmacie.IncarcareMedicamenteInFisier("medicament.txt");
            MessageBox.Show("Medicamentul a fost adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            curataEcran();
            return;
        }

        private void buttonCauta_Medicament_Click(object sender, EventArgs e)
        {
            curataEcran();
            this.labelcauta = new System.Windows.Forms.Label();
            this.textBoxCauta = new System.Windows.Forms.TextBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            // 
            // labelcauta
            // 
            this.labelcauta.AutoSize = true;
            this.labelcauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcauta.Location = new System.Drawing.Point(511, 63);
            this.labelcauta.Name = "labelcauta";
            this.labelcauta.Size = new System.Drawing.Size(290, 25);
            this.labelcauta.TabIndex = 6;
            this.labelcauta.Text = "Introduceti datele pentru cautare";
            // 
            // textBox1
            // 
            this.textBoxCauta.Location = new System.Drawing.Point(516, 110);
            this.textBoxCauta.Name = "textBox1";
            this.textBoxCauta.Size = new System.Drawing.Size(285, 22);
            this.textBoxCauta.TabIndex = 7;
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(617, 160);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(75, 23);
            this.buttonCauta.TabIndex = 8;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.textBoxCauta);
            this.Controls.Add(this.labelcauta);
            componenteCurente.Add(buttonCauta);
            componenteCurente.Add(this.textBoxCauta);
            componenteCurente.Add(this.labelcauta);
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
         
            List<Medicament> medicamenteGasite = _farmacie.CautaMedicamente(textBoxCauta.Text); 
            curataEcran();
            var labelID = new System.Windows.Forms.Label();
            var labelNume = new System.Windows.Forms.Label();
            var labelCantitate = new System.Windows.Forms.Label();
            var labelCategorieVarsta = new System.Windows.Forms.Label();
            var labelStoc = new System.Windows.Forms.Label();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelID.Location = new System.Drawing.Point(275, 30);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(33, 25);
            labelID.TabIndex = 6;
            labelID.Text = "ID";
            labelID.Click += new System.EventHandler(label1_Click);
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNume.Location = new System.Drawing.Point(349, 30);
            labelNume.Name = "labelNume";
            labelNume.Size = new System.Drawing.Size(68, 25);
            labelNume.TabIndex = 7;
            labelNume.Text = "Nume";
            // 
            // labelCantitate
            // 
            labelCantitate.AutoSize = true;
            labelCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCantitate.Location = new System.Drawing.Point(529, 30);
            labelCantitate.Name = "labelCantitate";
            labelCantitate.Size = new System.Drawing.Size(99, 25);
            labelCantitate.TabIndex = 8;
            labelCantitate.Text = "Cantitate";
            // 
            // labelCategorieVarsta
            // 
            labelCategorieVarsta.AutoSize = true;
            labelCategorieVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCategorieVarsta.Location = new System.Drawing.Point(654, 30);
            labelCategorieVarsta.Name = "labelCategorieVarsta";
            labelCategorieVarsta.Size = new System.Drawing.Size(175, 25);
            labelCategorieVarsta.TabIndex = 9;
            labelCategorieVarsta.Text = "Categorie Varsta";
            // 
            // labelStoc
            // 
            labelStoc.AutoSize = true;
            labelStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStoc.Location = new System.Drawing.Point(844, 30);
            labelStoc.Name = "labelStoc";
            labelStoc.Size = new System.Drawing.Size(80, 25);
            labelStoc.TabIndex = 10;
            labelStoc.Text = "In Stoc";
            //adauga componentele pe formular
            Controls.Add(labelStoc);
            Controls.Add(labelCategorieVarsta);
            Controls.Add(labelCantitate);
            Controls.Add(labelNume);
            Controls.Add(labelID);


            componenteCurente.Add(labelStoc);
            componenteCurente.Add(labelCategorieVarsta);
            componenteCurente.Add(labelCantitate);
            componenteCurente.Add(labelNume);
            componenteCurente.Add(labelID);

            var pass_y_curent = dimensiune_pass_y;
            foreach (Medicament medicament in medicamenteGasite)
            {
                labelID = new System.Windows.Forms.Label();
                labelNume = new System.Windows.Forms.Label();
                labelCantitate = new System.Windows.Forms.Label();
                labelCategorieVarsta = new System.Windows.Forms.Label();
                labelStoc = new System.Windows.Forms.Label();
                // 
                // labelID
                // 
                labelID.AutoSize = true;
                labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelID.Location = new System.Drawing.Point(275, 30 + pass_y_curent);
                labelID.Name = "labelID";
                labelID.Size = new System.Drawing.Size(33, 25);
                labelID.TabIndex = 6;
                labelID.Text = medicament.IdMedicament.ToString();
                labelID.Click += new System.EventHandler(label1_Click);
                // 
                // labelNume
                // 
                labelNume.AutoSize = true;
                labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelNume.Location = new System.Drawing.Point(349, 30 + pass_y_curent);
                labelNume.Name = "labelNume";
                labelNume.Size = new System.Drawing.Size(68, 25);
                labelNume.TabIndex = 7;
                labelNume.Text = medicament.Nume;
                // 
                // labelCantitate
                // 
                labelCantitate.AutoSize = true;
                labelCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCantitate.Location = new System.Drawing.Point(529, 30 + pass_y_curent);
                labelCantitate.Name = "labelCantitate";
                labelCantitate.Size = new System.Drawing.Size(99, 25);
                labelCantitate.TabIndex = 8;
                labelCantitate.Text = medicament.Cantitate.ToString();
                // 
                // labelCategorieVarsta
                // 
                labelCategorieVarsta.AutoSize = true;
                labelCategorieVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCategorieVarsta.Location = new System.Drawing.Point(654, 30 + pass_y_curent);
                labelCategorieVarsta.Name = "labelCategorieVarsta";
                labelCategorieVarsta.Size = new System.Drawing.Size(175, 25);
                labelCategorieVarsta.TabIndex = 9;
                labelCategorieVarsta.Text = medicament.CategorieVarsta;
                // 
                // labelStoc
                // 
                labelStoc.AutoSize = true;
                labelStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelStoc.Location = new System.Drawing.Point(844, 30 + pass_y_curent);
                labelStoc.Name = "labelStoc";
                labelStoc.Size = new System.Drawing.Size(80, 25);
                labelStoc.TabIndex = 10;
                labelStoc.Text = medicament.InStoc.ToString();
                pass_y_curent += dimensiune_pass_y;
                //adauga componentele pe formular
                Controls.Add(labelStoc);
                Controls.Add(labelCategorieVarsta);
                Controls.Add(labelCantitate);
                Controls.Add(labelNume);
                Controls.Add(labelID);

                componenteCurente.Add(labelStoc);
                componenteCurente.Add(labelCategorieVarsta);
                componenteCurente.Add(labelCantitate);
                componenteCurente.Add(labelNume);
                componenteCurente.Add(labelID);
            }
        }
    }
}
