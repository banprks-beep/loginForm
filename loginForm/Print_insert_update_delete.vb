Imports Mysqlx.XDevAPI.Relational

Public Class Print_insert_update_delete
    Dim table As New DataTable
    Dim bitmap As Bitmap


    Private Sub Print_insert_update_delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseFunction.GetAllData(xdgvRecord, table)


    End Sub

    Private Sub xbtnSave_Click(sender As Object, e As EventArgs) Handles xbtnSave.Click
        If xdgvRecord.Rows.Count > 0 Then

            For Each row As DataGridViewRow In xdgvRecord.Rows
                If row.IsNewRow Then Continue For
                Dim Id = row.Cells("Id").Value.ToString
                Dim E_Name = row.Cells("Name").Value.ToString
                Dim Age = row.Cells("Age").Value.ToString
                Dim Salary = row.Cells("Salary").Value.ToString
                Dim Department = row.Cells("Department").Value.ToString
                DatabaseFunction.InserttoDb(Id, E_Name, Age, Salary, Department)
            Next
            MessageBox.Show("Saved successfullly")
        End If
    End Sub

    Private Sub xbtnupdate_Click(sender As Object, e As EventArgs) Handles xbtnupdate.Click
        If xdgvRecord.Rows.Count > 0 Then

            For Each row As DataGridViewRow In xdgvRecord.Rows
                If row.IsNewRow Then Continue For
                Dim E_Name = row.Cells("Name").Value.ToString
                Dim Age = row.Cells("Age").Value.ToString
                Dim Salary = row.Cells("Salary").Value.ToString
                Dim Department = row.Cells("Department").Value.ToString
                Dim Id = row.Cells("Id").Value.ToString
                DatabaseFunction.UpdatetoDb(E_Name, Age, Salary, Department, Id)
            Next
            MessageBox.Show("Updated successfullly")
        End If

    End Sub

    Private Sub xbtndelete_Click(sender As Object, e As EventArgs) Handles xbtndelete.Click
        Dim selected_rowsIndex = xdgvRecord.SelectedRows.Count - 1
        If xdgvRecord.SelectedRows.Count > 0 Then
            For row As Integer = selected_rowsIndex To 0 Step -1
                DatabaseFunction.DeleteFromDb(xdgvRecord.SelectedRows(row).Cells("Id").Value.ToString)
                xdgvRecord.Rows.RemoveAt(xdgvRecord.SelectedRows(row).Index)
            Next
            MessageBox.Show("Deleted Completed")
        End If

    End Sub

    Private Sub xbtnExit_Click(sender As Object, e As EventArgs) Handles xbtnExit.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Do you really want to exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub xbtnPrint_Click(sender As Object, e As EventArgs) Handles xbtnPrint.Click
        Dim height As Integer = xdgvRecord.Height
        xdgvRecord.Height = xdgvRecord.RowCount * xdgvRecord.RowTemplate.Height
        bitmap = New Bitmap(Me.xdgvRecord.Width, Me.xdgvRecord.Height)
        xdgvRecord.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.xdgvRecord.Width, Me.xdgvRecord.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        xdgvRecord.Height = height

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recP As RectangleF = e.PageSettings.PrintableArea
        If Me.xdgvRecord.Height - recP.Height > 0 Then e.HasMorePages = True

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = 0 To 100
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(i)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        xProgressBar1.Value = e.ProgressPercentage
        XpbarText.Text = e.ProgressPercentage.ToString()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        XpbarText.Text = " "
        xProgressBar1.Value = 0
    End Sub

    Private Sub xbtnExport_Click(sender As Object, e As EventArgs) Handles xbtnExport.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class