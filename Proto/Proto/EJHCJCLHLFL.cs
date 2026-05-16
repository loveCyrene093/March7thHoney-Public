using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EJHCJCLHLFL : IMessage<EJHCJCLHLFL>, IMessage, IEquatable<EJHCJCLHLFL>, IDeepCloneable<EJHCJCLHLFL>, IBufferMessage
{
	public enum KCOCCGEOECOOneofCase
	{
		None = 0,
		MFCLFKHACJP = 97,
		AOKBMMOEAMD = 531,
		PNDOKOCCNKE = 1050,
		BPFJAOGMNKG = 1130,
		JJLAKBDMAGC = 1305,
		EHLFKAFAAMD = 1316,
		FHFHFADIEJO = 1395,
		FPFAMFHEINC = 1527,
		GHEPJFLNHNG = 1978,
		KMHCDILKHFD = 2008
	}

	private static readonly MessageParser<EJHCJCLHLFL> _parser = new MessageParser<EJHCJCLHLFL>(() => new EJHCJCLHLFL());

	private UnknownFieldSet _unknownFields;

	public const int MFCLFKHACJPFieldNumber = 97;

	public const int AOKBMMOEAMDFieldNumber = 531;

	public const int PNDOKOCCNKEFieldNumber = 1050;

	public const int BPFJAOGMNKGFieldNumber = 1130;

	public const int JJLAKBDMAGCFieldNumber = 1305;

	public const int EHLFKAFAAMDFieldNumber = 1316;

	public const int FHFHFADIEJOFieldNumber = 1395;

	public const int FPFAMFHEINCFieldNumber = 1527;

	public const int GHEPJFLNHNGFieldNumber = 1978;

	public const int KMHCDILKHFDFieldNumber = 2008;

	private object kCOCCGEOECO_;

	private KCOCCGEOECOOneofCase kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EJHCJCLHLFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EJHCJCLHLFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGMBMAAPCCN MFCLFKHACJP
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.MFCLFKHACJP)
			{
				return null;
			}
			return (AGMBMAAPCCN)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.MFCLFKHACJP : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAMHNJKNNAM AOKBMMOEAMD
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.AOKBMMOEAMD)
			{
				return null;
			}
			return (BAMHNJKNNAM)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.AOKBMMOEAMD : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPNNDJHIKO PNDOKOCCNKE
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.PNDOKOCCNKE)
			{
				return null;
			}
			return (LHPNNDJHIKO)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.PNDOKOCCNKE : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOADALEMDGL BPFJAOGMNKG
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.BPFJAOGMNKG)
			{
				return null;
			}
			return (OOADALEMDGL)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.BPFJAOGMNKG : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGFNONPBIOF JJLAKBDMAGC
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.JJLAKBDMAGC)
			{
				return null;
			}
			return (DGFNONPBIOF)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.JJLAKBDMAGC : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BOHKJAPOIKO EHLFKAFAAMD
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.EHLFKAFAAMD)
			{
				return null;
			}
			return (BOHKJAPOIKO)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.EHLFKAFAAMD : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFNNFKOMADN FHFHFADIEJO
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.FHFHFADIEJO)
			{
				return null;
			}
			return (EFNNFKOMADN)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.FHFHFADIEJO : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFBFBMJMKAL FPFAMFHEINC
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.FPFAMFHEINC)
			{
				return null;
			}
			return (DFBFBMJMKAL)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.FPFAMFHEINC : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LAJDNEMABIO GHEPJFLNHNG
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.GHEPJFLNHNG)
			{
				return null;
			}
			return (LAJDNEMABIO)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.GHEPJFLNHNG : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDDGLOAEOHH KMHCDILKHFD
	{
		get
		{
			if (kCOCCGEOECOCase_ != KCOCCGEOECOOneofCase.KMHCDILKHFD)
			{
				return null;
			}
			return (CDDGLOAEOHH)kCOCCGEOECO_;
		}
		set
		{
			kCOCCGEOECO_ = value;
			kCOCCGEOECOCase_ = ((value != null) ? KCOCCGEOECOOneofCase.KMHCDILKHFD : KCOCCGEOECOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCOCCGEOECOOneofCase KCOCCGEOECOCase => kCOCCGEOECOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJHCJCLHLFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJHCJCLHLFL(EJHCJCLHLFL other)
		: this()
	{
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.MFCLFKHACJP:
			MFCLFKHACJP = other.MFCLFKHACJP.Clone();
			break;
		case KCOCCGEOECOOneofCase.AOKBMMOEAMD:
			AOKBMMOEAMD = other.AOKBMMOEAMD.Clone();
			break;
		case KCOCCGEOECOOneofCase.PNDOKOCCNKE:
			PNDOKOCCNKE = other.PNDOKOCCNKE.Clone();
			break;
		case KCOCCGEOECOOneofCase.BPFJAOGMNKG:
			BPFJAOGMNKG = other.BPFJAOGMNKG.Clone();
			break;
		case KCOCCGEOECOOneofCase.JJLAKBDMAGC:
			JJLAKBDMAGC = other.JJLAKBDMAGC.Clone();
			break;
		case KCOCCGEOECOOneofCase.EHLFKAFAAMD:
			EHLFKAFAAMD = other.EHLFKAFAAMD.Clone();
			break;
		case KCOCCGEOECOOneofCase.FHFHFADIEJO:
			FHFHFADIEJO = other.FHFHFADIEJO.Clone();
			break;
		case KCOCCGEOECOOneofCase.FPFAMFHEINC:
			FPFAMFHEINC = other.FPFAMFHEINC.Clone();
			break;
		case KCOCCGEOECOOneofCase.GHEPJFLNHNG:
			GHEPJFLNHNG = other.GHEPJFLNHNG.Clone();
			break;
		case KCOCCGEOECOOneofCase.KMHCDILKHFD:
			KMHCDILKHFD = other.KMHCDILKHFD.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJHCJCLHLFL Clone()
	{
		return new EJHCJCLHLFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKCOCCGEOECO()
	{
		kCOCCGEOECOCase_ = KCOCCGEOECOOneofCase.None;
		kCOCCGEOECO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EJHCJCLHLFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EJHCJCLHLFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MFCLFKHACJP, other.MFCLFKHACJP))
		{
			return false;
		}
		if (!object.Equals(AOKBMMOEAMD, other.AOKBMMOEAMD))
		{
			return false;
		}
		if (!object.Equals(PNDOKOCCNKE, other.PNDOKOCCNKE))
		{
			return false;
		}
		if (!object.Equals(BPFJAOGMNKG, other.BPFJAOGMNKG))
		{
			return false;
		}
		if (!object.Equals(JJLAKBDMAGC, other.JJLAKBDMAGC))
		{
			return false;
		}
		if (!object.Equals(EHLFKAFAAMD, other.EHLFKAFAAMD))
		{
			return false;
		}
		if (!object.Equals(FHFHFADIEJO, other.FHFHFADIEJO))
		{
			return false;
		}
		if (!object.Equals(FPFAMFHEINC, other.FPFAMFHEINC))
		{
			return false;
		}
		if (!object.Equals(GHEPJFLNHNG, other.GHEPJFLNHNG))
		{
			return false;
		}
		if (!object.Equals(KMHCDILKHFD, other.KMHCDILKHFD))
		{
			return false;
		}
		if (KCOCCGEOECOCase != other.KCOCCGEOECOCase)
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
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.MFCLFKHACJP)
		{
			num ^= MFCLFKHACJP.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AOKBMMOEAMD)
		{
			num ^= AOKBMMOEAMD.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PNDOKOCCNKE)
		{
			num ^= PNDOKOCCNKE.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BPFJAOGMNKG)
		{
			num ^= BPFJAOGMNKG.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JJLAKBDMAGC)
		{
			num ^= JJLAKBDMAGC.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EHLFKAFAAMD)
		{
			num ^= EHLFKAFAAMD.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FHFHFADIEJO)
		{
			num ^= FHFHFADIEJO.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FPFAMFHEINC)
		{
			num ^= FPFAMFHEINC.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GHEPJFLNHNG)
		{
			num ^= GHEPJFLNHNG.GetHashCode();
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.KMHCDILKHFD)
		{
			num ^= KMHCDILKHFD.GetHashCode();
		}
		num ^= (int)kCOCCGEOECOCase_;
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
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.MFCLFKHACJP)
		{
			output.WriteRawTag(138, 6);
			output.WriteMessage(MFCLFKHACJP);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AOKBMMOEAMD)
		{
			output.WriteRawTag(154, 33);
			output.WriteMessage(AOKBMMOEAMD);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PNDOKOCCNKE)
		{
			output.WriteRawTag(210, 65);
			output.WriteMessage(PNDOKOCCNKE);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BPFJAOGMNKG)
		{
			output.WriteRawTag(210, 70);
			output.WriteMessage(BPFJAOGMNKG);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JJLAKBDMAGC)
		{
			output.WriteRawTag(202, 81);
			output.WriteMessage(JJLAKBDMAGC);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EHLFKAFAAMD)
		{
			output.WriteRawTag(162, 82);
			output.WriteMessage(EHLFKAFAAMD);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FHFHFADIEJO)
		{
			output.WriteRawTag(154, 87);
			output.WriteMessage(FHFHFADIEJO);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FPFAMFHEINC)
		{
			output.WriteRawTag(186, 95);
			output.WriteMessage(FPFAMFHEINC);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GHEPJFLNHNG)
		{
			output.WriteRawTag(210, 123);
			output.WriteMessage(GHEPJFLNHNG);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.KMHCDILKHFD)
		{
			output.WriteRawTag(194, 125);
			output.WriteMessage(KMHCDILKHFD);
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
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.MFCLFKHACJP)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MFCLFKHACJP);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AOKBMMOEAMD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AOKBMMOEAMD);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PNDOKOCCNKE)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PNDOKOCCNKE);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BPFJAOGMNKG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BPFJAOGMNKG);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JJLAKBDMAGC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(JJLAKBDMAGC);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EHLFKAFAAMD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EHLFKAFAAMD);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FHFHFADIEJO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FHFHFADIEJO);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FPFAMFHEINC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FPFAMFHEINC);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GHEPJFLNHNG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GHEPJFLNHNG);
		}
		if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.KMHCDILKHFD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KMHCDILKHFD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EJHCJCLHLFL other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.KCOCCGEOECOCase)
		{
		case KCOCCGEOECOOneofCase.MFCLFKHACJP:
			if (MFCLFKHACJP == null)
			{
				MFCLFKHACJP = new AGMBMAAPCCN();
			}
			MFCLFKHACJP.MergeFrom(other.MFCLFKHACJP);
			break;
		case KCOCCGEOECOOneofCase.AOKBMMOEAMD:
			if (AOKBMMOEAMD == null)
			{
				AOKBMMOEAMD = new BAMHNJKNNAM();
			}
			AOKBMMOEAMD.MergeFrom(other.AOKBMMOEAMD);
			break;
		case KCOCCGEOECOOneofCase.PNDOKOCCNKE:
			if (PNDOKOCCNKE == null)
			{
				PNDOKOCCNKE = new LHPNNDJHIKO();
			}
			PNDOKOCCNKE.MergeFrom(other.PNDOKOCCNKE);
			break;
		case KCOCCGEOECOOneofCase.BPFJAOGMNKG:
			if (BPFJAOGMNKG == null)
			{
				BPFJAOGMNKG = new OOADALEMDGL();
			}
			BPFJAOGMNKG.MergeFrom(other.BPFJAOGMNKG);
			break;
		case KCOCCGEOECOOneofCase.JJLAKBDMAGC:
			if (JJLAKBDMAGC == null)
			{
				JJLAKBDMAGC = new DGFNONPBIOF();
			}
			JJLAKBDMAGC.MergeFrom(other.JJLAKBDMAGC);
			break;
		case KCOCCGEOECOOneofCase.EHLFKAFAAMD:
			if (EHLFKAFAAMD == null)
			{
				EHLFKAFAAMD = new BOHKJAPOIKO();
			}
			EHLFKAFAAMD.MergeFrom(other.EHLFKAFAAMD);
			break;
		case KCOCCGEOECOOneofCase.FHFHFADIEJO:
			if (FHFHFADIEJO == null)
			{
				FHFHFADIEJO = new EFNNFKOMADN();
			}
			FHFHFADIEJO.MergeFrom(other.FHFHFADIEJO);
			break;
		case KCOCCGEOECOOneofCase.FPFAMFHEINC:
			if (FPFAMFHEINC == null)
			{
				FPFAMFHEINC = new DFBFBMJMKAL();
			}
			FPFAMFHEINC.MergeFrom(other.FPFAMFHEINC);
			break;
		case KCOCCGEOECOOneofCase.GHEPJFLNHNG:
			if (GHEPJFLNHNG == null)
			{
				GHEPJFLNHNG = new LAJDNEMABIO();
			}
			GHEPJFLNHNG.MergeFrom(other.GHEPJFLNHNG);
			break;
		case KCOCCGEOECOOneofCase.KMHCDILKHFD:
			if (KMHCDILKHFD == null)
			{
				KMHCDILKHFD = new CDDGLOAEOHH();
			}
			KMHCDILKHFD.MergeFrom(other.KMHCDILKHFD);
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
			case 778u:
			{
				AGMBMAAPCCN aGMBMAAPCCN = new AGMBMAAPCCN();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.MFCLFKHACJP)
				{
					aGMBMAAPCCN.MergeFrom(MFCLFKHACJP);
				}
				input.ReadMessage(aGMBMAAPCCN);
				MFCLFKHACJP = aGMBMAAPCCN;
				break;
			}
			case 4250u:
			{
				BAMHNJKNNAM bAMHNJKNNAM = new BAMHNJKNNAM();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.AOKBMMOEAMD)
				{
					bAMHNJKNNAM.MergeFrom(AOKBMMOEAMD);
				}
				input.ReadMessage(bAMHNJKNNAM);
				AOKBMMOEAMD = bAMHNJKNNAM;
				break;
			}
			case 8402u:
			{
				LHPNNDJHIKO lHPNNDJHIKO = new LHPNNDJHIKO();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.PNDOKOCCNKE)
				{
					lHPNNDJHIKO.MergeFrom(PNDOKOCCNKE);
				}
				input.ReadMessage(lHPNNDJHIKO);
				PNDOKOCCNKE = lHPNNDJHIKO;
				break;
			}
			case 9042u:
			{
				OOADALEMDGL oOADALEMDGL = new OOADALEMDGL();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.BPFJAOGMNKG)
				{
					oOADALEMDGL.MergeFrom(BPFJAOGMNKG);
				}
				input.ReadMessage(oOADALEMDGL);
				BPFJAOGMNKG = oOADALEMDGL;
				break;
			}
			case 10442u:
			{
				DGFNONPBIOF dGFNONPBIOF = new DGFNONPBIOF();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.JJLAKBDMAGC)
				{
					dGFNONPBIOF.MergeFrom(JJLAKBDMAGC);
				}
				input.ReadMessage(dGFNONPBIOF);
				JJLAKBDMAGC = dGFNONPBIOF;
				break;
			}
			case 10530u:
			{
				BOHKJAPOIKO bOHKJAPOIKO = new BOHKJAPOIKO();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.EHLFKAFAAMD)
				{
					bOHKJAPOIKO.MergeFrom(EHLFKAFAAMD);
				}
				input.ReadMessage(bOHKJAPOIKO);
				EHLFKAFAAMD = bOHKJAPOIKO;
				break;
			}
			case 11162u:
			{
				EFNNFKOMADN eFNNFKOMADN = new EFNNFKOMADN();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FHFHFADIEJO)
				{
					eFNNFKOMADN.MergeFrom(FHFHFADIEJO);
				}
				input.ReadMessage(eFNNFKOMADN);
				FHFHFADIEJO = eFNNFKOMADN;
				break;
			}
			case 12218u:
			{
				DFBFBMJMKAL dFBFBMJMKAL = new DFBFBMJMKAL();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.FPFAMFHEINC)
				{
					dFBFBMJMKAL.MergeFrom(FPFAMFHEINC);
				}
				input.ReadMessage(dFBFBMJMKAL);
				FPFAMFHEINC = dFBFBMJMKAL;
				break;
			}
			case 15826u:
			{
				LAJDNEMABIO lAJDNEMABIO = new LAJDNEMABIO();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.GHEPJFLNHNG)
				{
					lAJDNEMABIO.MergeFrom(GHEPJFLNHNG);
				}
				input.ReadMessage(lAJDNEMABIO);
				GHEPJFLNHNG = lAJDNEMABIO;
				break;
			}
			case 16066u:
			{
				CDDGLOAEOHH cDDGLOAEOHH = new CDDGLOAEOHH();
				if (kCOCCGEOECOCase_ == KCOCCGEOECOOneofCase.KMHCDILKHFD)
				{
					cDDGLOAEOHH.MergeFrom(KMHCDILKHFD);
				}
				input.ReadMessage(cDDGLOAEOHH);
				KMHCDILKHFD = cDDGLOAEOHH;
				break;
			}
			}
		}
	}
}
