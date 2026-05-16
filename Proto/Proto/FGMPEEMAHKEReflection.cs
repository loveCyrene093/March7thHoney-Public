using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FGMPEEMAHKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FGMPEEMAHKEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGR01QRUVNQUhLRS5wcm90byq7AQoLRkdNUEVFTUFIS0USGwoXRkdNUEVF";
		buffer[1] = "TUFIS0VfUENQREhFTFBLRU0QABIbChdGR01QRUVNQUhLRV9KRE1PTUNQRkhK";
		buffer[2] = "TRABEhsKF0ZHTVBFRU1BSEtFX01OSU1BRkJJR0dQEAISGwoXRkdNUEVFTUFI";
		buffer[3] = "S0VfUFBKT0pPS09PQkYQAxIbChdGR01QRUVNQUhLRV9FREdPSUFPREpMSBAE";
		buffer[4] = "EhsKF0ZHTVBFRU1BSEtFX1BHSklBR0dIQkJBEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FGMPEEMAHKE) }, null, null));
	}
}
