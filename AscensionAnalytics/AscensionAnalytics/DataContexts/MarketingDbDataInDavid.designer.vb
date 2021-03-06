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
Partial Public Class MarketingDbDataInDavidDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertMarketingDB_SchoolgroupMapping(instance As MarketingDB_SchoolgroupMapping)
    End Sub
  Partial Private Sub UpdateMarketingDB_SchoolgroupMapping(instance As MarketingDB_SchoolgroupMapping)
    End Sub
  Partial Private Sub DeleteMarketingDB_SchoolgroupMapping(instance As MarketingDB_SchoolgroupMapping)
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
	
	Public ReadOnly Property MarketingDb_Schools() As System.Data.Linq.Table(Of MarketingDb_School)
		Get
			Return Me.GetTable(Of MarketingDb_School)
		End Get
	End Property
	
	Public ReadOnly Property MarketingDB_SchoolgroupMappings() As System.Data.Linq.Table(Of MarketingDB_SchoolgroupMapping)
		Get
			Return Me.GetTable(Of MarketingDB_SchoolgroupMapping)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.MarketingDb_Schools")>  _
Partial Public Class MarketingDb_School
	
	Private _school As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_school", DbType:="NVarChar(100)")>  _
	Public Property school() As String
		Get
			Return Me._school
		End Get
		Set
			If (String.Equals(Me._school, value) = false) Then
				Me._school = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.MarketingDB_SchoolgroupMapping")>  _
Partial Public Class MarketingDB_SchoolgroupMapping
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _MarketingDbSchoolgroupMappingId As Integer
	
	Private _MarketingDbSchool As String
	
	Private _MarketingDbPlan As String
	
	Private _PremiumAdministratorGroupCode As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMarketingDbSchoolgroupMappingIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnMarketingDbSchoolgroupMappingIdChanged()
    End Sub
    Partial Private Sub OnMarketingDbSchoolChanging(value As String)
    End Sub
    Partial Private Sub OnMarketingDbSchoolChanged()
    End Sub
    Partial Private Sub OnMarketingDbPlanChanging(value As String)
    End Sub
    Partial Private Sub OnMarketingDbPlanChanged()
    End Sub
    Partial Private Sub OnPremiumAdministratorGroupCodeChanging(value As String)
    End Sub
    Partial Private Sub OnPremiumAdministratorGroupCodeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MarketingDbSchoolgroupMappingId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property MarketingDbSchoolgroupMappingId() As Integer
		Get
			Return Me._MarketingDbSchoolgroupMappingId
		End Get
		Set
			If ((Me._MarketingDbSchoolgroupMappingId = value)  _
						= false) Then
				Me.OnMarketingDbSchoolgroupMappingIdChanging(value)
				Me.SendPropertyChanging
				Me._MarketingDbSchoolgroupMappingId = value
				Me.SendPropertyChanged("MarketingDbSchoolgroupMappingId")
				Me.OnMarketingDbSchoolgroupMappingIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MarketingDbSchool", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property MarketingDbSchool() As String
		Get
			Return Me._MarketingDbSchool
		End Get
		Set
			If (String.Equals(Me._MarketingDbSchool, value) = false) Then
				Me.OnMarketingDbSchoolChanging(value)
				Me.SendPropertyChanging
				Me._MarketingDbSchool = value
				Me.SendPropertyChanged("MarketingDbSchool")
				Me.OnMarketingDbSchoolChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MarketingDbPlan", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property MarketingDbPlan() As String
		Get
			Return Me._MarketingDbPlan
		End Get
		Set
			If (String.Equals(Me._MarketingDbPlan, value) = false) Then
				Me.OnMarketingDbPlanChanging(value)
				Me.SendPropertyChanging
				Me._MarketingDbPlan = value
				Me.SendPropertyChanged("MarketingDbPlan")
				Me.OnMarketingDbPlanChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PremiumAdministratorGroupCode", DbType:="VarChar(20)")>  _
	Public Property PremiumAdministratorGroupCode() As String
		Get
			Return Me._PremiumAdministratorGroupCode
		End Get
		Set
			If (String.Equals(Me._PremiumAdministratorGroupCode, value) = false) Then
				Me.OnPremiumAdministratorGroupCodeChanging(value)
				Me.SendPropertyChanging
				Me._PremiumAdministratorGroupCode = value
				Me.SendPropertyChanged("PremiumAdministratorGroupCode")
				Me.OnPremiumAdministratorGroupCodeChanged
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
