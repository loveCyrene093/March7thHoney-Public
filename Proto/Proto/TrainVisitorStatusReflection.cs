using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainVisitorStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainVisitorStatusReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChhUcmFpblZpc2l0b3JTdGF0dXMucHJvdG8qpQEKElRyYWluVmlzaXRvclN0";
		buffer[1] = "YXR1cxIbChdKRFBKSE1IT01MRl9QQ1BESEVMUEtFTRAAEhsKF0pEUEpITUhP";
		buffer[2] = "TUxGX0tFSUJDUEFORUdBEAESGwoXSkRQSkhNSE9NTEZfQ0pOQkNOTkFDTkoQ";
		buffer[3] = "AhIbChdKRFBKSE1IT01MRl9BQ05OR0pITExKRBADEhsKF0pEUEpITUhPTUxG";
		buffer[4] = "X0VBQ0NHR0xER0VMEARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TrainVisitorStatus) }, null, null));
	}
}
