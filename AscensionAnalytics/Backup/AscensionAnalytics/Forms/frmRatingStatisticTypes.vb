﻿Public Class frmRatingStatisticTypes
    Private mDataContext As New ProgramRatingDataContext()

    Private Sub frmRatingStatisticTypes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsStatisticTypes.DataSource = mDataContext.Rating_StatisticTypes

    End Sub

    Public Sub SaveData()
        Try
            bsStatisticTypes.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexStatisticTypes
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
            .Title = "Export Statistic Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis Statistic Types (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub


    Private Sub grexStatisticTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexStatisticTypes.RecordAdded
        SaveData()
    End Sub

    Private Sub grexStatisticTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexStatisticTypes.RecordsDeleted
        'do nothing -- deleting not allowed
    End Sub

    Private Sub grexStatisticTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexStatisticTypes.RecordUpdated
        SaveData()
    End Sub
End Class