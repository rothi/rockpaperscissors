Public Class lblTitle
    Dim intCompScore As Integer = 0
    Dim intHumanScore As Integer = 0
    Dim intCompThrow As Integer
    Dim intRock As Integer = 1
    Dim intPaper As Integer = 2
    Dim intScissors As Integer = 3

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        Select Case Me.rdoRock.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblAnswer.Text = "You throw rock. Computer throws rock. Tie."
                    Case 2
                        Me.lblAnswer.Text = "You throw rock. Computer throws paper. You lose."
                        Me.intCompScore += 1
                    Case 3
                        Me.lblAnswer.Text = "You throw rock. Computer throws scissors. You win."
                        Me.intHumanScore += 1
                End Select
            Case False
        End Select

        Select Case Me.rdoPaper.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblAnswer.Text = "You throw paper. Computer throws rock. You win."
                        Me.intHumanScore += 1
                    Case 2
                        Me.lblAnswer.Text = "You throw paper. Computer throws paper. Tie."
                    Case 3
                        Me.lblAnswer.Text = "You throw paper. Computer throws scissors. You lose."
                        Me.intCompScore += 1
                End Select
            Case False
        End Select

        Select Case Me.rdoScissors.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblAnswer.Text = "You throw scissors. Computer throws rock. You lose."
                        Me.intCompScore += 1
                    Case 2
                        Me.lblAnswer.Text = "You throw scissors. Computer throws paper. You win."
                        Me.intHumanScore += 1
                    Case 3
                        Me.lblAnswer.Text = "You throw scissors. Computer throws scissors. Tie."
                End Select
            Case False
        End Select

        If intCompScore = 10 Then
            Me.btnSubmit.Enabled = False
            Me.btnSubmitIf.Enabled = False
            Me.lblFinal.Text = "Computer Wins Overall"
        ElseIf intHumanScore = 10 Then
            Me.btnSubmit.Enabled = False
            Me.btnSubmitIf.Enabled = False
            Me.lblFinal.Text = "You Win Overall"
        End If

        Me.lblCompScore.Text = intCompScore
        Me.lblHumanScore.Text = intHumanScore

    End Sub

    Private Sub btnSumbitIf_Click(sender As Object, e As EventArgs) Handles btnSubmitIf.Click

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If Me.rdoRock.Checked = True And intCompThrow = 1 Then
            Me.lblAnswer.Text = "Tie. Both throw Rock"
        ElseIf Me.rdoRock.Checked = True And intCompThrow = 2 Then
            Me.lblAnswer.Text = "Paper beats Rock. You Lose"
            Me.intCompScore += 1
        ElseIf Me.rdoRock.Checked = True And intCompThrow = 3 Then
            Me.lblAnswer.Text = "Rock beats Scissors. You Win"
            Me.intHumanScore += 1
        End If

        If Me.rdoPaper.Checked = True And intCompThrow = 1 Then
            Me.lblAnswer.Text = "Paper Covers Rock. You Win"
            Me.intHumanScore += 1
        ElseIf Me.rdoPaper.Checked = True And intCompThrow = 2 Then
            Me.lblAnswer.Text = "Tie. Both throw Paper"
        ElseIf Me.rdoPaper.Checked = True And intCompThrow = 3 Then
            Me.lblAnswer.Text = "Scissors cits Paper. You Lose"
            Me.intCompScore += 1
        End If

        If Me.rdoScissors.Checked = True And intCompThrow = 1 Then
            Me.lblAnswer.Text = "Rock beats Scissors. You Lose"
            Me.intCompScore += 1
        ElseIf Me.rdoScissors.Checked = True And intCompThrow = 2 Then
            Me.lblAnswer.Text = "Scissors cuts Paper. You Win."
            Me.intHumanScore += 1
        ElseIf Me.rdoScissors.Checked = True And intCompThrow = 3 Then
            Me.lblAnswer.Text = "Tie. Both throw Scissors"
        End If

        If intCompScore = 10 Then
            Me.btnSubmitIf.Enabled = False
            Me.btnSubmit.Enabled = False
            Me.lblFinal.Text = "Computer Wins Overall"
        ElseIf intHumanScore = 10 Then
            Me.btnSubmitIf.Enabled = False
            Me.btnSubmit.Enabled = False
            Me.lblFinal.Text = "You Win Overall"
        End If

        Me.lblCompScore.Text = intCompScore
        Me.lblHumanScore.Text = intHumanScore

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.lblAnswer.Text = ""
        Me.intCompScore = 0
        Me.intHumanScore = 0
        Me.lblCompScore.Text = ""
        Me.lblHumanScore.Text = ""
        Me.lblFinal.Text = ""
        Me.btnSubmit.Enabled = True
        Me.btnSubmitIf.Enabled = True
    End Sub


End Class
