namespace Client.FormIhm
{
    partial class PIM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbJourExploitation = new System.Windows.Forms.TextBox();
            this.tbLigne = new System.Windows.Forms.TextBox();
            this.tbAlpha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCompagnie = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRush = new System.Windows.Forms.CheckBox();
            this.cbContinuation = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClasseBag = new System.Windows.Forms.TextBox();
            this.tbItineraire = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Iata :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbJourExploitation);
            this.groupBox4.Controls.Add(this.tbLigne);
            this.groupBox4.Controls.Add(this.tbAlpha);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbCompagnie);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 223);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vol";
            // 
            // tbJourExploitation
            // 
            this.tbJourExploitation.Location = new System.Drawing.Point(124, 146);
            this.tbJourExploitation.Name = "tbJourExploitation";
            this.tbJourExploitation.Size = new System.Drawing.Size(144, 20);
            this.tbJourExploitation.TabIndex = 4;
            // 
            // tbLigne
            // 
            this.tbLigne.Location = new System.Drawing.Point(196, 91);
            this.tbLigne.Name = "tbLigne";
            this.tbLigne.Size = new System.Drawing.Size(73, 20);
            this.tbLigne.TabIndex = 3;
            // 
            // tbAlpha
            // 
            this.tbAlpha.Location = new System.Drawing.Point(90, 91);
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(100, 20);
            this.tbAlpha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jour d\'exploitation : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ligne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compagnie :";
            // 
            // tbCompagnie
            // 
            this.tbCompagnie.Location = new System.Drawing.Point(90, 37);
            this.tbCompagnie.Name = "tbCompagnie";
            this.tbCompagnie.Size = new System.Drawing.Size(179, 20);
            this.tbCompagnie.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRush);
            this.groupBox3.Controls.Add(this.cbContinuation);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbClasseBag);
            this.groupBox3.Controls.Add(this.tbItineraire);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(296, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 223);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bagage";
            // 
            // cbRush
            // 
            this.cbRush.AutoSize = true;
            this.cbRush.Location = new System.Drawing.Point(205, 144);
            this.cbRush.Name = "cbRush";
            this.cbRush.Size = new System.Drawing.Size(51, 17);
            this.cbRush.TabIndex = 8;
            this.cbRush.Text = "Rush";
            this.cbRush.UseVisualStyleBackColor = true;
            // 
            // cbContinuation
            // 
            this.cbContinuation.AutoSize = true;
            this.cbContinuation.Location = new System.Drawing.Point(60, 144);
            this.cbContinuation.Name = "cbContinuation";
            this.cbContinuation.Size = new System.Drawing.Size(85, 17);
            this.cbContinuation.TabIndex = 7;
            this.cbContinuation.Text = "Continuation";
            this.cbContinuation.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Classe bagage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Itinéraire : ";
            // 
            // tbClasseBag
            // 
            this.tbClasseBag.Location = new System.Drawing.Point(106, 91);
            this.tbClasseBag.Name = "tbClasseBag";
            this.tbClasseBag.Size = new System.Drawing.Size(100, 20);
            this.tbClasseBag.TabIndex = 6;
            // 
            // tbItineraire
            // 
            this.tbItineraire.Location = new System.Drawing.Point(106, 37);
            this.tbItineraire.Name = "tbItineraire";
            this.tbItineraire.Size = new System.Drawing.Size(100, 20);
            this.tbItineraire.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "Messages";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel2.Text = "Etat";
            // 
            // PIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 334);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PIM";
            this.Text = "PIM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbJourExploitation;
        private System.Windows.Forms.TextBox tbLigne;
        private System.Windows.Forms.TextBox tbAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCompagnie;
        private System.Windows.Forms.CheckBox cbRush;
        private System.Windows.Forms.CheckBox cbContinuation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClasseBag;
        private System.Windows.Forms.TextBox tbItineraire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

