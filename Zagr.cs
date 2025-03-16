using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Security.Permissions;
using System.Xml.Serialization;

namespace ZagrosDesktop
    {
    class DB
        {
        public static string ResidentialName = "";
        public static string CnnString = "";
        public static SqlConnection Cnn; // = new SqlConnection (CnnString)
        public static SqlCommand Cmd = new SqlCommand ();
        public static SqlDataAdapter DA = new SqlDataAdapter ();
        public static DataSet DS = new DataSet ();
        public static string strSQL;
        public static string DataPath = Environment.GetFolderPath (Environment.SpecialFolder.CommonDocuments) + @"\";
        public static string InstanceName = "SQLEXPRESS";

        [STAThread]
        static void Main ()
            {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize ();
            if (ReadConnectionString ())
                {
                CreateTables ();
                if (CopyAndAttachLocalDB () && CheckDBAttached2SqlServerExpress ())
                    {
                    //MessageBox.Show ("ديتابيس آماده استفاده");
                    ZagrApp.RefeedTables (63, false); //all=63 {1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units}
                    Application.Run (new frmSwitchBoard ());
                    }
                else
                    {
                    MessageBox.Show ("خطا: دسترسي به ديتابيس محلي برنامه ممکن نيست\n\n ديتابيس اسکيو ال سرور اکسپرس را با نام پيش فرض نصب کنيد");
                    }
                }
            }        
        public static bool CopyAndAttachLocalDB ()
            {
            string strCatalog = "Zagros";
            try
                {
                //copy
                if (!File.Exists (DB.DataPath + strCatalog + ".mdf"))
                    {
                    File.Copy (Application.StartupPath + @"_DB\Zagros.mdf", DB.DataPath + strCatalog + ".mdf", true);
                    }
                //attach
                var conn1 = new Microsoft.Data.SqlClient.SqlConnection (@"Data Source=.\" + DB.InstanceName + "; AttachDbFilename=" + DB.DataPath + strCatalog + ".mdf; Database=" + strCatalog + "; Integrated Security=SSPI; TrustServerCertificate=True;");
                if (conn1.State == ConnectionState.Closed)
                    conn1.Open ();
                var cmd1 = new SqlCommand ("SELECT * FROM Units", conn1);
                var da1 = new SqlDataAdapter ();
                da1.SelectCommand = cmd1;
                cmd1.Dispose ();
                conn1.Close ();
                conn1.Dispose ();
                //MessageBox.Show ("ديتابيس محلي استقرار يافت");
                return true;
                }
            catch (Exception ex)
                {
                //MessageBox.Show (ex.ToString ());
                return false;
                }
            }
        public static bool CheckDBAttached2SqlServerExpress ()
            {
            string strCatalog = "Zagros";
            using (var DBConn = new SqlConnection (@"Server=.\" + DB.InstanceName + "; Initial Catalog=" + strCatalog + "; Integrated Security=SSPI; TrustServerCertificate=True;"))
                {
                try
                    {
                    DBConn.Open ();
                    var DBCmd = new SqlCommand ("Select * From Units", DBConn);
                    int rows = DBCmd.ExecuteNonQuery ();
                    DBConn.Close ();
                    //MessageBox.Show ("ديتابيس محلي راه اندازي شد");
                    return true;
                    }
                catch (Exception ex)
                    {
                    DBConn.Close ();
                    return false;
                    }
                }
            }
        public static bool ReadConnectionString ()
            {
            string Linex = "";
            bool cnnLineReadOK = false;
            try
                {
                FileSystem.FileClose ();
                FileSystem.FileOpen (1, Application.StartupPath + @"\cnn.txt", OpenMode.Input);
                while (!cnnLineReadOK && !FileSystem.EOF (1))
                    {
                    Linex = FileSystem.LineInput (1).Trim ().ToLower ();
                    if (Linex == "connectionstring")
                        {
                        ResidentialName = FileSystem.LineInput (1);
                        CnnString = FileSystem.LineInput (1);
                        Cnn = new SqlConnection (CnnString);
                        cnnLineReadOK = true;
                        FileSystem.FileClose (1);
                        return true;
                        }
                    }
                FileSystem.FileClose (1);
                return false;
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                FileSystem.FileClose (1);
                return false;
                }
            }
        public static void CreateTables ()
            {
            DS.Tables.Add ("tblAccs");
            DS.Tables.Add ("tblCats");
            DS.Tables.Add ("tblPeriods");
            DS.Tables.Add ("tblPeriodsUnits");
            DS.Tables.Add ("tblPersons");
            DS.Tables.Add ("tblUnits");
            }
        public static bool ClearTables ()
            {
            DialogResult myAnsw = MessageBox.Show ("اخطار نهايي: همه اطلاعات پاک خواهند شد" + "\n\n ادامه مي دهيد؟", "تاييد کنيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (myAnsw == DialogResult.Yes)
                {
                try
                    {
                    DB.strSQL = "DELETE FROM Accs; DELETE FROM PERIODS; DELETE FROM PeriodsUnits; DELETE FROM Persons; DELETE FROM Units; DBCC CHECKIDENT ('Accs', RESEED, 0); DBCC CHECKIDENT ('Periods', RESEED, 0); DBCC CHECKIDENT ('PeriodsUnits', RESEED, 0); DBCC CHECKIDENT ('Persons', RESEED, 0); DBCC CHECKIDENT ('Units', RESEED, 0); ";
                    DB.Cnn.Open ();
                    var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                    cmdx.CommandType = CommandType.Text;
                    cmdx.ExecuteNonQuery ();
                    DB.Cnn.Close ();
                    ZagrApp.RefeedTables (63, false);
                    return true;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show (ex.ToString ());
                    return false;
                    }
                }
            else
                {
                return false;
                }
            }
        public static int NotFilledTables ()
            {
            int status = 0;
            string msgx = "";
            if (DB.DS.Tables ["tblUnits"].Rows.Count == 0)
                {
                status |= 1;
                msgx += "نام/شماره و مشخصات واحدهاي مسکوني را وارد کنيد\n\n";
                }
            if (DB.DS.Tables ["tblPersons"].Rows.Count == 0)
                {
                status |= 2;
                msgx += "نام افراد (مالک يا ساکن) را در جدول افراد وارد کنيد\n\n";
                }
            if (DB.DS.Tables ["tblPeriods"].Rows.Count == 0)
                {
                status |= 4;
                msgx += "دوره جديد مالي براي شارژها را ايجاد کنيد\n\n";
                }
            if (msgx != "")
                {
                MessageBox.Show (msgx, "توجه");
                }
            return status;
            }
        }
    public class ZagrApp
        {
        public static int TransactionRequestType = 0;
        public static string RequestModeNew_Edit = "";
        public static string DialogType = "";
        public static string DialogInput = "";
        public static string DialogOutput = "";
        public static void RefeedTables (int tables2feed, bool onlyActivePeriods)
            {
            DB.Cnn.Open ();
            if ((tables2feed & 1) == 1)
                {
                DB.DS.Tables ["tblAccs"].Clear ();
                DB.DA = new SqlDataAdapter ("Select ID, Datum, Subjectx, Amount, Cat_ID, Period_ID, Unit_ID, Note FROM Accs ORDER BY Datum", DB.Cnn);
                DB.DA.Fill (DB.DS, "tblAccs");
                }
            if ((tables2feed & 2) == 2)
                {
                DB.DS.Tables ["tblCats"].Clear ();
                DB.DA = new SqlDataAdapter ("Select ID, Title, Note FROM Cats", DB.Cnn);
                DB.DA.Fill (DB.DS, "tblCats");
                }
            if ((tables2feed & 4) == 4)
                {
                DB.DS.Tables ["tblPeriods"].Clear ();
                if (!onlyActivePeriods)
                    {
                    DB.DA = new SqlDataAdapter ("Select ID, Name, CntWater, ExpWater, ExpElec, ExpDoorPump, ExpGuard, ExpElev1, ExpElev2, ExpRepair, ExpMisc, PeopleTotal, BookKeeper, Note, DateStart, DateEnd, DateCnt, IsActive FROM Periods ORDER BY Name", DB.Cnn);
                    }
                else
                    {
                    DB.DA = new SqlDataAdapter ("Select ID, Name, CntWater, ExpWater, ExpElec, ExpDoorPump, ExpGuard, ExpElev1, ExpElev2, ExpRepair, ExpMisc, PeopleTotal, BookKeeper, Note, DateStart, DateEnd, DateCnt, IsActive FROM Periods WHERE IsActive=1 ORDER BY Name", DB.Cnn);
                    }
                DB.DA.Fill (DB.DS, "tblPeriods");
                }
            if ((tables2feed & 8) == 8)
                {
                DB.DS.Tables ["tblPeriodsUnits"].Clear ();
                DB.DA = new SqlDataAdapter ("SELECT PeriodsUnits.ID, Period_ID, Unit_ID, Owner, PersonsOwner.Name AS OwnerName, Resident, PersonsResident.Name AS ResidentName, IsRent, People, WaterFrom, WaterTo, ChargeBill, PeriodsUnits.Note, Area FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID LEFT JOIN Persons AS PersonsOwner ON PeriodsUnits.Owner = PersonsOwner.ID LEFT JOIN Persons AS PersonsResident ON PeriodsUnits.Resident = PersonsResident.ID WHERE Period_ID = 26 ORDER BY Period_ID, Unit_ID;", DB.Cnn);
                DB.DA.Fill (DB.DS, "tblPeriodsUnits");
                }
            if ((tables2feed & 16) == 16)
                {
                DB.DS.Tables ["tblPersons"].Clear ();
                DB.DA = new SqlDataAdapter ("Select ID, Title, Name, Tel, Note FROM Persons ORDER BY Name", DB.Cnn);
                DB.DA.Fill (DB.DS, "tblPersons");
                }
            if ((tables2feed & 32) == 32)
                {
                DB.DS.Tables ["tblUnits"].Clear ();
                DB.DA = new SqlDataAdapter ("Select ID, Name, Area, Parking, ElecSerialN, GassSerialN FROM Units ORDER BY Name", DB.Cnn);
                DB.DA.Fill (DB.DS, "tblUnits");
                }
            DB.Cnn.Close ();
            }
        public static void AddNewPerson (string newTitle, string newName, string newNote)
            {
            try
                {
                DB.strSQL = "INSERT INTO Persons (Title , Name, Note) VALUES (@title, @name, @note);";
                DB.Cnn.Open ();
                var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx.CommandType = CommandType.Text;
                cmdx.Parameters.AddWithValue ("@title", newTitle);
                cmdx.Parameters.AddWithValue ("@name", newName);
                cmdx.Parameters.AddWithValue ("@note", newNote);
                int i = cmdx.ExecuteNonQuery ();
                DB.Cnn.Close ();
                }
            catch (Exception ex)
                {
                //MessageBox.Show (ex.ToString ());
                }
            }
        public static bool UpdatePerson (string newTitle, string newName, string newNote, int personid)
            {
            if (personid != 0)
                {
                try
                    {
                    DB.strSQL = "UPDATE Persons SET Title=@title, Name=@name, Note=@note WHERE ID=@id";
                    DB.Cnn.Open ();
                    var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                    cmdx.CommandType = CommandType.Text;
                    cmdx.Parameters.AddWithValue ("@title", newTitle);
                    cmdx.Parameters.AddWithValue ("@name", newName);
                    cmdx.Parameters.AddWithValue ("@note", newNote);
                    cmdx.Parameters.AddWithValue ("@id", personid.ToString());
                    int i = (int) cmdx.ExecuteNonQuery ();
                    DB.Cnn.Close ();
                    return true;
                    }
                catch (Exception ex)
                    {
                    //MessageBox.Show (ex.ToString ());
                    return false;
                    }
                }
            else
                {
                return false;
                }
            }
        public static void AddNewUnit (string newName, int newArea)
            {
            if (newName.Length > 10)
                {
                newName= newName.Substring (0, 10);
                }
            try
                {
                DB.strSQL = "INSERT INTO Units (Name , Area) VALUES (@name, @area);";
                DB.Cnn.Open ();
                var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx.CommandType = CommandType.Text;
                cmdx.Parameters.AddWithValue ("@name", newName);
                cmdx.Parameters.AddWithValue ("@area", newArea.ToString());
                int i = cmdx.ExecuteNonQuery ();
                DB.Cnn.Close ();
                }
            catch (Exception ex)
                {
                //MessageBox.Show (ex.ToString ());
                }
            }
        public static bool UpdateUnit (string newName, int newArea, int unitid)
            {
            if (unitid != 0)
                {
                try
                    {
                    DB.strSQL = "UPDATE Units SET Name=@name, Area=@area WHERE ID=@id";
                    DB.Cnn.Open ();
                    var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                    cmdx.CommandType = CommandType.Text;
                    cmdx.Parameters.AddWithValue ("@name", newName);
                    cmdx.Parameters.AddWithValue ("@area", newArea);
                    cmdx.Parameters.AddWithValue ("@id", unitid.ToString ());
                    int i = (int) cmdx.ExecuteNonQuery ();
                    DB.Cnn.Close ();
                    return true;
                    }
                catch (Exception ex)
                    {
                    //MessageBox.Show (ex.ToString ());
                    return false;
                    }
                }
            else
                {
                return false;
                }
            }
        public static int AddNewTransaction (Transactionx tranxn)
            {
            try
                {
                DB.strSQL = "INSERT INTO Accs (Datum , Subjectx, Amount, Cat_ID, Period_ID, Unit_ID, Note) VALUES (@datum, @subject, @amount, @catid, @periodid, @unitid, @note); SELECT CAST (scope_identity() as int)";
                DB.Cnn.Open ();
                var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx.CommandType = CommandType.Text;
                cmdx.Parameters.AddWithValue ("@datum", tranxn.Datum);
                cmdx.Parameters.AddWithValue ("@subject", tranxn.Subjectx);
                cmdx.Parameters.AddWithValue ("@amount", tranxn.Amount.ToString ());
                cmdx.Parameters.AddWithValue ("@catid", tranxn.CatId.ToString ());
                cmdx.Parameters.AddWithValue ("@periodid", tranxn.PeriodId.ToString ());
                cmdx.Parameters.AddWithValue ("@unitid", tranxn.UnitId.ToString ());
                cmdx.Parameters.AddWithValue ("@note", tranxn.Note);
                int i = (int) cmdx.ExecuteScalar ();
                DB.Cnn.Close ();
                return i;
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                return 0;
                }
            }
        public static bool DeleteTransaction (int idx)
            {
            try
                {
                DB.strSQL = "DELETE FROM Accs WHERE ID=@id";
                DB.Cnn.Open ();
                var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx.CommandType = CommandType.Text;
                cmdx.Parameters.AddWithValue ("@id", idx.ToString ());
                cmdx.ExecuteNonQuery ();
                DB.Cnn.Close ();
                return true;
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                return false;
                }
            }
        public static void GetPeriodUnitsData (int intPeriod)
            {
            DB.DS.Tables ["tblPeriodsUnits"].Clear ();
            DB.Cnn.Open ();
            DB.DA = new SqlDataAdapter ("SELECT PeriodsUnits.ID, Period_ID, Unit_ID, Owner, PersonsOwner.Name AS OwnerName, Resident, PersonsResident.Name AS ResidentName, IsRent, People, WaterFrom, WaterTo, ChargeBill, PeriodsUnits.Note, Area FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID LEFT JOIN Persons AS PersonsOwner ON PeriodsUnits.Owner = PersonsOwner.ID LEFT JOIN Persons AS PersonsResident ON PeriodsUnits.Resident = PersonsResident.ID WHERE Period_ID = " + intPeriod.ToString () + " ORDER BY Period_ID, Unit_ID;", DB.Cnn);
            DB.DA.Fill (DB.DS, "tblPeriodsUnits");
            DB.Cnn.Close ();
            }
        public static bool UpdatePeriodInfo ()
            {
            if (Periodx.Id != 0)
                {
                try
                    {
                    DB.strSQL = "UPDATE Periods SET Name=@name, BookKeeper=@bookkeeper, DateStart=@datestart, DateEnd=@dateend,DateCnt=@datecnt, Note=@note, IsActive=@isactive WHERE ID=@id";
                    DB.Cnn.Open ();
                    var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                    cmdx.CommandType = CommandType.Text;
                    cmdx.Parameters.AddWithValue ("@name", Periodx.Name);
                    cmdx.Parameters.AddWithValue ("@bookkeeper", Periodx.BookKeeper);
                    cmdx.Parameters.AddWithValue ("@datestart", Periodx.DateStart);
                    cmdx.Parameters.AddWithValue ("@dateend", Periodx.DateEnd);
                    cmdx.Parameters.AddWithValue ("@datecnt", Periodx.DateCnt);
                    cmdx.Parameters.AddWithValue ("@note", Periodx.Note);
                    cmdx.Parameters.AddWithValue ("@isactive", Periodx.IsActive);
                    cmdx.Parameters.AddWithValue ("@id", Periodx.Id);
                    int i = (int) cmdx.ExecuteNonQuery ();
                    DB.Cnn.Close ();
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show (ex.ToString ());
                    return false;
                    }
                return true;
                }
            else
                {
                return false;
                }
            }
        public static bool UpdatePeriodExpenseData (int pid)
            {
            //ID, Name, CntWater, ExpWater, ExpElec, ExpDoorPump, ExpGuard, ExpElev1, ExpElev2, ExpRepair, ExpMisc, PeopleTotal, BookKeeper, Note, DateStart, DateEnd, DateCnt, IsActive
            //CntWater, ExpWater, ExpElec, ExpDoorPump, ExpGuard, ExpElev1, ExpElev2, ExpRepair, ExpMisc, PeopleTotal
            if (pid != 0)
                {
                try
                    {
                    DB.strSQL = "UPDATE Periods SET CntWater=@cntwater, ExpWater=@expwater, ExpElec=@expelec, ExpDoorPump=@expdoorpump, ExpGuard=@expguard, ExpElev1=@expelev1, ExpElev2=@expelev2, ExpRepair=@exprepair, ExpMisc=@expmisc, PeopleTotal=@peopletotal WHERE ID=@id";
                    DB.Cnn.Open ();
                    var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                    cmdx.CommandType = CommandType.Text;
                    cmdx.Parameters.AddWithValue ("@cntwater", Periodx.CntWater);
                    cmdx.Parameters.AddWithValue ("@expwater", Periodx.ExpWater);
                    cmdx.Parameters.AddWithValue ("@expelec", Periodx.ExpElec);
                    cmdx.Parameters.AddWithValue ("@expdoorpump", Periodx.ExpDoorPump);
                    cmdx.Parameters.AddWithValue ("@expguard", Periodx.ExpGuard);
                    cmdx.Parameters.AddWithValue ("@expelev1", Periodx.ExpElev1);
                    cmdx.Parameters.AddWithValue ("@expelev2", Periodx.ExpElev2);
                    cmdx.Parameters.AddWithValue ("@exprepair", Periodx.ExpRepair);
                    cmdx.Parameters.AddWithValue ("@expmisc", Periodx.ExpMisc);
                    cmdx.Parameters.AddWithValue ("@peopletotal", Periodx.PeopleTotal);
                    cmdx.Parameters.AddWithValue ("@id", pid.ToString());
                    int i = (int) cmdx.ExecuteNonQuery ();
                    DB.Cnn.Close ();
                    return true;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show (ex.ToString ());
                    return false;
                    }
                }
            else
                {
                return false;
                }
            }
        public static bool UpdatePeriodsUnitsRecord (int unitid, string fieldName, string fieldValue)
            {
            try
                {
                if (fieldName == "Note")
                    {
                    //FieldValue is a string
                    DB.strSQL = "UPDATE PeriodsUnits SET " + fieldName + " = N'" + fieldValue + "' WHERE ID= " + unitid.ToString ();
                    }
                else
                    {
                    //FieldValue is a number
                    DB.strSQL = "UPDATE PeriodsUnits SET " + fieldName + " = " + fieldValue + " WHERE ID= " + unitid.ToString ();
                    }
                DB.Cnn.Open ();
                var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx.CommandType = CommandType.Text;
                int i = cmdx.ExecuteNonQuery ();
                DB.Cnn.Close ();
                return true;
                }
            catch (Exception ex)
                {
                DB.Cnn.Close ();
                MessageBox.Show (ex.ToString ());
                return false;
                }
            }
        public static int AddNewPeriod ()
            {
            try
                {
                DB.strSQL = "INSERT INTO Periods (Name, BookKeeper, Note, DateStart, DateEnd, DateCnt, IsActive) VALUES (@name, @bookkeeper, @note, @datestart, @dateend, @datecnt, @isactive); SELECT CAST (scope_identity() as int)";
                DB.Cnn.Open ();
                var cmdx1 = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx1.CommandType = CommandType.Text;
                cmdx1.Parameters.AddWithValue ("@name", Periodx.Name);
                cmdx1.Parameters.AddWithValue ("@bookkeeper", Periodx.BookKeeper);
                cmdx1.Parameters.AddWithValue ("@note", Periodx.Note);
                cmdx1.Parameters.AddWithValue ("@datestart", Periodx.DateStart);
                cmdx1.Parameters.AddWithValue ("@dateend", Periodx.DateEnd);
                cmdx1.Parameters.AddWithValue ("@datecnt", Periodx.DateCnt);
                cmdx1.Parameters.AddWithValue ("@isactive", Periodx.IsActive);
                int pid = (int) cmdx1.ExecuteScalar ();
                DB.Cnn.Close ();
                return pid;
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                return 0;
                }
            }
        public static void AddUnit2PeriodsUnits (int periodId, int unitId, int ownerId, int residentId, int people, int waterFrom)
            {
            DB.strSQL = "INSERT INTO PeriodsUnits (Period_ID, Unit_ID, Owner, Resident, People, WaterFrom) VALUES (@periodid, @unitid, @owner, @resident, @people, @waterfrom);";
            DB.Cnn.Open ();
            var cmdx2 = new SqlCommand (DB.strSQL, DB.Cnn);
            cmdx2.CommandType = CommandType.Text;
            cmdx2.Parameters.AddWithValue ("@periodid", periodId.ToString ());
            cmdx2.Parameters.AddWithValue ("@unitid", unitId.ToString ());
            cmdx2.Parameters.AddWithValue ("@owner", ownerId.ToString ());
            cmdx2.Parameters.AddWithValue ("@resident", residentId.ToString ());
            cmdx2.Parameters.AddWithValue ("@people", people.ToString ());
            cmdx2.Parameters.AddWithValue ("@waterfrom", waterFrom.ToString ());
            int id2 = cmdx2.ExecuteNonQuery ();
            DB.Cnn.Close ();
            }
        public static bool RemoveUnitFromPeriodsUnits (int unitid)
            {
            try
                {
                DB.strSQL = "DELETE FROM PeriodsUnits WHERE ID=@id";
                DB.Cnn.Open ();
                var cmdx = new SqlCommand (DB.strSQL, DB.Cnn);
                cmdx.CommandType = CommandType.Text;
                cmdx.Parameters.AddWithValue ("@id", unitid.ToString ());
                cmdx.ExecuteNonQuery ();
                DB.Cnn.Close ();
                return true;
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                return false;
                }
            }
        public static bool CalculateCharge (int periodId)
            {
            RefeedTables (63, false); //{1:Accs 2:Cats 4:Periods 8:PeriodsUnits 16:Persons 32:Units} all=63
            //1-check uncertain items(cat-15)
            if (SumExpense (periodId, 15) != 0)
                {
                return false;
                }
            //2-calc sums             
            Periodx.CntWater = SumWaterCounter(periodId);
            if (Periodx.CntWater == 0)
                {
                MessageBox.Show ("جمع کنتور آب در اين دوره را بررسي کنيد");
                Periodx.CntWater = 1;
                }
            Periodx.PeopleTotal = SumPeople(periodId);
            if (Periodx.PeopleTotal == 0)
                {
                MessageBox.Show ("تعداد نفرات ساکن در مجتمع در اين دوره را بررسي کنيد");
                return false;
                }
            Periodx.ExpWater = SumExpense(periodId, 5);
            Periodx.ExpElec = SumExpense(periodId, 6);
            Periodx.ExpDoorPump = SumExpense(periodId, 11) + SumExpense (periodId, 12);
            Periodx.ExpGuard = SumExpense(periodId, 4);
            Periodx.ExpElev1 = SumExpense(periodId, 10);
            Periodx.ExpElev2 = SumExpense(periodId, 9);
            Periodx.ExpRepair = SumExpense(periodId, 8);
            Periodx.ExpMisc = SumExpense(periodId, 7) + SumExpense(periodId, 13) + SumExpense (periodId, 14);
            Periodx.AreaTotal = SumArea(periodId);
            //3-save sums to period
            if (UpdatePeriodExpenseData (periodId))
                {
                //4-calc units charges
                GetPeriodUnitsData (periodId);
                for (int u = 0; u < DB.DS.Tables ["tblPeriodsUnits"].Rows.Count; u++)
                    {
                    //0ID, 1Period_ID, 2Unit_ID, 3Owner, 4OwnerName, 5Resident, 6ResidentName, 7IsRent, 8People, 9WaterFrom, 10WaterTo, 11ChargeBill, 12Note, 13Area
                    PeriodUnit.Id = Convert.ToInt32(DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [0]);
                    PeriodUnit.People= Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [8]);
                    PeriodUnit.WaterFrom= Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [9]);
                    PeriodUnit.WaterTo= Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [10]);
                    PeriodUnit.Area = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [13]);
                    //calc charge
                    PeriodUnit.ChargeBill = 0;
                    PeriodUnit.ChargeBill = Periodx.ExpGuard / (DB.DS.Tables ["tblPeriodsUnits"].Rows.Count);
                    PeriodUnit.ChargeBill += (Periodx.ExpElec + Periodx.ExpDoorPump + Periodx.ExpElev1 + Periodx.ExpMisc) / Periodx.PeopleTotal * PeriodUnit.People;
                    PeriodUnit.ChargeBill += (Periodx.ExpElev2 + Periodx.ExpRepair) / Periodx.AreaTotal * PeriodUnit.Area;
                    PeriodUnit.ChargeBill += (Periodx.ExpWater) / Periodx.CntWater * (Math.Abs(PeriodUnit.WaterTo - PeriodUnit.WaterFrom) + 1);
                    //Save unit charge
                    UpdatePeriodsUnitsRecord (PeriodUnit.Id, "ChargeBill", PeriodUnit.ChargeBill.ToString());
                    }
                }
            RefeedTables (12, false);
            return true;
            }
        public static int SumExpense (int periodId, int catId)
            {
            DB.strSQL = "SELECT ISNULL(SUM(Amount), 0) AS Expx FROM Accs WHERE (Period_ID=" + periodId.ToString () + " AND Cat_ID=" + catId.ToString () + ")";
            DB.Cnn.Open ();
            var cmd = new SqlCommand (DB.strSQL, DB.Cnn);
            cmd.CommandType = CommandType.Text;
            int res = (int) cmd.ExecuteScalar ();
            DB.Cnn.Close ();
            return res;
            }
        public static int SumWaterCounter (int periodId)
            {
            DB.strSQL = "SELECT ISNULL(ABS(SUM(WaterTo-WaterFrom)), 0) AS cnt FROM PeriodsUnits WHERE Period_ID=" + periodId.ToString ();
            DB.Cnn.Open ();
            var cmd = new SqlCommand (DB.strSQL, DB.Cnn);
            cmd.CommandType = CommandType.Text;
            int res = (int) cmd.ExecuteScalar ();
            DB.Cnn.Close ();
            return res;
            }
        public static int SumPeople (int periodId)
            {
            DB.strSQL = "SELECT ISNULL(SUM(People), 0) AS ppl FROM PeriodsUnits WHERE Period_ID=" + periodId.ToString ();
            DB.Cnn.Open ();
            var cmd = new SqlCommand (DB.strSQL, DB.Cnn);
            cmd.CommandType = CommandType.Text;
            int res = (int) cmd.ExecuteScalar ();
            DB.Cnn.Close ();
            return res;
            }
        public static int SumArea (int periodId)
            {
            DB.strSQL = "SELECT SUM(Area) AS TotalArea FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID WHERE Period_ID=" + periodId.ToString ();
            DB.Cnn.Open ();
            var cmd = new SqlCommand (DB.strSQL, DB.Cnn);
            cmd.CommandType = CommandType.Text;
            int res = (int) cmd.ExecuteScalar ();
            DB.Cnn.Close ();
            return res;
            }
        public static bool AddChargesToAccs ()
            {
            Transactionx T = new Transactionx ();
            var frmDate = new frmTimeAndDate ();
            frmDate.ShowDialog ();
            if (!CustomInput.Cancelled)
                {
                T.Datum = ZagrApp.DialogOutput.ToString ();
                }
            else
                {
                return false;
                }
            try
                {
                for (int u = 0; u < DB.DS.Tables ["tblPeriodsUnits"].Rows.Count; u++)
                    {
                    T.Id = 0;
                    T.Subjectx = "شارژ " + Periodx.Name;
                    T.Amount = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [11]);
                    T.CatId = 3; //units charges
                    T.PeriodId = 0;
                    T.UnitId = Convert.ToInt32 (DB.DS.Tables ["tblPeriodsUnits"].Rows [u] [2]);
                    T.Note = "-";
                    AddNewTransaction (T);
                    }
                return true;
                }
            catch (Exception ex)
                {
                MessageBox.Show (ex.ToString ());
                return false;
                }
            }
        }
    public static class Periodx
        {
        //ID, Name, CntWater, ExpWater, ExpElec, ExpDoorPump, ExpGuard, ExpElev1, ExpElev2, ExpRepair, ExpMisc, PeopleTotal, BookKeeper, Note, DateStart, DateEnd, DateCnt, IsActive
        public static int Id;
        public static string Name;
        public static int CntWater;
        public static int ExpWater;
        public static int ExpElec;
        public static int ExpDoorPump;
        public static int ExpGuard;
        public static int ExpElev1;
        public static int ExpElev2;
        public static int ExpRepair;
        public static int ExpMisc;
        public static int PeopleTotal;
        public static string BookKeeper;
        public static string Note;
        public static string DateStart;
        public static string DateEnd;
        public static string DateCnt;
        public static bool IsActive;
        public static int AreaTotal;

        }
    public static class PeriodUnit
        {
        //ID, Period_ID, Unit_ID, Owner, Resident, IsRent, People, WaterFrom, WaterTo, ChargeBill, Note
        public static int Id;
        public static int PeriodId;
        public static int UnitId;
        public static int Owner;
        public static int Resident;
        public static int IsRent;
        public static int People;
        public static int WaterFrom;
        public static int WaterTo;
        public static int ChargeBill;
        public static int Note;
        public static int Area;
        }
    public class Transactionx
        {
        public int Id;
        public string Datum;
        public string Subjectx;
        public int Amount;
        public int CatId;
        public int PeriodId;
        public int UnitId;
        public string Note;
        }
    public static class TransaxnEdit
        {
        public static int Id;
        public static string Datum;
        public static string Subjectx;
        public static int Amount;
        public static int CatId;
        public static int PeriodId;
        public static int UnitId;
        public static string Note;
        }
    public static class CustomInput
        {
        public static string InputType;    //number, string
        public static string DefaultValue;
        public static string ReturnValue;
        public static string MessageText;
        public static bool Cancelled;
        }
    }
