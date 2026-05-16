namespace March7thHoney.Configuration;

public class WebSecurityConfig
{
	public bool EnableRsaLoginDecrypt { get; set; } = true;

	public string RsaPublicKeyPem { get; set; } = "";

	public string RsaPrivateKeyPem { get; set; } = "";
}
