namespace GestionStageTP {
    partial class ListInscritForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeStageTb = new System.Windows.Forms.TextBox();
            this.dateDebutTB = new System.Windows.Forms.TextBox();
            this.dateFinTB = new System.Windows.Forms.TextBox();
            this.nouvelleInscriptionTB = new System.Windows.Forms.Button();
            this.retourListStageBtn = new System.Windows.Forms.Button();
            this.listPrincipaleLB = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listAttenteLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stage:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Du :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Au :";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // typeStageTb
            // 
            this.typeStageTb.BackColor = System.Drawing.Color.White;
            this.typeStageTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeStageTb.Enabled = false;
            this.typeStageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeStageTb.Location = new System.Drawing.Point(100, 33);
            this.typeStageTb.Name = "typeStageTb";
            this.typeStageTb.ReadOnly = true;
            this.typeStageTb.Size = new System.Drawing.Size(137, 25);
            this.typeStageTb.TabIndex = 6;
            // 
            // dateDebutTB
            // 
            this.dateDebutTB.BackColor = System.Drawing.Color.White;
            this.dateDebutTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateDebutTB.Enabled = false;
            this.dateDebutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebutTB.Location = new System.Drawing.Point(100, 79);
            this.dateDebutTB.Name = "dateDebutTB";
            this.dateDebutTB.ReadOnly = true;
            this.dateDebutTB.Size = new System.Drawing.Size(137, 25);
            this.dateDebutTB.TabIndex = 6;
            // 
            // dateFinTB
            // 
            this.dateFinTB.BackColor = System.Drawing.Color.White;
            this.dateFinTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateFinTB.Enabled = false;
            this.dateFinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinTB.Location = new System.Drawing.Point(100, 124);
            this.dateFinTB.Name = "dateFinTB";
            this.dateFinTB.ReadOnly = true;
            this.dateFinTB.Size = new System.Drawing.Size(137, 25);
            this.dateFinTB.TabIndex = 6;
            // 
            // nouvelleInscriptionTB
            // 
            this.nouvelleInscriptionTB.BackColor = System.Drawing.Color.White;
            this.nouvelleInscriptionTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouvelleInscriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvelleInscriptionTB.Location = new System.Drawing.Point(12, 394);
            this.nouvelleInscriptionTB.Name = "nouvelleInscriptionTB";
            this.nouvelleInscriptionTB.Size = new System.Drawing.Size(210, 43);
            this.nouvelleInscriptionTB.TabIndex = 8;
            this.nouvelleInscriptionTB.Text = "Nouvelle Inscription";
            this.nouvelleInscriptionTB.UseVisualStyleBackColor = false;
            this.nouvelleInscriptionTB.Click += new System.EventHandler(this.nouvelleInscriptionTB_Click);
            // 
            // retourListStageBtn
            // 
            this.retourListStageBtn.BackColor = System.Drawing.Color.White;
            this.retourListStageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourListStageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourListStageBtn.Location = new System.Drawing.Point(426, 394);
            this.retourListStageBtn.Name = "retourListStageBtn";
            this.retourListStageBtn.Size = new System.Drawing.Size(210, 43);
            this.retourListStageBtn.TabIndex = 8;
            this.retourListStageBtn.Text = "Retour List Stage";
            this.retourListStageBtn.UseVisualStyleBackColor = false;
            this.retourListStageBtn.Click += new System.EventHandler(this.retourListStageBtn_Click);
            // 
            // listPrincipaleLB
            // 
            this.listPrincipaleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrincipaleLB.FormattingEnabled = true;
            this.listPrincipaleLB.ItemHeight = 25;
            this.listPrincipaleLB.Location = new System.Drawing.Point(12, 209);
            this.listPrincipaleLB.Name = "listPrincipaleLB";
            this.listPrincipaleLB.Size = new System.Drawing.Size(285, 179);
            this.listPrincipaleLB.TabIndex = 10;
            this.listPrincipaleLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listItemDblClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 10);
            this.panel1.TabIndex = 14;
            // 
            // listAttenteLB
            // 
            this.listAttenteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAttenteLB.FormattingEnabled = true;
            this.listAttenteLB.ItemHeight = 25;
            this.listAttenteLB.Location = new System.Drawing.Point(351, 209);
            this.listAttenteLB.Name = "listAttenteLB";
            this.listAttenteLB.Size = new System.Drawing.Size(285, 179);
            this.listAttenteLB.TabIndex = 10;
            this.listAttenteLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listItemDblClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "List Principale";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "List d\'attente";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListInscritForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listAttenteLB);
            this.Controls.Add(this.listPrincipaleLB);
            this.Controls.Add(this.retourListStageBtn);
            this.Controls.Add(this.nouvelleInscriptionTB);
            this.Controls.Add(this.dateFinTB);
            this.Controls.Add(this.dateDebutTB);
            this.Controls.Add(this.typeStageTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ListInscritForm";
            this.Text = "ListInscritForm";
            this.Load += new System.EventHandler(this.ListInscritForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeStageTb;
        private System.Windows.Forms.TextBox dateDebutTB;
        private System.Windows.Forms.TextBox dateFinTB;
        private System.Windows.Forms.Button nouvelleInscriptionTB;
        private System.Windows.Forms.Button retourListStageBtn;
        private System.Windows.Forms.ListBox listPrincipaleLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listAttenteLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}