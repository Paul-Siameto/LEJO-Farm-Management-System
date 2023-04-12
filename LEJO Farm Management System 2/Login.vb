Public Class Login

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim username As String
        Dim pass As String
        username = Txtusername.Text
        pass = Txtpassword.Text
        If (username.Equals("Admin") And pass.Equals("Admin")) Then
            Me.Hide()
            Main.Show()
            'MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (username = "Owner" And pass = "Owners") Then
            Me.Hide()
            OProduction.Show()
        ElseIf (username = "Manager" And pass = "Manager") Then
            Me.Hide()
            MFarm.Show()
        Else
            MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtusername.TextChanged

    End Sub
End Class