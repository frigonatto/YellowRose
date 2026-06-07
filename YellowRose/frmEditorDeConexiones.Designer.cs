namespace YellowRose
{
    partial class frmEditorDeConexiones
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            tslModo = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            tslFormSizeAndLocation = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            lstConexiones = new ListBox();
            fraConexionSeleccionada = new GroupBox();
            chkEncriptarPassword = new CheckBox();
            btnGenerarArchivo = new Button();
            btnProbarConexion = new Button();
            lblCadenaDeConexion = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            chkSeguridadIntegrada = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            fraConexionSeleccionada.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, tslModo, toolStripStatusLabel4, tslFormSizeAndLocation });
            statusStrip1.Location = new Point(0, 441);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel1.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(122, 19);
            toolStripStatusLabel1.Text = ".";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(122, 19);
            toolStripStatusLabel2.Text = ".";
            // 
            // tslModo
            // 
            tslModo.AutoSize = false;
            tslModo.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tslModo.BorderStyle = Border3DStyle.Sunken;
            tslModo.Name = "tslModo";
            tslModo.Size = new Size(122, 19);
            tslModo.Text = ".";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.AutoSize = false;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel4.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(122, 19);
            toolStripStatusLabel4.Text = ".";
            // 
            // tslFormSizeAndLocation
            // 
            tslFormSizeAndLocation.AutoSize = false;
            tslFormSizeAndLocation.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tslFormSizeAndLocation.BorderStyle = Border3DStyle.Sunken;
            tslFormSizeAndLocation.Name = "tslFormSizeAndLocation";
            tslFormSizeAndLocation.Size = new Size(250, 19);
            tslFormSizeAndLocation.Text = ".";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstConexiones);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(fraConexionSeleccionada);
            splitContainer1.Size = new Size(800, 441);
            splitContainer1.SplitterDistance = 240;
            splitContainer1.TabIndex = 1;
            // 
            // lstConexiones
            // 
            lstConexiones.Dock = DockStyle.Fill;
            lstConexiones.FormattingEnabled = true;
            lstConexiones.Location = new Point(0, 0);
            lstConexiones.Name = "lstConexiones";
            lstConexiones.Size = new Size(236, 437);
            lstConexiones.TabIndex = 0;
            // 
            // fraConexionSeleccionada
            // 
            fraConexionSeleccionada.Controls.Add(chkEncriptarPassword);
            fraConexionSeleccionada.Controls.Add(btnGenerarArchivo);
            fraConexionSeleccionada.Controls.Add(btnProbarConexion);
            fraConexionSeleccionada.Controls.Add(lblCadenaDeConexion);
            fraConexionSeleccionada.Controls.Add(label7);
            fraConexionSeleccionada.Controls.Add(label6);
            fraConexionSeleccionada.Controls.Add(textBox6);
            fraConexionSeleccionada.Controls.Add(textBox5);
            fraConexionSeleccionada.Controls.Add(label5);
            fraConexionSeleccionada.Controls.Add(textBox4);
            fraConexionSeleccionada.Controls.Add(textBox3);
            fraConexionSeleccionada.Controls.Add(label4);
            fraConexionSeleccionada.Controls.Add(label3);
            fraConexionSeleccionada.Controls.Add(chkSeguridadIntegrada);
            fraConexionSeleccionada.Controls.Add(textBox2);
            fraConexionSeleccionada.Controls.Add(textBox1);
            fraConexionSeleccionada.Controls.Add(label2);
            fraConexionSeleccionada.Controls.Add(label1);
            fraConexionSeleccionada.Location = new Point(16, 20);
            fraConexionSeleccionada.Name = "fraConexionSeleccionada";
            fraConexionSeleccionada.Size = new Size(526, 370);
            fraConexionSeleccionada.TabIndex = 0;
            fraConexionSeleccionada.TabStop = false;
            fraConexionSeleccionada.Text = "Conexión Seleccionada";
            // 
            // chkEncriptarPassword
            // 
            chkEncriptarPassword.AutoSize = true;
            chkEncriptarPassword.Location = new Point(357, 106);
            chkEncriptarPassword.Name = "chkEncriptarPassword";
            chkEncriptarPassword.Size = new Size(136, 19);
            chkEncriptarPassword.TabIndex = 9;
            chkEncriptarPassword.Text = "Encriptar Contraseña";
            chkEncriptarPassword.UseVisualStyleBackColor = true;
            // 
            // btnGenerarArchivo
            // 
            btnGenerarArchivo.Location = new Point(12, 331);
            btnGenerarArchivo.Name = "btnGenerarArchivo";
            btnGenerarArchivo.Size = new Size(110, 23);
            btnGenerarArchivo.TabIndex = 17;
            btnGenerarArchivo.Text = "Generar Archivo";
            btnGenerarArchivo.UseVisualStyleBackColor = true;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(430, 142);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(75, 23);
            btnProbarConexion.TabIndex = 12;
            btnProbarConexion.Text = "Probar";
            btnProbarConexion.UseVisualStyleBackColor = true;
            // 
            // lblCadenaDeConexion
            // 
            lblCadenaDeConexion.AutoSize = true;
            lblCadenaDeConexion.Location = new Point(136, 301);
            lblCadenaDeConexion.Name = "lblCadenaDeConexion";
            lblCadenaDeConexion.Size = new Size(124, 15);
            lblCadenaDeConexion.TabIndex = 16;
            lblCadenaDeConexion.Text = "lblCadenaDeConexion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 301);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 15;
            label7.Text = "Cadena de Conexión:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 150);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 10;
            label6.Text = "Nombre:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(90, 189);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(415, 81);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(90, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 13;
            label5.Text = "Descripción:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(227, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 104);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 73);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario:";
            // 
            // chkSeguridadIntegrada
            // 
            chkSeguridadIntegrada.AutoSize = true;
            chkSeguridadIntegrada.Location = new Point(17, 72);
            chkSeguridadIntegrada.Name = "chkSeguridadIntegrada";
            chkSeguridadIntegrada.Size = new Size(132, 19);
            chkSeguridadIntegrada.TabIndex = 4;
            chkSeguridadIntegrada.Text = "Seguridad Integrada";
            chkSeguridadIntegrada.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(405, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 32);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Catalog:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Data Source:";
            // 
            // frmEditorDeConexiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "frmEditorDeConexiones";
            Text = "Yellow Rose";
            FormClosing += frmEditorDeConexiones_FormClosing;
            Load += frmEditorDeConexiones_Load;
            KeyUp += frmEditorDeConexiones_KeyUp;
            Move += frmEditorDeConexiones_Move;
            Resize += frmEditorDeConexiones_Resize;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            fraConexionSeleccionada.ResumeLayout(false);
            fraConexionSeleccionada.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private ListBox lstConexiones;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tslModo;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel tslFormSizeAndLocation;
        private GroupBox fraConexionSeleccionada;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private CheckBox chkSeguridadIntegrada;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label lblCadenaDeConexion;
        private Label label7;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button btnProbarConexion;
        private CheckBox chkEncriptarPassword;
        private Button btnGenerarArchivo;
    }
}