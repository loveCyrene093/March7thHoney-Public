using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ECNCEKBIDPB : IMessage<ECNCEKBIDPB>, IMessage, IEquatable<ECNCEKBIDPB>, IDeepCloneable<ECNCEKBIDPB>, IBufferMessage
{
	private static readonly MessageParser<ECNCEKBIDPB> _parser = new MessageParser<ECNCEKBIDPB>(() => new ECNCEKBIDPB());

	private UnknownFieldSet _unknownFields;

	public const int BOINMJJEBBEFieldNumber = 2;

	private string bOINMJJEBBE_ = "";

	public const int NameFieldNumber = 3;

	private string name_ = "";

	public const int DiceSlotIdFieldNumber = 4;

	private uint diceSlotId_;

	public const int LENCLJPKDAOFieldNumber = 13;

	private ByteString lENCLJPKDAO_ = ByteString.Empty;

	public const int CELHCDABFCLFieldNumber = 14;

	private bool cELHCDABFCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ECNCEKBIDPB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ECNCEKBIDPBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool CELHCDABFCL
	{
		get
		{
			return cELHCDABFCL_;
		}
		set
		{
			cELHCDABFCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECNCEKBIDPB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECNCEKBIDPB(ECNCEKBIDPB other)
		: this()
	{
		bOINMJJEBBE_ = other.bOINMJJEBBE_;
		name_ = other.name_;
		diceSlotId_ = other.diceSlotId_;
		lENCLJPKDAO_ = other.lENCLJPKDAO_;
		cELHCDABFCL_ = other.cELHCDABFCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECNCEKBIDPB Clone()
	{
		return new ECNCEKBIDPB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ECNCEKBIDPB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ECNCEKBIDPB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BOINMJJEBBE != other.BOINMJJEBBE)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (LENCLJPKDAO != other.LENCLJPKDAO)
		{
			return false;
		}
		if (CELHCDABFCL != other.CELHCDABFCL)
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
		if (BOINMJJEBBE.Length != 0)
		{
			num ^= BOINMJJEBBE.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (LENCLJPKDAO.Length != 0)
		{
			num ^= LENCLJPKDAO.GetHashCode();
		}
		if (CELHCDABFCL)
		{
			num ^= CELHCDABFCL.GetHashCode();
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
		if (BOINMJJEBBE.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BOINMJJEBBE);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Name);
		}
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DiceSlotId);
		}
		if (LENCLJPKDAO.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteBytes(LENCLJPKDAO);
		}
		if (CELHCDABFCL)
		{
			output.WriteRawTag(112);
			output.WriteBool(CELHCDABFCL);
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
		if (BOINMJJEBBE.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BOINMJJEBBE);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (LENCLJPKDAO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(LENCLJPKDAO);
		}
		if (CELHCDABFCL)
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
	public void MergeFrom(ECNCEKBIDPB other)
	{
		if (other != null)
		{
			if (other.BOINMJJEBBE.Length != 0)
			{
				BOINMJJEBBE = other.BOINMJJEBBE;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.LENCLJPKDAO.Length != 0)
			{
				LENCLJPKDAO = other.LENCLJPKDAO;
			}
			if (other.CELHCDABFCL)
			{
				CELHCDABFCL = other.CELHCDABFCL;
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
				BOINMJJEBBE = input.ReadString();
				break;
			case 26u:
				Name = input.ReadString();
				break;
			case 32u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 106u:
				LENCLJPKDAO = input.ReadBytes();
				break;
			case 112u:
				CELHCDABFCL = input.ReadBool();
				break;
			}
		}
	}
}
