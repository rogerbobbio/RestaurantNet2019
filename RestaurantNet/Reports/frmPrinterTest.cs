using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RestaurantNet.Reports
{
  public partial class frmPrinterTest : frmMain
  {
    public frmPrinterTest()
    {
      InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      foreach (string printerName in PrinterSettings.InstalledPrinters)
      {
        // Display the printer name.
        txtResult.AppendText("IMPRESORA INSTALADA: " + printerName + " =========================================================");
        txtResult.AppendText(Environment.NewLine);

        // Retrieve the printer settings.
        var printer = new PrinterSettings();
        printer.PrinterName = printerName;

        // Check that this is a valid printer.
        // (This step might be required if you read the printer name
        // from a user-supplied value or a registry or configuration file
        // setting.)
        if (printer.IsValid)
        {
          // Display the list of valid resolutions.
          txtResult.AppendText("Resoluciones Soportadas:");
          txtResult.AppendText(Environment.NewLine);

          foreach (PrinterResolution resolution in printer.PrinterResolutions)
          {
            txtResult.AppendText("  Resolucion: " + resolution);
            txtResult.AppendText(Environment.NewLine);
          }
          txtResult.AppendText(Environment.NewLine);

          // Display the list of valid paper sizes.
          txtResult.AppendText("Tipo de papeles Soportadas:");
          txtResult.AppendText(Environment.NewLine);

          foreach (PaperSize size in printer.PaperSizes)
          {
            if (Enum.IsDefined(size.Kind.GetType(), size.Kind))
            {              
              txtResult.AppendText("  Tamaño: " + size);
              txtResult.AppendText(Environment.NewLine);
            }
          }
          txtResult.AppendText(Environment.NewLine);
        }
      }
    }    

    private void button1_Click(object sender, EventArgs e)
    {
      string s = "PRUEBA TEST PRINTER ********"; // device-dependent string, need a FormFeed?

      // Allow the user to select a printer.
      PrintDialog pd = new PrintDialog();
      pd.PrinterSettings = new PrinterSettings();
      if (DialogResult.OK == pd.ShowDialog(this))
      {
        // Send a printer-specific to the printer.
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s);
      }
    }

    public class RawPrinterHelper
    {
      // Structure and API declarions:
      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
      public class DOCINFOA
      {
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataType;
      }
      [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

      [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool ClosePrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

      [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool EndDocPrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool StartPagePrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool EndPagePrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
      public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

      // SendBytesToPrinter()
      // When the function is given a printer name and an unmanaged array
      // of bytes, the function sends those bytes to the print queue.
      // Returns true on success, false on failure.
      public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
      {
        Int32 dwError = 0, dwWritten = 0;
        IntPtr hPrinter = new IntPtr(0);
        DOCINFOA di = new DOCINFOA();
        bool bSuccess = false; // Assume failure unless you specifically succeed.

        di.pDocName = "My C#.NET RAW Document";
        di.pDataType = "RAW";

        // Open the printer.
        if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
        {
          // Start a document.
          if (StartDocPrinter(hPrinter, 1, di))
          {
            // Start a page.
            if (StartPagePrinter(hPrinter))
            {
              // Write your bytes.
              bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
              EndPagePrinter(hPrinter);
            }
            EndDocPrinter(hPrinter);
          }
          ClosePrinter(hPrinter);
        }
        // If you did not succeed, GetLastError may give more information
        // about why not.
        if (bSuccess == false)
        {
          dwError = Marshal.GetLastWin32Error();
        }
        return bSuccess;
      }

      public static bool SendFileToPrinter(string szPrinterName, string szFileName)
      {
        // Open the file.
        FileStream fs = new FileStream(szFileName, FileMode.Open);
        // Create a BinaryReader on the file.
        BinaryReader br = new BinaryReader(fs);
        // Dim an array of bytes big enough to hold the file's contents.
        Byte[] bytes = new Byte[fs.Length];
        bool bSuccess = false;
        // Your unmanaged pointer.
        IntPtr pUnmanagedBytes = new IntPtr(0);
        int nLength;

        nLength = Convert.ToInt32(fs.Length);
        // Read the contents of the file into the array.
        bytes = br.ReadBytes(nLength);
        // Allocate some unmanaged memory for those bytes.
        pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
        // Copy the managed byte array into the unmanaged array.
        Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
        // Send the unmanaged bytes to the printer.
        bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
        // Free the unmanaged memory that you allocated earlier.
        Marshal.FreeCoTaskMem(pUnmanagedBytes);
        return bSuccess;
      }
      public static bool SendStringToPrinter(string szPrinterName, string szString)
      {
        IntPtr pBytes;
        Int32 dwCount;
        // How many characters are in the string?
        dwCount = szString.Length;
        // Assume that the printer is expecting ANSI text, and then convert
        // the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString);
        // Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
        Marshal.FreeCoTaskMem(pBytes);
        return true;
      }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument; //add the document to the dialog box...            
            printDocument.PrintPage += CreateReceipt; //add an event handler that will do the printing
                                                      //on a till you will not want to ask the user where to print but this is fine for the test envoironment.


            //printDialog.PrinterSettings.PrinterName = cbBar.Text;
            //printDocument.Print();

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            int total = 0;
            float cash = float.Parse("1000");
            float change = 0.00f;

            //this prints the reciept

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 7); //must use a mono spaced font as the spaces need to line up
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" Wangoland Coffee Shop", new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY);
            string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            float totalprice = 0.00f;

            graphic.DrawString("PRODUCTOS", new Font("Courier New", 7, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

            //foreach (string item in listBox1.Items)
            //{
            //  //create the string to print on the reciept
            //  string productDescription = item;
            //  string productTotal = item.Substring(item.Length - 6, 6);
            //  float productPrice = float.Parse(item.Substring(item.Length - 5, 5));
            //  //MessageBox.Show(item.Substring(item.Length - 5, 5) + "PROD TOTAL: " + productTotal);
            //  totalprice += productPrice;
            //  if (productDescription.Contains("  -"))
            //  {
            //    string productLine = productDescription.Substring(0, 24);
            //    graphic.DrawString(productLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);
            //    offset = offset + (int)fontHeight + 5; //make the spacing consistent
            //  }
            //  else
            //  {
            //    string productLine = productDescription;
            //    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
            //    offset = offset + (int)fontHeight + 5; //make the spacing consistent
            //  }
            //}

            change = (cash - totalprice);

            //when we have drawn all of the items add the total

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Total to pay ".PadRight(30) + string.Format("{0:c}", totalprice), new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("CASH ".PadRight(30) + string.Format("{0:c}", cash), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("CHANGE ".PadRight(30) + string.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void frmPrinterTest_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
            foreach (var strPrinter in PrinterSettings.InstalledPrinters)
            {
                cbBar.Items.Add(strPrinter);                
            }
        }

        private void btnTestImpresora_Click(object sender, EventArgs e)
        {
            var reportViewerForm = new ReportViewer();
            DataSet dsResult = DataUtil.FillDataSet(DataBaseQuerys.ImpresoraTest(), "pedido_detalle");
            if (dsResult.Tables[0].Rows.Count > 0)
            {
                reportViewerForm.dsReport = dsResult;
                reportViewerForm.reporteName = AppConstant.Reportes.Bar;
                reportViewerForm.tableNameReport = "pedido_detalle";
                reportViewerForm.printerName = string.Empty;

                if (cbBar.Text != string.Empty)
                {
                    reportViewerForm.printerName = cbBar.Text;
                    reportViewerForm.paperHeight = DataUtil.GetInt(txtAncho.Text);
                    reportViewerForm.paperWidth = DataUtil.GetInt(txtAlto.Text);
                    reportViewerForm.ShowDialog();
                }
                else
                    MessageBox.Show(@"La impresora del bar no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
