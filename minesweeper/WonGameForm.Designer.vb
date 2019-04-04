<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WonGameForm
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
        Me.playAgainButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boardSizeLabel = New System.Windows.Forms.Label()
        Me.timeTextLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'playAgainButton
        '
        Me.playAgainButton.Location = New System.Drawing.Point(12, 97)
        Me.playAgainButton.Name = "playAgainButton"
        Me.playAgainButton.Size = New System.Drawing.Size(75, 23)
        Me.playAgainButton.TabIndex = 0
        Me.playAgainButton.Text = "Play again"
        Me.playAgainButton.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.Location = New System.Drawing.Point(153, 97)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(75, 23)
        Me.quitButton.TabIndex = 1
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Board size:"
        '
        'boardSizeLabel
        '
        Me.boardSizeLabel.AutoSize = True
        Me.boardSizeLabel.Location = New System.Drawing.Point(78, 31)
        Me.boardSizeLabel.Name = "boardSizeLabel"
        Me.boardSizeLabel.Size = New System.Drawing.Size(48, 13)
        Me.boardSizeLabel.TabIndex = 8
        Me.boardSizeLabel.Text = "0 x 0 = 0"
        '
        'timeTextLabel
        '
        Me.timeTextLabel.AutoSize = True
        Me.timeTextLabel.Location = New System.Drawing.Point(39, 44)
        Me.timeTextLabel.Name = "timeTextLabel"
        Me.timeTextLabel.Size = New System.Drawing.Size(33, 13)
        Me.timeTextLabel.TabIndex = 9
        Me.timeTextLabel.Text = "Time:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(78, 44)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(34, 13)
        Me.timeLabel.TabIndex = 10
        Me.timeLabel.Text = "00:00"
        '
        'WonGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 132)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.timeTextLabel)
        Me.Controls.Add(Me.boardSizeLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.playAgainButton)
        Me.Name = "WonGameForm"
        Me.Text = "You won!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playAgainButton As Button
    Friend WithEvents quitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents boardSizeLabel As Label
    Friend WithEvents timeTextLabel As Label
    Friend WithEvents timeLabel As Label
End Class
