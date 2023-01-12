<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPT
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRS = New System.Windows.Forms.Button()
        Me.btnTR = New System.Windows.Forms.Button()
        Me.pnlRPTContainer = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRS)
        Me.Panel1.Controls.Add(Me.btnTR)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 875)
        Me.Panel1.TabIndex = 0
        '
        'btnRS
        '
        Me.btnRS.BackColor = System.Drawing.Color.Blue
        Me.btnRS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRS.ForeColor = System.Drawing.Color.White
        Me.btnRS.Location = New System.Drawing.Point(0, 75)
        Me.btnRS.Name = "btnRS"
        Me.btnRS.Size = New System.Drawing.Size(199, 31)
        Me.btnRS.TabIndex = 15
        Me.btnRS.Text = "Regular Schedule"
        Me.btnRS.UseVisualStyleBackColor = False
        '
        'btnTR
        '
        Me.btnTR.BackColor = System.Drawing.Color.Blue
        Me.btnTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTR.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTR.ForeColor = System.Drawing.Color.White
        Me.btnTR.Location = New System.Drawing.Point(0, 38)
        Me.btnTR.Name = "btnTR"
        Me.btnTR.Size = New System.Drawing.Size(199, 31)
        Me.btnTR.TabIndex = 14
        Me.btnTR.Text = "Transfer Request"
        Me.btnTR.UseVisualStyleBackColor = False
        '
        'pnlRPTContainer
        '
        Me.pnlRPTContainer.Location = New System.Drawing.Point(199, 0)
        Me.pnlRPTContainer.Name = "pnlRPTContainer"
        Me.pnlRPTContainer.Size = New System.Drawing.Size(1390, 875)
        Me.pnlRPTContainer.TabIndex = 3
        '
        'FormPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1589, 875)
        Me.Controls.Add(Me.pnlRPTContainer)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPT"
        Me.Text = "FormPT"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlRPTContainer As Panel
    Friend WithEvents btnRS As Button
    Friend WithEvents btnTR As Button
End Class
