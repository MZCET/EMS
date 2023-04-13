Imports System.IO
Imports System.Reflection.Metadata
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Document = iTextSharp.text.Document

Public Class pdf
    Private Sub CreatePDF()
        Dim doc As New Document()
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("D:/template.pdf", FileMode.Create))
        doc.Open()

        ' Set the margins to 50pt on all sides
        doc.SetMargins(30, 30, 30, 30)

        ' Get the content byte of the document
        Dim cb As PdfContentByte = writer.DirectContent

        ' Set the stroke color and line width
        cb.SetRGBColorStroke(255, 0, 0)
        cb.SetLineWidth(3
                        )

        ' Draw a rectangle around the content area
        cb.Rectangle(doc.LeftMargin, doc.BottomMargin, doc.PageSize.Width - doc.LeftMargin - doc.RightMargin, doc.PageSize.Height - doc.TopMargin - doc.BottomMargin)
        cb.Stroke()

        ' Load the image from a file
        Dim img As Image = Image.GetInstance("D:\image.jpg")

        ' Set the position of the image in the top right corner of the margin with a 30pt gap
        img.SetAbsolutePosition(doc.PageSize.Width - doc.RightMargin - img.Width, doc.PageSize.Height - doc.TopMargin - img.Height)
        img.ScaleAbsolute(130, 150)
        ' Add the image to the content byte
        cb.AddImage(img)

        ' Add some text to the document
        Dim titleFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24, BaseColor.BLACK)
        Dim title As New Paragraph("Mount Zion College of Engineering", titleFont)


        title.Alignment = Element.ALIGN_CENTER
        doc.Add(title)

        ' Close the document
        doc.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreatePDF()
    End Sub
End Class

