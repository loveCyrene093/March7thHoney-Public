using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPPFOMBLOIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPPFOMBLOIFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUFBGT01CTE9JRi5wcm90bxoRQk5ESEpOREZGRUQucHJvdG8iOgoLUFBQ" + "Rk9NQkxPSUYSDQoFaW5kZXgYBSABKA0SHAoGc3RhdHVzGAcgASgOMgwuQk5E" + "SEpOREZGRURCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { BNDHJNDFFEDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPPFOMBLOIF), PPPFOMBLOIF.Parser, new string[2] { "Index", "Status" }, null, null, null, null)
		}));
	}
}
