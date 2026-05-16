using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OKFLIFAODGK : IMessage<OKFLIFAODGK>, IMessage, IEquatable<OKFLIFAODGK>, IDeepCloneable<OKFLIFAODGK>, IBufferMessage
{
	private static readonly MessageParser<OKFLIFAODGK> _parser = new MessageParser<OKFLIFAODGK>(() => new OKFLIFAODGK());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 6;

	private uint pENLMEIJIFK_;

	public const int PPBAAALANJBFieldNumber = 13;

	private IFDJPDIKLDI pPBAAALANJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OKFLIFAODGK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OKFLIFAODGKReflection.Descriptor.MessageTypes[0];

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
	public IFDJPDIKLDI PPBAAALANJB
	{
		get
		{
			return pPBAAALANJB_;
		}
		set
		{
			pPBAAALANJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKFLIFAODGK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKFLIFAODGK(OKFLIFAODGK other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		pPBAAALANJB_ = ((other.pPBAAALANJB_ != null) ? other.pPBAAALANJB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKFLIFAODGK Clone()
	{
		return new OKFLIFAODGK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OKFLIFAODGK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OKFLIFAODGK other)
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
		if (!object.Equals(PPBAAALANJB, other.PPBAAALANJB))
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
		if (pPBAAALANJB_ != null)
		{
			num ^= PPBAAALANJB.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (pPBAAALANJB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(PPBAAALANJB);
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
		if (pPBAAALANJB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPBAAALANJB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OKFLIFAODGK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PENLMEIJIFK != 0)
		{
			PENLMEIJIFK = other.PENLMEIJIFK;
		}
		if (other.pPBAAALANJB_ != null)
		{
			if (pPBAAALANJB_ == null)
			{
				PPBAAALANJB = new IFDJPDIKLDI();
			}
			PPBAAALANJB.MergeFrom(other.PPBAAALANJB);
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
			case 48u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 106u:
				if (pPBAAALANJB_ == null)
				{
					PPBAAALANJB = new IFDJPDIKLDI();
				}
				input.ReadMessage(PPBAAALANJB);
				break;
			}
		}
	}
}
