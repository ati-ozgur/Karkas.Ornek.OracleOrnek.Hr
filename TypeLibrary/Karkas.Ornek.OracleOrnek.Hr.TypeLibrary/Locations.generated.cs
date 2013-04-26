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
	[DebuggerDisplay("LocationId = {LocationId}CountryId = {CountryId}")]
	public partial class 	Locations: BaseTypeLibrary
	{
		private decimal locationId;
		private string streetAddress;
		private string postalCode;
		private string city;
		private string stateProvince;
		private string countryId;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public decimal LocationId
		{
			[DebuggerStepThrough]
			get
			{
				return locationId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (locationId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				locationId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string StreetAddress
		{
			[DebuggerStepThrough]
			get
			{
				return streetAddress;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (streetAddress!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				streetAddress = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string PostalCode
		{
			[DebuggerStepThrough]
			get
			{
				return postalCode;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (postalCode!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				postalCode = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string City
		{
			[DebuggerStepThrough]
			get
			{
				return city;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (city!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				city = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string StateProvince
		{
			[DebuggerStepThrough]
			get
			{
				return stateProvince;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (stateProvince!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				stateProvince = value;
			}
		}

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
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string LocationIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return locationId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				LocationId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"LocationId",string.Format(CEVIRI_YAZISI,"LocationId","decimal")));
				}
			}
		}

		public Locations ShallowCopy()
		{
			Locations obj = new Locations();
			obj.locationId = locationId;
			obj.streetAddress = streetAddress;
			obj.postalCode = postalCode;
			obj.city = city;
			obj.stateProvince = stateProvince;
			obj.countryId = countryId;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "City"));		}
		public class PropertyIsimleri
		{
			public const string LocationId = "LOCATION_ID";
			public const string StreetAddress = "STREET_ADDRESS";
			public const string PostalCode = "POSTAL_CODE";
			public const string City = "CITY";
			public const string StateProvince = "STATE_PROVINCE";
			public const string CountryId = "COUNTRY_ID";
		}

	}
}
