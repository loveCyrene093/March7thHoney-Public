using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CJPFNAFLAPD : IMessage<CJPFNAFLAPD>, IMessage, IEquatable<CJPFNAFLAPD>, IDeepCloneable<CJPFNAFLAPD>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		DLDDJKBNLIM = 11,
		NHNHLNMJKLA = 12
	}

	private static readonly MessageParser<CJPFNAFLAPD> _parser = new MessageParser<CJPFNAFLAPD>(() => new CJPFNAFLAPD());

	private UnknownFieldSet _unknownFields;

	public const int BCJMOEMDGJKFieldNumber = 411;

	private uint bCJMOEMDGJK_;

	public const int DLDDJKBNLIMFieldNumber = 11;

	public const int NHNHLNMJKLAFieldNumber = 12;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CJPFNAFLAPD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CJPFNAFLAPDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCJMOEMDGJK
	{
		get
		{
			return bCJMOEMDGJK_;
		}
		set
		{
			bCJMOEMDGJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDBLKOGKHEE DLDDJKBNLIM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.DLDDJKBNLIM)
			{
				return null;
			}
			return (KDBLKOGKHEE)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.DLDDJKBNLIM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIGGMLEFJNI NHNHLNMJKLA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.NHNHLNMJKLA)
			{
				return null;
			}
			return (HIGGMLEFJNI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.NHNHLNMJKLA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJPFNAFLAPD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJPFNAFLAPD(CJPFNAFLAPD other)
		: this()
	{
		bCJMOEMDGJK_ = other.bCJMOEMDGJK_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.DLDDJKBNLIM:
			DLDDJKBNLIM = other.DLDDJKBNLIM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.NHNHLNMJKLA:
			NHNHLNMJKLA = other.NHNHLNMJKLA.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJPFNAFLAPD Clone()
	{
		return new CJPFNAFLAPD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CJPFNAFLAPD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CJPFNAFLAPD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BCJMOEMDGJK != other.BCJMOEMDGJK)
		{
			return false;
		}
		if (!object.Equals(DLDDJKBNLIM, other.DLDDJKBNLIM))
		{
			return false;
		}
		if (!object.Equals(NHNHLNMJKLA, other.NHNHLNMJKLA))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (BCJMOEMDGJK != 0)
		{
			num ^= BCJMOEMDGJK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DLDDJKBNLIM)
		{
			num ^= DLDDJKBNLIM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHNHLNMJKLA)
		{
			num ^= NHNHLNMJKLA.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DLDDJKBNLIM)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DLDDJKBNLIM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHNHLNMJKLA)
		{
			output.WriteRawTag(98);
			output.WriteMessage(NHNHLNMJKLA);
		}
		if (BCJMOEMDGJK != 0)
		{
			output.WriteRawTag(216, 25);
			output.WriteUInt32(BCJMOEMDGJK);
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
		if (BCJMOEMDGJK != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(BCJMOEMDGJK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DLDDJKBNLIM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DLDDJKBNLIM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHNHLNMJKLA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NHNHLNMJKLA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CJPFNAFLAPD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BCJMOEMDGJK != 0)
		{
			BCJMOEMDGJK = other.BCJMOEMDGJK;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.DLDDJKBNLIM:
			if (DLDDJKBNLIM == null)
			{
				DLDDJKBNLIM = new KDBLKOGKHEE();
			}
			DLDDJKBNLIM.MergeFrom(other.DLDDJKBNLIM);
			break;
		case BPIHFAJCLOCOneofCase.NHNHLNMJKLA:
			if (NHNHLNMJKLA == null)
			{
				NHNHLNMJKLA = new HIGGMLEFJNI();
			}
			NHNHLNMJKLA.MergeFrom(other.NHNHLNMJKLA);
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
			case 90u:
			{
				KDBLKOGKHEE kDBLKOGKHEE = new KDBLKOGKHEE();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DLDDJKBNLIM)
				{
					kDBLKOGKHEE.MergeFrom(DLDDJKBNLIM);
				}
				input.ReadMessage(kDBLKOGKHEE);
				DLDDJKBNLIM = kDBLKOGKHEE;
				break;
			}
			case 98u:
			{
				HIGGMLEFJNI hIGGMLEFJNI = new HIGGMLEFJNI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.NHNHLNMJKLA)
				{
					hIGGMLEFJNI.MergeFrom(NHNHLNMJKLA);
				}
				input.ReadMessage(hIGGMLEFJNI);
				NHNHLNMJKLA = hIGGMLEFJNI;
				break;
			}
			case 3288u:
				BCJMOEMDGJK = input.ReadUInt32();
				break;
			}
		}
	}
}
