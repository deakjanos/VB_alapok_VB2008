Public Class Form1
    Public kivalasztott As String
    Public kivalasztott2 As String

    Private Sub AdatokBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdatokBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdatokBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Proba_adatbazisDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Proba_adatbazisDataSet.Lekérdezés_név_szerint' table. You can move, or remove it, as needed.
        Me.Lekérdezés_név_szerintTableAdapter.Fill(Me.Proba_adatbazisDataSet.Lekérdezés_név_szerint)
        'TODO: This line of code loads data into the 'Proba_adatbazisDataSet.Befizetések_lekérdezése' table. You can move, or remove it, as needed.
        Me.Befizetések_lekérdezéseTableAdapter.Fill(Me.Proba_adatbazisDataSet.Befizetések_lekérdezése)
        'TODO: This line of code loads data into the 'Proba_adatbazisDataSet.Adatok' table. You can move, or remove it, as needed.
        Me.AdatokTableAdapter.Fill(Me.Proba_adatbazisDataSet.Adatok)

    End Sub

    Private Sub AdatokBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdatokBindingNavigator.RefreshItems

    End Sub

    Private Sub AdatokDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdatokDataGridView.CellContentClick

    End Sub

    

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Befizetések_lekérdezéseDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Befizetések_lekérdezéseDataGridView.CellContentClick

    End Sub

    Private Sub Lekérdezés_név_szerintDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lekérdezés_név_szerintDataGridView.CellContentClick

    End Sub

   


    Private Sub NévTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NévTextBox.TextChanged
        kivalasztott = NévTextBox.Text
        kivalasztott2 = kivalasztott + " *** manipulált"
        TextBox1.Text = kivalasztott2
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub
End Class
