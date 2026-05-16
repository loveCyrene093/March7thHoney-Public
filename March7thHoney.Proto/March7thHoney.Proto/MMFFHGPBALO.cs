using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MMFFHGPBALO : IMessage<MMFFHGPBALO>, IMessage, IEquatable<MMFFHGPBALO>, IDeepCloneable<MMFFHGPBALO>, IBufferMessage
{
	private static readonly MessageParser<MMFFHGPBALO> _parser = new MessageParser<MMFFHGPBALO>(() => new MMFFHGPBALO());

	private UnknownFieldSet _unknownFields;

	public const int LENCLJPKDAOFieldNumber = 4;

	private ByteString lENCLJPKDAO_ = ByteString.Empty;

	public const int DiceSlotIdFieldNumber = 5;

	private uint diceSlotId_;

	public const int NameFieldNumber = 9;

	private string name_ = "";

	public const int EFIJDEBFFNFFieldNumber = 12;

	private static readonly FieldCodec<ICIKHNKEELJ> _repeated_eFIJDEBFFNF_codec = FieldCodec.ForMessage(98u, ICIKHNKEELJ.Parser);

	private readonly RepeatedField<ICIKHNKEELJ> eFIJDEBFFNF_ = new RepeatedField<ICIKHNKEELJ>();

	public const int BOINMJJEBBEFieldNumber = 13;

	private string bOINMJJEBBE_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MMFFHGPBALO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MMFFHGPBALOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString LENCLJPKDAO
	{
		get
		{
			return lENCLJPKDAO_;
		}
		set
		{
			lENCLJPKDAO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiceSlotId
	{
		get
		{
			return diceSlotId_;
		}
		set
		{
			diceSlotId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ICIKHNKEELJ> EFIJDEBFFNF => eFIJDEBFFNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BOINMJJEBBE
	{
		get
		{
			return bOINMJJEBBE_;
		}
		set
		{
			bOINMJJEBBE_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMFFHGPBALO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMFFHGPBALO(MMFFHGPBALO other)
		: this()
	{
		lENCLJPKDAO_ = other.lENCLJPKDAO_;
		diceSlotId_ = other.diceSlotId_;
		name_ = other.name_;
		eFIJDEBFFNF_ = other.eFIJDEBFFNF_.Clone();
		bOINMJJEBBE_ = other.bOINMJJEBBE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMFFHGPBALO Clone()
	{
		return new MMFFHGPBALO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MMFFHGPBALO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MMFFHGPBALO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LENCLJPKDAO != other.LENCLJPKDAO)
		{
			return false;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!eFIJDEBFFNF_.Equals(other.eFIJDEBFFNF_))
		{
			return false;
		}
		if (BOINMJJEBBE != other.BOINMJJEBBE)
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
		if (LENCLJPKDAO.Length != 0)
		{
			num ^= LENCLJPKDAO.GetHashCode();
		}
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		num ^= eFIJDEBFFNF_.GetHashCode();
		if (BOINMJJEBBE.Length != 0)
		{
			num ^= BOINMJJEBBE.GetHashCode();
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
		if (LENCLJPKDAO.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(LENCLJPKDAO);
		}
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DiceSlotId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Name);
		}
		eFIJDEBFFNF_.WriteTo(ref output, _repeated_eFIJDEBFFNF_codec);
		if (BOINMJJEBBE.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(BOINMJJEBBE);
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
		if (LENCLJPKDAO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(LENCLJPKDAO);
		}
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		num += eFIJDEBFFNF_.CalculateSize(_repeated_eFIJDEBFFNF_codec);
		if (BOINMJJEBBE.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BOINMJJEBBE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MMFFHGPBALO other)
	{
		if (other != null)
		{
			if (other.LENCLJPKDAO.Length != 0)
			{
				LENCLJPKDAO = other.LENCLJPKDAO;
			}
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			eFIJDEBFFNF_.Add(other.eFIJDEBFFNF_);
			if (other.BOINMJJEBBE.Length != 0)
			{
				BOINMJJEBBE = other.BOINMJJEBBE;
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
			case 34u:
				LENCLJPKDAO = input.ReadBytes();
				break;
			case 40u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 74u:
				Name = input.ReadString();
				break;
			case 98u:
				eFIJDEBFFNF_.AddEntriesFrom(ref input, _repeated_eFIJDEBFFNF_codec);
				break;
			case 106u:
				BOINMJJEBBE = input.ReadString();
				break;
			}
		}
	}
}
