<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblRows = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCols = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblProcessing = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbrProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.butProcess = New System.Windows.Forms.ToolStripButton()
        Me.butSettings = New System.Windows.Forms.ToolStripButton()
        Me.butExit = New System.Windows.Forms.ToolStripButton()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.lsvFiles = New System.Windows.Forms.ListView()
        Me.ColName = New System.Windows.Forms.ColumnHeader()
        Me.ColPath = New System.Windows.Forms.ColumnHeader()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblRows, Me.lblCols, Me.lblProcessing, Me.pbrProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 556)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(901, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblRows
        '
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(38, 17)
        Me.lblRows.Text = "Rows:"
        '
        'lblCols
        '
        Me.lblCols.Name = "lblCols"
        Me.lblCols.Size = New System.Drawing.Size(58, 17)
        Me.lblCols.Text = "Columns:"
        '
        'lblProcessing
        '
        Me.lblProcessing.Name = "lblProcessing"
        Me.lblProcessing.Size = New System.Drawing.Size(64, 17)
        Me.lblProcessing.Text = "Processing"
        Me.lblProcessing.Visible = False
        '
        'pbrProgress
        '
        Me.pbrProgress.Name = "pbrProgress"
        Me.pbrProgress.Size = New System.Drawing.Size(100, 16)
        Me.pbrProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(901, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(90, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripMenuItem2.Text = "&About"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "&Info"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butProcess, Me.butSettings, Me.butExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(901, 38)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'butProcess
        '
        Me.butProcess.Enabled = False
        Me.butProcess.Image = CType(resources.GetObject("butProcess.Image"), System.Drawing.Image)
        Me.butProcess.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butProcess.Name = "butProcess"
        Me.butProcess.Size = New System.Drawing.Size(51, 35)
        Me.butProcess.Text = "Process"
        Me.butProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'butSettings
        '
        Me.butSettings.Image = CType(resources.GetObject("butSettings.Image"), System.Drawing.Image)
        Me.butSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butSettings.Name = "butSettings"
        Me.butSettings.Size = New System.Drawing.Size(53, 35)
        Me.butSettings.Text = "Settings"
        Me.butSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'butExit
        '
        Me.butExit.Image = CType(resources.GetObject("butExit.Image"), System.Drawing.Image)
        Me.butExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(30, 35)
        Me.butExit.Text = "Exit"
        Me.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgvData
        '
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 25
        Me.dgvData.Size = New System.Drawing.Size(669, 480)
        Me.dgvData.TabIndex = 4
        '
        'lsvFiles
        '
        Me.lsvFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColPath})
        Me.lsvFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvFiles.FullRowSelect = True
        Me.lsvFiles.GridLines = True
        Me.lsvFiles.Location = New System.Drawing.Point(0, 0)
        Me.lsvFiles.MultiSelect = False
        Me.lsvFiles.Name = "lsvFiles"
        Me.lsvFiles.Size = New System.Drawing.Size(204, 480)
        Me.lsvFiles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsvFiles.TabIndex = 5
        Me.lsvFiles.UseCompatibleStateImageBehavior = False
        Me.lsvFiles.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Name"
        Me.ColName.Width = 200
        '
        'ColPath
        '
        Me.ColPath.Text = "Path"
        Me.ColPath.Width = 200
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 62)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lsvFiles)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvData)
        Me.SplitContainer1.Size = New System.Drawing.Size(877, 480)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 578)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Eagle Report Tool (Rapid) - Surangel And Sons,Co."
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblRows As ToolStripStatusLabel
    Friend WithEvents lblCols As ToolStripStatusLabel
    Friend WithEvents pbrProgress As ToolStripProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents butProcess As ToolStripButton
    Friend WithEvents butSettings As ToolStripButton
    Friend WithEvents butExit As ToolStripButton
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblProcessing As ToolStripStatusLabel
    Friend WithEvents lsvFiles As ListView
    Friend WithEvents ColName As ColumnHeader
    Friend WithEvents ColPath As ColumnHeader
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
End Class
