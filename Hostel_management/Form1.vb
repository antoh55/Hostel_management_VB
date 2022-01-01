Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New OleDb.OLEDBCONNECTION("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dell-PC\Desktop\Mwende2\Hostel_management\test_db.mdb")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
