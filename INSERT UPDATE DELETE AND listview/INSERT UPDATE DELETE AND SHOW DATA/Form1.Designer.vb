<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LISTSHOW = New System.Windows.Forms.ListView()
        Me.CLMID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLMNAMA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BUTTONINSERT = New System.Windows.Forms.Button()
        Me.BUTTONUPDATE = New System.Windows.Forms.Button()
        Me.BUTTONDELETE = New System.Windows.Forms.Button()
        Me.BUTTONSHOW = New System.Windows.Forms.Button()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LISTSHOW
        '
        Me.LISTSHOW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CLMID, Me.CLMNAMA})
        Me.LISTSHOW.FullRowSelect = True
        Me.LISTSHOW.GridLines = True
        Me.LISTSHOW.HideSelection = False
        Me.LISTSHOW.Location = New System.Drawing.Point(21, 98)
        Me.LISTSHOW.Name = "LISTSHOW"
        Me.LISTSHOW.Size = New System.Drawing.Size(318, 134)
        Me.LISTSHOW.TabIndex = 0
        Me.LISTSHOW.UseCompatibleStateImageBehavior = False
        Me.LISTSHOW.View = System.Windows.Forms.View.Details
        '
        'CLMID
        '
        Me.CLMID.Text = "ID"
        '
        'CLMNAMA
        '
        Me.CLMNAMA.Text = "NAMA"
        Me.CLMNAMA.Width = 200
        '
        'BUTTONINSERT
        '
        Me.BUTTONINSERT.Location = New System.Drawing.Point(21, 69)
        Me.BUTTONINSERT.Name = "BUTTONINSERT"
        Me.BUTTONINSERT.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONINSERT.TabIndex = 1
        Me.BUTTONINSERT.Text = "TAMBAH"
        Me.BUTTONINSERT.UseVisualStyleBackColor = True
        '
        'BUTTONUPDATE
        '
        Me.BUTTONUPDATE.Location = New System.Drawing.Point(102, 69)
        Me.BUTTONUPDATE.Name = "BUTTONUPDATE"
        Me.BUTTONUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONUPDATE.TabIndex = 2
        Me.BUTTONUPDATE.Text = "UBAH"
        Me.BUTTONUPDATE.UseVisualStyleBackColor = True
        '
        'BUTTONDELETE
        '
        Me.BUTTONDELETE.Location = New System.Drawing.Point(183, 69)
        Me.BUTTONDELETE.Name = "BUTTONDELETE"
        Me.BUTTONDELETE.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONDELETE.TabIndex = 3
        Me.BUTTONDELETE.Text = "HAPUS"
        Me.BUTTONDELETE.UseVisualStyleBackColor = True
        '
        'BUTTONSHOW
        '
        Me.BUTTONSHOW.Location = New System.Drawing.Point(264, 69)
        Me.BUTTONSHOW.Name = "BUTTONSHOW"
        Me.BUTTONSHOW.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONSHOW.TabIndex = 4
        Me.BUTTONSHOW.Text = "TAMPIL"
        Me.BUTTONSHOW.UseVisualStyleBackColor = True
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(85, 12)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(126, 20)
        Me.TXTID.TabIndex = 5
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Location = New System.Drawing.Point(85, 38)
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(126, 20)
        Me.TXTNAMA.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NAMA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 283)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTNAMA)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.BUTTONSHOW)
        Me.Controls.Add(Me.BUTTONDELETE)
        Me.Controls.Add(Me.BUTTONUPDATE)
        Me.Controls.Add(Me.BUTTONINSERT)
        Me.Controls.Add(Me.LISTSHOW)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LISTSHOW As ListView
    Friend WithEvents CLMID As ColumnHeader
    Friend WithEvents CLMNAMA As ColumnHeader
    Friend WithEvents BUTTONINSERT As Button
    Friend WithEvents BUTTONUPDATE As Button
    Friend WithEvents BUTTONDELETE As Button
    Friend WithEvents BUTTONSHOW As Button
    Friend WithEvents TXTID As TextBox
    Friend WithEvents TXTNAMA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
