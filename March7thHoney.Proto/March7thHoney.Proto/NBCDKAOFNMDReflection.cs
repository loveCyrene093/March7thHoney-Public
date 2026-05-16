using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBCDKAOFNMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBCDKAOFNMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQkNES0FPRk5NRC5wcm90byIgCgtOQkNES0FPRk5NRBIRCglzdG9wX2Rl" + "c2MYCiABKAlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBCDKAOFNMD), NBCDKAOFNMD.Parser, new string[1] { "StopDesc" }, null, null, null, null)
		}));
	}
}
