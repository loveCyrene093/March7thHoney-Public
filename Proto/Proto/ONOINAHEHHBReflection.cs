using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ONOINAHEHHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ONOINAHEHHBReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFPTk9JTkFIRUhIQi5wcm90bxoRQ05MSUtBRFBDQkgucHJvdG8aEUVGRUdL";
		buffer[1] = "REhFTUZOLnByb3RvIrUBCgtPTk9JTkFIRUhIQhITCgtHQUZQRUNHR0lDQxgD";
		buffer[2] = "IAEoDRITCgtNTlBDQkxFSEdIUBgEIAEoDRIhCgtMSk1NT01JSEdFSRgFIAEo";
		buffer[3] = "CzIMLkVGRUdLREhFTUZOEiEKC0JGTlBDSk9NR0ZMGAYgASgLMgwuRUZFR0tE";
		buffer[4] = "SEVNRk4SIQoLTU1OT0xJTUJQQ0EYCyADKAsyDC5DTkxJS0FEUENCSBITCgtD";
		buffer[5] = "RklPTktLSVBKTBgMIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[6] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CNLIKADPCBHReflection.Descriptor,
			EFEGKDHEMFNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ONOINAHEHHB), ONOINAHEHHB.Parser, new string[6] { "GAFPECGGICC", "MNPCBLEHGHP", "LJMMOMIHGEI", "BFNPCJOMGFL", "MMNOLIMBPCA", "CFIONKKIPJL" }, null, null, null, null)
		}));
	}
}
