using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCFAJAMPDKF : IMessage<BCFAJAMPDKF>, IMessage, IEquatable<BCFAJAMPDKF>, IDeepCloneable<BCFAJAMPDKF>, IBufferMessage
{
	private static readonly MessageParser<BCFAJAMPDKF> _parser = new MessageParser<BCFAJAMPDKF>(() => new BCFAJAMPDKF());

	private UnknownFieldSet _unknownFields;

	public const int BGNLOAEDCOJFieldNumber = 9;

	private uint bGNLOAEDCOJ_;

	public const int FOOLMIADMMHFieldNumber = 10;

	private uint fOOLMIADMMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCFAJAMPDKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCFAJAMPDKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGNLOAEDCOJ
	{
		get
		{
			return bGNLOAEDCOJ_;
		}
		set
		{
			bGNLOAEDCOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCFAJAMPDKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCFAJAMPDKF(BCFAJAMPDKF other)
		: this()
	{
		bGNLOAEDCOJ_ = other.bGNLOAEDCOJ_;
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCFAJAMPDKF Clone()
	{
		return new BCFAJAMPDKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCFAJAMPDKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCFAJAMPDKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BGNLOAEDCOJ != other.BGNLOAEDCOJ)
		{
			return false;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
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
		if (BGNLOAEDCOJ != 0)
		{
			num ^= BGNLOAEDCOJ.GetHashCode();
		}
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
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
		if (BGNLOAEDCOJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BGNLOAEDCOJ);
		}
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FOOLMIADMMH);
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
		if (BGNLOAEDCOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGNLOAEDCOJ);
		}
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCFAJAMPDKF other)
	{
		if (other != null)
		{
			if (other.BGNLOAEDCOJ != 0)
			{
				BGNLOAEDCOJ = other.BGNLOAEDCOJ;
			}
			if (other.FOOLMIADMMH != 0)
			{
				FOOLMIADMMH = other.FOOLMIADMMH;
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
			case 72u:
				BGNLOAEDCOJ = input.ReadUInt32();
				break;
			case 80u:
				FOOLMIADMMH = input.ReadUInt32();
				break;
			}
		}
	}
}
