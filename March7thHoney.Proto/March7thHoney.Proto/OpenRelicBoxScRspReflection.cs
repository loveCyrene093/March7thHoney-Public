using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenRelicBoxScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenRelicBoxScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdPcGVuUmVsaWNCb3hTY1JzcC5wcm90bxoRUEdMRkFDSENHQ0IucHJvdG8i" + "XAoRT3BlblJlbGljQm94U2NSc3ASEwoLQkRDSktGUEdNRkwYASABKA0SDwoH" + "cmV0Y29kZRgJIAEoDRIhCgtDR0NKTEhGTEVQThgMIAEoCzIMLlBHTEZBQ0hD" + "R0NCQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PGLFACHCGCBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenRelicBoxScRsp), OpenRelicBoxScRsp.Parser, new string[3] { "BDCJKFPGMFL", "Retcode", "CGCJLHFLEPN" }, null, null, null, null)
		}));
	}
}
