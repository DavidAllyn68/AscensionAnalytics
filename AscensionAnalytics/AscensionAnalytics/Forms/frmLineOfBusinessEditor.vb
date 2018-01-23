﻿Public Class frmLineOfBusinessEditor
    Private mDataContext As New LineOfBusinessDataContext()

    Private Sub frmLineOfBusinessEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsLineOfBusiness.DataSource = mDataContext.LineOfBusinesses
        bsLineOfBusinessCategories.DataSource = mDataContext.LineOfBusinessCategories

        grexLineOfBusiness.DropDowns("ddLineOfBusinessCategories").SetDataBinding(bsLineOfBusinessCategories, String.Empty)

    End Sub

    Private Sub grexLineOfBusinessEditor_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexLineOfBusiness.RecordAdded
        SaveData()
    End Sub

    Private Sub grexLineOfBusinessEditor_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexLineOfBusiness.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexLineOfBusinessEditor_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexLineOfBusiness.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsLineOfBusiness.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexLineOfBusiness
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
            .Title = "Export Lines Of Business"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Lines Of Business (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class