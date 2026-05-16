using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureUpdatePasterPosCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureUpdatePasterPosCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CihUcmF2ZWxCcm9jaHVyZVVwZGF0ZVBhc3RlclBvc0NzUmVxLnByb3RvIrEB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "CiJUcmF2ZWxCcm9jaHVyZVVwZGF0ZVBhc3RlclBvc0NzUmVxEg8KB2l0ZW1f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "aWQYAyABKA0SEwoLSEtJT01DT0NETkYYBSABKAUSEwoLS1BHTUJLS09HSkcY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "BiABKA0SEwoLSEJDSlBDTUpQSEUYByABKA0SEwoLQUVIS05HQktQQkUYCyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KA0SEwoLQ0ZJRE1NRkZCT0UYDSABKAUSEQoJdW5pcXVlX2lkGA4gASgEQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureUpdatePasterPosCsReq), TravelBrochureUpdatePasterPosCsReq.Parser, new string[7] { "ItemId", "HKIOMCOCDNF", "KPGMBKKOGJG", "HBCJPCMJPHE", "AEHKNGBKPBE", "CFIDMMFFBOE", "UniqueId" }, null, null, null, null)
		}));
	}
}
