<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPersonnel
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
        Me.btnVolunteer = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.pnlRPTContainer = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnVolunteer)
        Me.Panel1.Controls.Add(Me.btnEmployee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 875)
        Me.Panel1.TabIndex = 4
        '
        'btnVolunteer
        '
        Me.btnVolunteer.BackColor = System.Drawing.Color.Blue
        Me.btnVolunteer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVolunteer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolunteer.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolunteer.ForeColor = System.Drawing.Color.White
        Me.btnVolunteer.Location = New System.Drawing.Point(0, 149)
        Me.btnVolunteer.Name = "btnVolunteer"
        Me.btnVolunteer.Size = New System.Drawing.Size(199, 31)
        Me.btnVolunteer.TabIndex = 15
        Me.btnVolunteer.Text = "Volunteer List"
        Me.btnVolunteer.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.Blue
        Me.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Location = New System.Drawing.Point(0, 112)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(199, 31)
        Me.btnEmployee.TabIndex = 14
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'pnlRPTContainer
        '
        Me.pnlRPTContainer.BackColor = System.Drawing.Color.Silver
        Me.pnlRPTContainer.Location = New System.Drawing.Point(199, 0)
        Me.pnlRPTContainer.Name = "pnlRPTContainer"
        Me.pnlRPTContainer.Size = New System.Drawing.Size(1390, 875)
        Me.pnlRPTContainer.TabIndex = 5
        '
        'ReportPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 875)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRPTContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportPersonnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ReportPersonnel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVolunteer As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents pnlRPTContainer As Panel
End Class
