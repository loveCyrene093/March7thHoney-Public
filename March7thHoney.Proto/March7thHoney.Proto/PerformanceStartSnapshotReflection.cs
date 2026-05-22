using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PerformanceStartSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PerformanceStartSnapshotReflection()
	{
		_003C_003Ey__InlineArray28<string> buffer = default(_003C_003Ey__InlineArray28<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 0) = "Ch5QZXJmb3JtYW5jZVN0YXJ0U25hcHNob3QucHJvdG8aFERpYWxvZ1NuYXBz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 1) = "aG90LnByb3RvGhhFcmFGbGlwcGVyU25hcHNob3QucHJvdG8aHkZsb29yQ3Vz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 2) = "dG9tVmFsdWVTbmFwc2hvdC5wcm90bxoTR3JvdXBTbmFwc2hvdC5wcm90bxoZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 3) = "TWFwUm90YXRpb25TbmFwc2hvdC5wcm90bxoVTWlzc2lvblNuYXBzaG90LnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 4) = "b3RvGhRQbGF5ZXJTbmFwc2hvdC5wcm90bxoYU3dpdGNoSGFuZFNuYXBzaG90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 5) = "LnByb3RvItsHChhQZXJmb3JtYW5jZVN0YXJ0U25hcHNob3QSFgoOcGVyZm9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 6) = "bWFuY2VfaWQYASABKA0SGAoQcGVyZm9ybWFuY2VfdHlwZRgCIAEoDRIQCghw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 7) = "bGFuZV9pZBgDIAEoDRIQCghmbG9vcl9pZBgEIAEoDRIUCgxkaW1lbnNpb25f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 8) = "aWQYBSABKA0SFQoNc3RvcnlfbGluZV9pZBgGIAEoDRISCgpjb250ZW50X2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 9) = "GAcgASgNEhAKCGVudHJ5X2lkGAggASgNEg8KB3ZlcnNpb24YCSABKA0SHwoG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 10) = "cGxheWVyGAogASgLMg8uUGxheWVyU25hcHNob3QSIQoHbWlzc2lvbhgLIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 11) = "CzIQLk1pc3Npb25TbmFwc2hvdBIoCgtlcmFfZmxpcHBlchgMIAEoCzITLkVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 12) = "YUZsaXBwZXJTbmFwc2hvdBIpChFzZXJ2ZXJfZ3JvdXBfbGlzdBgNIAMoCzIO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 13) = "Lkdyb3VwU25hcHNob3QSKQoRY2xpZW50X2dyb3VwX2xpc3QYDiADKAsyDi5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 14) = "cm91cFNuYXBzaG90EjAKGHNlcnZlcl9sZWdhY3lfZ3JvdXBfbGlzdBgPIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 15) = "CzIOLkdyb3VwU25hcHNob3QSMAoYY2xpZW50X2xlZ2FjeV9ncm91cF9saXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 16) = "GBAgAygLMg4uR3JvdXBTbmFwc2hvdBJSChZmbG9vcl9zYXZlZF92YWx1ZV9s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 17) = "aXN0GBEgAygLMjIuUGVyZm9ybWFuY2VTdGFydFNuYXBzaG90LkZsb29yU2F2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 18) = "ZWRWYWx1ZUxpc3RFbnRyeRJUChdmbG9vcl9jdXN0b21fdmFsdWVfbGlzdBgS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 19) = "IAMoCzIzLlBlcmZvcm1hbmNlU3RhcnRTbmFwc2hvdC5GbG9vckN1c3RvbVZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 20) = "bHVlTGlzdEVudHJ5EioKDG1hcF9yb3RhdGlvbhgTIAEoCzIULk1hcFJvdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 21) = "aW9uU25hcHNob3QSEAoId29ybGRfaWQYFCABKA0SHwoGZGlhbG9nGBUgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 22) = "Mg8uRGlhbG9nU25hcHNob3QSFgoOb3duZXJfZ3JvdXBfaWQYFiABKA0SKAoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 23) = "c3dpdGNoX2hhbmQYFyABKAsyEy5Td2l0Y2hIYW5kU25hcHNob3QaOgoYRmxv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 24) = "b3JTYXZlZFZhbHVlTGlzdEVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 25) = "IAEoBToCOAEaVgoZRmxvb3JDdXN0b21WYWx1ZUxpc3RFbnRyeRILCgNrZXkY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 26) = "ASABKAkSKAoFdmFsdWUYAiABKAsyGS5GbG9vckN1c3RvbVZhbHVlU25hcHNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 27) = "b3Q6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray28<string>, string>(in buffer, 28))), new FileDescriptor[8]
		{
			DialogSnapshotReflection.Descriptor,
			EraFlipperSnapshotReflection.Descriptor,
			FloorCustomValueSnapshotReflection.Descriptor,
			GroupSnapshotReflection.Descriptor,
			MapRotationSnapshotReflection.Descriptor,
			MissionSnapshotReflection.Descriptor,
			PlayerSnapshotReflection.Descriptor,
			SwitchHandSnapshotReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PerformanceStartSnapshot), PerformanceStartSnapshot.Parser, new string[23]
			{
				"PerformanceId", "PerformanceType", "PlaneId", "FloorId", "DimensionId", "StoryLineId", "ContentId", "EntryId", "Version", "Player",
				"Mission", "EraFlipper", "ServerGroupList", "ClientGroupList", "ServerLegacyGroupList", "ClientLegacyGroupList", "FloorSavedValueList", "FloorCustomValueList", "MapRotation", "WorldId",
				"Dialog", "OwnerGroupId", "SwitchHand"
			}, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
