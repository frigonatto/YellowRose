using YellowRose.Clases;

namespace YellowRose
{
    public partial class frmPrincipal : Form
    {
        public Connection conexionActual;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            getFormSizeAndLocation();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormData.SaveFormSizeAndPosition(this);
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            updateFormSizeAndLocation();
        }
        private void frmPrincipal_Move(object sender, EventArgs e)
        {
            updateFormSizeAndLocation();
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
