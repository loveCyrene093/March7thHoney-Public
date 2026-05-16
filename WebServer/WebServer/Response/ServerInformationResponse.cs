namespace March7thHoney.WebServer.Response;

public class ServerInformationResponse : BaseResponse<ServerInformationData>
{
	public ServerInformationResponse(int code, string message, ServerInformationData? data = null)
		: base(code, message, data)
	{
	}
}
