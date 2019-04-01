Public Class Form1
    Dim strPeople = New String() {"William Montgomery", "Joseph Haring", "Donald Hall", "Roberto McCullum", "Scott Taylor", "Johnathan Hoover", "Devon Douglas"}
    Dim strPhoneNumbers = New String() {"562-558-8060", "651-230-8573", "781-765-4865", "501-837-8681", "352-301-8858", "562-688-0535", "318-348-6514"}

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtSearch.Text

        For i As Integer = 0 To 6
            Dim str As String = strPeople(i)

            If str.Contains(search) Then
                lblName.Text = strPeople(i)
                lblPhoneNumber.Text = strPhoneNumbers(i)
                Return
            End If
        Next

        lblName.Text = "No Names Match This Search"
    End Sub
End Class
