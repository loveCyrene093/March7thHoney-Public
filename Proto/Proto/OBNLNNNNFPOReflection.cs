using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBNLNNNNFPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBNLNNNNFPOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFPQk5MTk5OTkZQTy5wcm90byKLAQoLT0JOTE5OTk5GUE8SEwoLRUlJQUdB";
		buffer[1] = "QkFGRUMYASABKA0SEwoLUE9JQ09MTUJNSUcYBSABKAgSEwoLSkFGTkNPTUdB";
		buffer[2] = "QkcYBiABKA0SEwoLS1BGSEJEREVLTEoYCCABKA0SEwoLSUFMSk9KTUFGTEwY";
		buffer[3] = "DCABKA0SEwoLS09DR0dIUEtGQVAYDiABKAhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBNLNNNNFPO), OBNLNNNNFPO.Parser, new string[6] { "EIIAGABAFEC", "POICOLMBMIG", "JAFNCOMGABG", "KPFHBDDEKLJ", "IALJOJMAFLL", "KOCGGHPKFAP" }, null, null, null, null)
		}));
	}
}
