using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearDeletePinRelicCsReq : IMessage<RelicSmartWearDeletePinRelicCsReq>, IMessage, IEquatable<RelicSmartWearDeletePinRelicCsReq>, IDeepCloneable<RelicSmartWearDeletePinRelicCsReq>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearDeletePinRelicCsReq> _parser = new MessageParser<RelicSmartWearDeletePinRelicCsReq>(() => new RelicSmartWearDeletePinRelicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OPCPHICEOOFFieldNumber = 3;

	private bool oPCPHICEOOF_;

	public const int AvatarIdFieldNumber = 6;

	private uint avatarId_;

	public const int DHCNMIAIBGFFieldNumber = 11;

	private static readonly FieldCodec<NHFOGDPBOHN> _repeated_dHCNMIAIBGF_codec = FieldCodec.ForMessage(90u, NHFOGDPBOHN.Parser);

	private readonly RepeatedField<NHFOGDPBOHN> dHCNMIAIBGF_ = new RepeatedField<NHFOGDPBOHN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearDeletePinRelicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearDeletePinRelicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OPCPHICEOOF
	{
		get
		{
			return oPCPHICEOOF_;
		}
		set
		{
			oPCPHICEOOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NHFOGDPBOHN> DHCNMIAIBGF => dHCNMIAIBGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearDeletePinRelicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearDeletePinRelicCsReq(RelicSmartWearDeletePinRelicCsReq other)
		: this()
	{
		oPCPHICEOOF_ = other.oPCPHICEOOF_;
		avatarId_ = other.avatarId_;
		dHCNMIAIBGF_ = other.dHCNMIAIBGF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearDeletePinRelicCsReq Clone()
	{
		return new RelicSmartWearDeletePinRelicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearDeletePinRelicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearDeletePinRelicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OPCPHICEOOF != other.OPCPHICEOOF)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!dHCNMIAIBGF_.Equals(other.dHCNMIAIBGF_))
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
		if (OPCPHICEOOF)
		{
			num ^= OPCPHICEOOF.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= dHCNMIAIBGF_.GetHashCode();
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
		if (OPCPHICEOOF)
		{
			output.WriteRawTag(24);
			output.WriteBool(OPCPHICEOOF);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AvatarId);
		}
		dHCNMIAIBGF_.WriteTo(ref output, _repeated_dHCNMIAIBGF_codec);
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
		if (OPCPHICEOOF)
		{
			num += 2;
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += dHCNMIAIBGF_.CalculateSize(_repeated_dHCNMIAIBGF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearDeletePinRelicCsReq other)
	{
		if (other != null)
		{
			if (other.OPCPHICEOOF)
			{
				OPCPHICEOOF = other.OPCPHICEOOF;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			dHCNMIAIBGF_.Add(other.dHCNMIAIBGF_);
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
			case 24u:
				OPCPHICEOOF = input.ReadBool();
				break;
			case 48u:
				AvatarId = input.ReadUInt32();
				break;
			case 90u:
				dHCNMIAIBGF_.AddEntriesFrom(ref input, _repeated_dHCNMIAIBGF_codec);
				break;
			}
		}
	}
}
