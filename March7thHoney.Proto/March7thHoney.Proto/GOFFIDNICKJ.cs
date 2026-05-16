using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GOFFIDNICKJ : IMessage<GOFFIDNICKJ>, IMessage, IEquatable<GOFFIDNICKJ>, IDeepCloneable<GOFFIDNICKJ>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		GJCJHPEKODC = 1,
		BLALLLNKHAC = 2,
		FCAPBPHLNCJ = 3,
		JNKMJMABPMP = 9
	}

	private static readonly MessageParser<GOFFIDNICKJ> _parser = new MessageParser<GOFFIDNICKJ>(() => new GOFFIDNICKJ());

	private UnknownFieldSet _unknownFields;

	public const int GJCJHPEKODCFieldNumber = 1;

	public const int BLALLLNKHACFieldNumber = 2;

	public const int FCAPBPHLNCJFieldNumber = 3;

	public const int JNKMJMABPMPFieldNumber = 9;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GOFFIDNICKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GOFFIDNICKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIILIJHFHCK GJCJHPEKODC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GJCJHPEKODC)
			{
				return null;
			}
			return (PIILIJHFHCK)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GJCJHPEKODC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFIKPFBPOMF BLALLLNKHAC
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BLALLLNKHAC)
			{
				return null;
			}
			return (NFIKPFBPOMF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BLALLLNKHAC : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFHNCFDGCLG FCAPBPHLNCJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FCAPBPHLNCJ)
			{
				return null;
			}
			return (BFHNCFDGCLG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FCAPBPHLNCJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHOEMCHFOFA JNKMJMABPMP
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JNKMJMABPMP)
			{
				return null;
			}
			return (LHOEMCHFOFA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JNKMJMABPMP : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFIDNICKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFIDNICKJ(GOFFIDNICKJ other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.GJCJHPEKODC:
			GJCJHPEKODC = other.GJCJHPEKODC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BLALLLNKHAC:
			BLALLLNKHAC = other.BLALLLNKHAC.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FCAPBPHLNCJ:
			FCAPBPHLNCJ = other.FCAPBPHLNCJ.Clone();
			break;
		case BPIHFAJCLOCOneofCase.JNKMJMABPMP:
			JNKMJMABPMP = other.JNKMJMABPMP.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOFFIDNICKJ Clone()
	{
		return new GOFFIDNICKJ(this);
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
		return Equals(other as GOFFIDNICKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GOFFIDNICKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GJCJHPEKODC, other.GJCJHPEKODC))
		{
			return false;
		}
		if (!object.Equals(BLALLLNKHAC, other.BLALLLNKHAC))
		{
			return false;
		}
		if (!object.Equals(FCAPBPHLNCJ, other.FCAPBPHLNCJ))
		{
			return false;
		}
		if (!object.Equals(JNKMJMABPMP, other.JNKMJMABPMP))
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJCJHPEKODC)
		{
			num ^= GJCJHPEKODC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLALLLNKHAC)
		{
			num ^= BLALLLNKHAC.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCAPBPHLNCJ)
		{
			num ^= FCAPBPHLNCJ.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKMJMABPMP)
		{
			num ^= JNKMJMABPMP.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJCJHPEKODC)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GJCJHPEKODC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLALLLNKHAC)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BLALLLNKHAC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCAPBPHLNCJ)
		{
			output.WriteRawTag(26);
			output.WriteMessage(FCAPBPHLNCJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKMJMABPMP)
		{
			output.WriteRawTag(74);
			output.WriteMessage(JNKMJMABPMP);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJCJHPEKODC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GJCJHPEKODC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLALLLNKHAC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BLALLLNKHAC);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCAPBPHLNCJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCAPBPHLNCJ);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKMJMABPMP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNKMJMABPMP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GOFFIDNICKJ other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.GJCJHPEKODC:
			if (GJCJHPEKODC == null)
			{
				GJCJHPEKODC = new PIILIJHFHCK();
			}
			GJCJHPEKODC.MergeFrom(other.GJCJHPEKODC);
			break;
		case BPIHFAJCLOCOneofCase.BLALLLNKHAC:
			if (BLALLLNKHAC == null)
			{
				BLALLLNKHAC = new NFIKPFBPOMF();
			}
			BLALLLNKHAC.MergeFrom(other.BLALLLNKHAC);
			break;
		case BPIHFAJCLOCOneofCase.FCAPBPHLNCJ:
			if (FCAPBPHLNCJ == null)
			{
				FCAPBPHLNCJ = new BFHNCFDGCLG();
			}
			FCAPBPHLNCJ.MergeFrom(other.FCAPBPHLNCJ);
			break;
		case BPIHFAJCLOCOneofCase.JNKMJMABPMP:
			if (JNKMJMABPMP == null)
			{
				JNKMJMABPMP = new LHOEMCHFOFA();
			}
			JNKMJMABPMP.MergeFrom(other.JNKMJMABPMP);
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
			case 10u:
			{
				PIILIJHFHCK pIILIJHFHCK = new PIILIJHFHCK();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GJCJHPEKODC)
				{
					pIILIJHFHCK.MergeFrom(GJCJHPEKODC);
				}
				input.ReadMessage(pIILIJHFHCK);
				GJCJHPEKODC = pIILIJHFHCK;
				break;
			}
			case 18u:
			{
				NFIKPFBPOMF nFIKPFBPOMF = new NFIKPFBPOMF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BLALLLNKHAC)
				{
					nFIKPFBPOMF.MergeFrom(BLALLLNKHAC);
				}
				input.ReadMessage(nFIKPFBPOMF);
				BLALLLNKHAC = nFIKPFBPOMF;
				break;
			}
			case 26u:
			{
				BFHNCFDGCLG bFHNCFDGCLG = new BFHNCFDGCLG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FCAPBPHLNCJ)
				{
					bFHNCFDGCLG.MergeFrom(FCAPBPHLNCJ);
				}
				input.ReadMessage(bFHNCFDGCLG);
				FCAPBPHLNCJ = bFHNCFDGCLG;
				break;
			}
			case 74u:
			{
				LHOEMCHFOFA lHOEMCHFOFA = new LHOEMCHFOFA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JNKMJMABPMP)
				{
					lHOEMCHFOFA.MergeFrom(JNKMJMABPMP);
				}
				input.ReadMessage(lHOEMCHFOFA);
				JNKMJMABPMP = lHOEMCHFOFA;
				break;
			}
			}
		}
	}
}
