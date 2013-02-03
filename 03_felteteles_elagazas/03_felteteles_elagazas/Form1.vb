Public Class Form1

    Private Sub cmd_szm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_szm.Click
        If szm.Text = "igen" Then
            MsgBox("Igen", MsgBoxStyle.Information, "Üzenet")
        ElseIf szm.Text = "nem" Then
            MsgBox("Nem", MsgBoxStyle.Exclamation, "Üzenet")
        Else
            MsgBox("Valami más", MsgBoxStyle.Exclamation, "Üzenet")
        End If

    End Sub
End Class
