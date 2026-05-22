using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleGetDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJibGVHZXREYXRhU2NSc3AucHJvdG8idgoSTWFyYmxlR2V0RGF0YVNj" + "UnNwEhMKC0NOTEJOQUNGQ0pFGAIgAygNEhMKC0pIRE1HRkdKTUVCGAcgAygN" + "Eg8KB3JldGNvZGUYCyABKA0SEwoLSElLREFNTUZHREoYDiADKA0SEAoIc2Nv" + "cmVfaWQYDyABKAVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleGetDataScRsp), MarbleGetDataScRsp.Parser, new string[5] { "CNLBNACFCJE", "JHDMGFGJMEB", "Retcode", "HIKDAMMFGDJ", "ScoreId" }, null, null, null, null)
		}));
	}
}
