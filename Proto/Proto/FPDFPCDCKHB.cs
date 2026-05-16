using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FPDFPCDCKHB : IMessage<FPDFPCDCKHB>, IMessage, IEquatable<FPDFPCDCKHB>, IDeepCloneable<FPDFPCDCKHB>, IBufferMessage
{
	private static readonly MessageParser<FPDFPCDCKHB> _parser = new MessageParser<FPDFPCDCKHB>(() => new FPDFPCDCKHB());

	private UnknownFieldSet _unknownFields;

	public const int POFOCMIHJIAFieldNumber = 3;

	private PBICJCPDLGD pOFOCMIHJIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FPDFPCDCKHB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FPDFPCDCKHBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBICJCPDLGD POFOCMIHJIA
	{
		get
		{
			return pOFOCMIHJIA_;
		}
		set
		{
			pOFOCMIHJIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPDFPCDCKHB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPDFPCDCKHB(FPDFPCDCKHB other)
		: this()
	{
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPDFPCDCKHB Clone()
	{
		return new FPDFPCDCKHB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FPDFPCDCKHB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FPDFPCDCKHB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
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
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
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
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(POFOCMIHJIA);
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
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FPDFPCDCKHB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new PBICJCPDLGD();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new PBICJCPDLGD();
			}
			input.ReadMessage(POFOCMIHJIA);
		}
	}
}
