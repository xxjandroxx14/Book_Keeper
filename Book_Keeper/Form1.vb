Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Form1
    Private Const CONN_STRING As String = "server=localhost; userid=root; password=root;database=new_client;"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonRead_Click(Nothing, EventArgs.Empty)
    End Sub
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                conn.Open()
                MessageBox.Show("Connected")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        If String.IsNullOrWhiteSpace(TextBoxTitle.Text) OrElse String.IsNullOrWhiteSpace(TextBoxAuthor.Text) OrElse String.IsNullOrWhiteSpace(TextBoxCategory.Text) OrElse String.IsNullOrWhiteSpace(TextBoxAvailability.Text) Then
            MessageBox.Show("Please enter a value in all required fields!", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If IsDuplicateRecord(TextBoxTitle.Text, TextBoxAuthor.Text, TextBoxCategory.Text) Then
            MessageBox.Show("A record with the same Title, Author, and Category already exists.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim query As String = "INSERT INTO new_client.client_table ( title,author,category,availability) VALUES ( @title, @author, @category, @availability);"
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@title", TextBoxTitle.Text)
                    cmd.Parameters.AddWithValue("@author", TextBoxAuthor.Text)
                    cmd.Parameters.AddWithValue("@category", TextBoxCategory.Text)
                    cmd.Parameters.AddWithValue("@availability", TextBoxAvailability.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert successfully!")
                    TextBoxId.Clear()
                    TextBoxTitle.Clear()
                    TextBoxAuthor.Clear()
                    TextBoxCategory.Clear()
                    TextBoxAvailability.Clear()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function IsDuplicateRecord(title As String, author As String, category As String) As Boolean
        Dim query As String = "SELECT COUNT(id) FROM new_client.client_table WHERE title = @title AND author = @author AND category = @category;"
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@title", title)
                    cmd.Parameters.AddWithValue("@author", author)
                    cmd.Parameters.AddWithValue("@category", category)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0 '
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking for duplicates: " & ex.Message)
            Return True
        End Try
    End Function


    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM new_client.client_table;"
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                If DataGridView1.Columns.Contains("id") Then
                    DataGridView1.Columns("id").Visible = False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBoxTitle.Text = selectedRow.Cells("title").Value.ToString()
            TextBoxAuthor.Text = selectedRow.Cells("author").Value.ToString()
            TextBoxCategory.Text = selectedRow.Cells("category").Value.ToString()
            TextBoxAvailability.Text = selectedRow.Cells("availability").Value.ToString()
            TextBoxId.Text = selectedRow.Cells("id").Value.ToString()
        End If
    End Sub
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim query As String = "UPDATE new_client.client_table SET title = @title, author = @author, category = @category, availability = @availability WHERE id = @id;"
        If String.IsNullOrWhiteSpace(TextBoxId.Text) Then
            MessageBox.Show("Please select a record to update first by double-clicking the grid.")
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBoxTitle.Text) Then
            MessageBox.Show("Please enter a title value before updating!", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTitle.Focus()
            Return
        End If
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxId.Text))
                    cmd.Parameters.AddWithValue("@title", TextBoxTitle.Text)
                    cmd.Parameters.AddWithValue("@author", TextBoxAuthor.Text)
                    cmd.Parameters.AddWithValue("@category", TextBoxCategory.Text)
                    cmd.Parameters.AddWithValue("@availability", TextBoxAvailability.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message)
        End Try
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String = "DELETE FROM new_client.client_table WHERE id = @id;"
        If String.IsNullOrWhiteSpace(TextBoxId.Text) Then
            MessageBox.Show("Please select a record to delete first by double-clicking the grid.")
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If
        Try
            Using conn As New MySqlConnection(CONN_STRING)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxId.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                    TextBoxId.Clear()
                    TextBoxTitle.Clear()
                    TextBoxAuthor.Clear()
                    TextBoxCategory.Clear()
                    TextBoxAvailability.Clear()
                    ButtonRead_Click(Nothing, EventArgs.Empty)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error deleting record: " & ex.Message)
        End Try
    End Sub


End Class

