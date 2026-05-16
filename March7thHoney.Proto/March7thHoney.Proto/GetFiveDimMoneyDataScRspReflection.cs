using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFiveDimMoneyDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFiveDimMoneyDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRGaXZlRGltTW9uZXlEYXRhU2NSc3AucHJvdG8iVQoYR2V0Rml2ZURp" + "bU1vbmV5RGF0YVNjUnNwEhMKC0pLTERPRkJIQUJNGAIgASgNEg8KB3JldGNv" + "ZGUYCCABKA0SEwoLTkRLTU9JTkxPT0UYDCABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFiveDimMoneyDataScRsp), GetFiveDimMoneyDataScRsp.Parser, new string[3] { "JKLDOFBHABM", "Retcode", "NDKMOINLOOE" }, null, null, null, null)
		}));
	}
}
