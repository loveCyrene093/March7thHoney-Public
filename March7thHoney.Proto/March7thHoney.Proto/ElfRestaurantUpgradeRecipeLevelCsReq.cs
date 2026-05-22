using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantUpgradeRecipeLevelCsReq : IMessage<ElfRestaurantUpgradeRecipeLevelCsReq>, IMessage, IEquatable<ElfRestaurantUpgradeRecipeLevelCsReq>, IDeepCloneable<ElfRestaurantUpgradeRecipeLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantUpgradeRecipeLevelCsReq> _parser = new MessageParser<ElfRestaurantUpgradeRecipeLevelCsReq>(() => new ElfRestaurantUpgradeRecipeLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int APDABNGDMPMFieldNumber = 2;

	private uint aPDABNGDMPM_;

	public const int ODADJILOEKOFieldNumber = 15;

	private uint oDADJILOEKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantUpgradeRecipeLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantUpgradeRecipeLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APDABNGDMPM
	{
		get
		{
			return aPDABNGDMPM_;
		}
		set
		{
			aPDABNGDMPM_ = value;
		}
	}

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
	public ElfRestaurantUpgradeRecipeLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeRecipeLevelCsReq(ElfRestaurantUpgradeRecipeLevelCsReq other)
		: this()
	{
		aPDABNGDMPM_ = other.aPDABNGDMPM_;
		oDADJILOEKO_ = other.oDADJILOEKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantUpgradeRecipeLevelCsReq Clone()
	{
		return new ElfRestaurantUpgradeRecipeLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantUpgradeRecipeLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantUpgradeRecipeLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (APDABNGDMPM != other.APDABNGDMPM)
		{
			return false;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
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
		if (APDABNGDMPM != 0)
		{
			num ^= APDABNGDMPM.GetHashCode();
		}
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
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
		if (APDABNGDMPM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(APDABNGDMPM);
		}
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ODADJILOEKO);
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
		if (APDABNGDMPM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APDABNGDMPM);
		}
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElfRestaurantUpgradeRecipeLevelCsReq other)
	{
		if (other != null)
		{
			if (other.APDABNGDMPM != 0)
			{
				APDABNGDMPM = other.APDABNGDMPM;
			}
			if (other.ODADJILOEKO != 0)
			{
				ODADJILOEKO = other.ODADJILOEKO;
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
			case 16u:
				APDABNGDMPM = input.ReadUInt32();
				break;
			case 120u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			}
		}
	}
}
