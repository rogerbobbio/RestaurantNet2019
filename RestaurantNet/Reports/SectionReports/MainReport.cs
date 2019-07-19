using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System.ComponentModel;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for UISO.
    /// </summary>
    public partial class MainReport : SectionReport
    {
        #region Properties
        [Browsable(false)]
        public virtual string ReportTitle
        {
            get { return string.Empty; }
            set { }
        }
        protected virtual GrapeCity.ActiveReports.SectionReportModel.TextBox PageNumberControl
        {
            get { return null; }
        }
        protected virtual Margins PortraitDefaultMargins
        {
            get { return new Margins(0.5f, 0.5f, 0.5f, 0.5f); }
        }
        protected virtual Margins LandscapeDefaultMargins
        {
            get { return new Margins(0.5f, 0.5f, 0.5f, 0.5f); }
        }
        #endregion

        #region Page Settings and Margins
        protected virtual void SetPageSettings()
        {
            SetDefaultPortraitPageSettings();
        }
        protected void SetDefaultPortraitPageSettings()
        {
            //PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            PageSettings.Orientation = PageOrientation.Portrait;
            SetDefaultPageMargins();
        }
        protected void SetDefaultLandscapePageSettings()
        {
            //PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            PageSettings.Orientation = PageOrientation.Landscape;
            SetDefaultPageMargins();
        }
        public void SetDefaultPageMargins()
        {
            if (PageSettings.Orientation == PageOrientation.Landscape)
                PageSettings.Margins = this.LandscapeDefaultMargins;
            else
              if (PageSettings.Orientation == PageOrientation.Portrait)
                PageSettings.Margins = this.PortraitDefaultMargins;
        }
        #endregion

        #region PageNumber
        protected virtual void SetPageNumberControl()
        {
            SetPageNumberControl(PageNumberControl);
        }
        protected void SetPageNumberControl(GrapeCity.ActiveReports.SectionReportModel.TextBox pageNumberTextBox)
        {
            if (pageNumberTextBox != null)
            {
                pageNumberTextBox.SummaryRunning = SummaryRunning.All;
                pageNumberTextBox.SummaryType = SummaryType.PageCount;
            }
        }
        #endregion        

        protected virtual void MainReport_ReportStart(object sender, System.EventArgs e)
        {
            SetPageSettings();
            SetPageNumberControl();
        }
    }
}
