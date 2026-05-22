using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFiveDimMiniGameDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFiveDimMiniGameDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRGaXZlRGltTWluaUdhbWVEYXRhU2NSc3AucHJvdG8aEU5IRk1ITENH" + "SkFILnByb3RvIloKG0dldEZpdmVEaW1NaW5pR2FtZURhdGFTY1JzcBIqChRj" + "b250ZW50X3BhY2thZ2VfbGlzdBgEIAMoCzIMLk5IRk1ITENHSkFIEg8KB3Jl" + "dGNvZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { NHFMHLCGJAHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFiveDimMiniGameDataScRsp), GetFiveDimMiniGameDataScRsp.Parser, new string[2] { "ContentPackageList", "Retcode" }, null, null, null, null)
		}));
	}
}
