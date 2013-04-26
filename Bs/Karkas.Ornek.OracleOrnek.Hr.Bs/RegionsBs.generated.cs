
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary.Hr;
using Karkas.Ornek.OracleOrnek.Hr.Dal.Hr;


namespace Karkas.Ornek.OracleOrnek.Hr.Bs.Hr
{
	public partial class RegionsBs : BaseBs<Regions, RegionsDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Karkas.Ornek.OracleOrnek.Hr";
			}
		}
		public void Sil(decimal pRegionId)
		{
			dal.Sil( pRegionId);
		}
		public Regions SorgulaREGION_IDIle(decimal p1)
		{
			return dal.SorgulaREGION_IDIle(p1);
		}
	}
}
