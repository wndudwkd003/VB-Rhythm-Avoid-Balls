<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LearnForm
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
        Me.LearnLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LearnLabel
        '
        Me.LearnLabel.BackColor = System.Drawing.Color.Transparent
        Me.LearnLabel.ForeColor = System.Drawing.Color.White
        Me.LearnLabel.Image = Global.VB_Rhythm.My.Resources.Resources.learn2
        Me.LearnLabel.Location = New System.Drawing.Point(146, 473)
        Me.LearnLabel.Name = "LearnLabel"
        Me.LearnLabel.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.LearnLabel.Size = New System.Drawing.Size(974, 186)
        Me.LearnLabel.TabIndex = 3
        Me.LearnLabel.Text = "이 게임은 이렇게 합니다"
        Me.LearnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LearnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.VB_Rhythm.My.Resources.Resources.learn1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.LearnLabel)
        Me.DoubleBuffered = True
        Me.Name = "LearnForm"
        Me.Text = "LearnForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LearnLabel As Label
End Class
