using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterRogueEndlessActivityStageCsReq : IMessage<EnterRogueEndlessActivityStageCsReq>, IMessage, IEquatable<EnterRogueEndlessActivityStageCsReq>, IDeepCloneable<EnterRogueEndlessActivityStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterRogueEndlessActivityStageCsReq> _parser = new MessageParser<EnterRogueEndlessActivityStageCsReq>(() => new EnterRogueEndlessActivityStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PJMBJBMBKCEFieldNumber = 3;

	private uint pJMBJBMBKCE_;

	public const int AvatarListFieldNumber = 15;

	private static readonly FieldCodec<FCIMCHDEPPJ> _repeated_avatarList_codec = FieldCodec.ForMessage(122u, FCIMCHDEPPJ.Parser);

	private readonly RepeatedField<FCIMCHDEPPJ> avatarList_ = new RepeatedField<FCIMCHDEPPJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterRogueEndlessActivityStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterRogueEndlessActivityStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJMBJBMBKCE
	{
		get
		{
			return pJMBJBMBKCE_;
		}
		set
		{
			pJMBJBMBKCE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FCIMCHDEPPJ> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueEndlessActivityStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueEndlessActivityStageCsReq(EnterRogueEndlessActivityStageCsReq other)
		: this()
	{
		pJMBJBMBKCE_ = other.pJMBJBMBKCE_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueEndlessActivityStageCsReq Clone()
	{
		return new EnterRogueEndlessActivityStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterRogueEndlessActivityStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterRogueEndlessActivityStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJMBJBMBKCE != other.PJMBJBMBKCE)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (PJMBJBMBKCE != 0)
		{
			num ^= PJMBJBMBKCE.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (PJMBJBMBKCE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PJMBJBMBKCE);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (PJMBJBMBKCE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJMBJBMBKCE);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterRogueEndlessActivityStageCsReq other)
	{
		if (other != null)
		{
			if (other.PJMBJBMBKCE != 0)
			{
				PJMBJBMBKCE = other.PJMBJBMBKCE;
			}
			avatarList_.Add(other.avatarList_);
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
				PJMBJBMBKCE = input.ReadUInt32();
				break;
			case 122u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
