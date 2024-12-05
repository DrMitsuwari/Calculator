Public Class Form1
    ' Variables to hold the current value and operation
    Private currentValue As Double = 0
    Private previousValue As Double = 0
    Private operation As String = ""
    Private input As String = ""

    ' Handle number button clicks
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles num0.Click, num1.Click, num2.Click, num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click
        ' Get the text of the clicked button and append it to the input string
        input &= CType(sender, Button).Text
        Txtdisplay.Text = input
    End Sub

    ' Handle operation button clicks
    Private Sub Operation_Click(sender As Object, e As EventArgs) Handles OpAdd.Click, OpMinus.Click, OpMulti.Click, OpDivide.Click
        If input <> "" Then
            previousValue = Val(input) ' Store the first number
            operation = CType(sender, Button).Text ' Store the operation (+, -, *, /)
            input = "" ' Clear input for the next number
            Txtdisplay.Text = ""
        End If
    End Sub

    ' Handle the Equal button click
    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        If input <> "" Then
            currentValue = Val(input) ' Store the second number
            Dim result As Double = 0

            ' Perform the selected operation
            Select Case operation
                Case "+"
                    result = previousValue + currentValue
                Case "-"
                    result = previousValue - currentValue
                Case "*"
                    result = previousValue * currentValue
                Case "/"
                    If currentValue <> 0 Then
                        result = previousValue / currentValue
                    Else
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
            End Select

            ' Display the result
            Txtdisplay.Text = result.ToString()
            input = result.ToString() ' Allow chaining operations
        End If
    End Sub

    ' Handle Clear button click
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        previousValue = 0
        currentValue = 0
        operation = ""
        input = ""
        Txtdisplay.Text = ""
    End Sub
End Class
