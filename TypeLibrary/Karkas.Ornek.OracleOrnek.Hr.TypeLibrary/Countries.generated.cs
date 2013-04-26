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
	[DebuggerDisplay("CountryId = {CountryId}RegionId = {RegionId}")]
	public partial class 	Countries: BaseTypeLibrary
	{
		private string countryId;
		private string countryName;
		private Nullable<decimal> regionId;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CountryId
		{
			[DebuggerStepThrough]
			get
			{
				return countryId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (countryId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				countryId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CountryName
		{
			[DebuggerStepThrough]
			get
			{
				return countryName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (countryName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				countryName = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> RegionId
		{
			[DebuggerStepThrough]
			get
			{
				return regionId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (regionId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				regionId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string RegionIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return regionId != null ? regionId.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				RegionId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"RegionId",string.Format(CEVIRI_YAZISI,"RegionId","decimal")));
				}
			}
		}

		public Countries ShallowCopy()
		{
			Countries obj = new Countries();
			obj.countryId = countryId;
			obj.countryName = countryName;
			obj.regionId = regionId;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string CountryId = "COUNTRY_ID";
			public const string CountryName = "COUNTRY_NAME";
			public const string RegionId = "REGION_ID";
		}

	}
}
