﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary.Hr;


namespace Karkas.Ornek.OracleOrnek.Hr.Dal.Hr
{
public partial class EmployeesDal : BaseDal<Employees>
{
	
	public override string DatabaseName
	{
		get
		{
			return "OracleHr";
		}
	}
	protected override void identityKolonDegeriniSetle(Employees pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM EMPLOYEES";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT EMPLOYEE_ID,FIRST_NAME,LAST_NAME,EMAIL,PHONE_NUMBER,HIRE_DATE,JOB_ID,SALARY,COMMISSION_PCT,MANAGER_ID,DEPARTMENT_ID FROM EMPLOYEES";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM EMPLOYEES WHERE EMPLOYEE_ID = :EMPLOYEE_ID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE EMPLOYEES
			 SET 
			FIRST_NAME = :FIRST_NAME
,LAST_NAME = :LAST_NAME
,EMAIL = :EMAIL
,PHONE_NUMBER = :PHONE_NUMBER
,HIRE_DATE = :HIRE_DATE
,JOB_ID = :JOB_ID
,SALARY = :SALARY
,COMMISSION_PCT = :COMMISSION_PCT
,MANAGER_ID = :MANAGER_ID
,DEPARTMENT_ID = :DEPARTMENT_ID
			
			WHERE 
			 EMPLOYEE_ID = :EMPLOYEE_ID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO EMPLOYEES 
			 (EMPLOYEE_ID,FIRST_NAME,LAST_NAME,EMAIL,PHONE_NUMBER,HIRE_DATE,JOB_ID,SALARY,COMMISSION_PCT,MANAGER_ID,DEPARTMENT_ID) 
			 VALUES 
						(:EMPLOYEE_ID,:FIRST_NAME,:LAST_NAME,:EMAIL,:PHONE_NUMBER,:HIRE_DATE,:JOB_ID,:SALARY,:COMMISSION_PCT,:MANAGER_ID,:DEPARTMENT_ID)";
		}
	}
	public Employees SorgulaEmployeeIdIle(decimal p1)
	{
		List<Employees> liste = new List<Employees>();
		SorguCalistir(liste,String.Format(" EMPLOYEE_ID = '{0}'", p1));		
		if (liste.Count > 0)
		{
			return liste[0];
		}
		else
		{
			return null;
		}
	}
	
	protected override bool IdentityVarMi
	{
		get
		{
			return false;
		}
	}
	
	protected override bool PkGuidMi
	{
		get
		{
			return false;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "EMPLOYEE_ID";
		}
	}
	
	public virtual void Sil(decimal EmployeeId)
	{
		Employees row = new Employees();
		row.EmployeeId = EmployeeId;
		base.Sil(row);
	}
	protected override void ProcessRow(IDataReader dr, Employees row)
	{
		row.EmployeeId = dr.GetDecimal(0);
		if (!dr.IsDBNull(1))
		{
			row.FirstName = dr.GetString(1);
		}
		row.LastName = dr.GetString(2);
		row.Email = dr.GetString(3);
		if (!dr.IsDBNull(4))
		{
			row.PhoneNumber = dr.GetString(4);
		}
		row.HireDate = dr.GetDateTime(5);
		row.JobId = dr.GetString(6);
		if (!dr.IsDBNull(7))
		{
			row.Salary = dr.GetDecimal(7);
		}
		if (!dr.IsDBNull(8))
		{
			row.CommissionPct = dr.GetDecimal(8);
		}
		if (!dr.IsDBNull(9))
		{
			row.ManagerId = dr.GetDecimal(9);
		}
		if (!dr.IsDBNull(10))
		{
			row.DepartmentId = dr.GetDecimal(10);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Employees row)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle(":EMPLOYEE_ID",DbType.Decimal, row.EmployeeId);
		builder.parameterEkle(":FIRST_NAME",DbType.String, row.FirstName,20);
		builder.parameterEkle(":LAST_NAME",DbType.String, row.LastName,25);
		builder.parameterEkle(":EMAIL",DbType.String, row.Email,25);
		builder.parameterEkle(":PHONE_NUMBER",DbType.String, row.PhoneNumber,20);
		builder.parameterEkle(":HIRE_DATE",DbType.String, row.HireDate);
		builder.parameterEkle(":JOB_ID",DbType.String, row.JobId,10);
		builder.parameterEkle(":SALARY",DbType.Decimal, row.Salary);
		builder.parameterEkle(":COMMISSION_PCT",DbType.Decimal, row.CommissionPct);
		builder.parameterEkle(":MANAGER_ID",DbType.Decimal, row.ManagerId);
		builder.parameterEkle(":DEPARTMENT_ID",DbType.Decimal, row.DepartmentId);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Employees	 row)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle(":EMPLOYEE_ID",DbType.Decimal, row.EmployeeId);
		builder.parameterEkle(":FIRST_NAME",DbType.String, row.FirstName,20);
		builder.parameterEkle(":LAST_NAME",DbType.String, row.LastName,25);
		builder.parameterEkle(":EMAIL",DbType.String, row.Email,25);
		builder.parameterEkle(":PHONE_NUMBER",DbType.String, row.PhoneNumber,20);
		builder.parameterEkle(":HIRE_DATE",DbType.String, row.HireDate);
		builder.parameterEkle(":JOB_ID",DbType.String, row.JobId,10);
		builder.parameterEkle(":SALARY",DbType.Decimal, row.Salary);
		builder.parameterEkle(":COMMISSION_PCT",DbType.Decimal, row.CommissionPct);
		builder.parameterEkle(":MANAGER_ID",DbType.Decimal, row.ManagerId);
		builder.parameterEkle(":DEPARTMENT_ID",DbType.Decimal, row.DepartmentId);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Employees	 row)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle(":EMPLOYEE_ID",DbType.Decimal, row.EmployeeId);
	}
	public override string DbProviderName
	{
		get
		{
			return "Oracle.DataAccess.Client";
		}
	}
}
}
