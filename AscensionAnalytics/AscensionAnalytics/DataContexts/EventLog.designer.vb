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
Partial Public Class EventLogDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
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
	
	Public ReadOnly Property David_EventLog_Details() As System.Data.Linq.Table(Of David_EventLog_Detail)
		Get
			Return Me.GetTable(Of David_EventLog_Detail)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.David_EventLog_Details")>  _
Partial Public Class David_EventLog_Detail
	
	Private _EventLogId As Integer
	
	Private _Log As String
	
	Private _Source As String
	
	Private _Destination As String
	
	Private _Operation As String
	
	Private _Result As Integer
	
	Private _Completed As String
	
	Private _Begin As Date
	
	Private _End As System.Nullable(Of Date)
	
	Private _DurationInMinutes As System.Nullable(Of Integer)
	
	Private _DurationInSeconds As System.Nullable(Of Integer)
	
	Private _DurationDescription As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EventLogId", DbType:="Int NOT NULL")>  _
	Public Property EventLogId() As Integer
		Get
			Return Me._EventLogId
		End Get
		Set
			If ((Me._EventLogId = value)  _
						= false) Then
				Me._EventLogId = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Log]", Storage:="_Log", DbType:="VarChar(2000) NOT NULL", CanBeNull:=false)>  _
	Public Property Log() As String
		Get
			Return Me._Log
		End Get
		Set
			If (String.Equals(Me._Log, value) = false) Then
				Me._Log = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Source", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property Source() As String
		Get
			Return Me._Source
		End Get
		Set
			If (String.Equals(Me._Source, value) = false) Then
				Me._Source = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Destination", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property Destination() As String
		Get
			Return Me._Destination
		End Get
		Set
			If (String.Equals(Me._Destination, value) = false) Then
				Me._Destination = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Operation", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Operation() As String
		Get
			Return Me._Operation
		End Get
		Set
			If (String.Equals(Me._Operation, value) = false) Then
				Me._Operation = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Result", DbType:="Int NOT NULL")>  _
	Public Property Result() As Integer
		Get
			Return Me._Result
		End Get
		Set
			If ((Me._Result = value)  _
						= false) Then
				Me._Result = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Completed", DbType:="VarChar(5)")>  _
	Public Property Completed() As String
		Get
			Return Me._Completed
		End Get
		Set
			If (String.Equals(Me._Completed, value) = false) Then
				Me._Completed = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Begin]", Storage:="_Begin", DbType:="DateTime NOT NULL")>  _
	Public Property Begin() As Date
		Get
			Return Me._Begin
		End Get
		Set
			If ((Me._Begin = value)  _
						= false) Then
				Me._Begin = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_End", DbType:="DateTime")>  _
	Public Property [End]() As System.Nullable(Of Date)
		Get
			Return Me._End
		End Get
		Set
			If (Me._End.Equals(value) = false) Then
				Me._End = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DurationInMinutes", DbType:="Int")>  _
	Public Property DurationInMinutes() As System.Nullable(Of Integer)
		Get
			Return Me._DurationInMinutes
		End Get
		Set
			If (Me._DurationInMinutes.Equals(value) = false) Then
				Me._DurationInMinutes = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DurationInSeconds", DbType:="Int")>  _
	Public Property DurationInSeconds() As System.Nullable(Of Integer)
		Get
			Return Me._DurationInSeconds
		End Get
		Set
			If (Me._DurationInSeconds.Equals(value) = false) Then
				Me._DurationInSeconds = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DurationDescription", DbType:="VarChar(50)")>  _
	Public Property DurationDescription() As String
		Get
			Return Me._DurationDescription
		End Get
		Set
			If (String.Equals(Me._DurationDescription, value) = false) Then
				Me._DurationDescription = value
			End If
		End Set
	End Property
End Class
