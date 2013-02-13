using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using MBSBusinessEntities;

namespace MBSBLC
{
   public class BLC
   {
       #region Cinema

       CinemaBE cinemabe;

       public bool AddCinema(string CinemaID, string CinemaName, string Location, string NumOfScreens, string IsDeleted)
        {

                CinemaBE cinemabe = new CinemaBE(Convert.ToInt32(CinemaID), CinemaName, Location, Convert.ToInt32(NumOfScreens), IsDeleted);
               
                return cinemabe.Add();
           
         }


       public bool GetCinemaByID(string CinemaID)
       {
           cinemabe = new CinemaBE();
        
           cinemabe =cinemabe.GetCinemaByID(Convert.ToInt32(CinemaID));
            return true;
       }



       public string CinemaID(string CinemaID) { GetCinemaByID(CinemaID); return cinemabe.CinemaID.ToString(); }
       public string CinemaName(string CinemaID) { GetCinemaByID(CinemaID); return cinemabe.CinemaName.ToString(); }
       public string CinemaLocation(string CinemaID) { GetCinemaByID(CinemaID); return cinemabe.Location.ToString(); }
       public string NumOfScreens(string CinemaID) { GetCinemaByID(CinemaID); return cinemabe.NumOfScreens.ToString(); }
       public string CinemaIsDeleted(string CinemaID) { GetCinemaByID(CinemaID); return cinemabe.IsDeleted.ToString(); }
       
           


       #endregion

       #region Screen

       #endregion

       #region Booking

       #endregion

       #region Food

       #endregion

       #region FoodOrder

       #endregion

       #region Movie

       #endregion

       #region MovieSchedule

       #endregion
              
       #region ShowTime

       #endregion

       #region User

       #endregion

   }
}
