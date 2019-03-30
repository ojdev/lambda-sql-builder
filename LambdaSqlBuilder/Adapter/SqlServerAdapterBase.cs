/* License: http://www.apache.org/licenses/LICENSE-2.0 */


namespace LambdaSqlBuilder.Adapter
{
    /// <summary>
    /// Provides functionality common to all supported SQL Server versions
    /// </summary>
    class SqlServerAdapterBase : SqlAdapterBase
    {


        public string Table(string tableName)
        {
            return string.Format("{0}", tableName);
        }

        public string Field(string tableName, string fieldName)
        {
            return string.Format("{0}", fieldName);
        }

        public string Parameter(string parameterId)
        {
            return "@" + parameterId;
        }
    }
}
