Public Class Form1
    Private Sub btnPasswordCheck_Click(sender As Object, e As EventArgs) Handles btnPasswordCheck.Click
        If ValidatePassword(TextBox1.Text) = False Then
            MessageBox.Show("Password mush have 8-10 characters long with at least one numeric character and uppercase, lowercase and special Char", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Good Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function ValidatePassword(ByVal Password) As Boolean

        Dim regEx
        regEx = CreateObject("vbscript.regexp")

        regEx.Pattern = "^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&+=]).*$"
        ValidatePassword = regEx.Test(Password)

        regEx = Nothing
    End Function
End Class
