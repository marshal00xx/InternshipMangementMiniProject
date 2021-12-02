namespace GestionStageTP {
    partial class GestionDesStages {
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.SortByTypeBtn = new System.Windows.Forms.Button();
            this.SortByDateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(74, 76);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(643, 306);
            this.dgv.TabIndex = 0;
            this.dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // SortByTypeBtn
            // 
            this.SortByTypeBtn.BackColor = System.Drawing.Color.White;
            this.SortByTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByTypeBtn.Location = new System.Drawing.Point(192, 38);
            this.SortByTypeBtn.Name = "SortByTypeBtn";
            this.SortByTypeBtn.Size = new System.Drawing.Size(90, 32);
            this.SortByTypeBtn.TabIndex = 3;
            this.SortByTypeBtn.Text = "Type";
            this.SortByTypeBtn.UseVisualStyleBackColor = false;
            this.SortByTypeBtn.Click += new System.EventHandler(this.SortByTypeBtn_Click);
            // 
            // SortByDateBtn
            // 
            this.SortByDateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SortByDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByDateBtn.Location = new System.Drawing.Point(102, 38);
            this.SortByDateBtn.Name = "SortByDateBtn";
            this.SortByDateBtn.Size = new System.Drawing.Size(90, 32);
            this.SortByDateBtn.TabIndex = 2;
            this.SortByDateBtn.Text = "Date";
            this.SortByDateBtn.UseVisualStyleBackColor = false;
            this.SortByDateBtn.Click += new System.EventHandler(this.SortByDateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionStageTP.Properties.Resources.icons8_sort_100;
            this.pictureBox1.Location = new System.Drawing.Point(60, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GestionDesStages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SortByDateBtn);
            this.Controls.Add(this.SortByTypeBtn);
            this.Controls.Add(this.dgv);
            this.Name = "GestionDesStages";
            this.Text = "Gestion Des Stages";
            this.Load += new System.EventHandler(this.GestionDesStages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button SortByTypeBtn;
        private System.Windows.Forms.Button SortByDateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

