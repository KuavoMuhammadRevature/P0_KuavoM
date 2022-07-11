using System.Data.SqlClient;
namespace FIFAxAPI
{
    public class Players
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public string playerPosition { get; set; }
        public string groupId { get; set; }

        #region SQL Connection String
        SqlConnection con = new SqlConnection(@"server=KUAVO\KUAVO10INSTANCE;database=FIFAxDB;user id=sa;password=Exitoso-F!;MultipleActiveResultSets=true;");
        #endregion
        #region All-CRUD
        #region All Players
        public List<Players> GetAllPlayers()
        {
            SqlCommand cmdGetAll = new SqlCommand("select * from Players", con);
            con.Open();
            SqlDataReader rdAll = cmdGetAll.ExecuteReader();
            List<Players> playersList = new List<Players>();
            while (rdAll.Read())
            {
                playersList.Add(new Players()
                {
                    playerId = Convert.ToInt32(rdAll[0]),
                    playerName = rdAll[1].ToString(),
                    playerPosition = rdAll[2].ToString(),
                    groupId = rdAll[3].ToString()
                });
            }
            rdAll.Close();
            con.Close();
            return playersList;
        }
        #endregion

        #region Create Player
        public string AddPlayer(Players newPlayer)
        {
            SqlCommand cmdnewPlayer = new SqlCommand("insert into Players values(@playerId,@playerName,@playerPosition,@groupId", con);
            cmdnewPlayer.Parameters.AddWithValue("@playerId", playerId);
            cmdnewPlayer.Parameters.AddWithValue("@playerName", playerName);
            cmdnewPlayer.Parameters.AddWithValue("@playerPosition", playerPosition);
            cmdnewPlayer.Parameters.AddWithValue("@groupId", groupId);
            con.Open();
            int result = cmdnewPlayer.ExecuteNonQuery();
            con.Close();
            return "Player Added Successfully";
        }
        #endregion

        #region Read Players
        public Players GetPlayer(int playerId)
        {
            SqlCommand cmdGetPlayer = new SqlCommand("select * from Players where playerId=@playerId", con);
            cmdGetPlayer.Parameters.AddWithValue("@playerId", playerId);
            con.Open();
            SqlDataReader rdOnePlayer = cmdGetPlayer.ExecuteReader();
            if (rdOnePlayer.Read())
            {
                Players onePlayer = new Players()
                {
                    playerId = Convert.ToInt32(rdOnePlayer[0]),
                    playerName = rdOnePlayer[1].ToString(),
                    playerPosition = rdOnePlayer[2].ToString(),
                    groupId = rdOnePlayer[3].ToString()
                };
                return onePlayer;
            }
            else
            {
                rdOnePlayer.Close();
                con.Close();
                throw new Exception("Player Not Found");
            }
        }
        #endregion

        #region Update Players
        public string UpdatePlayers(Players updates)
        {
            SqlCommand cmdUpdatePlayer = new SqlCommand("update Players set playerId=@playerId,playerName=@playerName,playerPosition=@playerPosition,groupId=@groupId", con);
            cmdUpdatePlayer.Parameters.AddWithValue("@playerId", playerId);
            cmdUpdatePlayer.Parameters.AddWithValue("@playerName", playerName);
            cmdUpdatePlayer.Parameters.AddWithValue("@playerPosition", playerPosition);
            cmdUpdatePlayer.Parameters.AddWithValue("@groupId", groupId);
            con.Open();
            int result = cmdUpdatePlayer.ExecuteNonQuery();
            con.Close();
            return "Player updated Successfully";
        }
        #endregion

        #region Delete Player
        public string DeletePlayer(int playerId)
        {
            SqlCommand cmdDeletePlayer = new SqlCommand("delete from Players where playerId=@playerId", con);
            cmdDeletePlayer.Parameters.AddWithValue("@playerId", playerId);
            con.Open();
            int result = cmdDeletePlayer.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                return "Player Deleted Successfully";
            }
            else
            {
                throw new Exception("Player ID not found in system");
            }
        }
        #endregion

        #region Check If Player Exists
        public bool CheckPlayerExists(int playerId)
        {
            SqlCommand cmdCheckPlayer = new SqlCommand("select count(*) from Players where playerId=@playerId", con);
            cmdCheckPlayer.Parameters.AddWithValue("@playerId", playerId);

            con.Open();
            int count = (int)cmdCheckPlayer.ExecuteScalar();
            con.Close();
            if (count == 1)
            {
                return true;
            }
            throw new Exception("Player ID not found in system");
        }
        #endregion

        #endregion

    }
}
