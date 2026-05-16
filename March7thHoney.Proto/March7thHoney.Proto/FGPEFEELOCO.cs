using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FGPEFEELOCO : IMessage<FGPEFEELOCO>, IMessage, IEquatable<FGPEFEELOCO>, IDeepCloneable<FGPEFEELOCO>, IBufferMessage
{
	private static readonly MessageParser<FGPEFEELOCO> _parser = new MessageParser<FGPEFEELOCO>(() => new FGPEFEELOCO());

	private UnknownFieldSet _unknownFields;

	public const int EKBMEAJNNKOFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_eKBMEAJNNKO_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> eKBMEAJNNKO_ = new RepeatedField<uint>();

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int KLOOFAEJGKDFieldNumber = 12;

	private uint kLOOFAEJGKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FGPEFEELOCO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FGPEFEELOCOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EKBMEAJNNKO => eKBMEAJNNKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLOOFAEJGKD
	{
		get
		{
			return kLOOFAEJGKD_;
		}
		set
		{
			kLOOFAEJGKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FGPEFEELOCO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FGPEFEELOCO(FGPEFEELOCO other)
		: this()
	{
		eKBMEAJNNKO_ = other.eKBMEAJNNKO_.Clone();
		level_ = other.level_;
		kLOOFAEJGKD_ = other.kLOOFAEJGKD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FGPEFEELOCO Clone()
	{
		return new FGPEFEELOCO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FGPEFEELOCO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FGPEFEELOCO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eKBMEAJNNKO_.Equals(other.eKBMEAJNNKO_))
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (KLOOFAEJGKD != other.KLOOFAEJGKD)
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
		num ^= eKBMEAJNNKO_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (KLOOFAEJGKD != 0)
		{
			num ^= KLOOFAEJGKD.GetHashCode();
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
		eKBMEAJNNKO_.WriteTo(ref output, _repeated_eKBMEAJNNKO_codec);
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (KLOOFAEJGKD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KLOOFAEJGKD);
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
		num += eKBMEAJNNKO_.CalculateSize(_repeated_eKBMEAJNNKO_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (KLOOFAEJGKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLOOFAEJGKD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FGPEFEELOCO other)
	{
		if (other != null)
		{
			eKBMEAJNNKO_.Add(other.eKBMEAJNNKO_);
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.KLOOFAEJGKD != 0)
			{
				KLOOFAEJGKD = other.KLOOFAEJGKD;
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
				eKBMEAJNNKO_.AddEntriesFrom(ref input, _repeated_eKBMEAJNNKO_codec);
				break;
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 96u:
				KLOOFAEJGKD = input.ReadUInt32();
				break;
			}
		}
	}
}
