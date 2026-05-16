namespace March7thHoney.WebServer.Response;

public class PlayerInformationResponse : BaseResponse<PlayerInformationData>
{
	public PlayerInformationResponse(int code, string message, PlayerInformationData? data = null)
		: base(code, message, data)
	{
	}
}
