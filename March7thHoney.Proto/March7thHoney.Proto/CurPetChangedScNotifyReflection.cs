using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CurPetChangedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CurPetChangedScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDdXJQZXRDaGFuZ2VkU2NOb3RpZnkucHJvdG8iKwoVQ3VyUGV0Q2hhbmdl" + "ZFNjTm90aWZ5EhIKCmN1cl9wZXRfaWQYCCABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CurPetChangedScNotify), CurPetChangedScNotify.Parser, new string[1] { "CurPetId" }, null, null, null, null)
		}));
	}
}
