using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJHDDMCFAMF : IMessage<BJHDDMCFAMF>, IMessage, IEquatable<BJHDDMCFAMF>, IDeepCloneable<BJHDDMCFAMF>, IBufferMessage
{
	private static readonly MessageParser<BJHDDMCFAMF> _parser = new MessageParser<BJHDDMCFAMF>(() => new BJHDDMCFAMF());

	private UnknownFieldSet _unknownFields;

	public const int NPDCOJCAHPEFieldNumber = 5;

	private OPNCDHGNEDF nPDCOJCAHPE_;

	public const int LOFODGNJJFKFieldNumber = 10;

	private HABJHHLPLFG lOFODGNJJFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJHDDMCFAMF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJHDDMCFAMFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPNCDHGNEDF NPDCOJCAHPE
	{
		get
		{
			return nPDCOJCAHPE_;
		}
		set
		{
			nPDCOJCAHPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HABJHHLPLFG LOFODGNJJFK
	{
		get
		{
			return lOFODGNJJFK_;
		}
		set
		{
			lOFODGNJJFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJHDDMCFAMF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJHDDMCFAMF(BJHDDMCFAMF other)
		: this()
	{
		nPDCOJCAHPE_ = ((other.nPDCOJCAHPE_ != null) ? other.nPDCOJCAHPE_.Clone() : null);
		lOFODGNJJFK_ = ((other.lOFODGNJJFK_ != null) ? other.lOFODGNJJFK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJHDDMCFAMF Clone()
	{
		return new BJHDDMCFAMF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJHDDMCFAMF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJHDDMCFAMF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NPDCOJCAHPE, other.NPDCOJCAHPE))
		{
			return false;
		}
		if (!object.Equals(LOFODGNJJFK, other.LOFODGNJJFK))
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
		if (nPDCOJCAHPE_ != null)
		{
			num ^= NPDCOJCAHPE.GetHashCode();
		}
		if (lOFODGNJJFK_ != null)
		{
			num ^= LOFODGNJJFK.GetHashCode();
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
		if (nPDCOJCAHPE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NPDCOJCAHPE);
		}
		if (lOFODGNJJFK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LOFODGNJJFK);
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
		if (nPDCOJCAHPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NPDCOJCAHPE);
		}
		if (lOFODGNJJFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LOFODGNJJFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJHDDMCFAMF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nPDCOJCAHPE_ != null)
		{
			if (nPDCOJCAHPE_ == null)
			{
				NPDCOJCAHPE = new OPNCDHGNEDF();
			}
			NPDCOJCAHPE.MergeFrom(other.NPDCOJCAHPE);
		}
		if (other.lOFODGNJJFK_ != null)
		{
			if (lOFODGNJJFK_ == null)
			{
				LOFODGNJJFK = new HABJHHLPLFG();
			}
			LOFODGNJJFK.MergeFrom(other.LOFODGNJJFK);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 42u:
				if (nPDCOJCAHPE_ == null)
				{
					NPDCOJCAHPE = new OPNCDHGNEDF();
				}
				input.ReadMessage(NPDCOJCAHPE);
				break;
			case 82u:
				if (lOFODGNJJFK_ == null)
				{
					LOFODGNJJFK = new HABJHHLPLFG();
				}
				input.ReadMessage(LOFODGNJJFK);
				break;
			}
		}
	}
}
