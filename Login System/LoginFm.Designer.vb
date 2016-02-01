<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFm))
        Me.LoginBt = New System.Windows.Forms.Button()
        Me.CloseBt = New System.Windows.Forms.Button()
        Me.UsernameLb = New System.Windows.Forms.Label()
        Me.PasswordLb = New System.Windows.Forms.Label()
        Me.CreateLL = New System.Windows.Forms.LinkLabel()
        Me.UsernameTb = New System.Windows.Forms.TextBox()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LoginBt
        '
        Me.LoginBt.Location = New System.Drawing.Point(130, 77)
        Me.LoginBt.Name = "LoginBt"
        Me.LoginBt.Size = New System.Drawing.Size(75, 23)
        Me.LoginBt.TabIndex = 0
        Me.LoginBt.Text = "Login"
        Me.LoginBt.UseVisualStyleBackColor = True
        '
        'CloseBt
        '
        Me.CloseBt.Location = New System.Drawing.Point(222, 77)
        Me.CloseBt.Name = "CloseBt"
        Me.CloseBt.Size = New System.Drawing.Size(75, 23)
        Me.CloseBt.TabIndex = 1
        Me.CloseBt.Text = "Close"
        Me.CloseBt.UseVisualStyleBackColor = True
        '
        'UsernameLb
        '
        Me.UsernameLb.AutoSize = True
        Me.UsernameLb.Location = New System.Drawing.Point(15, 19)
        Me.UsernameLb.Name = "UsernameLb"
        Me.UsernameLb.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLb.TabIndex = 2
        Me.UsernameLb.Text = "Username"
        '
        'PasswordLb
        '
        Me.PasswordLb.AutoSize = True
        Me.PasswordLb.Location = New System.Drawing.Point(17, 50)
        Me.PasswordLb.Name = "PasswordLb"
        Me.PasswordLb.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLb.TabIndex = 3
        Me.PasswordLb.Text = "Password"
        '
        'CreateLL
        '
        Me.CreateLL.AutoSize = True
        Me.CreateLL.Location = New System.Drawing.Point(15, 82)
        Me.CreateLL.Name = "CreateLL"
        Me.CreateLL.Size = New System.Drawing.Size(81, 13)
        Me.CreateLL.TabIndex = 4
        Me.CreateLL.TabStop = True
        Me.CreateLL.Text = "Create Account"
        '
        'UsernameTb
        '
        Me.UsernameTb.Location = New System.Drawing.Point(89, 16)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(208, 20)
        Me.UsernameTb.TabIndex = 5
        '
        'PasswordTb
        '
        Me.PasswordTb.Location = New System.Drawing.Point(89, 43)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTb.Size = New System.Drawing.Size(208, 20)
        Me.PasswordTb.TabIndex = 6
        '
        'LoginFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(324, 115)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.CreateLL)
        Me.Controls.Add(Me.PasswordLb)
        Me.Controls.Add(Me.UsernameLb)
        Me.Controls.Add(Me.CloseBt)
        Me.Controls.Add(Me.LoginBt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginFm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBt As Button
    Friend WithEvents CloseBt As Button
    Friend WithEvents UsernameLb As Label
    Friend WithEvents PasswordLb As Label
    Friend WithEvents CreateLL As LinkLabel
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents PasswordTb As TextBox
End Class
