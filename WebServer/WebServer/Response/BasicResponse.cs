namespace March7thHoney.WebServer.Response;

public class BasicResponse : BaseResponse<object>
{
	public BasicResponse(int code, string message)
		: base(code, message, (object?)null)
	{
	}
}
