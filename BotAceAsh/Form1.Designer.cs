namespace BotAceAsh
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
            this.button1 = new System.Windows.Forms.Button();
            this.radio_3bouffes = new System.Windows.Forms.RadioButton();
            this.radio_4bouffe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(302, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lancer le bot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_3bouffes
            // 
            this.radio_3bouffes.AutoSize = true;
            this.radio_3bouffes.Checked = true;
            this.radio_3bouffes.Location = new System.Drawing.Point(15, 19);
            this.radio_3bouffes.Name = "radio_3bouffes";
            this.radio_3bouffes.Size = new System.Drawing.Size(57, 17);
            this.radio_3bouffes.TabIndex = 1;
            this.radio_3bouffes.TabStop = true;
            this.radio_3bouffes.Text = "3 buffs";
            this.radio_3bouffes.UseVisualStyleBackColor = true;
            // 
            // radio_4bouffe
            // 
            this.radio_4bouffe.AutoSize = true;
            this.radio_4bouffe.Location = new System.Drawing.Point(109, 19);
            this.radio_4bouffe.Name = "radio_4bouffe";
            this.radio_4bouffe.Size = new System.Drawing.Size(57, 17);
            this.radio_4bouffe.TabIndex = 2;
            this.radio_4bouffe.TabStop = true;
            this.radio_4bouffe.Text = "4 buffs";
            this.radio_4bouffe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_3bouffes);
            this.groupBox1.Controls.Add(this.radio_4bouffe);
            this.groupBox1.Location = new System.Drawing.Point(22, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre de buffs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "BOT ACE et ASH << BAN SOON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "BOT WISHMASTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_3bouffes;
        private System.Windows.Forms.RadioButton radio_4bouffe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

