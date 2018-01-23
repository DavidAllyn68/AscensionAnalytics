﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
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


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="David")>  _
Partial Public Class SchoolAddressInfoDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertSchoolAddressInfo(instance As SchoolAddressInfo)
    End Sub
  Partial Private Sub UpdateSchoolAddressInfo(instance As SchoolAddressInfo)
    End Sub
  Partial Private Sub DeleteSchoolAddressInfo(instance As SchoolAddressInfo)
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
	
	Public ReadOnly Property SchoolAddressInfos() As System.Data.Linq.Table(Of SchoolAddressInfo)
		Get
			Return Me.GetTable(Of SchoolAddressInfo)
		End Get
	End Property
End Class

<Table(Name:="dbo.SchoolAddressInfo")>  _
Partial Public Class SchoolAddressInfo
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CombinedClaimsSchoolId As Integer = CType(Nothing, Integer)
	
	Private _SchoolName As String = CType(Nothing, String)
	
	Private _StreetAddress As String
	
	Private _City As String
	
	Private _StateCode As String
	
	Private _ZipCode As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnStreetAddressChanging(value As String)
    End Sub
    Partial Private Sub OnStreetAddressChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnStateCodeChanging(value As String)
    End Sub
    Partial Private Sub OnStateCodeChanged()
    End Sub
    Partial Private Sub OnZipCodeChanging(value As String)
    End Sub
    Partial Private Sub OnZipCodeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_CombinedClaimsSchoolId", DbType:="Int NOT NULL", IsPrimaryKey:=true, UpdateCheck:=UpdateCheck.Never)>  _
	Public ReadOnly Property CombinedClaimsSchoolId() As Integer
		Get
			Return Me._CombinedClaimsSchoolId
		End Get
	End Property
	
	<Column(Storage:="_SchoolName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, UpdateCheck:=UpdateCheck.Never)>  _
	Public ReadOnly Property SchoolName() As String
		Get
			Return Me._SchoolName
		End Get
	End Property
	
	<Column(Storage:="_StreetAddress", DbType:="VarChar(2000)")>  _
	Public Property StreetAddress() As String
		Get
			Return Me._StreetAddress
		End Get
		Set
			If (String.Equals(Me._StreetAddress, value) = false) Then
				Me.OnStreetAddressChanging(value)
				Me.SendPropertyChanging
				Me._StreetAddress = value
				Me.SendPropertyChanged("StreetAddress")
				Me.OnStreetAddressChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_City", DbType:="VarChar(100)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_StateCode", DbType:="Char(2)")>  _
	Public Property StateCode() As String
		Get
			Return Me._StateCode
		End Get
		Set
			If (String.Equals(Me._StateCode, value) = false) Then
				Me.OnStateCodeChanging(value)
				Me.SendPropertyChanging
				Me._StateCode = value
				Me.SendPropertyChanged("StateCode")
				Me.OnStateCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ZipCode", DbType:="VarChar(10)")>  _
	Public Property ZipCode() As String
		Get
			Return Me._ZipCode
		End Get
		Set
			If (String.Equals(Me._ZipCode, value) = false) Then
				Me.OnZipCodeChanging(value)
				Me.SendPropertyChanging
				Me._ZipCode = value
				Me.SendPropertyChanged("ZipCode")
				Me.OnZipCodeChanged
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
