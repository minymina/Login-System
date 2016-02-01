<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeFm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeFm))
        Me.WelcomeLb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WelcomeLb
        '
        Me.WelcomeLb.AutoSize = True
        Me.WelcomeLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLb.Location = New System.Drawing.Point(74, 38)
        Me.WelcomeLb.Name = "WelcomeLb"
        Me.WelcomeLb.Size = New System.Drawing.Size(183, 42)
        Me.WelcomeLb.TabIndex = 0
        Me.WelcomeLb.Text = "Welcome!"
        '
        'WelcomeFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(324, 115)
        Me.Controls.Add(Me.WelcomeLb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WelcomeFm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WelcomeLb As Label
End Class
