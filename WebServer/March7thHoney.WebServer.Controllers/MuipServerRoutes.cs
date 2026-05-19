using March7thHoney.WebServer.Request;
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
		return new JsonResult(MuipManager.CreateSession(req.key_type));
	}

	[HttpPost("/muip/auth_admin")]
	public IActionResult AuthAdminKey([FromBody] AuthAdminKeyRequestBody req)
	{
		return new JsonResult(MuipManager.AuthAdmin(req.session_id, req.admin_key));
	}

	[HttpGet("/muip/exec_cmd")]
	public IActionResult ExecuteCommandGet([FromQuery] AdminExecRequest req)
	{
		return new JsonResult(MuipManager.ExecuteCommand(req.SessionId, req.Command, req.TargetUid));
	}

	[HttpPost("/muip/exec_cmd")]
	public IActionResult ExecuteCommandPost([FromBody] AdminExecRequest req)
	{
		return new JsonResult(MuipManager.ExecuteCommand(req.SessionId, req.Command, req.TargetUid));
	}

	[HttpGet("/muip/server_information")]
	public IActionResult GetServerInformationGet([FromQuery] ServerInformationRequest req)
	{
		return new JsonResult(MuipManager.GetInformation(req.SessionId));
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
		return new JsonResult(MuipManager.GetInformation(req.SessionId));
	}

	[HttpGet("/muip/player_information")]
	public IActionResult GetPlayerInformationGet([FromQuery] PlayerInformationRequest req)
	{
		return new JsonResult(MuipManager.GetPlayerInformation(req.SessionId, req.Uid));
	}

	[HttpPost("/muip/player_information")]
	public IActionResult GetPlayerInformationPost([FromBody] PlayerInformationRequest req)
	{
		return new JsonResult(MuipManager.GetPlayerInformation(req.SessionId, req.Uid));
	}
}
