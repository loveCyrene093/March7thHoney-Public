using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGMIBLCAEFA : IMessage<LGMIBLCAEFA>, IMessage, IEquatable<LGMIBLCAEFA>, IDeepCloneable<LGMIBLCAEFA>, IBufferMessage
{
	private static readonly MessageParser<LGMIBLCAEFA> _parser = new MessageParser<LGMIBLCAEFA>(() => new LGMIBLCAEFA());

	private UnknownFieldSet _unknownFields;

	public const int BOFOMAPKKHMFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_bOFOMAPKKHM_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> bOFOMAPKKHM_ = new RepeatedField<uint>();

	public const int KLOOFAEJGKDFieldNumber = 7;

	private uint kLOOFAEJGKD_;

	public const int LevelFieldNumber = 10;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGMIBLCAEFA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGMIBLCAEFAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BOFOMAPKKHM => bOFOMAPKKHM_;

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
	public LGMIBLCAEFA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGMIBLCAEFA(LGMIBLCAEFA other)
		: this()
	{
		bOFOMAPKKHM_ = other.bOFOMAPKKHM_.Clone();
		kLOOFAEJGKD_ = other.kLOOFAEJGKD_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGMIBLCAEFA Clone()
	{
		return new LGMIBLCAEFA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGMIBLCAEFA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGMIBLCAEFA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bOFOMAPKKHM_.Equals(other.bOFOMAPKKHM_))
		{
			return false;
		}
		if (KLOOFAEJGKD != other.KLOOFAEJGKD)
		{
			return false;
		}
		if (Level != other.Level)
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
		num ^= bOFOMAPKKHM_.GetHashCode();
		if (KLOOFAEJGKD != 0)
		{
			num ^= KLOOFAEJGKD.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		bOFOMAPKKHM_.WriteTo(ref output, _repeated_bOFOMAPKKHM_codec);
		if (KLOOFAEJGKD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KLOOFAEJGKD);
		}
		if (Level != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Level);
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
		num += bOFOMAPKKHM_.CalculateSize(_repeated_bOFOMAPKKHM_codec);
		if (KLOOFAEJGKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLOOFAEJGKD);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGMIBLCAEFA other)
	{
		if (other != null)
		{
			bOFOMAPKKHM_.Add(other.bOFOMAPKKHM_);
			if (other.KLOOFAEJGKD != 0)
			{
				KLOOFAEJGKD = other.KLOOFAEJGKD;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 16u:
			case 18u:
				bOFOMAPKKHM_.AddEntriesFrom(ref input, _repeated_bOFOMAPKKHM_codec);
				break;
			case 56u:
				KLOOFAEJGKD = input.ReadUInt32();
				break;
			case 80u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
