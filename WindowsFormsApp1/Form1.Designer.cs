namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelcod = new System.Windows.Forms.Label();
            this.labeltrans = new System.Windows.Forms.Label();
            this.buttonCan = new System.Windows.Forms.Button();
            this.buttonval = new System.Windows.Forms.Button();
            this.labelmonto = new System.Windows.Forms.Label();
            this.labeltransf = new System.Windows.Forms.Label();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labelmont = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(504, 115);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(113, 21);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button_buscar);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(253, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 83);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelcod
            // 
            this.labelcod.AutoSize = true;
            this.labelcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcod.Location = new System.Drawing.Point(199, 236);
            this.labelcod.Name = "labelcod";
            this.labelcod.Size = new System.Drawing.Size(104, 17);
            this.labelcod.TabIndex = 4;
            this.labelcod.Text = "Codigo Vippo";
            // 
            // labeltrans
            // 
            this.labeltrans.AutoSize = true;
            this.labeltrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltrans.Location = new System.Drawing.Point(199, 189);
            this.labeltrans.Name = "labeltrans";
            this.labeltrans.Size = new System.Drawing.Size(128, 17);
            this.labeltrans.TabIndex = 5;
            this.labeltrans.Text = "Nro Transaccion";
            // 
            // buttonCan
            // 
            this.buttonCan.Location = new System.Drawing.Point(202, 373);
            this.buttonCan.Name = "buttonCan";
            this.buttonCan.Size = new System.Drawing.Size(177, 33);
            this.buttonCan.TabIndex = 7;
            this.buttonCan.Text = "Volver";
            this.buttonCan.UseVisualStyleBackColor = true;
            this.buttonCan.Click += new System.EventHandler(this.buttonCan_Click);
            // 
            // buttonval
            // 
            this.buttonval.Location = new System.Drawing.Point(440, 373);
            this.buttonval.Name = "buttonval";
            this.buttonval.Size = new System.Drawing.Size(177, 33);
            this.buttonval.TabIndex = 8;
            this.buttonval.Text = "Validar";
            this.buttonval.UseVisualStyleBackColor = true;
            this.buttonval.Click += new System.EventHandler(this.buttonval_Click);
            // 
            // labelmonto
            // 
            this.labelmonto.AutoSize = true;
            this.labelmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonto.Location = new System.Drawing.Point(199, 285);
            this.labelmonto.Name = "labelmonto";
            this.labelmonto.Size = new System.Drawing.Size(52, 17);
            this.labelmonto.TabIndex = 9;
            this.labelmonto.Text = "Monto";
            this.labelmonto.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeltransf
            // 
            this.labeltransf.AutoSize = true;
            this.labeltransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltransf.Location = new System.Drawing.Point(501, 189);
            this.labeltransf.Name = "labeltransf";
            this.labeltransf.Size = new System.Drawing.Size(116, 17);
            this.labeltransf.TabIndex = 10;
            this.labeltransf.Text = "201803152789";
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodigo.Location = new System.Drawing.Point(564, 236);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(53, 17);
            this.labelcodigo.TabIndex = 11;
            this.labelcodigo.Text = "11303";
            // 
            // labelmont
            // 
            this.labelmont.AutoSize = true;
            this.labelmont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmont.Location = new System.Drawing.Point(564, 285);
            this.labelmont.Name = "labelmont";
            this.labelmont.Size = new System.Drawing.Size(53, 17);
            this.labelmont.TabIndex = 12;
            this.labelmont.Text = "10000";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(818, 418);
            this.Controls.Add(this.labelmont);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.labeltransf);
            this.Controls.Add(this.labelmonto);
            this.Controls.Add(this.buttonval);
            this.Controls.Add(this.buttonCan);
            this.Controls.Add(this.labeltrans);
            this.Controls.Add(this.labelcod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Buscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador Vippo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelcod;
        private System.Windows.Forms.Label labeltrans;
        private System.Windows.Forms.Button buttonCan;
        private System.Windows.Forms.Button buttonval;
        private System.Windows.Forms.Label labelmonto;
        private System.Windows.Forms.Label labeltransf;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.Label labelmont;
        private System.Windows.Forms.ErrorProvider error;
    }
}

