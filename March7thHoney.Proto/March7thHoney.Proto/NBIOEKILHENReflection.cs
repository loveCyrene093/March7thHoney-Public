using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBIOEKILHENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBIOEKILHENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQklPRUtJTEhFTi5wcm90bxoRTUdHTERISFBOQk0ucHJvdG8iQwoLTkJJ" + "T0VLSUxIRU4SIQoLQUFHQkxQS0RKSlAYASABKAsyDC5NR0dMREhIUE5CTRIR" + "CglhdmF0YXJfaWQYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { MGGLDHHPNBMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBIOEKILHEN), NBIOEKILHEN.Parser, new string[2] { "AAGBLPKDJJP", "AvatarId" }, null, null, null, null)
		}));
	}
}
