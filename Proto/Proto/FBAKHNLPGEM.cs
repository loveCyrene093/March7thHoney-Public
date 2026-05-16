using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FBAKHNLPGEM : IMessage<FBAKHNLPGEM>, IMessage, IEquatable<FBAKHNLPGEM>, IDeepCloneable<FBAKHNLPGEM>, IBufferMessage
{
	private static readonly MessageParser<FBAKHNLPGEM> _parser = new MessageParser<FBAKHNLPGEM>(() => new FBAKHNLPGEM());

	private UnknownFieldSet _unknownFields;

	public const int HGPGDCOCDFKFieldNumber = 12;

	private DLCCOJPHBCB hGPGDCOCDFK_;

	public const int ReasonFieldNumber = 13;

	private FMANPCKGFDD reason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FBAKHNLPGEM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FBAKHNLPGEMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCCOJPHBCB HGPGDCOCDFK
	{
		get
		{
			return hGPGDCOCDFK_;
		}
		set
		{
			hGPGDCOCDFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMANPCKGFDD Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBAKHNLPGEM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBAKHNLPGEM(FBAKHNLPGEM other)
		: this()
	{
		hGPGDCOCDFK_ = ((other.hGPGDCOCDFK_ != null) ? other.hGPGDCOCDFK_.Clone() : null);
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBAKHNLPGEM Clone()
	{
		return new FBAKHNLPGEM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FBAKHNLPGEM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FBAKHNLPGEM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HGPGDCOCDFK, other.HGPGDCOCDFK))
		{
			return false;
		}
		if (Reason != other.Reason)
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
		if (hGPGDCOCDFK_ != null)
		{
			num ^= HGPGDCOCDFK.GetHashCode();
		}
		if (Reason != FMANPCKGFDD.Maoejieahah)
		{
			num ^= Reason.GetHashCode();
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
		if (hGPGDCOCDFK_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(HGPGDCOCDFK);
		}
		if (Reason != FMANPCKGFDD.Maoejieahah)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)Reason);
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
		if (hGPGDCOCDFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HGPGDCOCDFK);
		}
		if (Reason != FMANPCKGFDD.Maoejieahah)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FBAKHNLPGEM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hGPGDCOCDFK_ != null)
		{
			if (hGPGDCOCDFK_ == null)
			{
				HGPGDCOCDFK = new DLCCOJPHBCB();
			}
			HGPGDCOCDFK.MergeFrom(other.HGPGDCOCDFK);
		}
		if (other.Reason != FMANPCKGFDD.Maoejieahah)
		{
			Reason = other.Reason;
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
			case 98u:
				if (hGPGDCOCDFK_ == null)
				{
					HGPGDCOCDFK = new DLCCOJPHBCB();
				}
				input.ReadMessage(HGPGDCOCDFK);
				break;
			case 104u:
				Reason = (FMANPCKGFDD)input.ReadEnum();
				break;
			}
		}
	}
}
