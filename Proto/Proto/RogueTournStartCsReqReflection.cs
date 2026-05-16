using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournStartCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpSb2d1ZVRvdXJuU3RhcnRDc1JlcS5wcm90bxoRSEREQkpJS05FUEYucHJv";
		buffer[1] = "dG8idAoUUm9ndWVUb3VyblN0YXJ0Q3NSZXESEwoLS0JKQUhGTE9PSUoYBSAB";
		buffer[2] = "KAgSDwoHYXJlYV9pZBgGIAEoDRIhCgthdmF0YXJfbGlzdBgHIAMoCzIMLkhE";
		buffer[3] = "REJKSUtORVBGEhMKC1BOTktGQklMSUVIGAsgASgIQhaqAhNNYXJjaDd0aEhv";
		buffer[4] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HDDBJIKNEPFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournStartCsReq), RogueTournStartCsReq.Parser, new string[4] { "KBJAHFLOOIJ", "AreaId", "AvatarList", "PNNKFBILIEH" }, null, null, null, null)
		}));
	}
}
