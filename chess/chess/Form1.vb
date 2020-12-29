Public Class ChessForm




    Public boardSquare(9, 9) As Integer
    Public legalMoves(9, 9) As Boolean  'This should really be 8, but I made it 9 to make the screaming stop.

    ' 1, 2 is from position, 3, 4 is to position in x,y format
    Public selections(4) As Integer


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
        boardSquare(3, 8) = 8
        boardSquare(6, 8) = 8
        'kings
        boardSquare(4, 1) = 5
        boardSquare(4, 8) = 11
        'queens
        boardSquare(5, 1) = 6
        boardSquare(5, 8) = 12

        'this should fill in pawns
        Dim filler As Integer
        For filler = 1 To 8
            boardSquare(filler, 2) = 1
            boardSquare(filler, 7) = 7
        Next

        'clears the rest of the board

        Dim clearer As Integer
        For clearer = 1 To 8
            boardSquare(clearer, 3) = 0
            boardSquare(clearer, 4) = 0
            boardSquare(clearer, 5) = 0
            boardSquare(clearer, 6) = 0
        Next

        selections(0) = 0
        selections(1) = 0
        selections(2) = 0
        selections(3) = 0
        selections(4) = 0


    End Function

    Function renderer()
        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidBrushGreen As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim solidBrushGray As SolidBrush = New SolidBrush(Color.LightGray)
        Dim solidBrushYellow As SolidBrush = New SolidBrush(Color.LightYellow)
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



                If selections(1) = fillerx And selections(2) = fillery Then
                    surface.FillRectangle(solidBrushYellow, rects(fillerx, fillery))

                    '   ElseIf selections(3) = fillerx And selections(4) = fillery Then
                    '     surface.FillRectangle(solidBrushYellow, rects(fillerx, fillery))
                    'commented because it doesn't do anything because it resets before re-rendering. Maybe it shouldn't do that?

                Else


                    If funnyModCheck = 0 Then
                        surface.FillRectangle(solidBrushGreen, rects(fillerx, fillery))
                    Else
                        'uses solidGrayBrush for every other square. clever, right?
                        surface.FillRectangle(solidBrushGray, rects(fillerx, fillery))
                    End If


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

    Private Sub ChessForm_Click(sender As Object, e As EventArgs) Handles Me.Click



        If selections(0) = 0 Then
            selections(1) = (MousePosition.X - Me.Left - 32) / 64 + 1
            selections(2) = 0 - (MousePosition.Y - Me.Top) / 64 + 9
            selections(0) = 1



            '  --------------------------------------- The scary stuff goes somewhere in here
            Dim clearerx As Integer
            Dim clearery As Integer
            For clearerx = 1 To 8
                For clearery = 1 To 8
                    legalMoves(clearerx, clearery) = False
                Next
            Next



            Dim myX As Integer = selections(1)
            Dim myY As Integer = selections(2)

            If boardSquare(myX, myY) = 0 Then
                '                                   If selected square is empty, do nothing?
            ElseIf boardSquare(myX, myY) = 1 Then
                ' white pawn code



                If boardSquare(myX, myY + 1) = 0 Then
                    legalMoves(myX, myY + 1) = True      'move forward one
                End If

                If myY = 2 And boardSquare(myX, 2 + 2) = 0 Then 'This checks if the pawn can move forward 2, used to have myY + 2, but that creates errors when searching with the pawn at the end of the board
                    legalMoves(myX, myY + 2) = True
                End If

                If boardSquare(myX + 1, myY + 1) > 6 Then 'right capture
                    legalMoves(myX + 1, myY + 1) = True
                End If

                If boardSquare(myX - 1, myY + 1) > 6 Then
                    legalMoves(myX - 1, myY + 1) = True   ' left capture
                End If




            End If






            Else


            selections(3) = (MousePosition.X - Me.Left - 32) / 64 + 1
            selections(4) = 0 - (MousePosition.Y - Me.Top) / 64 + 9




            ' This is a very confusing way to swap out 2 pieces


            Dim source(2) As Integer
            Dim destination(2) As Integer


            source(1) = selections(1)
            source(2) = selections(2)
            destination(1) = selections(3)
            destination(2) = selections(4)

            Dim sourcePiece As Integer = boardSquare(source(1), source(2))
            Dim destinationPiece As Integer = boardSquare(destination(1), destination(2))


            If legalMoves(destination(1), destination(2)) = True Then


                boardSquare(source(1), source(2)) = destinationPiece
                boardSquare(destination(1), destination(2)) = sourcePiece

            End If



            selections(1) = 0
                selections(2) = 0
                selections(3) = 0
                selections(4) = 0

                selections(0) = 0






                'please burn this when you do rules tomorrow
                'forget I said that



            End If




            renderer()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)



    End Sub
End Class
