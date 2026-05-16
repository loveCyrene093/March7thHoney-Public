using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicPresetAddPlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicPresetAddPlanCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch1SZWxpY1ByZXNldEFkZFBsYW5Dc1JlcS5wcm90bxoRRU5BS0ROQ0VKQk8u";
		buffer[1] = "cHJvdG8aH1JlbGljUHJlc2V0UGxhblNvdXJjZVR5cGUucHJvdG8ioQEKF1Jl";
		buffer[2] = "bGljUHJlc2V0QWRkUGxhbkNzUmVxEiEKC0hCTkhLUERNR0lQGAMgASgOMgwu";
		buffer[3] = "RU5BS0ROQ0VKQk8SEQoJcmVsaWNfaWRzGAQgAygNEhEKCWF2YXRhcl9pZBgF";
		buffer[4] = "IAEoDRIMCgRuYW1lGAsgASgJEi8KC0FMRkhORUhPQkpBGA4gASgOMhouUmVs";
		buffer[5] = "aWNQcmVzZXRQbGFuU291cmNlVHlwZUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[6] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ENAKDNCEJBOReflection.Descriptor,
			RelicPresetPlanSourceTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicPresetAddPlanCsReq), RelicPresetAddPlanCsReq.Parser, new string[5] { "HBNHKPDMGIP", "RelicIds", "AvatarId", "Name", "ALFHNEHOBJA" }, null, null, null, null)
		}));
	}
}
