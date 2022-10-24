namespace proyectoDB
{
    partial class TablaIniciativas
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
            this.dginiciativas = new System.Windows.Forms.DataGridView();
            this.Columnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dginiciativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dginiciativas
            // 
            this.dginiciativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginiciativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnid,
            this.Columnnombre});
            this.dginiciativas.Location = new System.Drawing.Point(12, 202);
            this.dginiciativas.Name = "dginiciativas";
            this.dginiciativas.RowTemplate.Height = 25;
            this.dginiciativas.Size = new System.Drawing.Size(643, 221);
            this.dginiciativas.TabIndex = 0;
            this.dginiciativas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Columnid
            // 
            this.Columnid.HeaderText = "Id";
            this.Columnid.Name = "Columnid";
            // 
            // Columnnombre
            // 
            this.Columnnombre.HeaderText = "Nombre";
            this.Columnnombre.Name = "Columnnombre";
            this.Columnnombre.Width = 500;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID de iniciativa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "buscar comentarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Regrasar al menú";
            // 
            // TablaIniciativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dginiciativas);
            this.Name = "TablaIniciativas";
            this.Text = "TablaIniciativas";
            this.Load += new System.EventHandler(this.TablaIniciativas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginiciativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dginiciativas;
        private Button button1;
        private DataGridViewTextBoxColumn Columnid;
        private DataGridViewTextBoxColumn Columnnombre;
        private Label label1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label2;
    }
}