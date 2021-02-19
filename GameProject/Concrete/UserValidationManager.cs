using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.BirthYear==1991 && gamer.FirstName=="Melek" && gamer.LastName == "Battal" && gamer.NationalityId==125)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
