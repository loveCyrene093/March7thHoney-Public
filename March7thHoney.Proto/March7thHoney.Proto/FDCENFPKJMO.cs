using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FDCENFPKJMO : IMessage<FDCENFPKJMO>, IMessage, IEquatable<FDCENFPKJMO>, IDeepCloneable<FDCENFPKJMO>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		DOOBFDLPMNB = 2,
		DPAFELPDGIN = 5,
		OMKBLLOAJPO = 10,
		NGDDLKDLLAL = 13,
		PPIFOCGJDMD = 14
	}

	private static readonly MessageParser<FDCENFPKJMO> _parser = new MessageParser<FDCENFPKJMO>(() => new FDCENFPKJMO());

	private UnknownFieldSet _unknownFields;

	public const int DOOBFDLPMNBFieldNumber = 2;

	public const int DPAFELPDGINFieldNumber = 5;

	public const int OMKBLLOAJPOFieldNumber = 10;

	public const int NGDDLKDLLALFieldNumber = 13;

	public const int PPIFOCGJDMDFieldNumber = 14;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FDCENFPKJMO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FDCENFPKJMOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMCBEJOFCGI DOOBFDLPMNB
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.DOOBFDLPMNB)
			{
				return null;
			}
			return (LMCBEJOFCGI)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.DOOBFDLPMNB : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHIPNHAPDFJ DPAFELPDGIN
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.DPAFELPDGIN)
			{
				return null;
			}
			return (BHIPNHAPDFJ)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.DPAFELPDGIN : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEADICKBGGF OMKBLLOAJPO
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.OMKBLLOAJPO)
			{
				return null;
			}
			return (FEADICKBGGF)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.OMKBLLOAJPO : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCODKMAJFDG NGDDLKDLLAL
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.NGDDLKDLLAL)
			{
				return null;
			}
			return (MCODKMAJFDG)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.NGDDLKDLLAL : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFDFJFABJPL PPIFOCGJDMD
	{
		get
		{
			if (nLPPPCHGGPFCase_ != NLPPPCHGGPFOneofCase.PPIFOCGJDMD)
			{
				return null;
			}
			return (MFDFJFABJPL)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = ((value != null) ? NLPPPCHGGPFOneofCase.PPIFOCGJDMD : NLPPPCHGGPFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDCENFPKJMO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDCENFPKJMO(FDCENFPKJMO other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.DOOBFDLPMNB:
			DOOBFDLPMNB = other.DOOBFDLPMNB.Clone();
			break;
		case NLPPPCHGGPFOneofCase.DPAFELPDGIN:
			DPAFELPDGIN = other.DPAFELPDGIN.Clone();
			break;
		case NLPPPCHGGPFOneofCase.OMKBLLOAJPO:
			OMKBLLOAJPO = other.OMKBLLOAJPO.Clone();
			break;
		case NLPPPCHGGPFOneofCase.NGDDLKDLLAL:
			NGDDLKDLLAL = other.NGDDLKDLLAL.Clone();
			break;
		case NLPPPCHGGPFOneofCase.PPIFOCGJDMD:
			PPIFOCGJDMD = other.PPIFOCGJDMD.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDCENFPKJMO Clone()
	{
		return new FDCENFPKJMO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FDCENFPKJMO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FDCENFPKJMO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DOOBFDLPMNB, other.DOOBFDLPMNB))
		{
			return false;
		}
		if (!object.Equals(DPAFELPDGIN, other.DPAFELPDGIN))
		{
			return false;
		}
		if (!object.Equals(OMKBLLOAJPO, other.OMKBLLOAJPO))
		{
			return false;
		}
		if (!object.Equals(NGDDLKDLLAL, other.NGDDLKDLLAL))
		{
			return false;
		}
		if (!object.Equals(PPIFOCGJDMD, other.PPIFOCGJDMD))
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOOBFDLPMNB)
		{
			num ^= DOOBFDLPMNB.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DPAFELPDGIN)
		{
			num ^= DPAFELPDGIN.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.OMKBLLOAJPO)
		{
			num ^= OMKBLLOAJPO.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGDDLKDLLAL)
		{
			num ^= NGDDLKDLLAL.GetHashCode();
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPIFOCGJDMD)
		{
			num ^= PPIFOCGJDMD.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOOBFDLPMNB)
		{
			output.WriteRawTag(18);
			output.WriteMessage(DOOBFDLPMNB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DPAFELPDGIN)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DPAFELPDGIN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.OMKBLLOAJPO)
		{
			output.WriteRawTag(82);
			output.WriteMessage(OMKBLLOAJPO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGDDLKDLLAL)
		{
			output.WriteRawTag(106);
			output.WriteMessage(NGDDLKDLLAL);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPIFOCGJDMD)
		{
			output.WriteRawTag(114);
			output.WriteMessage(PPIFOCGJDMD);
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
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOOBFDLPMNB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DOOBFDLPMNB);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DPAFELPDGIN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DPAFELPDGIN);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.OMKBLLOAJPO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OMKBLLOAJPO);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGDDLKDLLAL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NGDDLKDLLAL);
		}
		if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPIFOCGJDMD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPIFOCGJDMD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FDCENFPKJMO other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.DOOBFDLPMNB:
			if (DOOBFDLPMNB == null)
			{
				DOOBFDLPMNB = new LMCBEJOFCGI();
			}
			DOOBFDLPMNB.MergeFrom(other.DOOBFDLPMNB);
			break;
		case NLPPPCHGGPFOneofCase.DPAFELPDGIN:
			if (DPAFELPDGIN == null)
			{
				DPAFELPDGIN = new BHIPNHAPDFJ();
			}
			DPAFELPDGIN.MergeFrom(other.DPAFELPDGIN);
			break;
		case NLPPPCHGGPFOneofCase.OMKBLLOAJPO:
			if (OMKBLLOAJPO == null)
			{
				OMKBLLOAJPO = new FEADICKBGGF();
			}
			OMKBLLOAJPO.MergeFrom(other.OMKBLLOAJPO);
			break;
		case NLPPPCHGGPFOneofCase.NGDDLKDLLAL:
			if (NGDDLKDLLAL == null)
			{
				NGDDLKDLLAL = new MCODKMAJFDG();
			}
			NGDDLKDLLAL.MergeFrom(other.NGDDLKDLLAL);
			break;
		case NLPPPCHGGPFOneofCase.PPIFOCGJDMD:
			if (PPIFOCGJDMD == null)
			{
				PPIFOCGJDMD = new MFDFJFABJPL();
			}
			PPIFOCGJDMD.MergeFrom(other.PPIFOCGJDMD);
			break;
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
			case 18u:
			{
				LMCBEJOFCGI lMCBEJOFCGI = new LMCBEJOFCGI();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DOOBFDLPMNB)
				{
					lMCBEJOFCGI.MergeFrom(DOOBFDLPMNB);
				}
				input.ReadMessage(lMCBEJOFCGI);
				DOOBFDLPMNB = lMCBEJOFCGI;
				break;
			}
			case 42u:
			{
				BHIPNHAPDFJ bHIPNHAPDFJ = new BHIPNHAPDFJ();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.DPAFELPDGIN)
				{
					bHIPNHAPDFJ.MergeFrom(DPAFELPDGIN);
				}
				input.ReadMessage(bHIPNHAPDFJ);
				DPAFELPDGIN = bHIPNHAPDFJ;
				break;
			}
			case 82u:
			{
				FEADICKBGGF fEADICKBGGF = new FEADICKBGGF();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.OMKBLLOAJPO)
				{
					fEADICKBGGF.MergeFrom(OMKBLLOAJPO);
				}
				input.ReadMessage(fEADICKBGGF);
				OMKBLLOAJPO = fEADICKBGGF;
				break;
			}
			case 106u:
			{
				MCODKMAJFDG mCODKMAJFDG = new MCODKMAJFDG();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.NGDDLKDLLAL)
				{
					mCODKMAJFDG.MergeFrom(NGDDLKDLLAL);
				}
				input.ReadMessage(mCODKMAJFDG);
				NGDDLKDLLAL = mCODKMAJFDG;
				break;
			}
			case 114u:
			{
				MFDFJFABJPL mFDFJFABJPL = new MFDFJFABJPL();
				if (nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.PPIFOCGJDMD)
				{
					mFDFJFABJPL.MergeFrom(PPIFOCGJDMD);
				}
				input.ReadMessage(mFDFJFABJPL);
				PPIFOCGJDMD = mFDFJFABJPL;
				break;
			}
			}
		}
	}
}
