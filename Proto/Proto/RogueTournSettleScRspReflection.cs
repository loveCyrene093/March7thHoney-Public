using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournSettleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournSettleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtSb2d1ZVRvdXJuU2V0dGxlU2NSc3AucHJvdG8aEUFMR0pPTUZDTEtMLnBy";
		buffer[1] = "b3RvGhFCRkVJUEVMRkNERi5wcm90byJuChVSb2d1ZVRvdXJuU2V0dGxlU2NS";
		buffer[2] = "c3ASIQoLQUZMSkpKRkNCSU4YByABKAsyDC5CRkVJUEVMRkNERhIhCgtFREtK";
		buffer[3] = "TVBBQ0hOShgJIAEoCzIMLkFMR0pPTUZDTEtMEg8KB3JldGNvZGUYDCABKA1C";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ALGJOMFCLKLReflection.Descriptor,
			BFEIPELFCDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSettleScRsp), RogueTournSettleScRsp.Parser, new string[3] { "AFLJJJFCBIN", "EDKJMPACHNJ", "Retcode" }, null, null, null, null)
		}));
	}
}
