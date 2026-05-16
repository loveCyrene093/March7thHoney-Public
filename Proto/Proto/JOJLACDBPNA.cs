using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JOJLACDBPNA : IMessage<JOJLACDBPNA>, IMessage, IEquatable<JOJLACDBPNA>, IDeepCloneable<JOJLACDBPNA>, IBufferMessage
{
	private static readonly MessageParser<JOJLACDBPNA> _parser = new MessageParser<JOJLACDBPNA>(() => new JOJLACDBPNA());

	private UnknownFieldSet _unknownFields;

	public const int KHDLMPAKEGFFieldNumber = 1;

	private uint kHDLMPAKEGF_;

	public const int PIHGDHAKLCBFieldNumber = 3;

	private BBHPOJJLFEC pIHGDHAKLCB_;

	public const int ELLELJFGDPHFieldNumber = 12;

	private uint eLLELJFGDPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JOJLACDBPNA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JOJLACDBPNAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHDLMPAKEGF
	{
		get
		{
			return kHDLMPAKEGF_;
		}
		set
		{
			kHDLMPAKEGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBHPOJJLFEC PIHGDHAKLCB
	{
		get
		{
			return pIHGDHAKLCB_;
		}
		set
		{
			pIHGDHAKLCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ELLELJFGDPH
	{
		get
		{
			return eLLELJFGDPH_;
		}
		set
		{
			eLLELJFGDPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOJLACDBPNA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOJLACDBPNA(JOJLACDBPNA other)
		: this()
	{
		kHDLMPAKEGF_ = other.kHDLMPAKEGF_;
		pIHGDHAKLCB_ = ((other.pIHGDHAKLCB_ != null) ? other.pIHGDHAKLCB_.Clone() : null);
		eLLELJFGDPH_ = other.eLLELJFGDPH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOJLACDBPNA Clone()
	{
		return new JOJLACDBPNA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JOJLACDBPNA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JOJLACDBPNA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHDLMPAKEGF != other.KHDLMPAKEGF)
		{
			return false;
		}
		if (!object.Equals(PIHGDHAKLCB, other.PIHGDHAKLCB))
		{
			return false;
		}
		if (ELLELJFGDPH != other.ELLELJFGDPH)
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
		if (KHDLMPAKEGF != 0)
		{
			num ^= KHDLMPAKEGF.GetHashCode();
		}
		if (pIHGDHAKLCB_ != null)
		{
			num ^= PIHGDHAKLCB.GetHashCode();
		}
		if (ELLELJFGDPH != 0)
		{
			num ^= ELLELJFGDPH.GetHashCode();
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
		if (KHDLMPAKEGF != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KHDLMPAKEGF);
		}
		if (pIHGDHAKLCB_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PIHGDHAKLCB);
		}
		if (ELLELJFGDPH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ELLELJFGDPH);
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
		if (KHDLMPAKEGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHDLMPAKEGF);
		}
		if (pIHGDHAKLCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PIHGDHAKLCB);
		}
		if (ELLELJFGDPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ELLELJFGDPH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JOJLACDBPNA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KHDLMPAKEGF != 0)
		{
			KHDLMPAKEGF = other.KHDLMPAKEGF;
		}
		if (other.pIHGDHAKLCB_ != null)
		{
			if (pIHGDHAKLCB_ == null)
			{
				PIHGDHAKLCB = new BBHPOJJLFEC();
			}
			PIHGDHAKLCB.MergeFrom(other.PIHGDHAKLCB);
		}
		if (other.ELLELJFGDPH != 0)
		{
			ELLELJFGDPH = other.ELLELJFGDPH;
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
			case 8u:
				KHDLMPAKEGF = input.ReadUInt32();
				break;
			case 26u:
				if (pIHGDHAKLCB_ == null)
				{
					PIHGDHAKLCB = new BBHPOJJLFEC();
				}
				input.ReadMessage(PIHGDHAKLCB);
				break;
			case 96u:
				ELLELJFGDPH = input.ReadUInt32();
				break;
			}
		}
	}
}
