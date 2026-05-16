using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHLDNDDFEIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHLDNDDFEIEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSExETkRERkVJRS5wcm90byI7CgtHSExETkRERkVJRRIPCgdhcmVhX2lk" + "GAEgASgNEhsKE3ZlcmlmeV9zdGVwX2lkX2xpc3QYDiADKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GHLDNDDFEIE), GHLDNDDFEIE.Parser, new string[2] { "AreaId", "VerifyStepIdList" }, null, null, null, null)
		}));
	}
}
