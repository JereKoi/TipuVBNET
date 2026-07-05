Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form1

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("TipulaConnection").ConnectionString
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTiput()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNimi.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName_Label.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtVari.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTipu_color.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpHatch.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddTipu.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAddTipu.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdateList.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblUpdateList.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiput.CellContentClick

    End Sub
End Class
