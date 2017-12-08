<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfile
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.secretCombo = New System.Windows.Forms.ComboBox()
        Me.secretAnsTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.userNameTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(228, 117)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(116, 38)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(187, 20)
        Me.passTxt.TabIndex = 1
        Me.passTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'secretCombo
        '
        Me.secretCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.secretCombo.FormattingEnabled = True
        Me.secretCombo.Items.AddRange(New Object() {"- Select Question -", "Question 1", "Question 2", "Question 3"})
        Me.secretCombo.Location = New System.Drawing.Point(116, 64)
        Me.secretCombo.Name = "secretCombo"
        Me.secretCombo.Size = New System.Drawing.Size(187, 21)
        Me.secretCombo.TabIndex = 2
        '
        'secretAnsTxt
        '
        Me.secretAnsTxt.Location = New System.Drawing.Point(116, 91)
        Me.secretAnsTxt.Name = "secretAnsTxt"
        Me.secretAnsTxt.Size = New System.Drawing.Size(187, 20)
        Me.secretAnsTxt.TabIndex = 3
        Me.secretAnsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Secret Question:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Secret Answer:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(147, 117)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'userNameTxt
        '
        Me.userNameTxt.Location = New System.Drawing.Point(116, 12)
        Me.userNameTxt.Name = "userNameTxt"
        Me.userNameTxt.ReadOnly = True
        Me.userNameTxt.Size = New System.Drawing.Size(187, 20)
        Me.userNameTxt.TabIndex = 8
        Me.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Username:"
        '
        'EditProfile
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(315, 150)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.userNameTxt)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.secretAnsTxt)
        Me.Controls.Add(Me.secretCombo)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditProfile"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents passTxt As TextBox
    Friend WithEvents secretCombo As ComboBox
    Friend WithEvents secretAnsTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents userNameTxt As TextBox
    Friend WithEvents Label4 As Label
End Class
