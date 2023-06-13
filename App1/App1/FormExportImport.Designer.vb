<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExportImport
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
        Me.ButtonCreateData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumberOfRows = New System.Windows.Forms.TextBox()
        Me.ButtonClearDGV = New System.Windows.Forms.Button()
        Me.ButtonExportToExcel = New System.Windows.Forms.Button()
        Me.ButtonImportFromExcel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_Number2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_Number3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_Number4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCreateData
        '
        Me.ButtonCreateData.Location = New System.Drawing.Point(12, 12)
        Me.ButtonCreateData.Name = "ButtonCreateData"
        Me.ButtonCreateData.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCreateData.TabIndex = 0
        Me.ButtonCreateData.Text = "Make Data"
        Me.ButtonCreateData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number Rows :"
        '
        'TextBoxNumberOfRows
        '
        Me.TextBoxNumberOfRows.Location = New System.Drawing.Point(179, 14)
        Me.TextBoxNumberOfRows.Name = "TextBoxNumberOfRows"
        Me.TextBoxNumberOfRows.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumberOfRows.TabIndex = 2
        '
        'ButtonClearDGV
        '
        Me.ButtonClearDGV.Location = New System.Drawing.Point(285, 14)
        Me.ButtonClearDGV.Name = "ButtonClearDGV"
        Me.ButtonClearDGV.Size = New System.Drawing.Size(198, 23)
        Me.ButtonClearDGV.TabIndex = 3
        Me.ButtonClearDGV.Text = "CLEAR And Default Column"
        Me.ButtonClearDGV.UseVisualStyleBackColor = True
        '
        'ButtonExportToExcel
        '
        Me.ButtonExportToExcel.Location = New System.Drawing.Point(489, 14)
        Me.ButtonExportToExcel.Name = "ButtonExportToExcel"
        Me.ButtonExportToExcel.Size = New System.Drawing.Size(198, 23)
        Me.ButtonExportToExcel.TabIndex = 3
        Me.ButtonExportToExcel.Text = "EXPORT TO MS EXCEL"
        Me.ButtonExportToExcel.UseVisualStyleBackColor = True
        '
        'ButtonImportFromExcel
        '
        Me.ButtonImportFromExcel.Location = New System.Drawing.Point(693, 17)
        Me.ButtonImportFromExcel.Name = "ButtonImportFromExcel"
        Me.ButtonImportFromExcel.Size = New System.Drawing.Size(198, 23)
        Me.ButtonImportFromExcel.TabIndex = 3
        Me.ButtonImportFromExcel.Text = "IMPORT TO MS EXCEL"
        Me.ButtonImportFromExcel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Name_User, Me.Country, Me.City, Me.Phone_Number, Me.Phone_Number2, Me.Phone_Number3, Me.Phone_Number4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 312)
        Me.DataGridView1.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'Name_User
        '
        Me.Name_User.HeaderText = "Name_User"
        Me.Name_User.Name = "Name_User"
        '
        'Country
        '
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'Phone_Number
        '
        Me.Phone_Number.HeaderText = "Phone_Number"
        Me.Phone_Number.Name = "Phone_Number"
        '
        'Phone_Number2
        '
        Me.Phone_Number2.HeaderText = "Phone_Number2"
        Me.Phone_Number2.Name = "Phone_Number2"
        '
        'Phone_Number3
        '
        Me.Phone_Number3.HeaderText = "Phone_Number3"
        Me.Phone_Number3.Name = "Phone_Number3"
        '
        'Phone_Number4
        '
        Me.Phone_Number4.HeaderText = "Phone_Number4"
        Me.Phone_Number4.Name = "Phone_Number4"
        '
        'FormExportImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonImportFromExcel)
        Me.Controls.Add(Me.ButtonExportToExcel)
        Me.Controls.Add(Me.ButtonClearDGV)
        Me.Controls.Add(Me.TextBoxNumberOfRows)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCreateData)
        Me.Name = "FormExportImport"
        Me.Text = "FormExportImport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCreateData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumberOfRows As TextBox
    Friend WithEvents ButtonClearDGV As Button
    Friend WithEvents ButtonExportToExcel As Button
    Friend WithEvents ButtonImportFromExcel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Name_User As DataGridViewTextBoxColumn
    Friend WithEvents Country As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number As DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number2 As DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number3 As DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number4 As DataGridViewTextBoxColumn
End Class
