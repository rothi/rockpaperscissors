<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblTitle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoRock = New System.Windows.Forms.RadioButton()
        Me.rdoPaper = New System.Windows.Forms.RadioButton()
        Me.rdoScissors = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblHumanScore = New System.Windows.Forms.Label()
        Me.lblCompScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.btnSubmitIf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rock, Paper Scissors!"
        '
        'rdoRock
        '
        Me.rdoRock.AutoSize = True
        Me.rdoRock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRock.Location = New System.Drawing.Point(19, 90)
        Me.rdoRock.Name = "rdoRock"
        Me.rdoRock.Size = New System.Drawing.Size(55, 17)
        Me.rdoRock.TabIndex = 1
        Me.rdoRock.TabStop = True
        Me.rdoRock.Text = "Rock"
        Me.rdoRock.UseVisualStyleBackColor = True
        '
        'rdoPaper
        '
        Me.rdoPaper.AutoSize = True
        Me.rdoPaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPaper.Location = New System.Drawing.Point(19, 113)
        Me.rdoPaper.Name = "rdoPaper"
        Me.rdoPaper.Size = New System.Drawing.Size(58, 17)
        Me.rdoPaper.TabIndex = 2
        Me.rdoPaper.TabStop = True
        Me.rdoPaper.Text = "Paper"
        Me.rdoPaper.UseVisualStyleBackColor = True
        '
        'rdoScissors
        '
        Me.rdoScissors.AutoSize = True
        Me.rdoScissors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoScissors.Location = New System.Drawing.Point(19, 134)
        Me.rdoScissors.Name = "rdoScissors"
        Me.rdoScissors.Size = New System.Drawing.Size(72, 17)
        Me.rdoScissors.TabIndex = 3
        Me.rdoScissors.TabStop = True
        Me.rdoScissors.Text = "Scissors"
        Me.rdoScissors.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose One:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmit.Location = New System.Drawing.Point(19, 157)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(92, 33)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(14, 205)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 25)
        Me.lblAnswer.TabIndex = 6
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(19, 260)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(97, 33)
        Me.btnRestart.TabIndex = 7
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lblHumanScore
        '
        Me.lblHumanScore.AutoSize = True
        Me.lblHumanScore.Location = New System.Drawing.Point(217, 260)
        Me.lblHumanScore.Name = "lblHumanScore"
        Me.lblHumanScore.Size = New System.Drawing.Size(0, 13)
        Me.lblHumanScore.TabIndex = 8
        '
        'lblCompScore
        '
        Me.lblCompScore.AutoSize = True
        Me.lblCompScore.Location = New System.Drawing.Point(217, 280)
        Me.lblCompScore.Name = "lblCompScore"
        Me.lblCompScore.Size = New System.Drawing.Size(0, 13)
        Me.lblCompScore.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Your Score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Computer Score:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(244, 262)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 37)
        Me.lblFinal.TabIndex = 12
        '
        'btnSubmitIf
        '
        Me.btnSubmitIf.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitIf.Location = New System.Drawing.Point(117, 157)
        Me.btnSubmitIf.Name = "btnSubmitIf"
        Me.btnSubmitIf.Size = New System.Drawing.Size(127, 33)
        Me.btnSubmitIf.TabIndex = 13
        Me.btnSubmitIf.Text = "Submit If"
        Me.btnSubmitIf.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(686, 303)
        Me.Controls.Add(Me.btnSubmitIf)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCompScore)
        Me.Controls.Add(Me.lblHumanScore)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdoScissors)
        Me.Controls.Add(Me.rdoPaper)
        Me.Controls.Add(Me.rdoRock)
        Me.Controls.Add(Me.Label1)
        Me.Name = "lblTitle"
        Me.Text = "Rock Paper Scissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoRock As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rdoScissors As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents lblHumanScore As System.Windows.Forms.Label
    Friend WithEvents lblCompScore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents btnSubmitIf As System.Windows.Forms.Button

End Class
