using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageDataReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhDb250ZW50UGFja2FnZURhdGEucHJvdG8aGENvbnRlbnRQYWNrYWdlSW5m";
		buffer[1] = "by5wcm90byJfChJDb250ZW50UGFja2FnZURhdGESFgoOY3VyX2NvbnRlbnRf";
		buffer[2] = "aWQYDSABKA0SMQoUY29udGVudF9wYWNrYWdlX2xpc3QYDiADKAsyEy5Db250";
		buffer[3] = "ZW50UGFja2FnZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ContentPackageInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageData), ContentPackageData.Parser, new string[2] { "CurContentId", "ContentPackageList" }, null, null, null, null)
		}));
	}
}
