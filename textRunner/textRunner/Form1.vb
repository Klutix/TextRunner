Public Class frm_textRunner
    Dim strInLine As String
    Dim currentLine As Integer = 0
    Dim LastLine As Integer
    Dim player As String = "v"
    Dim map() As String
    Dim direction As Integer = 0
    Dim blnCollision As Boolean
    Dim isrunning As Boolean = False
    Dim arGameOvar() As String
    Dim strGAMEOVER As String
    Dim newRound As Boolean
    Dim gameOerSwitchTic As Integer = 0



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        newRound = True
        isrunning = True
        GameOvar.Enabled = False
        strInLine = ""
        strInLine = My.Computer.FileSystem.ReadAllText("E:\p.txt")
        strGAMEOVER = My.Computer.FileSystem.ReadAllText("E:\GAMEOVER.txt")


        RichTextBox1.Text = strInLine
        map = Split(strInLine, "|")
        GameLoopTimer.Enabled = True


    End Sub


    Public Function insertV(ByRef location As Integer) As Boolean
        If (currentLine < UBound(map)) Then
            If (map(location).Substring(12 + direction, 1) = " ") Or newRound = True Then


                map(location) = map(location).Remove(12 + direction, 1)
                map(location) = map(location).Insert(12 + direction, player)

                'remove a space to keep things looking even
                'map(location) = map(location).Remove(13, 2)

                RichTextBox1.SelectionStart = currentLine
                newRound = False
            Else
                GameLoopTimer.Enabled = False


                Return False
                Exit Function

            End If
        End If

        Return True

    End Function

    Public Sub buildString()
        strInLine = ""
        For x = currentLine - 1 To UBound(map)
            strInLine += map(x)
        Next
    End Sub

    'Public Sub removeV(ByRef lastLne As Integer)
    '    If (currentLine < UBound(map)) Then
    '        If map(lastLne).Contains(",") Then
    '            map(lastLne) = map(lastLne).Replace("v", " ")

    '            'insert a space to keep things looking even
    '            map(lastLne) = map(lastLne).Insert(13 + direction, " ")
    '        End If
    '    End If
    'End Sub





    Private Sub GameLoopTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameLoopTimer.Tick


        If (isrunning = True) Then

            '1 check user user input
            txtHiddenControl.Focus()

            '2.insert v into string 
            If (insertV(currentLine)) Then
                currentLine += 1
                LastLine = currentLine - 1
            Else
                gameOver()
                Exit Sub
            End If
            '3.rebuild string
            buildString()



            '3.redraw
            RichTextBox1.Text = strInLine
            RichTextBox1.Lines(currentLine + 3) += RichTextBox1.Lines(currentLine).Insert(12 + direction, player)


        End If


    End Sub





    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHiddenControl.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad4

                direction += -1

            Case Keys.NumPad6
                direction += 1
        End Select

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtHiddenControl.Focus()

    End Sub

    Public Sub gameOver()
        GameLoopTimer.Enabled = False
        isrunning = False

        RichTextBox1.Text = strGAMEOVER
        arGameOvar = Split(strGAMEOVER, "|")



        GameOvar.Enabled = True
    End Sub

    Private Sub GameOvar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameOvar.Tick




        gameOver()
        rebuildGAMEOVERstr()
    End Sub

    Public Sub rebuildGAMEOVERstr()
        Select Case gameOerSwitchTic
            Case 1
                strGAMEOVER = strGAMEOVER.Replace("GAME", "OVER")
                gameOerSwitchTic = 0
            Case 0
                strGAMEOVER = strGAMEOVER.Replace("OVER", "GAME")
                gameOerSwitchTic = 1
        End Select


    End Sub

End Class
