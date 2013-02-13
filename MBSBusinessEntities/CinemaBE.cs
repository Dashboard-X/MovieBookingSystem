using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MBSDAL;

namespace MBSBusinessEntities
{
   public class CinemaBE
   {

        public CinemaBE()
       {
         mbs = new MBS_Entities();
       }

       public CinemaBE(int CinemaID, string CinemaName, string Location, int NumOfScreens, string IsDeleted)
       {
           this.CinemaID = CinemaID;
           this.CinemaName = CinemaName;
           this.Location = Location;
           this.NumOfScreens = NumOfScreens;
           this.IsDeleted = IsDeleted;

           mbs = new MBS_Entities();
       }


       #region ClassVariables

       private MBS_Entities mbs;

       private int cinemaID;
             
       private string cinemaName;

       private string location;

       private int numOfScreens;

       private string isDeleted;
            
       #endregion


       #region Properties

       public int CinemaID
       {
           get { return cinemaID; }
           set { cinemaID = value; }
       }

       public string CinemaName
       {
           get { return cinemaName; }
           set { cinemaName = value; }
       }

       public string Location
       {
           get { return location; }
           set { location = value; }
       }

       public int NumOfScreens
       {
           get { return numOfScreens; }
           set { numOfScreens = value; }
       }

       public string IsDeleted
       {
           get { return isDeleted; }
           set { isDeleted = value; }
       }
       #endregion


       #region Methods

       public bool Add()
       {

           Cinema cinema = new Cinema();
           cinema.CinemaID = this.CinemaID;
           cinema.CinemaName = this.CinemaName;
           cinema.Location = this.Location;
           cinema.NumOfScreens = this.NumOfScreens;
           cinema.IsDeleted = this.IsDeleted;
           mbs.AddToCinemas(cinema);
           mbs.SaveChanges();

           return true;
       }

       public bool Delete()
       {

           Cinema cinema = new Cinema();
           cinema.CinemaID = this.CinemaID;
           cinema.CinemaName = this.CinemaName;
           cinema.Location = this.Location;
           cinema.NumOfScreens = this.NumOfScreens;
           cinema.IsDeleted = "true";
           mbs.AddToCinemas(cinema);
           mbs.SaveChanges();

           return true;
       }

       private CinemaBE ConvertDALToBusinessEntity(Cinema cinemaDAL)
       {

           CinemaBE cinemabe = new CinemaBE();

           cinemabe.CinemaID = cinemaDAL.CinemaID;
           cinemabe.CinemaName = cinemaDAL.CinemaName;
           cinemabe.Location = cinemaDAL.Location;
           cinemabe.NumOfScreens =Convert.ToInt32(cinemaDAL.NumOfScreens);
           cinemabe.IsDeleted = cinemaDAL.IsDeleted;

           return cinemabe;
       }


       private List<Cinema> GetAllDALCinemas()
       {
           return mbs.Cinemas.ToList();
       }
       
       public List<CinemaBE> GetAllCinemas()
       {

           List<Cinema> dalcinemalist = GetAllDALCinemas();
           List<CinemaBE> cinemalist = new List<CinemaBE>();

           foreach (Cinema dalcimema in dalcinemalist)
           {
               CinemaBE cinemabe = ConvertDALToBusinessEntity(dalcimema);
               cinemalist.Add(cinemabe);
           }

           return cinemalist;

       }

       public CinemaBE GetCinemaByID(int CinemaID)
       {
           CinemaBE cinemabe=new CinemaBE();
           Cinema cinema = GetCinemaDALByID(CinemaID);
           cinemabe = ConvertDALToBusinessEntity(cinema);
           return cinemabe;
       }


       private Cinema GetCinemaDALByID(int CinemaID)
       {
           Cinema cinemaDAL = new Cinema();
           cinemaDAL = mbs.Cinemas.First(x => x.CinemaID == CinemaID);

           return cinemaDAL;
        
       }

       #endregion




   }
}
