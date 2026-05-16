using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKHIPFHEKCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKHIPFHEKCKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNS0hJUEZIRUtDSy5wcm90bxoRR0ZPSU9JQUNEQ0gucHJvdG8aEU9FQkpC";
		buffer[1] = "UE5OT0tPLnByb3RvImkKC01LSElQRkhFS0NLEhMKC01GQkRNTFBERU9FGAUg";
		buffer[2] = "ASgNEiEKC3BsYXllcl9pbmZvGA4gAygLMgwuT0VCSkJQTk5PS08SIgoLREZK";
		buffer[3] = "Qk5IUEFJQ0EY5g4gASgLMgwuR0ZPSU9JQUNEQ0hCFqoCE01hcmNoN3RoSG9u";
		buffer[4] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GFOIOIACDCHReflection.Descriptor,
			OEBJBPNNOKOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKHIPFHEKCK), MKHIPFHEKCK.Parser, new string[3] { "MFBDMLPDEOE", "PlayerInfo", "DFJBNHPAICA" }, null, null, null, null)
		}));
	}
}
