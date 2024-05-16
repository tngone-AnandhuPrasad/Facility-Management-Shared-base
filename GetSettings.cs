using TNG.Shared.Lib.Intefaces;
using System.Data;
using MongoDB.Driver;

namespace TNG.Shared.Lib
{

    public class GetSettings
    {
        /// <summary>
        /// DB Context 
        /// </summary>
        /// <value></value>
        private IMongoLayer _db { get; set; }


        public GetSettings(IMongoLayer db)
        {
    
            this._db = db;
        }




    }
}