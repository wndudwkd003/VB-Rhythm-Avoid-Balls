﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.LifeLable = New System.Windows.Forms.Label()
        Me.PowerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TimeLabel.Location = New System.Drawing.Point(226, 325)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(258, 31)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "Time : 00.00.00.00"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLabel.Location = New System.Drawing.Point(876, 325)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(131, 31)
        Me.ScoreLabel.TabIndex = 1
        Me.ScoreLabel.Text = "Score : 0"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LifeLable
        '
        Me.LifeLable.AutoSize = True
        Me.LifeLable.BackColor = System.Drawing.Color.Transparent
        Me.LifeLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LifeLable.Location = New System.Drawing.Point(589, 566)
        Me.LifeLable.Name = "LifeLable"
        Me.LifeLable.Size = New System.Drawing.Size(103, 31)
        Me.LifeLable.TabIndex = 0
        Me.LifeLable.Text = "Life : 3"
        Me.LifeLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PowerLabel
        '
        Me.PowerLabel.AutoSize = True
        Me.PowerLabel.BackColor = System.Drawing.Color.Transparent
        Me.PowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PowerLabel.ForeColor = System.Drawing.Color.Black
        Me.PowerLabel.Location = New System.Drawing.Point(620, 123)
        Me.PowerLabel.Name = "PowerLabel"
        Me.PowerLabel.Size = New System.Drawing.Size(30, 31)
        Me.PowerLabel.TabIndex = 0
        Me.PowerLabel.Text = "5"
        Me.PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.VB_Rhythm.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.PowerLabel)
        Me.Controls.Add(Me.LifeLable)
        Me.Controls.Add(Me.TimeLabel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodge : Avoid Balls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimeLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents LifeLable As Label
    Friend WithEvents PowerLabel As Label
End Class
