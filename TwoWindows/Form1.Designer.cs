namespace TwoWindows
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.txtVoir = new System.Windows.Forms.RichTextBox();
            this.btnVoir = new System.Windows.Forms.Button();
            this.nomlbl = new System.Windows.Forms.Label();
            this.prenomlbl = new System.Windows.Forms.Label();
            this.naissancelbl = new System.Windows.Forms.Label();
            this.nomtxt = new System.Windows.Forms.TextBox();
            this.prenomtxt = new System.Windows.Forms.TextBox();
            this.naissancetxt = new System.Windows.Forms.DateTimePicker();
            this.btnajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(46, 43);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 22);
            this.txtHost.TabIndex = 4;
            this.txtHost.Text = "localhost";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(200, 43);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 22);
            this.txtDB.TabIndex = 5;
            this.txtDB.Text = "madatabase";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(419, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            this.txtID.Text = "root";
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(612, 43);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(100, 22);
            this.txtMDP.TabIndex = 7;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(819, 37);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(114, 34);
            this.btnConnecter.TabIndex = 8;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // txtVoir
            // 
            this.txtVoir.Location = new System.Drawing.Point(46, 162);
            this.txtVoir.Name = "txtVoir";
            this.txtVoir.Size = new System.Drawing.Size(666, 206);
            this.txtVoir.TabIndex = 9;
            this.txtVoir.Text = "";
            // 
            // btnVoir
            // 
            this.btnVoir.Enabled = false;
            this.btnVoir.Location = new System.Drawing.Point(819, 162);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(114, 47);
            this.btnVoir.TabIndex = 10;
            this.btnVoir.Text = "Voir";
            this.btnVoir.UseVisualStyleBackColor = true;
            this.btnVoir.Click += new System.EventHandler(this.bVoir_Click_1);
            // 
            // nomlbl
            // 
            this.nomlbl.AutoSize = true;
            this.nomlbl.Location = new System.Drawing.Point(46, 83);
            this.nomlbl.Name = "nomlbl";
            this.nomlbl.Size = new System.Drawing.Size(37, 17);
            this.nomlbl.TabIndex = 11;
            this.nomlbl.Text = "Nom";
            // 
            // prenomlbl
            // 
            this.prenomlbl.AutoSize = true;
            this.prenomlbl.Location = new System.Drawing.Point(200, 82);
            this.prenomlbl.Name = "prenomlbl";
            this.prenomlbl.Size = new System.Drawing.Size(57, 17);
            this.prenomlbl.TabIndex = 12;
            this.prenomlbl.Text = "Prénom";
            // 
            // naissancelbl
            // 
            this.naissancelbl.AutoSize = true;
            this.naissancelbl.Location = new System.Drawing.Point(419, 83);
            this.naissancelbl.Name = "naissancelbl";
            this.naissancelbl.Size = new System.Drawing.Size(126, 17);
            this.naissancelbl.TabIndex = 13;
            this.naissancelbl.Text = "Date de naissance";
            // 
            // nomtxt
            // 
            this.nomtxt.Enabled = false;
            this.nomtxt.Location = new System.Drawing.Point(49, 104);
            this.nomtxt.Name = "nomtxt";
            this.nomtxt.Size = new System.Drawing.Size(100, 22);
            this.nomtxt.TabIndex = 14;
            // 
            // prenomtxt
            // 
            this.prenomtxt.Enabled = false;
            this.prenomtxt.Location = new System.Drawing.Point(203, 103);
            this.prenomtxt.Name = "prenomtxt";
            this.prenomtxt.Size = new System.Drawing.Size(100, 22);
            this.prenomtxt.TabIndex = 15;
            // 
            // naissancetxt
            // 
            this.naissancetxt.Enabled = false;
            this.naissancetxt.Location = new System.Drawing.Point(422, 103);
            this.naissancetxt.Name = "naissancetxt";
            this.naissancetxt.Size = new System.Drawing.Size(165, 22);
            this.naissancetxt.TabIndex = 16;
            // 
            // btnajouter
            // 
            this.btnajouter.Enabled = false;
            this.btnajouter.Location = new System.Drawing.Point(819, 103);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(114, 31);
            this.btnajouter.TabIndex = 17;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 381);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.naissancetxt);
            this.Controls.Add(this.prenomtxt);
            this.Controls.Add(this.nomtxt);
            this.Controls.Add(this.naissancelbl);
            this.Controls.Add(this.prenomlbl);
            this.Controls.Add(this.nomlbl);
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.txtVoir);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.RichTextBox txtVoir;
        private System.Windows.Forms.Button btnVoir;
        private System.Windows.Forms.Label nomlbl;
        private System.Windows.Forms.Label prenomlbl;
        private System.Windows.Forms.Label naissancelbl;
        private System.Windows.Forms.TextBox nomtxt;
        private System.Windows.Forms.TextBox prenomtxt;
        private System.Windows.Forms.DateTimePicker naissancetxt;
        private System.Windows.Forms.Button btnajouter;
    }
}

