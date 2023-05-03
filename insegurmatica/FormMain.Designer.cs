namespace insegurmatica
{
    partial class FormMain
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.segav = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cuarentena = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.spearador2 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleProtection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.password = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // bandeja
            // 
            this.bandeja.ContextMenuStrip = this.menuContextual;
            this.bandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("bandeja.Icon")));
            this.bandeja.Text = "Insegurmática";
            this.bandeja.Visible = true;
            // 
            // menuContextual
            // 
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segav,
            this.buscar,
            this.actualizar,
            this.cuarentena,
            this.estadisticas,
            this.separador1,
            this.ayuda,
            this.spearador2,
            this.toggleProtection,
            this.toolStripSeparator1,
            this.password});
            this.menuContextual.Name = "menuContextual";
            this.menuContextual.Size = new System.Drawing.Size(279, 220);
            // 
            // segav
            // 
            this.segav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.segav.Name = "segav";
            this.segav.Size = new System.Drawing.Size(278, 22);
            this.segav.Text = "Segurmática Antivirus";
            this.segav.Click += new System.EventHandler(this.segav_Click);
            // 
            // buscar
            // 
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(278, 22);
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.actionDisabled_Click);
            // 
            // actualizar
            // 
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(278, 22);
            this.actualizar.Text = "Actualizar ahora";
            this.actualizar.Click += new System.EventHandler(this.actionDisabled_Click);
            // 
            // cuarentena
            // 
            this.cuarentena.Name = "cuarentena";
            this.cuarentena.Size = new System.Drawing.Size(278, 22);
            this.cuarentena.Text = "Cuarentena";
            this.cuarentena.Click += new System.EventHandler(this.actionDisabled_Click);
            // 
            // estadisticas
            // 
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.Size = new System.Drawing.Size(278, 22);
            this.estadisticas.Text = "Estadísticas";
            this.estadisticas.Click += new System.EventHandler(this.actionDisabled_Click);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(275, 6);
            // 
            // ayuda
            // 
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(278, 22);
            this.ayuda.Text = "Ayuda";
            this.ayuda.Click += new System.EventHandler(this.actionDisabled_Click);
            // 
            // spearador2
            // 
            this.spearador2.Name = "spearador2";
            this.spearador2.Size = new System.Drawing.Size(275, 6);
            // 
            // toggleProtection
            // 
            this.toggleProtection.Name = "toggleProtection";
            this.toggleProtection.Size = new System.Drawing.Size(278, 22);
            this.toggleProtection.Text = "Deshabilitar protección permanente";
            this.toggleProtection.Click += new System.EventHandler(this.toggleProtection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            // 
            // password
            // 
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(278, 22);
            this.password.Text = "Cambiar contraseña de administración";
            this.password.Click += new System.EventHandler(this.actionDisabled_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 243);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Insegurmática";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon bandeja;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem segav;
        private System.Windows.Forms.ToolStripMenuItem buscar;
        private System.Windows.Forms.ToolStripMenuItem actualizar;
        private System.Windows.Forms.ToolStripMenuItem cuarentena;
        private System.Windows.Forms.ToolStripMenuItem estadisticas;
        private System.Windows.Forms.ToolStripSeparator separador1;
        private System.Windows.Forms.ToolStripMenuItem ayuda;
        private System.Windows.Forms.ToolStripSeparator spearador2;
        private System.Windows.Forms.ToolStripMenuItem toggleProtection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem password;
    }
}

