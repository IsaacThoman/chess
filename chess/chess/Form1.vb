Public Class Form1

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
