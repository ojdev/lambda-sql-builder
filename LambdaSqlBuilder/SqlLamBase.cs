﻿/* License: http://www.apache.org/licenses/LICENSE-2.0 */

using LambdaSqlBuilder.Adapter;
using LambdaSqlBuilder.Builder;
using LambdaSqlBuilder.Resolver;
using LambdaSqlBuilder.ValueObjects;
using System;
using System.Collections.Generic;

namespace LambdaSqlBuilder
{
    /// <summary>
    /// Base functionality for the SqlLam class that is not related to any specific entity type
    /// </summary>
    public abstract class SqlLamBase
    {
        internal static ISqlAdapter _defaultAdapter = new SqlServer2012Adapter();
        internal SqlQueryBuilder _builder;
        internal LambdaResolver _resolver;

        public SqlQueryBuilder SqlBuilder { get { return _builder; } }


        public string QueryStringPage(int pageSize, int? pageNumber = null)
        {
            return _builder.QueryStringPage(pageSize, pageNumber);
        }

        public IDictionary<string, object> QueryParameters
        {
            get { return _builder.Parameters; }
        }

        public string[] SplitColumns
        {
            get { return _builder.SplitColumns.ToArray(); }
        }

        public static void SetAdapter(SqlAdapter adapter)
        {
            _defaultAdapter = GetAdapterInstance(adapter);
        }

        private static ISqlAdapter GetAdapterInstance(SqlAdapter adapter)
        {
            switch (adapter)
            {
                case SqlAdapter.SqlServer2008:
                    return new SqlServer2008Adapter();
                case SqlAdapter.SqlServer2012:
                    return new SqlServer2012Adapter();
                default:
                    throw new ArgumentException("The specified Sql Adapter was not recognized");
            }
        }
    }
}
