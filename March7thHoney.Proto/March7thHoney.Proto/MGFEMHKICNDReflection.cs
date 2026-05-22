using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MGFEMHKICNDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MGFEMHKICNDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNR0ZFTUhLSUNORC5wcm90byJECgtNR0ZFTUhLSUNORBITCgtMQ0hEQVBF" + "TFBHTxgCIAEoDRITCgtKT0NETUVITkxBRBgEIAEoDRILCgN1aWQYDSABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MGFEMHKICND), MGFEMHKICND.Parser, new string[3] { "LCHDAPELPGO", "JOCDMEHNLAD", "Uid" }, null, null, null, null)
		}));
	}
}
