Public Class Form1

    ' Globális változók deklarálása
    Dim a As Integer, b As Integer, c As Integer
    Dim ered As Integer, f As Integer
    Private Sub Text1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kiir.Click

        'Kiírás
        f = FreeFile()
        If Text1.Text <> "" And Text2.Text <> "" And Text3.Text <> "" Then
            a = CInt(Text1.Text)
            b = CInt(Text2.Text)
            c = CInt(Text3.Text)
            'FileOpen App.Path + "\adatok.txt" For Output As f
            FileOpen(f, "\adatok.txt", OpenMode.Output)
            Write(f, a, b, c)
            FileClose(f)
            olvas.Enabled = True
            Text1.Text = ""
            Text2.Text = ""
            Text3.Text = ""
            Text4.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles olvas.Click
        'Beolvasás
        f = FreeFile()
        'If Text1.Text <> "" And Text2.Text <> "" And Text3.Text <> "" Then

        FileOpen(f, "\adatok.txt", OpenMode.Input)
        Input(f, a)
        Text1.Text = CStr(a)
        Input(f, b)
        Text2.Text = CStr(b)
        Input(f, c)
        Text3.Text = CStr(c)
        FileClose(f)
        olvas.Enabled = True

        
        Text4.Text = ""



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles szamol.Click
        'Kiszámítás pl. összegezés
        Text4.Text = ""
        If Text1.Text <> "" And Text2.Text <> "" And Text3.Text <> "" Then
            a = CInt(Text1.Text)
            b = CInt(Text2.Text)
            c = CInt(Text3.Text)
            ered = a + b + c
            Text4.Text = CStr(ered)
        End If
    End Sub
End Class
