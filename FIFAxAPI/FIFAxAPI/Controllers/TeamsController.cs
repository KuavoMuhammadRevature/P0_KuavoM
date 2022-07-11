using Microsoft.AspNetCore.Mvc;

namespace FIFAxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        #region Methods for Teams

        #region ALL Teams
        Teams teamObj = new Teams();
        [HttpGet]
        [Route("teamList")]
        public IActionResult GetAllTeams()
        {
            try
            {
                return Ok(teamObj.GetAllTeams());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Create
        [HttpPost]
        [Route("teamList/add/{newTeam}")]
        public IActionResult AddTeam(Teams newTeam)
        {
            try
            {
                return Ok(newTeam.AddTeam(newTeam));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Read
        [HttpPost]
        [Route("teamList/{teamId}")]
        public IActionResult GetTeam(int teamId)
        {
            try
            {
                return Ok(teamObj.GetTeam(teamId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Update/Edit
        [HttpPut]
        [Route("teamList/update")]
        public IActionResult UpdateTeam(Teams updates)
        {
            try
            {
                return Ok(teamObj.UpdateTeam(updates));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Delete
        [HttpDelete]
        [Route("teamList/delete/{teamId}")]
        public IActionResult DeleteTeam(int teamId)
        {
            try
            {
                return Accepted(teamObj.DeleteTeam(teamId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Check If Team Exists
        [HttpPost]
        [Route("teamList/check/{teamId}")]
        public IActionResult CheckTeamExists(int teamId)
        {
            try
            {
                return Ok(teamObj.CheckTeamExists(teamId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #endregion
    }
}

