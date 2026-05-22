using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdatePlayerSettingCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdatePlayerSettingCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VcGRhdGVQbGF5ZXJTZXR0aW5nQ3NSZXEucHJvdG8aGVVwZGF0ZVBsYXll" + "clNldHRpbmcucHJvdG8iSAoYVXBkYXRlUGxheWVyU2V0dGluZ0NzUmVxEiwK" + "DnBsYXllcl9zZXR0aW5nGAMgASgLMhQuVXBkYXRlUGxheWVyU2V0dGluZ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { UpdatePlayerSettingReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdatePlayerSettingCsReq), UpdatePlayerSettingCsReq.Parser, new string[1] { "PlayerSetting" }, null, null, null, null)
		}));
	}
}
