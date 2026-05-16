using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EKOIHOMFMDE : IMessage<EKOIHOMFMDE>, IMessage, IEquatable<EKOIHOMFMDE>, IDeepCloneable<EKOIHOMFMDE>, IBufferMessage
{
	private static readonly MessageParser<EKOIHOMFMDE> _parser = new MessageParser<EKOIHOMFMDE>(() => new EKOIHOMFMDE());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 7;

	private FGMPEEMAHKE type_;

	public const int EDODCLMAFILFieldNumber = 9;

	private bool eDODCLMAFIL_;

	public const int IdFieldNumber = 14;

	private uint id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EKOIHOMFMDE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EKOIHOMFMDEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FGMPEEMAHKE Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EDODCLMAFIL
	{
		get
		{
			return eDODCLMAFIL_;
		}
		set
		{
			eDODCLMAFIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKOIHOMFMDE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKOIHOMFMDE(EKOIHOMFMDE other)
		: this()
	{
		type_ = other.type_;
		eDODCLMAFIL_ = other.eDODCLMAFIL_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKOIHOMFMDE Clone()
	{
		return new EKOIHOMFMDE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EKOIHOMFMDE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EKOIHOMFMDE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (EDODCLMAFIL != other.EDODCLMAFIL)
		{
			return false;
		}
		if (Id != other.Id)
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
		if (Type != FGMPEEMAHKE.Pcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (EDODCLMAFIL)
		{
			num ^= EDODCLMAFIL.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (Type != FGMPEEMAHKE.Pcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Type);
		}
		if (EDODCLMAFIL)
		{
			output.WriteRawTag(72);
			output.WriteBool(EDODCLMAFIL);
		}
		if (Id != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Id);
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
		if (Type != FGMPEEMAHKE.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (EDODCLMAFIL)
		{
			num += 2;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EKOIHOMFMDE other)
	{
		if (other != null)
		{
			if (other.Type != FGMPEEMAHKE.Pcpdhelpkem)
			{
				Type = other.Type;
			}
			if (other.EDODCLMAFIL)
			{
				EDODCLMAFIL = other.EDODCLMAFIL;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 56u:
				Type = (FGMPEEMAHKE)input.ReadEnum();
				break;
			case 72u:
				EDODCLMAFIL = input.ReadBool();
				break;
			case 112u:
				Id = input.ReadUInt32();
				break;
			}
		}
	}
}
