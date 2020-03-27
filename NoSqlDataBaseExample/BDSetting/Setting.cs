using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;


namespace NoSqlDataBaseExample.BDSetting
{
    public class Setting<T> : Isetting<T> where T:class
    {
        public T Add (T item, string  Name)
        {

            using (LiteDatabase db = new LiteDatabase(@"MyData.db"))
            {
                // Get user collection
                var entity = db.GetCollection<T>(Name.ToString());

                entity.Insert(item);

                return item;
            }
        }

        public List<T> GetAll( string Name)
        {

            using (LiteDatabase db = new LiteDatabase(@"MyData.db"))
            {
                // Get user collection
                var entity = db.GetCollection<T>(Name.ToString()).FindAll().ToList();

                return entity;
            }
        }
    }
}

