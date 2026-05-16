using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGetDailyInitItemScRsp : IMessage<MonopolyGetDailyInitItemScRsp>, IMessage, IEquatable<MonopolyGetDailyInitItemScRsp>, IDeepCloneable<MonopolyGetDailyInitItemScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGetDailyInitItemScRsp> _parser = new MessageParser<MonopolyGetDailyInitItemScRsp>(() => new MonopolyGetDailyInitItemScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JBONHGNNCLEFieldNumber = 3;

	private uint jBONHGNNCLE_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int CPFBCBKFLFMFieldNumber = 6;

	private uint cPFBCBKFLFM_;

	public const int JEHGFEJCIFFFieldNumber = 7;

	private uint jEHGFEJCIFF_;

	public const int CILPIJNOIAGFieldNumber = 11;

	private long cILPIJNOIAG_;

	public const int EOAAJMDCHIDFieldNumber = 12;

	private uint eOAAJMDCHID_;

	public const int FJBDCNAKIFMFieldNumber = 13;

	private uint fJBDCNAKIFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGetDailyInitItemScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGetDailyInitItemScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBONHGNNCLE
	{
		get
		{
			return jBONHGNNCLE_;
		}
		set
		{
			jBONHGNNCLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPFBCBKFLFM
	{
		get
		{
			return cPFBCBKFLFM_;
		}
		set
		{
			cPFBCBKFLFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JEHGFEJCIFF
	{
		get
		{
			return jEHGFEJCIFF_;
		}
		set
		{
			jEHGFEJCIFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CILPIJNOIAG
	{
		get
		{
			return cILPIJNOIAG_;
		}
		set
		{
			cILPIJNOIAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EOAAJMDCHID
	{
		get
		{
			return eOAAJMDCHID_;
		}
		set
		{
			eOAAJMDCHID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJBDCNAKIFM
	{
		get
		{
			return fJBDCNAKIFM_;
		}
		set
		{
			fJBDCNAKIFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetDailyInitItemScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetDailyInitItemScRsp(MonopolyGetDailyInitItemScRsp other)
		: this()
	{
		jBONHGNNCLE_ = other.jBONHGNNCLE_;
		retcode_ = other.retcode_;
		cPFBCBKFLFM_ = other.cPFBCBKFLFM_;
		jEHGFEJCIFF_ = other.jEHGFEJCIFF_;
		cILPIJNOIAG_ = other.cILPIJNOIAG_;
		eOAAJMDCHID_ = other.eOAAJMDCHID_;
		fJBDCNAKIFM_ = other.fJBDCNAKIFM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetDailyInitItemScRsp Clone()
	{
		return new MonopolyGetDailyInitItemScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGetDailyInitItemScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGetDailyInitItemScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JBONHGNNCLE != other.JBONHGNNCLE)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CPFBCBKFLFM != other.CPFBCBKFLFM)
		{
			return false;
		}
		if (JEHGFEJCIFF != other.JEHGFEJCIFF)
		{
			return false;
		}
		if (CILPIJNOIAG != other.CILPIJNOIAG)
		{
			return false;
		}
		if (EOAAJMDCHID != other.EOAAJMDCHID)
		{
			return false;
		}
		if (FJBDCNAKIFM != other.FJBDCNAKIFM)
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
		if (JBONHGNNCLE != 0)
		{
			num ^= JBONHGNNCLE.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CPFBCBKFLFM != 0)
		{
			num ^= CPFBCBKFLFM.GetHashCode();
		}
		if (JEHGFEJCIFF != 0)
		{
			num ^= JEHGFEJCIFF.GetHashCode();
		}
		if (CILPIJNOIAG != 0L)
		{
			num ^= CILPIJNOIAG.GetHashCode();
		}
		if (EOAAJMDCHID != 0)
		{
			num ^= EOAAJMDCHID.GetHashCode();
		}
		if (FJBDCNAKIFM != 0)
		{
			num ^= FJBDCNAKIFM.GetHashCode();
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
		if (JBONHGNNCLE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JBONHGNNCLE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (CPFBCBKFLFM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CPFBCBKFLFM);
		}
		if (JEHGFEJCIFF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JEHGFEJCIFF);
		}
		if (CILPIJNOIAG != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(CILPIJNOIAG);
		}
		if (EOAAJMDCHID != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EOAAJMDCHID);
		}
		if (FJBDCNAKIFM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FJBDCNAKIFM);
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
		if (JBONHGNNCLE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBONHGNNCLE);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CPFBCBKFLFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPFBCBKFLFM);
		}
		if (JEHGFEJCIFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JEHGFEJCIFF);
		}
		if (CILPIJNOIAG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CILPIJNOIAG);
		}
		if (EOAAJMDCHID != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EOAAJMDCHID);
		}
		if (FJBDCNAKIFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJBDCNAKIFM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGetDailyInitItemScRsp other)
	{
		if (other != null)
		{
			if (other.JBONHGNNCLE != 0)
			{
				JBONHGNNCLE = other.JBONHGNNCLE;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CPFBCBKFLFM != 0)
			{
				CPFBCBKFLFM = other.CPFBCBKFLFM;
			}
			if (other.JEHGFEJCIFF != 0)
			{
				JEHGFEJCIFF = other.JEHGFEJCIFF;
			}
			if (other.CILPIJNOIAG != 0L)
			{
				CILPIJNOIAG = other.CILPIJNOIAG;
			}
			if (other.EOAAJMDCHID != 0)
			{
				EOAAJMDCHID = other.EOAAJMDCHID;
			}
			if (other.FJBDCNAKIFM != 0)
			{
				FJBDCNAKIFM = other.FJBDCNAKIFM;
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
			case 24u:
				JBONHGNNCLE = input.ReadUInt32();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 48u:
				CPFBCBKFLFM = input.ReadUInt32();
				break;
			case 56u:
				JEHGFEJCIFF = input.ReadUInt32();
				break;
			case 88u:
				CILPIJNOIAG = input.ReadInt64();
				break;
			case 96u:
				EOAAJMDCHID = input.ReadUInt32();
				break;
			case 104u:
				FJBDCNAKIFM = input.ReadUInt32();
				break;
			}
		}
	}
}
