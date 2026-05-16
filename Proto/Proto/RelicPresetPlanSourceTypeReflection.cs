using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicPresetPlanSourceTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicPresetPlanSourceTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch9SZWxpY1ByZXNldFBsYW5Tb3VyY2VUeXBlLnByb3RvKqwBChlSZWxpY1By";
		buffer[1] = "ZXNldFBsYW5Tb3VyY2VUeXBlEhsKF0tISU1BUEhLRExJX1BDUERIRUxQS0VN";
		buffer[2] = "EAASGwoXS0hJTUFQSEtETElfRkxGTENFTEZBUEkQARIbChdLSElNQVBIS0RM";
		buffer[3] = "SV9PTkpHRUFBSkRMTRACEhsKF0tISU1BUEhLRExJX0tPQktPQUlETE5GEAMS";
		buffer[4] = "GwoXS0hJTUFQSEtETElfR0JDS0dPSUdHSEsQBEIWqgITTWFyY2g3dGhIb25l";
		buffer[5] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RelicPresetPlanSourceType) }, null, null));
	}
}
