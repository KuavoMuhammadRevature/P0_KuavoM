using System.Data.SqlClient;
namespace FIFAxAPI
{
    public class Teams
    {
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string groupId { get; set; }

        #region SQL Connection String
        SqlConnection con = new SqlConnection(@"server=KUAVO\KUAVO10INSTANCE;database=FIFAxDB;user id=sa;password=Exitoso-F!;MultipleActiveResultSets=true;");
        #endregion

        #region All-CRUD
        #region All Teams
        public List<Teams> GetAllTeams()
        {
            SqlCommand cmdGetAll = new SqlCommand("select * from Teams", con);
            con.Open();
            SqlDataReader rdAll = cmdGetAll.ExecuteReader();
            List<Teams> teamsList = new List<Teams>();
            while (rdAll.Read())
            {
                teamsList.Add(new Teams()
                {
                    teamId = Convert.ToInt32(rdAll[0]),
                    teamName = rdAll[1].ToString(),
                    groupId = rdAll[2].ToString()
                });
            }
            rdAll.Close();
            con.Close();
            return teamsList;
        }
        #endregion

        #region Create Teams
        public string AddTeam(Teams newTeam)
        {
            SqlCommand cmdnewTeam = new SqlCommand("insert into Teams values(@teamId, @teamName, @groupId", con);
            cmdnewTeam.Parameters.AddWithValue("@teamId", teamId);
            cmdnewTeam.Parameters.AddWithValue("@teamName", teamName);
            cmdnewTeam.Parameters.AddWithValue("@groupId", groupId);
            con.Open();
            int result = cmdnewTeam.ExecuteNonQuery();
            con.Close();
            return "Account Added Successfully";
        }
        #endregion

        #region Read Teams
        public Teams GetTeam(int teamId)
        {
            SqlCommand cmdGetTeam = new SqlCommand("select * from Teams where teamId=@teamId", con);
            cmdGetTeam.Parameters.AddWithValue("@teamId", teamId);

            con.Open();
            SqlDataReader rd = cmdGetTeam.ExecuteReader();
            if (rd.Read())
            {
                Teams teams = new Teams()
                {
                    teamId = Convert.ToInt32(rd[0]),
                    teamName = rd[1].ToString(),
                    groupId = rd[2].ToString()
                };
                return teams;
            }
            else
            {
                rd.Close();
                con.Close();
                throw new Exception("Team Not Found");
            }
        }
        #endregion

        #region Update Teams
        public string UpdateTeam(Teams changes)
        {
            SqlCommand cmdUpdateTeam = new SqlCommand("update Teams set teamId=@teamId,teamName=@teamName,groupId=@groupId", con);
            cmdUpdateTeam.Parameters.AddWithValue("@teamId", changes.teamId);
            cmdUpdateTeam.Parameters.AddWithValue("@teamName", changes.teamName);
            cmdUpdateTeam.Parameters.AddWithValue("@groupId", changes.groupId);
            con.Open();
            int result = cmdUpdateTeam.ExecuteNonQuery();
            con.Close();

            return "Team updated Successfully";
        }
        #endregion

        #region Delete Teams
        public string DeleteTeam(int teamId)
        {
            SqlCommand cmdDeleteTeam = new SqlCommand("delete from Teams where teamId=@teamId", con);
            cmdDeleteTeam.Parameters.AddWithValue("@teamId", teamId);
            con.Open();
            int result = cmdDeleteTeam.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                return "Team Deleted Successfully";
            }
            else
            {
                throw new Exception("Team ID not found in system");
            }
        }
        #endregion

        #region Check If Teams Exists
        public bool CheckTeamExists(int teamId)
        {
            SqlCommand cmdCheck = new SqlCommand("select count(*) from Teams where teamId=@teamId", con);
            cmdCheck.Parameters.AddWithValue("@teamId", teamId);

            con.Open();
            int count = (int)cmdCheck.ExecuteScalar();
            con.Close();
            if (count == 1)
            {
                return true;
            }
            throw new Exception("Team ID not found in system");
        }
        #endregion

        #endregion

    }
}
