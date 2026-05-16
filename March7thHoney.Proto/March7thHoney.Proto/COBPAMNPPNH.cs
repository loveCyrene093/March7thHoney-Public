using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class COBPAMNPPNH : IMessage<COBPAMNPPNH>, IMessage, IEquatable<COBPAMNPPNH>, IDeepCloneable<COBPAMNPPNH>, IBufferMessage
{
	private static readonly MessageParser<COBPAMNPPNH> _parser = new MessageParser<COBPAMNPPNH>(() => new COBPAMNPPNH());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 5;

	private uint pENLMEIJIFK_;

	public const int EMAMFJGGMAAFieldNumber = 7;

	private IPHFDELCNBD eMAMFJGGMAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<COBPAMNPPNH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => COBPAMNPPNHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPHFDELCNBD EMAMFJGGMAA
	{
		get
		{
			return eMAMFJGGMAA_;
		}
		set
		{
			eMAMFJGGMAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COBPAMNPPNH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COBPAMNPPNH(COBPAMNPPNH other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		eMAMFJGGMAA_ = ((other.eMAMFJGGMAA_ != null) ? other.eMAMFJGGMAA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COBPAMNPPNH Clone()
	{
		return new COBPAMNPPNH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as COBPAMNPPNH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(COBPAMNPPNH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (!object.Equals(EMAMFJGGMAA, other.EMAMFJGGMAA))
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
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (eMAMFJGGMAA_ != null)
		{
			num ^= EMAMFJGGMAA.GetHashCode();
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
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (eMAMFJGGMAA_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(EMAMFJGGMAA);
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
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (eMAMFJGGMAA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EMAMFJGGMAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(COBPAMNPPNH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PENLMEIJIFK != 0)
		{
			PENLMEIJIFK = other.PENLMEIJIFK;
		}
		if (other.eMAMFJGGMAA_ != null)
		{
			if (eMAMFJGGMAA_ == null)
			{
				EMAMFJGGMAA = new IPHFDELCNBD();
			}
			EMAMFJGGMAA.MergeFrom(other.EMAMFJGGMAA);
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
			case 40u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 58u:
				if (eMAMFJGGMAA_ == null)
				{
					EMAMFJGGMAA = new IPHFDELCNBD();
				}
				input.ReadMessage(EMAMFJGGMAA);
				break;
			}
		}
	}
}
