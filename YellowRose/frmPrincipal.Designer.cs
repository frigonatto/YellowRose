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
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            fraConexion = new GroupBox();
            lblNombreConexion = new Label();
            label5 = new Label();
            btnInformacion = new Button();
            btnConectar = new Button();
            button1 = new Button();
            label3 = new Label();
            lblCadendaConexion = new Label();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            textBox1 = new TextBox();
            lblEstadoConexion = new Label();
            statusStrip1.SuspendLayout();
            fraConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5 });
            statusStrip1.Location = new Point(0, 531);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(118, 17);
            toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(118, 17);
            toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(118, 17);
            toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // fraConexion
            // 
            fraConexion.Controls.Add(lblEstadoConexion);
            fraConexion.Controls.Add(lblNombreConexion);
            fraConexion.Controls.Add(label5);
            fraConexion.Controls.Add(btnInformacion);
            fraConexion.Controls.Add(btnConectar);
            fraConexion.Controls.Add(button1);
            fraConexion.Controls.Add(label3);
            fraConexion.Controls.Add(lblCadendaConexion);
            fraConexion.Controls.Add(label1);
            fraConexion.Location = new Point(11, 8);
            fraConexion.Name = "fraConexion";
            fraConexion.Size = new Size(777, 101);
            fraConexion.TabIndex = 1;
            fraConexion.TabStop = false;
            fraConexion.Text = "Conexión";
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
            btnInformacion.Location = new Point(546, 61);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(75, 23);
            btnInformacion.TabIndex = 6;
            btnInformacion.Text = "i";
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(454, 59);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 5;
            btnConectar.Text = "c";
            btnConectar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(653, 23);
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
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Location = new Point(12, 131);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Size = new Size(776, 383);
            splitContainer1.SplitterDistance = 190;
            splitContainer1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
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
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(splitContainer1);
            Controls.Add(fraConexion);
            Controls.Add(statusStrip1);
            Name = "frmPrincipal";
            Text = "YellowRose";
            Load += frmPrincipal_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            fraConexion.ResumeLayout(false);
            fraConexion.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private ToolStripStatusLabel toolStripStatusLabel5;
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
        private TextBox textBox1;
        private Label lblEstadoConexion;
    }
}
