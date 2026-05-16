using Microsoft.AspNetCore.Mvc;

namespace March7thHoney.WebServer.Handler;

public class FingerprintHandler
{
	public JsonResult GetFp(string device_fp)
	{
		FingerprintResJson fingerprintResJson = new FingerprintResJson();
		if (device_fp == null)
		{
			fingerprintResJson.retcode = -202;
			fingerprintResJson.message = "Error";
		}
		else
		{
			fingerprintResJson.message = "OK";
			fingerprintResJson.data = new FingerprintResJson.FingerprintDataJson(device_fp);
		}
		return new JsonResult(fingerprintResJson);
	}
}
