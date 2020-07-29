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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listTeman = New System.Windows.Forms.ListBox()
        Me.tombolBaca = New System.Windows.Forms.Button()
        Me.tombolBersihkan = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listTeman)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Tentang Teman"
        '
        'listTeman
        '
        Me.listTeman.FormattingEnabled = True
        Me.listTeman.Location = New System.Drawing.Point(10, 20)
        Me.listTeman.Name = "listTeman"
        Me.listTeman.Size = New System.Drawing.Size(476, 186)
        Me.listTeman.TabIndex = 0
        '
        'tombolBaca
        '
        Me.tombolBaca.Location = New System.Drawing.Point(3, 239)
        Me.tombolBaca.Name = "tombolBaca"
        Me.tombolBaca.Size = New System.Drawing.Size(131, 34)
        Me.tombolBaca.TabIndex = 1
        Me.tombolBaca.Text = "&Baca Dari File"
        Me.tombolBaca.UseVisualStyleBackColor = True
        '
        'tombolBersihkan
        '
        Me.tombolBersihkan.Location = New System.Drawing.Point(178, 239)
        Me.tombolBersihkan.Name = "tombolBersihkan"
        Me.tombolBersihkan.Size = New System.Drawing.Size(131, 34)
        Me.tombolBersihkan.TabIndex = 2
        Me.tombolBersihkan.Text = "B&ersihkan"
        Me.tombolBersihkan.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(358, 239)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(131, 34)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "&Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 285)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBersihkan)
        Me.Controls.Add(Me.tombolBaca)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Demo ReadLine File"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents listTeman As System.Windows.Forms.ListBox
    Friend WithEvents tombolBaca As System.Windows.Forms.Button
    Friend WithEvents tombolBersihkan As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
