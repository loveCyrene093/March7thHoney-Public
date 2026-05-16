namespace March7thHoney.WebServer.Handler;

public class FingerprintResJson
{
	public class FingerprintDataJson
	{
		public string device_fp { get; set; }

		public string message { get; set; }

		public int code { get; set; }

		public FingerprintDataJson(string fp)
		{
			code = 200;
			message = "OK";
			device_fp = fp;
		}
	}

	public string? message { get; set; }

	public int retcode { get; set; }

	public FingerprintDataJson? data { get; set; }
}
