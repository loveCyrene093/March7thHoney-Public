using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEBOPKJEMHKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEBOPKJEMHKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUJPUEtKRU1ISy5wcm90bxoRRkRNTUFBSEVGUEsucHJvdG8iQAoLRUVC" + "T1BLSkVNSEsSEwoLSENBRUpGTUtNTkQYByABKA0SHAoGc3RhdHVzGAwgASgO" + "MgwuRkRNTUFBSEVGUEtCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { FDMMAAHEFPKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEBOPKJEMHK), EEBOPKJEMHK.Parser, new string[2] { "HCAEJFMKMND", "Status" }, null, null, null, null)
		}));
	}
}
