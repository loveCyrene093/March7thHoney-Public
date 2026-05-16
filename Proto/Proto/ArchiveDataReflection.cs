using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ArchiveDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ArchiveDataReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFBcmNoaXZlRGF0YS5wcm90bxoRTW9uc3Rlckxpc3QucHJvdG8aD1JlbGlj";
		buffer[1] = "TGlzdC5wcm90byLEAQoLQXJjaGl2ZURhdGESHgoWYXJjaGl2ZV9hdmF0YXJf";
		buffer[2] = "aWRfbGlzdBgCIAMoDRInChFraWxsX21vbnN0ZXJfbGlzdBgGIAMoCzIMLk1v";
		buffer[3] = "bnN0ZXJMaXN0EiEKGWFyY2hpdmVfZXF1aXBtZW50X2lkX2xpc3QYByADKA0S";
		buffer[4] = "HgoKcmVsaWNfbGlzdBgIIAMoCzIKLlJlbGljTGlzdBIpCiFhcmNoaXZlX21p";
		buffer[5] = "c3NpbmdfZXF1aXBtZW50X2lkX2xpc3QYDCADKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[6] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MonsterListReflection.Descriptor,
			RelicListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ArchiveData), ArchiveData.Parser, new string[5] { "ArchiveAvatarIdList", "KillMonsterList", "ArchiveEquipmentIdList", "RelicList", "ArchiveMissingEquipmentIdList" }, null, null, null, null)
		}));
	}
}
