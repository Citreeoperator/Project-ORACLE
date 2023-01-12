<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReports
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnIMT = New System.Windows.Forms.Button()
        Me.btnPersonnel = New System.Windows.Forms.Button()
        Me.btnIR = New System.Windows.Forms.Button()
        Me.btnPTS = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 37)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 38)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "REPORTS"
        '
        'pnlReports
        '
        Me.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReports.Location = New System.Drawing.Point(315, 37)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(1589, 875)
        Me.pnlReports.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 875)
        Me.Panel2.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnIMT)
        Me.GroupBox2.Controls.Add(Me.btnPersonnel)
        Me.GroupBox2.Controls.Add(Me.btnIR)
        Me.GroupBox2.Controls.Add(Me.btnPTS)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 196)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnIMT
        '
        Me.btnIMT.BackColor = System.Drawing.Color.Blue
        Me.btnIMT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIMT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnIMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnIMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIMT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIMT.ForeColor = System.Drawing.Color.White
        Me.btnIMT.Location = New System.Drawing.Point(6, 149)
        Me.btnIMT.Name = "btnIMT"
        Me.btnIMT.Size = New System.Drawing.Size(303, 31)
        Me.btnIMT.TabIndex = 11
        Me.btnIMT.Text = "Incident Management Team"
        Me.btnIMT.UseVisualStyleBackColor = False
        '
        'btnPersonnel
        '
        Me.btnPersonnel.BackColor = System.Drawing.Color.Blue
        Me.btnPersonnel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPersonnel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnPersonnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonnel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPersonnel.ForeColor = System.Drawing.Color.White
        Me.btnPersonnel.Location = New System.Drawing.Point(6, 112)
        Me.btnPersonnel.Name = "btnPersonnel"
        Me.btnPersonnel.Size = New System.Drawing.Size(303, 31)
        Me.btnPersonnel.TabIndex = 10
        Me.btnPersonnel.Text = "Office Personnel"
        Me.btnPersonnel.UseVisualStyleBackColor = False
        '
        'btnIR
        '
        Me.btnIR.BackColor = System.Drawing.Color.Blue
        Me.btnIR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIR.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIR.ForeColor = System.Drawing.Color.White
        Me.btnIR.Location = New System.Drawing.Point(6, 75)
        Me.btnIR.Name = "btnIR"
        Me.btnIR.Size = New System.Drawing.Size(303, 31)
        Me.btnIR.TabIndex = 9
        Me.btnIR.Text = "Incident Report"
        Me.btnIR.UseVisualStyleBackColor = False
        '
        'btnPTS
        '
        Me.btnPTS.BackColor = System.Drawing.Color.Blue
        Me.btnPTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPTS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPTS.ForeColor = System.Drawing.Color.White
        Me.btnPTS.Location = New System.Drawing.Point(6, 38)
        Me.btnPTS.Name = "btnPTS"
        Me.btnPTS.Size = New System.Drawing.Size(303, 31)
        Me.btnPTS.TabIndex = 8
        Me.btnPTS.Text = "Patient Transfer"
        Me.btnPTS.UseVisualStyleBackColor = False
        '
        'FormReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 912)
        Me.Controls.Add(Me.pnlReports)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlReports As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnIMT As Button
    Friend WithEvents btnPersonnel As Button
    Friend WithEvents btnIR As Button
    Friend WithEvents btnPTS As Button
End Class
