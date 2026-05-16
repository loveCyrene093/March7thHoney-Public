using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFPGJKEDKEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFPGJKEDKEBReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFPRlBHSktFREtFQi5wcm90bxoRQ0hESEFGQ0xFREIucHJvdG8aEUdERUVF";
		buffer[1] = "RUFHRElQLnByb3RvGhFHSE5BTEFNS0RMQS5wcm90bxoRS0VHSk1FSkJOQ0ou";
		buffer[2] = "cHJvdG8izAEKC09GUEdKS0VES0VCEhYKDnF1ZXVlX3Bvc2l0aW9uGAcgASgN";
		buffer[3] = "EiQKC0FOTExNQVBCSkZOGI0GIAEoCzIMLkdERUVFRUFHRElQSAASJAoLREpH";
		buffer[4] = "QVBGUEhGSUkYmgogASgLMgwuQ0hESEFGQ0xFREJIABIkCgtNQk9HTlBLQU1J";
		buffer[5] = "RhjyCiABKAsyDC5HSE5BTEFNS0RMQUgAEiQKC0JEUEhJSEJMSk9OGIgNIAEo";
		buffer[6] = "CzIMLktFR0pNRUpCTkNKSABCDQoLQkdHQklNQktIRUlCFqoCE01hcmNoN3Ro";
		buffer[7] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			CHDHAFCLEDBReflection.Descriptor,
			GDEEEEAGDIPReflection.Descriptor,
			GHNALAMKDLAReflection.Descriptor,
			KEGJMEJBNCJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFPGJKEDKEB), OFPGJKEDKEB.Parser, new string[5] { "QueuePosition", "ANLLMAPBJFN", "DJGAPFPHFII", "MBOGNPKAMIF", "BDPHIHBLJON" }, new string[1] { "BGGBIMBKHEI" }, null, null, null)
		}));
	}
}
