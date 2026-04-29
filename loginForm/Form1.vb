Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlConnection
Public Class Form1

    Private Sub xbtnLogin_Click(sender As Object, e As EventArgs) Handles xbtnLogin.Click
        Dim connstring As String = "Server=192.168.10.;Port=3306;Database=myproject;Uid=root;Password=;"
        Using conn As New MySqlConnection(connstring)
            Try
                conn.Open()
                Dim command As New MySqlCommand("select * from Table_login where username = @username and password = @password", conn)
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = xtxtboxUserName.Text
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = xtxtboxPassword.Text
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() <= 0 Then
                    MessageBox.Show("Username or Password are Invalid")
                Else
                    MessageBox.Show("Login Successful")
                    Dim frm As New Print_insert_update_delete
                    Me.Hide()
                    frm.Show()

                End If

            Catch ex As MySqlException
                MessageBox.Show("MySQL error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub XbtnCancel_Click(sender As Object, e As EventArgs) Handles XbtnCancel.Click
        Me.Close()
    End Sub


    Private Sub xcheckbxShowPasswd_CheckedChanged(sender As Object, e As EventArgs) Handles xcheckbxShowPasswd.CheckedChanged
        If xcheckbxShowPasswd.Checked Then
            xtxtboxPassword.PasswordChar = Nothing
        Else
            xtxtboxPassword.PasswordChar = "*"c
        End If
    End Sub


End Class
