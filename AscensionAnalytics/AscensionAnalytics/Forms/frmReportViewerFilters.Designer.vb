﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewerFilters
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grexReportViewerFilter_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewerFilters))
        Me.vsmReportViewerFilters = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexReportViewerFilter = New Janus.Windows.GridEX.GridEX
        Me.bsReportViewerFilters = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexReportViewerFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReportViewerFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmReportViewerFilters
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmReportViewerFilters.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexReportViewerFilter
        '
        Me.grexReportViewerFilter.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexReportViewerFilter.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexReportViewerFilter.DataSource = Me.bsReportViewerFilters
        grexReportViewerFilter_DesignTimeLayout.LayoutString = resources.GetString("grexReportViewerFilter_DesignTimeLayout.LayoutString")
        Me.grexReportViewerFilter.DesignTimeLayout = grexReportViewerFilter_DesignTimeLayout
        Me.grexReportViewerFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexReportViewerFilter.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexReportViewerFilter.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexReportViewerFilter.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexReportViewerFilter.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexReportViewerFilter.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexReportViewerFilter.Location = New System.Drawing.Point(0, 0)
        Me.grexReportViewerFilter.Name = "grexReportViewerFilter"
        Me.grexReportViewerFilter.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexReportViewerFilter.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexReportViewerFilter.Size = New System.Drawing.Size(967, 262)
        Me.grexReportViewerFilter.TabIndex = 0
        Me.grexReportViewerFilter.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexReportViewerFilter.VisualStyleManager = Me.vsmReportViewerFilters
        '
        'bsReportViewerFilters
        '
        Me.bsReportViewerFilters.DataSource = GetType(AscensionAnalytics.ReportViewer_RecordFilter)
        '
        'frmReportViewerFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 262)
        Me.Controls.Add(Me.grexReportViewerFilter)
        Me.Name = "frmReportViewerFilters"
        Me.Text = "Report Viewer Filters"
        CType(Me.grexReportViewerFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReportViewerFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmReportViewerFilters As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexReportViewerFilter As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsReportViewerFilters As System.Windows.Forms.BindingSource
End Class
