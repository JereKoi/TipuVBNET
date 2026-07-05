Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form1

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("TipulaConnection").ConnectionString
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTipuList()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub lblName_Label_Click(sender As Object, e As EventArgs) Handles lblName_Label.Click

    End Sub

    Private Sub txtColor_TextChanged(sender As Object, e As EventArgs) Handles txtColor.TextChanged
    End Sub

    Private Sub lblTipu_color_Click(sender As Object, e As EventArgs) Handles lblTipu_color.Click

    End Sub

    Private Sub dtpHatch_ValueChanged(sender As Object, e As EventArgs) Handles dtpHatch.ValueChanged

    End Sub

    Private Sub btnAddTipu_Click(sender As Object, e As EventArgs) Handles btnAddTipu.Click
        ' Checks that name has been entered
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name for the Tipu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' SQL-query for a new Tipu addition
        Dim query As String = "INSERT INTO Tiput (Name, HatchingDate, Color) VALUES (@Name, @Date, @Color)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Search new data to UI elements using parameters
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Date", dtpHatch.Value)
                cmd.Parameters.AddWithValue("@Color", txtColor.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New Tipu added successfully!", "Pii pii!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear input fields and update the DataGridView
                    txtName.Clear()
                    txtColor.Clear()
                    UpdateTipuList()
                Catch ex As Exception
                    MessageBox.Show("Error adding Tipu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub



    'Sub function to load Tiput from database to dgvTiput-table
    Private Sub UpdateTipuList()
        Dim query As String = "SELECT TipuID, Name, HatchingDate, Color FROM Tiput"

        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            Try
                adapter.Fill(table)
                dgvTiput.DataSource = table ' Set data to new table
            Catch ex As Exception
                MessageBox.Show("Error loading Tiput: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub lblAddTipu_Click(sender As Object, e As EventArgs) Handles lblAddTipu.Click

    End Sub

    Private Sub btnUpdateList_Click(sender As Object, e As EventArgs) Handles btnUpdateList.Click
        UpdateTipuList()
    End Sub

    Private Sub lblUpdateList_Click(sender As Object, e As EventArgs) Handles lblUpdateList.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiput.CellContentClick

    End Sub
End Class
