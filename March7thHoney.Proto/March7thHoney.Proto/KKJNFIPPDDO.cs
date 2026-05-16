using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KKJNFIPPDDO : IMessage<KKJNFIPPDDO>, IMessage, IEquatable<KKJNFIPPDDO>, IDeepCloneable<KKJNFIPPDDO>, IBufferMessage
{
	private static readonly MessageParser<KKJNFIPPDDO> _parser = new MessageParser<KKJNFIPPDDO>(() => new KKJNFIPPDDO());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 5;

	private uint uniqueId_;

	public const int KLOOFAEJGKDFieldNumber = 9;

	private uint kLOOFAEJGKD_;

	public const int BOFOMAPKKHMFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_bOFOMAPKKHM_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> bOFOMAPKKHM_ = new RepeatedField<uint>();

	public const int LevelFieldNumber = 14;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KKJNFIPPDDO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KKJNFIPPDDOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
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
	public RepeatedField<uint> BOFOMAPKKHM => bOFOMAPKKHM_;

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
	public KKJNFIPPDDO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKJNFIPPDDO(KKJNFIPPDDO other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		kLOOFAEJGKD_ = other.kLOOFAEJGKD_;
		bOFOMAPKKHM_ = other.bOFOMAPKKHM_.Clone();
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKJNFIPPDDO Clone()
	{
		return new KKJNFIPPDDO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KKJNFIPPDDO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KKJNFIPPDDO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (KLOOFAEJGKD != other.KLOOFAEJGKD)
		{
			return false;
		}
		if (!bOFOMAPKKHM_.Equals(other.bOFOMAPKKHM_))
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (KLOOFAEJGKD != 0)
		{
			num ^= KLOOFAEJGKD.GetHashCode();
		}
		num ^= bOFOMAPKKHM_.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UniqueId);
		}
		if (KLOOFAEJGKD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KLOOFAEJGKD);
		}
		bOFOMAPKKHM_.WriteTo(ref output, _repeated_bOFOMAPKKHM_codec);
		if (Level != 0)
		{
			output.WriteRawTag(112);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (KLOOFAEJGKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLOOFAEJGKD);
		}
		num += bOFOMAPKKHM_.CalculateSize(_repeated_bOFOMAPKKHM_codec);
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
	public void MergeFrom(KKJNFIPPDDO other)
	{
		if (other != null)
		{
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.KLOOFAEJGKD != 0)
			{
				KLOOFAEJGKD = other.KLOOFAEJGKD;
			}
			bOFOMAPKKHM_.Add(other.bOFOMAPKKHM_);
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
			case 40u:
				UniqueId = input.ReadUInt32();
				break;
			case 72u:
				KLOOFAEJGKD = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				bOFOMAPKKHM_.AddEntriesFrom(ref input, _repeated_bOFOMAPKKHM_codec);
				break;
			case 112u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
