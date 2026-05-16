namespace March7thHoney.WebServer.Response;

public class BaseResponse<T>
{
	public int Code { get; set; }

	public string Message { get; set; }

	public T? Data { get; set; }

	public BaseResponse(int code, string message, T? data)
	{
		Code = code;
		Message = message;
		Data = data;
		base._002Ector();
	}
}
