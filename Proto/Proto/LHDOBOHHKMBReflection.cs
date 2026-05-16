using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHDOBOHHKMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHDOBOHHKMBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMSERPQk9ISEtNQi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIpIBCgtM";
		buffer[1] = "SERPQk9ISEtNQhITCgtBT0tEQkRHRENIQhgEIAEoDRIgCgljb3N0X2RhdGEY";
		buffer[2] = "BiABKAsyDS5JdGVtQ29zdERhdGESIgoLRUtLSUFITk1ESE0YCyABKAsyDS5J";
		buffer[3] = "dGVtQ29zdERhdGESEwoLS0xOSExFSktETUwYDCABKAgSEwoLQ0VIT1BISkhE";
		buffer[4] = "RUYYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHDOBOHHKMB), LHDOBOHHKMB.Parser, new string[5] { "AOKDBDGDCHB", "CostData", "EKKIAHNMDHM", "KLNHLEJKDML", "CEHOPHJHDEF" }, null, null, null, null)
		}));
	}
}
