using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ANBOFKHHDNE : IMessage<ANBOFKHHDNE>, IMessage, IEquatable<ANBOFKHHDNE>, IDeepCloneable<ANBOFKHHDNE>, IBufferMessage
{
	private static readonly MessageParser<ANBOFKHHDNE> _parser = new MessageParser<ANBOFKHHDNE>(() => new ANBOFKHHDNE());

	private UnknownFieldSet _unknownFields;

	public const int CJOPNFDBJHDFieldNumber = 1;

	private uint cJOPNFDBJHD_;

	public const int UniqueIdFieldNumber = 5;

	private uint uniqueId_;

	public const int DisplayValueFieldNumber = 7;

	private uint displayValue_;

	public const int JBPCICCFPGEFieldNumber = 9;

	private uint jBPCICCFPGE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ANBOFKHHDNE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ANBOFKHHDNEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJOPNFDBJHD
	{
		get
		{
			return cJOPNFDBJHD_;
		}
		set
		{
			cJOPNFDBJHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBPCICCFPGE
	{
		get
		{
			return jBPCICCFPGE_;
		}
		set
		{
			jBPCICCFPGE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANBOFKHHDNE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANBOFKHHDNE(ANBOFKHHDNE other)
		: this()
	{
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		uniqueId_ = other.uniqueId_;
		displayValue_ = other.displayValue_;
		jBPCICCFPGE_ = other.jBPCICCFPGE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANBOFKHHDNE Clone()
	{
		return new ANBOFKHHDNE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ANBOFKHHDNE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ANBOFKHHDNE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (DisplayValue != other.DisplayValue)
		{
			return false;
		}
		if (JBPCICCFPGE != other.JBPCICCFPGE)
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
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (DisplayValue != 0)
		{
			num ^= DisplayValue.GetHashCode();
		}
		if (JBPCICCFPGE != 0)
		{
			num ^= JBPCICCFPGE.GetHashCode();
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
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CJOPNFDBJHD);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UniqueId);
		}
		if (DisplayValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DisplayValue);
		}
		if (JBPCICCFPGE != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(JBPCICCFPGE);
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
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (DisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DisplayValue);
		}
		if (JBPCICCFPGE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBPCICCFPGE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ANBOFKHHDNE other)
	{
		if (other != null)
		{
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.DisplayValue != 0)
			{
				DisplayValue = other.DisplayValue;
			}
			if (other.JBPCICCFPGE != 0)
			{
				JBPCICCFPGE = other.JBPCICCFPGE;
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
			case 8u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			case 40u:
				UniqueId = input.ReadUInt32();
				break;
			case 56u:
				DisplayValue = input.ReadUInt32();
				break;
			case 72u:
				JBPCICCFPGE = input.ReadUInt32();
				break;
			}
		}
	}
}
