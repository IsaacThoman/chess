Public Class ChessForm

    Public boardSquare(8, 8) As Integer

    Function setBoard()
        'white rooks
        boardSquare(1, 1) = 4
        boardSquare(8, 1) = 4
        'black rooks
        boardSquare(1, 8) = 10
        boardSquare(8, 8) = 10
        'white knights
        boardSquare(2, 1) = 3
        boardSquare(7, 1) = 3
        'black knights
        boardSquare(2, 8) = 9
        boardSquare(7, 8) = 9
        'white bishops
        boardSquare(3, 1) = 2
        boardSquare(6, 1) = 2
        'black bishops
        boardSquare(3, 8) = 9
        boardSquare(6, 8) = 9
        'kings
        boardSquare(4, 1) = 6
        boardSquare(4, 8) = 12
        'queens
        boardSquare(5, 1) = 6
        boardSquare(5, 8) = 12

        'this should fill in pawns
        Dim filler As Integer
        For filler = 1 To 8
            boardSquare(filler, 2) = 1
            boardSquare(filler, 7) = 7
        Next



    End Function

    Function renderer()
        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidBrushGreen As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim solidBrushGray As SolidBrush = New SolidBrush(Color.LightGray)
        Dim rects(8, 8) As Rectangle
        'new image stuff
        Dim myBitmap(12) As System.Drawing.Bitmap
        myBitmap(1) = New System.Drawing.Bitmap(My.Resources._1)
        myBitmap(2) = New System.Drawing.Bitmap(My.Resources._2)
        myBitmap(3) = New System.Drawing.Bitmap(My.Resources._3)
        myBitmap(4) = New System.Drawing.Bitmap(My.Resources._4)
        myBitmap(5) = New System.Drawing.Bitmap(My.Resources._5)
        myBitmap(6) = New System.Drawing.Bitmap(My.Resources._6)
        myBitmap(7) = New System.Drawing.Bitmap(My.Resources._7)
        myBitmap(8) = New System.Drawing.Bitmap(My.Resources._8)
        myBitmap(9) = New System.Drawing.Bitmap(My.Resources._9)
        myBitmap(10) = New System.Drawing.Bitmap(My.Resources._10)
        myBitmap(11) = New System.Drawing.Bitmap(My.Resources._11)
        myBitmap(12) = New System.Drawing.Bitmap(My.Resources._12)

        Dim myGraphics As Graphics


        Dim funnyModCheck
        For fillerx = 1 To 8
            For fillery = 1 To 8
                rects(fillerx, fillery) = New Rectangle((fillerx * 64) - 64, (fillery * -64) + 512, 64, 64)

                funnyModCheck = (fillerx + fillery) Mod 2


                If funnyModCheck = 0 Then
                    surface.FillRectangle(solidBrushGreen, rects(fillerx, fillery))
                Else
                    'uses solidGrayBrush for every other square. clever, right?
                    surface.FillRectangle(solidBrushGray, rects(fillerx, fillery))
                End If


                myGraphics = Graphics.FromHwnd(ActiveForm().Handle)

                If boardSquare(fillerx, fillery) > 0 Then

                    myGraphics.DrawImage(image:=myBitmap(boardSquare(fillerx, fillery)), rect:=rects(fillerx, fillery))
                End If


            Next 'these close the funny 2D loop thing
        Next




    End Function





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setBoard()
        renderer()
    End Sub
End Class
