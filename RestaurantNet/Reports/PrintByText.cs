using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RestaurantNet.Reports
{
    public sealed class PrintByText
    {
        static internal DataSet dsReport = new DataSet();
        public static void printDocument(string printerName, DataSet dsData, string tipo)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            dsReport = dsData;
            printDialog.Document = printDocument;
            if (tipo == "B")
                printDocument.PrintPage += CreateTicketForBar;
            else
                printDocument.PrintPage += CreateTicketForKitchen;
            printDialog.PrinterSettings.PrinterName = printerName;
            printDocument.Print();
        }        

        private static void CreateTicketForBar(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 7); //must use a mono spaced font as the spaces need to line up
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            var currentDateTime = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");

            graphic.DrawString("BAR - " + currentDateTime, new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY);

            var mesaDesc = "BARRA / PARA LLEVAR";
            var mesaId = DataUtil.GetString(dsReport.Tables[0].Rows[0], "Mesa_id");
            if (mesaId != string.Empty)
            {
                var sWhere = "mesa_id = " + mesaId + "";
                mesaDesc = DataUtil.FindSingleRow("mesa", "Mesa_descripcion", sWhere);
            }

            var line = "Mesa: " + mesaDesc;
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            line = "Orden #: " + DataUtil.GetString(dsReport.Tables[0].Rows[0], "Orden_turno");
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            line = "Pedido #: " + DataUtil.GetString(dsReport.Tables[0].Rows[0], "Pedido_id");
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            line = "Mozo: " + DataUtil.GetString(dsReport.Tables[0].Rows[0], "AtendidoPor");
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            string top = "Cant.  Producto";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);            
            offset = offset + (int)fontHeight + 5; //make the spacing consistent


            foreach (DataRow productoRow in dsReport.Tables[0].Rows)
            {
                var cantidad = DataUtil.GetString(productoRow["Pedido_cantidad"]);
                var descripcion = DataUtil.GetString(productoRow["Descripcion_Producto"]);
                var product = cantidad + "  " + descripcion;
                if (product.Length > 24)
                {
                    product.Substring(0, 24);
                }                
                graphic.DrawString(product, font, new SolidBrush(Color.Red), startX, startY + offset);
                offset = offset + (int)fontHeight + 5; //make the spacing consistent
            }
        }
        private static void CreateTicketForKitchen(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 7); //must use a mono spaced font as the spaces need to line up
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            var currentDateTime = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");

            graphic.DrawString("COCINA - " + currentDateTime, new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY);

            var mesaDesc = "BARRA / PARA LLEVAR";
            var mesaId = DataUtil.GetString(dsReport.Tables[0].Rows[0], "Mesa_id");
            if (mesaId != string.Empty)
            {
                var sWhere = "mesa_id = " + mesaId + "";
                mesaDesc = DataUtil.FindSingleRow("mesa", "Mesa_descripcion", sWhere);
            }

            var line = "Mesa: " + mesaDesc;
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            line = "Orden #: " + DataUtil.GetString(dsReport.Tables[0].Rows[0], "Orden_turno");
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            line = "Pedido #: " + DataUtil.GetString(dsReport.Tables[0].Rows[0], "Pedido_id");
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            line = "Mozo: " + DataUtil.GetString(dsReport.Tables[0].Rows[0], "AtendidoPor");
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            string top = "Cant.  Producto";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);            
            offset = offset + (int)fontHeight + 5; //make the spacing consistent


            foreach (DataRow productoRow in dsReport.Tables[0].Rows)
            {
                var cantidad = DataUtil.GetString(productoRow["Pedido_cantidad"]);
                var descripcion = DataUtil.GetString(productoRow["Descripcion_Producto"]);
                var product = cantidad + "  " + descripcion;
                if (product.Length > 24)
                {
                    product.Substring(0, 24);
                }
                graphic.DrawString(product, font, new SolidBrush(Color.Red), startX, startY + offset);
                offset = offset + (int)fontHeight + 5; //make the spacing consistent
            }
        }
    }
}
