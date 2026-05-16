namespace March7thHoney.WebServer.Response;

public class AuthAdminKeyResponse : BaseResponse<AuthAdminKeyData>
{
	public AuthAdminKeyResponse(int code, string message, AuthAdminKeyData? data)
		: base(code, message, data)
	{
	}
}
