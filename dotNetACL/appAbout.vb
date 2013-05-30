Public Class appAbout

    Private Sub appAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If session.isLoggedIn Then
            loginControl.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mainForm.loadChild(New loginForm)
    End Sub
End Class