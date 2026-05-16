using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RoleTrackEquipmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RoleTrackEquipmentInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChxSb2xlVHJhY2tFcXVpcG1lbnRJbmZvLnByb3RvGh9HcmlkRmlnaHRFcXVp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "cFRyYWNrU291cmNlLnByb3RvIqwBChZSb2xlVHJhY2tFcXVpcG1lbnRJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EioKBnNvdXJjZRgFIAEoDjIaLkdyaWRGaWdodEVxdWlwVHJhY2tTb3VyY2US";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "HAoUZ3JpZF9maWdodF9pdGVtX2xpc3QYBiADKA0SEwoLRkFOT0xOT01IRkkY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ByABKA0SHgoWdHJhY2tfZXF1aXBwZWRfaWRfbGlzdBgMIAMoDRITCgtCQ0dD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "R0hFUERFQRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { GridFightEquipTrackSourceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RoleTrackEquipmentInfo), RoleTrackEquipmentInfo.Parser, new string[5] { "Source", "GridFightItemList", "FANOLNOMHFI", "TrackEquippedIdList", "BCGCGHEPDEA" }, null, null, null, null)
		}));
	}
}
