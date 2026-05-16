using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CALIPIKFDEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CALIPIKFDEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQUxJUElLRkRFSi5wcm90bxoRT0RNSkFDSUtFUEMucHJvdG8iQwoLQ0FM" + "SVBJS0ZERUoSEQoJYXZhdGFyX2lkGAEgASgNEiEKC0dGT01CR0xOTEtJGAkg" + "ASgOMgwuT0RNSkFDSUtFUENCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { ODMJACIKEPCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CALIPIKFDEJ), CALIPIKFDEJ.Parser, new string[2] { "AvatarId", "GFOMBGLNLKI" }, null, null, null, null)
		}));
	}
}
