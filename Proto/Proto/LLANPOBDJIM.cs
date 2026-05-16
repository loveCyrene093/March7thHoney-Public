using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LLANPOBDJIM : IMessage<LLANPOBDJIM>, IMessage, IEquatable<LLANPOBDJIM>, IDeepCloneable<LLANPOBDJIM>, IBufferMessage
{
	private static readonly MessageParser<LLANPOBDJIM> _parser = new MessageParser<LLANPOBDJIM>(() => new LLANPOBDJIM());

	private UnknownFieldSet _unknownFields;

	public const int FirstLineupFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_firstLineup_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> firstLineup_ = new RepeatedField<uint>();

	public const int SecondLineupFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_secondLineup_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> secondLineup_ = new RepeatedField<uint>();

	public const int FFMBCEEGOLOFieldNumber = 3;

	private uint fFMBCEEGOLO_;

	public const int JBFMHDLMBFAFieldNumber = 4;

	private uint jBFMHDLMBFA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LLANPOBDJIM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LLANPOBDJIMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FirstLineup => firstLineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SecondLineup => secondLineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FFMBCEEGOLO
	{
		get
		{
			return fFMBCEEGOLO_;
		}
		set
		{
			fFMBCEEGOLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBFMHDLMBFA
	{
		get
		{
			return jBFMHDLMBFA_;
		}
		set
		{
			jBFMHDLMBFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLANPOBDJIM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLANPOBDJIM(LLANPOBDJIM other)
		: this()
	{
		firstLineup_ = other.firstLineup_.Clone();
		secondLineup_ = other.secondLineup_.Clone();
		fFMBCEEGOLO_ = other.fFMBCEEGOLO_;
		jBFMHDLMBFA_ = other.jBFMHDLMBFA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLANPOBDJIM Clone()
	{
		return new LLANPOBDJIM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LLANPOBDJIM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LLANPOBDJIM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!firstLineup_.Equals(other.firstLineup_))
		{
			return false;
		}
		if (!secondLineup_.Equals(other.secondLineup_))
		{
			return false;
		}
		if (FFMBCEEGOLO != other.FFMBCEEGOLO)
		{
			return false;
		}
		if (JBFMHDLMBFA != other.JBFMHDLMBFA)
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
		num ^= firstLineup_.GetHashCode();
		num ^= secondLineup_.GetHashCode();
		if (FFMBCEEGOLO != 0)
		{
			num ^= FFMBCEEGOLO.GetHashCode();
		}
		if (JBFMHDLMBFA != 0)
		{
			num ^= JBFMHDLMBFA.GetHashCode();
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
		firstLineup_.WriteTo(ref output, _repeated_firstLineup_codec);
		secondLineup_.WriteTo(ref output, _repeated_secondLineup_codec);
		if (FFMBCEEGOLO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FFMBCEEGOLO);
		}
		if (JBFMHDLMBFA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JBFMHDLMBFA);
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
		num += firstLineup_.CalculateSize(_repeated_firstLineup_codec);
		num += secondLineup_.CalculateSize(_repeated_secondLineup_codec);
		if (FFMBCEEGOLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FFMBCEEGOLO);
		}
		if (JBFMHDLMBFA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBFMHDLMBFA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LLANPOBDJIM other)
	{
		if (other != null)
		{
			firstLineup_.Add(other.firstLineup_);
			secondLineup_.Add(other.secondLineup_);
			if (other.FFMBCEEGOLO != 0)
			{
				FFMBCEEGOLO = other.FFMBCEEGOLO;
			}
			if (other.JBFMHDLMBFA != 0)
			{
				JBFMHDLMBFA = other.JBFMHDLMBFA;
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
			case 10u:
				firstLineup_.AddEntriesFrom(ref input, _repeated_firstLineup_codec);
				break;
			case 16u:
			case 18u:
				secondLineup_.AddEntriesFrom(ref input, _repeated_secondLineup_codec);
				break;
			case 24u:
				FFMBCEEGOLO = input.ReadUInt32();
				break;
			case 32u:
				JBFMHDLMBFA = input.ReadUInt32();
				break;
			}
		}
	}
}
