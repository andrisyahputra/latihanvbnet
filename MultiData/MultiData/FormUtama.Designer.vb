<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DaftarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarPeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarRefrensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DaftarKomponenMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DaftarToolStripMenuItem
        '
        Me.DaftarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarPeminjamToolStripMenuItem, Me.DaftarRefrensiToolStripMenuItem, Me.ToolStripMenuItem1, Me.DaftarKomponenMobilToolStripMenuItem, Me.DaftarMobilToolStripMenuItem})
        Me.DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        Me.DaftarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.DaftarToolStripMenuItem.Text = "Master"
        '
        'DaftarPeminjamToolStripMenuItem
        '
        Me.DaftarPeminjamToolStripMenuItem.Name = "DaftarPeminjamToolStripMenuItem"
        Me.DaftarPeminjamToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DaftarPeminjamToolStripMenuItem.Text = "Daftar Peminjam"
        '
        'DaftarRefrensiToolStripMenuItem
        '
        Me.DaftarRefrensiToolStripMenuItem.Name = "DaftarRefrensiToolStripMenuItem"
        Me.DaftarRefrensiToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DaftarRefrensiToolStripMenuItem.Text = "Daftar Refrensi"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(199, 6)
        '
        'DaftarKomponenMobilToolStripMenuItem
        '
        Me.DaftarKomponenMobilToolStripMenuItem.Name = "DaftarKomponenMobilToolStripMenuItem"
        Me.DaftarKomponenMobilToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DaftarKomponenMobilToolStripMenuItem.Text = "Daftar Komponen Mobil"
        '
        'DaftarMobilToolStripMenuItem
        '
        Me.DaftarMobilToolStripMenuItem.Name = "DaftarMobilToolStripMenuItem"
        Me.DaftarMobilToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DaftarMobilToolStripMenuItem.Text = "Daftar Mobil"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "Form Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarPeminjamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarRefrensiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents DaftarKomponenMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
