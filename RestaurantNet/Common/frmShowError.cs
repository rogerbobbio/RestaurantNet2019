namespace RestaurantNet.Common
{
  public partial class frmShowError : frmMain
  {
    public string MensajeError;
    public string SentenciaError;

    public frmShowError()
    {
      InitializeComponent();
    }

    private void frmShowError_Load(object sender, System.EventArgs e)
    {
      txtMensajeError.Text = MensajeError;
      txtSentenciaError.Text = SentenciaError;
    }
  }
}
