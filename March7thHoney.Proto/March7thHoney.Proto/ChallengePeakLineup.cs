using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakLineup : IMessage<ChallengePeakLineup>, IMessage, IEquatable<ChallengePeakLineup>, IDeepCloneable<ChallengePeakLineup>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakLineup> _parser = new MessageParser<ChallengePeakLineup>(() => new ChallengePeakLineup());

	private UnknownFieldSet _unknownFields;

	public const int FMFGOJHCCNLFieldNumber = 1;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_fMFGOJHCCNL_codec = FieldCodec.ForMessage(10u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> fMFGOJHCCNL_ = new RepeatedField<EEBPHJCNBFO>();

	public const int PeakIdFieldNumber = 3;

	private uint peakId_;

	public const int PeakAvatarIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_peakAvatarIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> peakAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakLineup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakLineupReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> FMFGOJHCCNL => fMFGOJHCCNL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakId
	{
		get
		{
			return peakId_;
		}
		set
		{
			peakId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PeakAvatarIdList => peakAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakLineup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakLineup(ChallengePeakLineup other)
		: this()
	{
		fMFGOJHCCNL_ = other.fMFGOJHCCNL_.Clone();
		peakId_ = other.peakId_;
		peakAvatarIdList_ = other.peakAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakLineup Clone()
	{
		return new ChallengePeakLineup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakLineup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakLineup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fMFGOJHCCNL_.Equals(other.fMFGOJHCCNL_))
		{
			return false;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (!peakAvatarIdList_.Equals(other.peakAvatarIdList_))
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
		num ^= fMFGOJHCCNL_.GetHashCode();
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		num ^= peakAvatarIdList_.GetHashCode();
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
		fMFGOJHCCNL_.WriteTo(ref output, _repeated_fMFGOJHCCNL_codec);
		if (PeakId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PeakId);
		}
		peakAvatarIdList_.WriteTo(ref output, _repeated_peakAvatarIdList_codec);
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
		num += fMFGOJHCCNL_.CalculateSize(_repeated_fMFGOJHCCNL_codec);
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		num += peakAvatarIdList_.CalculateSize(_repeated_peakAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakLineup other)
	{
		if (other != null)
		{
			fMFGOJHCCNL_.Add(other.fMFGOJHCCNL_);
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			peakAvatarIdList_.Add(other.peakAvatarIdList_);
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
			case 10u:
				fMFGOJHCCNL_.AddEntriesFrom(ref input, _repeated_fMFGOJHCCNL_codec);
				break;
			case 24u:
				PeakId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				peakAvatarIdList_.AddEntriesFrom(ref input, _repeated_peakAvatarIdList_codec);
				break;
			}
		}
	}
}
