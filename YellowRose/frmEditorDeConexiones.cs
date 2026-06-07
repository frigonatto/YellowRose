using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YellowRose.Clases;

namespace YellowRose
{
    public partial class frmEditorDeConexiones : Form
    {
        private bool modoEdicion;
        private Connection conexionActual;

        public frmEditorDeConexiones()
        {
            InitializeComponent();
        }

        private void frmEditorDeConexiones_Load(object sender, EventArgs e)
        {

        }

        private void frmEditorDeConexiones_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !modoEdicion)
            {
                modoEdicion = true;
                configurarGUI();
            }

            if (e.KeyCode == Keys.F5 && modoEdicion)
            {
                //cargarGrilla();
            }

            if (e.KeyCode == Keys.F6 && modoEdicion)
            {
                //agregarCondicionDePago(sender, e);
            }
        }

        private void frmEditorDeConexiones_Move(object sender, EventArgs e)
        {
            updateFormSizeAndLocation();
        }

        private void frmEditorDeConexiones_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormData.SaveFormSizeAndPosition(this);
        }

        private void frmEditorDeConexiones_Resize(object sender, EventArgs e)
        {
            updateFormSizeAndLocation();
        }


        private void configurarGUI()
        {

            if (modoEdicion)
            {
                tslModo.Text = "Editar";
            }
            else
            {
                tslModo.Text = "Agregar";
            }
        }

        private void mostrarConexionActual()
        {

        }


        #region Form Size And Location
        private void updateFormSizeAndLocation()
        {
            tslFormSizeAndLocation.Text = "Size: " + this.Size.Width.ToString() + ", " + this.Size.Height.ToString();
            tslFormSizeAndLocation.Text += " | Location: " + this.Location.X.ToString() + ", " + this.Location.Y.ToString();
        }
        private void getFormSizeAndLocation()
        {
            FormDataResponse respuesta = FormData.GetFormSizeAndPosition(this.Name);
            if (respuesta.StatusCode == 200 && respuesta.Data != null)
            {
                this.Size = new Size(respuesta.Data.FormSize_Width, respuesta.Data.FormSize_Height);
                this.Location = new Point(respuesta.Data.FormLocation_X, respuesta.Data.FormLocation_Y);
                if (Enum.TryParse<FormWindowState>(respuesta.Data.FormWindowState, out FormWindowState windowState))
                {
                    this.WindowState = windowState;
                }
            }

            updateFormSizeAndLocation();
        }

        #endregion


    }
}
