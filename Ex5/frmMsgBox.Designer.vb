<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBox
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
        Me.btnMsgBox = New System.Windows.Forms.Button()
        Me.btnMessageBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMsgBox
        '
        Me.btnMsgBox.Location = New System.Drawing.Point(70, 50)
        Me.btnMsgBox.Name = "btnMsgBox"
        Me.btnMsgBox.Size = New System.Drawing.Size(130, 40)
        Me.btnMsgBox.TabIndex = 0
        Me.btnMsgBox.Text = "MsgBox"
        Me.btnMsgBox.UseVisualStyleBackColor = True
        '
        'btnMessageBox
        '
        Me.btnMessageBox.Location = New System.Drawing.Point(70, 120)
        Me.btnMessageBox.Name = "btnMessageBox"
        Me.btnMessageBox.Size = New System.Drawing.Size(130, 40)
        Me.btnMessageBox.TabIndex = 1
        Me.btnMessageBox.Text = "MessageBox.Show"
        Me.btnMessageBox.UseVisualStyleBackColor = True
        '
        'frmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 210)
        Me.Controls.Add(Me.btnMessageBox)
        Me.Controls.Add(Me.btnMsgBox)
        Me.Name = "frmMsgBox"
        Me.Text = "MsgBox & MessageBox.Show"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMsgBox As System.Windows.Forms.Button
    Friend WithEvents btnMessageBox As System.Windows.Forms.Button

End Class
