<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageViewer
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
        Me.productPicture = New System.Windows.Forms.PictureBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        CType(Me.productPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productPicture
        '
        Me.productPicture.Image = Global.IMS.My.Resources.Resources.imagePlaceholder
        Me.productPicture.Location = New System.Drawing.Point(12, 12)
        Me.productPicture.Name = "productPicture"
        Me.productPicture.Size = New System.Drawing.Size(431, 324)
        Me.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productPicture.TabIndex = 0
        Me.productPicture.TabStop = False
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(12, 342)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(431, 23)
        Me.exitBtn.TabIndex = 1
        Me.exitBtn.Text = "Close"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'ImageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 377)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.productPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImageViewer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Image"
        CType(Me.productPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents productPicture As PictureBox
    Friend WithEvents exitBtn As Button
End Class
