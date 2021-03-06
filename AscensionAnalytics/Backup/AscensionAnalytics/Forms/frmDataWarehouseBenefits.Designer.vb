﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseBenefits
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
        Dim grexDataWarehouseBenefits_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseBenefits))
        Me.vsmDataWarehouseBenefits = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseBenefits = New Janus.Windows.GridEX.GridEX
        Me.bsDataWarehouseBenefits = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDataWarehouseBenefitCategories = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDataWarehouseBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDataWarehouseBenefitCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseBenefits
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseBenefits.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseBenefits
        '
        Me.grexDataWarehouseBenefits.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseBenefits.DataSource = Me.bsDataWarehouseBenefits
        grexDataWarehouseBenefits_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseBenefits_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseBenefits.DesignTimeLayout = grexDataWarehouseBenefits_DesignTimeLayout
        Me.grexDataWarehouseBenefits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseBenefits.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseBenefits.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseBenefits.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseBenefits.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseBenefits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexDataWarehouseBenefits.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseBenefits.Name = "grexDataWarehouseBenefits"
        Me.grexDataWarehouseBenefits.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseBenefits.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseBenefits.Size = New System.Drawing.Size(953, 539)
        Me.grexDataWarehouseBenefits.TabIndex = 0
        Me.grexDataWarehouseBenefits.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseBenefits.VisualStyleManager = Me.vsmDataWarehouseBenefits
        '
        'bsDataWarehouseBenefits
        '
        Me.bsDataWarehouseBenefits.DataSource = GetType(AscensionAnalytics.DataWarehouseBenefit)
        Me.bsDataWarehouseBenefits.Sort = "BenefitCode"
        '
        'bsDataWarehouseBenefitCategories
        '
        Me.bsDataWarehouseBenefitCategories.DataSource = GetType(AscensionAnalytics.DataWarehouseBenefitCategory)
        '
        'frmDataWarehouseBenefits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 539)
        Me.Controls.Add(Me.grexDataWarehouseBenefits)
        Me.Name = "frmDataWarehouseBenefits"
        Me.Text = "Benefits Editor"
        CType(Me.grexDataWarehouseBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDataWarehouseBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDataWarehouseBenefitCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseBenefits As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseBenefits As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDataWarehouseBenefits As System.Windows.Forms.BindingSource
    Friend WithEvents bsDataWarehouseBenefitCategories As System.Windows.Forms.BindingSource
End Class
