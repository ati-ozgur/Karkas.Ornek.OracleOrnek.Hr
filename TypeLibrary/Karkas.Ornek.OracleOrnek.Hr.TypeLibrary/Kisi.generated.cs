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
	[DebuggerDisplay("")]
	public partial class 	Kisi: BaseTypeLibrary
	{
		private Nullable<decimal> kisikey;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> Kisikey
		{
			[DebuggerStepThrough]
			get
			{
				return kisikey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (kisikey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				kisikey = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string KisikeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return kisikey != null ? kisikey.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				Kisikey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Kisikey",string.Format(CEVIRI_YAZISI,"Kisikey","decimal")));
				}
			}
		}

		public Kisi ShallowCopy()
		{
			Kisi obj = new Kisi();
			obj.kisikey = kisikey;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string Kisikey = "KISIKEY";
		}

	}
}
