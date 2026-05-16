using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGKBEBCCDGF : IMessage<CGKBEBCCDGF>, IMessage, IEquatable<CGKBEBCCDGF>, IDeepCloneable<CGKBEBCCDGF>, IBufferMessage
{
	public enum LBEBNKMENPNOneofCase
	{
		None = 0,
		FHCPKOMPCDH = 1,
		MAECOFLEAGD = 2,
		NHHFADEBELO = 3,
		MBKDAFJCHAC = 4,
		JGNAJOFIKEJ = 6,
		EIENKJFFFJG = 8,
		LLNNPGEOFCD = 10,
		APBBENFPNLL = 12,
		HBMPBIOLCGD = 13,
		AJAIDIBLMAO = 14,
		NJMKOPKJCGC = 15
	}

	private static readonly MessageParser<CGKBEBCCDGF> _parser = new MessageParser<CGKBEBCCDGF>(() => new CGKBEBCCDGF());

	private UnknownFieldSet _unknownFields;

	public const int FHCPKOMPCDHFieldNumber = 1;

	public const int MAECOFLEAGDFieldNumber = 2;

	public const int NHHFADEBELOFieldNumber = 3;

	public const int MBKDAFJCHACFieldNumber = 4;

	public const int JGNAJOFIKEJFieldNumber = 6;

	public const int EIENKJFFFJGFieldNumber = 8;

	public const int LLNNPGEOFCDFieldNumber = 10;

	public const int APBBENFPNLLFieldNumber = 12;

	public const int HBMPBIOLCGDFieldNumber = 13;

	public const int AJAIDIBLMAOFieldNumber = 14;

	public const int NJMKOPKJCGCFieldNumber = 15;

	private object lBEBNKMENPN_;

	private LBEBNKMENPNOneofCase lBEBNKMENPNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGKBEBCCDGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGKBEBCCDGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBLDOIIILEC FHCPKOMPCDH
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.FHCPKOMPCDH)
			{
				return null;
			}
			return (JBLDOIIILEC)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.FHCPKOMPCDH : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDIECABCIGN MAECOFLEAGD
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.MAECOFLEAGD)
			{
				return null;
			}
			return (GDIECABCIGN)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.MAECOFLEAGD : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAHJGDGPMHI NHHFADEBELO
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.NHHFADEBELO)
			{
				return null;
			}
			return (DAHJGDGPMHI)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.NHHFADEBELO : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHBECEGINOC MBKDAFJCHAC
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.MBKDAFJCHAC)
			{
				return null;
			}
			return (KHBECEGINOC)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.MBKDAFJCHAC : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGFDCHANNEB JGNAJOFIKEJ
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.JGNAJOFIKEJ)
			{
				return null;
			}
			return (GGFDCHANNEB)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.JGNAJOFIKEJ : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APNHPMINDKB EIENKJFFFJG
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.EIENKJFFFJG)
			{
				return null;
			}
			return (APNHPMINDKB)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.EIENKJFFFJG : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEICIPHOPN LLNNPGEOFCD
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.LLNNPGEOFCD)
			{
				return null;
			}
			return (KCEICIPHOPN)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.LLNNPGEOFCD : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEEMHIBGALH APBBENFPNLL
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.APBBENFPNLL)
			{
				return null;
			}
			return (AEEMHIBGALH)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.APBBENFPNLL : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHNGCNHEOCB HBMPBIOLCGD
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.HBMPBIOLCGD)
			{
				return null;
			}
			return (JHNGCNHEOCB)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.HBMPBIOLCGD : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKBOCDDFIKB AJAIDIBLMAO
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.AJAIDIBLMAO)
			{
				return null;
			}
			return (FKBOCDDFIKB)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.AJAIDIBLMAO : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFKOMCNLMDG NJMKOPKJCGC
	{
		get
		{
			if (lBEBNKMENPNCase_ != LBEBNKMENPNOneofCase.NJMKOPKJCGC)
			{
				return null;
			}
			return (GFKOMCNLMDG)lBEBNKMENPN_;
		}
		set
		{
			lBEBNKMENPN_ = value;
			lBEBNKMENPNCase_ = ((value != null) ? LBEBNKMENPNOneofCase.NJMKOPKJCGC : LBEBNKMENPNOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBEBNKMENPNOneofCase LBEBNKMENPNCase => lBEBNKMENPNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGKBEBCCDGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGKBEBCCDGF(CGKBEBCCDGF other)
		: this()
	{
		switch (other.LBEBNKMENPNCase)
		{
		case LBEBNKMENPNOneofCase.FHCPKOMPCDH:
			FHCPKOMPCDH = other.FHCPKOMPCDH.Clone();
			break;
		case LBEBNKMENPNOneofCase.MAECOFLEAGD:
			MAECOFLEAGD = other.MAECOFLEAGD.Clone();
			break;
		case LBEBNKMENPNOneofCase.NHHFADEBELO:
			NHHFADEBELO = other.NHHFADEBELO.Clone();
			break;
		case LBEBNKMENPNOneofCase.MBKDAFJCHAC:
			MBKDAFJCHAC = other.MBKDAFJCHAC.Clone();
			break;
		case LBEBNKMENPNOneofCase.JGNAJOFIKEJ:
			JGNAJOFIKEJ = other.JGNAJOFIKEJ.Clone();
			break;
		case LBEBNKMENPNOneofCase.EIENKJFFFJG:
			EIENKJFFFJG = other.EIENKJFFFJG.Clone();
			break;
		case LBEBNKMENPNOneofCase.LLNNPGEOFCD:
			LLNNPGEOFCD = other.LLNNPGEOFCD.Clone();
			break;
		case LBEBNKMENPNOneofCase.APBBENFPNLL:
			APBBENFPNLL = other.APBBENFPNLL.Clone();
			break;
		case LBEBNKMENPNOneofCase.HBMPBIOLCGD:
			HBMPBIOLCGD = other.HBMPBIOLCGD.Clone();
			break;
		case LBEBNKMENPNOneofCase.AJAIDIBLMAO:
			AJAIDIBLMAO = other.AJAIDIBLMAO.Clone();
			break;
		case LBEBNKMENPNOneofCase.NJMKOPKJCGC:
			NJMKOPKJCGC = other.NJMKOPKJCGC.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGKBEBCCDGF Clone()
	{
		return new CGKBEBCCDGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLBEBNKMENPN()
	{
		lBEBNKMENPNCase_ = LBEBNKMENPNOneofCase.None;
		lBEBNKMENPN_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGKBEBCCDGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGKBEBCCDGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FHCPKOMPCDH, other.FHCPKOMPCDH))
		{
			return false;
		}
		if (!object.Equals(MAECOFLEAGD, other.MAECOFLEAGD))
		{
			return false;
		}
		if (!object.Equals(NHHFADEBELO, other.NHHFADEBELO))
		{
			return false;
		}
		if (!object.Equals(MBKDAFJCHAC, other.MBKDAFJCHAC))
		{
			return false;
		}
		if (!object.Equals(JGNAJOFIKEJ, other.JGNAJOFIKEJ))
		{
			return false;
		}
		if (!object.Equals(EIENKJFFFJG, other.EIENKJFFFJG))
		{
			return false;
		}
		if (!object.Equals(LLNNPGEOFCD, other.LLNNPGEOFCD))
		{
			return false;
		}
		if (!object.Equals(APBBENFPNLL, other.APBBENFPNLL))
		{
			return false;
		}
		if (!object.Equals(HBMPBIOLCGD, other.HBMPBIOLCGD))
		{
			return false;
		}
		if (!object.Equals(AJAIDIBLMAO, other.AJAIDIBLMAO))
		{
			return false;
		}
		if (!object.Equals(NJMKOPKJCGC, other.NJMKOPKJCGC))
		{
			return false;
		}
		if (LBEBNKMENPNCase != other.LBEBNKMENPNCase)
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
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.FHCPKOMPCDH)
		{
			num ^= FHCPKOMPCDH.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MAECOFLEAGD)
		{
			num ^= MAECOFLEAGD.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NHHFADEBELO)
		{
			num ^= NHHFADEBELO.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MBKDAFJCHAC)
		{
			num ^= MBKDAFJCHAC.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.JGNAJOFIKEJ)
		{
			num ^= JGNAJOFIKEJ.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.EIENKJFFFJG)
		{
			num ^= EIENKJFFFJG.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.LLNNPGEOFCD)
		{
			num ^= LLNNPGEOFCD.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.APBBENFPNLL)
		{
			num ^= APBBENFPNLL.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.HBMPBIOLCGD)
		{
			num ^= HBMPBIOLCGD.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.AJAIDIBLMAO)
		{
			num ^= AJAIDIBLMAO.GetHashCode();
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NJMKOPKJCGC)
		{
			num ^= NJMKOPKJCGC.GetHashCode();
		}
		num ^= (int)lBEBNKMENPNCase_;
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
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.FHCPKOMPCDH)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FHCPKOMPCDH);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MAECOFLEAGD)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MAECOFLEAGD);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NHHFADEBELO)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NHHFADEBELO);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MBKDAFJCHAC)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MBKDAFJCHAC);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.JGNAJOFIKEJ)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JGNAJOFIKEJ);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.EIENKJFFFJG)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EIENKJFFFJG);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.LLNNPGEOFCD)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LLNNPGEOFCD);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.APBBENFPNLL)
		{
			output.WriteRawTag(98);
			output.WriteMessage(APBBENFPNLL);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.HBMPBIOLCGD)
		{
			output.WriteRawTag(106);
			output.WriteMessage(HBMPBIOLCGD);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.AJAIDIBLMAO)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AJAIDIBLMAO);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NJMKOPKJCGC)
		{
			output.WriteRawTag(122);
			output.WriteMessage(NJMKOPKJCGC);
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
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.FHCPKOMPCDH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHCPKOMPCDH);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MAECOFLEAGD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAECOFLEAGD);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NHHFADEBELO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NHHFADEBELO);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MBKDAFJCHAC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBKDAFJCHAC);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.JGNAJOFIKEJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JGNAJOFIKEJ);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.EIENKJFFFJG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EIENKJFFFJG);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.LLNNPGEOFCD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LLNNPGEOFCD);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.APBBENFPNLL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(APBBENFPNLL);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.HBMPBIOLCGD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HBMPBIOLCGD);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.AJAIDIBLMAO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AJAIDIBLMAO);
		}
		if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NJMKOPKJCGC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NJMKOPKJCGC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGKBEBCCDGF other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.LBEBNKMENPNCase)
		{
		case LBEBNKMENPNOneofCase.FHCPKOMPCDH:
			if (FHCPKOMPCDH == null)
			{
				FHCPKOMPCDH = new JBLDOIIILEC();
			}
			FHCPKOMPCDH.MergeFrom(other.FHCPKOMPCDH);
			break;
		case LBEBNKMENPNOneofCase.MAECOFLEAGD:
			if (MAECOFLEAGD == null)
			{
				MAECOFLEAGD = new GDIECABCIGN();
			}
			MAECOFLEAGD.MergeFrom(other.MAECOFLEAGD);
			break;
		case LBEBNKMENPNOneofCase.NHHFADEBELO:
			if (NHHFADEBELO == null)
			{
				NHHFADEBELO = new DAHJGDGPMHI();
			}
			NHHFADEBELO.MergeFrom(other.NHHFADEBELO);
			break;
		case LBEBNKMENPNOneofCase.MBKDAFJCHAC:
			if (MBKDAFJCHAC == null)
			{
				MBKDAFJCHAC = new KHBECEGINOC();
			}
			MBKDAFJCHAC.MergeFrom(other.MBKDAFJCHAC);
			break;
		case LBEBNKMENPNOneofCase.JGNAJOFIKEJ:
			if (JGNAJOFIKEJ == null)
			{
				JGNAJOFIKEJ = new GGFDCHANNEB();
			}
			JGNAJOFIKEJ.MergeFrom(other.JGNAJOFIKEJ);
			break;
		case LBEBNKMENPNOneofCase.EIENKJFFFJG:
			if (EIENKJFFFJG == null)
			{
				EIENKJFFFJG = new APNHPMINDKB();
			}
			EIENKJFFFJG.MergeFrom(other.EIENKJFFFJG);
			break;
		case LBEBNKMENPNOneofCase.LLNNPGEOFCD:
			if (LLNNPGEOFCD == null)
			{
				LLNNPGEOFCD = new KCEICIPHOPN();
			}
			LLNNPGEOFCD.MergeFrom(other.LLNNPGEOFCD);
			break;
		case LBEBNKMENPNOneofCase.APBBENFPNLL:
			if (APBBENFPNLL == null)
			{
				APBBENFPNLL = new AEEMHIBGALH();
			}
			APBBENFPNLL.MergeFrom(other.APBBENFPNLL);
			break;
		case LBEBNKMENPNOneofCase.HBMPBIOLCGD:
			if (HBMPBIOLCGD == null)
			{
				HBMPBIOLCGD = new JHNGCNHEOCB();
			}
			HBMPBIOLCGD.MergeFrom(other.HBMPBIOLCGD);
			break;
		case LBEBNKMENPNOneofCase.AJAIDIBLMAO:
			if (AJAIDIBLMAO == null)
			{
				AJAIDIBLMAO = new FKBOCDDFIKB();
			}
			AJAIDIBLMAO.MergeFrom(other.AJAIDIBLMAO);
			break;
		case LBEBNKMENPNOneofCase.NJMKOPKJCGC:
			if (NJMKOPKJCGC == null)
			{
				NJMKOPKJCGC = new GFKOMCNLMDG();
			}
			NJMKOPKJCGC.MergeFrom(other.NJMKOPKJCGC);
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
				JBLDOIIILEC jBLDOIIILEC = new JBLDOIIILEC();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.FHCPKOMPCDH)
				{
					jBLDOIIILEC.MergeFrom(FHCPKOMPCDH);
				}
				input.ReadMessage(jBLDOIIILEC);
				FHCPKOMPCDH = jBLDOIIILEC;
				break;
			}
			case 18u:
			{
				GDIECABCIGN gDIECABCIGN = new GDIECABCIGN();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MAECOFLEAGD)
				{
					gDIECABCIGN.MergeFrom(MAECOFLEAGD);
				}
				input.ReadMessage(gDIECABCIGN);
				MAECOFLEAGD = gDIECABCIGN;
				break;
			}
			case 26u:
			{
				DAHJGDGPMHI dAHJGDGPMHI = new DAHJGDGPMHI();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NHHFADEBELO)
				{
					dAHJGDGPMHI.MergeFrom(NHHFADEBELO);
				}
				input.ReadMessage(dAHJGDGPMHI);
				NHHFADEBELO = dAHJGDGPMHI;
				break;
			}
			case 34u:
			{
				KHBECEGINOC kHBECEGINOC = new KHBECEGINOC();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.MBKDAFJCHAC)
				{
					kHBECEGINOC.MergeFrom(MBKDAFJCHAC);
				}
				input.ReadMessage(kHBECEGINOC);
				MBKDAFJCHAC = kHBECEGINOC;
				break;
			}
			case 50u:
			{
				GGFDCHANNEB gGFDCHANNEB = new GGFDCHANNEB();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.JGNAJOFIKEJ)
				{
					gGFDCHANNEB.MergeFrom(JGNAJOFIKEJ);
				}
				input.ReadMessage(gGFDCHANNEB);
				JGNAJOFIKEJ = gGFDCHANNEB;
				break;
			}
			case 66u:
			{
				APNHPMINDKB aPNHPMINDKB = new APNHPMINDKB();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.EIENKJFFFJG)
				{
					aPNHPMINDKB.MergeFrom(EIENKJFFFJG);
				}
				input.ReadMessage(aPNHPMINDKB);
				EIENKJFFFJG = aPNHPMINDKB;
				break;
			}
			case 82u:
			{
				KCEICIPHOPN kCEICIPHOPN = new KCEICIPHOPN();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.LLNNPGEOFCD)
				{
					kCEICIPHOPN.MergeFrom(LLNNPGEOFCD);
				}
				input.ReadMessage(kCEICIPHOPN);
				LLNNPGEOFCD = kCEICIPHOPN;
				break;
			}
			case 98u:
			{
				AEEMHIBGALH aEEMHIBGALH = new AEEMHIBGALH();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.APBBENFPNLL)
				{
					aEEMHIBGALH.MergeFrom(APBBENFPNLL);
				}
				input.ReadMessage(aEEMHIBGALH);
				APBBENFPNLL = aEEMHIBGALH;
				break;
			}
			case 106u:
			{
				JHNGCNHEOCB jHNGCNHEOCB = new JHNGCNHEOCB();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.HBMPBIOLCGD)
				{
					jHNGCNHEOCB.MergeFrom(HBMPBIOLCGD);
				}
				input.ReadMessage(jHNGCNHEOCB);
				HBMPBIOLCGD = jHNGCNHEOCB;
				break;
			}
			case 114u:
			{
				FKBOCDDFIKB fKBOCDDFIKB = new FKBOCDDFIKB();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.AJAIDIBLMAO)
				{
					fKBOCDDFIKB.MergeFrom(AJAIDIBLMAO);
				}
				input.ReadMessage(fKBOCDDFIKB);
				AJAIDIBLMAO = fKBOCDDFIKB;
				break;
			}
			case 122u:
			{
				GFKOMCNLMDG gFKOMCNLMDG = new GFKOMCNLMDG();
				if (lBEBNKMENPNCase_ == LBEBNKMENPNOneofCase.NJMKOPKJCGC)
				{
					gFKOMCNLMDG.MergeFrom(NJMKOPKJCGC);
				}
				input.ReadMessage(gFKOMCNLMDG);
				NJMKOPKJCGC = gFKOMCNLMDG;
				break;
			}
			}
		}
	}
}
