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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtX = New System.Windows.Forms.TextBox()
        Me.TxtN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSin = New System.Windows.Forms.TextBox()
        Me.TxtCos = New System.Windows.Forms.TextBox()
        Me.TxtE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAproxSin = New System.Windows.Forms.TextBox()
        Me.TxtAproxCos = New System.Windows.Forms.TextBox()
        Me.TxtAproxE = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "n:"
        '
        'TxtX
        '
        Me.TxtX.Location = New System.Drawing.Point(121, 39)
        Me.TxtX.Name = "TxtX"
        Me.TxtX.Size = New System.Drawing.Size(100, 22)
        Me.TxtX.TabIndex = 2
        '
        'TxtN
        '
        Me.TxtN.Location = New System.Drawing.Point(121, 81)
        Me.TxtN.Name = "TxtN"
        Me.TxtN.Size = New System.Drawing.Size(100, 22)
        Me.TxtN.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "sin(x)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "cos(x)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "e(x)"
        '
        'TxtSin
        '
        Me.TxtSin.Location = New System.Drawing.Point(121, 177)
        Me.TxtSin.Name = "TxtSin"
        Me.TxtSin.Size = New System.Drawing.Size(162, 22)
        Me.TxtSin.TabIndex = 7
        '
        'TxtCos
        '
        Me.TxtCos.Location = New System.Drawing.Point(121, 223)
        Me.TxtCos.Name = "TxtCos"
        Me.TxtCos.Size = New System.Drawing.Size(162, 22)
        Me.TxtCos.TabIndex = 8
        '
        'TxtE
        '
        Me.TxtE.Location = New System.Drawing.Point(121, 263)
        Me.TxtE.Name = "TxtE"
        Me.TxtE.Size = New System.Drawing.Size(162, 22)
        Me.TxtE.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Aprox"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Aprox"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Aprox"
        '
        'TxtAproxSin
        '
        Me.TxtAproxSin.Location = New System.Drawing.Point(382, 180)
        Me.TxtAproxSin.Name = "TxtAproxSin"
        Me.TxtAproxSin.Size = New System.Drawing.Size(172, 22)
        Me.TxtAproxSin.TabIndex = 13
        '
        'TxtAproxCos
        '
        Me.TxtAproxCos.Location = New System.Drawing.Point(382, 222)
        Me.TxtAproxCos.Name = "TxtAproxCos"
        Me.TxtAproxCos.Size = New System.Drawing.Size(172, 22)
        Me.TxtAproxCos.TabIndex = 14
        '
        'TxtAproxE
        '
        Me.TxtAproxE.Location = New System.Drawing.Point(382, 268)
        Me.TxtAproxE.Name = "TxtAproxE"
        Me.TxtAproxE.Size = New System.Drawing.Size(172, 22)
        Me.TxtAproxE.TabIndex = 15
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(382, 21)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(122, 82)
        Me.BtnCalcular.TabIndex = 16
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(149, 134)
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(300, 22)
        Me.TxtMensaje.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 346)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtAproxE)
        Me.Controls.Add(Me.TxtAproxCos)
        Me.Controls.Add(Me.TxtAproxSin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtE)
        Me.Controls.Add(Me.TxtCos)
        Me.Controls.Add(Me.TxtSin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtN)
        Me.Controls.Add(Me.TxtX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtX As System.Windows.Forms.TextBox
    Friend WithEvents TxtN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSin As System.Windows.Forms.TextBox
    Friend WithEvents TxtCos As System.Windows.Forms.TextBox
    Friend WithEvents TxtE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtAproxSin As System.Windows.Forms.TextBox
    Friend WithEvents TxtAproxCos As System.Windows.Forms.TextBox
    Friend WithEvents TxtAproxE As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox

End Class
