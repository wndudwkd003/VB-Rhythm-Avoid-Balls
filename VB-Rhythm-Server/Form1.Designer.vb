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
        Me.components = New System.ComponentModel.Container()
        Me.tbChatList = New System.Windows.Forms.TextBox()
        Me.RankListBox = New System.Windows.Forms.ListBox()
        Me.ResultText = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tbChatList
        '
        Me.tbChatList.Location = New System.Drawing.Point(649, 9)
        Me.tbChatList.Multiline = True
        Me.tbChatList.Name = "tbChatList"
        Me.tbChatList.Size = New System.Drawing.Size(371, 588)
        Me.tbChatList.TabIndex = 1
        '
        'RankListBox
        '
        Me.RankListBox.FormattingEnabled = True
        Me.RankListBox.ItemHeight = 15
        Me.RankListBox.Location = New System.Drawing.Point(433, 9)
        Me.RankListBox.Name = "RankListBox"
        Me.RankListBox.Size = New System.Drawing.Size(201, 589)
        Me.RankListBox.TabIndex = 2
        '
        'ResultText
        '
        Me.ResultText.Location = New System.Drawing.Point(12, 9)
        Me.ResultText.Multiline = True
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(404, 338)
        Me.ResultText.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 609)
        Me.Controls.Add(Me.ResultText)
        Me.Controls.Add(Me.RankListBox)
        Me.Controls.Add(Me.tbChatList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbChatList As TextBox
    Friend WithEvents RankListBox As ListBox
    Friend WithEvents ResultText As TextBox
    Friend WithEvents Timer1 As Timer
End Class
