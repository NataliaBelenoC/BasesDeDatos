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
            this.btnmienbros = new System.Windows.Forms.Button();
            this.lblmiembros = new System.Windows.Forms.Label();
            this.lbllider = new System.Windows.Forms.Label();
            this.txtlider = new System.Windows.Forms.TextBox();
            this.txtmienbros = new System.Windows.Forms.TextBox();
            this.btnlider = new System.Windows.Forms.Button();
            this.lblmenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmienbros
            // 
            this.btnmienbros.Location = new System.Drawing.Point(47, 238);
            this.btnmienbros.Name = "btnmienbros";
            this.btnmienbros.Size = new System.Drawing.Size(113, 23);
            this.btnmienbros.TabIndex = 0;
            this.btnmienbros.Text = "agregar miembros";
            this.btnmienbros.UseVisualStyleBackColor = true;
            // 
            // lblmiembros
            // 
            this.lblmiembros.AutoSize = true;
            this.lblmiembros.Location = new System.Drawing.Point(20, 159);
            this.lblmiembros.Name = "lblmiembros";
            this.lblmiembros.Size = new System.Drawing.Size(57, 15);
            this.lblmiembros.TabIndex = 1;
            this.lblmiembros.Text = "mienbros";
            // 
            // lbllider
            // 
            this.lbllider.AutoSize = true;
            this.lbllider.Location = new System.Drawing.Point(20, 49);
            this.lbllider.Name = "lbllider";
            this.lbllider.Size = new System.Drawing.Size(30, 15);
            this.lbllider.TabIndex = 2;
            this.lbllider.Text = "lider";
            // 
            // txtlider
            // 
            this.txtlider.Location = new System.Drawing.Point(20, 82);
            this.txtlider.Name = "txtlider";
            this.txtlider.Size = new System.Drawing.Size(170, 23);
            this.txtlider.TabIndex = 3;
            // 
            // txtmienbros
            // 
            this.txtmienbros.Location = new System.Drawing.Point(20, 192);
            this.txtmienbros.Name = "txtmienbros";
            this.txtmienbros.Size = new System.Drawing.Size(170, 23);
            this.txtmienbros.TabIndex = 4;
            // 
            // btnlider
            // 
            this.btnlider.Location = new System.Drawing.Point(63, 124);
            this.btnlider.Name = "btnlider";
            this.btnlider.Size = new System.Drawing.Size(86, 23);
            this.btnlider.TabIndex = 5;
            this.btnlider.Text = "agregar lider";
            this.btnlider.UseVisualStyleBackColor = true;
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
            // grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 330);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.btnlider);
            this.Controls.Add(this.txtmienbros);
            this.Controls.Add(this.txtlider);
            this.Controls.Add(this.lbllider);
            this.Controls.Add(this.lblmiembros);
            this.Controls.Add(this.btnmienbros);
            this.Name = "grupo";
            this.Text = "grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnmienbros;
        private Label lblmiembros;
        private Label lbllider;
        private TextBox txtlider;
        private TextBox txtmienbros;
        private Button btnlider;
        private Label lblmenu;
    }
}