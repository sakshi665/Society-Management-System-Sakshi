<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SocietyDataSet = New pro2.societyDataSet()
        Me.SellhouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellhouseTableAdapter = New pro2.societyDataSetTableAdapters.sellhouseTableAdapter()
        Me.SocietyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SocietyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellhouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 72)
        Me.Panel2.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label3.Location = New System.Drawing.Point(43, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "E - SOCIETY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Tomato
        Me.Label7.Location = New System.Drawing.Point(263, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 36)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "ON  SELL  HOUSES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(758, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MistyRose
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SocietyNameDataGridViewTextBoxColumn, Me.BlockNoDataGridViewTextBoxColumn, Me.HouseNoDataGridViewTextBoxColumn, Me.HouseTypeDataGridViewTextBoxColumn, Me.OwnernameDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SellhouseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(75, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(717, 308)
        Me.DataGridView1.TabIndex = 59
        '
        'SocietyDataSet
        '
        Me.SocietyDataSet.DataSetName = "societyDataSet"
        Me.SocietyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SellhouseBindingSource
        '
        Me.SellhouseBindingSource.DataMember = "sellhouse"
        Me.SellhouseBindingSource.DataSource = Me.SocietyDataSet
        '
        'SellhouseTableAdapter
        '
        Me.SellhouseTableAdapter.ClearBeforeFill = True
        '
        'SocietyNameDataGridViewTextBoxColumn
        '
        Me.SocietyNameDataGridViewTextBoxColumn.DataPropertyName = "societyName"
        Me.SocietyNameDataGridViewTextBoxColumn.HeaderText = "societyName"
        Me.SocietyNameDataGridViewTextBoxColumn.Name = "SocietyNameDataGridViewTextBoxColumn"
        '
        'BlockNoDataGridViewTextBoxColumn
        '
        Me.BlockNoDataGridViewTextBoxColumn.DataPropertyName = "blockNo"
        Me.BlockNoDataGridViewTextBoxColumn.HeaderText = "blockNo"
        Me.BlockNoDataGridViewTextBoxColumn.Name = "BlockNoDataGridViewTextBoxColumn"
        '
        'HouseNoDataGridViewTextBoxColumn
        '
        Me.HouseNoDataGridViewTextBoxColumn.DataPropertyName = "houseNo"
        Me.HouseNoDataGridViewTextBoxColumn.HeaderText = "houseNo"
        Me.HouseNoDataGridViewTextBoxColumn.Name = "HouseNoDataGridViewTextBoxColumn"
        '
        'HouseTypeDataGridViewTextBoxColumn
        '
        Me.HouseTypeDataGridViewTextBoxColumn.DataPropertyName = "houseType"
        Me.HouseTypeDataGridViewTextBoxColumn.HeaderText = "houseType"
        Me.HouseTypeDataGridViewTextBoxColumn.Name = "HouseTypeDataGridViewTextBoxColumn"
        '
        'OwnernameDataGridViewTextBoxColumn
        '
        Me.OwnernameDataGridViewTextBoxColumn.DataPropertyName = "ownername"
        Me.OwnernameDataGridViewTextBoxColumn.HeaderText = "ownername"
        Me.OwnernameDataGridViewTextBoxColumn.Name = "OwnernameDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "contactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "contactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(871, 523)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SocietyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellhouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SocietyDataSet As societyDataSet
    Friend WithEvents SellhouseBindingSource As BindingSource
    Friend WithEvents SellhouseTableAdapter As societyDataSetTableAdapters.sellhouseTableAdapter
    Friend WithEvents SocietyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlockNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OwnernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
