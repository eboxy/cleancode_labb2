using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace cleancode_labb2.Models
{
    
    
        public interface IApiRequestSend<T>
        {
            IEnumerable<T> GetAllData();

            void AddEntity(T entity);

            void ModifyEntity(int id, T entity);

            void DeleteEntity(T entity);
        }

    
}
