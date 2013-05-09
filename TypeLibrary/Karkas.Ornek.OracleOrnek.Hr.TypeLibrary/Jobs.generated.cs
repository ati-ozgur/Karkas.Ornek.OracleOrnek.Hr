﻿using System;
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
	[DebuggerDisplay("JobId = {JobId}")]
	public partial class 	Jobs: BaseTypeLibrary
	{
		private string jobId;
		private string jobTitle;
		private Nullable<decimal> minSalary;
		private Nullable<decimal> maxSalary;

		[Key]
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

		[StringLength(35)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string JobTitle
		{
			[DebuggerStepThrough]
			get
			{
				return jobTitle;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (jobTitle!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				jobTitle = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> MinSalary
		{
			[DebuggerStepThrough]
			get
			{
				return minSalary;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (minSalary!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				minSalary = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> MaxSalary
		{
			[DebuggerStepThrough]
			get
			{
				return maxSalary;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (maxSalary!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				maxSalary = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string MinSalaryAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return minSalary != null ? minSalary.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				MinSalary = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"MinSalary",string.Format(CEVIRI_YAZISI,"MinSalary","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string MaxSalaryAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return maxSalary != null ? maxSalary.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				MaxSalary = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"MaxSalary",string.Format(CEVIRI_YAZISI,"MaxSalary","decimal")));
				}
			}
		}

		public Jobs ShallowCopy()
		{
			Jobs obj = new Jobs();
			obj.jobId = jobId;
			obj.jobTitle = jobTitle;
			obj.minSalary = minSalary;
			obj.maxSalary = maxSalary;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "JobTitle"));		}
		public class PropertyIsimleri
		{
			public const string JobId = "JOB_ID";
			public const string JobTitle = "JOB_TITLE";
			public const string MinSalary = "MIN_SALARY";
			public const string MaxSalary = "MAX_SALARY";
		}

	}
}
