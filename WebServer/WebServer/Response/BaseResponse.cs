namespace March7thHoney.WebServer.Response;

public class BaseResponse<T>(int code, string message, T? data)
{
	public int Code { get; set; } = code;

	public string Message { get; set; } = message;

	public T? Data { get; set; } = data;
}
