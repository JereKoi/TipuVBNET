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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnAddTipu = New System.Windows.Forms.Button()
        Me.btnUpdateList = New System.Windows.Forms.Button()
        Me.dtpHatch = New System.Windows.Forms.DateTimePicker()
        Me.dgvTiput = New System.Windows.Forms.DataGridView()
        Me.lblName_Label = New System.Windows.Forms.Label()
        Me.lblTipu_color = New System.Windows.Forms.Label()
        Me.lblAddTipu = New System.Windows.Forms.Label()
        Me.lblUpdateList = New System.Windows.Forms.Label()
        CType(Me.dgvTiput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(198, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(405, 54)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 1
        '
        'btnAddTipu
        '
        Me.btnAddTipu.Location = New System.Drawing.Point(198, 120)
        Me.btnAddTipu.Name = "btnAddTipu"
        Me.btnAddTipu.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTipu.TabIndex = 2
        Me.btnAddTipu.Text = "btnAddTipu"
        Me.btnAddTipu.UseVisualStyleBackColor = True
        '
        'btnUpdateList
        '
        Me.btnUpdateList.Location = New System.Drawing.Point(366, 120)
        Me.btnUpdateList.Name = "btnUpdateList"
        Me.btnUpdateList.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateList.TabIndex = 3
        Me.btnUpdateList.Text = "btnUpdateList"
        Me.btnUpdateList.UseVisualStyleBackColor = True
        '
        'dtpHatch
        '
        Me.dtpHatch.Location = New System.Drawing.Point(198, 94)
        Me.dtpHatch.Name = "dtpHatch"
        Me.dtpHatch.Size = New System.Drawing.Size(200, 20)
        Me.dtpHatch.TabIndex = 4
        '
        'dgvTiput
        '
        Me.dgvTiput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiput.Location = New System.Drawing.Point(12, 162)
        Me.dgvTiput.Name = "dgvTiput"
        Me.dgvTiput.Size = New System.Drawing.Size(776, 254)
        Me.dgvTiput.TabIndex = 5
        '
        'lblName_Label
        '
        Me.lblName_Label.AutoSize = True
        Me.lblName_Label.Location = New System.Drawing.Point(317, 54)
        Me.lblName_Label.Name = "lblName_Label"
        Me.lblName_Label.Size = New System.Drawing.Size(59, 13)
        Me.lblName_Label.TabIndex = 6
        Me.lblName_Label.Text = "Tipu Name"
        '
        'lblTipu_color
        '
        Me.lblTipu_color.AutoSize = True
        Me.lblTipu_color.Location = New System.Drawing.Point(524, 57)
        Me.lblTipu_color.Name = "lblTipu_color"
        Me.lblTipu_color.Size = New System.Drawing.Size(55, 13)
        Me.lblTipu_color.TabIndex = 7
        Me.lblTipu_color.Text = "Tipu Color"
        '
        'lblAddTipu
        '
        Me.lblAddTipu.AutoSize = True
        Me.lblAddTipu.Location = New System.Drawing.Point(290, 125)
        Me.lblAddTipu.Name = "lblAddTipu"
        Me.lblAddTipu.Size = New System.Drawing.Size(50, 13)
        Me.lblAddTipu.TabIndex = 8
        Me.lblAddTipu.Text = "Add Tipu"
        '
        'lblUpdateList
        '
        Me.lblUpdateList.AutoSize = True
        Me.lblUpdateList.Location = New System.Drawing.Point(458, 125)
        Me.lblUpdateList.Name = "lblUpdateList"
        Me.lblUpdateList.Size = New System.Drawing.Size(61, 13)
        Me.lblUpdateList.TabIndex = 9
        Me.lblUpdateList.Text = "Update List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblUpdateList)
        Me.Controls.Add(Me.lblAddTipu)
        Me.Controls.Add(Me.lblTipu_color)
        Me.Controls.Add(Me.lblName_Label)
        Me.Controls.Add(Me.dgvTiput)
        Me.Controls.Add(Me.dtpHatch)
        Me.Controls.Add(Me.btnUpdateList)
        Me.Controls.Add(Me.btnAddTipu)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvTiput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents btnAddTipu As Button
    Friend WithEvents btnUpdateList As Button
    Friend WithEvents dtpHatch As DateTimePicker
    Friend WithEvents dgvTiput As DataGridView
    Friend WithEvents lblName_Label As Label
    Friend WithEvents lblTipu_color As Label
    Friend WithEvents lblAddTipu As Label
    Friend WithEvents lblUpdateList As Label
End Class
