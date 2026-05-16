using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PANIGDLLMBG : IMessage<PANIGDLLMBG>, IMessage, IEquatable<PANIGDLLMBG>, IDeepCloneable<PANIGDLLMBG>, IBufferMessage
{
	private static readonly MessageParser<PANIGDLLMBG> _parser = new MessageParser<PANIGDLLMBG>(() => new PANIGDLLMBG());

	private UnknownFieldSet _unknownFields;

	public const int PeakAvatarIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_peakAvatarIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> peakAvatarIdList_ = new RepeatedField<uint>();

	public const int PeakIdFieldNumber = 8;

	private uint peakId_;

	public const int CyclesUsedFieldNumber = 9;

	private uint cyclesUsed_;

	public const int AvatarListFieldNumber = 12;

	private static readonly FieldCodec<DisplayAvatarInfo> _repeated_avatarList_codec = FieldCodec.ForMessage(98u, DisplayAvatarInfo.Parser);

	private readonly RepeatedField<DisplayAvatarInfo> avatarList_ = new RepeatedField<DisplayAvatarInfo>();

	public const int FinishedTargetListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PANIGDLLMBG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PANIGDLLMBGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PeakAvatarIdList => peakAvatarIdList_;

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
	public uint CyclesUsed
	{
		get
		{
			return cyclesUsed_;
		}
		set
		{
			cyclesUsed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarInfo> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PANIGDLLMBG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PANIGDLLMBG(PANIGDLLMBG other)
		: this()
	{
		peakAvatarIdList_ = other.peakAvatarIdList_.Clone();
		peakId_ = other.peakId_;
		cyclesUsed_ = other.cyclesUsed_;
		avatarList_ = other.avatarList_.Clone();
		finishedTargetList_ = other.finishedTargetList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PANIGDLLMBG Clone()
	{
		return new PANIGDLLMBG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PANIGDLLMBG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PANIGDLLMBG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!peakAvatarIdList_.Equals(other.peakAvatarIdList_))
		{
			return false;
		}
		if (PeakId != other.PeakId)
		{
			return false;
		}
		if (CyclesUsed != other.CyclesUsed)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
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
		num ^= peakAvatarIdList_.GetHashCode();
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
		}
		if (CyclesUsed != 0)
		{
			num ^= CyclesUsed.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		num ^= finishedTargetList_.GetHashCode();
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
		peakAvatarIdList_.WriteTo(ref output, _repeated_peakAvatarIdList_codec);
		if (PeakId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PeakId);
		}
		if (CyclesUsed != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CyclesUsed);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
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
		num += peakAvatarIdList_.CalculateSize(_repeated_peakAvatarIdList_codec);
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (CyclesUsed != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CyclesUsed);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PANIGDLLMBG other)
	{
		if (other != null)
		{
			peakAvatarIdList_.Add(other.peakAvatarIdList_);
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
			}
			if (other.CyclesUsed != 0)
			{
				CyclesUsed = other.CyclesUsed;
			}
			avatarList_.Add(other.avatarList_);
			finishedTargetList_.Add(other.finishedTargetList_);
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
			case 18u:
				peakAvatarIdList_.AddEntriesFrom(ref input, _repeated_peakAvatarIdList_codec);
				break;
			case 64u:
				PeakId = input.ReadUInt32();
				break;
			case 72u:
				CyclesUsed = input.ReadUInt32();
				break;
			case 98u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 104u:
			case 106u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			}
		}
	}
}
