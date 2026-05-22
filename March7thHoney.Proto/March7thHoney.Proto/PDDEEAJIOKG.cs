using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PDDEEAJIOKG : IMessage<PDDEEAJIOKG>, IMessage, IEquatable<PDDEEAJIOKG>, IDeepCloneable<PDDEEAJIOKG>, IBufferMessage
{
	private static readonly MessageParser<PDDEEAJIOKG> _parser = new MessageParser<PDDEEAJIOKG>(() => new PDDEEAJIOKG());

	private UnknownFieldSet _unknownFields;

	public const int PAMGHMDJAJAFieldNumber = 4;

	private DCOKKBHKEGL pAMGHMDJAJA_;

	public const int AGOPFIFDJFNFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_aGOPFIFDJFN_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> aGOPFIFDJFN_ = new RepeatedField<uint>();

	public const int UnfinishedStoryLineIdListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	public const int BaseAvatarIdListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PDDEEAJIOKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PDDEEAJIOKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCOKKBHKEGL PAMGHMDJAJA
	{
		get
		{
			return pAMGHMDJAJA_;
		}
		set
		{
			pAMGHMDJAJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AGOPFIFDJFN => aGOPFIFDJFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDDEEAJIOKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDDEEAJIOKG(PDDEEAJIOKG other)
		: this()
	{
		pAMGHMDJAJA_ = ((other.pAMGHMDJAJA_ != null) ? other.pAMGHMDJAJA_.Clone() : null);
		aGOPFIFDJFN_ = other.aGOPFIFDJFN_.Clone();
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDDEEAJIOKG Clone()
	{
		return new PDDEEAJIOKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PDDEEAJIOKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PDDEEAJIOKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PAMGHMDJAJA, other.PAMGHMDJAJA))
		{
			return false;
		}
		if (!aGOPFIFDJFN_.Equals(other.aGOPFIFDJFN_))
		{
			return false;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
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
		if (pAMGHMDJAJA_ != null)
		{
			num ^= PAMGHMDJAJA.GetHashCode();
		}
		num ^= aGOPFIFDJFN_.GetHashCode();
		num ^= unfinishedStoryLineIdList_.GetHashCode();
		num ^= baseAvatarIdList_.GetHashCode();
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
		if (pAMGHMDJAJA_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PAMGHMDJAJA);
		}
		aGOPFIFDJFN_.WriteTo(ref output, _repeated_aGOPFIFDJFN_codec);
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
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
		if (pAMGHMDJAJA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PAMGHMDJAJA);
		}
		num += aGOPFIFDJFN_.CalculateSize(_repeated_aGOPFIFDJFN_codec);
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PDDEEAJIOKG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pAMGHMDJAJA_ != null)
		{
			if (pAMGHMDJAJA_ == null)
			{
				PAMGHMDJAJA = new DCOKKBHKEGL();
			}
			PAMGHMDJAJA.MergeFrom(other.PAMGHMDJAJA);
		}
		aGOPFIFDJFN_.Add(other.aGOPFIFDJFN_);
		unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
		baseAvatarIdList_.Add(other.baseAvatarIdList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (pAMGHMDJAJA_ == null)
				{
					PAMGHMDJAJA = new DCOKKBHKEGL();
				}
				input.ReadMessage(PAMGHMDJAJA);
				break;
			case 48u:
			case 50u:
				aGOPFIFDJFN_.AddEntriesFrom(ref input, _repeated_aGOPFIFDJFN_codec);
				break;
			case 64u:
			case 66u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			case 72u:
			case 74u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			}
		}
	}
}
