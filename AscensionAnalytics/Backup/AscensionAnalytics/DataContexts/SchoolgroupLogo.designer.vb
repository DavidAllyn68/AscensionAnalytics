﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5477
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
Partial Public Class SchoolgroupLogoDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertschoolgroup_logo(instance As schoolgroup_logo)
    End Sub
  Partial Private Sub Updateschoolgroup_logo(instance As schoolgroup_logo)
    End Sub
  Partial Private Sub Deleteschoolgroup_logo(instance As schoolgroup_logo)
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
	
	Public ReadOnly Property schoolgroup_logos() As System.Data.Linq.Table(Of schoolgroup_logo)
		Get
			Return Me.GetTable(Of schoolgroup_logo)
		End Get
	End Property
End Class

<Table(Name:="dbo.schoolgroup_logo")>  _
Partial Public Class schoolgroup_logo
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _schoolgroup_logo_id As Integer
	
	Private _schoolgroup_cd As String
	
	Private _logo_image() As Byte
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onschoolgroup_logo_idChanging(value As Integer)
    End Sub
    Partial Private Sub Onschoolgroup_logo_idChanged()
    End Sub
    Partial Private Sub Onschoolgroup_cdChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_cdChanged()
    End Sub
    Partial Private Sub Onlogo_imageChanging(value As Byte())
    End Sub
    Partial Private Sub Onlogo_imageChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_schoolgroup_logo_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property schoolgroup_logo_id() As Integer
		Get
			Return Me._schoolgroup_logo_id
		End Get
		Set
			If ((Me._schoolgroup_logo_id = value)  _
						= false) Then
				Me.Onschoolgroup_logo_idChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_logo_id = value
				Me.SendPropertyChanged("schoolgroup_logo_id")
				Me.Onschoolgroup_logo_idChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_schoolgroup_cd", DbType:="Char(10)")>  _
	Public Property schoolgroup_cd() As String
		Get
			Return Me._schoolgroup_cd
		End Get
		Set
			If (String.Equals(Me._schoolgroup_cd, value) = false) Then
				Me.Onschoolgroup_cdChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_cd = value
				Me.SendPropertyChanged("schoolgroup_cd")
				Me.Onschoolgroup_cdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_logo_image", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property logo_image() As Byte()
		Get
			Return Me._logo_image
		End Get
		Set
			If (Object.Equals(Me._logo_image, value) = false) Then
				Me.Onlogo_imageChanging(value)
				Me.SendPropertyChanging
				Me._logo_image = value
				Me.SendPropertyChanged("logo_image")
				Me.Onlogo_imageChanged
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