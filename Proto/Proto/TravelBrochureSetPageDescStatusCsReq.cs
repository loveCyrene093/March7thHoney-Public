using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TravelBrochureSetPageDescStatusCsReq : IMessage<TravelBrochureSetPageDescStatusCsReq>, IMessage, IEquatable<TravelBrochureSetPageDescStatusCsReq>, IDeepCloneable<TravelBrochureSetPageDescStatusCsReq>, IBufferMessage
{
	private static readonly MessageParser<TravelBrochureSetPageDescStatusCsReq> _parser = new MessageParser<TravelBrochureSetPageDescStatusCsReq>(() => new TravelBrochureSetPageDescStatusCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GODADABGOJDFieldNumber = 5;

	private HADIBEMFDML gODADABGOJD_;

	public const int HBCJPCMJPHEFieldNumber = 9;

	private uint hBCJPCMJPHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TravelBrochureSetPageDescStatusCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TravelBrochureSetPageDescStatusCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HADIBEMFDML GODADABGOJD
	{
		get
		{
			return gODADABGOJD_;
		}
		set
		{
			gODADABGOJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBCJPCMJPHE
	{
		get
		{
			return hBCJPCMJPHE_;
		}
		set
		{
			hBCJPCMJPHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureSetPageDescStatusCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureSetPageDescStatusCsReq(TravelBrochureSetPageDescStatusCsReq other)
		: this()
	{
		gODADABGOJD_ = other.gODADABGOJD_;
		hBCJPCMJPHE_ = other.hBCJPCMJPHE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureSetPageDescStatusCsReq Clone()
	{
		return new TravelBrochureSetPageDescStatusCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TravelBrochureSetPageDescStatusCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TravelBrochureSetPageDescStatusCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GODADABGOJD != other.GODADABGOJD)
		{
			return false;
		}
		if (HBCJPCMJPHE != other.HBCJPCMJPHE)
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
		if (GODADABGOJD != HADIBEMFDML.Imkmpbmamdg)
		{
			num ^= GODADABGOJD.GetHashCode();
		}
		if (HBCJPCMJPHE != 0)
		{
			num ^= HBCJPCMJPHE.GetHashCode();
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
		if (GODADABGOJD != HADIBEMFDML.Imkmpbmamdg)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)GODADABGOJD);
		}
		if (HBCJPCMJPHE != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HBCJPCMJPHE);
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
		if (GODADABGOJD != HADIBEMFDML.Imkmpbmamdg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GODADABGOJD);
		}
		if (HBCJPCMJPHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBCJPCMJPHE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TravelBrochureSetPageDescStatusCsReq other)
	{
		if (other != null)
		{
			if (other.GODADABGOJD != HADIBEMFDML.Imkmpbmamdg)
			{
				GODADABGOJD = other.GODADABGOJD;
			}
			if (other.HBCJPCMJPHE != 0)
			{
				HBCJPCMJPHE = other.HBCJPCMJPHE;
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
				GODADABGOJD = (HADIBEMFDML)input.ReadEnum();
				break;
			case 72u:
				HBCJPCMJPHE = input.ReadUInt32();
				break;
			}
		}
	}
}
