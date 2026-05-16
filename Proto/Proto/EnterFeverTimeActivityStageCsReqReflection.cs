using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterFeverTimeActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterFeverTimeActivityStageCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZFbnRlckZldmVyVGltZUFjdGl2aXR5U3RhZ2VDc1JlcS5wcm90bxoRSEFK";
		buffer[1] = "QU9HR1BDSkMucHJvdG8iewogRW50ZXJGZXZlclRpbWVBY3Rpdml0eVN0YWdl";
		buffer[2] = "Q3NSZXESIQoLYXZhdGFyX2xpc3QYASADKAsyDC5IQUpBT0dHUENKQxITCgtN";
		buffer[3] = "Qk5OQUdFSUFBSBgFIAEoDRIKCgJpZBgIIAEoDRITCgtHREJPT0RLTEJNSxgN";
		buffer[4] = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HAJAOGGPCJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFeverTimeActivityStageCsReq), EnterFeverTimeActivityStageCsReq.Parser, new string[4] { "AvatarList", "MBNNAGEIAAH", "Id", "GDBOODKLBMK" }, null, null, null, null)
		}));
	}
}
