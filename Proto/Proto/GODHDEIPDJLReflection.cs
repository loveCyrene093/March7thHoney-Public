using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GODHDEIPDJLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GODHDEIPDJLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHT0RIREVJUERKTC5wcm90bxoQTW90aW9uSW5mby5wcm90byKBAQoLR09E";
		buffer[1] = "SERFSVBESkwSEwoLTUhJTktBREpDQ0cYASABKAwSEwoLQU1CTExGTEZLSEMY";
		buffer[2] = "BCABKA0SIAoLUExGQU9DUEJCQ1AYBSABKAsyCy5Nb3Rpb25JbmZvEhEKCWNv";
		buffer[3] = "bmZpZ19pZBgGIAEoDRITCgtKTE1KRkVETkJNRhgJIAEoDUIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GODHDEIPDJL), GODHDEIPDJL.Parser, new string[5] { "MHINKADJCCG", "AMBLLFLFKHC", "PLFAOCPBBCP", "ConfigId", "JLMJFEDNBMF" }, null, null, null, null)
		}));
	}
}
