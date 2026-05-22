using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleRecordTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleRecordTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZCYXR0bGVSZWNvcmRUeXBlLnByb3RvKmAKEEJhdHRsZVJlY29yZFR5cGUS" + "FgoSQkFUVExFX1JFQ09SRF9OT05FEAASGwoXQkFUVExFX1JFQ09SRF9DSEFM" + "TEVOR0UQARIXChNCQVRUTEVfUkVDT1JEX1JPR1VFEAJCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BattleRecordType) }, null, null));
	}
}
