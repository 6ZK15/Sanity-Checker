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
        Me.components = New System.ComponentModel.Container()
        Me.btnSortCollege = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
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
        Me.InstructorEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Zsgr004294174501BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Senior_Project.Database1DataSet()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Zsgr0042_9417450_1TableAdapter = New Senior_Project.Database1DataSetTableAdapters.zsgr0042_9417450_1TableAdapter()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zsgr004294174501BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSortCollege
        '
        Me.btnSortCollege.Location = New System.Drawing.Point(484, 420)
        Me.btnSortCollege.Name = "btnSortCollege"
        Me.btnSortCollege.Size = New System.Drawing.Size(75, 23)
        Me.btnSortCollege.TabIndex = 0
        Me.btnSortCollege.Text = "Select File"
        Me.btnSortCollege.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STADataGridViewTextBoxColumn, Me.TermDataGridViewTextBoxColumn, Me.CRNDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.SecDataGridViewTextBoxColumn, Me.PartTermDataGridViewTextBoxColumn, Me.ScheduleDataGridViewTextBoxColumn, Me.InstMethodDataGridViewTextBoxColumn, Me.IntgPartnerDataGridViewTextBoxColumn, Me.CourseTitleDataGridViewTextBoxColumn, Me.InstructorDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.InstructorEmailDataGridViewTextBoxColumn, Me.DaysDataGridViewTextBoxColumn, Me.Sec1DataGridViewTextBoxColumn, Me.TimeBeginDataGridViewTextBoxColumn, Me.TimeEndDataGridViewTextBoxColumn, Me.BldgDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.HrsDataGridViewTextBoxColumn, Me.FeesTypeDataGridViewTextBoxColumn, Me.FeesAmountDataGridViewTextBoxColumn, Me.ProfEngFeeDataGridViewTextBoxColumn, Me.ProfFeeDataGridViewTextBoxColumn, Me.EngFeeDataGridViewTextBoxColumn, Me.SeatingAvailDataGridViewTextBoxColumn, Me.SeatingAssnDataGridViewTextBoxColumn, Me.SeatingMAXDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.Zsgr004294174501BindingSource
        Me.dgv.Location = New System.Drawing.Point(13, 13)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(687, 383)
        Me.dgv.TabIndex = 1
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
        'InstructorEmailDataGridViewTextBoxColumn
        '
        Me.InstructorEmailDataGridViewTextBoxColumn.DataPropertyName = "Instructor Email"
        Me.InstructorEmailDataGridViewTextBoxColumn.HeaderText = "Instructor Email"
        Me.InstructorEmailDataGridViewTextBoxColumn.Name = "InstructorEmailDataGridViewTextBoxColumn"
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
        'Zsgr004294174501BindingSource
        '
        Me.Zsgr004294174501BindingSource.DataMember = "zsgr0042_9417450-1"
        Me.Zsgr004294174501BindingSource.DataSource = Me.Database1DataSetBindingSource
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnDepartment
        '
        Me.btnDepartment.Location = New System.Drawing.Point(13, 429)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(75, 23)
        Me.btnDepartment.TabIndex = 2
        Me.btnDepartment.Text = "s"
        Me.btnDepartment.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'BindingSource1
        '
        '
        'Zsgr0042_9417450_1TableAdapter
        '
        Me.Zsgr0042_9417450_1TableAdapter.ClearBeforeFill = True
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Location = New System.Drawing.Point(94, 413)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(41, 13)
        Me.lblSort.TabIndex = 3
        Me.lblSort.Text = "Sort By"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(331, 448)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(284, 429)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(331, 422)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 518)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.btnDepartment)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnSortCollege)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zsgr004294174501BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSortCollege As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnDepartment As Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Zsgr004294174501BindingSource As BindingSource
    Friend WithEvents Zsgr0042_9417450_1TableAdapter As Database1DataSetTableAdapters.zsgr0042_9417450_1TableAdapter
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
    Friend WithEvents InstructorEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents lblSort As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
