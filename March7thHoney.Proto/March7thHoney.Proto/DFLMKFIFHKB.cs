using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFLMKFIFHKB : IMessage<DFLMKFIFHKB>, IMessage, IEquatable<DFLMKFIFHKB>, IDeepCloneable<DFLMKFIFHKB>, IBufferMessage
{
	private static readonly MessageParser<DFLMKFIFHKB> _parser = new MessageParser<DFLMKFIFHKB>(() => new DFLMKFIFHKB());

	private UnknownFieldSet _unknownFields;

	public const int EFIJDEBFFNFFieldNumber = 2;

	private static readonly FieldCodec<ICIKHNKEELJ> _repeated_eFIJDEBFFNF_codec = FieldCodec.ForMessage(18u, ICIKHNKEELJ.Parser);

	private readonly RepeatedField<ICIKHNKEELJ> eFIJDEBFFNF_ = new RepeatedField<ICIKHNKEELJ>();

	public const int DiceSlotIdFieldNumber = 6;

	private uint diceSlotId_;

	public const int BOINMJJEBBEFieldNumber = 7;

	private string bOINMJJEBBE_ = "";

	public const int NameFieldNumber = 8;

	private string name_ = "";

	public const int LENCLJPKDAOFieldNumber = 9;

	private ByteString lENCLJPKDAO_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFLMKFIFHKB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFLMKFIFHKBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ICIKHNKEELJ> EFIJDEBFFNF => eFIJDEBFFNF_;

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
	public DFLMKFIFHKB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFLMKFIFHKB(DFLMKFIFHKB other)
		: this()
	{
		eFIJDEBFFNF_ = other.eFIJDEBFFNF_.Clone();
		diceSlotId_ = other.diceSlotId_;
		bOINMJJEBBE_ = other.bOINMJJEBBE_;
		name_ = other.name_;
		lENCLJPKDAO_ = other.lENCLJPKDAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFLMKFIFHKB Clone()
	{
		return new DFLMKFIFHKB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DFLMKFIFHKB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFLMKFIFHKB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eFIJDEBFFNF_.Equals(other.eFIJDEBFFNF_))
		{
			return false;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (BOINMJJEBBE != other.BOINMJJEBBE)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (LENCLJPKDAO != other.LENCLJPKDAO)
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
		num ^= eFIJDEBFFNF_.GetHashCode();
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (BOINMJJEBBE.Length != 0)
		{
			num ^= BOINMJJEBBE.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (LENCLJPKDAO.Length != 0)
		{
			num ^= LENCLJPKDAO.GetHashCode();
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
		eFIJDEBFFNF_.WriteTo(ref output, _repeated_eFIJDEBFFNF_codec);
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DiceSlotId);
		}
		if (BOINMJJEBBE.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(BOINMJJEBBE);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Name);
		}
		if (LENCLJPKDAO.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteBytes(LENCLJPKDAO);
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
		num += eFIJDEBFFNF_.CalculateSize(_repeated_eFIJDEBFFNF_codec);
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (BOINMJJEBBE.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BOINMJJEBBE);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (LENCLJPKDAO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(LENCLJPKDAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DFLMKFIFHKB other)
	{
		if (other != null)
		{
			eFIJDEBFFNF_.Add(other.eFIJDEBFFNF_);
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.BOINMJJEBBE.Length != 0)
			{
				BOINMJJEBBE = other.BOINMJJEBBE;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.LENCLJPKDAO.Length != 0)
			{
				LENCLJPKDAO = other.LENCLJPKDAO;
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
			case 18u:
				eFIJDEBFFNF_.AddEntriesFrom(ref input, _repeated_eFIJDEBFFNF_codec);
				break;
			case 48u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 58u:
				BOINMJJEBBE = input.ReadString();
				break;
			case 66u:
				Name = input.ReadString();
				break;
			case 74u:
				LENCLJPKDAO = input.ReadBytes();
				break;
			}
		}
	}
}
