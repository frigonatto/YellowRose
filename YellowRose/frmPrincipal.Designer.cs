namespace YellowRose
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            tslFormSizeAndLocation = new ToolStripStatusLabel();
            fraConexion = new GroupBox();
            lblEstadoConexion = new Label();
            lblNombreConexion = new Label();
            label5 = new Label();
            btnInformacion = new Button();
            btnConectar = new Button();
            button1 = new Button();
            label3 = new Label();
            lblCadendaConexion = new Label();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            txtInstrucciones = new TextBox();
            dgvResultados = new DataGridView();
            menuStrip1 = new MenuStrip();
            conexionesToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            conectarToolStripMenuItem = new ToolStripMenuItem();
            desconectarToolStripMenuItem = new ToolStripMenuItem();
            editorDeConexionesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            comandosToolStripMenuItem = new ToolStripMenuItem();
            resultadosToolStripMenuItem = new ToolStripMenuItem();
            descargarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            fraConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, tslFormSizeAndLocation });
            statusStrip1.Location = new Point(0, 529);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(801, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel1.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.AutoSize = false;
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel3.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(118, 17);
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.AutoSize = false;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel4.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(118, 17);
            // 
            // tslFormSizeAndLocation
            // 
            tslFormSizeAndLocation.AutoSize = false;
            tslFormSizeAndLocation.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tslFormSizeAndLocation.BorderStyle = Border3DStyle.Sunken;
            tslFormSizeAndLocation.Name = "tslFormSizeAndLocation";
            tslFormSizeAndLocation.Size = new Size(250, 17);
            // 
            // fraConexion
            // 
            fraConexion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fraConexion.Controls.Add(lblEstadoConexion);
            fraConexion.Controls.Add(lblNombreConexion);
            fraConexion.Controls.Add(label5);
            fraConexion.Controls.Add(btnInformacion);
            fraConexion.Controls.Add(btnConectar);
            fraConexion.Controls.Add(button1);
            fraConexion.Controls.Add(label3);
            fraConexion.Controls.Add(lblCadendaConexion);
            fraConexion.Controls.Add(label1);
            fraConexion.Location = new Point(14, 39);
            fraConexion.Name = "fraConexion";
            fraConexion.Size = new Size(778, 101);
            fraConexion.TabIndex = 1;
            fraConexion.TabStop = false;
            fraConexion.Text = "Conexión";
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoConexion.Location = new Point(70, 69);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(108, 15);
            lblEstadoConexion.TabIndex = 9;
            lblEstadoConexion.Text = "lblEstadoConexion";
            // 
            // lblNombreConexion
            // 
            lblNombreConexion.AutoSize = true;
            lblNombreConexion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreConexion.Location = new Point(81, 22);
            lblNombreConexion.Name = "lblNombreConexion";
            lblNombreConexion.Size = new Size(118, 15);
            lblNombreConexion.TabIndex = 8;
            lblNombreConexion.Text = "lblNombreConexion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 22);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 7;
            label5.Text = "Nombre:";
            // 
            // btnInformacion
            // 
            btnInformacion.Location = new Point(678, 59);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(75, 23);
            btnInformacion.TabIndex = 6;
            btnInformacion.Text = "i";
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(585, 61);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 5;
            btnConectar.Text = "c";
            btnConectar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(654, 23);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "Configurar...";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 69);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // lblCadendaConexion
            // 
            lblCadendaConexion.AutoSize = true;
            lblCadendaConexion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCadendaConexion.Location = new Point(144, 43);
            lblCadendaConexion.Name = "lblCadendaConexion";
            lblCadendaConexion.Size = new Size(119, 15);
            lblCadendaConexion.TabIndex = 1;
            lblCadendaConexion.Text = "lblCadendaConexion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadena de Conexión:";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Location = new Point(12, 146);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtInstrucciones);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvResultados);
            splitContainer1.Size = new Size(777, 366);
            splitContainer1.SplitterDistance = 181;
            splitContainer1.TabIndex = 2;
            // 
            // txtInstrucciones
            // 
            txtInstrucciones.Dock = DockStyle.Fill;
            txtInstrucciones.Location = new Point(0, 0);
            txtInstrucciones.Multiline = true;
            txtInstrucciones.Name = "txtInstrucciones";
            txtInstrucciones.Size = new Size(773, 177);
            txtInstrucciones.TabIndex = 0;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Dock = DockStyle.Fill;
            dgvResultados.Location = new Point(0, 0);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(773, 177);
            dgvResultados.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { conexionesToolStripMenuItem, comandosToolStripMenuItem, resultadosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // conexionesToolStripMenuItem
            // 
            conexionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, conectarToolStripMenuItem, desconectarToolStripMenuItem, editorDeConexionesToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem1 });
            conexionesToolStripMenuItem.Name = "conexionesToolStripMenuItem";
            conexionesToolStripMenuItem.Size = new Size(80, 20);
            conexionesToolStripMenuItem.Text = "Conexiones";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(185, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            // 
            // conectarToolStripMenuItem
            // 
            conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            conectarToolStripMenuItem.Size = new Size(185, 22);
            conectarToolStripMenuItem.Text = "Conectar";
            // 
            // desconectarToolStripMenuItem
            // 
            desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            desconectarToolStripMenuItem.Size = new Size(185, 22);
            desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // editorDeConexionesToolStripMenuItem
            // 
            editorDeConexionesToolStripMenuItem.Name = "editorDeConexionesToolStripMenuItem";
            editorDeConexionesToolStripMenuItem.Size = new Size(185, 22);
            editorDeConexionesToolStripMenuItem.Text = "Editor de Conexiones";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(182, 6);
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(185, 22);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // comandosToolStripMenuItem
            // 
            comandosToolStripMenuItem.Name = "comandosToolStripMenuItem";
            comandosToolStripMenuItem.Size = new Size(77, 20);
            comandosToolStripMenuItem.Text = "Comandos";
            // 
            // resultadosToolStripMenuItem
            // 
            resultadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { descargarToolStripMenuItem });
            resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            resultadosToolStripMenuItem.Size = new Size(76, 20);
            resultadosToolStripMenuItem.Text = "Resultados";
            // 
            // descargarToolStripMenuItem
            // 
            descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            descargarToolStripMenuItem.Size = new Size(135, 22);
            descargarToolStripMenuItem.Text = "Descargar...";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 551);
            Controls.Add(splitContainer1);
            Controls.Add(fraConexion);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Yellow Rose";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            Move += frmPrincipal_Move;
            Resize += frmPrincipal_Resize;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            fraConexion.ResumeLayout(false);
            fraConexion.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private GroupBox fraConexion;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel tslFormSizeAndLocation;
        private Button btnInformacion;
        private Button btnConectar;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label lblCadendaConexion;
        private Label label1;
        private SplitContainer splitContainer1;
        private Label lblNombreConexion;
        private Label label5;
        private TextBox txtInstrucciones;
        private Label lblEstadoConexion;
        private DataGridView dgvResultados;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conexionesToolStripMenuItem;
        private ToolStripMenuItem comandosToolStripMenuItem;
        private ToolStripMenuItem resultadosToolStripMenuItem;
        private ToolStripMenuItem descargarToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem editorDeConexionesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}
