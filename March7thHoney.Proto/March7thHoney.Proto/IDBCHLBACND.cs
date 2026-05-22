using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IDBCHLBACND : IMessage<IDBCHLBACND>, IMessage, IEquatable<IDBCHLBACND>, IDeepCloneable<IDBCHLBACND>, IBufferMessage
{
	private static readonly MessageParser<IDBCHLBACND> _parser = new MessageParser<IDBCHLBACND>(() => new IDBCHLBACND());

	private UnknownFieldSet _unknownFields;

	public const int BIPJEHIOEGNFieldNumber = 1;

	private uint bIPJEHIOEGN_;

	public const int BLBGFIGJBNDFieldNumber = 4;

	private uint bLBGFIGJBND_;

	public const int IGIKKGLMJEDFieldNumber = 8;

	private uint iGIKKGLMJED_;

	public const int FEBHLMNHFOCFieldNumber = 9;

	private uint fEBHLMNHFOC_;

	public const int MKHDOPGGBIEFieldNumber = 11;

	private bool mKHDOPGGBIE_;

	public const int PMICICPPDOPFieldNumber = 13;

	private uint pMICICPPDOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IDBCHLBACND> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IDBCHLBACNDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BIPJEHIOEGN
	{
		get
		{
			return bIPJEHIOEGN_;
		}
		set
		{
			bIPJEHIOEGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BLBGFIGJBND
	{
		get
		{
			return bLBGFIGJBND_;
		}
		set
		{
			bLBGFIGJBND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGIKKGLMJED
	{
		get
		{
			return iGIKKGLMJED_;
		}
		set
		{
			iGIKKGLMJED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FEBHLMNHFOC
	{
		get
		{
			return fEBHLMNHFOC_;
		}
		set
		{
			fEBHLMNHFOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MKHDOPGGBIE
	{
		get
		{
			return mKHDOPGGBIE_;
		}
		set
		{
			mKHDOPGGBIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMICICPPDOP
	{
		get
		{
			return pMICICPPDOP_;
		}
		set
		{
			pMICICPPDOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDBCHLBACND()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDBCHLBACND(IDBCHLBACND other)
		: this()
	{
		bIPJEHIOEGN_ = other.bIPJEHIOEGN_;
		bLBGFIGJBND_ = other.bLBGFIGJBND_;
		iGIKKGLMJED_ = other.iGIKKGLMJED_;
		fEBHLMNHFOC_ = other.fEBHLMNHFOC_;
		mKHDOPGGBIE_ = other.mKHDOPGGBIE_;
		pMICICPPDOP_ = other.pMICICPPDOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDBCHLBACND Clone()
	{
		return new IDBCHLBACND(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IDBCHLBACND);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IDBCHLBACND other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BIPJEHIOEGN != other.BIPJEHIOEGN)
		{
			return false;
		}
		if (BLBGFIGJBND != other.BLBGFIGJBND)
		{
			return false;
		}
		if (IGIKKGLMJED != other.IGIKKGLMJED)
		{
			return false;
		}
		if (FEBHLMNHFOC != other.FEBHLMNHFOC)
		{
			return false;
		}
		if (MKHDOPGGBIE != other.MKHDOPGGBIE)
		{
			return false;
		}
		if (PMICICPPDOP != other.PMICICPPDOP)
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
		if (BIPJEHIOEGN != 0)
		{
			num ^= BIPJEHIOEGN.GetHashCode();
		}
		if (BLBGFIGJBND != 0)
		{
			num ^= BLBGFIGJBND.GetHashCode();
		}
		if (IGIKKGLMJED != 0)
		{
			num ^= IGIKKGLMJED.GetHashCode();
		}
		if (FEBHLMNHFOC != 0)
		{
			num ^= FEBHLMNHFOC.GetHashCode();
		}
		if (MKHDOPGGBIE)
		{
			num ^= MKHDOPGGBIE.GetHashCode();
		}
		if (PMICICPPDOP != 0)
		{
			num ^= PMICICPPDOP.GetHashCode();
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
		if (BIPJEHIOEGN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BIPJEHIOEGN);
		}
		if (BLBGFIGJBND != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BLBGFIGJBND);
		}
		if (IGIKKGLMJED != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(IGIKKGLMJED);
		}
		if (FEBHLMNHFOC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FEBHLMNHFOC);
		}
		if (MKHDOPGGBIE)
		{
			output.WriteRawTag(88);
			output.WriteBool(MKHDOPGGBIE);
		}
		if (PMICICPPDOP != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PMICICPPDOP);
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
		if (BIPJEHIOEGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BIPJEHIOEGN);
		}
		if (BLBGFIGJBND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BLBGFIGJBND);
		}
		if (IGIKKGLMJED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGIKKGLMJED);
		}
		if (FEBHLMNHFOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FEBHLMNHFOC);
		}
		if (MKHDOPGGBIE)
		{
			num += 2;
		}
		if (PMICICPPDOP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMICICPPDOP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IDBCHLBACND other)
	{
		if (other != null)
		{
			if (other.BIPJEHIOEGN != 0)
			{
				BIPJEHIOEGN = other.BIPJEHIOEGN;
			}
			if (other.BLBGFIGJBND != 0)
			{
				BLBGFIGJBND = other.BLBGFIGJBND;
			}
			if (other.IGIKKGLMJED != 0)
			{
				IGIKKGLMJED = other.IGIKKGLMJED;
			}
			if (other.FEBHLMNHFOC != 0)
			{
				FEBHLMNHFOC = other.FEBHLMNHFOC;
			}
			if (other.MKHDOPGGBIE)
			{
				MKHDOPGGBIE = other.MKHDOPGGBIE;
			}
			if (other.PMICICPPDOP != 0)
			{
				PMICICPPDOP = other.PMICICPPDOP;
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
				BIPJEHIOEGN = input.ReadUInt32();
				break;
			case 32u:
				BLBGFIGJBND = input.ReadUInt32();
				break;
			case 64u:
				IGIKKGLMJED = input.ReadUInt32();
				break;
			case 72u:
				FEBHLMNHFOC = input.ReadUInt32();
				break;
			case 88u:
				MKHDOPGGBIE = input.ReadBool();
				break;
			case 104u:
				PMICICPPDOP = input.ReadUInt32();
				break;
			}
		}
	}
}
