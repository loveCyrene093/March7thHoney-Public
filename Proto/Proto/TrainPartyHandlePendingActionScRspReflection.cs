using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyHandlePendingActionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyHandlePendingActionScRspReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "CihUcmFpblBhcnR5SGFuZGxlUGVuZGluZ0FjdGlvblNjUnNwLnByb3RvGhFE";
		buffer[1] = "T0FJQ1BBTU5ETi5wcm90bxoRRUZCREtFSExDREYucHJvdG8aEUhLSkFES0xJ";
		buffer[2] = "QkVILnByb3RvGhFNQUdGS0ZDTUxKTS5wcm90bxoRT05BTUpBTk9CT00ucHJv";
		buffer[3] = "dG8irAIKIlRyYWluUGFydHlIYW5kbGVQZW5kaW5nQWN0aW9uU2NSc3ASIQoL";
		buffer[4] = "T0ZDS0hHTElOQUcYASABKAsyDC5NQUdGS0ZDTUxKTRIPCgdyZXRjb2RlGAYg";
		buffer[5] = "ASgNEhYKDnF1ZXVlX3Bvc2l0aW9uGAsgASgNEhMKC0tFSk9QUElETlBQGA4g";
		buffer[6] = "ASgIEiQKC0RDQ0ZIUEJCS01EGNMFIAEoCzIMLkRPQUlDUEFNTkROSAASJAoL";
		buffer[7] = "TURLTkhCRE5CUFAY9wkgASgLMgwuSEtKQURLTElCRUhIABIkCgtCTklIRUtP";
		buffer[8] = "Sk1ORBjNCiABKAsyDC5PTkFNSkFOT0JPTUgAEiQKC0xPT0ZQQ1BKUEhOGKwO";
		buffer[9] = "IAEoCzIMLkVGQkRLRUhMQ0RGSABCDQoLUE5LUENQRkJIQUFCFqoCE01hcmNo";
		buffer[10] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			DOAICPAMNDNReflection.Descriptor,
			EFBDKEHLCDFReflection.Descriptor,
			HKJADKLIBEHReflection.Descriptor,
			MAGFKFCMLJMReflection.Descriptor,
			ONAMJANOBOMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyHandlePendingActionScRsp), TrainPartyHandlePendingActionScRsp.Parser, new string[8] { "OFCKHGLINAG", "Retcode", "QueuePosition", "KEJOPPIDNPP", "DCCFHPBBKMD", "MDKNHBDNBPP", "BNIHEKOJMND", "LOOFPCPJPHN" }, new string[1] { "PNKPCPFBHAA" }, null, null, null)
		}));
	}
}
