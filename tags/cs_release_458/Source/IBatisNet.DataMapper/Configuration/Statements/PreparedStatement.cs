
#region Apache Notice
/*****************************************************************************
 * $Header: $
 * $Revision: $
 * $Date: $
 * 
 * iBATIS.NET Data Mapper
 * Copyright (C) 2004 - Gilles Bayon
 *  
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 ********************************************************************************/
#endregion

using System;
using System.Collections;

namespace IBatisNet.DataMapper.Configuration.Statements
{
	/// <summary>
	/// Construct the list of IDataParameters for the statement
	/// and prepare the sql
	/// </summary>
	public class PreparedStatement
	{
		#region Fields

		private string _preparedSsql = string.Empty;
		private ArrayList _dbParametersName = new ArrayList();
		private ArrayList _dbParameters = new ArrayList();

		#endregion

		#region Properties
		/// <summary>
		/// The list of IDataParameter name used by the PreparedSql.
		/// </summary>
		public ArrayList DbParametersName
		{
			get { return _dbParametersName; }
		}

		/// <summary>
		/// The list of IDataParameter to use for the PreparedSql.
		/// </summary>
		public ArrayList DbParameters
		{
			get { return _dbParameters;}
		}

		/// <summary>
		/// The prepared statement.
		/// </summary>
		public string PreparedSql
		{
			get { return _preparedSsql; }
			set {_preparedSsql = value;}
		}

		#endregion
	}
}