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
        radAdult = New RadioButton()
        radChild = New RadioButton()
        radStudent = New RadioButton()
        radSenior = New RadioButton()
        chkYoga = New CheckBox()
        chkKarate = New CheckBox()
        chkPersonalTrainer = New CheckBox()
        lblMonths = New Label()
        txtMonths = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblMonthlyFee = New Label()
        lblTotalFee = New Label()
        btnCalculate = New Button()
        btnExit = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' radAdult
        ' 
        radAdult.AutoSize = True
        radAdult.Location = New Point(24, 37)
        radAdult.Name = "radAdult"
        radAdult.Size = New Size(130, 24)
        radAdult.TabIndex = 0
        radAdult.TabStop = True
        radAdult.Text = "Standard Adult"
        radAdult.UseVisualStyleBackColor = True
        ' 
        ' radChild
        ' 
        radChild.AutoSize = True
        radChild.Location = New Point(24, 77)
        radChild.Name = "radChild"
        radChild.Size = New Size(154, 24)
        radChild.TabIndex = 1
        radChild.TabStop = True
        radChild.Text = "Child (12 && Under)"
        radChild.UseVisualStyleBackColor = True
        ' 
        ' radStudent
        ' 
        radStudent.AutoSize = True
        radStudent.Location = New Point(24, 107)
        radStudent.Name = "radStudent"
        radStudent.Size = New Size(81, 24)
        radStudent.TabIndex = 2
        radStudent.TabStop = True
        radStudent.Text = "Student"
        radStudent.UseVisualStyleBackColor = True
        ' 
        ' radSenior
        ' 
        radSenior.AutoSize = True
        radSenior.Location = New Point(24, 144)
        radSenior.Name = "radSenior"
        radSenior.Size = New Size(121, 24)
        radSenior.TabIndex = 3
        radSenior.TabStop = True
        radSenior.Text = "Senior Citizen"
        radSenior.UseVisualStyleBackColor = True
        ' 
        ' chkYoga
        ' 
        chkYoga.AutoSize = True
        chkYoga.Location = New Point(32, 36)
        chkYoga.Name = "chkYoga"
        chkYoga.Size = New Size(64, 24)
        chkYoga.TabIndex = 4
        chkYoga.Text = "Yoga"
        chkYoga.UseVisualStyleBackColor = True
        ' 
        ' chkKarate
        ' 
        chkKarate.AutoSize = True
        chkKarate.Location = New Point(32, 76)
        chkKarate.Name = "chkKarate"
        chkKarate.Size = New Size(74, 24)
        chkKarate.TabIndex = 5
        chkKarate.Text = "Karate"
        chkKarate.UseVisualStyleBackColor = True
        ' 
        ' chkPersonalTrainer
        ' 
        chkPersonalTrainer.AutoSize = True
        chkPersonalTrainer.Location = New Point(32, 116)
        chkPersonalTrainer.Name = "chkPersonalTrainer"
        chkPersonalTrainer.Size = New Size(135, 24)
        chkPersonalTrainer.TabIndex = 6
        chkPersonalTrainer.Text = "Personal Trainer"
        chkPersonalTrainer.UseVisualStyleBackColor = True
        ' 
        ' lblMonths
        ' 
        lblMonths.AutoSize = True
        lblMonths.Location = New Point(8, 34)
        lblMonths.Name = "lblMonths"
        lblMonths.Size = New Size(197, 20)
        lblMonths.TabIndex = 7
        lblMonths.Text = "Enter the Number of Months"
        ' 
        ' txtMonths
        ' 
        txtMonths.Location = New Point(22, 57)
        txtMonths.Name = "txtMonths"
        txtMonths.Size = New Size(166, 27)
        txtMonths.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 9
        Label1.Text = "Monthly Fee:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(104, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 10
        Label2.Text = "Total:"
        ' 
        ' lblMonthlyFee
        ' 
        lblMonthlyFee.BackColor = SystemColors.ButtonShadow
        lblMonthlyFee.BorderStyle = BorderStyle.Fixed3D
        lblMonthlyFee.Location = New Point(156, 49)
        lblMonthlyFee.Name = "lblMonthlyFee"
        lblMonthlyFee.Size = New Size(172, 26)
        lblMonthlyFee.TabIndex = 11
        ' 
        ' lblTotalFee
        ' 
        lblTotalFee.BackColor = SystemColors.ControlDark
        lblTotalFee.BorderStyle = BorderStyle.Fixed3D
        lblTotalFee.Location = New Point(156, 98)
        lblTotalFee.Name = "lblTotalFee"
        lblTotalFee.Size = New Size(172, 30)
        lblTotalFee.TabIndex = 12
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(79, 409)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 13
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(574, 409)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 15
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radSenior)
        GroupBox1.Controls.Add(radStudent)
        GroupBox1.Controls.Add(radChild)
        GroupBox1.Controls.Add(radAdult)
        GroupBox1.Location = New Point(55, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(235, 188)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Types of Membership"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chkPersonalTrainer)
        GroupBox2.Controls.Add(chkKarate)
        GroupBox2.Controls.Add(chkYoga)
        GroupBox2.Location = New Point(471, 34)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(279, 161)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Options"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtMonths)
        GroupBox3.Controls.Add(lblMonths)
        GroupBox3.Location = New Point(57, 262)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(247, 115)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Membership Length"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblTotalFee)
        GroupBox4.Controls.Add(lblMonthlyFee)
        GroupBox4.Controls.Add(Label2)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Location = New Point(435, 211)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(350, 163)
        GroupBox4.TabIndex = 19
        GroupBox4.TabStop = False
        GroupBox4.Text = "Membership Fees"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "Membership Fee Calculator"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents radAdult As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkPersonalTrainer As CheckBox
    Friend WithEvents lblMonths As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
