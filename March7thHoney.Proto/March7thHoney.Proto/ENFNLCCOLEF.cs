using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ENFNLCCOLEF : IMessage<ENFNLCCOLEF>, IMessage, IEquatable<ENFNLCCOLEF>, IDeepCloneable<ENFNLCCOLEF>, IBufferMessage
{
	private static readonly MessageParser<ENFNLCCOLEF> _parser = new MessageParser<ENFNLCCOLEF>(() => new ENFNLCCOLEF());

	private UnknownFieldSet _unknownFields;

	public const int DressEquipmentUniqueIdFieldNumber = 10;

	private uint dressEquipmentUniqueId_;

	public const int OHOKBKELFOKFieldNumber = 15;

	private uint oHOKBKELFOK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ENFNLCCOLEF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ENFNLCCOLEFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressEquipmentUniqueId
	{
		get
		{
			return dressEquipmentUniqueId_;
		}
		set
		{
			dressEquipmentUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OHOKBKELFOK
	{
		get
		{
			return oHOKBKELFOK_;
		}
		set
		{
			oHOKBKELFOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENFNLCCOLEF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENFNLCCOLEF(ENFNLCCOLEF other)
		: this()
	{
		dressEquipmentUniqueId_ = other.dressEquipmentUniqueId_;
		oHOKBKELFOK_ = other.oHOKBKELFOK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENFNLCCOLEF Clone()
	{
		return new ENFNLCCOLEF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ENFNLCCOLEF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ENFNLCCOLEF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DressEquipmentUniqueId != other.DressEquipmentUniqueId)
		{
			return false;
		}
		if (OHOKBKELFOK != other.OHOKBKELFOK)
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
		if (DressEquipmentUniqueId != 0)
		{
			num ^= DressEquipmentUniqueId.GetHashCode();
		}
		if (OHOKBKELFOK != 0)
		{
			num ^= OHOKBKELFOK.GetHashCode();
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
		if (DressEquipmentUniqueId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DressEquipmentUniqueId);
		}
		if (OHOKBKELFOK != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OHOKBKELFOK);
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
		if (DressEquipmentUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressEquipmentUniqueId);
		}
		if (OHOKBKELFOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OHOKBKELFOK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ENFNLCCOLEF other)
	{
		if (other != null)
		{
			if (other.DressEquipmentUniqueId != 0)
			{
				DressEquipmentUniqueId = other.DressEquipmentUniqueId;
			}
			if (other.OHOKBKELFOK != 0)
			{
				OHOKBKELFOK = other.OHOKBKELFOK;
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
			case 80u:
				DressEquipmentUniqueId = input.ReadUInt32();
				break;
			case 120u:
				OHOKBKELFOK = input.ReadUInt32();
				break;
			}
		}
	}
}
