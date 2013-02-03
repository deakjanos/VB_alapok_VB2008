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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim AzonostóLabel As System.Windows.Forms.Label
        Dim NévLabel As System.Windows.Forms.Label
        Dim CímLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Me.Proba_adatbazis_1DataSet = New adatkotes_1.proba_adatbazis_1DataSet
        Me.AdatokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdatokTableAdapter = New adatkotes_1.proba_adatbazis_1DataSetTableAdapters.AdatokTableAdapter
        Me.TableAdapterManager = New adatkotes_1.proba_adatbazis_1DataSetTableAdapters.TableAdapterManager
        Me.AdatokBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.AdatokBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.AzonostóTextBox = New System.Windows.Forms.TextBox
        Me.NévTextBox = New System.Windows.Forms.TextBox
        Me.CímTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        AzonostóLabel = New System.Windows.Forms.Label
        NévLabel = New System.Windows.Forms.Label
        CímLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        CType(Me.Proba_adatbazis_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdatokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdatokBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdatokBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Proba_adatbazis_1DataSet
        '
        Me.Proba_adatbazis_1DataSet.DataSetName = "proba_adatbazis_1DataSet"
        Me.Proba_adatbazis_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdatokBindingSource
        '
        Me.AdatokBindingSource.DataMember = "Adatok"
        Me.AdatokBindingSource.DataSource = Me.Proba_adatbazis_1DataSet
        '
        'AdatokTableAdapter
        '
        Me.AdatokTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdatokTableAdapter = Me.AdatokTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = adatkotes_1.proba_adatbazis_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.AdatokBindingNavigator.Size = New System.Drawing.Size(292, 25)
        Me.AdatokBindingNavigator.TabIndex = 0
        Me.AdatokBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AdatokBindingNavigatorSaveItem
        '
        Me.AdatokBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdatokBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdatokBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdatokBindingNavigatorSaveItem.Name = "AdatokBindingNavigatorSaveItem"
        Me.AdatokBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AdatokBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AzonostóLabel
        '
        AzonostóLabel.AutoSize = True
        AzonostóLabel.Location = New System.Drawing.Point(29, 111)
        AzonostóLabel.Name = "AzonostóLabel"
        AzonostóLabel.Size = New System.Drawing.Size(53, 13)
        AzonostóLabel.TabIndex = 1
        AzonostóLabel.Text = "azonostó:"
        '
        'AzonostóTextBox
        '
        Me.AzonostóTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdatokBindingSource, "azonostó", True))
        Me.AzonostóTextBox.Location = New System.Drawing.Point(88, 108)
        Me.AzonostóTextBox.Name = "AzonostóTextBox"
        Me.AzonostóTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AzonostóTextBox.TabIndex = 2
        '
        'NévLabel
        '
        NévLabel.AutoSize = True
        NévLabel.Location = New System.Drawing.Point(52, 137)
        NévLabel.Name = "NévLabel"
        NévLabel.Size = New System.Drawing.Size(30, 13)
        NévLabel.TabIndex = 3
        NévLabel.Text = "Név:"
        '
        'NévTextBox
        '
        Me.NévTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdatokBindingSource, "Név", True))
        Me.NévTextBox.Location = New System.Drawing.Point(88, 134)
        Me.NévTextBox.Name = "NévTextBox"
        Me.NévTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NévTextBox.TabIndex = 4
        '
        'CímLabel
        '
        CímLabel.AutoSize = True
        CímLabel.Location = New System.Drawing.Point(54, 163)
        CímLabel.Name = "CímLabel"
        CímLabel.Size = New System.Drawing.Size(28, 13)
        CímLabel.TabIndex = 5
        CímLabel.Text = "cím:"
        '
        'CímTextBox
        '
        Me.CímTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdatokBindingSource, "cím", True))
        Me.CímTextBox.Location = New System.Drawing.Point(88, 160)
        Me.CímTextBox.Name = "CímTextBox"
        Me.CímTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CímTextBox.TabIndex = 6
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(36, 189)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 7
        TelefonLabel.Text = "Telefon:"
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdatokBindingSource, "Telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(88, 186)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(CímLabel)
        Me.Controls.Add(Me.CímTextBox)
        Me.Controls.Add(NévLabel)
        Me.Controls.Add(Me.NévTextBox)
        Me.Controls.Add(AzonostóLabel)
        Me.Controls.Add(Me.AzonostóTextBox)
        Me.Controls.Add(Me.AdatokBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Proba_adatbazis_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdatokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdatokBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdatokBindingNavigator.ResumeLayout(False)
        Me.AdatokBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Proba_adatbazis_1DataSet As adatkotes_1.proba_adatbazis_1DataSet
    Friend WithEvents AdatokBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdatokTableAdapter As adatkotes_1.proba_adatbazis_1DataSetTableAdapters.AdatokTableAdapter
    Friend WithEvents TableAdapterManager As adatkotes_1.proba_adatbazis_1DataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents AzonostóTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NévTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CímTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox

End Class
