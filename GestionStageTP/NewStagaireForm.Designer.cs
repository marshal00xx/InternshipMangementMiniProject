namespace GestionStageTP {
    partial class NewStagaireForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.prenomTB = new System.Windows.Forms.TextBox();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.anneeNaissanceTB = new System.Windows.Forms.TextBox();
            this.diplomeTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femmeRBTN = new System.Windows.Forms.RadioButton();
            this.hommeRBTN = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ajouterStagaireBTN = new System.Windows.Forms.Button();
            this.retourInscriptionBTN = new System.Windows.Forms.Button();
            this.retourDebutBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prenomTB
            // 
            this.prenomTB.BackColor = System.Drawing.Color.White;
            this.prenomTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTB.ForeColor = System.Drawing.Color.Black;
            this.prenomTB.Location = new System.Drawing.Point(304, 157);
            this.prenomTB.Name = "prenomTB";
            this.prenomTB.Size = new System.Drawing.Size(163, 32);
            this.prenomTB.TabIndex = 13;
            this.prenomTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickTB);
            // 
            // nomTB
            // 
            this.nomTB.BackColor = System.Drawing.Color.White;
            this.nomTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTB.ForeColor = System.Drawing.Color.Black;
            this.nomTB.Location = new System.Drawing.Point(304, 100);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(163, 32);
            this.nomTB.TabIndex = 14;
            this.nomTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickTB);
            // 
            // anneeNaissanceTB
            // 
            this.anneeNaissanceTB.BackColor = System.Drawing.Color.White;
            this.anneeNaissanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneeNaissanceTB.ForeColor = System.Drawing.Color.Black;
            this.anneeNaissanceTB.Location = new System.Drawing.Point(304, 211);
            this.anneeNaissanceTB.Name = "anneeNaissanceTB";
            this.anneeNaissanceTB.Size = new System.Drawing.Size(163, 32);
            this.anneeNaissanceTB.TabIndex = 14;
            this.anneeNaissanceTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickTB);
            // 
            // diplomeTB
            // 
            this.diplomeTB.BackColor = System.Drawing.Color.White;
            this.diplomeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diplomeTB.ForeColor = System.Drawing.Color.Black;
            this.diplomeTB.Location = new System.Drawing.Point(304, 268);
            this.diplomeTB.Name = "diplomeTB";
            this.diplomeTB.Size = new System.Drawing.Size(163, 32);
            this.diplomeTB.TabIndex = 13;
            this.diplomeTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickTB);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femmeRBTN);
            this.groupBox1.Controls.Add(this.hommeRBTN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 85);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // femmeRBTN
            // 
            this.femmeRBTN.AutoSize = true;
            this.femmeRBTN.ForeColor = System.Drawing.Color.Black;
            this.femmeRBTN.Location = new System.Drawing.Point(344, 31);
            this.femmeRBTN.Name = "femmeRBTN";
            this.femmeRBTN.Size = new System.Drawing.Size(105, 30);
            this.femmeRBTN.TabIndex = 16;
            this.femmeRBTN.TabStop = true;
            this.femmeRBTN.Text = "Femme";
            this.femmeRBTN.UseVisualStyleBackColor = true;
            // 
            // hommeRBTN
            // 
            this.hommeRBTN.AutoSize = true;
            this.hommeRBTN.ForeColor = System.Drawing.Color.Black;
            this.hommeRBTN.Location = new System.Drawing.Point(70, 31);
            this.hommeRBTN.Name = "hommeRBTN";
            this.hommeRBTN.Size = new System.Drawing.Size(108, 30);
            this.hommeRBTN.TabIndex = 16;
            this.hommeRBTN.TabStop = true;
            this.hommeRBTN.Text = "Homme";
            this.hommeRBTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Annee de naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Diplome :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ajouter Un Stagaire";
            // 
            // ajouterStagaireBTN
            // 
            this.ajouterStagaireBTN.BackColor = System.Drawing.Color.White;
            this.ajouterStagaireBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterStagaireBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterStagaireBTN.Location = new System.Drawing.Point(545, 198);
            this.ajouterStagaireBTN.Name = "ajouterStagaireBTN";
            this.ajouterStagaireBTN.Size = new System.Drawing.Size(210, 43);
            this.ajouterStagaireBTN.TabIndex = 17;
            this.ajouterStagaireBTN.Text = "Creation";
            this.ajouterStagaireBTN.UseVisualStyleBackColor = false;
            this.ajouterStagaireBTN.Click += new System.EventHandler(this.ajouterStagaireBTN_Click);
            // 
            // retourInscriptionBTN
            // 
            this.retourInscriptionBTN.BackColor = System.Drawing.Color.White;
            this.retourInscriptionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourInscriptionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourInscriptionBTN.Location = new System.Drawing.Point(545, 277);
            this.retourInscriptionBTN.Name = "retourInscriptionBTN";
            this.retourInscriptionBTN.Size = new System.Drawing.Size(210, 43);
            this.retourInscriptionBTN.TabIndex = 18;
            this.retourInscriptionBTN.Text = "Retour Inscrition";
            this.retourInscriptionBTN.UseVisualStyleBackColor = false;
            this.retourInscriptionBTN.Click += new System.EventHandler(this.retourInscriptionBTN_Click);
            // 
            // retourDebutBTN
            // 
            this.retourDebutBTN.BackColor = System.Drawing.Color.White;
            this.retourDebutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourDebutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourDebutBTN.Location = new System.Drawing.Point(545, 354);
            this.retourDebutBTN.Name = "retourDebutBTN";
            this.retourDebutBTN.Size = new System.Drawing.Size(210, 43);
            this.retourDebutBTN.TabIndex = 19;
            this.retourDebutBTN.Text = "Retour Debut";
            this.retourDebutBTN.UseVisualStyleBackColor = false;
            this.retourDebutBTN.Click += new System.EventHandler(this.retourDebutBTN_Click);
            // 
            // NewStagaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.retourDebutBTN);
            this.Controls.Add(this.retourInscriptionBTN);
            this.Controls.Add(this.ajouterStagaireBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.diplomeTB);
            this.Controls.Add(this.anneeNaissanceTB);
            this.Controls.Add(this.prenomTB);
            this.Controls.Add(this.nomTB);
            this.Name = "NewStagaireForm";
            this.Text = "NewStagaireForm";
            this.Load += new System.EventHandler(this.NewStagaireForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prenomTB;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox anneeNaissanceTB;
        private System.Windows.Forms.TextBox diplomeTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femmeRBTN;
        private System.Windows.Forms.RadioButton hommeRBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ajouterStagaireBTN;
        private System.Windows.Forms.Button retourInscriptionBTN;
        private System.Windows.Forms.Button retourDebutBTN;
    }
}