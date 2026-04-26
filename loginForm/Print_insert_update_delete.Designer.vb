<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_insert_update_delete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print_insert_update_delete))
        xbtnSave = New Button()
        xbtnupdate = New Button()
        xbtndelete = New Button()
        xbtnPrint = New Button()
        xbtnExportToPdf = New Button()
        xbtntoexcel = New Button()
        xdgvRecord = New DataGridView()
        xbtnExit = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        xbtnExport = New Button()
        xProgressBar1 = New ProgressBar()
        Percent = New Label()
        XpbarText = New TextBox()
        CType(xdgvRecord, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' xbtnSave
        ' 
        xbtnSave.BackColor = Color.DarkKhaki
        xbtnSave.FlatStyle = FlatStyle.Popup
        xbtnSave.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtnSave.ForeColor = SystemColors.ButtonHighlight
        xbtnSave.Location = New Point(23, 803)
        xbtnSave.Name = "xbtnSave"
        xbtnSave.Size = New Size(194, 67)
        xbtnSave.TabIndex = 0
        xbtnSave.Text = "Save"
        xbtnSave.UseVisualStyleBackColor = False
        ' 
        ' xbtnupdate
        ' 
        xbtnupdate.BackColor = Color.DarkKhaki
        xbtnupdate.FlatStyle = FlatStyle.Popup
        xbtnupdate.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtnupdate.ForeColor = SystemColors.ButtonHighlight
        xbtnupdate.Location = New Point(270, 803)
        xbtnupdate.Name = "xbtnupdate"
        xbtnupdate.Size = New Size(194, 67)
        xbtnupdate.TabIndex = 1
        xbtnupdate.Text = "Update"
        xbtnupdate.UseVisualStyleBackColor = False
        ' 
        ' xbtndelete
        ' 
        xbtndelete.BackColor = Color.DarkKhaki
        xbtndelete.FlatStyle = FlatStyle.Popup
        xbtndelete.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtndelete.ForeColor = SystemColors.ButtonHighlight
        xbtndelete.Location = New Point(533, 803)
        xbtndelete.Name = "xbtndelete"
        xbtndelete.Size = New Size(194, 67)
        xbtndelete.TabIndex = 2
        xbtndelete.Text = "Delete"
        xbtndelete.UseVisualStyleBackColor = False
        ' 
        ' xbtnPrint
        ' 
        xbtnPrint.BackColor = Color.DarkKhaki
        xbtnPrint.FlatStyle = FlatStyle.Popup
        xbtnPrint.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtnPrint.ForeColor = SystemColors.ButtonHighlight
        xbtnPrint.Location = New Point(1439, 50)
        xbtnPrint.Name = "xbtnPrint"
        xbtnPrint.Size = New Size(164, 64)
        xbtnPrint.TabIndex = 3
        xbtnPrint.Text = "Print"
        xbtnPrint.UseVisualStyleBackColor = False
        ' 
        ' xbtnExportToPdf
        ' 
        xbtnExportToPdf.BackColor = Color.DarkKhaki
        xbtnExportToPdf.FlatStyle = FlatStyle.Popup
        xbtnExportToPdf.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtnExportToPdf.ForeColor = SystemColors.ButtonHighlight
        xbtnExportToPdf.Location = New Point(1336, 159)
        xbtnExportToPdf.Name = "xbtnExportToPdf"
        xbtnExportToPdf.Size = New Size(269, 64)
        xbtnExportToPdf.TabIndex = 4
        xbtnExportToPdf.Text = "Export to PDF"
        xbtnExportToPdf.UseVisualStyleBackColor = False
        ' 
        ' xbtntoexcel
        ' 
        xbtntoexcel.BackColor = Color.DarkKhaki
        xbtntoexcel.FlatStyle = FlatStyle.Popup
        xbtntoexcel.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtntoexcel.ForeColor = SystemColors.ButtonHighlight
        xbtntoexcel.Location = New Point(1287, 289)
        xbtntoexcel.Name = "xbtntoexcel"
        xbtntoexcel.Size = New Size(318, 64)
        xbtntoexcel.TabIndex = 5
        xbtntoexcel.Text = "Export to Excel"
        xbtntoexcel.UseVisualStyleBackColor = False
        ' 
        ' xdgvRecord
        ' 
        xdgvRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        xdgvRecord.BackgroundColor = SystemColors.InactiveCaption
        xdgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        xdgvRecord.Location = New Point(12, 26)
        xdgvRecord.Name = "xdgvRecord"
        xdgvRecord.RowHeadersWidth = 82
        xdgvRecord.Size = New Size(1234, 750)
        xdgvRecord.TabIndex = 6
        ' 
        ' xbtnExit
        ' 
        xbtnExit.BackColor = Color.DarkKhaki
        xbtnExit.FlatStyle = FlatStyle.Popup
        xbtnExit.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtnExit.ForeColor = SystemColors.ButtonHighlight
        xbtnExit.Location = New Point(890, 782)
        xbtnExit.Name = "xbtnExit"
        xbtnExit.Size = New Size(194, 67)
        xbtnExit.TabIndex = 7
        xbtnExit.Text = "Exit"
        xbtnExit.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        ' 
        ' xbtnExport
        ' 
        xbtnExport.BackColor = Color.DarkKhaki
        xbtnExport.FlatStyle = FlatStyle.Popup
        xbtnExport.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        xbtnExport.ForeColor = SystemColors.ButtonHighlight
        xbtnExport.Location = New Point(1299, 421)
        xbtnExport.Name = "xbtnExport"
        xbtnExport.Size = New Size(269, 64)
        xbtnExport.TabIndex = 8
        xbtnExport.Text = "Export "
        xbtnExport.UseVisualStyleBackColor = False
        ' 
        ' xProgressBar1
        ' 
        xProgressBar1.Location = New Point(1252, 520)
        xProgressBar1.Name = "xProgressBar1"
        xProgressBar1.Size = New Size(185, 41)
        xProgressBar1.TabIndex = 9
        ' 
        ' Percent
        ' 
        Percent.AutoSize = True
        Percent.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Percent.Location = New Point(1439, 520)
        Percent.Name = "Percent"
        Percent.Size = New Size(48, 45)
        Percent.TabIndex = 10
        Percent.Text = "%"
        ' 
        ' XpbarText
        ' 
        XpbarText.Location = New Point(1484, 520)
        XpbarText.Name = "XpbarText"
        XpbarText.Size = New Size(133, 39)
        XpbarText.TabIndex = 11
        ' 
        ' Print_insert_update_delete
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1629, 912)
        Controls.Add(XpbarText)
        Controls.Add(Percent)
        Controls.Add(xProgressBar1)
        Controls.Add(xbtnExport)
        Controls.Add(xbtnExit)
        Controls.Add(xdgvRecord)
        Controls.Add(xbtntoexcel)
        Controls.Add(xbtnExportToPdf)
        Controls.Add(xbtnPrint)
        Controls.Add(xbtndelete)
        Controls.Add(xbtnupdate)
        Controls.Add(xbtnSave)
        Name = "Print_insert_update_delete"
        Text = "Print_insert_update_delete"
        CType(xdgvRecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents xbtnSave As Button
    Friend WithEvents xbtnupdate As Button
    Friend WithEvents xbtndelete As Button
    Friend WithEvents xbtnPrint As Button
    Friend WithEvents xbtnExportToPdf As Button
    Friend WithEvents xbtntoexcel As Button
    Friend WithEvents xdgvRecord As DataGridView
    Friend WithEvents xbtnExit As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents xbtnExport As Button
    Friend WithEvents xProgressBar1 As ProgressBar
    Friend WithEvents Percent As Label
    Friend WithEvents XpbarText As TextBox
End Class
