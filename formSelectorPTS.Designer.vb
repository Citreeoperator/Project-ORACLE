<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSelectorPTS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSelectorPTS))
        Me.pnlPTSSelect = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIR = New System.Windows.Forms.Button()
        Me.btnPTS = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPTSSelect
        '
        Me.pnlPTSSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlPTSSelect.Location = New System.Drawing.Point(0, 37)
        Me.pnlPTSSelect.Name = "pnlPTSSelect"
        Me.pnlPTSSelect.Size = New System.Drawing.Size(1904, 918)
        Me.pnlPTSSelect.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnIR)
        Me.Panel1.Controls.Add(Me.btnPTS)
        Me.Panel1.Controls.Add(Me.PictureBox1)
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
        Me.Label5.Location = New System.Drawing.Point(717, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(470, 38)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "PATIENT TRANSPORT SERVICES"
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
        Me.btnIR.Location = New System.Drawing.Point(227, 1)
        Me.btnIR.Name = "btnIR"
        Me.btnIR.Size = New System.Drawing.Size(193, 33)
        Me.btnIR.TabIndex = 11
        Me.btnIR.Text = "Regular Schedule"
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
        Me.btnPTS.Location = New System.Drawing.Point(33, 1)
        Me.btnPTS.Name = "btnPTS"
        Me.btnPTS.Size = New System.Drawing.Size(193, 33)
        Me.btnPTS.TabIndex = 10
        Me.btnPTS.Text = "Transport Request"
        Me.btnPTS.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'formSelectorPTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 955)
        Me.Controls.Add(Me.pnlPTSSelect)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formSelectorPTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OPTIONS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPTSSelect As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIR As Button
    Friend WithEvents btnPTS As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
