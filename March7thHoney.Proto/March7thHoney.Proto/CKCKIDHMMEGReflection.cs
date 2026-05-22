using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CKCKIDHMMEGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CKCKIDHMMEGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDS0NLSURITU1FRy5wcm90byJCCgtDS0NLSURITU1FRxILCgNwb3MYBCAB" + "KA0SEwoLSkNNRlBITUZBT04YCiABKA0SEQoJdW5pcXVlX2lkGA4gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CKCKIDHMMEG), CKCKIDHMMEG.Parser, new string[3] { "Pos", "JCMFPHMFAON", "UniqueId" }, null, null, null, null)
		}));
	}
}
