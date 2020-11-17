namespace TP10_GestionCabinet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_specialite = new System.Windows.Forms.ComboBox();
            this.comboBox_Sexe = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_prioritaire = new System.Windows.Forms.Button();
            this.button_renitialiserForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button1_ajouter = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listeAttente1 = new System.Windows.Forms.ListBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_afficher = new System.Windows.Forms.Button();
            this.button_classeAge = new System.Windows.Forms.Button();
            this.button_classerSexe = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_specialite);
            this.groupBox3.Controls.Add(this.comboBox_Sexe);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_prenom);
            this.groupBox3.Controls.Add(this.textBox_nom);
            this.groupBox3.Controls.Add(this.textBox_Id);
            this.groupBox3.Location = new System.Drawing.Point(12, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 281);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information sur le Patient";
            // 
            // comboBox_specialite
            // 
            this.comboBox_specialite.FormattingEnabled = true;
            this.comboBox_specialite.Items.AddRange(new object[] {
            "Géneraliste",
            "Dentiste",
            "Cardiologue"});
            this.comboBox_specialite.Location = new System.Drawing.Point(156, 247);
            this.comboBox_specialite.Name = "comboBox_specialite";
            this.comboBox_specialite.Size = new System.Drawing.Size(200, 23);
            this.comboBox_specialite.TabIndex = 13;
            // 
            // comboBox_Sexe
            // 
            this.comboBox_Sexe.FormattingEnabled = true;
            this.comboBox_Sexe.Items.AddRange(new object[] {
            "Femme",
            "Homme"});
            this.comboBox_Sexe.Location = new System.Drawing.Point(156, 205);
            this.comboBox_Sexe.Name = "comboBox_Sexe";
            this.comboBox_Sexe.Size = new System.Drawing.Size(200, 23);
            this.comboBox_Sexe.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Spécialité Demandée";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Sexe";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Date de Naissance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Prénom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(156, 126);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(200, 22);
            this.textBox_prenom.TabIndex = 3;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(156, 72);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(200, 22);
            this.textBox_nom.TabIndex = 2;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(156, 21);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(200, 22);
            this.textBox_Id.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_prioritaire);
            this.groupBox4.Controls.Add(this.button_renitialiserForm);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button1_ajouter);
            this.groupBox4.Location = new System.Drawing.Point(408, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 284);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste des Actions";
            // 
            // button_prioritaire
            // 
            this.button_prioritaire.BackColor = System.Drawing.Color.White;
            this.button_prioritaire.Location = new System.Drawing.Point(18, 244);
            this.button_prioritaire.Name = "button_prioritaire";
            this.button_prioritaire.Size = new System.Drawing.Size(176, 23);
            this.button_prioritaire.TabIndex = 4;
            this.button_prioritaire.Text = "Prioritaire";
            this.button_prioritaire.UseVisualStyleBackColor = false;
            this.button_prioritaire.Click += new System.EventHandler(this.button_prioritaire_Click);
            // 
            // button_renitialiserForm
            // 
            this.button_renitialiserForm.BackColor = System.Drawing.Color.White;
            this.button_renitialiserForm.Location = new System.Drawing.Point(18, 184);
            this.button_renitialiserForm.Name = "button_renitialiserForm";
            this.button_renitialiserForm.Size = new System.Drawing.Size(176, 23);
            this.button_renitialiserForm.TabIndex = 3;
            this.button_renitialiserForm.Text = "Renitialiser formulaire";
            this.button_renitialiserForm.UseVisualStyleBackColor = false;
            this.button_renitialiserForm.Click += new System.EventHandler(this.button_renitialiserForm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Retirer un patient";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Renitialiser la liste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1_ajouter
            // 
            this.button1_ajouter.BackColor = System.Drawing.Color.White;
            this.button1_ajouter.Location = new System.Drawing.Point(18, 21);
            this.button1_ajouter.Name = "button1_ajouter";
            this.button1_ajouter.Size = new System.Drawing.Size(176, 23);
            this.button1_ajouter.TabIndex = 0;
            this.button1_ajouter.Text = "Ajouter à la liste d\'attente";
            this.button1_ajouter.UseVisualStyleBackColor = false;
            this.button1_ajouter.Click += new System.EventHandler(this.button1_ajouter_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listeAttente1);
            this.groupBox5.Location = new System.Drawing.Point(648, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 281);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste d\'attente";
            // 
            // listeAttente1
            // 
            this.listeAttente1.FormattingEnabled = true;
            this.listeAttente1.ItemHeight = 15;
            this.listeAttente1.Location = new System.Drawing.Point(24, 28);
            this.listeAttente1.Name = "listeAttente1";
            this.listeAttente1.Size = new System.Drawing.Size(157, 229);
            this.listeAttente1.TabIndex = 5;
            // 
            // button_quitter
            // 
            this.button_quitter.BackColor = System.Drawing.Color.White;
            this.button_quitter.Location = new System.Drawing.Point(12, 342);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(176, 23);
            this.button_quitter.TabIndex = 5;
            this.button_quitter.Text = "Quitter l\'application";
            this.button_quitter.UseVisualStyleBackColor = false;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_afficher
            // 
            this.button_afficher.BackColor = System.Drawing.Color.White;
            this.button_afficher.Location = new System.Drawing.Point(226, 342);
            this.button_afficher.Name = "button_afficher";
            this.button_afficher.Size = new System.Drawing.Size(176, 23);
            this.button_afficher.TabIndex = 16;
            this.button_afficher.Text = "Afficher par spécialité";
            this.button_afficher.UseVisualStyleBackColor = false;
            this.button_afficher.Click += new System.EventHandler(this.button_afficher_Click);
            // 
            // button_classeAge
            // 
            this.button_classeAge.BackColor = System.Drawing.Color.White;
            this.button_classeAge.Location = new System.Drawing.Point(445, 342);
            this.button_classeAge.Name = "button_classeAge";
            this.button_classeAge.Size = new System.Drawing.Size(176, 23);
            this.button_classeAge.TabIndex = 17;
            this.button_classeAge.Text = "Classer par Age";
            this.button_classeAge.UseVisualStyleBackColor = false;
            this.button_classeAge.Click += new System.EventHandler(this.button_classeAge_Click);
            // 
            // button_classerSexe
            // 
            this.button_classerSexe.BackColor = System.Drawing.Color.White;
            this.button_classerSexe.Location = new System.Drawing.Point(672, 342);
            this.button_classerSexe.Name = "button_classerSexe";
            this.button_classerSexe.Size = new System.Drawing.Size(176, 23);
            this.button_classerSexe.TabIndex = 18;
            this.button_classerSexe.Text = "Classer par Sexe";
            this.button_classerSexe.UseVisualStyleBackColor = false;
            this.button_classerSexe.Click += new System.EventHandler(this.button_classerSexe_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(859, 389);
            this.Controls.Add(this.button_classerSexe);
            this.Controls.Add(this.button_classeAge);
            this.Controls.Add(this.button_afficher);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Gestion Cabinet";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Specialite;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.CheckBox Femme;
        private System.Windows.Forms.CheckBox homme;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_specialite;
        private System.Windows.Forms.ComboBox comboBox_Sexe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_prioritaire;
        private System.Windows.Forms.Button button_renitialiserForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button1_ajouter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_afficher;
        private System.Windows.Forms.Button button_classeAge;
        private System.Windows.Forms.Button button_classerSexe;
        private System.Windows.Forms.ListBox listeAttente1;
    }
}

