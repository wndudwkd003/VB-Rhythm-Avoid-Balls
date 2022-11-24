<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.RankButton = New System.Windows.Forms.Button()
        Me.LearnButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DOSIyagiBoldface", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(121, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Avoid Balls ver.VB"
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.AutoSize = True
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Location = New System.Drawing.Point(179, 264)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(209, 58)
        Me.StartButton.TabIndex = 1
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Game Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'RankButton
        '
        Me.RankButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RankButton.AutoSize = True
        Me.RankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RankButton.Location = New System.Drawing.Point(179, 333)
        Me.RankButton.Name = "RankButton"
        Me.RankButton.Size = New System.Drawing.Size(209, 58)
        Me.RankButton.TabIndex = 2
        Me.RankButton.TabStop = False
        Me.RankButton.Text = "Player Rank"
        Me.RankButton.UseVisualStyleBackColor = True
        '
        'LearnButton
        '
        Me.LearnButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LearnButton.AutoSize = True
        Me.LearnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LearnButton.Location = New System.Drawing.Point(179, 404)
        Me.LearnButton.Name = "LearnButton"
        Me.LearnButton.Size = New System.Drawing.Size(209, 58)
        Me.LearnButton.TabIndex = 3
        Me.LearnButton.TabStop = False
        Me.LearnButton.Text = "How To Play"
        Me.LearnButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.AutoSize = True
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(179, 475)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(209, 58)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "Game Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(564, 581)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LearnButton)
        Me.Controls.Add(Me.RankButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "StartForm"
        Me.Text = "StartForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents RankButton As Button
    Friend WithEvents LearnButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Timer1 As Timer
End Class
