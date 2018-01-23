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
Partial Public Class DataWarehouseMessageQueueDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertMessageQueue(instance As MessageQueue)
    End Sub
  Partial Private Sub UpdateMessageQueue(instance As MessageQueue)
    End Sub
  Partial Private Sub DeleteMessageQueue(instance As MessageQueue)
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
	
	Public ReadOnly Property MessageQueues() As System.Data.Linq.Table(Of MessageQueue)
		Get
			Return Me.GetTable(Of MessageQueue)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.MessageQueue_ProcessMessages")>  _
	Public Function MessageQueue_ProcessMessages() As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.MessageQueue")>  _
Partial Public Class MessageQueue
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _MessageQueueId As Integer
	
	Private _MessageSubject As String
	
	Private _MessageBody As String
	
	Private _MessageSenderAddress As String
	
	Private _MessageRecipientAddress As String
	
	Private _MessageCreatedDate As Date
	
	Private _MessageScheduleDate As Date
	
	Private _MessageSentDate As System.Nullable(Of Date)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMessageQueueIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnMessageQueueIdChanged()
    End Sub
    Partial Private Sub OnMessageSubjectChanging(value As String)
    End Sub
    Partial Private Sub OnMessageSubjectChanged()
    End Sub
    Partial Private Sub OnMessageBodyChanging(value As String)
    End Sub
    Partial Private Sub OnMessageBodyChanged()
    End Sub
    Partial Private Sub OnMessageSenderAddressChanging(value As String)
    End Sub
    Partial Private Sub OnMessageSenderAddressChanged()
    End Sub
    Partial Private Sub OnMessageRecipientAddressChanging(value As String)
    End Sub
    Partial Private Sub OnMessageRecipientAddressChanged()
    End Sub
    Partial Private Sub OnMessageCreatedDateChanging(value As Date)
    End Sub
    Partial Private Sub OnMessageCreatedDateChanged()
    End Sub
    Partial Private Sub OnMessageScheduleDateChanging(value As Date)
    End Sub
    Partial Private Sub OnMessageScheduleDateChanged()
    End Sub
    Partial Private Sub OnMessageSentDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnMessageSentDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageQueueId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property MessageQueueId() As Integer
		Get
			Return Me._MessageQueueId
		End Get
		Set
			If ((Me._MessageQueueId = value)  _
						= false) Then
				Me.OnMessageQueueIdChanging(value)
				Me.SendPropertyChanging
				Me._MessageQueueId = value
				Me.SendPropertyChanged("MessageQueueId")
				Me.OnMessageQueueIdChanged
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
				Me.OnMessageSubjectChanging(value)
				Me.SendPropertyChanging
				Me._MessageSubject = value
				Me.SendPropertyChanged("MessageSubject")
				Me.OnMessageSubjectChanged
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
				Me.OnMessageBodyChanging(value)
				Me.SendPropertyChanging
				Me._MessageBody = value
				Me.SendPropertyChanged("MessageBody")
				Me.OnMessageBodyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageSenderAddress", DbType:="VarChar(100) NOT NULL", CanBeNull:=false, IsDbGenerated:=true)>  _
	Public Property MessageSenderAddress() As String
		Get
			Return Me._MessageSenderAddress
		End Get
		Set
			If (String.Equals(Me._MessageSenderAddress, value) = false) Then
				Me.OnMessageSenderAddressChanging(value)
				Me.SendPropertyChanging
				Me._MessageSenderAddress = value
				Me.SendPropertyChanged("MessageSenderAddress")
				Me.OnMessageSenderAddressChanged
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
				Me.OnMessageRecipientAddressChanging(value)
				Me.SendPropertyChanging
				Me._MessageRecipientAddress = value
				Me.SendPropertyChanged("MessageRecipientAddress")
				Me.OnMessageRecipientAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageCreatedDate", DbType:="SmallDateTime NOT NULL", IsDbGenerated:=true)>  _
	Public Property MessageCreatedDate() As Date
		Get
			Return Me._MessageCreatedDate
		End Get
		Set
			If ((Me._MessageCreatedDate = value)  _
						= false) Then
				Me.OnMessageCreatedDateChanging(value)
				Me.SendPropertyChanging
				Me._MessageCreatedDate = value
				Me.SendPropertyChanged("MessageCreatedDate")
				Me.OnMessageCreatedDateChanged
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
				Me.OnMessageScheduleDateChanging(value)
				Me.SendPropertyChanging
				Me._MessageScheduleDate = value
				Me.SendPropertyChanged("MessageScheduleDate")
				Me.OnMessageScheduleDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MessageSentDate", DbType:="SmallDateTime", IsDbGenerated:=true)>  _
	Public Property MessageSentDate() As System.Nullable(Of Date)
		Get
			Return Me._MessageSentDate
		End Get
		Set
			If (Me._MessageSentDate.Equals(value) = false) Then
				Me.OnMessageSentDateChanging(value)
				Me.SendPropertyChanging
				Me._MessageSentDate = value
				Me.SendPropertyChanged("MessageSentDate")
				Me.OnMessageSentDateChanged
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
