using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmGroup : IMessage<MusicRhythmGroup>, IMessage, IEquatable<MusicRhythmGroup>, IDeepCloneable<MusicRhythmGroup>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmGroup> _parser = new MessageParser<MusicRhythmGroup>(() => new MusicRhythmGroup());

	private UnknownFieldSet _unknownFields;

	public const int MusicGroupIdFieldNumber = 3;

	private uint musicGroupId_;

	public const int FICCPEMLMNNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_fICCPEMLMNN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> fICCPEMLMNN_ = new RepeatedField<uint>();

	public const int NCIIIIABFDPFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_nCIIIIABFDP_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> nCIIIIABFDP_ = new RepeatedField<uint>();

	public const int MusicGroupPhaseFieldNumber = 13;

	private uint musicGroupPhase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmGroup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmGroupReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MusicGroupId
	{
		get
		{
			return musicGroupId_;
		}
		set
		{
			musicGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FICCPEMLMNN => fICCPEMLMNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NCIIIIABFDP => nCIIIIABFDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MusicGroupPhase
	{
		get
		{
			return musicGroupPhase_;
		}
		set
		{
			musicGroupPhase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmGroup()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmGroup(MusicRhythmGroup other)
		: this()
	{
		musicGroupId_ = other.musicGroupId_;
		fICCPEMLMNN_ = other.fICCPEMLMNN_.Clone();
		nCIIIIABFDP_ = other.nCIIIIABFDP_.Clone();
		musicGroupPhase_ = other.musicGroupPhase_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmGroup Clone()
	{
		return new MusicRhythmGroup(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmGroup);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MusicGroupId != other.MusicGroupId)
		{
			return false;
		}
		if (!fICCPEMLMNN_.Equals(other.fICCPEMLMNN_))
		{
			return false;
		}
		if (!nCIIIIABFDP_.Equals(other.nCIIIIABFDP_))
		{
			return false;
		}
		if (MusicGroupPhase != other.MusicGroupPhase)
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
		if (MusicGroupId != 0)
		{
			num ^= MusicGroupId.GetHashCode();
		}
		num ^= fICCPEMLMNN_.GetHashCode();
		num ^= nCIIIIABFDP_.GetHashCode();
		if (MusicGroupPhase != 0)
		{
			num ^= MusicGroupPhase.GetHashCode();
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
		if (MusicGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MusicGroupId);
		}
		fICCPEMLMNN_.WriteTo(ref output, _repeated_fICCPEMLMNN_codec);
		nCIIIIABFDP_.WriteTo(ref output, _repeated_nCIIIIABFDP_codec);
		if (MusicGroupPhase != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MusicGroupPhase);
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
		if (MusicGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MusicGroupId);
		}
		num += fICCPEMLMNN_.CalculateSize(_repeated_fICCPEMLMNN_codec);
		num += nCIIIIABFDP_.CalculateSize(_repeated_nCIIIIABFDP_codec);
		if (MusicGroupPhase != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MusicGroupPhase);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmGroup other)
	{
		if (other != null)
		{
			if (other.MusicGroupId != 0)
			{
				MusicGroupId = other.MusicGroupId;
			}
			fICCPEMLMNN_.Add(other.fICCPEMLMNN_);
			nCIIIIABFDP_.Add(other.nCIIIIABFDP_);
			if (other.MusicGroupPhase != 0)
			{
				MusicGroupPhase = other.MusicGroupPhase;
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
			case 24u:
				MusicGroupId = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				fICCPEMLMNN_.AddEntriesFrom(ref input, _repeated_fICCPEMLMNN_codec);
				break;
			case 64u:
			case 66u:
				nCIIIIABFDP_.AddEntriesFrom(ref input, _repeated_nCIIIIABFDP_codec);
				break;
			case 104u:
				MusicGroupPhase = input.ReadUInt32();
				break;
			}
		}
	}
}
