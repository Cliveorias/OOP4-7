<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRadioCheck
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoBSCpE = New System.Windows.Forms.RadioButton()
        Me.rdoBSCS = New System.Windows.Forms.RadioButton()
        Me.rdoBSIT = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMat = New System.Windows.Forms.CheckBox()
        Me.chkSci = New System.Windows.Forms.CheckBox()
        Me.chkFil = New System.Windows.Forms.CheckBox()
        Me.chkEng = New System.Windows.Forms.CheckBox()
        Me.chkCom = New System.Windows.Forms.CheckBox()
        Me.btnTestRdoBtn = New System.Windows.Forms.Button()
        Me.btnTestChkBox = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoBSCpE)
        Me.GroupBox1.Controls.Add(Me.rdoBSCS)
        Me.GroupBox1.Controls.Add(Me.rdoBSIT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Course"
        '
        'rdoBSCpE
        '
        Me.rdoBSCpE.AutoSize = True
        Me.rdoBSCpE.Location = New System.Drawing.Point(15, 95)
        Me.rdoBSCpE.Name = "rdoBSCpE"
        Me.rdoBSCpE.Size = New System.Drawing.Size(56, 17)
        Me.rdoBSCpE.TabIndex = 2
        Me.rdoBSCpE.Text = "BSCpE"
        Me.rdoBSCpE.UseVisualStyleBackColor = True
        '
        'rdoBSCS
        '
        Me.rdoBSCS.AutoSize = True
        Me.rdoBSCS.Location = New System.Drawing.Point(15, 60)
        Me.rdoBSCS.Name = "rdoBSCS"
        Me.rdoBSCS.Size = New System.Drawing.Size(51, 17)
        Me.rdoBSCS.TabIndex = 1
        Me.rdoBSCS.Text = "BSCS"
        Me.rdoBSCS.UseVisualStyleBackColor = True
        '
        'rdoBSIT
        '
        Me.rdoBSIT.AutoSize = True
        Me.rdoBSIT.Checked = True
        Me.rdoBSIT.Location = New System.Drawing.Point(15, 25)
        Me.rdoBSIT.Name = "rdoBSIT"
        Me.rdoBSIT.Size = New System.Drawing.Size(47, 17)
        Me.rdoBSIT.TabIndex = 0
        Me.rdoBSIT.TabStop = True
        Me.rdoBSIT.Text = "BSIT"
        Me.rdoBSIT.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMat)
        Me.GroupBox2.Controls.Add(Me.chkSci)
        Me.GroupBox2.Controls.Add(Me.chkFil)
        Me.GroupBox2.Controls.Add(Me.chkEng)
        Me.GroupBox2.Controls.Add(Me.chkCom)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Favorite Subject/s"
        '
        'chkMat
        '
        Me.chkMat.AutoSize = True
        Me.chkMat.Location = New System.Drawing.Point(105, 60)
        Me.chkMat.Name = "chkMat"
        Me.chkMat.Size = New System.Drawing.Size(48, 17)
        Me.chkMat.TabIndex = 4
        Me.chkMat.Text = "Math"
        Me.chkMat.UseVisualStyleBackColor = True
        '
        'chkSci
        '
        Me.chkSci.AutoSize = True
        Me.chkSci.Location = New System.Drawing.Point(105, 25)
        Me.chkSci.Name = "chkSci"
        Me.chkSci.Size = New System.Drawing.Size(60, 17)
        Me.chkSci.TabIndex = 3
        Me.chkSci.Text = "Science"
        Me.chkSci.UseVisualStyleBackColor = True
        '
        'chkFil
        '
        Me.chkFil.AutoSize = True
        Me.chkFil.Location = New System.Drawing.Point(15, 95)
        Me.chkFil.Name = "chkFil"
        Me.chkFil.Size = New System.Drawing.Size(58, 17)
        Me.chkFil.TabIndex = 2
        Me.chkFil.Text = "Filipino"
        Me.chkFil.UseVisualStyleBackColor = True
        '
        'chkEng
        '
        Me.chkEng.AutoSize = True
        Me.chkEng.Location = New System.Drawing.Point(15, 60)
        Me.chkEng.Name = "chkEng"
        Me.chkEng.Size = New System.Drawing.Size(60, 17)
        Me.chkEng.TabIndex = 1
        Me.chkEng.Text = "English"
        Me.chkEng.UseVisualStyleBackColor = True
        '
        'chkCom
        '
        Me.chkCom.AutoSize = True
        Me.chkCom.Location = New System.Drawing.Point(15, 25)
        Me.chkCom.Name = "chkCom"
        Me.chkCom.Size = New System.Drawing.Size(71, 17)
        Me.chkCom.TabIndex = 0
        Me.chkCom.Text = "Computer"
        Me.chkCom.UseVisualStyleBackColor = True
        '
        'btnTestRdoBtn
        '
        Me.btnTestRdoBtn.Location = New System.Drawing.Point(12, 155)
        Me.btnTestRdoBtn.Name = "btnTestRdoBtn"
        Me.btnTestRdoBtn.Size = New System.Drawing.Size(105, 30)
        Me.btnTestRdoBtn.TabIndex = 2
        Me.btnTestRdoBtn.Text = "Test RadioButton"
        Me.btnTestRdoBtn.UseVisualStyleBackColor = True
        '
        'btnTestChkBox
        '
        Me.btnTestChkBox.Location = New System.Drawing.Point(123, 155)
        Me.btnTestChkBox.Name = "btnTestChkBox"
        Me.btnTestChkBox.Size = New System.Drawing.Size(105, 30)
        Me.btnTestChkBox.TabIndex = 3
        Me.btnTestChkBox.Text = "Test CheckBox"
        Me.btnTestChkBox.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(234, 155)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(91, 30)
        Me.btnClearAll.TabIndex = 4
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'frmRadioCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 200)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnTestChkBox)
        Me.Controls.Add(Me.btnTestRdoBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRadioCheck"
        Me.Text = "RadioButton & CheckBox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoBSCpE As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBSCS As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBSIT As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMat As System.Windows.Forms.CheckBox
    Friend WithEvents chkSci As System.Windows.Forms.CheckBox
    Friend WithEvents chkFil As System.Windows.Forms.CheckBox
    Friend WithEvents chkEng As System.Windows.Forms.CheckBox
    Friend WithEvents chkCom As System.Windows.Forms.CheckBox
    Friend WithEvents btnTestRdoBtn As System.Windows.Forms.Button
    Friend WithEvents btnTestChkBox As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button

End Class
