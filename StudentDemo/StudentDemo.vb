Public Class frmStudentDemo
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim studentOne As New Student() ' Declare & Instantiate a Student Object - Default constructor (3 Years)
        Dim studentTwo As Student ' Declare a student variable, but do not instantiate the object

        studentTwo = New Student(2) ' Instantiate a Student Object - Parameterized Constructor

        studentOne.Name = tbStudentNameOne.Text ' Set the Name of Student One
        studentTwo.Name = tbStudentNameTwo.Text ' Set the Name of Student Two

        lbStudentOnePropertyOutput.Text = studentOne.Name ' Get/Access the Name property of Student One 
        lbStudentOneMethodOutput.Text = studentOne.GetStudentData() ' Call the function GetStudentData for Student One

        lbStudentTwoPropertyOutput.Text = studentTwo.Name ' Get/Access the Name property of Student Two
        lbStudentTwoMethodOutput.Text = studentTwo.GetStudentData() ' Call the function GetStudentData for Student Two

    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        tbStudentNameOne.Text = String.Empty ' clear text box
        tbStudentNameTwo.Text = String.Empty ' clear text box

        lbStudentOnePropertyOutput.Text = String.Empty ' clear label
        lbStudentOneMethodOutput.Text = String.Empty ' clear label

        lbStudentTwoPropertyOutput.Text = String.Empty ' clear label
        lbStudentTwoMethodOutput.Text = String.Empty ' clear label

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class


