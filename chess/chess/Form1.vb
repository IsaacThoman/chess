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
        Dim myBitmap(1, 12) As System.Drawing.Bitmap
        Dim myGraphics As Graphics


        Dim funnyModCheck
        For fillerx = 1 To 8
            For fillery = 1 To 8
                rects(fillerx, fillery) = New Rectangle((fillerx * 64) - 64, (fillery * 64) - 64, 64, 64)

                funnyModCheck = (fillerx + fillery) Mod 2



                If funnyModCheck = 0 Then
                    surface.FillRectangle(solidBrushGreen, rects(fillerx, fillery))
                Else
                    'uses solidGrayBrush for every other square. clever, right?
                    surface.FillRectangle(solidBrushGray, rects(fillerx, fillery))
                End If


                '           'EEK! I wish I knew of a better way than all of these ugly if statements!
                '           If boardSquare(fillerx, fillery) = 1 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._1)
                '           ElseIf boardSquare(fillerx, fillery) = 2 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._2)
                '           ElseIf boardSquare(fillerx, fillery) = 3 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._3)
                '           ElseIf boardSquare(fillerx, fillery) = 4 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._4)
                '           ElseIf boardSquare(fillerx, fillery) = 5 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._5)
                '           ElseIf boardSquare(fillerx, fillery) = 6 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._6)
                '           ElseIf boardSquare(fillerx, fillery) = 7 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._7)
                '           ElseIf boardSquare(fillerx, fillery) = 8 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._8)
                '           ElseIf boardSquare(fillerx, fillery) = 9 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._9)
                '           ElseIf boardSquare(fillerx, fillery) = 10 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._10)
                '           ElseIf boardSquare(fillerx, fillery) = 11 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._11)
                '           ElseIf boardSquare(fillerx, fillery) = 12 Then
                '           Dim myBitmap As Bitmap = New System.Drawing.Bitmap(My.Resources._12)
                '
                '                End If
                '



                'renders out the actual image you just defined
                myGraphics = Graphics.FromHwnd(ActiveForm().Handle)
                myGraphics.DrawImage(image:=myBitmap(1, 1), rect:=rects(1, 1))

            Next 'these close the funny 2D loop thing
        Next




    End Function





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        renderer()
    End Sub
End Class
