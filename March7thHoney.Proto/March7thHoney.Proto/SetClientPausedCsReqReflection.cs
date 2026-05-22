using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetClientPausedCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetClientPausedCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRDbGllbnRQYXVzZWRDc1JlcS5wcm90byImChRTZXRDbGllbnRQYXVz" + "ZWRDc1JlcRIOCgZwYXVzZWQYCiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetClientPausedCsReq), SetClientPausedCsReq.Parser, new string[1] { "Paused" }, null, null, null, null)
		}));
	}
}
