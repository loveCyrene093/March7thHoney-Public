using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class WorldUnlockScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static WorldUnlockScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZXb3JsZFVubG9ja1NjUnNwLnByb3RvIjgKEFdvcmxkVW5sb2NrU2NSc3AS" + "DwoHcmV0Y29kZRgCIAEoDRITCgtMTE9MT0VIUEZIQRgGIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(WorldUnlockScRsp), WorldUnlockScRsp.Parser, new string[2] { "Retcode", "LLOLOEHPFHA" }, null, null, null, null)
		}));
	}
}
