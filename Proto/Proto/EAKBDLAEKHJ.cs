using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EAKBDLAEKHJ : IMessage<EAKBDLAEKHJ>, IMessage, IEquatable<EAKBDLAEKHJ>, IDeepCloneable<EAKBDLAEKHJ>, IBufferMessage
{
	private static readonly MessageParser<EAKBDLAEKHJ> _parser = new MessageParser<EAKBDLAEKHJ>(() => new EAKBDLAEKHJ());

	private UnknownFieldSet _unknownFields;

	public const int AAIKDELNAKEFieldNumber = 6;

	private uint aAIKDELNAKE_;

	public const int LJEIDELEADDFieldNumber = 7;

	private uint lJEIDELEADD_;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int HCPJCIIGMPGFieldNumber = 10;

	private bool hCPJCIIGMPG_;

	public const int PMNEGOPJOIBFieldNumber = 11;

	private uint pMNEGOPJOIB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EAKBDLAEKHJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EAKBDLAEKHJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAIKDELNAKE
	{
		get
		{
			return aAIKDELNAKE_;
		}
		set
		{
			aAIKDELNAKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJEIDELEADD
	{
		get
		{
			return lJEIDELEADD_;
		}
		set
		{
			lJEIDELEADD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HCPJCIIGMPG
	{
		get
		{
			return hCPJCIIGMPG_;
		}
		set
		{
			hCPJCIIGMPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMNEGOPJOIB
	{
		get
		{
			return pMNEGOPJOIB_;
		}
		set
		{
			pMNEGOPJOIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAKBDLAEKHJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAKBDLAEKHJ(EAKBDLAEKHJ other)
		: this()
	{
		aAIKDELNAKE_ = other.aAIKDELNAKE_;
		lJEIDELEADD_ = other.lJEIDELEADD_;
		groupId_ = other.groupId_;
		hCPJCIIGMPG_ = other.hCPJCIIGMPG_;
		pMNEGOPJOIB_ = other.pMNEGOPJOIB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAKBDLAEKHJ Clone()
	{
		return new EAKBDLAEKHJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EAKBDLAEKHJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EAKBDLAEKHJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AAIKDELNAKE != other.AAIKDELNAKE)
		{
			return false;
		}
		if (LJEIDELEADD != other.LJEIDELEADD)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (HCPJCIIGMPG != other.HCPJCIIGMPG)
		{
			return false;
		}
		if (PMNEGOPJOIB != other.PMNEGOPJOIB)
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
		if (AAIKDELNAKE != 0)
		{
			num ^= AAIKDELNAKE.GetHashCode();
		}
		if (LJEIDELEADD != 0)
		{
			num ^= LJEIDELEADD.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (HCPJCIIGMPG)
		{
			num ^= HCPJCIIGMPG.GetHashCode();
		}
		if (PMNEGOPJOIB != 0)
		{
			num ^= PMNEGOPJOIB.GetHashCode();
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
		if (AAIKDELNAKE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AAIKDELNAKE);
		}
		if (LJEIDELEADD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LJEIDELEADD);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		if (HCPJCIIGMPG)
		{
			output.WriteRawTag(80);
			output.WriteBool(HCPJCIIGMPG);
		}
		if (PMNEGOPJOIB != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PMNEGOPJOIB);
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
		if (AAIKDELNAKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAIKDELNAKE);
		}
		if (LJEIDELEADD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJEIDELEADD);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (HCPJCIIGMPG)
		{
			num += 2;
		}
		if (PMNEGOPJOIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMNEGOPJOIB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EAKBDLAEKHJ other)
	{
		if (other != null)
		{
			if (other.AAIKDELNAKE != 0)
			{
				AAIKDELNAKE = other.AAIKDELNAKE;
			}
			if (other.LJEIDELEADD != 0)
			{
				LJEIDELEADD = other.LJEIDELEADD;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.HCPJCIIGMPG)
			{
				HCPJCIIGMPG = other.HCPJCIIGMPG;
			}
			if (other.PMNEGOPJOIB != 0)
			{
				PMNEGOPJOIB = other.PMNEGOPJOIB;
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
			case 48u:
				AAIKDELNAKE = input.ReadUInt32();
				break;
			case 56u:
				LJEIDELEADD = input.ReadUInt32();
				break;
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 80u:
				HCPJCIIGMPG = input.ReadBool();
				break;
			case 88u:
				PMNEGOPJOIB = input.ReadUInt32();
				break;
			}
		}
	}
}
