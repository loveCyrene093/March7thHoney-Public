using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueTalentInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueTalentInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRSb2d1ZVRhbGVudEluZm9TY1JzcC5wcm90bxoRTUNBQ0RGSENQSUUu" + "cHJvdG8iTQoXR2V0Um9ndWVUYWxlbnRJbmZvU2NSc3ASIQoLdGFsZW50X2lu" + "Zm8YByABKAsyDC5NQ0FDREZIQ1BJRRIPCgdyZXRjb2RlGAsgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueTalentInfoScRsp), GetRogueTalentInfoScRsp.Parser, new string[2] { "TalentInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
