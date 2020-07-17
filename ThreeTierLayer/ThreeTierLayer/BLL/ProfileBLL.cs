using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThreeTierLayer.DAL;

namespace ThreeTierLayer.BLL
{
    class ProfileBLL
    {
        public DataTable GetProfile()
        {
            try
            {
                ProfileDAL objDal = new ProfileDAL();
                return objDal.ReadProfile(); 
            }
            catch
            {
                throw;
            }
        }
    }
}
