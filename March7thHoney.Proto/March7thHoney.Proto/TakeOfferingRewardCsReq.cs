using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeOfferingRewardCsReq : IMessage<TakeOfferingRewardCsReq>, IMessage, IEquatable<TakeOfferingRewardCsReq>, IDeepCloneable<TakeOfferingRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeOfferingRewardCsReq> _parser = new MessageParser<TakeOfferingRewardCsReq>(() => new TakeOfferingRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int InteractedPropEntityIdFieldNumber = 7;

	private uint interactedPropEntityId_;

	public const int TakeRewardLevelListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_takeRewardLevelList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> takeRewardLevelList_ = new RepeatedField<uint>();

	public const int OfferingIdFieldNumber = 15;

	private uint offeringId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeOfferingRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeOfferingRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractedPropEntityId
	{
		get
		{
			return interactedPropEntityId_;
		}
		set
		{
			interactedPropEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TakeRewardLevelList => takeRewardLevelList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OfferingId
	{
		get
		{
			return offeringId_;
		}
		set
		{
			offeringId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeOfferingRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeOfferingRewardCsReq(TakeOfferingRewardCsReq other)
		: this()
	{
		interactedPropEntityId_ = other.interactedPropEntityId_;
		takeRewardLevelList_ = other.takeRewardLevelList_.Clone();
		offeringId_ = other.offeringId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeOfferingRewardCsReq Clone()
	{
		return new TakeOfferingRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeOfferingRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeOfferingRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractedPropEntityId != other.InteractedPropEntityId)
		{
			return false;
		}
		if (!takeRewardLevelList_.Equals(other.takeRewardLevelList_))
		{
			return false;
		}
		if (OfferingId != other.OfferingId)
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
		if (InteractedPropEntityId != 0)
		{
			num ^= InteractedPropEntityId.GetHashCode();
		}
		num ^= takeRewardLevelList_.GetHashCode();
		if (OfferingId != 0)
		{
			num ^= OfferingId.GetHashCode();
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
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(InteractedPropEntityId);
		}
		takeRewardLevelList_.WriteTo(ref output, _repeated_takeRewardLevelList_codec);
		if (OfferingId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OfferingId);
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
		if (InteractedPropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractedPropEntityId);
		}
		num += takeRewardLevelList_.CalculateSize(_repeated_takeRewardLevelList_codec);
		if (OfferingId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OfferingId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeOfferingRewardCsReq other)
	{
		if (other != null)
		{
			if (other.InteractedPropEntityId != 0)
			{
				InteractedPropEntityId = other.InteractedPropEntityId;
			}
			takeRewardLevelList_.Add(other.takeRewardLevelList_);
			if (other.OfferingId != 0)
			{
				OfferingId = other.OfferingId;
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
			case 56u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				takeRewardLevelList_.AddEntriesFrom(ref input, _repeated_takeRewardLevelList_codec);
				break;
			case 120u:
				OfferingId = input.ReadUInt32();
				break;
			}
		}
	}
}
