﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmeribenGroupMapping
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
        Dim grexAmeribenGroupMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmeribenGroupMapping))
        Me.vsmAmeribenGroupMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexAmeribenGroupMapping = New Janus.Windows.GridEX.GridEX
        Me.bsAmeribenGroupMap = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAmeribenGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAmeribenGroupMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAmeribenGroupMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAmeribenGroupMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexAmeribenGroupMapping
        '
        Me.grexAmeribenGroupMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenGroupMapping.AllowCardSizing = False
        Me.grexAmeribenGroupMapping.DataSource = Me.bsAmeribenGroupMap
        grexAmeribenGroupMapping_DesignTimeLayout.LayoutString = resources.GetString("grexAmeribenGroupMapping_DesignTimeLayout.LayoutString")
        Me.grexAmeribenGroupMapping.DesignTimeLayout = grexAmeribenGroupMapping_DesignTimeLayout
        Me.grexAmeribenGroupMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAmeribenGroupMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAmeribenGroupMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAmeribenGroupMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAmeribenGroupMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAmeribenGroupMapping.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexAmeribenGroupMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexAmeribenGroupMapping.Name = "grexAmeribenGroupMapping"
        Me.grexAmeribenGroupMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAmeribenGroupMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenGroupMapping.Size = New System.Drawing.Size(979, 377)
        Me.grexAmeribenGroupMapping.TabIndex = 0
        Me.grexAmeribenGroupMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAmeribenGroupMapping.VisualStyleManager = Me.vsmAmeribenGroupMapping
        '
        'bsAmeribenGroupMap
        '
        Me.bsAmeribenGroupMap.DataSource = GetType(AscensionAnalytics.Ameriben_GroupMap)
        '
        'frmAmeribenGroupMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 377)
        Me.Controls.Add(Me.grexAmeribenGroupMapping)
        Me.Name = "frmAmeribenGroupMapping"
        Me.Text = "Ameriben Group Mapping"
        CType(Me.grexAmeribenGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAmeribenGroupMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmAmeribenGroupMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAmeribenGroupMap As System.Windows.Forms.BindingSource
    Friend WithEvents grexAmeribenGroupMapping As Janus.Windows.GridEX.GridEX
End Class
