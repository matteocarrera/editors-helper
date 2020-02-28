using System;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iFont = iTextSharp.text.Font;
using iImage = iTextSharp.text.Image;
using FontStyle = System.Drawing.FontStyle;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace Editor_Helper
{
    class Report
    {
        private readonly Document _reportPDF = new Document(PageSize.A5.Rotate());
        private iFont _regularFont = SetiTextSharpFont("Gothic.ttf", 9, (int)FontStyle.Regular);
        private readonly Main _main;
        private readonly string _filePath;

        internal Report(Main main, string filePath)
        {
            _main = main;
            _filePath = filePath;
        }

        internal void Create()
        {
            try
            {
                PdfWriter.GetInstance(_reportPDF, new FileStream(_filePath, FileMode.Create));
                _reportPDF.Open();

                Append(iImage.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png), 150f, 150f, Element.ALIGN_CENTER);

                string title = "Отчет о работе редактора за " + DateTime.Now.Date.ToString("d");
                Paragraph mainTitle = new Paragraph(title, _regularFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingBefore = 20,
                    SpacingAfter = 10
                };
                _reportPDF.Add(mainTitle);

                Append(_main.InfoLabel.Text, FontStyle.Regular);
                Append(_main.NameLabel.Text, FontStyle.Bold);
                Append(_main.TimeInfoLabel.Text, FontStyle.Regular);
                Append(ParseTime(_main._currentTimer), FontStyle.Bold);
                Append(_main.KeysInfoLabel.Text, FontStyle.Regular);
                Append(_main.KeysLabel.Text, FontStyle.Bold);
                Append("График активности во время работы (импортирован из программы):", FontStyle.Regular);
                Append(_main.KeysPressedChart);

                _reportPDF.Close();
                Process.Start(_filePath);
            }
            catch { }
        }

        private void Append(string text, FontStyle fontStyle)
        {
            _regularFont = SetiTextSharpFont("Gothic.ttf", 9, (int)fontStyle);
            _reportPDF.Add(new Paragraph(text, _regularFont));
        }

        private void Append(iImage image, float width, float height, int alignment)
        {
            image.ScaleToFit(width, height);
            image.Alignment = alignment;
            _reportPDF.Add(image);
        }

        private void Append(Chart chart)
        {
            SetChartProperties(chart, 14f, 2f);

            var chartImage = new MemoryStream();
            chart.SaveImage(chartImage, ChartImageFormat.Png);
            iImage img = iImage.GetInstance(chartImage.GetBuffer());
            img.Alignment = Element.ALIGN_CENTER;
            img.ScaleToFit(350f, 300f);
            _reportPDF.Add(img);

            SetChartProperties(chart, 8.5f, 0.5f);
        }

        private string ParseTime(TimeSpan timeSpan)
        {
            string readableTime = string.Empty;
            if (timeSpan.Hours != 0)
            {
                readableTime += timeSpan.Hours.ToString();
                readableTime += ParseEnding(new string[] { " часов ", " часа ", " час " }, timeSpan.Hours);
            } 
            readableTime += timeSpan.Minutes.ToString();
            readableTime += ParseEnding(new string[] { " минут", " минуты", " минута" }, timeSpan.Minutes);
            return readableTime;
        }

        private string ParseEnding(string[] endings, int time)
        {
            int firstEnding = time % 100;
            if (firstEnding >= 11 && firstEnding <= 14) return endings[0];
            else
            {
                int secondEnding = firstEnding % 10;
                switch (secondEnding)
                {
                    case 1:
                        return endings[2];
                    case 2:
                    case 3:
                    case 4:
                        return endings[1];
                    default:
                        return endings[0];
                }
            }
        }

        private void SetChartProperties(Chart chart, float fontSize, float sizeMultiplier)
        {
            var chartReportFont = new System.Drawing.Font("Century Gothic", fontSize);
            var chartReportFontBold = new System.Drawing.Font("Century Gothic", fontSize, FontStyle.Bold);
            chart.Width = Convert.ToInt32(chart.Width * sizeMultiplier);
            chart.Height = Convert.ToInt32(chart.Height * sizeMultiplier);
            chart.Titles["MainTitle"].Font = chartReportFontBold;
            chart.ChartAreas[0].AxisX.TitleFont = chartReportFont;
            chart.ChartAreas[0].AxisX.LabelStyle.Font = chartReportFont;
            chart.ChartAreas[0].AxisY.TitleFont = chartReportFont;
            chart.ChartAreas[0].AxisY.LabelStyle.Font = chartReportFont;
        }

        private static iFont SetiTextSharpFont(string fontName, float fontSize, int fontStyle)
        {
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), fontName);
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            return new iFont(baseFont, fontSize, fontStyle);
        }
    }
}