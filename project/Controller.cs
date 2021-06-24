using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace project
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
       

      

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int InsertPlane(int Serial,string Status,string Model,int ECapacity,int FCap)
        {

            string QUery = "INSERT INTO plane(Snumber,Model,ECap,FCap,Status)" +
                "values (" + Serial + ",'" + Model + "'," + ECapacity + ","+FCap+",'" + Status + "');";
            return dbMan.ExecuteNonQuery(QUery);

        }



        public int InsertFlight(int StuffNumber,int Source,int Destenation,string FlightStatus,int FlightNumber,int PassNumber)
        {
            string QUery = "INSERT INTO flight(Flightno,NoPassengers,DestCode ,SourceCode ,NoStaff ,Fstatus)" +
                "values (" + FlightNumber + "," + PassNumber + "," + Destenation + "," + Source +","+StuffNumber+",'"
                +FlightStatus +"');";
            return dbMan.ExecuteNonQuery(QUery);


        }

        //////////////////////////////////using procedure/////////////////////////////////////////////////
        public int InsertAirport(int code,int NoOFPlanes,string country,string ANAme)
        {
            //string QUery = "INSERT INTO airport(NoPlanes ,LocationCountry ,AirportCode ,AirportName )" +
            //    "values (" + NoOFPlanes + ",'" + country + "'," + code + ",'"+ANAme +  "');";

            //return dbMan.ExecuteNonQuery(QUery);
            string proc = StoredProc.insertairport;
            Dictionary<string, object> par = new Dictionary<string, object>();
            par.Add("@ACode", code);
            par.Add("@NoPlanes", NoOFPlanes);
            par.Add("@AName", ANAme);
            par.Add("@CName", country);
            

            return dbMan.ExecuteNonQuery(proc, par);

        }

        //////////////////////////////////using procedure/////////////////////////////////////////////////
        public int InsertFlight_Crew(string Fname,string LName,int ID,string Address,string Password,string Role)
        {

            //string QUery = "INSERT INTO FlightCrew(CrewID ,Pass ,Fname ,Lname ,Address ,Role )" +
            //    "values (" + ID + ",'" + Password + "','" + Fname + "','" + LName +"','"+ Address+"','" +Role + "');";
           
            string proc = StoredProc.insertflightcrew;
            Dictionary<string, object> par = new Dictionary<string, object>();
            par.Add("@CrCode", ID);
            par.Add("@FName", Fname);
            par.Add("@LName", LName);
            par.Add("@Pass", Password);
            par.Add("@Addr", Address);
            par.Add("@role", Role);

            return dbMan.ExecuteNonQuery(proc,par);


        }

        public int InsertEmployee(string Fname, string LName, int ID, string Address, string Password, int Hours)
        {
            string QUery = "INSERT INTO Employee(EmpID ,Pass ,Fname ,Lname ,Address ,WeeklyHours )" +
                "values (" + ID + ",'" + Password + "','" + Fname + "','" + LName + "','" + Address + "'," + Hours + ");";

            return dbMan.ExecuteNonQuery(QUery);
        }
          
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public DataTable SelectPlaneBySerial(int Serial)
        {
            string query = "SELECT * FROM plane WHERE Snumber="+Serial+";";
            return dbMan.ExecuteReader(query);

        }
        public DataTable SelectFlyByNumb(int Numb)
        {
            string query = "SELECT * FROM Flight WHERE Flightno=" + Numb + ";";
            return dbMan.ExecuteReader(query);

        }
        public int UpdatePlaneStatus(int serial,string status)
        {
            string query = "UPDATE plane SET Status='" + status + "'  WHERE Snumber=" + serial + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        //////////////////////////ModifyFlight///////////////////////////////////////////////////////////////////
        ///
        public DataTable GetAllAirport()
        {
            string query = "SELECT * FROM Airport";
            return dbMan.ExecuteReader(query);


        }
        public DataTable GetAllClients()
        {
            string query = "SELECT * FROM Client";
            return dbMan.ExecuteReader(query);


        }
        public DataTable getidflights()
        {
            string s = "select Flightno from Flight";
           return  dbMan.ExecuteReader(s);

        }
        public DataTable GetAllFlights()///////using procedure
        {
            //string query = "SELECT * FROM Flight";
            //return dbMan.ExecuteReader(query);
            string proc = StoredProc.selectallflight;
            return dbMan.ExecuteReader(proc,null);


        }
        
        public int UpdateFlightPassNo(int Numb, int pass)
        {
            string query = "UPDATE Flight SET NoPassengers=" + pass + "  WHERE FlightNo=" + Numb + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateFlightStatus(int Numb, string status)
        {
            string query = "UPDATE Flight SET Fstatus='" + status + "'  WHERE FlightNo=" + Numb + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateFlightDest(int Numb, int dest)
        {
            string query = "UPDATE Flight SET DestCode=" + dest + "  WHERE FlightNo=" + Numb + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateFlightSource(int Numb, int dest)
        {
            string query = "UPDATE Flight SET SourceCode=" + dest + "  WHERE FlightNo=" + Numb + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateFlightNoStaff(int Numb, int dest)
        {
            string query = "UPDATE Flight SET NoStaff=" + dest + "  WHERE FlightNo=" + Numb + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateFlightNo(int Numb, int dest)
        {
            string query = "UPDATE Flight SET FlightNo=" + dest + "  WHERE FlightNo=" + Numb + ";";
            return dbMan.ExecuteNonQuery(query);

        }

        public int DeleteFlight(int Numb) // using procedure
        {
        //    string query = "DELETE Flight  WHERE FlightNo=" + Numb + ";";
        //    return dbMan.ExecuteNonQuery(query);

             string proc = StoredProc.deleteflight;
                Dictionary<string, object> par = new Dictionary<string, object>();
               par.Add("@FNum", Numb);
           

            return dbMan.ExecuteNonQuery(proc, par);

        }
        //////////////////////////////////GetClient//////////////////////////////////////////////////////////
        /// <summary>
        public DataTable SelectClient(int id)
        {
            string query = "SELECT * FROM Client WHERE ClientID="+id+";";
            return dbMan.ExecuteReader(query);
        }
        public object getBanStatus(int id)
        {
            string query = "SELECT BanSTatus FROM Client WHERE ClientID=" + id + ";";
            return dbMan.ExecuteScalar(query);

        }
        public int UpdateBan(int id,int status)
        {
            string query = "UPDATE Client SET BanStatus= "+status+"WHERE ClientID=" + id + ";";
            return dbMan.ExecuteNonQuery(query);

        }
    ////////////////////////////GetReviewById////////////////////////////////////////////////////////////
    public DataTable GetReviewById(int id)
        {
            string query = "SELECT * FROM Review where FlightNo=" + id + ";";
            return dbMan.ExecuteReader(query);


        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///




        //signup
        /// <summary>
        /// //
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="nationality"></param>
        /// <returns></returns>
        public int InsertClient(string email, string pass, string fname, string lname, string gender, string address, string nationality)
        {
            string query = "INSERT INTO Client (Email, Pass, Fname,Lname,Gender,Address,Nationality,BanStatus)" +
                            "Values ('" + email + "','" + pass + "','" + fname + "','" + lname + "','" + gender + "','" + address + "','" + nationality + "','" + 0 + "');";
            MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        /// <summary>
        /// ////
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public DataTable viewCliendID(string email, string pass)
        {
            string query = "SELECT ClientID FROM Client WHERE Email='" + email + "' and Pass='" + pass + "';";
            return dbMan.ExecuteReader(query);
        }

        /// <summary>
        /// ////
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="passw"></param>
        /// <returns></returns>
        public object Login(int ID, string passw)
        {

            string query = "SELECT ClientID, Pass from Client where ClientID='" + ID + "' and  Pass='" + passw + "';";
            return dbMan.ExecuteScalar(query);

        }

        //Flights
        /// <summary>
        /// ///
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public DataTable viewFDetails(string dest, string to)
        {
            string query = "SELECT * FROM Flight WHERE DestCode=ANY(SELECT AirportCode from Airport where AirportName='" + dest + "') and SourceCode=ANY(SELECT AirportCode from Airport where AirportName='" + to + "'and NoPassengers>0);";
            return dbMan.ExecuteReader(query);
        }

        public object checkBan(int ID)
        {
            string query = "SELECT BanStatus FROM Client WHERE ClientID='" + ID + "';";
            return dbMan.ExecuteScalar(query);

        }
        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="flight"></param>
        /// <param name="fare"></param>
        /// <returns></returns>
        public int BookFlight(int ID, int flight, string fare)
        {
            string query = "INSERT INTO Books (Client_id, Flight_number, Fare)" +
                            "Values ('" + ID + "','" + flight + "','" + fare + "');";
          //  MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        public int NoPass(int fn)
        {
            string query = "update flight set NoPassengers = NoPassengers - 1 where NoPassengers>0 and Flightno =" + fn
                + "; ";
            return dbMan.ExecuteNonQuery(query);


        }

        //edit pass only
        /// <summary>
        /// /////////
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="pass"></param>
        /// <param name="oldpass"></param>
        /// <returns></returns>
        public int changePass(int ID, string pass, string oldpass)
        {
            string query = "UPDATE Client SET Pass='" + pass + "' WHERE ClientID=" + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        /// <summary>
        /// /////
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns></returns>
        public int changeName(int ID, string fname, string lname)//using procedure
        {
            string proc = StoredProc.modifyclientname;
            Dictionary<string, object> par = new Dictionary<string, object>();
            par.Add("@ID", ID);
            par.Add("@FName", fname);
            par.Add("@LName", lname);
           

            return dbMan.ExecuteNonQuery(proc, par);
        }
        //change address
        /// <summary>
        /// //
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public int changeAdd(int ID, string add)
        {
            string query = "UPDATE Client SET Address='" + add + "' WHERE ClientID='" + ID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="commen"></param>
        /// <param name="rate"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Review(int fn, string commen, int rate, int id)
        {
            string query = "INSERT INTO Review (Comment, ClientID, Flightno,Rate)" +
                            "Values ('" + commen + "','" + id + "','" + fn + "','" + rate + "');";
            MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////
          public DataTable SelectFlightInfo(int ID)
        {
            string query = "SELECT Flightno,NoPassengers,NoStaff,Fstatus FROM Flight F, Serves_On S WHERE S.CrewID = " + ID + " AND F.FlightNo = S.FlightID;";
            return dbMan.ExecuteReader(query);
        }
    public DataTable SelectClient()
    {
        string query = "SELECT ClientID FROM Client;";
        return dbMan.ExecuteReader(query);
    }

    public int UpdateClient(string newstat, int ID)
    {
        string query = "UPDATE Client SET CStatus = '" + newstat + "' WHERE ClientID = " + ID + ";";
        return dbMan.ExecuteNonQuery(query);
    }
    public string findpass(int ID)
    {
        string query = "SELECT Pass FROM FlightCrew WHERE CrewID = " + ID + ";";
        return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        ////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// 
        public int InsertClient(int ID, string email, string pass, string fnamee, string lnamee,int Agee,string gender,string Address,string nationalityy)
        {
            string query = "INSERT INTO Client (ClientID, Email, Pass, Fname, Lname, Age, Gender, Address, Nationality)" +
                            "Values ('" + ID + "','" + email + "','" + pass + "','" + fnamee + "','" + lnamee + "','" + Agee + "','" + gender + "','" + Address + "','" + nationalityy + "');";
            return dbMan.ExecuteNonQuery(query);
        }

    //Project functions//////////
    public int updateAdd(int id, string add)
    {
        string s = "UPDATE Client SET Address='" + add + "' WHERE ClientID=" + id + ";";

        return dbMan.ExecuteNonQuery(s);
    }
    //SelectAvailableFlights()
    public DataTable SelectAvailableFlights()
    {
        string q = "SELECT Flightno, NoPassengers, DestCode, SourceCode,NoStaff FROM Flight"
        + " WHERE Fstatus='pending' ;";
        return dbMan.ExecuteReader(q);


    }
    //InsertinBook
    public int InsertinBook(int cID, int fnum, string classs)
    {
        string query = "INSERT INTO Books (client_id, Flight_number, Fare)" +
                        "Values ('" + cID + "','" + fnum + "','" + classs + "');";
        return dbMan.ExecuteNonQuery(query);
    }
        //RemoveClient(cidd)
        public int RemoveClient(int c, int n)
        {
            string query = "DELETE FROM Books " +
                            "WHERE Client_id=" + c + "and Flight_number=" + n + "; ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RemoveClient(int c)
        {
            string query = "DELETE FROM Books " +
                            "WHERE Client_id=" + c +  "; ";
            return dbMan.ExecuteNonQuery(query);
        }

    }
}
