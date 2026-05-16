using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearUpdatePinRelicScNotify : IMessage<RelicSmartWearUpdatePinRelicScNotify>, IMessage, IEquatable<RelicSmartWearUpdatePinRelicScNotify>, IDeepCloneable<RelicSmartWearUpdatePinRelicScNotify>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearUpdatePinRelicScNotify> _parser = new MessageParser<RelicSmartWearUpdatePinRelicScNotify>(() => new RelicSmartWearUpdatePinRelicScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BKDEIHEKGICFieldNumber = 4;

	private static readonly FieldCodec<BDEKEIKAKML> _repeated_bKDEIHEKGIC_codec = FieldCodec.ForMessage(34u, BDEKEIKAKML.Parser);

	private readonly RepeatedField<BDEKEIKAKML> bKDEIHEKGIC_ = new RepeatedField<BDEKEIKAKML>();

	public const int NAEIPMIIIECFieldNumber = 5;

	private static readonly FieldCodec<BDEKEIKAKML> _repeated_nAEIPMIIIEC_codec = FieldCodec.ForMessage(42u, BDEKEIKAKML.Parser);

	private readonly RepeatedField<BDEKEIKAKML> nAEIPMIIIEC_ = new RepeatedField<BDEKEIKAKML>();

	public const int RelicUniqueIdFieldNumber = 9;

	private uint relicUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearUpdatePinRelicScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearUpdatePinRelicScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BDEKEIKAKML> BKDEIHEKGIC => bKDEIHEKGIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BDEKEIKAKML> NAEIPMIIIEC => nAEIPMIIIEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicUniqueId
	{
		get
		{
			return relicUniqueId_;
		}
		set
		{
			relicUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicScNotify(RelicSmartWearUpdatePinRelicScNotify other)
		: this()
	{
		bKDEIHEKGIC_ = other.bKDEIHEKGIC_.Clone();
		nAEIPMIIIEC_ = other.nAEIPMIIIEC_.Clone();
		relicUniqueId_ = other.relicUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearUpdatePinRelicScNotify Clone()
	{
		return new RelicSmartWearUpdatePinRelicScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearUpdatePinRelicScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearUpdatePinRelicScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bKDEIHEKGIC_.Equals(other.bKDEIHEKGIC_))
		{
			return false;
		}
		if (!nAEIPMIIIEC_.Equals(other.nAEIPMIIIEC_))
		{
			return false;
		}
		if (RelicUniqueId != other.RelicUniqueId)
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
		num ^= bKDEIHEKGIC_.GetHashCode();
		num ^= nAEIPMIIIEC_.GetHashCode();
		if (RelicUniqueId != 0)
		{
			num ^= RelicUniqueId.GetHashCode();
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
		bKDEIHEKGIC_.WriteTo(ref output, _repeated_bKDEIHEKGIC_codec);
		nAEIPMIIIEC_.WriteTo(ref output, _repeated_nAEIPMIIIEC_codec);
		if (RelicUniqueId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RelicUniqueId);
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
		num += bKDEIHEKGIC_.CalculateSize(_repeated_bKDEIHEKGIC_codec);
		num += nAEIPMIIIEC_.CalculateSize(_repeated_nAEIPMIIIEC_codec);
		if (RelicUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearUpdatePinRelicScNotify other)
	{
		if (other != null)
		{
			bKDEIHEKGIC_.Add(other.bKDEIHEKGIC_);
			nAEIPMIIIEC_.Add(other.nAEIPMIIIEC_);
			if (other.RelicUniqueId != 0)
			{
				RelicUniqueId = other.RelicUniqueId;
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
			case 34u:
				bKDEIHEKGIC_.AddEntriesFrom(ref input, _repeated_bKDEIHEKGIC_codec);
				break;
			case 42u:
				nAEIPMIIIEC_.AddEntriesFrom(ref input, _repeated_nAEIPMIIIEC_codec);
				break;
			case 72u:
				RelicUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
