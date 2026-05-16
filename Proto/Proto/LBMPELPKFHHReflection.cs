using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBMPELPKFHHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBMPELPKFHHReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFMQk1QRUxQS0ZISC5wcm90bxoRQ0NMR0pHRExBREUucHJvdG8aEU5OSkdK";
		buffer[1] = "SUpFSkNMLnByb3RvGhFOTktKQk5OQU5KSy5wcm90byKIAgoLTEJNUEVMUEtG";
		buffer[2] = "SEgSIQoLTkNPTklHSEpFREkYASADKAsyDC5OTktKQk5OQU5KSxITCgtJRkNH";
		buffer[3] = "Tk9GTkRNQRgCIAEoCRIYChBkZWJ1Z19leHRyYV9pbmZvGAMgASgJEiEKC0JL";
		buffer[4] = "TE9BRUNQT0VEGAQgAygLMgwuQ0NMR0pHRExBREUSEAoIcGxhbmVfaWQYBSAB";
		buffer[5] = "KA0SEAoIZmxvb3JfaWQYBiABKA0SEwoLRkFQQ0ZBSEtLRk8YByABKA0SEwoL";
		buffer[6] = "Qk9MTk5CT09JT0kYCCABKA0SIQoLTUVQRFBDTkhDQUUYCSABKAsyDC5OTkpH";
		buffer[7] = "SklKRUpDTBITCgtBT0pMRE9MTUVHSxgKIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[8] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CCLGJGDLADEReflection.Descriptor,
			NNJGJIJEJCLReflection.Descriptor,
			NNKJBNNANJKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LBMPELPKFHH), LBMPELPKFHH.Parser, new string[10] { "NCONIGHJEDI", "IFCGNOFNDMA", "DebugExtraInfo", "BKLOAECPOED", "PlaneId", "FloorId", "FAPCFAHKKFO", "BOLNNBOOIOI", "MEPDPCNHCAE", "AOJLDOLMEGK" }, null, null, null, null)
		}));
	}
}
