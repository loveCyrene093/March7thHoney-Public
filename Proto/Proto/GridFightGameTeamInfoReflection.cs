using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameTeamInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameTeamInfoReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChtHcmlkRmlnaHRHYW1lVGVhbUluZm8ucHJvdG8aEUNLQ0tJREhNTUVHLnBy";
		buffer[1] = "b3RvGhtHcmlkR2FtZUZvcmdlSXRlbUluZm8ucHJvdG8aFUdyaWRHYW1lTnBj";
		buffer[2] = "SW5mby5wcm90bxoWR3JpZEdhbWVSb2xlSW5mby5wcm90byL9AQoVR3JpZEZp";
		buffer[3] = "Z2h0R2FtZVRlYW1JbmZvEhMKC0NETEFJSkNLSkpOGAUgAygNEjkKGWdyaWRf";
		buffer[4] = "Z2FtZV9mb3JnZV9pdGVtX2xpc3QYCCADKAsyFi5HcmlkR2FtZUZvcmdlSXRl";
		buffer[5] = "bUluZm8SLAoSZ3JpZF9nYW1lX25wY19saXN0GAogAygLMhAuR3JpZEdhbWVO";
		buffer[6] = "cGNJbmZvEiEKC01NQUpDTEFDT0JOGA0gAygLMgwuQ0tDS0lESE1NRUcSLgoT";
		buffer[7] = "Z3JpZF9nYW1lX3JvbGVfbGlzdBgOIAMoCzIRLkdyaWRHYW1lUm9sZUluZm8S";
		buffer[8] = "EwoLSE9GSUVOTUFMT1AYDyADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[9] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			CKCKIDHMMEGReflection.Descriptor,
			GridGameForgeItemInfoReflection.Descriptor,
			GridGameNpcInfoReflection.Descriptor,
			GridGameRoleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameTeamInfo), GridFightGameTeamInfo.Parser, new string[6] { "CDLAIJCKJJN", "GridGameForgeItemList", "GridGameNpcList", "MMAJCLACOBN", "GridGameRoleList", "HOFIENMALOP" }, null, null, null, null)
		}));
	}
}
