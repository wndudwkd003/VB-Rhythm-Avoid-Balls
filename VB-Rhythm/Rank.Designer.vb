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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rank))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NicknameLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player Ranking"
        '
        'NicknameLabel
        '
        Me.NicknameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NicknameLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NicknameLabel.Location = New System.Drawing.Point(242, 214)
        Me.NicknameLabel.Name = "NicknameLabel"
        Me.NicknameLabel.Size = New System.Drawing.Size(215, 59)
        Me.NicknameLabel.TabIndex = 0
        Me.NicknameLabel.Text = "닉네임"
        Me.NicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoreLabel
        '
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLabel.Location = New System.Drawing.Point(242, 290)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(215, 52)
        Me.ScoreLabel.TabIndex = 0
        Me.ScoreLabel.Text = "점수"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLabel
        '
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TimeLabel.Location = New System.Drawing.Point(242, 362)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(215, 57)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "시간"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(242, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 54)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "최근 기록"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 59)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "닉네임"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(21, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "My Rank"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(21, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 52)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "점수"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(21, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 57)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "시간"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.VB_Rhythm.My.Resources.Resources.bg_rank
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NicknameLabel)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rank"
        Me.Text = "Dodge : Avoid Balls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NicknameLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
