using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CKEJAJOCNGOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CKEJAJOCNGOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDS0VKQUpPQ05HTy5wcm90byINCgtDS0VKQUpPQ05HT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CKEJAJOCNGO), CKEJAJOCNGO.Parser, null, null, null, null, null)
		}));
	}
}
