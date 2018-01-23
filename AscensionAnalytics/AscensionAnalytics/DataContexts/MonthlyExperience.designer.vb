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
Partial Public Class MonthlyExperienceDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertmonthly_experience(instance As monthly_experience)
    End Sub
  Partial Private Sub Updatemonthly_experience(instance As monthly_experience)
    End Sub
  Partial Private Sub Deletemonthly_experience(instance As monthly_experience)
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
	
	Public ReadOnly Property monthly_experiences() As System.Data.Linq.Table(Of monthly_experience)
		Get
			Return Me.GetTable(Of monthly_experience)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.monthly_experience")>  _
Partial Public Class monthly_experience
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _MonthlyExperienceId As Integer
	
	Private _policyid As Integer
	
	Private _schoolgroup_cd As String
	
	Private _schoolgroup_nm As String
	
	Private _underwriter_cd As String
	
	Private _underwriter_nm As String
	
	Private _policyyearid As Byte
	
	Private _policyyear As String
	
	Private _curr_policyyearid As Integer
	
	Private _curr_policyyear As String
	
	Private _prev_policyyear As String
	
	Private _prev2_policyyear As String
	
	Private _prev3_policyyear As String
	
	Private _yearmo As Integer
	
	Private _year_char As String
	
	Private _month_char As String
	
	Private _month_ending As Date
	
	Private _relative_year As Integer
	
	Private _relative_month As Integer
	
	Private _enrollment As Integer
	
	Private _enrollment_months As Integer
	
	Private _prem_due As Decimal
	
	Private _prem_received As Decimal
	
	Private _num_mbrs As Integer
	
	Private _num_claims As Integer
	
	Private _num_charges As Integer
	
	Private _tot_incurred_ServiceDate As Decimal
	
	Private _tot_incurred As Decimal
	
	Private _tot_ppodisc As Decimal
	
	Private _tot_coinsurance As Decimal
	
	Private _tot_copay As Decimal
	
	Private _tot_deductible As Decimal
	
	Private _tot_excluded As Decimal
	
	Private _tot_otherins As Decimal
	
	Private _tot_paid As Decimal
	
	Private _cuml_enrollment As Integer
	
	Private _cuml_enrollment_months As Integer
	
	Private _cuml_prem_due As Decimal
	
	Private _cuml_prem_received As Decimal
	
	Private _cuml_charges As Integer
	
	Private _cuml_incurred_ServiceDate As Decimal
	
	Private _cuml_incurred As Decimal
	
	Private _cuml_ppodisc As Decimal
	
	Private _cuml_coinsurance As Decimal
	
	Private _cuml_copay As Decimal
	
	Private _cuml_deductible As Decimal
	
	Private _cuml_excluded As Decimal
	
	Private _cuml_otherins As Decimal
	
	Private _cuml_paid As Decimal
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMonthlyExperienceIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnMonthlyExperienceIdChanged()
    End Sub
    Partial Private Sub OnpolicyidChanging(value As Integer)
    End Sub
    Partial Private Sub OnpolicyidChanged()
    End Sub
    Partial Private Sub Onschoolgroup_cdChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_cdChanged()
    End Sub
    Partial Private Sub Onschoolgroup_nmChanging(value As String)
    End Sub
    Partial Private Sub Onschoolgroup_nmChanged()
    End Sub
    Partial Private Sub Onunderwriter_cdChanging(value As String)
    End Sub
    Partial Private Sub Onunderwriter_cdChanged()
    End Sub
    Partial Private Sub Onunderwriter_nmChanging(value As String)
    End Sub
    Partial Private Sub Onunderwriter_nmChanged()
    End Sub
    Partial Private Sub OnpolicyyearidChanging(value As Byte)
    End Sub
    Partial Private Sub OnpolicyyearidChanged()
    End Sub
    Partial Private Sub OnpolicyyearChanging(value As String)
    End Sub
    Partial Private Sub OnpolicyyearChanged()
    End Sub
    Partial Private Sub Oncurr_policyyearidChanging(value As Integer)
    End Sub
    Partial Private Sub Oncurr_policyyearidChanged()
    End Sub
    Partial Private Sub Oncurr_policyyearChanging(value As String)
    End Sub
    Partial Private Sub Oncurr_policyyearChanged()
    End Sub
    Partial Private Sub Onprev_policyyearChanging(value As String)
    End Sub
    Partial Private Sub Onprev_policyyearChanged()
    End Sub
    Partial Private Sub Onprev2_policyyearChanging(value As String)
    End Sub
    Partial Private Sub Onprev2_policyyearChanged()
    End Sub
    Partial Private Sub Onprev3_policyyearChanging(value As String)
    End Sub
    Partial Private Sub Onprev3_policyyearChanged()
    End Sub
    Partial Private Sub OnyearmoChanging(value As Integer)
    End Sub
    Partial Private Sub OnyearmoChanged()
    End Sub
    Partial Private Sub Onyear_charChanging(value As String)
    End Sub
    Partial Private Sub Onyear_charChanged()
    End Sub
    Partial Private Sub Onmonth_charChanging(value As String)
    End Sub
    Partial Private Sub Onmonth_charChanged()
    End Sub
    Partial Private Sub Onmonth_endingChanging(value As Date)
    End Sub
    Partial Private Sub Onmonth_endingChanged()
    End Sub
    Partial Private Sub Onrelative_yearChanging(value As Integer)
    End Sub
    Partial Private Sub Onrelative_yearChanged()
    End Sub
    Partial Private Sub Onrelative_monthChanging(value As Integer)
    End Sub
    Partial Private Sub Onrelative_monthChanged()
    End Sub
    Partial Private Sub OnenrollmentChanging(value As Integer)
    End Sub
    Partial Private Sub OnenrollmentChanged()
    End Sub
    Partial Private Sub Onenrollment_monthsChanging(value As Integer)
    End Sub
    Partial Private Sub Onenrollment_monthsChanged()
    End Sub
    Partial Private Sub Onprem_dueChanging(value As Decimal)
    End Sub
    Partial Private Sub Onprem_dueChanged()
    End Sub
    Partial Private Sub Onprem_receivedChanging(value As Decimal)
    End Sub
    Partial Private Sub Onprem_receivedChanged()
    End Sub
    Partial Private Sub Onnum_mbrsChanging(value As Integer)
    End Sub
    Partial Private Sub Onnum_mbrsChanged()
    End Sub
    Partial Private Sub Onnum_claimsChanging(value As Integer)
    End Sub
    Partial Private Sub Onnum_claimsChanged()
    End Sub
    Partial Private Sub Onnum_chargesChanging(value As Integer)
    End Sub
    Partial Private Sub Onnum_chargesChanged()
    End Sub
    Partial Private Sub Ontot_incurred_ServiceDateChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_incurred_ServiceDateChanged()
    End Sub
    Partial Private Sub Ontot_incurredChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_incurredChanged()
    End Sub
    Partial Private Sub Ontot_ppodiscChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_ppodiscChanged()
    End Sub
    Partial Private Sub Ontot_coinsuranceChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_coinsuranceChanged()
    End Sub
    Partial Private Sub Ontot_copayChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_copayChanged()
    End Sub
    Partial Private Sub Ontot_deductibleChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_deductibleChanged()
    End Sub
    Partial Private Sub Ontot_excludedChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_excludedChanged()
    End Sub
    Partial Private Sub Ontot_otherinsChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_otherinsChanged()
    End Sub
    Partial Private Sub Ontot_paidChanging(value As Decimal)
    End Sub
    Partial Private Sub Ontot_paidChanged()
    End Sub
    Partial Private Sub Oncuml_enrollmentChanging(value As Integer)
    End Sub
    Partial Private Sub Oncuml_enrollmentChanged()
    End Sub
    Partial Private Sub Oncuml_enrollment_monthsChanging(value As Integer)
    End Sub
    Partial Private Sub Oncuml_enrollment_monthsChanged()
    End Sub
    Partial Private Sub Oncuml_prem_dueChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_prem_dueChanged()
    End Sub
    Partial Private Sub Oncuml_prem_receivedChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_prem_receivedChanged()
    End Sub
    Partial Private Sub Oncuml_chargesChanging(value As Integer)
    End Sub
    Partial Private Sub Oncuml_chargesChanged()
    End Sub
    Partial Private Sub Oncuml_incurred_ServiceDateChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_incurred_ServiceDateChanged()
    End Sub
    Partial Private Sub Oncuml_incurredChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_incurredChanged()
    End Sub
    Partial Private Sub Oncuml_ppodiscChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_ppodiscChanged()
    End Sub
    Partial Private Sub Oncuml_coinsuranceChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_coinsuranceChanged()
    End Sub
    Partial Private Sub Oncuml_copayChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_copayChanged()
    End Sub
    Partial Private Sub Oncuml_deductibleChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_deductibleChanged()
    End Sub
    Partial Private Sub Oncuml_excludedChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_excludedChanged()
    End Sub
    Partial Private Sub Oncuml_otherinsChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_otherinsChanged()
    End Sub
    Partial Private Sub Oncuml_paidChanging(value As Decimal)
    End Sub
    Partial Private Sub Oncuml_paidChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MonthlyExperienceId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property MonthlyExperienceId() As Integer
		Get
			Return Me._MonthlyExperienceId
		End Get
		Set
			If ((Me._MonthlyExperienceId = value)  _
						= false) Then
				Me.OnMonthlyExperienceIdChanging(value)
				Me.SendPropertyChanging
				Me._MonthlyExperienceId = value
				Me.SendPropertyChanged("MonthlyExperienceId")
				Me.OnMonthlyExperienceIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_policyid", DbType:="Int NOT NULL")>  _
	Public Property policyid() As Integer
		Get
			Return Me._policyid
		End Get
		Set
			If ((Me._policyid = value)  _
						= false) Then
				Me.OnpolicyidChanging(value)
				Me.SendPropertyChanging
				Me._policyid = value
				Me.SendPropertyChanged("policyid")
				Me.OnpolicyidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_schoolgroup_cd", DbType:="Char(10) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_schoolgroup_nm", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property schoolgroup_nm() As String
		Get
			Return Me._schoolgroup_nm
		End Get
		Set
			If (String.Equals(Me._schoolgroup_nm, value) = false) Then
				Me.Onschoolgroup_nmChanging(value)
				Me.SendPropertyChanging
				Me._schoolgroup_nm = value
				Me.SendPropertyChanged("schoolgroup_nm")
				Me.Onschoolgroup_nmChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_underwriter_cd", DbType:="Char(10) NOT NULL", CanBeNull:=false)>  _
	Public Property underwriter_cd() As String
		Get
			Return Me._underwriter_cd
		End Get
		Set
			If (String.Equals(Me._underwriter_cd, value) = false) Then
				Me.Onunderwriter_cdChanging(value)
				Me.SendPropertyChanging
				Me._underwriter_cd = value
				Me.SendPropertyChanged("underwriter_cd")
				Me.Onunderwriter_cdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_underwriter_nm", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property underwriter_nm() As String
		Get
			Return Me._underwriter_nm
		End Get
		Set
			If (String.Equals(Me._underwriter_nm, value) = false) Then
				Me.Onunderwriter_nmChanging(value)
				Me.SendPropertyChanging
				Me._underwriter_nm = value
				Me.SendPropertyChanged("underwriter_nm")
				Me.Onunderwriter_nmChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_policyyearid", DbType:="TinyInt NOT NULL")>  _
	Public Property policyyearid() As Byte
		Get
			Return Me._policyyearid
		End Get
		Set
			If ((Me._policyyearid = value)  _
						= false) Then
				Me.OnpolicyyearidChanging(value)
				Me.SendPropertyChanging
				Me._policyyearid = value
				Me.SendPropertyChanged("policyyearid")
				Me.OnpolicyyearidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_policyyear", DbType:="Char(9) NOT NULL", CanBeNull:=false)>  _
	Public Property policyyear() As String
		Get
			Return Me._policyyear
		End Get
		Set
			If (String.Equals(Me._policyyear, value) = false) Then
				Me.OnpolicyyearChanging(value)
				Me.SendPropertyChanging
				Me._policyyear = value
				Me.SendPropertyChanged("policyyear")
				Me.OnpolicyyearChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_curr_policyyearid", DbType:="Int NOT NULL")>  _
	Public Property curr_policyyearid() As Integer
		Get
			Return Me._curr_policyyearid
		End Get
		Set
			If ((Me._curr_policyyearid = value)  _
						= false) Then
				Me.Oncurr_policyyearidChanging(value)
				Me.SendPropertyChanging
				Me._curr_policyyearid = value
				Me.SendPropertyChanged("curr_policyyearid")
				Me.Oncurr_policyyearidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_curr_policyyear", DbType:="Char(9) NOT NULL", CanBeNull:=false)>  _
	Public Property curr_policyyear() As String
		Get
			Return Me._curr_policyyear
		End Get
		Set
			If (String.Equals(Me._curr_policyyear, value) = false) Then
				Me.Oncurr_policyyearChanging(value)
				Me.SendPropertyChanging
				Me._curr_policyyear = value
				Me.SendPropertyChanged("curr_policyyear")
				Me.Oncurr_policyyearChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prev_policyyear", DbType:="Char(9) NOT NULL", CanBeNull:=false)>  _
	Public Property prev_policyyear() As String
		Get
			Return Me._prev_policyyear
		End Get
		Set
			If (String.Equals(Me._prev_policyyear, value) = false) Then
				Me.Onprev_policyyearChanging(value)
				Me.SendPropertyChanging
				Me._prev_policyyear = value
				Me.SendPropertyChanged("prev_policyyear")
				Me.Onprev_policyyearChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prev2_policyyear", DbType:="Char(9) NOT NULL", CanBeNull:=false)>  _
	Public Property prev2_policyyear() As String
		Get
			Return Me._prev2_policyyear
		End Get
		Set
			If (String.Equals(Me._prev2_policyyear, value) = false) Then
				Me.Onprev2_policyyearChanging(value)
				Me.SendPropertyChanging
				Me._prev2_policyyear = value
				Me.SendPropertyChanged("prev2_policyyear")
				Me.Onprev2_policyyearChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prev3_policyyear", DbType:="Char(9) NOT NULL", CanBeNull:=false)>  _
	Public Property prev3_policyyear() As String
		Get
			Return Me._prev3_policyyear
		End Get
		Set
			If (String.Equals(Me._prev3_policyyear, value) = false) Then
				Me.Onprev3_policyyearChanging(value)
				Me.SendPropertyChanging
				Me._prev3_policyyear = value
				Me.SendPropertyChanged("prev3_policyyear")
				Me.Onprev3_policyyearChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_yearmo", DbType:="Int NOT NULL")>  _
	Public Property yearmo() As Integer
		Get
			Return Me._yearmo
		End Get
		Set
			If ((Me._yearmo = value)  _
						= false) Then
				Me.OnyearmoChanging(value)
				Me.SendPropertyChanging
				Me._yearmo = value
				Me.SendPropertyChanged("yearmo")
				Me.OnyearmoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_year_char", DbType:="Char(4) NOT NULL", CanBeNull:=false)>  _
	Public Property year_char() As String
		Get
			Return Me._year_char
		End Get
		Set
			If (String.Equals(Me._year_char, value) = false) Then
				Me.Onyear_charChanging(value)
				Me.SendPropertyChanging
				Me._year_char = value
				Me.SendPropertyChanged("year_char")
				Me.Onyear_charChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_month_char", DbType:="NVarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property month_char() As String
		Get
			Return Me._month_char
		End Get
		Set
			If (String.Equals(Me._month_char, value) = false) Then
				Me.Onmonth_charChanging(value)
				Me.SendPropertyChanging
				Me._month_char = value
				Me.SendPropertyChanged("month_char")
				Me.Onmonth_charChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_month_ending", DbType:="SmallDateTime NOT NULL")>  _
	Public Property month_ending() As Date
		Get
			Return Me._month_ending
		End Get
		Set
			If ((Me._month_ending = value)  _
						= false) Then
				Me.Onmonth_endingChanging(value)
				Me.SendPropertyChanging
				Me._month_ending = value
				Me.SendPropertyChanged("month_ending")
				Me.Onmonth_endingChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_relative_year", DbType:="Int NOT NULL")>  _
	Public Property relative_year() As Integer
		Get
			Return Me._relative_year
		End Get
		Set
			If ((Me._relative_year = value)  _
						= false) Then
				Me.Onrelative_yearChanging(value)
				Me.SendPropertyChanging
				Me._relative_year = value
				Me.SendPropertyChanged("relative_year")
				Me.Onrelative_yearChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_relative_month", DbType:="Int NOT NULL")>  _
	Public Property relative_month() As Integer
		Get
			Return Me._relative_month
		End Get
		Set
			If ((Me._relative_month = value)  _
						= false) Then
				Me.Onrelative_monthChanging(value)
				Me.SendPropertyChanging
				Me._relative_month = value
				Me.SendPropertyChanged("relative_month")
				Me.Onrelative_monthChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_enrollment", DbType:="Int NOT NULL")>  _
	Public Property enrollment() As Integer
		Get
			Return Me._enrollment
		End Get
		Set
			If ((Me._enrollment = value)  _
						= false) Then
				Me.OnenrollmentChanging(value)
				Me.SendPropertyChanging
				Me._enrollment = value
				Me.SendPropertyChanged("enrollment")
				Me.OnenrollmentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_enrollment_months", DbType:="Int NOT NULL")>  _
	Public Property enrollment_months() As Integer
		Get
			Return Me._enrollment_months
		End Get
		Set
			If ((Me._enrollment_months = value)  _
						= false) Then
				Me.Onenrollment_monthsChanging(value)
				Me.SendPropertyChanging
				Me._enrollment_months = value
				Me.SendPropertyChanged("enrollment_months")
				Me.Onenrollment_monthsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prem_due", DbType:="Money NOT NULL")>  _
	Public Property prem_due() As Decimal
		Get
			Return Me._prem_due
		End Get
		Set
			If ((Me._prem_due = value)  _
						= false) Then
				Me.Onprem_dueChanging(value)
				Me.SendPropertyChanging
				Me._prem_due = value
				Me.SendPropertyChanged("prem_due")
				Me.Onprem_dueChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prem_received", DbType:="Money NOT NULL")>  _
	Public Property prem_received() As Decimal
		Get
			Return Me._prem_received
		End Get
		Set
			If ((Me._prem_received = value)  _
						= false) Then
				Me.Onprem_receivedChanging(value)
				Me.SendPropertyChanging
				Me._prem_received = value
				Me.SendPropertyChanged("prem_received")
				Me.Onprem_receivedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_num_mbrs", DbType:="Int NOT NULL")>  _
	Public Property num_mbrs() As Integer
		Get
			Return Me._num_mbrs
		End Get
		Set
			If ((Me._num_mbrs = value)  _
						= false) Then
				Me.Onnum_mbrsChanging(value)
				Me.SendPropertyChanging
				Me._num_mbrs = value
				Me.SendPropertyChanged("num_mbrs")
				Me.Onnum_mbrsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_num_claims", DbType:="Int NOT NULL")>  _
	Public Property num_claims() As Integer
		Get
			Return Me._num_claims
		End Get
		Set
			If ((Me._num_claims = value)  _
						= false) Then
				Me.Onnum_claimsChanging(value)
				Me.SendPropertyChanging
				Me._num_claims = value
				Me.SendPropertyChanged("num_claims")
				Me.Onnum_claimsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_num_charges", DbType:="Int NOT NULL")>  _
	Public Property num_charges() As Integer
		Get
			Return Me._num_charges
		End Get
		Set
			If ((Me._num_charges = value)  _
						= false) Then
				Me.Onnum_chargesChanging(value)
				Me.SendPropertyChanging
				Me._num_charges = value
				Me.SendPropertyChanged("num_charges")
				Me.Onnum_chargesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_incurred_ServiceDate", DbType:="Money NOT NULL")>  _
	Public Property tot_incurred_ServiceDate() As Decimal
		Get
			Return Me._tot_incurred_ServiceDate
		End Get
		Set
			If ((Me._tot_incurred_ServiceDate = value)  _
						= false) Then
				Me.Ontot_incurred_ServiceDateChanging(value)
				Me.SendPropertyChanging
				Me._tot_incurred_ServiceDate = value
				Me.SendPropertyChanged("tot_incurred_ServiceDate")
				Me.Ontot_incurred_ServiceDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_incurred", DbType:="Money NOT NULL")>  _
	Public Property tot_incurred() As Decimal
		Get
			Return Me._tot_incurred
		End Get
		Set
			If ((Me._tot_incurred = value)  _
						= false) Then
				Me.Ontot_incurredChanging(value)
				Me.SendPropertyChanging
				Me._tot_incurred = value
				Me.SendPropertyChanged("tot_incurred")
				Me.Ontot_incurredChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_ppodisc", DbType:="Money NOT NULL")>  _
	Public Property tot_ppodisc() As Decimal
		Get
			Return Me._tot_ppodisc
		End Get
		Set
			If ((Me._tot_ppodisc = value)  _
						= false) Then
				Me.Ontot_ppodiscChanging(value)
				Me.SendPropertyChanging
				Me._tot_ppodisc = value
				Me.SendPropertyChanged("tot_ppodisc")
				Me.Ontot_ppodiscChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_coinsurance", DbType:="Money NOT NULL")>  _
	Public Property tot_coinsurance() As Decimal
		Get
			Return Me._tot_coinsurance
		End Get
		Set
			If ((Me._tot_coinsurance = value)  _
						= false) Then
				Me.Ontot_coinsuranceChanging(value)
				Me.SendPropertyChanging
				Me._tot_coinsurance = value
				Me.SendPropertyChanged("tot_coinsurance")
				Me.Ontot_coinsuranceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_copay", DbType:="Money NOT NULL")>  _
	Public Property tot_copay() As Decimal
		Get
			Return Me._tot_copay
		End Get
		Set
			If ((Me._tot_copay = value)  _
						= false) Then
				Me.Ontot_copayChanging(value)
				Me.SendPropertyChanging
				Me._tot_copay = value
				Me.SendPropertyChanged("tot_copay")
				Me.Ontot_copayChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_deductible", DbType:="Money NOT NULL")>  _
	Public Property tot_deductible() As Decimal
		Get
			Return Me._tot_deductible
		End Get
		Set
			If ((Me._tot_deductible = value)  _
						= false) Then
				Me.Ontot_deductibleChanging(value)
				Me.SendPropertyChanging
				Me._tot_deductible = value
				Me.SendPropertyChanged("tot_deductible")
				Me.Ontot_deductibleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_excluded", DbType:="Money NOT NULL")>  _
	Public Property tot_excluded() As Decimal
		Get
			Return Me._tot_excluded
		End Get
		Set
			If ((Me._tot_excluded = value)  _
						= false) Then
				Me.Ontot_excludedChanging(value)
				Me.SendPropertyChanging
				Me._tot_excluded = value
				Me.SendPropertyChanged("tot_excluded")
				Me.Ontot_excludedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_otherins", DbType:="Money NOT NULL")>  _
	Public Property tot_otherins() As Decimal
		Get
			Return Me._tot_otherins
		End Get
		Set
			If ((Me._tot_otherins = value)  _
						= false) Then
				Me.Ontot_otherinsChanging(value)
				Me.SendPropertyChanging
				Me._tot_otherins = value
				Me.SendPropertyChanged("tot_otherins")
				Me.Ontot_otherinsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tot_paid", DbType:="Money NOT NULL")>  _
	Public Property tot_paid() As Decimal
		Get
			Return Me._tot_paid
		End Get
		Set
			If ((Me._tot_paid = value)  _
						= false) Then
				Me.Ontot_paidChanging(value)
				Me.SendPropertyChanging
				Me._tot_paid = value
				Me.SendPropertyChanged("tot_paid")
				Me.Ontot_paidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_enrollment", DbType:="Int NOT NULL")>  _
	Public Property cuml_enrollment() As Integer
		Get
			Return Me._cuml_enrollment
		End Get
		Set
			If ((Me._cuml_enrollment = value)  _
						= false) Then
				Me.Oncuml_enrollmentChanging(value)
				Me.SendPropertyChanging
				Me._cuml_enrollment = value
				Me.SendPropertyChanged("cuml_enrollment")
				Me.Oncuml_enrollmentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_enrollment_months", DbType:="Int NOT NULL")>  _
	Public Property cuml_enrollment_months() As Integer
		Get
			Return Me._cuml_enrollment_months
		End Get
		Set
			If ((Me._cuml_enrollment_months = value)  _
						= false) Then
				Me.Oncuml_enrollment_monthsChanging(value)
				Me.SendPropertyChanging
				Me._cuml_enrollment_months = value
				Me.SendPropertyChanged("cuml_enrollment_months")
				Me.Oncuml_enrollment_monthsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_prem_due", DbType:="Money NOT NULL")>  _
	Public Property cuml_prem_due() As Decimal
		Get
			Return Me._cuml_prem_due
		End Get
		Set
			If ((Me._cuml_prem_due = value)  _
						= false) Then
				Me.Oncuml_prem_dueChanging(value)
				Me.SendPropertyChanging
				Me._cuml_prem_due = value
				Me.SendPropertyChanged("cuml_prem_due")
				Me.Oncuml_prem_dueChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_prem_received", DbType:="Money NOT NULL")>  _
	Public Property cuml_prem_received() As Decimal
		Get
			Return Me._cuml_prem_received
		End Get
		Set
			If ((Me._cuml_prem_received = value)  _
						= false) Then
				Me.Oncuml_prem_receivedChanging(value)
				Me.SendPropertyChanging
				Me._cuml_prem_received = value
				Me.SendPropertyChanged("cuml_prem_received")
				Me.Oncuml_prem_receivedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_charges", DbType:="Int NOT NULL")>  _
	Public Property cuml_charges() As Integer
		Get
			Return Me._cuml_charges
		End Get
		Set
			If ((Me._cuml_charges = value)  _
						= false) Then
				Me.Oncuml_chargesChanging(value)
				Me.SendPropertyChanging
				Me._cuml_charges = value
				Me.SendPropertyChanged("cuml_charges")
				Me.Oncuml_chargesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_incurred_ServiceDate", DbType:="Money NOT NULL")>  _
	Public Property cuml_incurred_ServiceDate() As Decimal
		Get
			Return Me._cuml_incurred_ServiceDate
		End Get
		Set
			If ((Me._cuml_incurred_ServiceDate = value)  _
						= false) Then
				Me.Oncuml_incurred_ServiceDateChanging(value)
				Me.SendPropertyChanging
				Me._cuml_incurred_ServiceDate = value
				Me.SendPropertyChanged("cuml_incurred_ServiceDate")
				Me.Oncuml_incurred_ServiceDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_incurred", DbType:="Money NOT NULL")>  _
	Public Property cuml_incurred() As Decimal
		Get
			Return Me._cuml_incurred
		End Get
		Set
			If ((Me._cuml_incurred = value)  _
						= false) Then
				Me.Oncuml_incurredChanging(value)
				Me.SendPropertyChanging
				Me._cuml_incurred = value
				Me.SendPropertyChanged("cuml_incurred")
				Me.Oncuml_incurredChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_ppodisc", DbType:="Money NOT NULL")>  _
	Public Property cuml_ppodisc() As Decimal
		Get
			Return Me._cuml_ppodisc
		End Get
		Set
			If ((Me._cuml_ppodisc = value)  _
						= false) Then
				Me.Oncuml_ppodiscChanging(value)
				Me.SendPropertyChanging
				Me._cuml_ppodisc = value
				Me.SendPropertyChanged("cuml_ppodisc")
				Me.Oncuml_ppodiscChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_coinsurance", DbType:="Money NOT NULL")>  _
	Public Property cuml_coinsurance() As Decimal
		Get
			Return Me._cuml_coinsurance
		End Get
		Set
			If ((Me._cuml_coinsurance = value)  _
						= false) Then
				Me.Oncuml_coinsuranceChanging(value)
				Me.SendPropertyChanging
				Me._cuml_coinsurance = value
				Me.SendPropertyChanged("cuml_coinsurance")
				Me.Oncuml_coinsuranceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_copay", DbType:="Money NOT NULL")>  _
	Public Property cuml_copay() As Decimal
		Get
			Return Me._cuml_copay
		End Get
		Set
			If ((Me._cuml_copay = value)  _
						= false) Then
				Me.Oncuml_copayChanging(value)
				Me.SendPropertyChanging
				Me._cuml_copay = value
				Me.SendPropertyChanged("cuml_copay")
				Me.Oncuml_copayChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_deductible", DbType:="Money NOT NULL")>  _
	Public Property cuml_deductible() As Decimal
		Get
			Return Me._cuml_deductible
		End Get
		Set
			If ((Me._cuml_deductible = value)  _
						= false) Then
				Me.Oncuml_deductibleChanging(value)
				Me.SendPropertyChanging
				Me._cuml_deductible = value
				Me.SendPropertyChanged("cuml_deductible")
				Me.Oncuml_deductibleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_excluded", DbType:="Money NOT NULL")>  _
	Public Property cuml_excluded() As Decimal
		Get
			Return Me._cuml_excluded
		End Get
		Set
			If ((Me._cuml_excluded = value)  _
						= false) Then
				Me.Oncuml_excludedChanging(value)
				Me.SendPropertyChanging
				Me._cuml_excluded = value
				Me.SendPropertyChanged("cuml_excluded")
				Me.Oncuml_excludedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_otherins", DbType:="Money NOT NULL")>  _
	Public Property cuml_otherins() As Decimal
		Get
			Return Me._cuml_otherins
		End Get
		Set
			If ((Me._cuml_otherins = value)  _
						= false) Then
				Me.Oncuml_otherinsChanging(value)
				Me.SendPropertyChanging
				Me._cuml_otherins = value
				Me.SendPropertyChanged("cuml_otherins")
				Me.Oncuml_otherinsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_cuml_paid", DbType:="Money NOT NULL")>  _
	Public Property cuml_paid() As Decimal
		Get
			Return Me._cuml_paid
		End Get
		Set
			If ((Me._cuml_paid = value)  _
						= false) Then
				Me.Oncuml_paidChanging(value)
				Me.SendPropertyChanging
				Me._cuml_paid = value
				Me.SendPropertyChanged("cuml_paid")
				Me.Oncuml_paidChanged
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
