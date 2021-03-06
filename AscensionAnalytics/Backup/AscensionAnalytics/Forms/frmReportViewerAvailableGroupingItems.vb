﻿Public Class frmReportViewerAvailableGroupingItems
    Dim mDataContext As New ReportViewerDataContext()

    Public Sub SaveData()
        Try
            bsReportViewerAvailableGroupingItems.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")
        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAvailableGroupingItems
        _gridExExporter.ExportMode = Janus.Windows.GridEX.ExportMode.AllRows
        _gridExExporter.Export(_ioStream)
        _ioStream.Close()
        _ioStream.Dispose()

        Process.Start(_filePath)

    End Sub
    Public Sub ExportGridExToExcel()
        Dim _fileName As String = String.Empty
        Dim _saveFileDialogue As New SaveFileDialog()

        With _saveFileDialogue
            .Title = "Export Available Grouping Items"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Available ReportViewer Grouping Items (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub


    Private Sub frmReportViewerAvailableGroupingItems_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsReportViewerAvailableGroupingItems.DataSource = mDataContext.ReportViewer_AvailableGroupingItems

    End Sub

    Private Sub grexAvailableGroupingItems_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAvailableGroupingItems.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAvailableGroupingItems_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAvailableGroupingItems.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexAvailableGroupingItems_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAvailableGroupingItems.RecordUpdated
        SaveData()
    End Sub
End Class