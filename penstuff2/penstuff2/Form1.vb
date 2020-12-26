Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidb As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim rect1 As Rectangle = New Rectangle(0, 0, 50, 50)

        surface.FillRectangle(solidb, rect1)

    End Sub
End Class
