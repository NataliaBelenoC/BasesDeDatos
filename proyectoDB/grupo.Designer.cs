namespace proyectoDB
{
    partial class grupo
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
            this.btnmiembros = new System.Windows.Forms.Button();
            this.lblmiembros = new System.Windows.Forms.Label();
            this.lbllider = new System.Windows.Forms.Label();
            this.txtlider = new System.Windows.Forms.TextBox();
            this.txtmiembros = new System.Windows.Forms.TextBox();
            this.btnlider = new System.Windows.Forms.Button();
            this.lblmenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmiembros
            // 
            this.btnmiembros.Location = new System.Drawing.Point(51, 221);
            this.btnmiembros.Name = "btnmiembros";
            this.btnmiembros.Size = new System.Drawing.Size(113, 23);
            this.btnmiembros.TabIndex = 0;
            this.btnmiembros.Text = "agregar miembros";
            this.btnmiembros.UseVisualStyleBackColor = true;
            this.btnmiembros.Click += new System.EventHandler(this.btnmiembros_Click);
            // 
            // lblmiembros
            // 
            this.lblmiembros.AutoSize = true;
            this.lblmiembros.Location = new System.Drawing.Point(20, 174);
            this.lblmiembros.Name = "lblmiembros";
            this.lblmiembros.Size = new System.Drawing.Size(103, 15);
            this.lblmiembros.TabIndex = 1;
            this.lblmiembros.Text = "miembros(correo)";
            // 
            // lbllider
            // 
            this.lbllider.AutoSize = true;
            this.lbllider.Location = new System.Drawing.Point(20, 64);
            this.lbllider.Name = "lbllider";
            this.lbllider.Size = new System.Drawing.Size(72, 15);
            this.lbllider.TabIndex = 2;
            this.lbllider.Text = "lider(correo)";
            // 
            // txtlider
            // 
            this.txtlider.Location = new System.Drawing.Point(20, 82);
            this.txtlider.Name = "txtlider";
            this.txtlider.Size = new System.Drawing.Size(170, 23);
            this.txtlider.TabIndex = 3;
            // 
            // txtmiembros
            // 
            this.txtmiembros.Location = new System.Drawing.Point(20, 192);
            this.txtmiembros.Name = "txtmiembros";
            this.txtmiembros.Size = new System.Drawing.Size(170, 23);
            this.txtmiembros.TabIndex = 4;
            // 
            // btnlider
            // 
            this.btnlider.Location = new System.Drawing.Point(62, 111);
            this.btnlider.Name = "btnlider";
            this.btnlider.Size = new System.Drawing.Size(86, 23);
            this.btnlider.TabIndex = 5;
            this.btnlider.Text = "agregar lider";
            this.btnlider.UseVisualStyleBackColor = true;
            this.btnlider.Click += new System.EventHandler(this.btnlider_Click);
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Location = new System.Drawing.Point(12, 9);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(95, 15);
            this.lblmenu.TabIndex = 20;
            this.lblmenu.Text = "regresar al menu";
            this.lblmenu.Click += new System.EventHandler(this.lblmenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Informacion de la iniciativa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.btnlider);
            this.Controls.Add(this.txtmiembros);
            this.Controls.Add(this.txtlider);
            this.Controls.Add(this.lbllider);
            this.Controls.Add(this.lblmiembros);
            this.Controls.Add(this.btnmiembros);
            this.Name = "grupo";
            this.Text = "grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnmiembros;
        private Label lblmiembros;
        private Label lbllider;
        private TextBox txtlider;
        private TextBox txtmiembros;
        private Button btnlider;
        private Label lblmenu;
        private Button button1;
    }
}