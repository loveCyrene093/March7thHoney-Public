namespace March7thHoney.WebServer.Response;

public class CreateSessionResponse : BaseResponse<CreateSessionData>
{
	public CreateSessionResponse(int code, string message, CreateSessionData? data)
		: base(code, message, data)
	{
	}
}
