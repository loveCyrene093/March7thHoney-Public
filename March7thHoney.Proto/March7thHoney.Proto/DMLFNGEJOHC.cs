using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMLFNGEJOHC : IMessage<DMLFNGEJOHC>, IMessage, IEquatable<DMLFNGEJOHC>, IDeepCloneable<DMLFNGEJOHC>, IBufferMessage
{
	private static readonly MessageParser<DMLFNGEJOHC> _parser = new MessageParser<DMLFNGEJOHC>(() => new DMLFNGEJOHC());

	private UnknownFieldSet _unknownFields;

	public const int KDLLCFMLMNDFieldNumber = 1;

	private CAEABHJNLMI kDLLCFMLMND_;

	public const int PHOPBJFMNDCFieldNumber = 10;

	private uint pHOPBJFMNDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMLFNGEJOHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMLFNGEJOHCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAEABHJNLMI KDLLCFMLMND
	{
		get
		{
			return kDLLCFMLMND_;
		}
		set
		{
			kDLLCFMLMND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHOPBJFMNDC
	{
		get
		{
			return pHOPBJFMNDC_;
		}
		set
		{
			pHOPBJFMNDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLFNGEJOHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLFNGEJOHC(DMLFNGEJOHC other)
		: this()
	{
		kDLLCFMLMND_ = ((other.kDLLCFMLMND_ != null) ? other.kDLLCFMLMND_.Clone() : null);
		pHOPBJFMNDC_ = other.pHOPBJFMNDC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMLFNGEJOHC Clone()
	{
		return new DMLFNGEJOHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMLFNGEJOHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMLFNGEJOHC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KDLLCFMLMND, other.KDLLCFMLMND))
		{
			return false;
		}
		if (PHOPBJFMNDC != other.PHOPBJFMNDC)
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
		if (kDLLCFMLMND_ != null)
		{
			num ^= KDLLCFMLMND.GetHashCode();
		}
		if (PHOPBJFMNDC != 0)
		{
			num ^= PHOPBJFMNDC.GetHashCode();
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
		if (kDLLCFMLMND_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(KDLLCFMLMND);
		}
		if (PHOPBJFMNDC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PHOPBJFMNDC);
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
		if (kDLLCFMLMND_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KDLLCFMLMND);
		}
		if (PHOPBJFMNDC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHOPBJFMNDC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMLFNGEJOHC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kDLLCFMLMND_ != null)
		{
			if (kDLLCFMLMND_ == null)
			{
				KDLLCFMLMND = new CAEABHJNLMI();
			}
			KDLLCFMLMND.MergeFrom(other.KDLLCFMLMND);
		}
		if (other.PHOPBJFMNDC != 0)
		{
			PHOPBJFMNDC = other.PHOPBJFMNDC;
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
			case 10u:
				if (kDLLCFMLMND_ == null)
				{
					KDLLCFMLMND = new CAEABHJNLMI();
				}
				input.ReadMessage(KDLLCFMLMND);
				break;
			case 80u:
				PHOPBJFMNDC = input.ReadUInt32();
				break;
			}
		}
	}
}
