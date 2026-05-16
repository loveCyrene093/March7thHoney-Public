using March7thHoney.WebServer.Request;
using March7thHoney.WebServer.Response;
using March7thHoney.WebServer.Server;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Controllers;

[ApiController]
[EnableCors("AllowAll")]
[Route("/")]
public class MuipServerRoutes
{
	[HttpPost("/muip/create_session")]
	public IActionResult CreateSession([FromBody] CreateSessionRequestBody req)
	{
		CreateSessionResponse value = MuipManager.CreateSession(req.key_type);
		return new JsonResult(value);
	}

	[HttpPost("/muip/auth_admin")]
	public IActionResult AuthAdminKey([FromBody] AuthAdminKeyRequestBody req)
	{
		AuthAdminKeyResponse value = MuipManager.AuthAdmin(req.session_id, req.admin_key);
		return new JsonResult(value);
	}

	[HttpGet("/muip/exec_cmd")]
	public IActionResult ExecuteCommandGet([FromQuery] AdminExecRequest req)
	{
		ExecuteCommandResponse value = MuipManager.ExecuteCommand(req.SessionId, req.Command, req.TargetUid);
		return new JsonResult(value);
	}

	[HttpPost("/muip/exec_cmd")]
	public IActionResult ExecuteCommandPost([FromBody] AdminExecRequest req)
	{
		ExecuteCommandResponse value = MuipManager.ExecuteCommand(req.SessionId, req.Command, req.TargetUid);
		return new JsonResult(value);
	}

	[HttpGet("/muip/server_information")]
	public IActionResult GetServerInformationGet([FromQuery] ServerInformationRequest req)
	{
		ServerInformationResponse information = MuipManager.GetInformation(req.SessionId);
		return new JsonResult(information);
	}

	[HttpGet("/server/type")]
	public IActionResult March7thHoneyVerify()
	{
		return new ContentResult
		{
			Content = "{\"serverType\": \"March7thHoneyServer\"}",
			ContentType = "application/json"
		};
	}

	[HttpPost("/muip/server_information")]
	public IActionResult GetServerInformationPost([FromBody] ServerInformationRequest req)
	{
		ServerInformationResponse information = MuipManager.GetInformation(req.SessionId);
		return new JsonResult(information);
	}

	[HttpGet("/muip/player_information")]
	public IActionResult GetPlayerInformationGet([FromQuery] PlayerInformationRequest req)
	{
		PlayerInformationResponse playerInformation = MuipManager.GetPlayerInformation(req.SessionId, req.Uid);
		return new JsonResult(playerInformation);
	}

	[HttpPost("/muip/player_information")]
	public IActionResult GetPlayerInformationPost([FromBody] PlayerInformationRequest req)
	{
		PlayerInformationResponse playerInformation = MuipManager.GetPlayerInformation(req.SessionId, req.Uid);
		return new JsonResult(playerInformation);
	}
}
