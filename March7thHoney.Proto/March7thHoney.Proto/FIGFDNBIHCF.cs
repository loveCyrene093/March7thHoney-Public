using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIGFDNBIHCF : IMessage<FIGFDNBIHCF>, IMessage, IEquatable<FIGFDNBIHCF>, IDeepCloneable<FIGFDNBIHCF>, IBufferMessage
{
	private static readonly MessageParser<FIGFDNBIHCF> _parser = new MessageParser<FIGFDNBIHCF>(() => new FIGFDNBIHCF());

	private UnknownFieldSet _unknownFields;

	public const int HIOFNIHMFAMFieldNumber = 7;

	private uint hIOFNIHMFAM_;

	public const int PNDECPCKLHGFieldNumber = 9;

	private EFEGKDHEMFN pNDECPCKLHG_;

	public const int KLOBDDIJNHGFieldNumber = 10;

	private uint kLOBDDIJNHG_;

	public const int FJNLJOBOONHFieldNumber = 14;

	private uint fJNLJOBOONH_;

	public const int IDGJPGAIIBJFieldNumber = 15;

	private uint iDGJPGAIIBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIGFDNBIHCF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIGFDNBIHCFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HIOFNIHMFAM
	{
		get
		{
			return hIOFNIHMFAM_;
		}
		set
		{
			hIOFNIHMFAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN PNDECPCKLHG
	{
		get
		{
			return pNDECPCKLHG_;
		}
		set
		{
			pNDECPCKLHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLOBDDIJNHG
	{
		get
		{
			return kLOBDDIJNHG_;
		}
		set
		{
			kLOBDDIJNHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJNLJOBOONH
	{
		get
		{
			return fJNLJOBOONH_;
		}
		set
		{
			fJNLJOBOONH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IDGJPGAIIBJ
	{
		get
		{
			return iDGJPGAIIBJ_;
		}
		set
		{
			iDGJPGAIIBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGFDNBIHCF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGFDNBIHCF(FIGFDNBIHCF other)
		: this()
	{
		hIOFNIHMFAM_ = other.hIOFNIHMFAM_;
		pNDECPCKLHG_ = ((other.pNDECPCKLHG_ != null) ? other.pNDECPCKLHG_.Clone() : null);
		kLOBDDIJNHG_ = other.kLOBDDIJNHG_;
		fJNLJOBOONH_ = other.fJNLJOBOONH_;
		iDGJPGAIIBJ_ = other.iDGJPGAIIBJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGFDNBIHCF Clone()
	{
		return new FIGFDNBIHCF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIGFDNBIHCF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIGFDNBIHCF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HIOFNIHMFAM != other.HIOFNIHMFAM)
		{
			return false;
		}
		if (!object.Equals(PNDECPCKLHG, other.PNDECPCKLHG))
		{
			return false;
		}
		if (KLOBDDIJNHG != other.KLOBDDIJNHG)
		{
			return false;
		}
		if (FJNLJOBOONH != other.FJNLJOBOONH)
		{
			return false;
		}
		if (IDGJPGAIIBJ != other.IDGJPGAIIBJ)
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
		if (HIOFNIHMFAM != 0)
		{
			num ^= HIOFNIHMFAM.GetHashCode();
		}
		if (pNDECPCKLHG_ != null)
		{
			num ^= PNDECPCKLHG.GetHashCode();
		}
		if (KLOBDDIJNHG != 0)
		{
			num ^= KLOBDDIJNHG.GetHashCode();
		}
		if (FJNLJOBOONH != 0)
		{
			num ^= FJNLJOBOONH.GetHashCode();
		}
		if (IDGJPGAIIBJ != 0)
		{
			num ^= IDGJPGAIIBJ.GetHashCode();
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
		if (HIOFNIHMFAM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HIOFNIHMFAM);
		}
		if (pNDECPCKLHG_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PNDECPCKLHG);
		}
		if (KLOBDDIJNHG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KLOBDDIJNHG);
		}
		if (FJNLJOBOONH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FJNLJOBOONH);
		}
		if (IDGJPGAIIBJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IDGJPGAIIBJ);
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
		if (HIOFNIHMFAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HIOFNIHMFAM);
		}
		if (pNDECPCKLHG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PNDECPCKLHG);
		}
		if (KLOBDDIJNHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLOBDDIJNHG);
		}
		if (FJNLJOBOONH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJNLJOBOONH);
		}
		if (IDGJPGAIIBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IDGJPGAIIBJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIGFDNBIHCF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HIOFNIHMFAM != 0)
		{
			HIOFNIHMFAM = other.HIOFNIHMFAM;
		}
		if (other.pNDECPCKLHG_ != null)
		{
			if (pNDECPCKLHG_ == null)
			{
				PNDECPCKLHG = new EFEGKDHEMFN();
			}
			PNDECPCKLHG.MergeFrom(other.PNDECPCKLHG);
		}
		if (other.KLOBDDIJNHG != 0)
		{
			KLOBDDIJNHG = other.KLOBDDIJNHG;
		}
		if (other.FJNLJOBOONH != 0)
		{
			FJNLJOBOONH = other.FJNLJOBOONH;
		}
		if (other.IDGJPGAIIBJ != 0)
		{
			IDGJPGAIIBJ = other.IDGJPGAIIBJ;
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
			case 56u:
				HIOFNIHMFAM = input.ReadUInt32();
				break;
			case 74u:
				if (pNDECPCKLHG_ == null)
				{
					PNDECPCKLHG = new EFEGKDHEMFN();
				}
				input.ReadMessage(PNDECPCKLHG);
				break;
			case 80u:
				KLOBDDIJNHG = input.ReadUInt32();
				break;
			case 112u:
				FJNLJOBOONH = input.ReadUInt32();
				break;
			case 120u:
				IDGJPGAIIBJ = input.ReadUInt32();
				break;
			}
		}
	}
}
