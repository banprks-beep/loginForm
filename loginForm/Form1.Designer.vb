<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        xbtnLogin = New Button()
        xtxtboxUserName = New TextBox()
        xlblUsername = New Label()
        xtxtboxPassword = New TextBox()
        xlblPassword = New Label()
        XbtnCancel = New Button()
        xcheckbxShowPasswd = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 121)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 222)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' xbtnLogin
        ' 
        xbtnLogin.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        xbtnLogin.Location = New Point(261, 470)
        xbtnLogin.Name = "xbtnLogin"
        xbtnLogin.Size = New Size(213, 84)
        xbtnLogin.TabIndex = 1
        xbtnLogin.Text = "Login"
        xbtnLogin.UseVisualStyleBackColor = False
        ' 
        ' xtxtboxUserName
        ' 
        xtxtboxUserName.Font = New Font("Microsoft Sans Serif", 12F)
        xtxtboxUserName.Location = New Point(491, 157)
        xtxtboxUserName.Name = "xtxtboxUserName"
        xtxtboxUserName.Size = New Size(404, 44)
        xtxtboxUserName.TabIndex = 2
        ' 
        ' xlblUsername
        ' 
        xlblUsername.AutoSize = True
        xlblUsername.Font = New Font("Microsoft Sans Serif", 12F)
        xlblUsername.Location = New Point(293, 158)
        xlblUsername.Name = "xlblUsername"
        xlblUsername.Size = New Size(164, 37)
        xlblUsername.TabIndex = 3
        xlblUsername.Text = "Username"
        ' 
        ' xtxtboxPassword
        ' 
        xtxtboxPassword.Font = New Font("Microsoft Sans Serif", 12F)
        xtxtboxPassword.Location = New Point(491, 246)
        xtxtboxPassword.Name = "xtxtboxPassword"
        xtxtboxPassword.PasswordChar = "*"c
        xtxtboxPassword.Size = New Size(404, 44)
        xtxtboxPassword.TabIndex = 4
        ' 
        ' xlblPassword
        ' 
        xlblPassword.AutoSize = True
        xlblPassword.Font = New Font("Microsoft Sans Serif", 12F)
        xlblPassword.Location = New Point(293, 255)
        xlblPassword.Name = "xlblPassword"
        xlblPassword.Size = New Size(158, 37)
        xlblPassword.TabIndex = 5
        xlblPassword.Text = "Password"
        ' 
        ' XbtnCancel
        ' 
        XbtnCancel.BackColor = Color.IndianRed
        XbtnCancel.Location = New Point(571, 469)
        XbtnCancel.Name = "XbtnCancel"
        XbtnCancel.Size = New Size(213, 84)
        XbtnCancel.TabIndex = 6
        XbtnCancel.Text = "Cancel"
        XbtnCancel.UseVisualStyleBackColor = False
        ' 
        ' xcheckbxShowPasswd
        ' 
        xcheckbxShowPasswd.AutoSize = True
        xcheckbxShowPasswd.Font = New Font("Microsoft Sans Serif", 12F)
        xcheckbxShowPasswd.Location = New Point(502, 326)
        xcheckbxShowPasswd.Name = "xcheckbxShowPasswd"
        xcheckbxShowPasswd.Size = New Size(279, 41)
        xcheckbxShowPasswd.TabIndex = 7
        xcheckbxShowPasswd.Text = "Show Password"
        xcheckbxShowPasswd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(970, 703)
        Controls.Add(xcheckbxShowPasswd)
        Controls.Add(XbtnCancel)
        Controls.Add(xlblPassword)
        Controls.Add(xtxtboxPassword)
        Controls.Add(xlblUsername)
        Controls.Add(xtxtboxUserName)
        Controls.Add(xbtnLogin)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents xbtnLogin As Button
    Friend WithEvents xtxtboxUserName As TextBox
    Friend WithEvents xlblUsername As Label
    Friend WithEvents xtxtboxPassword As TextBox
    Friend WithEvents xlblPassword As Label
    Friend WithEvents XbtnCancel As Button
    Friend WithEvents xcheckbxShowPasswd As CheckBox

End Class
