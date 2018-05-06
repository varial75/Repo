<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPACalc
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
        Me.lblPageHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.lstGrades1 = New System.Windows.Forms.ComboBox()
        Me.lstGrade2 = New System.Windows.Forms.ComboBox()
        Me.lstGrade3 = New System.Windows.Forms.ComboBox()
        Me.nudCredits1 = New System.Windows.Forms.NumericUpDown()
        Me.nudCredits2 = New System.Windows.Forms.NumericUpDown()
        Me.nudCredits3 = New System.Windows.Forms.NumericUpDown()
        Me.nudCredits4 = New System.Windows.Forms.NumericUpDown()
        Me.lstGrade4 = New System.Windows.Forms.ComboBox()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.nudCredits5 = New System.Windows.Forms.NumericUpDown()
        Me.lstGrade5 = New System.Windows.Forms.ComboBox()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.nudCredits6 = New System.Windows.Forms.NumericUpDown()
        Me.lstGrade6 = New System.Windows.Forms.ComboBox()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.btnCalcGPA = New System.Windows.Forms.Button()
        Me.lblGPAOutput = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudCumulativeGPA = New System.Windows.Forms.NumericUpDown()
        Me.nudCompletedCredits = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudGoalGPA = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudGPAAverage = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nudCurrentCredits = New System.Windows.Forms.NumericUpDown()
        Me.btnCreditsRequired = New System.Windows.Forms.Button()
        Me.lblCreditsRequiredOutput = New System.Windows.Forms.Label()
        Me.lblGPARequiredOutput = New System.Windows.Forms.Label()
        Me.btnGPARequired = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblCreditCount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblGradePointCount = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        CType(Me.nudCredits1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCredits2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCredits3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCredits4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCredits5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCredits6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCumulativeGPA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCompletedCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGoalGPA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGPAAverage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCurrentCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPageHeader
        '
        Me.lblPageHeader.AutoSize = True
        Me.lblPageHeader.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageHeader.Location = New System.Drawing.Point(190, 24)
        Me.lblPageHeader.Name = "lblPageHeader"
        Me.lblPageHeader.Size = New System.Drawing.Size(716, 46)
        Me.lblPageHeader.TabIndex = 0
        Me.lblPageHeader.Text = "Welcome to the GPA Calculator"
        Me.lblPageHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please, enter in the corresponding information " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to calculate your GPA."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(615, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name of Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(832, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Credits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(943, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Grade"
        '
        'txtCourse1
        '
        Me.txtCourse1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse1.Location = New System.Drawing.Point(588, 184)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(227, 27)
        Me.txtCourse1.TabIndex = 3
        '
        'txtCourse2
        '
        Me.txtCourse2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse2.Location = New System.Drawing.Point(588, 217)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(227, 27)
        Me.txtCourse2.TabIndex = 6
        '
        'txtCourse3
        '
        Me.txtCourse3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse3.Location = New System.Drawing.Point(588, 250)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(227, 27)
        Me.txtCourse3.TabIndex = 9
        '
        'lstGrades1
        '
        Me.lstGrades1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrades1.FormattingEnabled = True
        Me.lstGrades1.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrades1.Location = New System.Drawing.Point(947, 184)
        Me.lstGrades1.Name = "lstGrades1"
        Me.lstGrades1.Size = New System.Drawing.Size(66, 28)
        Me.lstGrades1.TabIndex = 5
        '
        'lstGrade2
        '
        Me.lstGrade2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade2.FormattingEnabled = True
        Me.lstGrade2.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrade2.Location = New System.Drawing.Point(947, 217)
        Me.lstGrade2.Name = "lstGrade2"
        Me.lstGrade2.Size = New System.Drawing.Size(66, 28)
        Me.lstGrade2.TabIndex = 8
        '
        'lstGrade3
        '
        Me.lstGrade3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade3.FormattingEnabled = True
        Me.lstGrade3.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrade3.Location = New System.Drawing.Point(947, 250)
        Me.lstGrade3.Name = "lstGrade3"
        Me.lstGrade3.Size = New System.Drawing.Size(66, 28)
        Me.lstGrade3.TabIndex = 11
        '
        'nudCredits1
        '
        Me.nudCredits1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCredits1.Location = New System.Drawing.Point(836, 185)
        Me.nudCredits1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCredits1.Name = "nudCredits1"
        Me.nudCredits1.Size = New System.Drawing.Size(90, 27)
        Me.nudCredits1.TabIndex = 4
        Me.nudCredits1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudCredits2
        '
        Me.nudCredits2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCredits2.Location = New System.Drawing.Point(836, 218)
        Me.nudCredits2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCredits2.Name = "nudCredits2"
        Me.nudCredits2.Size = New System.Drawing.Size(90, 27)
        Me.nudCredits2.TabIndex = 7
        Me.nudCredits2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudCredits3
        '
        Me.nudCredits3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCredits3.Location = New System.Drawing.Point(836, 251)
        Me.nudCredits3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCredits3.Name = "nudCredits3"
        Me.nudCredits3.Size = New System.Drawing.Size(90, 27)
        Me.nudCredits3.TabIndex = 10
        Me.nudCredits3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudCredits4
        '
        Me.nudCredits4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCredits4.Location = New System.Drawing.Point(836, 284)
        Me.nudCredits4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCredits4.Name = "nudCredits4"
        Me.nudCredits4.Size = New System.Drawing.Size(90, 27)
        Me.nudCredits4.TabIndex = 13
        Me.nudCredits4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstGrade4
        '
        Me.lstGrade4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade4.FormattingEnabled = True
        Me.lstGrade4.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrade4.Location = New System.Drawing.Point(947, 283)
        Me.lstGrade4.Name = "lstGrade4"
        Me.lstGrade4.Size = New System.Drawing.Size(66, 28)
        Me.lstGrade4.TabIndex = 14
        '
        'txtCourse4
        '
        Me.txtCourse4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse4.Location = New System.Drawing.Point(588, 283)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(227, 27)
        Me.txtCourse4.TabIndex = 12
        '
        'nudCredits5
        '
        Me.nudCredits5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCredits5.Location = New System.Drawing.Point(836, 317)
        Me.nudCredits5.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCredits5.Name = "nudCredits5"
        Me.nudCredits5.Size = New System.Drawing.Size(90, 27)
        Me.nudCredits5.TabIndex = 16
        Me.nudCredits5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstGrade5
        '
        Me.lstGrade5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade5.FormattingEnabled = True
        Me.lstGrade5.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrade5.Location = New System.Drawing.Point(947, 316)
        Me.lstGrade5.Name = "lstGrade5"
        Me.lstGrade5.Size = New System.Drawing.Size(66, 28)
        Me.lstGrade5.TabIndex = 17
        '
        'txtCourse5
        '
        Me.txtCourse5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse5.Location = New System.Drawing.Point(588, 316)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(227, 27)
        Me.txtCourse5.TabIndex = 15
        '
        'nudCredits6
        '
        Me.nudCredits6.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCredits6.Location = New System.Drawing.Point(836, 350)
        Me.nudCredits6.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCredits6.Name = "nudCredits6"
        Me.nudCredits6.Size = New System.Drawing.Size(90, 27)
        Me.nudCredits6.TabIndex = 19
        Me.nudCredits6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstGrade6
        '
        Me.lstGrade6.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade6.FormattingEnabled = True
        Me.lstGrade6.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrade6.Location = New System.Drawing.Point(947, 349)
        Me.lstGrade6.Name = "lstGrade6"
        Me.lstGrade6.Size = New System.Drawing.Size(66, 28)
        Me.lstGrade6.TabIndex = 20
        '
        'txtCourse6
        '
        Me.txtCourse6.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse6.Location = New System.Drawing.Point(588, 349)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(227, 27)
        Me.txtCourse6.TabIndex = 18
        '
        'btnCalcGPA
        '
        Me.btnCalcGPA.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCalcGPA.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcGPA.Location = New System.Drawing.Point(402, 394)
        Me.btnCalcGPA.Name = "btnCalcGPA"
        Me.btnCalcGPA.Size = New System.Drawing.Size(186, 34)
        Me.btnCalcGPA.TabIndex = 21
        Me.btnCalcGPA.TabStop = False
        Me.btnCalcGPA.Text = "My GPA is ..."
        Me.btnCalcGPA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalcGPA.UseVisualStyleBackColor = False
        '
        'lblGPAOutput
        '
        Me.lblGPAOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGPAOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGPAOutput.Enabled = False
        Me.lblGPAOutput.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPAOutput.Location = New System.Drawing.Point(604, 394)
        Me.lblGPAOutput.Name = "lblGPAOutput"
        Me.lblGPAOutput.Size = New System.Drawing.Size(90, 33)
        Me.lblGPAOutput.TabIndex = 20
        Me.lblGPAOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(415, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 34)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Raise Your GPA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(346, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "What is your cumulative GPA?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(92, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(334, 46)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "How many credit hours " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "have you completed to date?"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudCumulativeGPA
        '
        Me.nudCumulativeGPA.DecimalPlaces = 2
        Me.nudCumulativeGPA.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCumulativeGPA.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudCumulativeGPA.Location = New System.Drawing.Point(447, 234)
        Me.nudCumulativeGPA.Maximum = New Decimal(New Integer() {400, 0, 0, 131072})
        Me.nudCumulativeGPA.Name = "nudCumulativeGPA"
        Me.nudCumulativeGPA.Size = New System.Drawing.Size(90, 27)
        Me.nudCumulativeGPA.TabIndex = 1
        Me.nudCumulativeGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudCompletedCredits
        '
        Me.nudCompletedCredits.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCompletedCredits.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCompletedCredits.Location = New System.Drawing.Point(447, 284)
        Me.nudCompletedCredits.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCompletedCredits.Name = "nudCompletedCredits"
        Me.nudCompletedCredits.Size = New System.Drawing.Size(90, 27)
        Me.nudCompletedCredits.TabIndex = 2
        Me.nudCompletedCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(262, 589)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 34)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "By Average"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(710, 589)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(195, 34)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "By Credits"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(341, 535)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(274, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "What is your goal GPA?"
        '
        'nudGoalGPA
        '
        Me.nudGoalGPA.DecimalPlaces = 2
        Me.nudGoalGPA.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGoalGPA.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudGoalGPA.Location = New System.Drawing.Point(621, 531)
        Me.nudGoalGPA.Maximum = New Decimal(New Integer() {400, 0, 0, 131072})
        Me.nudGoalGPA.Name = "nudGoalGPA"
        Me.nudGoalGPA.Size = New System.Drawing.Size(90, 27)
        Me.nudGoalGPA.TabIndex = 22
        Me.nudGoalGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(92, 640)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(346, 46)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "What GPA average will you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "maintain to reach your goal?"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudGPAAverage
        '
        Me.nudGPAAverage.DecimalPlaces = 2
        Me.nudGPAAverage.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGPAAverage.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudGPAAverage.Location = New System.Drawing.Point(451, 652)
        Me.nudGPAAverage.Maximum = New Decimal(New Integer() {400, 0, 0, 131072})
        Me.nudGPAAverage.Name = "nudGPAAverage"
        Me.nudGPAAverage.Size = New System.Drawing.Size(90, 27)
        Me.nudGPAAverage.TabIndex = 23
        Me.nudGPAAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(634, 640)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(250, 46)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "How many credits " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do you plan to take?"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudCurrentCredits
        '
        Me.nudCurrentCredits.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCurrentCredits.Location = New System.Drawing.Point(921, 652)
        Me.nudCurrentCredits.Name = "nudCurrentCredits"
        Me.nudCurrentCredits.Size = New System.Drawing.Size(90, 27)
        Me.nudCurrentCredits.TabIndex = 25
        Me.nudCurrentCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCreditsRequired
        '
        Me.btnCreditsRequired.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCreditsRequired.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditsRequired.Location = New System.Drawing.Point(96, 698)
        Me.btnCreditsRequired.Name = "btnCreditsRequired"
        Me.btnCreditsRequired.Size = New System.Drawing.Size(342, 64)
        Me.btnCreditsRequired.TabIndex = 24
        Me.btnCreditsRequired.TabStop = False
        Me.btnCreditsRequired.Text = "Number of Credits Required to Reach Your Goal"
        Me.btnCreditsRequired.UseVisualStyleBackColor = False
        '
        'lblCreditsRequiredOutput
        '
        Me.lblCreditsRequiredOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreditsRequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditsRequiredOutput.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditsRequiredOutput.Location = New System.Drawing.Point(451, 715)
        Me.lblCreditsRequiredOutput.Name = "lblCreditsRequiredOutput"
        Me.lblCreditsRequiredOutput.Size = New System.Drawing.Size(90, 33)
        Me.lblCreditsRequiredOutput.TabIndex = 36
        Me.lblCreditsRequiredOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGPARequiredOutput
        '
        Me.lblGPARequiredOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGPARequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGPARequiredOutput.Enabled = False
        Me.lblGPARequiredOutput.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPARequiredOutput.Location = New System.Drawing.Point(921, 716)
        Me.lblGPARequiredOutput.Name = "lblGPARequiredOutput"
        Me.lblGPARequiredOutput.Size = New System.Drawing.Size(90, 33)
        Me.lblGPARequiredOutput.TabIndex = 25
        Me.lblGPARequiredOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGPARequired
        '
        Me.btnGPARequired.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnGPARequired.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPARequired.Location = New System.Drawing.Point(599, 698)
        Me.btnGPARequired.Name = "btnGPARequired"
        Me.btnGPARequired.Size = New System.Drawing.Size(307, 67)
        Me.btnGPARequired.TabIndex = 26
        Me.btnGPARequired.TabStop = False
        Me.btnGPARequired.Text = "Average GPA Required To Reach Your Goal"
        Me.btnGPARequired.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnReset.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(12, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(139, 34)
        Me.btnReset.TabIndex = 37
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset Page"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblCreditCount
        '
        Me.lblCreditCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreditCount.Location = New System.Drawing.Point(873, 447)
        Me.lblCreditCount.Name = "lblCreditCount"
        Me.lblCreditCount.Size = New System.Drawing.Size(104, 32)
        Me.lblCreditCount.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(983, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Credit Count"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(983, 489)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 34)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Grade Point" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Count"
        '
        'lblGradePointCount
        '
        Me.lblGradePointCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradePointCount.Location = New System.Drawing.Point(873, 488)
        Me.lblGradePointCount.Name = "lblGradePointCount"
        Me.lblGradePointCount.Size = New System.Drawing.Size(104, 32)
        Me.lblGradePointCount.TabIndex = 40
        '
        'lblDate
        '
        Me.lblDate.Enabled = False
        Me.lblDate.Location = New System.Drawing.Point(900, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(185, 41)
        Me.lblDate.TabIndex = 42
        '
        'frmGPACalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 799)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblGradePointCount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCreditCount)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblGPARequiredOutput)
        Me.Controls.Add(Me.btnGPARequired)
        Me.Controls.Add(Me.lblCreditsRequiredOutput)
        Me.Controls.Add(Me.btnCreditsRequired)
        Me.Controls.Add(Me.nudCurrentCredits)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.nudGPAAverage)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.nudGoalGPA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nudCompletedCredits)
        Me.Controls.Add(Me.nudCumulativeGPA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblGPAOutput)
        Me.Controls.Add(Me.btnCalcGPA)
        Me.Controls.Add(Me.nudCredits6)
        Me.Controls.Add(Me.lstGrade6)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.nudCredits5)
        Me.Controls.Add(Me.lstGrade5)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.nudCredits4)
        Me.Controls.Add(Me.lstGrade4)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.nudCredits3)
        Me.Controls.Add(Me.nudCredits2)
        Me.Controls.Add(Me.nudCredits1)
        Me.Controls.Add(Me.lstGrade3)
        Me.Controls.Add(Me.lstGrade2)
        Me.Controls.Add(Me.lstGrades1)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.txtCourse1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPageHeader)
        Me.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmGPACalc"
        Me.Text = "GPA Calculator"
        CType(Me.nudCredits1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCredits2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCredits3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCredits4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCredits5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCredits6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCumulativeGPA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCompletedCredits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGoalGPA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGPAAverage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCurrentCredits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPageHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents lstGrades1 As ComboBox
    Friend WithEvents lstGrade2 As ComboBox
    Friend WithEvents lstGrade3 As ComboBox
    Friend WithEvents nudCredits1 As NumericUpDown
    Friend WithEvents nudCredits2 As NumericUpDown
    Friend WithEvents nudCredits3 As NumericUpDown
    Friend WithEvents nudCredits4 As NumericUpDown
    Friend WithEvents lstGrade4 As ComboBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents nudCredits5 As NumericUpDown
    Friend WithEvents lstGrade5 As ComboBox
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents nudCredits6 As NumericUpDown
    Friend WithEvents lstGrade6 As ComboBox
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents btnCalcGPA As Button
    Friend WithEvents lblGPAOutput As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nudCumulativeGPA As NumericUpDown
    Friend WithEvents nudCompletedCredits As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents nudGoalGPA As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents nudGPAAverage As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents nudCurrentCredits As NumericUpDown
    Friend WithEvents btnCreditsRequired As Button
    Friend WithEvents lblCreditsRequiredOutput As Label
    Friend WithEvents lblGPARequiredOutput As Label
    Friend WithEvents btnGPARequired As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblCreditCount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblGradePointCount As Label
    Friend WithEvents lblDate As Label
End Class
