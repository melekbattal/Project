using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IPlayerService
    {
        void Login(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
