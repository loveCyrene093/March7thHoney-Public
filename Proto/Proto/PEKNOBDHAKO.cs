using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PEKNOBDHAKO : IMessage<PEKNOBDHAKO>, IMessage, IEquatable<PEKNOBDHAKO>, IDeepCloneable<PEKNOBDHAKO>, IBufferMessage
{
	public enum MFKJOHBNBJAOneofCase
	{
		None,
		MHNBGKJLDGB,
		NCCNKHELPKL,
		IFHGNHGAPIN,
		NAOKLIALCEN,
		KFPKHHAOGPP,
		IIHECADEHNG
	}

	private static readonly MessageParser<PEKNOBDHAKO> _parser = new MessageParser<PEKNOBDHAKO>(() => new PEKNOBDHAKO());

	private UnknownFieldSet _unknownFields;

	public const int MGMFENIOPHOFieldNumber = 10;

	private string mGMFENIOPHO_ = "";

	public const int MHNBGKJLDGBFieldNumber = 1;

	public const int NCCNKHELPKLFieldNumber = 2;

	public const int IFHGNHGAPINFieldNumber = 3;

	public const int NAOKLIALCENFieldNumber = 4;

	public const int KFPKHHAOGPPFieldNumber = 5;

	public const int IIHECADEHNGFieldNumber = 6;

	private object mFKJOHBNBJA_;

	private MFKJOHBNBJAOneofCase mFKJOHBNBJACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PEKNOBDHAKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PEKNOBDHAKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MGMFENIOPHO
	{
		get
		{
			return mGMFENIOPHO_;
		}
		set
		{
			mGMFENIOPHO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GOEOJEFKKMK MHNBGKJLDGB
	{
		get
		{
			if (mFKJOHBNBJACase_ != MFKJOHBNBJAOneofCase.MHNBGKJLDGB)
			{
				return null;
			}
			return (GOEOJEFKKMK)mFKJOHBNBJA_;
		}
		set
		{
			mFKJOHBNBJA_ = value;
			mFKJOHBNBJACase_ = ((value != null) ? MFKJOHBNBJAOneofCase.MHNBGKJLDGB : MFKJOHBNBJAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPONIDHOFPP NCCNKHELPKL
	{
		get
		{
			if (mFKJOHBNBJACase_ != MFKJOHBNBJAOneofCase.NCCNKHELPKL)
			{
				return null;
			}
			return (BPONIDHOFPP)mFKJOHBNBJA_;
		}
		set
		{
			mFKJOHBNBJA_ = value;
			mFKJOHBNBJACase_ = ((value != null) ? MFKJOHBNBJAOneofCase.NCCNKHELPKL : MFKJOHBNBJAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFEMKNKGPNF IFHGNHGAPIN
	{
		get
		{
			if (mFKJOHBNBJACase_ != MFKJOHBNBJAOneofCase.IFHGNHGAPIN)
			{
				return null;
			}
			return (HFEMKNKGPNF)mFKJOHBNBJA_;
		}
		set
		{
			mFKJOHBNBJA_ = value;
			mFKJOHBNBJACase_ = ((value != null) ? MFKJOHBNBJAOneofCase.IFHGNHGAPIN : MFKJOHBNBJAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPMIMEPEBHH NAOKLIALCEN
	{
		get
		{
			if (mFKJOHBNBJACase_ != MFKJOHBNBJAOneofCase.NAOKLIALCEN)
			{
				return null;
			}
			return (KPMIMEPEBHH)mFKJOHBNBJA_;
		}
		set
		{
			mFKJOHBNBJA_ = value;
			mFKJOHBNBJACase_ = ((value != null) ? MFKJOHBNBJAOneofCase.NAOKLIALCEN : MFKJOHBNBJAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOFLIBJHHPC KFPKHHAOGPP
	{
		get
		{
			if (mFKJOHBNBJACase_ != MFKJOHBNBJAOneofCase.KFPKHHAOGPP)
			{
				return null;
			}
			return (HOFLIBJHHPC)mFKJOHBNBJA_;
		}
		set
		{
			mFKJOHBNBJA_ = value;
			mFKJOHBNBJACase_ = ((value != null) ? MFKJOHBNBJAOneofCase.KFPKHHAOGPP : MFKJOHBNBJAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPDLFAOMIPI IIHECADEHNG
	{
		get
		{
			if (mFKJOHBNBJACase_ != MFKJOHBNBJAOneofCase.IIHECADEHNG)
			{
				return null;
			}
			return (HPDLFAOMIPI)mFKJOHBNBJA_;
		}
		set
		{
			mFKJOHBNBJA_ = value;
			mFKJOHBNBJACase_ = ((value != null) ? MFKJOHBNBJAOneofCase.IIHECADEHNG : MFKJOHBNBJAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFKJOHBNBJAOneofCase MFKJOHBNBJACase => mFKJOHBNBJACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEKNOBDHAKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEKNOBDHAKO(PEKNOBDHAKO other)
		: this()
	{
		mGMFENIOPHO_ = other.mGMFENIOPHO_;
		switch (other.MFKJOHBNBJACase)
		{
		case MFKJOHBNBJAOneofCase.MHNBGKJLDGB:
			MHNBGKJLDGB = other.MHNBGKJLDGB.Clone();
			break;
		case MFKJOHBNBJAOneofCase.NCCNKHELPKL:
			NCCNKHELPKL = other.NCCNKHELPKL.Clone();
			break;
		case MFKJOHBNBJAOneofCase.IFHGNHGAPIN:
			IFHGNHGAPIN = other.IFHGNHGAPIN.Clone();
			break;
		case MFKJOHBNBJAOneofCase.NAOKLIALCEN:
			NAOKLIALCEN = other.NAOKLIALCEN.Clone();
			break;
		case MFKJOHBNBJAOneofCase.KFPKHHAOGPP:
			KFPKHHAOGPP = other.KFPKHHAOGPP.Clone();
			break;
		case MFKJOHBNBJAOneofCase.IIHECADEHNG:
			IIHECADEHNG = other.IIHECADEHNG.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEKNOBDHAKO Clone()
	{
		return new PEKNOBDHAKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMFKJOHBNBJA()
	{
		mFKJOHBNBJACase_ = MFKJOHBNBJAOneofCase.None;
		mFKJOHBNBJA_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PEKNOBDHAKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PEKNOBDHAKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGMFENIOPHO != other.MGMFENIOPHO)
		{
			return false;
		}
		if (!object.Equals(MHNBGKJLDGB, other.MHNBGKJLDGB))
		{
			return false;
		}
		if (!object.Equals(NCCNKHELPKL, other.NCCNKHELPKL))
		{
			return false;
		}
		if (!object.Equals(IFHGNHGAPIN, other.IFHGNHGAPIN))
		{
			return false;
		}
		if (!object.Equals(NAOKLIALCEN, other.NAOKLIALCEN))
		{
			return false;
		}
		if (!object.Equals(KFPKHHAOGPP, other.KFPKHHAOGPP))
		{
			return false;
		}
		if (!object.Equals(IIHECADEHNG, other.IIHECADEHNG))
		{
			return false;
		}
		if (MFKJOHBNBJACase != other.MFKJOHBNBJACase)
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
		if (MGMFENIOPHO.Length != 0)
		{
			num ^= MGMFENIOPHO.GetHashCode();
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.MHNBGKJLDGB)
		{
			num ^= MHNBGKJLDGB.GetHashCode();
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NCCNKHELPKL)
		{
			num ^= NCCNKHELPKL.GetHashCode();
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IFHGNHGAPIN)
		{
			num ^= IFHGNHGAPIN.GetHashCode();
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NAOKLIALCEN)
		{
			num ^= NAOKLIALCEN.GetHashCode();
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.KFPKHHAOGPP)
		{
			num ^= KFPKHHAOGPP.GetHashCode();
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IIHECADEHNG)
		{
			num ^= IIHECADEHNG.GetHashCode();
		}
		num ^= (int)mFKJOHBNBJACase_;
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
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.MHNBGKJLDGB)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MHNBGKJLDGB);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NCCNKHELPKL)
		{
			output.WriteRawTag(18);
			output.WriteMessage(NCCNKHELPKL);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IFHGNHGAPIN)
		{
			output.WriteRawTag(26);
			output.WriteMessage(IFHGNHGAPIN);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NAOKLIALCEN)
		{
			output.WriteRawTag(34);
			output.WriteMessage(NAOKLIALCEN);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.KFPKHHAOGPP)
		{
			output.WriteRawTag(42);
			output.WriteMessage(KFPKHHAOGPP);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IIHECADEHNG)
		{
			output.WriteRawTag(50);
			output.WriteMessage(IIHECADEHNG);
		}
		if (MGMFENIOPHO.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(MGMFENIOPHO);
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
		if (MGMFENIOPHO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MGMFENIOPHO);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.MHNBGKJLDGB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHNBGKJLDGB);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NCCNKHELPKL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCCNKHELPKL);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IFHGNHGAPIN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IFHGNHGAPIN);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NAOKLIALCEN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NAOKLIALCEN);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.KFPKHHAOGPP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KFPKHHAOGPP);
		}
		if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IIHECADEHNG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IIHECADEHNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PEKNOBDHAKO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MGMFENIOPHO.Length != 0)
		{
			MGMFENIOPHO = other.MGMFENIOPHO;
		}
		switch (other.MFKJOHBNBJACase)
		{
		case MFKJOHBNBJAOneofCase.MHNBGKJLDGB:
			if (MHNBGKJLDGB == null)
			{
				MHNBGKJLDGB = new GOEOJEFKKMK();
			}
			MHNBGKJLDGB.MergeFrom(other.MHNBGKJLDGB);
			break;
		case MFKJOHBNBJAOneofCase.NCCNKHELPKL:
			if (NCCNKHELPKL == null)
			{
				NCCNKHELPKL = new BPONIDHOFPP();
			}
			NCCNKHELPKL.MergeFrom(other.NCCNKHELPKL);
			break;
		case MFKJOHBNBJAOneofCase.IFHGNHGAPIN:
			if (IFHGNHGAPIN == null)
			{
				IFHGNHGAPIN = new HFEMKNKGPNF();
			}
			IFHGNHGAPIN.MergeFrom(other.IFHGNHGAPIN);
			break;
		case MFKJOHBNBJAOneofCase.NAOKLIALCEN:
			if (NAOKLIALCEN == null)
			{
				NAOKLIALCEN = new KPMIMEPEBHH();
			}
			NAOKLIALCEN.MergeFrom(other.NAOKLIALCEN);
			break;
		case MFKJOHBNBJAOneofCase.KFPKHHAOGPP:
			if (KFPKHHAOGPP == null)
			{
				KFPKHHAOGPP = new HOFLIBJHHPC();
			}
			KFPKHHAOGPP.MergeFrom(other.KFPKHHAOGPP);
			break;
		case MFKJOHBNBJAOneofCase.IIHECADEHNG:
			if (IIHECADEHNG == null)
			{
				IIHECADEHNG = new HPDLFAOMIPI();
			}
			IIHECADEHNG.MergeFrom(other.IIHECADEHNG);
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
				GOEOJEFKKMK gOEOJEFKKMK = new GOEOJEFKKMK();
				if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.MHNBGKJLDGB)
				{
					gOEOJEFKKMK.MergeFrom(MHNBGKJLDGB);
				}
				input.ReadMessage(gOEOJEFKKMK);
				MHNBGKJLDGB = gOEOJEFKKMK;
				break;
			}
			case 18u:
			{
				BPONIDHOFPP bPONIDHOFPP = new BPONIDHOFPP();
				if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NCCNKHELPKL)
				{
					bPONIDHOFPP.MergeFrom(NCCNKHELPKL);
				}
				input.ReadMessage(bPONIDHOFPP);
				NCCNKHELPKL = bPONIDHOFPP;
				break;
			}
			case 26u:
			{
				HFEMKNKGPNF hFEMKNKGPNF = new HFEMKNKGPNF();
				if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IFHGNHGAPIN)
				{
					hFEMKNKGPNF.MergeFrom(IFHGNHGAPIN);
				}
				input.ReadMessage(hFEMKNKGPNF);
				IFHGNHGAPIN = hFEMKNKGPNF;
				break;
			}
			case 34u:
			{
				KPMIMEPEBHH kPMIMEPEBHH = new KPMIMEPEBHH();
				if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.NAOKLIALCEN)
				{
					kPMIMEPEBHH.MergeFrom(NAOKLIALCEN);
				}
				input.ReadMessage(kPMIMEPEBHH);
				NAOKLIALCEN = kPMIMEPEBHH;
				break;
			}
			case 42u:
			{
				HOFLIBJHHPC hOFLIBJHHPC = new HOFLIBJHHPC();
				if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.KFPKHHAOGPP)
				{
					hOFLIBJHHPC.MergeFrom(KFPKHHAOGPP);
				}
				input.ReadMessage(hOFLIBJHHPC);
				KFPKHHAOGPP = hOFLIBJHHPC;
				break;
			}
			case 50u:
			{
				HPDLFAOMIPI hPDLFAOMIPI = new HPDLFAOMIPI();
				if (mFKJOHBNBJACase_ == MFKJOHBNBJAOneofCase.IIHECADEHNG)
				{
					hPDLFAOMIPI.MergeFrom(IIHECADEHNG);
				}
				input.ReadMessage(hPDLFAOMIPI);
				IIHECADEHNG = hPDLFAOMIPI;
				break;
			}
			case 82u:
				MGMFENIOPHO = input.ReadString();
				break;
			}
		}
	}
}
