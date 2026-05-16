using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMovieRacingDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMovieRacingDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRNb3ZpZVJhY2luZ0RhdGFTY1JzcC5wcm90bxoRQk5JR0lBSk9QR0Mu" + "cHJvdG8iTQoXR2V0TW92aWVSYWNpbmdEYXRhU2NSc3ASIQoLRUtORk9LTlBH" + "SEMYDSADKAsyDC5CTklHSUFKT1BHQxIPCgdyZXRjb2RlGA8gASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BNIGIAJOPGCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMovieRacingDataScRsp), GetMovieRacingDataScRsp.Parser, new string[2] { "EKNFOKNPGHC", "Retcode" }, null, null, null, null)
		}));
	}
}
