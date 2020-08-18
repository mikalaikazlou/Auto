using System.Collections.Generic;

namespace Service
{
    interface IService
    {
        Car Details(int id);
        void Create(Car car);
        void Delete(int id);
        void Update(Car car);
    }
}