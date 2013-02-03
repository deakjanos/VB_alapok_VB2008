Public Class Form1
    Dim eszam As Long
    Dim mszam As Long
    Dim op As String
    Private Sub muvelet()
        eszam = szm_eszam.Text
        mszam = szm_mszam.Text
        op = szm_op.Text
        Select Case (op)
            Case "+"
                c_e.Text = eszam + mszam
            Case "-"
                c_e.Text = eszam - mszam
            Case "/"
                c_e.Text = eszam / mszam
            Case "*"
                c_e.Text = eszam * mszam

        End Select
    End Sub

    Private Sub cmd_vegrehajt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vegrehajt.Click
        If (szm_op.Text = "") Or (szm_eszam.Text = "") Or (szm_mszam.Text = "") Then
            MsgBox("Valami hiányzik!", MsgBoxStyle.Exclamation, "Figyelmeztetés")
        Else : muvelet()
        End If
    End Sub

    Private Sub cmd_oa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_oa.Click
        szm_op.Text = "+"
    End Sub

    Private Sub cmd_kiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_kiv.Click
        szm_op.Text = "-"
    End Sub

    Private Sub cmd_szor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_szor.Click
        szm_op.Text = "*"
    End Sub

    Private Sub cmd_oszt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_oszt.Click
        szm_op.Text = "/"
    End Sub
End Class
