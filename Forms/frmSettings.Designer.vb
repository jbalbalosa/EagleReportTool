<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCol2 = New System.Windows.Forms.TextBox()
        Me.txtCol1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZoom = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbOrientation = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.butlose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCol2)
        Me.GroupBox1.Controls.Add(Me.txtCol1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Area"
        '
        'txtCol2
        '
        Me.txtCol2.Location = New System.Drawing.Point(91, 61)
        Me.txtCol2.Name = "txtCol2"
        Me.txtCol2.Size = New System.Drawing.Size(59, 23)
        Me.txtCol2.TabIndex = 3
        Me.txtCol2.Text = "AA"
        '
        'txtCol1
        '
        Me.txtCol1.Location = New System.Drawing.Point(91, 29)
        Me.txtCol1.Name = "txtCol1"
        Me.txtCol1.Size = New System.Drawing.Size(59, 23)
        Me.txtCol1.TabIndex = 2
        Me.txtCol1.Text = "B"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Column 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Column 1"
        '
        'txtZoom
        '
        Me.txtZoom.Location = New System.Drawing.Point(91, 22)
        Me.txtZoom.Name = "txtZoom"
        Me.txtZoom.Size = New System.Drawing.Size(59, 23)
        Me.txtZoom.TabIndex = 3
        Me.txtZoom.Text = "90"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtZoom)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 107)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zoom %"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.cmbOrientation)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 107)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Page Orientation/Type"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Legal", "Letter"})
        Me.cmbType.Location = New System.Drawing.Point(21, 64)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(140, 23)
        Me.cmbType.TabIndex = 1
        '
        'cmbOrientation
        '
        Me.cmbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrientation.FormattingEnabled = True
        Me.cmbOrientation.Items.AddRange(New Object() {"Landscape", "Portrait"})
        Me.cmbOrientation.Location = New System.Drawing.Point(21, 22)
        Me.cmbOrientation.Name = "cmbOrientation"
        Me.cmbOrientation.Size = New System.Drawing.Size(140, 23)
        Me.cmbOrientation.Sorted = True
        Me.cmbOrientation.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(212, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 142)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Worksheet"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(59, 23)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sort By"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(59, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "AW"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(59, 23)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "End Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Start Range"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(461, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'butlose
        '
        Me.butlose.Location = New System.Drawing.Point(374, 336)
        Me.butlose.Name = "butlose"
        Me.butlose.Size = New System.Drawing.Size(75, 23)
        Me.butlose.TabIndex = 8
        Me.butlose.Text = "Close"
        Me.butlose.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 391)
        Me.Controls.Add(Me.butlose)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCol2 As TextBox
    Friend WithEvents txtCol1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtZoom As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents cmbOrientation As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents butlose As Button
End Class
