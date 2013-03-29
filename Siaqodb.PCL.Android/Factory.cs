using System;
using System.Collections.Generic;
using Sqo;

#if WP8
namespace Siaqodb.PCL.WP8
#elif SILVERLIGHT
namespace Siaqodb.PCL.Silverlight
#elif WINDOWS_PHONE
namespace Siaqodb.PCL.WP71
#elif NETFX_CORE
namespace Siaqodb.PCL.WinRT
#elif ANDROID
namespace Siaqodb.PCL.Android
#elif NET40
namespace Siaqodb.PCL.NET40
#elif iOS
namespace Siaqodb.PCL.iOS
#endif
{
    public class Factory : Portable.IFactory
    {
        public override object GetInstance(string databasePath, string trialLicense)
        {
            if (_instance == null)
            {
                if (!string.IsNullOrEmpty(trialLicense))
                    SiaqodbConfigurator.SetTrialLicense(trialLicense);

#if NETFX_CORE
                _instance = new Sqo.Siaqodb();
#else
                _instance = new Sqo.Siaqodb(databasePath);
#endif
            }
            return _instance;
        }

        public override void StoreObject(object obj)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).StoreObject(obj);
        }

        public override void Delete(object obj)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).Delete(obj);
        }

        public override int Count<T>()
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).Count<T>().Result;
#else
            return ((Sqo.Siaqodb)_instance).Count<T>();
#endif
        }

        public override bool DeleteObjectBy(Dictionary<string, object> criteria)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).DeleteObjectBy(criteria).Result;
#else
            return ((Sqo.Siaqodb)_instance).DeleteObjectBy(criteria);
#endif
        }

        public override bool DeleteObjectBy(object obj, params string[] fieldNames)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).DeleteObjectBy(obj, fieldNames).Result;
#else
            return ((Sqo.Siaqodb)_instance).DeleteObjectBy(obj, fieldNames);
#endif
        }

        public override bool DeleteObjectBy(string fieldName, object obj)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).DeleteObjectBy(fieldName, obj).Result;
#else
            return ((Sqo.Siaqodb)_instance).DeleteObjectBy(fieldName, obj);
#endif
        }

        public override int DeleteObjectBy<T>(Dictionary<string, object> criteria)
        {
#if NETFX_CORE
            throw new NotImplementedException();
#else
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            return ((Sqo.Siaqodb)_instance).DeleteObjectBy<T>(criteria);
#endif
        }

        public override void DropType(Type type)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).DropType(type);
        }

        public override void DropType(Type type, bool claimFreespace)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).DropType(type, claimFreespace);
        }

        public override void DropType<T>()
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).DropType<T>();
        }

        public override void StartBulkInsert(params Type[] types)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).StartBulkInsert(types);
        }

        public override void EndBulkInsert(params Type[] types)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            ((Sqo.Siaqodb)_instance).EndBulkInsert(types);
        }

       public override string GetDBPath()
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).GetDBPath().Path;
#else
            return ((Sqo.Siaqodb)_instance).GetDBPath();
#endif
        }

        public override int GetOID(object obj)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

            return ((Sqo.Siaqodb)_instance).GetOID(obj);
        }

        public override bool UpdateObjectBy(object obj, params string[] fieldNames)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).UpdateObjectBy(obj, fieldNames).Result;
#else
            return ((Sqo.Siaqodb)_instance).UpdateObjectBy(obj, fieldNames);
#endif
        }

        public override bool UpdateObjectBy(string fieldName, object obj)
        {
            if (_instance == null)
                throw new NullReferenceException("Database not configured. Call GetInstance first.");

#if NETFX_CORE
            return ((Sqo.Siaqodb)_instance).UpdateObjectBy(fieldName, obj).Result;
#else
            return ((Sqo.Siaqodb)_instance).UpdateObjectBy(fieldName, obj);
#endif
        }
    }
}
