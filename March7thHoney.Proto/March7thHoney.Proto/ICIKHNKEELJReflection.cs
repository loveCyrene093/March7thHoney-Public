using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICIKHNKEELJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICIKHNKEELJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQ0lLSE5LRUVMSi5wcm90byJxCgtJQ0lLSE5LRUVMShIPCgdyb2xlX2lk" + "GAMgASgNEhEKCXJvbGVfc3RhchgHIAEoDRILCgNwb3MYCSABKA0SHAoUZ3Jp" + "ZF9maWdodF9pdGVtX2xpc3QYDCADKA0SEwoLTUhGRERNS01GQUgYDiABKAhC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICIKHNKEELJ), ICIKHNKEELJ.Parser, new string[5] { "RoleId", "RoleStar", "Pos", "GridFightItemList", "MHFDDMKMFAH" }, null, null, null, null)
		}));
	}
}
