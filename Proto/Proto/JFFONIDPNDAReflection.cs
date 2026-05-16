using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JFFONIDPNDAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JFFONIDPNDAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKRkZPTklEUE5EQS5wcm90byqBAQoLSkZGT05JRFBOREESGwoXSkZGT05J";
		buffer[1] = "RFBOREFfUENQREhFTFBLRU0QABIbChdKRkZPTklEUE5EQV9MTUZKSUNKTEFO";
		buffer[2] = "TBABEhsKF0pGRk9OSURQTkRBX0lBTURFT0lQTU1EEAISGwoXSkZGT05JRFBO";
		buffer[3] = "REFfTENMT0JQSkdDTUUQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JFFONIDPNDA) }, null, null));
	}
}
