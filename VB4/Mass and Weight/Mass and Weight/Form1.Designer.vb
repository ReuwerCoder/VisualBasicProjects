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
        Me.lblMassOO = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblWeightResult = New System.Windows.Forms.Label()
        Me.txtboxInput = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMassOO
        '
        Me.lblMassOO.AutoSize = True
        Me.lblMassOO.Location = New System.Drawing.Point(56, 50)
        Me.lblMassOO.Name = "lblMassOO"
        Me.lblMassOO.Size = New System.Drawing.Size(106, 17)
        Me.lblMassOO.TabIndex = 0
        Me.lblMassOO.Text = "Mass of Object:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(56, 115)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(56, 17)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Weight:"
        '
        'lblWeightResult
        '
        Me.lblWeightResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeightResult.Location = New System.Drawing.Point(168, 115)
        Me.lblWeightResult.Name = "lblWeightResult"
        Me.lblWeightResult.Size = New System.Drawing.Size(192, 23)
        Me.lblWeightResult.TabIndex = 2
        '
        'txtboxInput
        '
        Me.txtboxInput.Location = New System.Drawing.Point(168, 47)
        Me.txtboxInput.Name = "txtboxInput"
        Me.txtboxInput.Size = New System.Drawing.Size(192, 22)
        Me.txtboxInput.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(59, 194)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(247, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 234)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtboxInput)
        Me.Controls.Add(Me.lblWeightResult)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblMassOO)
        Me.Name = "Form1"
        Me.Text = "Mass and Weight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMassOO As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblWeightResult As Label
    Friend WithEvents txtboxInput As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
