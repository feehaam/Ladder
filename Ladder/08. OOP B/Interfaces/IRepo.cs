using System;
namespace OOPB
{
    internal interface IRepo
    {
        public void Create(Object obj);
        public Object Read(int id);
        public void Update(int id, Object obj);
        public void Delete(int id);
        
    }
}
