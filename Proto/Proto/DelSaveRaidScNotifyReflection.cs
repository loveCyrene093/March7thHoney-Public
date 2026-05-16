using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DelSaveRaidScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DelSaveRaidScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlEZWxTYXZlUmFpZFNjTm90aWZ5LnByb3RvIjsKE0RlbFNhdmVSYWlkU2NO" + "b3RpZnkSDwoHcmFpZF9pZBgGIAEoDRITCgt3b3JsZF9sZXZlbBgJIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DelSaveRaidScNotify), DelSaveRaidScNotify.Parser, new string[2] { "RaidId", "WorldLevel" }, null, null, null, null)
		}));
	}
}
