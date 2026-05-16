using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ENALOKIFDFH : IMessage<ENALOKIFDFH>, IMessage, IEquatable<ENALOKIFDFH>, IDeepCloneable<ENALOKIFDFH>, IBufferMessage
{
	private static readonly MessageParser<ENALOKIFDFH> _parser = new MessageParser<ENALOKIFDFH>(() => new ENALOKIFDFH());

	private UnknownFieldSet _unknownFields;

	public const int PanelIdFieldNumber = 3;

	private uint panelId_;

	public const int FADFCMMNDDKFieldNumber = 5;

	private uint fADFCMMNDDK_;

	public const int KLOBEEOJBCNFieldNumber = 10;

	private uint kLOBEEOJBCN_;

	public const int FHJBMBLFAFHFieldNumber = 15;

	private uint fHJBMBLFAFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ENALOKIFDFH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ENALOKIFDFHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FADFCMMNDDK
	{
		get
		{
			return fADFCMMNDDK_;
		}
		set
		{
			fADFCMMNDDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLOBEEOJBCN
	{
		get
		{
			return kLOBEEOJBCN_;
		}
		set
		{
			kLOBEEOJBCN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHJBMBLFAFH
	{
		get
		{
			return fHJBMBLFAFH_;
		}
		set
		{
			fHJBMBLFAFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENALOKIFDFH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENALOKIFDFH(ENALOKIFDFH other)
		: this()
	{
		panelId_ = other.panelId_;
		fADFCMMNDDK_ = other.fADFCMMNDDK_;
		kLOBEEOJBCN_ = other.kLOBEEOJBCN_;
		fHJBMBLFAFH_ = other.fHJBMBLFAFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENALOKIFDFH Clone()
	{
		return new ENALOKIFDFH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ENALOKIFDFH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ENALOKIFDFH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (FADFCMMNDDK != other.FADFCMMNDDK)
		{
			return false;
		}
		if (KLOBEEOJBCN != other.KLOBEEOJBCN)
		{
			return false;
		}
		if (FHJBMBLFAFH != other.FHJBMBLFAFH)
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
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (FADFCMMNDDK != 0)
		{
			num ^= FADFCMMNDDK.GetHashCode();
		}
		if (KLOBEEOJBCN != 0)
		{
			num ^= KLOBEEOJBCN.GetHashCode();
		}
		if (FHJBMBLFAFH != 0)
		{
			num ^= FHJBMBLFAFH.GetHashCode();
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
		if (PanelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PanelId);
		}
		if (FADFCMMNDDK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FADFCMMNDDK);
		}
		if (KLOBEEOJBCN != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KLOBEEOJBCN);
		}
		if (FHJBMBLFAFH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FHJBMBLFAFH);
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
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (FADFCMMNDDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FADFCMMNDDK);
		}
		if (KLOBEEOJBCN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLOBEEOJBCN);
		}
		if (FHJBMBLFAFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHJBMBLFAFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ENALOKIFDFH other)
	{
		if (other != null)
		{
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.FADFCMMNDDK != 0)
			{
				FADFCMMNDDK = other.FADFCMMNDDK;
			}
			if (other.KLOBEEOJBCN != 0)
			{
				KLOBEEOJBCN = other.KLOBEEOJBCN;
			}
			if (other.FHJBMBLFAFH != 0)
			{
				FHJBMBLFAFH = other.FHJBMBLFAFH;
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
			case 24u:
				PanelId = input.ReadUInt32();
				break;
			case 40u:
				FADFCMMNDDK = input.ReadUInt32();
				break;
			case 80u:
				KLOBEEOJBCN = input.ReadUInt32();
				break;
			case 120u:
				FHJBMBLFAFH = input.ReadUInt32();
				break;
			}
		}
	}
}
