<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserViewer
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
        Me.components = New System.ComponentModel.Container()
        Me.userStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userCountLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userDGView = New System.Windows.Forms.DataGridView()
        Me.userID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secretQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secretA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userStatusStrip.SuspendLayout()
        CType(Me.userDGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'userStatusStrip
        '
        Me.userStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel, Me.userCountLbl})
        Me.userStatusStrip.Location = New System.Drawing.Point(0, 330)
        Me.userStatusStrip.Name = "userStatusStrip"
        Me.userStatusStrip.Size = New System.Drawing.Size(772, 22)
        Me.userStatusStrip.TabIndex = 0
        Me.userStatusStrip.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(63, 17)
        Me.statusLabel.Text = "Total User:"
        '
        'userCountLbl
        '
        Me.userCountLbl.Name = "userCountLbl"
        Me.userCountLbl.Size = New System.Drawing.Size(19, 17)
        Me.userCountLbl.Text = "00"
        '
        'userDGView
        '
        Me.userDGView.AllowUserToAddRows = False
        Me.userDGView.AllowUserToDeleteRows = False
        Me.userDGView.AllowUserToOrderColumns = True
        Me.userDGView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userDGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userID, Me.userName, Me.userType, Me.secretQ, Me.secretA})
        Me.userDGView.ContextMenuStrip = Me.ctxMenu
        Me.userDGView.Location = New System.Drawing.Point(0, 0)
        Me.userDGView.Name = "userDGView"
        Me.userDGView.ReadOnly = True
        Me.userDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userDGView.Size = New System.Drawing.Size(772, 327)
        Me.userDGView.TabIndex = 1
        '
        'userID
        '
        Me.userID.HeaderText = "User ID"
        Me.userID.Name = "userID"
        Me.userID.ReadOnly = True
        '
        'userName
        '
        Me.userName.HeaderText = "User Name"
        Me.userName.Name = "userName"
        Me.userName.ReadOnly = True
        '
        'userType
        '
        Me.userType.HeaderText = "User Type"
        Me.userType.Name = "userType"
        Me.userType.ReadOnly = True
        '
        'secretQ
        '
        Me.secretQ.HeaderText = "Secret Question"
        Me.secretQ.Name = "secretQ"
        Me.secretQ.ReadOnly = True
        '
        'secretA
        '
        Me.secretA.HeaderText = "SecretAnswer"
        Me.secretA.Name = "secretA"
        Me.secretA.ReadOnly = True
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(153, 92)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UserViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 352)
        Me.Controls.Add(Me.userDGView)
        Me.Controls.Add(Me.userStatusStrip)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(788, 390)
        Me.Name = "UserViewer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User List"
        Me.userStatusStrip.ResumeLayout(False)
        Me.userStatusStrip.PerformLayout()
        CType(Me.userDGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userStatusStrip As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents userCountLbl As ToolStripStatusLabel
    Friend WithEvents userDGView As DataGridView
    Friend WithEvents userID As DataGridViewTextBoxColumn
    Friend WithEvents userName As DataGridViewTextBoxColumn
    Friend WithEvents userType As DataGridViewTextBoxColumn
    Friend WithEvents secretQ As DataGridViewTextBoxColumn
    Friend WithEvents secretA As DataGridViewTextBoxColumn
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
