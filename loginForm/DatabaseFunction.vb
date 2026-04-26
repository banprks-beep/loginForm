Imports MySql.Data.MySqlClient

Public Class DatabaseFunction
    Public Shared Sub InserttoDb(Id As String, Name As String, Age As String, Salary As String, Department As String)
        Dim connstring As String = "Server=192.168.1;Port=3306;Database=myproject;Uid=root;Password=;"
        Using conn As New MySqlConnection(connstring)
            Try
                conn.Open()
                Dim command As New MySqlCommand("INSERT IGNORE INTO Employee (Id, Name, Age, Salary, Department) VALUES (@Id,@Name,@Age,@Salary,@Department)", conn)
                command.Parameters.Add("@Id", MySqlDbType.Int32).Value = Convert.ToInt32(Id)
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name
                command.Parameters.Add("@Age", MySqlDbType.VarChar).Value = Age
                command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = Salary
                command.Parameters.Add("@Department", MySqlDbType.VarChar).Value = Department
                command.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("MySQL error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Shared Sub GetAllData(Datagridviewtable, table)
        Dim connstring As String = "Server=192.168.1;Port=3306;Database=myproject;Uid=root;Password=;"
        Using conn As New MySqlConnection(connstring)
            Try
                conn.Open()
                Dim command As New MySqlCommand("SELECT * FROM Employee", conn)
                Dim adapter As New MySqlDataAdapter(command)
                'Dim table As New DataTable()
                adapter.Fill(table)
                Datagridviewtable.datasource = table

            Catch ex As MySqlException
                MessageBox.Show("MySQL error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Public Shared Sub UpdatetoDb(Name As String, Age As String, Salary As String, Department As String, Id As String)
        Dim connstring As String = "Server=192.168.1;Port=3306;Database=myproject;Uid=root;Password=;"
        Using conn As New MySqlConnection(connstring)
            Try
                conn.Open()
                Dim command As New MySqlCommand("UPDATE Employee SET Name=@name, Age=@age, Salary=@salary, Department=@Department WHERE Id=@Id", conn)
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name
                command.Parameters.Add("@Age", MySqlDbType.VarChar).Value = Age
                command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = Salary
                command.Parameters.Add("@Department", MySqlDbType.VarChar).Value = Department
                command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = Convert.ToInt32(Id)
                command.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("MySQL error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Public Shared Sub DeleteFromDb(Id As String)
        Dim connstring As String = "Server=192.168.1;Port=3306;Database=myproject;Uid=root;Password=;"
        Using conn As New MySqlConnection(connstring)
            Try
                conn.Open()
                Dim command As New MySqlCommand("DELETE FROM Employee WHERE Id=@Id", conn)
                command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = Id
                command.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("MySQL error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


End Class
