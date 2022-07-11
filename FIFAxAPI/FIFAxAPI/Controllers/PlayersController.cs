using Microsoft.AspNetCore.Mvc;

namespace FIFAxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        #region Methods for Players

        #region ALL Players
        Players playerObj = new Players();
        [HttpGet]
        [Route("playerList")]
        public IActionResult GetAllPlayers()
        {
            try
            {
                return Ok(playerObj.GetAllPlayers());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Create Players
        [HttpPost]
        [Route("playerList/add/{newPlayer}")]
        public IActionResult AddPlayer(Players newPlayer)
        {
            try
            {
                return Ok(newPlayer.AddPlayer(newPlayer));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Read
        [HttpPost]
        [Route("playerList/{playerId}")]
        public IActionResult GetPlayer(int playerId)
        {
            try
            {
                return Ok(playerObj.GetPlayer(playerId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Update/Edit
        [HttpPut]
        [Route("playerList/update")]
        public IActionResult UpdatePlayers(Players updatePlayer)
        {
            try
            {
                return Ok(playerObj.UpdatePlayers(updatePlayer));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Delete
        [HttpDelete]
        [Route("playerList/delete/{playerId}")]
        public IActionResult DeletePlayer(int playerId)
        {
            try
            {
                return Accepted(playerObj.DeletePlayer(playerId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Check If Team Exists
        [HttpPost]
        [Route("playerList/check/{playerId}")]
        public IActionResult CheckPlayerExists(int playerId)
        {
            try
            {
                return Ok(playerObj.CheckPlayerExists(playerId));
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
