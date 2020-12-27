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
        Me.Height = 550

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


            Next
        Next




    End Function





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        renderer()
    End Sub
End Class
