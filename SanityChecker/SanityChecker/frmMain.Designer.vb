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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCrnSearch = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.STADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartTermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntgPartnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstructorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstrctorEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeBeginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeEndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BldgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfEngFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatingAvailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatingAssnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatingMAXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MytableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDataSet1 = New SanityChecker.masterDataSet()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New SanityChecker.sanityCheckerDataSetTableAdapters.TableAdapterManager()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MytableTableAdapter = New SanityChecker.masterDataSetTableAdapters.mytableTableAdapter()
        Me.DataTableAdapter1 = New SanityChecker.masterDataSetTableAdapters.DataTableAdapter()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MytableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 77)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(75, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(337, 74)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblCrnSearch
        '
        Me.lblCrnSearch.AutoSize = True
        Me.lblCrnSearch.Location = New System.Drawing.Point(12, 61)
        Me.lblCrnSearch.Name = "lblCrnSearch"
        Me.lblCrnSearch.Size = New System.Drawing.Size(67, 13)
        Me.lblCrnSearch.TabIndex = 6
        Me.lblCrnSearch.Text = "CRN Search"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(418, 74)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 7
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(15, 13)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgvDisplay
        '
        Me.dgvDisplay.AutoGenerateColumns = False
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STADataGridViewTextBoxColumn, Me.TermDataGridViewTextBoxColumn, Me.CRNDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.SecDataGridViewTextBoxColumn, Me.PartTermDataGridViewTextBoxColumn, Me.ScheduleDataGridViewTextBoxColumn, Me.InstMethodDataGridViewTextBoxColumn, Me.IntgPartnerDataGridViewTextBoxColumn, Me.CourseTitleDataGridViewTextBoxColumn, Me.InstructorDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.InstrctorEmailDataGridViewTextBoxColumn, Me.DaysDataGridViewTextBoxColumn, Me.Sec1DataGridViewTextBoxColumn, Me.TimeBeginDataGridViewTextBoxColumn, Me.TimeEndDataGridViewTextBoxColumn, Me.BldgDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.HrsDataGridViewTextBoxColumn, Me.FeesTypeDataGridViewTextBoxColumn, Me.FeesAmountDataGridViewTextBoxColumn, Me.ProfEngFeeDataGridViewTextBoxColumn, Me.ProfFeeDataGridViewTextBoxColumn, Me.EngFeeDataGridViewTextBoxColumn, Me.SeatingAvailDataGridViewTextBoxColumn, Me.SeatingAssnDataGridViewTextBoxColumn, Me.SeatingMAXDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn})
        Me.dgvDisplay.DataSource = Me.MytableBindingSource
        Me.dgvDisplay.Location = New System.Drawing.Point(12, 102)
        Me.dgvDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.RowTemplate.Height = 24
        Me.dgvDisplay.Size = New System.Drawing.Size(479, 187)
        Me.dgvDisplay.TabIndex = 9
        '
        'STADataGridViewTextBoxColumn
        '
        Me.STADataGridViewTextBoxColumn.DataPropertyName = "STA"
        Me.STADataGridViewTextBoxColumn.HeaderText = "STA"
        Me.STADataGridViewTextBoxColumn.Name = "STADataGridViewTextBoxColumn"
        '
        'TermDataGridViewTextBoxColumn
        '
        Me.TermDataGridViewTextBoxColumn.DataPropertyName = "Term"
        Me.TermDataGridViewTextBoxColumn.HeaderText = "Term"
        Me.TermDataGridViewTextBoxColumn.Name = "TermDataGridViewTextBoxColumn"
        '
        'CRNDataGridViewTextBoxColumn
        '
        Me.CRNDataGridViewTextBoxColumn.DataPropertyName = "CRN"
        Me.CRNDataGridViewTextBoxColumn.HeaderText = "CRN"
        Me.CRNDataGridViewTextBoxColumn.Name = "CRNDataGridViewTextBoxColumn"
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "College"
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'SecDataGridViewTextBoxColumn
        '
        Me.SecDataGridViewTextBoxColumn.DataPropertyName = "Sec"
        Me.SecDataGridViewTextBoxColumn.HeaderText = "Sec"
        Me.SecDataGridViewTextBoxColumn.Name = "SecDataGridViewTextBoxColumn"
        '
        'PartTermDataGridViewTextBoxColumn
        '
        Me.PartTermDataGridViewTextBoxColumn.DataPropertyName = "Part Term"
        Me.PartTermDataGridViewTextBoxColumn.HeaderText = "Part Term"
        Me.PartTermDataGridViewTextBoxColumn.Name = "PartTermDataGridViewTextBoxColumn"
        '
        'ScheduleDataGridViewTextBoxColumn
        '
        Me.ScheduleDataGridViewTextBoxColumn.DataPropertyName = "Schedule"
        Me.ScheduleDataGridViewTextBoxColumn.HeaderText = "Schedule"
        Me.ScheduleDataGridViewTextBoxColumn.Name = "ScheduleDataGridViewTextBoxColumn"
        '
        'InstMethodDataGridViewTextBoxColumn
        '
        Me.InstMethodDataGridViewTextBoxColumn.DataPropertyName = "Inst Method"
        Me.InstMethodDataGridViewTextBoxColumn.HeaderText = "Inst Method"
        Me.InstMethodDataGridViewTextBoxColumn.Name = "InstMethodDataGridViewTextBoxColumn"
        '
        'IntgPartnerDataGridViewTextBoxColumn
        '
        Me.IntgPartnerDataGridViewTextBoxColumn.DataPropertyName = "Intg Partner"
        Me.IntgPartnerDataGridViewTextBoxColumn.HeaderText = "Intg Partner"
        Me.IntgPartnerDataGridViewTextBoxColumn.Name = "IntgPartnerDataGridViewTextBoxColumn"
        '
        'CourseTitleDataGridViewTextBoxColumn
        '
        Me.CourseTitleDataGridViewTextBoxColumn.DataPropertyName = "Course Title"
        Me.CourseTitleDataGridViewTextBoxColumn.HeaderText = "Course Title"
        Me.CourseTitleDataGridViewTextBoxColumn.Name = "CourseTitleDataGridViewTextBoxColumn"
        '
        'InstructorDataGridViewTextBoxColumn
        '
        Me.InstructorDataGridViewTextBoxColumn.DataPropertyName = "Instructor"
        Me.InstructorDataGridViewTextBoxColumn.HeaderText = "Instructor"
        Me.InstructorDataGridViewTextBoxColumn.Name = "InstructorDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'InstrctorEmailDataGridViewTextBoxColumn
        '
        Me.InstrctorEmailDataGridViewTextBoxColumn.DataPropertyName = "Instrctor Email"
        Me.InstrctorEmailDataGridViewTextBoxColumn.HeaderText = "Instrctor Email"
        Me.InstrctorEmailDataGridViewTextBoxColumn.Name = "InstrctorEmailDataGridViewTextBoxColumn"
        '
        'DaysDataGridViewTextBoxColumn
        '
        Me.DaysDataGridViewTextBoxColumn.DataPropertyName = "Days"
        Me.DaysDataGridViewTextBoxColumn.HeaderText = "Days"
        Me.DaysDataGridViewTextBoxColumn.Name = "DaysDataGridViewTextBoxColumn"
        '
        'Sec1DataGridViewTextBoxColumn
        '
        Me.Sec1DataGridViewTextBoxColumn.DataPropertyName = "Sec1"
        Me.Sec1DataGridViewTextBoxColumn.HeaderText = "Sec1"
        Me.Sec1DataGridViewTextBoxColumn.Name = "Sec1DataGridViewTextBoxColumn"
        '
        'TimeBeginDataGridViewTextBoxColumn
        '
        Me.TimeBeginDataGridViewTextBoxColumn.DataPropertyName = "Time_Begin"
        Me.TimeBeginDataGridViewTextBoxColumn.HeaderText = "Time_Begin"
        Me.TimeBeginDataGridViewTextBoxColumn.Name = "TimeBeginDataGridViewTextBoxColumn"
        '
        'TimeEndDataGridViewTextBoxColumn
        '
        Me.TimeEndDataGridViewTextBoxColumn.DataPropertyName = "Time_End"
        Me.TimeEndDataGridViewTextBoxColumn.HeaderText = "Time_End"
        Me.TimeEndDataGridViewTextBoxColumn.Name = "TimeEndDataGridViewTextBoxColumn"
        '
        'BldgDataGridViewTextBoxColumn
        '
        Me.BldgDataGridViewTextBoxColumn.DataPropertyName = "Bldg"
        Me.BldgDataGridViewTextBoxColumn.HeaderText = "Bldg"
        Me.BldgDataGridViewTextBoxColumn.Name = "BldgDataGridViewTextBoxColumn"
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "Room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "Room"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        '
        'HrsDataGridViewTextBoxColumn
        '
        Me.HrsDataGridViewTextBoxColumn.DataPropertyName = "Hrs"
        Me.HrsDataGridViewTextBoxColumn.HeaderText = "Hrs"
        Me.HrsDataGridViewTextBoxColumn.Name = "HrsDataGridViewTextBoxColumn"
        '
        'FeesTypeDataGridViewTextBoxColumn
        '
        Me.FeesTypeDataGridViewTextBoxColumn.DataPropertyName = "Fees_Type"
        Me.FeesTypeDataGridViewTextBoxColumn.HeaderText = "Fees_Type"
        Me.FeesTypeDataGridViewTextBoxColumn.Name = "FeesTypeDataGridViewTextBoxColumn"
        '
        'FeesAmountDataGridViewTextBoxColumn
        '
        Me.FeesAmountDataGridViewTextBoxColumn.DataPropertyName = "Fees_Amount"
        Me.FeesAmountDataGridViewTextBoxColumn.HeaderText = "Fees_Amount"
        Me.FeesAmountDataGridViewTextBoxColumn.Name = "FeesAmountDataGridViewTextBoxColumn"
        '
        'ProfEngFeeDataGridViewTextBoxColumn
        '
        Me.ProfEngFeeDataGridViewTextBoxColumn.DataPropertyName = "Prof / Eng Fee"
        Me.ProfEngFeeDataGridViewTextBoxColumn.HeaderText = "Prof / Eng Fee"
        Me.ProfEngFeeDataGridViewTextBoxColumn.Name = "ProfEngFeeDataGridViewTextBoxColumn"
        '
        'ProfFeeDataGridViewTextBoxColumn
        '
        Me.ProfFeeDataGridViewTextBoxColumn.DataPropertyName = "Prof Fee"
        Me.ProfFeeDataGridViewTextBoxColumn.HeaderText = "Prof Fee"
        Me.ProfFeeDataGridViewTextBoxColumn.Name = "ProfFeeDataGridViewTextBoxColumn"
        '
        'EngFeeDataGridViewTextBoxColumn
        '
        Me.EngFeeDataGridViewTextBoxColumn.DataPropertyName = "Eng Fee"
        Me.EngFeeDataGridViewTextBoxColumn.HeaderText = "Eng Fee"
        Me.EngFeeDataGridViewTextBoxColumn.Name = "EngFeeDataGridViewTextBoxColumn"
        '
        'SeatingAvailDataGridViewTextBoxColumn
        '
        Me.SeatingAvailDataGridViewTextBoxColumn.DataPropertyName = "Seating_Avail"
        Me.SeatingAvailDataGridViewTextBoxColumn.HeaderText = "Seating_Avail"
        Me.SeatingAvailDataGridViewTextBoxColumn.Name = "SeatingAvailDataGridViewTextBoxColumn"
        '
        'SeatingAssnDataGridViewTextBoxColumn
        '
        Me.SeatingAssnDataGridViewTextBoxColumn.DataPropertyName = "Seating_Assn"
        Me.SeatingAssnDataGridViewTextBoxColumn.HeaderText = "Seating_Assn"
        Me.SeatingAssnDataGridViewTextBoxColumn.Name = "SeatingAssnDataGridViewTextBoxColumn"
        '
        'SeatingMAXDataGridViewTextBoxColumn
        '
        Me.SeatingMAXDataGridViewTextBoxColumn.DataPropertyName = "Seating_MAX"
        Me.SeatingMAXDataGridViewTextBoxColumn.HeaderText = "Seating_MAX"
        Me.SeatingMAXDataGridViewTextBoxColumn.Name = "SeatingMAXDataGridViewTextBoxColumn"
        '
        'LevelDataGridViewTextBoxColumn
        '
        Me.LevelDataGridViewTextBoxColumn.DataPropertyName = "Level"
        Me.LevelDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelDataGridViewTextBoxColumn.Name = "LevelDataGridViewTextBoxColumn"
        '
        'MytableBindingSource
        '
        Me.MytableBindingSource.DataMember = "mytable"
        Me.MytableBindingSource.DataSource = Me.MasterDataSet1BindingSource
        '
        'MasterDataSet1BindingSource
        '
        Me.MasterDataSet1BindingSource.DataSource = Me.MasterDataSet1
        Me.MasterDataSet1BindingSource.Position = 0
        '
        'MasterDataSet1
        '
        Me.MasterDataSet1.DataSetName = "masterDataSet"
        Me.MasterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(96, 13)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 10
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.sanityCheckerTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = SanityChecker.sanityCheckerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Seating"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(256, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Seating Limits"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(499, 61)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 264)
        Me.ListBox1.TabIndex = 13
        '
        'MytableTableAdapter
        '
        Me.MytableTableAdapter.ClearBeforeFill = True
        '
        'DataTableAdapter1
        '
        Me.DataTableAdapter1.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(714, 374)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblCrnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Sanity Checker by H.A.R.E Solutions"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MytableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblCrnSearch As System.Windows.Forms.Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents btnOpen As Button
    Friend WithEvents MasterDataSet1 As masterDataSet
    Friend WithEvents TableAdapterManager1 As sanityCheckerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterDataSet1BindingSource As BindingSource
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MytableBindingSource As BindingSource
    Friend WithEvents MytableTableAdapter As masterDataSetTableAdapters.mytableTableAdapter
    Friend WithEvents STADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TermDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CRNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartTermDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntgPartnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstructorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstrctorEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Sec1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeBeginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeEndDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BldgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HrsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeesTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeesAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfEngFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EngFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatingAvailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatingAssnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatingMAXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents DataTableAdapter1 As masterDataSetTableAdapters.DataTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
