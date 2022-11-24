<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSndMsg = New System.Windows.Forms.Button()
        Me.tbMsg = New System.Windows.Forms.TextBox()
        Me.tbChatList = New System.Windows.Forms.TextBox()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "랭킹 저장 서버"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Server Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSndMsg
        '
        Me.btnSndMsg.Enabled = False
        Me.btnSndMsg.Location = New System.Drawing.Point(364, 571)
        Me.btnSndMsg.Name = "btnSndMsg"
        Me.btnSndMsg.Size = New System.Drawing.Size(92, 24)
        Me.btnSndMsg.TabIndex = 7
        Me.btnSndMsg.Text = "전송"
        Me.btnSndMsg.UseVisualStyleBackColor = True
        '
        'tbMsg
        '
        Me.tbMsg.Enabled = False
        Me.tbMsg.Location = New System.Drawing.Point(93, 572)
        Me.tbMsg.Name = "tbMsg"
        Me.tbMsg.Size = New System.Drawing.Size(265, 23)
        Me.tbMsg.TabIndex = 6
        '
        'tbChatList
        '
        Me.tbChatList.Location = New System.Drawing.Point(93, 191)
        Me.tbChatList.Multiline = True
        Me.tbChatList.Name = "tbChatList"
        Me.tbChatList.ReadOnly = True
        Me.tbChatList.Size = New System.Drawing.Size(363, 375)
        Me.tbChatList.TabIndex = 5
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Location = New System.Drawing.Point(93, 159)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(42, 15)
        Me.lbInfo.TabIndex = 4
        Me.lbInfo.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 645)
        Me.Controls.Add(Me.btnSndMsg)
        Me.Controls.Add(Me.tbMsg)
        Me.Controls.Add(Me.tbChatList)
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSndMsg As Button
    Friend WithEvents tbMsg As TextBox
    Friend WithEvents tbChatList As TextBox
    Friend WithEvents lbInfo As Label
End Class
