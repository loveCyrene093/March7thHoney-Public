namespace March7thHoney.WebServer.Response;

public class ExecuteCommandResponse : BaseResponse<ExecuteCommandData>
{
	public ExecuteCommandResponse(int code, string message, ExecuteCommandData? data = null)
		: base(code, message, data)
	{
	}
}
