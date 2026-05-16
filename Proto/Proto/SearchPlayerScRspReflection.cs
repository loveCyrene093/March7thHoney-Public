using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SearchPlayerScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SearchPlayerScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdTZWFyY2hQbGF5ZXJTY1JzcC5wcm90bxoWUGxheWVyU2ltcGxlSW5mby5w";
		buffer[1] = "cm90byJqChFTZWFyY2hQbGF5ZXJTY1JzcBIrChBzaW1wbGVfaW5mb19saXN0";
		buffer[2] = "GAcgAygLMhEuUGxheWVyU2ltcGxlSW5mbxIXCg9yZXN1bHRfdWlkX2xpc3QY";
		buffer[3] = "CiADKA0SDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PlayerSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SearchPlayerScRsp), SearchPlayerScRsp.Parser, new string[3] { "SimpleInfoList", "ResultUidList", "Retcode" }, null, null, null, null)
		}));
	}
}
