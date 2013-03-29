using System;
using System.Collections.Generic;

namespace Siaqodb.PCL.Portable
{
    public abstract class IFactory
    {
        public object _instance;
        public abstract object GetInstance(string databasePath, string trialLicense);

        //public abstract void Open();
        //public abstract void Close();

        public abstract void StoreObject(object obj);
        //public abstract void StoreObject(object obj, dynamic sqoTransaction);

        public abstract void Delete(object obj);
        //public abstract void Delete(object obj, dynamic sqoTransaction);

        public abstract int Count<T>();

        public abstract bool DeleteObjectBy(Dictionary<string, object> criteria);
        public abstract bool DeleteObjectBy(object obj, params string[] fieldNames);
        //public abstract bool DeleteObjectBy(object obj, dynamic sqoTransaction, params string[] fieldNames);
        public abstract bool DeleteObjectBy(string fieldName, object obj);

        public abstract int DeleteObjectBy<T>(Dictionary<string, object> criteria);

        public abstract void DropType(Type type);
        public abstract void DropType(Type type, bool claimFreespace);

        public abstract void DropType<T>();

        public abstract void StartBulkInsert(params Type[] types);
        public abstract void EndBulkInsert(params Type[] types);

        //public abstract void Flush();

        //public abstract IList<Sqo.MetaType> GetAllTypes();

        public abstract string GetDBPath();

        public abstract int GetOID(object obj);

        //public abstract IObjectList<T> LoadAll<T>();

        public abstract bool UpdateObjectBy(object obj, params string[] fieldNames);
        //public abstract bool UpdateObjectBy(object obj, dynamic sqoTransaction, params string[] fieldNames);
        public abstract bool UpdateObjectBy(string fieldName, object obj);
    }
}
