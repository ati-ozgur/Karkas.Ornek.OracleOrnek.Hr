﻿
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
	public partial class DepartmentsBs : BaseBs<Departments, DepartmentsDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "";
			}
		}
		public void Sil(decimal pDepartmentId)
		{
			dal.Sil( pDepartmentId);
		}
		public Departments SorgulaDEPARTMENT_IDIle(decimal p1)
		{
			return dal.SorgulaDEPARTMENT_IDIle(p1);
		}
	}
}
