using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GAELJJDDEMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GAELJJDDEMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQUVMSkpEREVNRC5wcm90byJHCgtHQUVMSkpEREVNRBIQCghldmVudF9p" + "ZBgCIAEoDRIPCgdyZXRjb2RlGAogASgNEhUKDWRpc3BsYXlfdmFsdWUYDSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GAELJJDDEMD), GAELJJDDEMD.Parser, new string[3] { "EventId", "Retcode", "DisplayValue" }, null, null, null, null)
		}));
	}
}
