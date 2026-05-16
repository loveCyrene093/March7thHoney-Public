using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherDivideSpiritExpUpCsReq : IMessage<AetherDivideSpiritExpUpCsReq>, IMessage, IEquatable<AetherDivideSpiritExpUpCsReq>, IDeepCloneable<AetherDivideSpiritExpUpCsReq>, IBufferMessage
{
	private static readonly MessageParser<AetherDivideSpiritExpUpCsReq> _parser = new MessageParser<AetherDivideSpiritExpUpCsReq>(() => new AetherDivideSpiritExpUpCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NOEHMENEMLLFieldNumber = 4;

	private uint nOEHMENEMLL_;

	public const int FIKLLOCJBGNFieldNumber = 11;

	private uint fIKLLOCJBGN_;

	public const int IMMHJMDHDGCFieldNumber = 13;

	private uint iMMHJMDHDGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherDivideSpiritExpUpCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherDivideSpiritExpUpCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOEHMENEMLL
	{
		get
		{
			return nOEHMENEMLL_;
		}
		set
		{
			nOEHMENEMLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIKLLOCJBGN
	{
		get
		{
			return fIKLLOCJBGN_;
		}
		set
		{
			fIKLLOCJBGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMMHJMDHDGC
	{
		get
		{
			return iMMHJMDHDGC_;
		}
		set
		{
			iMMHJMDHDGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritExpUpCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritExpUpCsReq(AetherDivideSpiritExpUpCsReq other)
		: this()
	{
		nOEHMENEMLL_ = other.nOEHMENEMLL_;
		fIKLLOCJBGN_ = other.fIKLLOCJBGN_;
		iMMHJMDHDGC_ = other.iMMHJMDHDGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritExpUpCsReq Clone()
	{
		return new AetherDivideSpiritExpUpCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherDivideSpiritExpUpCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherDivideSpiritExpUpCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NOEHMENEMLL != other.NOEHMENEMLL)
		{
			return false;
		}
		if (FIKLLOCJBGN != other.FIKLLOCJBGN)
		{
			return false;
		}
		if (IMMHJMDHDGC != other.IMMHJMDHDGC)
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
		if (NOEHMENEMLL != 0)
		{
			num ^= NOEHMENEMLL.GetHashCode();
		}
		if (FIKLLOCJBGN != 0)
		{
			num ^= FIKLLOCJBGN.GetHashCode();
		}
		if (IMMHJMDHDGC != 0)
		{
			num ^= IMMHJMDHDGC.GetHashCode();
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
		if (NOEHMENEMLL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NOEHMENEMLL);
		}
		if (FIKLLOCJBGN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FIKLLOCJBGN);
		}
		if (IMMHJMDHDGC != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IMMHJMDHDGC);
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
		if (NOEHMENEMLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOEHMENEMLL);
		}
		if (FIKLLOCJBGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIKLLOCJBGN);
		}
		if (IMMHJMDHDGC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMMHJMDHDGC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AetherDivideSpiritExpUpCsReq other)
	{
		if (other != null)
		{
			if (other.NOEHMENEMLL != 0)
			{
				NOEHMENEMLL = other.NOEHMENEMLL;
			}
			if (other.FIKLLOCJBGN != 0)
			{
				FIKLLOCJBGN = other.FIKLLOCJBGN;
			}
			if (other.IMMHJMDHDGC != 0)
			{
				IMMHJMDHDGC = other.IMMHJMDHDGC;
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
			case 32u:
				NOEHMENEMLL = input.ReadUInt32();
				break;
			case 88u:
				FIKLLOCJBGN = input.ReadUInt32();
				break;
			case 104u:
				IMMHJMDHDGC = input.ReadUInt32();
				break;
			}
		}
	}
}
