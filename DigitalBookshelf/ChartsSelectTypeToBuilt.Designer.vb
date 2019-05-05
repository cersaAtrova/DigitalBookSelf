<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChartsPreBuilt
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grbCategories = New System.Windows.Forms.GroupBox()
        Me.radByAuthor = New System.Windows.Forms.RadioButton()
        Me.radByReading = New System.Windows.Forms.RadioButton()
        Me.radByRating = New System.Windows.Forms.RadioButton()
        Me.radByCategory = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grbCategories.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOk.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(84, 260)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 39)
        Me.btnOk.TabIndex = 1
        Me.btnOk.TabStop = False
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(222, 260)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 39)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grbCategories
        '
        Me.grbCategories.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grbCategories.Controls.Add(Me.radByAuthor)
        Me.grbCategories.Controls.Add(Me.radByReading)
        Me.grbCategories.Controls.Add(Me.radByRating)
        Me.grbCategories.Controls.Add(Me.radByCategory)
        Me.grbCategories.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCategories.Location = New System.Drawing.Point(12, 30)
        Me.grbCategories.Name = "grbCategories"
        Me.grbCategories.Size = New System.Drawing.Size(439, 197)
        Me.grbCategories.TabIndex = 3
        Me.grbCategories.TabStop = False
        Me.grbCategories.Text = "Select Categoty "
        '
        'radByAuthor
        '
        Me.radByAuthor.AutoSize = True
        Me.radByAuthor.Location = New System.Drawing.Point(27, 132)
        Me.radByAuthor.Name = "radByAuthor"
        Me.radByAuthor.Size = New System.Drawing.Size(101, 22)
        Me.radByAuthor.TabIndex = 3
        Me.radByAuthor.TabStop = True
        Me.radByAuthor.Text = "By Author"
        Me.radByAuthor.UseVisualStyleBackColor = True
        '
        'radByReading
        '
        Me.radByReading.AutoSize = True
        Me.radByReading.Location = New System.Drawing.Point(276, 44)
        Me.radByReading.Name = "radByReading"
        Me.radByReading.Size = New System.Drawing.Size(109, 22)
        Me.radByReading.TabIndex = 2
        Me.radByReading.TabStop = True
        Me.radByReading.Text = "By Reading"
        Me.radByReading.UseVisualStyleBackColor = True
        '
        'radByRating
        '
        Me.radByRating.AutoSize = True
        Me.radByRating.Location = New System.Drawing.Point(276, 132)
        Me.radByRating.Name = "radByRating"
        Me.radByRating.Size = New System.Drawing.Size(101, 22)
        Me.radByRating.TabIndex = 1
        Me.radByRating.TabStop = True
        Me.radByRating.Text = "By Rating"
        Me.radByRating.UseVisualStyleBackColor = True
        '
        'radByCategory
        '
        Me.radByCategory.AutoSize = True
        Me.radByCategory.Checked = True
        Me.radByCategory.Location = New System.Drawing.Point(27, 44)
        Me.radByCategory.Name = "radByCategory"
        Me.radByCategory.Size = New System.Drawing.Size(117, 22)
        Me.radByCategory.TabIndex = 0
        Me.radByCategory.TabStop = True
        Me.radByCategory.Text = "By Category"
        Me.radByCategory.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmChartsPreBuilt
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(474, 350)
        Me.Controls.Add(Me.grbCategories)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(400, 200)
        Me.Name = "frmChartsPreBuilt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.grbCategories.ResumeLayout(False)
        Me.grbCategories.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grbCategories As GroupBox
    Friend WithEvents radByAuthor As RadioButton
    Friend WithEvents radByReading As RadioButton
    Friend WithEvents radByRating As RadioButton
    Friend WithEvents radByCategory As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
