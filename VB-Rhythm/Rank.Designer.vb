<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rank
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NicknameLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player Ranking"
        '
        'NicknameLabel
        '
        Me.NicknameLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NicknameLabel.Location = New System.Drawing.Point(46, 183)
        Me.NicknameLabel.Name = "NicknameLabel"
        Me.NicknameLabel.Size = New System.Drawing.Size(403, 59)
        Me.NicknameLabel.TabIndex = 0
        Me.NicknameLabel.Text = "닉네임"
        Me.NicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLabel.Location = New System.Drawing.Point(144, 257)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(222, 52)
        Me.ScoreLabel.TabIndex = 0
        Me.ScoreLabel.Text = "점수"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLabel
        '
        Me.TimeLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TimeLabel.Location = New System.Drawing.Point(139, 329)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(227, 57)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "시간"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(139, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 54)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "My Rank"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 450)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NicknameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rank"
        Me.Text = "Rank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NicknameLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label5 As Label
End Class
