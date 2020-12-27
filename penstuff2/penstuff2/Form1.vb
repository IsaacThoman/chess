Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidb As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim rect1 As Rectangle = New Rectangle(0, 0, 64, 64)

        ' surface.FillRectangle(solidb, rect1)




        '  Dim myBitmap As Bitmap = New Bitmap(64, 64)
        '  myBitmap = Bitmap.FromFile("c:\8.png")
        '  Dim g As Graphics = Graphics.FromImage(myBitmap)

        ' Dim Image1 = Image.FromFile("c:\8.png")
        ' g.DrawImage(Image1, 64, 64, 64, 64)

        ' Image1 = myBitmap.Clone




        ' ---------------------------------------------------- stolen code
        Dim myBitmap As System.Drawing.Bitmap
        Dim myGraphics As Graphics



        myBitmap = New System.Drawing.Bitmap(filename:="c:/8.png")

        'return the current form as a drawing surface
        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)
        myGraphics.DrawImage(image:=myBitmap, rect:=rect1)



    End Sub
End Class
