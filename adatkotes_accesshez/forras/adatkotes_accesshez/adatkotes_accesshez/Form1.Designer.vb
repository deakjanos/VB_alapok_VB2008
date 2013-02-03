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
        Me.components = New System.ComponentModel.Container
        Dim NévLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AdatokBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.AdatokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Proba_adatbazisDataSet = New adatkotes_accesshez.proba_adatbazisDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AdatokBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.AdatokDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Befizetések_lekérdezéseDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Befizetések_lekérdezéseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lekérdezés_név_szerintDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lekérdezés_név_szerintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AdatokTableAdapter = New adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.AdatokTableAdapter
        Me.TableAdapterManager = New adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.TableAdapterManager
        Me.Befizetések_lekérdezéseTableAdapter = New adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.Befizetések_lekérdezéseTableAdapter
        Me.Lekérdezés_név_szerintTableAdapter = New adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.Lekérdezés_név_szerintTableAdapter
        Me.NévTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        NévLabel = New System.Windows.Forms.Label
        CType(Me.AdatokBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdatokBindingNavigator.SuspendLayout()
        CType(Me.AdatokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proba_adatbazisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdatokDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Befizetések_lekérdezéseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Befizetések_lekérdezéseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lekérdezés_név_szerintDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lekérdezés_név_szerintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NévLabel
        '
        NévLabel.AutoSize = True
        NévLabel.Location = New System.Drawing.Point(363, 130)
        NévLabel.Name = "NévLabel"
        NévLabel.Size = New System.Drawing.Size(30, 13)
        NévLabel.TabIndex = 5
        NévLabel.Text = "Név:"
        '
        'AdatokBindingNavigator
        '
        Me.AdatokBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdatokBindingNavigator.BindingSource = Me.AdatokBindingSource
        Me.AdatokBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdatokBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdatokBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdatokBindingNavigatorSaveItem})
        Me.AdatokBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdatokBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdatokBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdatokBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdatokBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdatokBindingNavigator.Name = "AdatokBindingNavigator"
        Me.AdatokBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdatokBindingNavigator.Size = New System.Drawing.Size(553, 25)
        Me.AdatokBindingNavigator.TabIndex = 0
        Me.AdatokBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'AdatokBindingSource
        '
        Me.AdatokBindingSource.DataMember = "Adatok"
        Me.AdatokBindingSource.DataSource = Me.Proba_adatbazisDataSet
        '
        'Proba_adatbazisDataSet
        '
        Me.Proba_adatbazisDataSet.DataSetName = "proba_adatbazisDataSet"
        Me.Proba_adatbazisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AdatokBindingNavigatorSaveItem
        '
        Me.AdatokBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdatokBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdatokBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdatokBindingNavigatorSaveItem.Name = "AdatokBindingNavigatorSaveItem"
        Me.AdatokBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdatokBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AdatokDataGridView
        '
        Me.AdatokDataGridView.AutoGenerateColumns = False
        Me.AdatokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdatokDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AdatokDataGridView.DataSource = Me.AdatokBindingSource
        Me.AdatokDataGridView.Location = New System.Drawing.Point(57, 54)
        Me.AdatokDataGridView.Name = "AdatokDataGridView"
        Me.AdatokDataGridView.Size = New System.Drawing.Size(442, 67)
        Me.AdatokDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "azonosító"
        Me.DataGridViewTextBoxColumn1.HeaderText = "azonosító"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Név"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Név"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cím"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cím"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Befizetések_lekérdezéseDataGridView
        '
        Me.Befizetések_lekérdezéseDataGridView.AutoGenerateColumns = False
        Me.Befizetések_lekérdezéseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Befizetések_lekérdezéseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Befizetések_lekérdezéseDataGridView.DataSource = Me.Befizetések_lekérdezéseBindingSource
        Me.Befizetések_lekérdezéseDataGridView.Location = New System.Drawing.Point(12, 162)
        Me.Befizetések_lekérdezéseDataGridView.Name = "Befizetések_lekérdezéseDataGridView"
        Me.Befizetések_lekérdezéseDataGridView.Size = New System.Drawing.Size(245, 117)
        Me.Befizetések_lekérdezéseDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Név"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Név"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "állapot"
        Me.DataGridViewTextBoxColumn6.HeaderText = "állapot"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Befizetések_lekérdezéseBindingSource
        '
        Me.Befizetések_lekérdezéseBindingSource.DataMember = "Befizetések lekérdezése"
        Me.Befizetések_lekérdezéseBindingSource.DataSource = Me.Proba_adatbazisDataSet
        '
        'Lekérdezés_név_szerintDataGridView
        '
        Me.Lekérdezés_név_szerintDataGridView.AutoGenerateColumns = False
        Me.Lekérdezés_név_szerintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lekérdezés_név_szerintDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Lekérdezés_név_szerintDataGridView.DataSource = Me.Lekérdezés_név_szerintBindingSource
        Me.Lekérdezés_név_szerintDataGridView.Location = New System.Drawing.Point(289, 162)
        Me.Lekérdezés_név_szerintDataGridView.Name = "Lekérdezés_név_szerintDataGridView"
        Me.Lekérdezés_név_szerintDataGridView.Size = New System.Drawing.Size(242, 117)
        Me.Lekérdezés_név_szerintDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Név"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Név"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "állapot"
        Me.DataGridViewTextBoxColumn8.HeaderText = "állapot"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Lekérdezés_név_szerintBindingSource
        '
        Me.Lekérdezés_név_szerintBindingSource.DataMember = "Lekérdezés név szerint"
        Me.Lekérdezés_név_szerintBindingSource.DataSource = Me.Proba_adatbazisDataSet
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(553, 25)
        Me.FillByToolStrip.TabIndex = 5
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'AdatokTableAdapter
        '
        Me.AdatokTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdatokTableAdapter = Me.AdatokTableAdapter
        Me.TableAdapterManager.állapotTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Befizetések_lekérdezéseTableAdapter
        '
        Me.Befizetések_lekérdezéseTableAdapter.ClearBeforeFill = True
        '
        'Lekérdezés_név_szerintTableAdapter
        '
        Me.Lekérdezés_név_szerintTableAdapter.ClearBeforeFill = True
        '
        'NévTextBox
        '
        Me.NévTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdatokBindingSource, "Név", True))
        Me.NévTextBox.Location = New System.Drawing.Point(399, 127)
        Me.NévTextBox.Name = "NévTextBox"
        Me.NévTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NévTextBox.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 127)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 319)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(NévLabel)
        Me.Controls.Add(Me.NévTextBox)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Lekérdezés_név_szerintDataGridView)
        Me.Controls.Add(Me.Befizetések_lekérdezéseDataGridView)
        Me.Controls.Add(Me.AdatokDataGridView)
        Me.Controls.Add(Me.AdatokBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AdatokBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdatokBindingNavigator.ResumeLayout(False)
        Me.AdatokBindingNavigator.PerformLayout()
        CType(Me.AdatokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proba_adatbazisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdatokDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Befizetések_lekérdezéseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Befizetések_lekérdezéseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lekérdezés_név_szerintDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lekérdezés_név_szerintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Proba_adatbazisDataSet As adatkotes_accesshez.proba_adatbazisDataSet
    Friend WithEvents AdatokBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdatokTableAdapter As adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.AdatokTableAdapter
    Friend WithEvents TableAdapterManager As adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdatokBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdatokBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdatokDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Befizetések_lekérdezéseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Befizetések_lekérdezéseTableAdapter As adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.Befizetések_lekérdezéseTableAdapter
    Friend WithEvents Befizetések_lekérdezéseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lekérdezés_név_szerintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lekérdezés_név_szerintTableAdapter As adatkotes_accesshez.proba_adatbazisDataSetTableAdapters.Lekérdezés_név_szerintTableAdapter
    Friend WithEvents Lekérdezés_név_szerintDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NévTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
