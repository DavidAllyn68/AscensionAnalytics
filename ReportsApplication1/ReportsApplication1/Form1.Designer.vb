﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DPRDataSet = New ReportsApplication1.DPRDataSet()
        Me.DPRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DPRTableAdapter = New ReportsApplication1.DPRDataSetTableAdapters.DPRTableAdapter()
        CType(Me.DPRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DPRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DPRTableDataSet"
        ReportDataSource1.Value = Me.DPRBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'DPRDataSet
        '
        Me.DPRDataSet.DataSetName = "DPRDataSet"
        Me.DPRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DPRBindingSource
        '
        Me.DPRBindingSource.DataMember = "DPR"
        Me.DPRBindingSource.DataSource = Me.DPRDataSet
        '
        'DPRTableAdapter
        '
        Me.DPRTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DPRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DPRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DPRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DPRDataSet As ReportsApplication1.DPRDataSet
    Friend WithEvents DPRTableAdapter As ReportsApplication1.DPRDataSetTableAdapters.DPRTableAdapter

End Class
