﻿namespace proyectoDB
{
    partial class menu
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
            this.lbleditarperfil = new System.Windows.Forms.Label();
            this.btnlistasiniciativa = new System.Windows.Forms.Button();
            this.btncreargrupo = new System.Windows.Forms.Button();
            this.lblcerrarsesion = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbleditarperfil
            // 
            this.lbleditarperfil.AutoSize = true;
            this.lbleditarperfil.Location = new System.Drawing.Point(193, 9);
            this.lbleditarperfil.Name = "lbleditarperfil";
            this.lbleditarperfil.Size = new System.Drawing.Size(67, 15);
            this.lbleditarperfil.TabIndex = 0;
            this.lbleditarperfil.Text = "editar perfil";
            this.lbleditarperfil.Visible = false;
            this.lbleditarperfil.Click += new System.EventHandler(this.lbleditarperfil_Click);
            // 
            // btnlistasiniciativa
            // 
            this.btnlistasiniciativa.Location = new System.Drawing.Point(65, 76);
            this.btnlistasiniciativa.Name = "btnlistasiniciativa";
            this.btnlistasiniciativa.Size = new System.Drawing.Size(126, 36);
            this.btnlistasiniciativa.TabIndex = 2;
            this.btnlistasiniciativa.Text = "listas de iniciativas";
            this.btnlistasiniciativa.UseVisualStyleBackColor = true;
            this.btnlistasiniciativa.Click += new System.EventHandler(this.btnlistasiniciativa_Click);
            // 
            // btncreargrupo
            // 
            this.btncreargrupo.Location = new System.Drawing.Point(65, 152);
            this.btncreargrupo.Name = "btncreargrupo";
            this.btncreargrupo.Size = new System.Drawing.Size(126, 36);
            this.btncreargrupo.TabIndex = 3;
            this.btncreargrupo.Text = "crear grupo";
            this.btncreargrupo.UseVisualStyleBackColor = true;
            this.btncreargrupo.Click += new System.EventHandler(this.btncreargrupo_Click);
            // 
            // lblcerrarsesion
            // 
            this.lblcerrarsesion.AutoSize = true;
            this.lblcerrarsesion.Location = new System.Drawing.Point(12, 9);
            this.lblcerrarsesion.Name = "lblcerrarsesion";
            this.lblcerrarsesion.Size = new System.Drawing.Size(73, 15);
            this.lblcerrarsesion.TabIndex = 4;
            this.lblcerrarsesion.Text = "cerrar sesion";
            this.lblcerrarsesion.Click += new System.EventHandler(this.lblcerrarsesion_Click);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(222, 215);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(38, 15);
            this.lblcorreo.TabIndex = 5;
            this.lblcorreo.Text = "label2";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 241);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblcerrarsesion);
            this.Controls.Add(this.btncreargrupo);
            this.Controls.Add(this.btnlistasiniciativa);
            this.Controls.Add(this.lbleditarperfil);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnlistasiniciativa;
        private Button btncreargrupo;
        private Label lblcerrarsesion;
        public Label lblcorreo;
        public Label lbleditarperfil;
    }
}