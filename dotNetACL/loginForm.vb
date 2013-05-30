Public Class loginForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim username As String = loginName.Text
        Dim pass As String = loginPass.Text

        session.auth(username, pass)
        setUserInfo()

        If Not session.isLoggedIn Then
            MsgBox("Login Gagal, pastikan username dan password anda sesuai", MsgBoxStyle.Exclamation, "Login")
        Else
            Me.Close()
        End If
    End Sub


    Private Sub loginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setUserInfo()
    End Sub

    Public Sub setUserInfo()
        If Not session.isLoggedIn Then
            mainForm.setUserStatus("User belum login")
        Else
            mainForm.setUserStatus("User: " & session.var("name"))
        End If
    End Sub
End Class