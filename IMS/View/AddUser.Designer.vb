<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.addUserGroup = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.userTypeCombo = New System.Windows.Forms.ComboBox()
        Me.resetForm = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.secretCombo = New System.Windows.Forms.ComboBox()
        Me.secretAnsTxt = New System.Windows.Forms.TextBox()
        Me.rpasswordTxt = New System.Windows.Forms.TextBox()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.userNameTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addUserGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'addUserGroup
        '
        Me.addUserGroup.Controls.Add(Me.Label6)
        Me.addUserGroup.Controls.Add(Me.userTypeCombo)
        Me.addUserGroup.Controls.Add(Me.resetForm)
        Me.addUserGroup.Controls.Add(Me.btnAddUser)
        Me.addUserGroup.Controls.Add(Me.showPassword)
        Me.addUserGroup.Controls.Add(Me.secretCombo)
        Me.addUserGroup.Controls.Add(Me.secretAnsTxt)
        Me.addUserGroup.Controls.Add(Me.rpasswordTxt)
        Me.addUserGroup.Controls.Add(Me.passwordTxt)
        Me.addUserGroup.Controls.Add(Me.userNameTxt)
        Me.addUserGroup.Controls.Add(Me.Label5)
        Me.addUserGroup.Controls.Add(Me.Label4)
        Me.addUserGroup.Controls.Add(Me.Label3)
        Me.addUserGroup.Controls.Add(Me.Label2)
        Me.addUserGroup.Controls.Add(Me.Label1)
        Me.addUserGroup.Location = New System.Drawing.Point(12, 12)
        Me.addUserGroup.Name = "addUserGroup"
        Me.addUserGroup.Size = New System.Drawing.Size(342, 269)
        Me.addUserGroup.TabIndex = 3
        Me.addUserGroup.TabStop = False
        Me.addUserGroup.Text = "New User Information"
        Me.addUserGroup.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "User Type:"
        '
        'userTypeCombo
        '
        Me.userTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userTypeCombo.FormattingEnabled = True
        Me.userTypeCombo.Items.AddRange(New Object() {"- Select User Type -", "Admin", "Staff"})
        Me.userTypeCombo.Location = New System.Drawing.Point(110, 120)
        Me.userTypeCombo.Name = "userTypeCombo"
        Me.userTypeCombo.Size = New System.Drawing.Size(226, 21)
        Me.userTypeCombo.TabIndex = 4
        '
        'resetForm
        '
        Me.resetForm.Location = New System.Drawing.Point(261, 211)
        Me.resetForm.Name = "resetForm"
        Me.resetForm.Size = New System.Drawing.Size(75, 23)
        Me.resetForm.TabIndex = 7
        Me.resetForm.Text = "Reset Form"
        Me.resetForm.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(261, 240)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 23)
        Me.btnAddUser.TabIndex = 8
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Location = New System.Drawing.Point(110, 97)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(102, 17)
        Me.showPassword.TabIndex = 3
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'secretCombo
        '
        Me.secretCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.secretCombo.FormattingEnabled = True
        Me.secretCombo.Items.AddRange(New Object() {"- Select Secret Question -", "Question 1", "Question 2", "Question 3"})
        Me.secretCombo.Location = New System.Drawing.Point(110, 147)
        Me.secretCombo.Name = "secretCombo"
        Me.secretCombo.Size = New System.Drawing.Size(226, 21)
        Me.secretCombo.TabIndex = 5
        '
        'secretAnsTxt
        '
        Me.secretAnsTxt.Location = New System.Drawing.Point(110, 174)
        Me.secretAnsTxt.Name = "secretAnsTxt"
        Me.secretAnsTxt.Size = New System.Drawing.Size(226, 20)
        Me.secretAnsTxt.TabIndex = 6
        Me.secretAnsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rpasswordTxt
        '
        Me.rpasswordTxt.Location = New System.Drawing.Point(110, 71)
        Me.rpasswordTxt.Name = "rpasswordTxt"
        Me.rpasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.rpasswordTxt.Size = New System.Drawing.Size(226, 20)
        Me.rpasswordTxt.TabIndex = 2
        Me.rpasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordTxt
        '
        Me.passwordTxt.Location = New System.Drawing.Point(110, 45)
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordTxt.Size = New System.Drawing.Size(226, 20)
        Me.passwordTxt.TabIndex = 1
        Me.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userNameTxt
        '
        Me.userNameTxt.Location = New System.Drawing.Point(110, 19)
        Me.userNameTxt.Name = "userNameTxt"
        Me.userNameTxt.Size = New System.Drawing.Size(226, 20)
        Me.userNameTxt.TabIndex = 0
        Me.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Answer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Secret Question:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Retype Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 293)
        Me.Controls.Add(Me.addUserGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddUser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New User"
        Me.addUserGroup.ResumeLayout(False)
        Me.addUserGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addUserGroup As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents userTypeCombo As ComboBox
    Friend WithEvents resetForm As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents secretCombo As ComboBox
    Friend WithEvents secretAnsTxt As TextBox
    Friend WithEvents rpasswordTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents userNameTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
