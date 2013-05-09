using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using Karkas.Core.Onaylama;
using Karkas.Core.Onaylama.ForPonos;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Ornek.OracleOrnek.Hr.TypeLibrary.Hr
{
	[Serializable]
	[DebuggerDisplay("EmployeeId = {EmployeeId}JobId = {JobId}ManagerId = {ManagerId}DepartmentId = {DepartmentId}")]
	public partial class 	Employees: BaseTypeLibrary
	{
		private decimal employeeId;
		private string firstName;
		private string lastName;
		private string email;
		private string phoneNumber;
		private DateTime hireDate;
		private string jobId;
		private Nullable<decimal> salary;
		private Nullable<decimal> commissionPct;
		private Nullable<decimal> managerId;
		private Nullable<decimal> departmentId;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public decimal EmployeeId
		{
			[DebuggerStepThrough]
			get
			{
				return employeeId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (employeeId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				employeeId = value;
			}
		}

		[StringLength(20)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string FirstName
		{
			[DebuggerStepThrough]
			get
			{
				return firstName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (firstName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				firstName = value;
			}
		}

		[StringLength(25)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string LastName
		{
			[DebuggerStepThrough]
			get
			{
				return lastName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (lastName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				lastName = value;
			}
		}

		[StringLength(25)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Email
		{
			[DebuggerStepThrough]
			get
			{
				return email;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (email!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				email = value;
			}
		}

		[StringLength(20)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string PhoneNumber
		{
			[DebuggerStepThrough]
			get
			{
				return phoneNumber;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (phoneNumber!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				phoneNumber = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public DateTime HireDate
		{
			[DebuggerStepThrough]
			get
			{
				return hireDate;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (hireDate!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				hireDate = value;
			}
		}

		[StringLength(10)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string JobId
		{
			[DebuggerStepThrough]
			get
			{
				return jobId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (jobId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				jobId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> Salary
		{
			[DebuggerStepThrough]
			get
			{
				return salary;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (salary!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				salary = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> CommissionPct
		{
			[DebuggerStepThrough]
			get
			{
				return commissionPct;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (commissionPct!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				commissionPct = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> ManagerId
		{
			[DebuggerStepThrough]
			get
			{
				return managerId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (managerId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				managerId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> DepartmentId
		{
			[DebuggerStepThrough]
			get
			{
				return departmentId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (departmentId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				departmentId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string EmployeeIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return employeeId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				EmployeeId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"EmployeeId",string.Format(CEVIRI_YAZISI,"EmployeeId","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string HireDateAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return hireDate.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					DateTime _a = Convert.ToDateTime(value);
				HireDate = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"HireDate",string.Format(CEVIRI_YAZISI,"HireDate","DateTime")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SalaryAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return salary != null ? salary.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				Salary = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Salary",string.Format(CEVIRI_YAZISI,"Salary","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string CommissionPctAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return commissionPct != null ? commissionPct.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				CommissionPct = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"CommissionPct",string.Format(CEVIRI_YAZISI,"CommissionPct","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string ManagerIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return managerId != null ? managerId.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				ManagerId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"ManagerId",string.Format(CEVIRI_YAZISI,"ManagerId","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DepartmentIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return departmentId != null ? departmentId.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				DepartmentId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"DepartmentId",string.Format(CEVIRI_YAZISI,"DepartmentId","decimal")));
				}
			}
		}

		public Employees ShallowCopy()
		{
			Employees obj = new Employees();
			obj.employeeId = employeeId;
			obj.firstName = firstName;
			obj.lastName = lastName;
			obj.email = email;
			obj.phoneNumber = phoneNumber;
			obj.hireDate = hireDate;
			obj.jobId = jobId;
			obj.salary = salary;
			obj.commissionPct = commissionPct;
			obj.managerId = managerId;
			obj.departmentId = departmentId;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "LastName"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Email"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "HireDate"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "JobId"));		}
		public class PropertyIsimleri
		{
			public const string EmployeeId = "EMPLOYEE_ID";
			public const string FirstName = "FIRST_NAME";
			public const string LastName = "LAST_NAME";
			public const string Email = "EMAIL";
			public const string PhoneNumber = "PHONE_NUMBER";
			public const string HireDate = "HIRE_DATE";
			public const string JobId = "JOB_ID";
			public const string Salary = "SALARY";
			public const string CommissionPct = "COMMISSION_PCT";
			public const string ManagerId = "MANAGER_ID";
			public const string DepartmentId = "DEPARTMENT_ID";
		}

	}
}
