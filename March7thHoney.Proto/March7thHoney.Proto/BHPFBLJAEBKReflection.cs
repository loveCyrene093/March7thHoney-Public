using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHPFBLJAEBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHPFBLJAEBKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSFBGQkxKQUVCSy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIkIKC0JI" + "UEZCTEpBRUJLEg8KB3JldGNvZGUYDSABKA0SIgoLS0JFRktPTlBLR0oYDiAB" + "KAsyDS5JdGVtQ29zdERhdGFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BHPFBLJAEBK), BHPFBLJAEBK.Parser, new string[2] { "Retcode", "KBEFKONPKGJ" }, null, null, null, null)
		}));
	}
}
