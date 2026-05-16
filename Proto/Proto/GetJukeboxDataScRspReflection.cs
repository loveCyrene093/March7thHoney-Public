using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetJukeboxDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetJukeboxDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlHZXRKdWtlYm94RGF0YVNjUnNwLnByb3RvGhFNQ1BQSUVKRUJFRi5wcm90";
		buffer[1] = "bxoPTXVzaWNEYXRhLnByb3RvInAKE0dldEp1a2Vib3hEYXRhU2NSc3ASJQoR";
		buffer[2] = "VW5sb2NrZWRNdXNpY0xpc3QYBCADKAsyCi5NdXNpY0RhdGESDwoHcmV0Y29k";
		buffer[3] = "ZRgJIAEoDRIhCgtKSUxLT1BJTkxEQxgOIAEoCzIMLk1DUFBJRUpFQkVGQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MCPPIEJEBEFReflection.Descriptor,
			MusicDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetJukeboxDataScRsp), GetJukeboxDataScRsp.Parser, new string[3] { "UnlockedMusicList", "Retcode", "JILKOPINLDC" }, null, null, null, null)
		}));
	}
}
