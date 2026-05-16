using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantUpgradeFacilityLevelCsReq : IMessage<ElfRestaurantUpgradeFacilityLevelCsReq>, IMessage, IEquatable<ElfRestaurantUpgradeFacilityLevelCsReq>, IDeepCloneable<ElfRestaurantUpgradeFacilityLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantUpgradeFacilityLevelCsReq> _parser = new MessageParser<ElfRestaurantUpgradeFacilityLevelCsReq>(() => new ElfRestaurantUpgradeFacilityLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ODADJILOEKOFieldNumber = 6;

	private uint oDADJILOEKO_;

	public const int KBMMGOJKAPFFieldNumber = 14;

	private uint kBMMGOJKAPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantUpgradeFacilityLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantUpgradeFacilityLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODADJILOEKO
	{
		get
		{
			return oDADJILOEKO_;
		}
		set
		{
			oDADJILOEKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBMMGOJKAPF
	{
		get
		{
			return kBMMGOJKAPF_;
		}
		set
		{
			kBMMGOJKAPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeFacilityLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeFacilityLevelCsReq(ElfRestaurantUpgradeFacilityLevelCsReq other)
		: this()
	{
		oDADJILOEKO_ = other.oDADJILOEKO_;
		kBMMGOJKAPF_ = other.kBMMGOJKAPF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeFacilityLevelCsReq Clone()
	{
		return new ElfRestaurantUpgradeFacilityLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantUpgradeFacilityLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantUpgradeFacilityLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
		{
			return false;
		}
		if (KBMMGOJKAPF != other.KBMMGOJKAPF)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
		}
		if (KBMMGOJKAPF != 0)
		{
			num ^= KBMMGOJKAPF.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ODADJILOEKO);
		}
		if (KBMMGOJKAPF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KBMMGOJKAPF);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (KBMMGOJKAPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBMMGOJKAPF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantUpgradeFacilityLevelCsReq other)
	{
		if (other != null)
		{
			if (other.ODADJILOEKO != 0)
			{
				ODADJILOEKO = other.ODADJILOEKO;
			}
			if (other.KBMMGOJKAPF != 0)
			{
				KBMMGOJKAPF = other.KBMMGOJKAPF;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 48u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			case 112u:
				KBMMGOJKAPF = input.ReadUInt32();
				break;
			}
		}
	}
}
