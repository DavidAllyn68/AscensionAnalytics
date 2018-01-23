﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="David")>  _
Partial Public Class ProcedureScheduleDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertProcedureSchedule(instance As ProcedureSchedule)
    End Sub
  Partial Private Sub UpdateProcedureSchedule(instance As ProcedureSchedule)
    End Sub
  Partial Private Sub DeleteProcedureSchedule(instance As ProcedureSchedule)
    End Sub
  Partial Private Sub InsertProcedureSchedule_RecurrenceType(instance As ProcedureSchedule_RecurrenceType)
    End Sub
  Partial Private Sub UpdateProcedureSchedule_RecurrenceType(instance As ProcedureSchedule_RecurrenceType)
    End Sub
  Partial Private Sub DeleteProcedureSchedule_RecurrenceType(instance As ProcedureSchedule_RecurrenceType)
    End Sub
  Partial Private Sub InsertProcedureSchedule_Recurrence(instance As ProcedureSchedule_Recurrence)
    End Sub
  Partial Private Sub UpdateProcedureSchedule_Recurrence(instance As ProcedureSchedule_Recurrence)
    End Sub
  Partial Private Sub DeleteProcedureSchedule_Recurrence(instance As ProcedureSchedule_Recurrence)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.AscensionAnalytics.My.MySettings.Default.DavidConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property ProcedureSchedules() As System.Data.Linq.Table(Of ProcedureSchedule)
		Get
			Return Me.GetTable(Of ProcedureSchedule)
		End Get
	End Property
	
	Public ReadOnly Property ProcedureSchedule_RecurrenceTypes() As System.Data.Linq.Table(Of ProcedureSchedule_RecurrenceType)
		Get
			Return Me.GetTable(Of ProcedureSchedule_RecurrenceType)
		End Get
	End Property
	
	Public ReadOnly Property ProcedureSchedule_Recurrences() As System.Data.Linq.Table(Of ProcedureSchedule_Recurrence)
		Get
			Return Me.GetTable(Of ProcedureSchedule_Recurrence)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.RunDavidProcs")>  _
	Public Function RunDavidProcs() As ISingleResult(Of RunDavidProcsResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of RunDavidProcsResult))
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ProcedureSchedule")>  _
Partial Public Class ProcedureSchedule
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ProcedureScheduleId As Integer
	
	Private _ProcedureName As String
	
	Private _ProcedureExecute As Date
	
	Private _ProcedureStarted As System.Nullable(Of Date)
	
	Private _ProcedureCompleted As System.Nullable(Of Date)
	
	Private _ExecutionNotes As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnProcedureScheduleIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnProcedureScheduleIdChanged()
    End Sub
    Partial Private Sub OnProcedureNameChanging(value As String)
    End Sub
    Partial Private Sub OnProcedureNameChanged()
    End Sub
    Partial Private Sub OnProcedureExecuteChanging(value As Date)
    End Sub
    Partial Private Sub OnProcedureExecuteChanged()
    End Sub
    Partial Private Sub OnProcedureStartedChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnProcedureStartedChanged()
    End Sub
    Partial Private Sub OnProcedureCompletedChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnProcedureCompletedChanged()
    End Sub
    Partial Private Sub OnExecutionNotesChanging(value As String)
    End Sub
    Partial Private Sub OnExecutionNotesChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureScheduleId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ProcedureScheduleId() As Integer
		Get
			Return Me._ProcedureScheduleId
		End Get
		Set
			If ((Me._ProcedureScheduleId = value)  _
						= false) Then
				Me.OnProcedureScheduleIdChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureScheduleId = value
				Me.SendPropertyChanged("ProcedureScheduleId")
				Me.OnProcedureScheduleIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureName", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property ProcedureName() As String
		Get
			Return Me._ProcedureName
		End Get
		Set
			If (String.Equals(Me._ProcedureName, value) = false) Then
				Me.OnProcedureNameChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureName = value
				Me.SendPropertyChanged("ProcedureName")
				Me.OnProcedureNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureExecute", DbType:="SmallDateTime NOT NULL")>  _
	Public Property ProcedureExecute() As Date
		Get
			Return Me._ProcedureExecute
		End Get
		Set
			If ((Me._ProcedureExecute = value)  _
						= false) Then
				Me.OnProcedureExecuteChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureExecute = value
				Me.SendPropertyChanged("ProcedureExecute")
				Me.OnProcedureExecuteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureStarted", DbType:="SmallDateTime")>  _
	Public Property ProcedureStarted() As System.Nullable(Of Date)
		Get
			Return Me._ProcedureStarted
		End Get
		Set
			If (Me._ProcedureStarted.Equals(value) = false) Then
				Me.OnProcedureStartedChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureStarted = value
				Me.SendPropertyChanged("ProcedureStarted")
				Me.OnProcedureStartedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureCompleted", DbType:="SmallDateTime")>  _
	Public Property ProcedureCompleted() As System.Nullable(Of Date)
		Get
			Return Me._ProcedureCompleted
		End Get
		Set
			If (Me._ProcedureCompleted.Equals(value) = false) Then
				Me.OnProcedureCompletedChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureCompleted = value
				Me.SendPropertyChanged("ProcedureCompleted")
				Me.OnProcedureCompletedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ExecutionNotes", DbType:="VarChar(2000)")>  _
	Public Property ExecutionNotes() As String
		Get
			Return Me._ExecutionNotes
		End Get
		Set
			If (String.Equals(Me._ExecutionNotes, value) = false) Then
				Me.OnExecutionNotesChanging(value)
				Me.SendPropertyChanging
				Me._ExecutionNotes = value
				Me.SendPropertyChanged("ExecutionNotes")
				Me.OnExecutionNotesChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ProcedureSchedule_RecurrenceTypes")>  _
Partial Public Class ProcedureSchedule_RecurrenceType
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ProcedureScheduleRecurrenceTypeId As Integer
	
	Private _RecurrenceType As String
	
	Private _ProcedureSchedule_Recurrences As EntitySet(Of ProcedureSchedule_Recurrence)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnProcedureScheduleRecurrenceTypeIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnProcedureScheduleRecurrenceTypeIdChanged()
    End Sub
    Partial Private Sub OnRecurrenceTypeChanging(value As String)
    End Sub
    Partial Private Sub OnRecurrenceTypeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._ProcedureSchedule_Recurrences = New EntitySet(Of ProcedureSchedule_Recurrence)(AddressOf Me.attach_ProcedureSchedule_Recurrences, AddressOf Me.detach_ProcedureSchedule_Recurrences)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureScheduleRecurrenceTypeId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ProcedureScheduleRecurrenceTypeId() As Integer
		Get
			Return Me._ProcedureScheduleRecurrenceTypeId
		End Get
		Set
			If ((Me._ProcedureScheduleRecurrenceTypeId = value)  _
						= false) Then
				Me.OnProcedureScheduleRecurrenceTypeIdChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureScheduleRecurrenceTypeId = value
				Me.SendPropertyChanged("ProcedureScheduleRecurrenceTypeId")
				Me.OnProcedureScheduleRecurrenceTypeIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RecurrenceType", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property RecurrenceType() As String
		Get
			Return Me._RecurrenceType
		End Get
		Set
			If (String.Equals(Me._RecurrenceType, value) = false) Then
				Me.OnRecurrenceTypeChanging(value)
				Me.SendPropertyChanging
				Me._RecurrenceType = value
				Me.SendPropertyChanged("RecurrenceType")
				Me.OnRecurrenceTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="ProcedureSchedule_RecurrenceType_ProcedureSchedule_Recurrence", Storage:="_ProcedureSchedule_Recurrences", ThisKey:="ProcedureScheduleRecurrenceTypeId", OtherKey:="ProcedureScheduleRecurrenceTypeId")>  _
	Public Property ProcedureSchedule_Recurrences() As EntitySet(Of ProcedureSchedule_Recurrence)
		Get
			Return Me._ProcedureSchedule_Recurrences
		End Get
		Set
			Me._ProcedureSchedule_Recurrences.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_ProcedureSchedule_Recurrences(ByVal entity As ProcedureSchedule_Recurrence)
		Me.SendPropertyChanging
		entity.ProcedureSchedule_RecurrenceType = Me
	End Sub
	
	Private Sub detach_ProcedureSchedule_Recurrences(ByVal entity As ProcedureSchedule_Recurrence)
		Me.SendPropertyChanging
		entity.ProcedureSchedule_RecurrenceType = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ProcedureSchedule_Recurrence")>  _
Partial Public Class ProcedureSchedule_Recurrence
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ProcedureScheduleRecurranceId As Integer
	
	Private _ProcedureName As String
	
	Private _ProcedureScheduleRecurrenceTypeId As Integer
	
	Private _LastExecuteTime As System.Nullable(Of Date)
	
	Private _NextExecuteTime As System.Nullable(Of Date)
	
	Private _ProcedureSchedule_RecurrenceType As EntityRef(Of ProcedureSchedule_RecurrenceType)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnProcedureScheduleRecurranceIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnProcedureScheduleRecurranceIdChanged()
    End Sub
    Partial Private Sub OnProcedureNameChanging(value As String)
    End Sub
    Partial Private Sub OnProcedureNameChanged()
    End Sub
    Partial Private Sub OnProcedureScheduleRecurrenceTypeIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnProcedureScheduleRecurrenceTypeIdChanged()
    End Sub
    Partial Private Sub OnLastExecuteTimeChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnLastExecuteTimeChanged()
    End Sub
    Partial Private Sub OnNextExecuteTimeChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnNextExecuteTimeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._ProcedureSchedule_RecurrenceType = CType(Nothing, EntityRef(Of ProcedureSchedule_RecurrenceType))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureScheduleRecurranceId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ProcedureScheduleRecurranceId() As Integer
		Get
			Return Me._ProcedureScheduleRecurranceId
		End Get
		Set
			If ((Me._ProcedureScheduleRecurranceId = value)  _
						= false) Then
				Me.OnProcedureScheduleRecurranceIdChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureScheduleRecurranceId = value
				Me.SendPropertyChanged("ProcedureScheduleRecurranceId")
				Me.OnProcedureScheduleRecurranceIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureName", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property ProcedureName() As String
		Get
			Return Me._ProcedureName
		End Get
		Set
			If (String.Equals(Me._ProcedureName, value) = false) Then
				Me.OnProcedureNameChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureName = value
				Me.SendPropertyChanged("ProcedureName")
				Me.OnProcedureNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProcedureScheduleRecurrenceTypeId", DbType:="Int NOT NULL")>  _
	Public Property ProcedureScheduleRecurrenceTypeId() As Integer
		Get
			Return Me._ProcedureScheduleRecurrenceTypeId
		End Get
		Set
			If ((Me._ProcedureScheduleRecurrenceTypeId = value)  _
						= false) Then
				If Me._ProcedureSchedule_RecurrenceType.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnProcedureScheduleRecurrenceTypeIdChanging(value)
				Me.SendPropertyChanging
				Me._ProcedureScheduleRecurrenceTypeId = value
				Me.SendPropertyChanged("ProcedureScheduleRecurrenceTypeId")
				Me.OnProcedureScheduleRecurrenceTypeIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastExecuteTime", DbType:="SmallDateTime")>  _
	Public Property LastExecuteTime() As System.Nullable(Of Date)
		Get
			Return Me._LastExecuteTime
		End Get
		Set
			If (Me._LastExecuteTime.Equals(value) = false) Then
				Me.OnLastExecuteTimeChanging(value)
				Me.SendPropertyChanging
				Me._LastExecuteTime = value
				Me.SendPropertyChanged("LastExecuteTime")
				Me.OnLastExecuteTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NextExecuteTime", DbType:="SmallDateTime")>  _
	Public Property NextExecuteTime() As System.Nullable(Of Date)
		Get
			Return Me._NextExecuteTime
		End Get
		Set
			If (Me._NextExecuteTime.Equals(value) = false) Then
				Me.OnNextExecuteTimeChanging(value)
				Me.SendPropertyChanging
				Me._NextExecuteTime = value
				Me.SendPropertyChanged("NextExecuteTime")
				Me.OnNextExecuteTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="ProcedureSchedule_RecurrenceType_ProcedureSchedule_Recurrence", Storage:="_ProcedureSchedule_RecurrenceType", ThisKey:="ProcedureScheduleRecurrenceTypeId", OtherKey:="ProcedureScheduleRecurrenceTypeId", IsForeignKey:=true)>  _
	Public Property ProcedureSchedule_RecurrenceType() As ProcedureSchedule_RecurrenceType
		Get
			Return Me._ProcedureSchedule_RecurrenceType.Entity
		End Get
		Set
			Dim previousValue As ProcedureSchedule_RecurrenceType = Me._ProcedureSchedule_RecurrenceType.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._ProcedureSchedule_RecurrenceType.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._ProcedureSchedule_RecurrenceType.Entity = Nothing
					previousValue.ProcedureSchedule_Recurrences.Remove(Me)
				End If
				Me._ProcedureSchedule_RecurrenceType.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.ProcedureSchedule_Recurrences.Add(Me)
					Me._ProcedureScheduleRecurrenceTypeId = value.ProcedureScheduleRecurrenceTypeId
				Else
					Me._ProcedureScheduleRecurrenceTypeId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("ProcedureSchedule_RecurrenceType")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class RunDavidProcsResult
	
	Private _MessageQueueId As Integer
	
	Private _MessageSubject As String
	
	Private _MessageBody As String
	
	Private _MessageSenderAddress As String
	
	Private _MessageRecipientAddress As String
	
	Private _MessageCreatedDate As Date
	
	Private _MessageScheduleDate As Date
	
	Private _MessageSentDate As System.Nullable(Of Date)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageQueueId", DbType:="Int NOT NULL")>  _
	Public Property MessageQueueId() As Integer
		Get
			Return Me._MessageQueueId
		End Get
		Set
			If ((Me._MessageQueueId = value)  _
						= false) Then
				Me._MessageQueueId = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageSubject", DbType:="VarChar(1000) NOT NULL", CanBeNull:=false)>  _
	Public Property MessageSubject() As String
		Get
			Return Me._MessageSubject
		End Get
		Set
			If (String.Equals(Me._MessageSubject, value) = false) Then
				Me._MessageSubject = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageBody", DbType:="Text NOT NULL", CanBeNull:=false, UpdateCheck:=UpdateCheck.Never)>  _
	Public Property MessageBody() As String
		Get
			Return Me._MessageBody
		End Get
		Set
			If (String.Equals(Me._MessageBody, value) = false) Then
				Me._MessageBody = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageSenderAddress", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property MessageSenderAddress() As String
		Get
			Return Me._MessageSenderAddress
		End Get
		Set
			If (String.Equals(Me._MessageSenderAddress, value) = false) Then
				Me._MessageSenderAddress = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageRecipientAddress", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property MessageRecipientAddress() As String
		Get
			Return Me._MessageRecipientAddress
		End Get
		Set
			If (String.Equals(Me._MessageRecipientAddress, value) = false) Then
				Me._MessageRecipientAddress = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageCreatedDate", DbType:="SmallDateTime NOT NULL")>  _
	Public Property MessageCreatedDate() As Date
		Get
			Return Me._MessageCreatedDate
		End Get
		Set
			If ((Me._MessageCreatedDate = value)  _
						= false) Then
				Me._MessageCreatedDate = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageScheduleDate", DbType:="SmallDateTime NOT NULL")>  _
	Public Property MessageScheduleDate() As Date
		Get
			Return Me._MessageScheduleDate
		End Get
		Set
			If ((Me._MessageScheduleDate = value)  _
						= false) Then
				Me._MessageScheduleDate = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageSentDate", DbType:="SmallDateTime")>  _
	Public Property MessageSentDate() As System.Nullable(Of Date)
		Get
			Return Me._MessageSentDate
		End Get
		Set
			If (Me._MessageSentDate.Equals(value) = false) Then
				Me._MessageSentDate = value
			End If
		End Set
	End Property
End Class