using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIBAKJGOPJM : IMessage<JIBAKJGOPJM>, IMessage, IEquatable<JIBAKJGOPJM>, IDeepCloneable<JIBAKJGOPJM>, IBufferMessage
{
	private static readonly MessageParser<JIBAKJGOPJM> _parser = new MessageParser<JIBAKJGOPJM>(() => new JIBAKJGOPJM());

	private UnknownFieldSet _unknownFields;

	public const int BPJAFBFFPPHFieldNumber = 7;

	private uint bPJAFBFFPPH_;

	public const int IIGMOIGOELBFieldNumber = 15;

	private uint iIGMOIGOELB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIBAKJGOPJM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIBAKJGOPJMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BPJAFBFFPPH
	{
		get
		{
			return bPJAFBFFPPH_;
		}
		set
		{
			bPJAFBFFPPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIGMOIGOELB
	{
		get
		{
			return iIGMOIGOELB_;
		}
		set
		{
			iIGMOIGOELB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBAKJGOPJM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBAKJGOPJM(JIBAKJGOPJM other)
		: this()
	{
		bPJAFBFFPPH_ = other.bPJAFBFFPPH_;
		iIGMOIGOELB_ = other.iIGMOIGOELB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBAKJGOPJM Clone()
	{
		return new JIBAKJGOPJM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIBAKJGOPJM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIBAKJGOPJM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BPJAFBFFPPH != other.BPJAFBFFPPH)
		{
			return false;
		}
		if (IIGMOIGOELB != other.IIGMOIGOELB)
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
		if (BPJAFBFFPPH != 0)
		{
			num ^= BPJAFBFFPPH.GetHashCode();
		}
		if (IIGMOIGOELB != 0)
		{
			num ^= IIGMOIGOELB.GetHashCode();
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
		if (BPJAFBFFPPH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BPJAFBFFPPH);
		}
		if (IIGMOIGOELB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IIGMOIGOELB);
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
		if (BPJAFBFFPPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BPJAFBFFPPH);
		}
		if (IIGMOIGOELB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIGMOIGOELB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JIBAKJGOPJM other)
	{
		if (other != null)
		{
			if (other.BPJAFBFFPPH != 0)
			{
				BPJAFBFFPPH = other.BPJAFBFFPPH;
			}
			if (other.IIGMOIGOELB != 0)
			{
				IIGMOIGOELB = other.IIGMOIGOELB;
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
			case 56u:
				BPJAFBFFPPH = input.ReadUInt32();
				break;
			case 120u:
				IIGMOIGOELB = input.ReadUInt32();
				break;
			}
		}
	}
}
