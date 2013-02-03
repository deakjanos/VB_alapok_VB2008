Public Class foablak

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles felirat.Click

    End Sub

    Private Sub cmd_szm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_szm.Click
        MsgBox("A szöveg, amit beírtál:" & (Chr(10)) & szm.Text, MsgBoxStyle.Information, "Üzenet")
    End Sub
End Class
