using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetPlayerInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetPlayerInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRQbGF5ZXJJbmZvQ3NSZXEucHJvdG8aDEdlbmRlci5wcm90byJSChJT" + "ZXRQbGF5ZXJJbmZvQ3NSZXESFwoGZ2VuZGVyGAIgASgOMgcuR2VuZGVyEhAK" + "CG5pY2tuYW1lGAogASgJEhEKCWlzX21vZGlmeRgPIAEoCEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GenderReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetPlayerInfoCsReq), SetPlayerInfoCsReq.Parser, new string[3] { "Gender", "Nickname", "IsModify" }, null, null, null, null)
		}));
	}
}
