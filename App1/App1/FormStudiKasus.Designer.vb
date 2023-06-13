<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStudiKasus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonImportFromExcel = New System.Windows.Forms.Button()
        Me.ButtonExportToExcel = New System.Windows.Forms.Button()
        Me.ButtonClearDGV = New System.Windows.Forms.Button()
        Me.TextBoxNumberOfRows = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCreateData = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(124, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 312)
        Me.DataGridView1.TabIndex = 11
        '
        'ButtonImportFromExcel
        '
        Me.ButtonImportFromExcel.Location = New System.Drawing.Point(805, 21)
        Me.ButtonImportFromExcel.Name = "ButtonImportFromExcel"
        Me.ButtonImportFromExcel.Size = New System.Drawing.Size(198, 23)
        Me.ButtonImportFromExcel.TabIndex = 8
        Me.ButtonImportFromExcel.Text = "IMPORT TO MS EXCEL"
        Me.ButtonImportFromExcel.UseVisualStyleBackColor = True
        '
        'ButtonExportToExcel
        '
        Me.ButtonExportToExcel.Location = New System.Drawing.Point(601, 18)
        Me.ButtonExportToExcel.Name = "ButtonExportToExcel"
        Me.ButtonExportToExcel.Size = New System.Drawing.Size(198, 23)
        Me.ButtonExportToExcel.TabIndex = 9
        Me.ButtonExportToExcel.Text = "EXPORT TO MS EXCEL"
        Me.ButtonExportToExcel.UseVisualStyleBackColor = True
        '
        'ButtonClearDGV
        '
        Me.ButtonClearDGV.Location = New System.Drawing.Point(397, 18)
        Me.ButtonClearDGV.Name = "ButtonClearDGV"
        Me.ButtonClearDGV.Size = New System.Drawing.Size(198, 23)
        Me.ButtonClearDGV.TabIndex = 10
        Me.ButtonClearDGV.Text = "CLEAR And Default Column"
        Me.ButtonClearDGV.UseVisualStyleBackColor = True
        '
        'TextBoxNumberOfRows
        '
        Me.TextBoxNumberOfRows.Location = New System.Drawing.Point(291, 18)
        Me.TextBoxNumberOfRows.Name = "TextBoxNumberOfRows"
        Me.TextBoxNumberOfRows.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumberOfRows.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Number Rows :"
        '
        'ButtonCreateData
        '
        Me.ButtonCreateData.Location = New System.Drawing.Point(124, 16)
        Me.ButtonCreateData.Name = "ButtonCreateData"
        Me.ButtonCreateData.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCreateData.TabIndex = 5
        Me.ButtonCreateData.Text = "Make Data"
        Me.ButtonCreateData.UseVisualStyleBackColor = True
        '
        'FormStudiKasus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 557)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonImportFromExcel)
        Me.Controls.Add(Me.ButtonExportToExcel)
        Me.Controls.Add(Me.ButtonClearDGV)
        Me.Controls.Add(Me.TextBoxNumberOfRows)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCreateData)
        Me.Name = "FormStudiKasus"
        Me.Text = "FormStudiKasus"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonImportFromExcel As Button
    Friend WithEvents ButtonExportToExcel As Button
    Friend WithEvents ButtonClearDGV As Button
    Friend WithEvents TextBoxNumberOfRows As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCreateData As Button
End Class
