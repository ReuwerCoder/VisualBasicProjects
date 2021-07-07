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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picFiveCents = New System.Windows.Forms.PictureBox()
        Me.picTenCents = New System.Windows.Forms.PictureBox()
        Me.picTwentyCents = New System.Windows.Forms.PictureBox()
        Me.picFiftyCents = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picFiveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTenCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwentyCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFiftyCents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the Coins"
        '
        'picFiveCents
        '
        Me.picFiveCents.Image = CType(resources.GetObject("picFiveCents.Image"), System.Drawing.Image)
        Me.picFiveCents.Location = New System.Drawing.Point(12, 37)
        Me.picFiveCents.Name = "picFiveCents"
        Me.picFiveCents.Size = New System.Drawing.Size(125, 181)
        Me.picFiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFiveCents.TabIndex = 1
        Me.picFiveCents.TabStop = False
        '
        'picTenCents
        '
        Me.picTenCents.Image = CType(resources.GetObject("picTenCents.Image"), System.Drawing.Image)
        Me.picTenCents.InitialImage = CType(resources.GetObject("picTenCents.InitialImage"), System.Drawing.Image)
        Me.picTenCents.Location = New System.Drawing.Point(235, 37)
        Me.picTenCents.Name = "picTenCents"
        Me.picTenCents.Size = New System.Drawing.Size(125, 181)
        Me.picTenCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTenCents.TabIndex = 2
        Me.picTenCents.TabStop = False
        '
        'picTwentyCents
        '
        Me.picTwentyCents.Image = CType(resources.GetObject("picTwentyCents.Image"), System.Drawing.Image)
        Me.picTwentyCents.Location = New System.Drawing.Point(12, 224)
        Me.picTwentyCents.Name = "picTwentyCents"
        Me.picTwentyCents.Size = New System.Drawing.Size(125, 181)
        Me.picTwentyCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTwentyCents.TabIndex = 3
        Me.picTwentyCents.TabStop = False
        '
        'picFiftyCents
        '
        Me.picFiftyCents.Image = CType(resources.GetObject("picFiftyCents.Image"), System.Drawing.Image)
        Me.picFiftyCents.Location = New System.Drawing.Point(235, 224)
        Me.picFiftyCents.Name = "picFiftyCents"
        Me.picFiftyCents.Size = New System.Drawing.Size(125, 181)
        Me.picFiftyCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFiftyCents.TabIndex = 4
        Me.picFiftyCents.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(179, 408)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(181, 38)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(141, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 503)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picFiftyCents)
        Me.Controls.Add(Me.picTwentyCents)
        Me.Controls.Add(Me.picTenCents)
        Me.Controls.Add(Me.picFiveCents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Change Counter"
        CType(Me.picFiveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTenCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwentyCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFiftyCents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picFiveCents As PictureBox
    Friend WithEvents picTenCents As PictureBox
    Friend WithEvents picTwentyCents As PictureBox
    Friend WithEvents picFiftyCents As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
End Class
