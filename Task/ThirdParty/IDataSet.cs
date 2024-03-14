using System.Collections.Generic;

namespace Task.ThirdParty
{
    public interface IDataSet
    {
        void Put(string columnName, object value);

        IList<string> GetColumnNames();

        IList<object> GetValues();
    }
}
