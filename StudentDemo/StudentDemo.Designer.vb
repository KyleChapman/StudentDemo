<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentDemo
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.tbStudentNameOne = New System.Windows.Forms.TextBox()
        Me.tbStudentNameTwo = New System.Windows.Forms.TextBox()
        Me.lbStudentOneNameInput = New System.Windows.Forms.Label()
        Me.lbStudentTwoNameInput = New System.Windows.Forms.Label()
        Me.grpStudentOne = New System.Windows.Forms.GroupBox()
        Me.lbStudentOneMethodOutput = New System.Windows.Forms.Label()
        Me.lbStudentOneNameOutput = New System.Windows.Forms.Label()
        Me.lbStudentOneMethod = New System.Windows.Forms.Label()
        Me.lbStudentOneName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbStudentTwoMethodOutput = New System.Windows.Forms.Label()
        Me.lbStudentTwoNameOutput = New System.Windows.Forms.Label()
        Me.lbStudentTwoMethod = New System.Windows.Forms.Label()
        Me.lbStudentTwoName = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbStudentOneCountOutput = New System.Windows.Forms.Label()
        Me.lbStudentOneCount = New System.Windows.Forms.Label()
        Me.lbStudentTwoCountOutput = New System.Windows.Forms.Label()
        Me.lbStudentTwoCount = New System.Windows.Forms.Label()
        Me.grpStudentOne.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(8, 64)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'tbStudentNameOne
        '
        Me.tbStudentNameOne.Location = New System.Drawing.Point(132, 9)
        Me.tbStudentNameOne.Name = "tbStudentNameOne"
        Me.tbStudentNameOne.Size = New System.Drawing.Size(226, 20)
        Me.tbStudentNameOne.TabIndex = 1
        '
        'tbStudentNameTwo
        '
        Me.tbStudentNameTwo.Location = New System.Drawing.Point(132, 38)
        Me.tbStudentNameTwo.Name = "tbStudentNameTwo"
        Me.tbStudentNameTwo.Size = New System.Drawing.Size(226, 20)
        Me.tbStudentNameTwo.TabIndex = 3
        '
        'lbStudentOneNameInput
        '
        Me.lbStudentOneNameInput.Location = New System.Drawing.Point(12, 12)
        Me.lbStudentOneNameInput.Name = "lbStudentOneNameInput"
        Me.lbStudentOneNameInput.Size = New System.Drawing.Size(114, 17)
        Me.lbStudentOneNameInput.TabIndex = 0
        Me.lbStudentOneNameInput.Text = "Student &One Name"
        '
        'lbStudentTwoNameInput
        '
        Me.lbStudentTwoNameInput.Location = New System.Drawing.Point(12, 41)
        Me.lbStudentTwoNameInput.Name = "lbStudentTwoNameInput"
        Me.lbStudentTwoNameInput.Size = New System.Drawing.Size(113, 13)
        Me.lbStudentTwoNameInput.TabIndex = 2
        Me.lbStudentTwoNameInput.Text = "Student &Two Name"
        '
        'grpStudentOne
        '
        Me.grpStudentOne.Controls.Add(Me.lbStudentOneCountOutput)
        Me.grpStudentOne.Controls.Add(Me.lbStudentOneCount)
        Me.grpStudentOne.Controls.Add(Me.lbStudentOneMethodOutput)
        Me.grpStudentOne.Controls.Add(Me.lbStudentOneNameOutput)
        Me.grpStudentOne.Controls.Add(Me.lbStudentOneMethod)
        Me.grpStudentOne.Controls.Add(Me.lbStudentOneName)
        Me.grpStudentOne.Location = New System.Drawing.Point(8, 93)
        Me.grpStudentOne.Name = "grpStudentOne"
        Me.grpStudentOne.Size = New System.Drawing.Size(356, 103)
        Me.grpStudentOne.TabIndex = 5
        Me.grpStudentOne.TabStop = False
        Me.grpStudentOne.Text = "Student One (Output)"
        '
        'lbStudentOneMethodOutput
        '
        Me.lbStudentOneMethodOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStudentOneMethodOutput.Location = New System.Drawing.Point(139, 75)
        Me.lbStudentOneMethodOutput.Name = "lbStudentOneMethodOutput"
        Me.lbStudentOneMethodOutput.Size = New System.Drawing.Size(211, 22)
        Me.lbStudentOneMethodOutput.TabIndex = 3
        '
        'lbStudentOneNameOutput
        '
        Me.lbStudentOneNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStudentOneNameOutput.Location = New System.Drawing.Point(139, 26)
        Me.lbStudentOneNameOutput.Name = "lbStudentOneNameOutput"
        Me.lbStudentOneNameOutput.Size = New System.Drawing.Size(211, 22)
        Me.lbStudentOneNameOutput.TabIndex = 1
        '
        'lbStudentOneMethod
        '
        Me.lbStudentOneMethod.Location = New System.Drawing.Point(7, 75)
        Me.lbStudentOneMethod.Name = "lbStudentOneMethod"
        Me.lbStudentOneMethod.Size = New System.Drawing.Size(136, 22)
        Me.lbStudentOneMethod.TabIndex = 2
        Me.lbStudentOneMethod.Text = "GetStudentData (Method):"
        '
        'lbStudentOneName
        '
        Me.lbStudentOneName.Location = New System.Drawing.Point(7, 27)
        Me.lbStudentOneName.Name = "lbStudentOneName"
        Me.lbStudentOneName.Size = New System.Drawing.Size(124, 21)
        Me.lbStudentOneName.TabIndex = 0
        Me.lbStudentOneName.Text = "Name (Property):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbStudentTwoCountOutput)
        Me.GroupBox1.Controls.Add(Me.lbStudentTwoCount)
        Me.GroupBox1.Controls.Add(Me.lbStudentTwoMethodOutput)
        Me.GroupBox1.Controls.Add(Me.lbStudentTwoNameOutput)
        Me.GroupBox1.Controls.Add(Me.lbStudentTwoMethod)
        Me.GroupBox1.Controls.Add(Me.lbStudentTwoName)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 106)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Two (Output)"
        '
        'lbStudentTwoMethodOutput
        '
        Me.lbStudentTwoMethodOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStudentTwoMethodOutput.Location = New System.Drawing.Point(137, 76)
        Me.lbStudentTwoMethodOutput.Name = "lbStudentTwoMethodOutput"
        Me.lbStudentTwoMethodOutput.Size = New System.Drawing.Size(212, 22)
        Me.lbStudentTwoMethodOutput.TabIndex = 3
        '
        'lbStudentTwoNameOutput
        '
        Me.lbStudentTwoNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStudentTwoNameOutput.Location = New System.Drawing.Point(138, 26)
        Me.lbStudentTwoNameOutput.Name = "lbStudentTwoNameOutput"
        Me.lbStudentTwoNameOutput.Size = New System.Drawing.Size(212, 22)
        Me.lbStudentTwoNameOutput.TabIndex = 1
        '
        'lbStudentTwoMethod
        '
        Me.lbStudentTwoMethod.Location = New System.Drawing.Point(6, 79)
        Me.lbStudentTwoMethod.Name = "lbStudentTwoMethod"
        Me.lbStudentTwoMethod.Size = New System.Drawing.Size(136, 22)
        Me.lbStudentTwoMethod.TabIndex = 2
        Me.lbStudentTwoMethod.Text = "GetStudentData (Method):"
        '
        'lbStudentTwoName
        '
        Me.lbStudentTwoName.Location = New System.Drawing.Point(7, 27)
        Me.lbStudentTwoName.Name = "lbStudentTwoName"
        Me.lbStudentTwoName.Size = New System.Drawing.Size(129, 21)
        Me.lbStudentTwoName.TabIndex = 0
        Me.lbStudentTwoName.Text = "Name (Property):"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(145, 64)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 64)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbStudentOneCountOutput
        '
        Me.lbStudentOneCountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStudentOneCountOutput.Location = New System.Drawing.Point(139, 50)
        Me.lbStudentOneCountOutput.Name = "lbStudentOneCountOutput"
        Me.lbStudentOneCountOutput.Size = New System.Drawing.Size(211, 22)
        Me.lbStudentOneCountOutput.TabIndex = 5
        '
        'lbStudentOneCount
        '
        Me.lbStudentOneCount.Location = New System.Drawing.Point(7, 51)
        Me.lbStudentOneCount.Name = "lbStudentOneCount"
        Me.lbStudentOneCount.Size = New System.Drawing.Size(124, 21)
        Me.lbStudentOneCount.TabIndex = 4
        Me.lbStudentOneCount.Text = "Count (Property):"
        '
        'lbStudentTwoCountOutput
        '
        Me.lbStudentTwoCountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStudentTwoCountOutput.Location = New System.Drawing.Point(138, 51)
        Me.lbStudentTwoCountOutput.Name = "lbStudentTwoCountOutput"
        Me.lbStudentTwoCountOutput.Size = New System.Drawing.Size(211, 22)
        Me.lbStudentTwoCountOutput.TabIndex = 7
        '
        'lbStudentTwoCount
        '
        Me.lbStudentTwoCount.Location = New System.Drawing.Point(6, 52)
        Me.lbStudentTwoCount.Name = "lbStudentTwoCount"
        Me.lbStudentTwoCount.Size = New System.Drawing.Size(124, 21)
        Me.lbStudentTwoCount.TabIndex = 6
        Me.lbStudentTwoCount.Text = "Count (Property):"
        '
        'frmStudentDemo
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 316)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpStudentOne)
        Me.Controls.Add(Me.lbStudentTwoNameInput)
        Me.Controls.Add(Me.lbStudentOneNameInput)
        Me.Controls.Add(Me.tbStudentNameTwo)
        Me.Controls.Add(Me.tbStudentNameOne)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.grpStudentOne.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents tbStudentNameOne As TextBox
    Friend WithEvents tbStudentNameTwo As TextBox
    Friend WithEvents lbStudentOneNameInput As Label
    Friend WithEvents lbStudentTwoNameInput As Label
    Friend WithEvents grpStudentOne As GroupBox
    Friend WithEvents lbStudentOneMethodOutput As Label
    Friend WithEvents lbStudentOneNameOutput As Label
    Friend WithEvents lbStudentOneMethod As Label
    Friend WithEvents lbStudentOneName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbStudentTwoMethodOutput As Label
    Friend WithEvents lbStudentTwoNameOutput As Label
    Friend WithEvents lbStudentTwoMethod As Label
    Friend WithEvents lbStudentTwoName As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbStudentOneCountOutput As Label
    Friend WithEvents lbStudentOneCount As Label
    Friend WithEvents lbStudentTwoCountOutput As Label
    Friend WithEvents lbStudentTwoCount As Label
End Class
