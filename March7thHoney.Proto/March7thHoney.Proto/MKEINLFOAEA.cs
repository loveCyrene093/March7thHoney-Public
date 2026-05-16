using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MKEINLFOAEA : IMessage<MKEINLFOAEA>, IMessage, IEquatable<MKEINLFOAEA>, IDeepCloneable<MKEINLFOAEA>, IBufferMessage
{
	private static readonly MessageParser<MKEINLFOAEA> _parser = new MessageParser<MKEINLFOAEA>(() => new MKEINLFOAEA());

	private UnknownFieldSet _unknownFields;

	public const int CMHMNEEFCLCFieldNumber = 1;

	private uint cMHMNEEFCLC_;

	public const int BHFOOBPKIANFieldNumber = 2;

	private uint bHFOOBPKIAN_;

	public const int MLLDHEAKDJCFieldNumber = 3;

	private uint mLLDHEAKDJC_;

	public const int HJMLKDNIIFPFieldNumber = 4;

	private uint hJMLKDNIIFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MKEINLFOAEA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MKEINLFOAEAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CMHMNEEFCLC
	{
		get
		{
			return cMHMNEEFCLC_;
		}
		set
		{
			cMHMNEEFCLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHFOOBPKIAN
	{
		get
		{
			return bHFOOBPKIAN_;
		}
		set
		{
			bHFOOBPKIAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLLDHEAKDJC
	{
		get
		{
			return mLLDHEAKDJC_;
		}
		set
		{
			mLLDHEAKDJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMLKDNIIFP
	{
		get
		{
			return hJMLKDNIIFP_;
		}
		set
		{
			hJMLKDNIIFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA(MKEINLFOAEA other)
		: this()
	{
		cMHMNEEFCLC_ = other.cMHMNEEFCLC_;
		bHFOOBPKIAN_ = other.bHFOOBPKIAN_;
		mLLDHEAKDJC_ = other.mLLDHEAKDJC_;
		hJMLKDNIIFP_ = other.hJMLKDNIIFP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA Clone()
	{
		return new MKEINLFOAEA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MKEINLFOAEA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MKEINLFOAEA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CMHMNEEFCLC != other.CMHMNEEFCLC)
		{
			return false;
		}
		if (BHFOOBPKIAN != other.BHFOOBPKIAN)
		{
			return false;
		}
		if (MLLDHEAKDJC != other.MLLDHEAKDJC)
		{
			return false;
		}
		if (HJMLKDNIIFP != other.HJMLKDNIIFP)
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
		if (CMHMNEEFCLC != 0)
		{
			num ^= CMHMNEEFCLC.GetHashCode();
		}
		if (BHFOOBPKIAN != 0)
		{
			num ^= BHFOOBPKIAN.GetHashCode();
		}
		if (MLLDHEAKDJC != 0)
		{
			num ^= MLLDHEAKDJC.GetHashCode();
		}
		if (HJMLKDNIIFP != 0)
		{
			num ^= HJMLKDNIIFP.GetHashCode();
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
		if (CMHMNEEFCLC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CMHMNEEFCLC);
		}
		if (BHFOOBPKIAN != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BHFOOBPKIAN);
		}
		if (MLLDHEAKDJC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MLLDHEAKDJC);
		}
		if (HJMLKDNIIFP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HJMLKDNIIFP);
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
		if (CMHMNEEFCLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CMHMNEEFCLC);
		}
		if (BHFOOBPKIAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHFOOBPKIAN);
		}
		if (MLLDHEAKDJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLLDHEAKDJC);
		}
		if (HJMLKDNIIFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMLKDNIIFP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MKEINLFOAEA other)
	{
		if (other != null)
		{
			if (other.CMHMNEEFCLC != 0)
			{
				CMHMNEEFCLC = other.CMHMNEEFCLC;
			}
			if (other.BHFOOBPKIAN != 0)
			{
				BHFOOBPKIAN = other.BHFOOBPKIAN;
			}
			if (other.MLLDHEAKDJC != 0)
			{
				MLLDHEAKDJC = other.MLLDHEAKDJC;
			}
			if (other.HJMLKDNIIFP != 0)
			{
				HJMLKDNIIFP = other.HJMLKDNIIFP;
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
				CMHMNEEFCLC = input.ReadUInt32();
				break;
			case 16u:
				BHFOOBPKIAN = input.ReadUInt32();
				break;
			case 24u:
				MLLDHEAKDJC = input.ReadUInt32();
				break;
			case 32u:
				HJMLKDNIIFP = input.ReadUInt32();
				break;
			}
		}
	}
}
