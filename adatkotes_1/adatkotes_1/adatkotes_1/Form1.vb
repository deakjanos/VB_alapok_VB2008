Public Class Form1

    Private Sub AdatokBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdatokBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdatokBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Proba_adatbazis_1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Proba_adatbazis_1DataSet.Adatok' table. You can move, or remove it, as needed.
        Me.AdatokTableAdapter.Fill(Me.Proba_adatbazis_1DataSet.Adatok)

    End Sub
End Class
