using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesCardPieceApplyPermissionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesCardPieceApplyPermissionTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitQbGFuZXRGZXNDYXJkUGllY2VBcHBseVBlcm1pc3Npb25UeXBlLnByb3Rv";
		buffer[1] = "Kn4KJVBsYW5ldEZlc0NhcmRQaWVjZUFwcGx5UGVybWlzc2lvblR5cGUSGwoX";
		buffer[2] = "UFBKUEpLUEpITUdfTktBREZDTUVLR04QABIbChdQUEpQSktQSkhNR19QTUpN";
		buffer[3] = "RUZER09IQxABEhsKF1BQSlBKS1BKSE1HX0hMUEZCTUJES1BQEAJCFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PlanetFesCardPieceApplyPermissionType) }, null, null));
	}
}
