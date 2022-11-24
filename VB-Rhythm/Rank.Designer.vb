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
        Me.RankButton_1 = New System.Windows.Forms.Button()
        Me.NicknameLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.RankButton_2 = New System.Windows.Forms.Button()
        Me.RankButton_3 = New System.Windows.Forms.Button()
        Me.RankButton_4 = New System.Windows.Forms.Button()
        Me.RankButton_5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        'RankButton_1
        '
        Me.RankButton_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RankButton_1.Location = New System.Drawing.Point(500, 43)
        Me.RankButton_1.Name = "RankButton_1"
        Me.RankButton_1.Size = New System.Drawing.Size(223, 60)
        Me.RankButton_1.TabIndex = 1
        Me.RankButton_1.TabStop = False
        Me.RankButton_1.Text = "1st. nickname"
        Me.RankButton_1.UseVisualStyleBackColor = True
        '
        'NicknameLabel
        '
        Me.NicknameLabel.AutoSize = True
        Me.NicknameLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NicknameLabel.Location = New System.Drawing.Point(88, 192)
        Me.NicknameLabel.Name = "NicknameLabel"
        Me.NicknameLabel.Size = New System.Drawing.Size(96, 27)
        Me.NicknameLabel.TabIndex = 0
        Me.NicknameLabel.Text = "닉네임"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLabel.Location = New System.Drawing.Point(88, 286)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(68, 27)
        Me.ScoreLabel.TabIndex = 0
        Me.ScoreLabel.Text = "점수"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TimeLabel.Location = New System.Drawing.Point(88, 378)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(68, 27)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "시간"
        '
        'RankButton_2
        '
        Me.RankButton_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RankButton_2.Location = New System.Drawing.Point(500, 123)
        Me.RankButton_2.Name = "RankButton_2"
        Me.RankButton_2.Size = New System.Drawing.Size(223, 60)
        Me.RankButton_2.TabIndex = 1
        Me.RankButton_2.TabStop = False
        Me.RankButton_2.Text = "2st. nickname"
        Me.RankButton_2.UseVisualStyleBackColor = True
        '
        'RankButton_3
        '
        Me.RankButton_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RankButton_3.Location = New System.Drawing.Point(500, 201)
        Me.RankButton_3.Name = "RankButton_3"
        Me.RankButton_3.Size = New System.Drawing.Size(223, 60)
        Me.RankButton_3.TabIndex = 1
        Me.RankButton_3.TabStop = False
        Me.RankButton_3.Text = "3st. nickname"
        Me.RankButton_3.UseVisualStyleBackColor = True
        '
        'RankButton_4
        '
        Me.RankButton_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RankButton_4.Location = New System.Drawing.Point(500, 279)
        Me.RankButton_4.Name = "RankButton_4"
        Me.RankButton_4.Size = New System.Drawing.Size(223, 60)
        Me.RankButton_4.TabIndex = 1
        Me.RankButton_4.TabStop = False
        Me.RankButton_4.Text = "4st. nickname"
        Me.RankButton_4.UseVisualStyleBackColor = True
        '
        'RankButton_5
        '
        Me.RankButton_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RankButton_5.Location = New System.Drawing.Point(500, 357)
        Me.RankButton_5.Name = "RankButton_5"
        Me.RankButton_5.Size = New System.Drawing.Size(223, 60)
        Me.RankButton_5.TabIndex = 1
        Me.RankButton_5.TabStop = False
        Me.RankButton_5.Text = "5st. nickname"
        Me.RankButton_5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(312, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "닉네임"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(312, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "점수"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(312, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "시간"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(78, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "My Rank"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("DOSIyagiBoldface", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(284, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "User Rank"
        '
        'Rank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RankButton_5)
        Me.Controls.Add(Me.RankButton_4)
        Me.Controls.Add(Me.RankButton_3)
        Me.Controls.Add(Me.RankButton_2)
        Me.Controls.Add(Me.RankButton_1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NicknameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rank"
        Me.Text = "Rank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RankButton_1 As Button
    Friend WithEvents NicknameLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents RankButton_2 As Button
    Friend WithEvents RankButton_3 As Button
    Friend WithEvents RankButton_4 As Button
    Friend WithEvents RankButton_5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
