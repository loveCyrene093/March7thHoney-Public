using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GGBDCOICGJG : IMessage<GGBDCOICGJG>, IMessage, IEquatable<GGBDCOICGJG>, IDeepCloneable<GGBDCOICGJG>, IBufferMessage
{
	private static readonly MessageParser<GGBDCOICGJG> _parser = new MessageParser<GGBDCOICGJG>(() => new GGBDCOICGJG());

	private UnknownFieldSet _unknownFields;

	public const int WaveFieldNumber = 1;

	private uint wave_;

	public const int ScoreIdFieldNumber = 2;

	private uint scoreId_;

	public const int OIPAAMGIIEGFieldNumber = 3;

	private uint oIPAAMGIIEG_;

	public const int BHFCPJAKIBGFieldNumber = 4;

	private static readonly FieldCodec<HHIPKINNCAP> _repeated_bHFCPJAKIBG_codec = FieldCodec.ForMessage(34u, HHIPKINNCAP.Parser);

	private readonly RepeatedField<HHIPKINNCAP> bHFCPJAKIBG_ = new RepeatedField<HHIPKINNCAP>();

	public const int JHFKANKGLJNFieldNumber = 5;

	private float jHFKANKGLJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GGBDCOICGJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GGBDCOICGJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIPAAMGIIEG
	{
		get
		{
			return oIPAAMGIIEG_;
		}
		set
		{
			oIPAAMGIIEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HHIPKINNCAP> BHFCPJAKIBG => bHFCPJAKIBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float JHFKANKGLJN
	{
		get
		{
			return jHFKANKGLJN_;
		}
		set
		{
			jHFKANKGLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGBDCOICGJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGBDCOICGJG(GGBDCOICGJG other)
		: this()
	{
		wave_ = other.wave_;
		scoreId_ = other.scoreId_;
		oIPAAMGIIEG_ = other.oIPAAMGIIEG_;
		bHFCPJAKIBG_ = other.bHFCPJAKIBG_.Clone();
		jHFKANKGLJN_ = other.jHFKANKGLJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGBDCOICGJG Clone()
	{
		return new GGBDCOICGJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GGBDCOICGJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GGBDCOICGJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (OIPAAMGIIEG != other.OIPAAMGIIEG)
		{
			return false;
		}
		if (!bHFCPJAKIBG_.Equals(other.bHFCPJAKIBG_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JHFKANKGLJN, other.JHFKANKGLJN))
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
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (OIPAAMGIIEG != 0)
		{
			num ^= OIPAAMGIIEG.GetHashCode();
		}
		num ^= bHFCPJAKIBG_.GetHashCode();
		if (JHFKANKGLJN != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JHFKANKGLJN);
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
		if (Wave != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Wave);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ScoreId);
		}
		if (OIPAAMGIIEG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OIPAAMGIIEG);
		}
		bHFCPJAKIBG_.WriteTo(ref output, _repeated_bHFCPJAKIBG_codec);
		if (JHFKANKGLJN != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(JHFKANKGLJN);
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
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (OIPAAMGIIEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIPAAMGIIEG);
		}
		num += bHFCPJAKIBG_.CalculateSize(_repeated_bHFCPJAKIBG_codec);
		if (JHFKANKGLJN != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GGBDCOICGJG other)
	{
		if (other != null)
		{
			if (other.Wave != 0)
			{
				Wave = other.Wave;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.OIPAAMGIIEG != 0)
			{
				OIPAAMGIIEG = other.OIPAAMGIIEG;
			}
			bHFCPJAKIBG_.Add(other.bHFCPJAKIBG_);
			if (other.JHFKANKGLJN != 0f)
			{
				JHFKANKGLJN = other.JHFKANKGLJN;
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
			case 8u:
				Wave = input.ReadUInt32();
				break;
			case 16u:
				ScoreId = input.ReadUInt32();
				break;
			case 24u:
				OIPAAMGIIEG = input.ReadUInt32();
				break;
			case 34u:
				bHFCPJAKIBG_.AddEntriesFrom(ref input, _repeated_bHFCPJAKIBG_codec);
				break;
			case 45u:
				JHFKANKGLJN = input.ReadFloat();
				break;
			}
		}
	}
}
