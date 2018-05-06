Public Class frmGPACalc
    'Declaration of Global Variables ***************************************************************************************************

    'Left Boxes
    Dim decCumulativeGPA As Decimal
    Dim intCompletedCredits As Integer
    'Table Boxes
    Dim strCourse1 As String
    Dim strCourse2 As String
    Dim strCourse3 As String
    Dim strCourse4 As String
    Dim strCourse5 As String
    Dim strCourse6 As String
    Dim intCredits1 As Integer
    Dim intCredits2 As Integer
    Dim intCredits3 As Integer
    Dim intCredits4 As Integer
    Dim intCredits5 As Integer
    Dim intCredits6 As Integer
    Dim strGrade1 As String
    Dim strGrade2 As String
    Dim strGrade3 As String
    Dim strGrade4 As String
    Dim strGrade5 As String
    Dim strGrade6 As String
    'Goal Boxes
    Dim decGPAGoal As Decimal
    Dim decGPAAverage As Decimal
    Dim intCreditsPlanned As Integer

    'Output Boxes
    Dim sngGPAOutput As Single
    Dim sngGPAAverageRequiredOutput As Single
    Dim intNumCreditsRequiredOutput As Integer

    'Counters
    Dim intGradePointCount As Integer
    Dim intCreditCount As Integer


    Public Sub frmGPACalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Date Stamp Coding ********************************************************************************************************************
        Dim datToday As Date = Now
        lblDate.Text = datToday.ToLongDateString
    End Sub

    Private Sub btnCalcGPA_Click(sender As Object, e As EventArgs) Handles btnCalcGPA.Click
        'Input
        decCumulativeGPA = nudCumulativeGPA.Value
        intCompletedCredits = nudCompletedCredits.Value
        intCredits1 = nudCredits1.Value
        intCredits2 = nudCredits2.Value
        intCredits3 = nudCredits3.Value
        intCredits4 = nudCredits4.Value
        intCredits5 = nudCredits5.Value
        intCredits6 = nudCredits6.Value
        strGrade1 = lstGrades1.Text
        strGrade2 = lstGrade2.Text
        strGrade3 = lstGrade3.Text
        strGrade4 = lstGrade4.Text
        strGrade5 = lstGrade5.Text
        strGrade6 = lstGrade6.Text

        'Processing
        'Clear Counters each time button is pressed
        intCreditCount = 0
        intGradePointCount = 0

        'Populate the Credit Count **************************************************************************************************************
        intCreditCount = intCreditCount + intCompletedCredits

        'Each Case populates the CreditsCounter variable for final GPA calculation
        Select Case intCredits1
            Case = 1
                intCreditCount = intCreditCount + 1
            Case = 2
                intCreditCount = intCreditCount + 2
            Case = 3
                intCreditCount = intCreditCount + 3
            Case = 4
                intCreditCount = intCreditCount + 4
            Case = 5
                intCreditCount = intCreditCount + 5
            Case = 6
                intCreditCount = intCreditCount + 6
            Case = 7
                intCreditCount = intCreditCount + 7
            Case = 8
                intCreditCount = intCreditCount + 8
            Case = 9
                intCreditCount = intCreditCount + 9
            Case = 10
                intCreditCount = intCreditCount + 10
        End Select

        Select Case intCredits2
            Case = 1
                intCreditCount = intCreditCount + 1
            Case = 2
                intCreditCount = intCreditCount + 2
            Case = 3
                intCreditCount = intCreditCount + 3
            Case = 4
                intCreditCount = intCreditCount + 4
            Case = 5
                intCreditCount = intCreditCount + 5
            Case = 6
                intCreditCount = intCreditCount + 6
            Case = 7
                intCreditCount = intCreditCount + 7
            Case = 8
                intCreditCount = intCreditCount + 8
            Case = 9
                intCreditCount = intCreditCount + 9
            Case = 10
                intCreditCount = intCreditCount + 10
        End Select

        Select Case intCredits3
            Case = 1
                intCreditCount = intCreditCount + 1
            Case = 2
                intCreditCount = intCreditCount + 2
            Case = 3
                intCreditCount = intCreditCount + 3
            Case = 4
                intCreditCount = intCreditCount + 4
            Case = 5
                intCreditCount = intCreditCount + 5
            Case = 6
                intCreditCount = intCreditCount + 6
            Case = 7
                intCreditCount = intCreditCount + 7
            Case = 8
                intCreditCount = intCreditCount + 8
            Case = 9
                intCreditCount = intCreditCount + 9
            Case = 10
                intCreditCount = intCreditCount + 10
        End Select

        Select Case intCredits4
            Case = 1
                intCreditCount = intCreditCount + 1
            Case = 2
                intCreditCount = intCreditCount + 2
            Case = 3
                intCreditCount = intCreditCount + 3
            Case = 4
                intCreditCount = intCreditCount + 4
            Case = 5
                intCreditCount = intCreditCount + 5
            Case = 6
                intCreditCount = intCreditCount + 6
            Case = 7
                intCreditCount = intCreditCount + 7
            Case = 8
                intCreditCount = intCreditCount + 8
            Case = 9
                intCreditCount = intCreditCount + 9
            Case = 10
                intCreditCount = intCreditCount + 10
        End Select

        Select Case intCredits5
            Case = 1
                intCreditCount = intCreditCount + 1
            Case = 2
                intCreditCount = intCreditCount + 2
            Case = 3
                intCreditCount = intCreditCount + 3
            Case = 4
                intCreditCount = intCreditCount + 4
            Case = 5
                intCreditCount = intCreditCount + 5
            Case = 6
                intCreditCount = intCreditCount + 6
            Case = 7
                intCreditCount = intCreditCount + 7
            Case = 8
                intCreditCount = intCreditCount + 8
            Case = 9
                intCreditCount = intCreditCount + 9
            Case = 10
                intCreditCount = intCreditCount + 10
        End Select

        Select Case intCredits6
            Case = 1
                intCreditCount = intCreditCount + 1
            Case = 2
                intCreditCount = intCreditCount + 2
            Case = 3
                intCreditCount = intCreditCount + 3
            Case = 4
                intCreditCount = intCreditCount + 4
            Case = 5
                intCreditCount = intCreditCount + 5
            Case = 6
                intCreditCount = intCreditCount + 6
            Case = 7
                intCreditCount = intCreditCount + 7
            Case = 8
                intCreditCount = intCreditCount + 8
            Case = 9
                intCreditCount = intCreditCount + 9
            Case = 10
                intCreditCount = intCreditCount + 10
        End Select

        'Populate the Grade Point Count
        'THIS SECTION CONTAINS AN ERROR' **************************************************************************************************************
        intGradePointCount = (decCumulativeGPA * intCompletedCredits)
        'THIS SECTION CONTAINS AN ERROR' **************************************************************************************************************

        ' A=4, B=3, C=2, D=1, F=0 grade points.
        'Each case selects the grade from each class and populates the GradePointCounter varialbe for final GPA calculations
        Select Case strGrade1
            Case = "A"
                intGradePointCount = intGradePointCount + 4 * intCredits1
            Case = "B"
                intGradePointCount = intGradePointCount + 3 * intCredits1
            Case = "C"
                intGradePointCount = intGradePointCount + 2 * intCredits1
            Case = "D"
                intGradePointCount = intGradePointCount + 1 * intCredits1
            Case = "F"
                intGradePointCount = intGradePointCount
        End Select

        Select Case strGrade2
            Case = "A"
                intGradePointCount = intGradePointCount + 4 * intCredits2
            Case = "B"
                intGradePointCount = intGradePointCount + 3 * intCredits2
            Case = "C"
                intGradePointCount = intGradePointCount + 2 * intCredits2
            Case = "D"
                intGradePointCount = intGradePointCount + 1 * intCredits2
            Case = "F"
                intGradePointCount = intGradePointCount
        End Select

        Select Case strGrade3
            Case = "A"
                intGradePointCount = intGradePointCount + 4 * intCredits3
            Case = "B"
                intGradePointCount = intGradePointCount + 3 * intCredits3
            Case = "C"
                intGradePointCount = intGradePointCount + 2 * intCredits3
            Case = "D"
                intGradePointCount = intGradePointCount + 1 * intCredits3
            Case = "F"
                intGradePointCount = intGradePointCount
        End Select

        Select Case strGrade4
            Case = "A"
                intGradePointCount = intGradePointCount + 4 * intCredits4
            Case = "B"
                intGradePointCount = intGradePointCount + 3 * intCredits4
            Case = "C"
                intGradePointCount = intGradePointCount + 2 * intCredits4
            Case = "D"
                intGradePointCount = intGradePointCount + 1 * intCredits4
            Case = "F"
                intGradePointCount = intGradePointCount
        End Select

        Select Case strGrade5
            Case = "A"
                intGradePointCount = intGradePointCount + 4 * intCredits5
            Case = "B"
                intGradePointCount = intGradePointCount + 3 * intCredits5
            Case = "C"
                intGradePointCount = intGradePointCount + 2 * intCredits5
            Case = "D"
                intGradePointCount = intGradePointCount + 1 * intCredits5
            Case = "F"
                intGradePointCount = intGradePointCount
        End Select

        Select Case strGrade6
            Case = "A"
                intGradePointCount = intGradePointCount + 4 * intCredits6
            Case = "B"
                intGradePointCount = intGradePointCount + 3 * intCredits6
            Case = "C"
                intGradePointCount = intGradePointCount + 2 * intCredits6
            Case = "D"
                intGradePointCount = intGradePointCount + 1 * intCredits6
            Case = "F"
                intGradePointCount = intGradePointCount
        End Select

        'THIS SECTION CONTAINS AN ERROR' **************************************************************************************************************
        sngGPAOutput = intGradePointCount / intCreditCount
        'THIS SECTION CONTAINS AN ERROR' **************************************************************************************************************

        'Output
        'remove lblCreditCount and lblGradePointCount from finished code and form *******************************************************
        lblCreditCount.Text = intCreditCount.ToString
        lblGradePointCount.Text = intGradePointCount.ToString
        'remove lblCreditCount and lblGradePointCount from finished code and form *******************************************************

        lblGPAOutput.Text = sngGPAOutput.ToString

    End Sub

    Private Sub btnCreditsRequired_Click(sender As Object, e As EventArgs) Handles btnCreditsRequired.Click

        'Input
        decGPAGoal = nudGoalGPA.Value
        decGPAAverage = nudGPAAverage.Value

        'Processing
        intNumCreditsRequiredOutput = (decGPAGoal - sngGPAOutput) * intCompletedCredits / (decGPAAverage - decGPAGoal)

        'Output
        lblCreditsRequiredOutput.Text = intNumCreditsRequiredOutput.ToString

    End Sub

    Private Sub btnGPARequired_Click(sender As Object, e As EventArgs) Handles btnGPARequired.Click

        'Input
        intCreditsPlanned = nudCurrentCredits.Value
        decGPAGoal = nudGoalGPA.Value

        'Processing
        sngGPAAverageRequiredOutput = decGPAGoal + (decGPAGoal - sngGPAOutput) * intCompletedCredits / intCreditsPlanned

        'Output
        lblGPARequiredOutput.Text = sngGPAAverageRequiredOutput.ToString

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset all counters, input, and output boxes here*********************************************************************************
        'Input
        decCumulativeGPA = nudCumulativeGPA.Value
        intCompletedCredits = nudCompletedCredits.Value
        strCourse1 = txtCourse1.Text
        strCourse2 = txtCourse2.Text
        strCourse3 = txtCourse3.Text
        strCourse4 = txtCourse4.Text
        strCourse5 = txtCourse5.Text
        strCourse6 = txtCourse6.Text
        intCredits1 = nudCredits1.Value
        intCredits2 = nudCredits2.Value
        intCredits3 = nudCredits3.Value
        intCredits4 = nudCredits4.Value
        intCredits5 = nudCredits5.Value
        intCredits6 = nudCredits6.Value
        strGrade1 = lstGrades1.Text
        strGrade2 = lstGrade2.Text
        strGrade3 = lstGrade3.Text
        strGrade4 = lstGrade4.Text
        strGrade5 = lstGrade5.Text
        strGrade6 = lstGrade6.Text

        'Processing
        'Reset Left Boxes
        decCumulativeGPA = "0.00"
        intCompletedCredits = "0"
        'Reset Table Boxes
        strCourse1 = ""
        strCourse2 = ""
        strCourse3 = ""
        strCourse4 = ""
        strCourse5 = ""
        strCourse6 = ""
        intCredits1 = "0.00"
        intCredits2 = "0.00"
        intCredits3 = "0.00"
        intCredits4 = "0.00"
        intCredits5 = "0.00"
        intCredits6 = "0.00"
        strGrade1 = ""
        strGrade2 = ""
        strGrade3 = ""
        strGrade4 = ""
        strGrade5 = ""
        strGrade6 = ""

        'Reset Goal Boxes
        'Reset Output
        'Reset Counters

        'Output


    End Sub
End Class
