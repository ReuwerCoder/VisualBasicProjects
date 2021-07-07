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
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRetailprice = New System.Windows.Forms.Label()
        Me.txtwholesalecost = New System.Windows.Forms.TextBox()
        Me.txtmarkup = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(74, 236)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(139, 63)
        Me.btnGetRetail.TabIndex = 0
        Me.btnGetRetail.Text = "Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 63)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wholesale Cost of Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Markup %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Retail Price"
        '
        'lblRetailprice
        '
        Me.lblRetailprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailprice.Location = New System.Drawing.Point(254, 150)
        Me.lblRetailprice.Name = "lblRetailprice"
        Me.lblRetailprice.Size = New System.Drawing.Size(100, 23)
        Me.lblRetailprice.TabIndex = 5
        '
        'txtwholesalecost
        '
        Me.txtwholesalecost.Location = New System.Drawing.Point(257, 37)
        Me.txtwholesalecost.Name = "txtwholesalecost"
        Me.txtwholesalecost.Size = New System.Drawing.Size(100, 22)
        Me.txtwholesalecost.TabIndex = 6
        '
        'txtmarkup
        '
        Me.txtmarkup.Location = New System.Drawing.Point(257, 86)
        Me.txtmarkup.Name = "txtmarkup"
        Me.txtmarkup.Size = New System.Drawing.Size(100, 22)
        Me.txtmarkup.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 311)
        Me.Controls.Add(Me.txtmarkup)
        Me.Controls.Add(Me.txtwholesalecost)
        Me.Controls.Add(Me.lblRetailprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetRetail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRetailprice As Label
    Friend WithEvents txtwholesalecost As TextBox
    Friend WithEvents txtmarkup As TextBox
End Class
