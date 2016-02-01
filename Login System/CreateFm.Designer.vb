<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateFm))
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.UsernameTb = New System.Windows.Forms.TextBox()
        Me.PasswordLb = New System.Windows.Forms.Label()
        Me.UsernameLb = New System.Windows.Forms.Label()
        Me.CloseBt = New System.Windows.Forms.Button()
        Me.CreateBt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PasswordTb
        '
        Me.PasswordTb.Location = New System.Drawing.Point(89, 43)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(208, 20)
        Me.PasswordTb.TabIndex = 13
        '
        'UsernameTb
        '
        Me.UsernameTb.Location = New System.Drawing.Point(89, 16)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(208, 20)
        Me.UsernameTb.TabIndex = 12
        '
        'PasswordLb
        '
        Me.PasswordLb.AutoSize = True
        Me.PasswordLb.Location = New System.Drawing.Point(17, 50)
        Me.PasswordLb.Name = "PasswordLb"
        Me.PasswordLb.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLb.TabIndex = 10
        Me.PasswordLb.Text = "Password"
        '
        'UsernameLb
        '
        Me.UsernameLb.AutoSize = True
        Me.UsernameLb.Location = New System.Drawing.Point(15, 19)
        Me.UsernameLb.Name = "UsernameLb"
        Me.UsernameLb.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLb.TabIndex = 9
        Me.UsernameLb.Text = "Username"
        '
        'CloseBt
        '
        Me.CloseBt.Location = New System.Drawing.Point(222, 77)
        Me.CloseBt.Name = "CloseBt"
        Me.CloseBt.Size = New System.Drawing.Size(75, 23)
        Me.CloseBt.TabIndex = 8
        Me.CloseBt.Text = "Close"
        Me.CloseBt.UseVisualStyleBackColor = True
        '
        'CreateBt
        '
        Me.CreateBt.Location = New System.Drawing.Point(130, 77)
        Me.CreateBt.Name = "CreateBt"
        Me.CreateBt.Size = New System.Drawing.Size(75, 23)
        Me.CreateBt.TabIndex = 7
        Me.CreateBt.Text = "Create"
        Me.CreateBt.UseVisualStyleBackColor = True
        '
        'CreateFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(324, 115)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.PasswordLb)
        Me.Controls.Add(Me.UsernameLb)
        Me.Controls.Add(Me.CloseBt)
        Me.Controls.Add(Me.CreateBt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateFm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents PasswordLb As Label
    Friend WithEvents UsernameLb As Label
    Friend WithEvents CloseBt As Button
    Friend WithEvents CreateBt As Button
End Class
