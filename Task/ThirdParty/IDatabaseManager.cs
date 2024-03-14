using System.Collections.Generic;

namespace Task.ThirdParty
{
    public interface IDatabaseManager
    {
        IList<IDataSet> GetTableData(string tableName);
    }
}
