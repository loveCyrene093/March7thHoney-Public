using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMLCENLAGMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMLCENLAGMNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLTUxDRU5MQUdNTi5wcm90byqBAQoLS01MQ0VOTEFHTU4SGwoXS01MQ0VO";
		buffer[1] = "TEFHTU5fUENQREhFTFBLRU0QABIbChdLTUxDRU5MQUdNTl9BRkdFTkFPSkJM";
		buffer[2] = "RBABEhsKF0tNTENFTkxBR01OX0dKRkpLTEFNS0lIEAISGwoXS01MQ0VOTEFH";
		buffer[3] = "TU5fSUFISUVCQ0ZQQ0QQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KMLCENLAGMN) }, null, null));
	}
}
