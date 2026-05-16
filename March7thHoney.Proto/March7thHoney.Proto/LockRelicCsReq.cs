using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockRelicCsReq : IMessage<LockRelicCsReq>, IMessage, IEquatable<LockRelicCsReq>, IDeepCloneable<LockRelicCsReq>, IBufferMessage
{
	private static readonly MessageParser<LockRelicCsReq> _parser = new MessageParser<LockRelicCsReq>(() => new LockRelicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int RelicIdsFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int IsLockedFieldNumber = 9;

	private bool isLocked_;

	public const int KIPBINBIDAEFieldNumber = 11;

	private bool kIPBINBIDAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LockRelicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LockRelicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> RelicIds => relicIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsLocked
	{
		get
		{
			return isLocked_;
		}
		set
		{
			isLocked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KIPBINBIDAE
	{
		get
		{
			return kIPBINBIDAE_;
		}
		set
		{
			kIPBINBIDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockRelicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockRelicCsReq(LockRelicCsReq other)
		: this()
	{
		relicIds_ = other.relicIds_.Clone();
		isLocked_ = other.isLocked_;
		kIPBINBIDAE_ = other.kIPBINBIDAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockRelicCsReq Clone()
	{
		return new LockRelicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LockRelicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LockRelicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!relicIds_.Equals(other.relicIds_))
		{
			return false;
		}
		if (IsLocked != other.IsLocked)
		{
			return false;
		}
		if (KIPBINBIDAE != other.KIPBINBIDAE)
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
		num ^= relicIds_.GetHashCode();
		if (IsLocked)
		{
			num ^= IsLocked.GetHashCode();
		}
		if (KIPBINBIDAE)
		{
			num ^= KIPBINBIDAE.GetHashCode();
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
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (IsLocked)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsLocked);
		}
		if (KIPBINBIDAE)
		{
			output.WriteRawTag(88);
			output.WriteBool(KIPBINBIDAE);
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
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (IsLocked)
		{
			num += 2;
		}
		if (KIPBINBIDAE)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LockRelicCsReq other)
	{
		if (other != null)
		{
			relicIds_.Add(other.relicIds_);
			if (other.IsLocked)
			{
				IsLocked = other.IsLocked;
			}
			if (other.KIPBINBIDAE)
			{
				KIPBINBIDAE = other.KIPBINBIDAE;
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
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 72u:
				IsLocked = input.ReadBool();
				break;
			case 88u:
				KIPBINBIDAE = input.ReadBool();
				break;
			}
		}
	}
}
