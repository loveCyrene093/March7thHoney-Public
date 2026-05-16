using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraRoundWorkStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraRoundWorkStartCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBDaGltZXJhUm91bmRXb3JrU3RhcnRDc1JlcS5wcm90bxoRRkhDQ0NISkhI";
		buffer[1] = "S0wucHJvdG8aEVBDQU9MSkxGUEJBLnByb3RvIocBChpDaGltZXJhUm91bmRX";
		buffer[2] = "b3JrU3RhcnRDc1JlcRIhCgtLTUFGREZCSkNKSRgCIAMoCzIMLlBDQU9MSkxG";
		buffer[3] = "UEJBEhMKC0dITUpORENBRUVPGAcgASgNEhMKC0ZJR0pITUNFUE9BGAggASgN";
		buffer[4] = "EhwKBmxpbmV1cBgOIAEoCzIMLkZIQ0NDSEpISEtMQhaqAhNNYXJjaDd0aEhv";
		buffer[5] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FHCCCHJHHKLReflection.Descriptor,
			PCAOLJLFPBAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraRoundWorkStartCsReq), ChimeraRoundWorkStartCsReq.Parser, new string[4] { "KMAFDFBJCJI", "GHMJNDCAEEO", "FIGJHMCEPOA", "Lineup" }, null, null, null, null)
		}));
	}
}
