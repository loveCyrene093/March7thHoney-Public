using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGHJPDIDOBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGHJPDIDOBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR0hKUERJRE9CSS5wcm90bxoRT0lJQURKQ0VNS0IucHJvdG8iQwoLQ0dI" + "SlBESURPQkkSIQoLYXZhdGFyX2xpc3QYByADKAsyDC5PSUlBREpDRU1LQhIR" + "CglidWZmX2xpc3QYDCADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { OIIADJCEMKBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGHJPDIDOBI), CGHJPDIDOBI.Parser, new string[2] { "AvatarList", "BuffList" }, null, null, null, null)
		}));
	}
}
