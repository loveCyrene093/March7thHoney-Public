using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LFPNDKKDEKN : IMessage<LFPNDKKDEKN>, IMessage, IEquatable<LFPNDKKDEKN>, IDeepCloneable<LFPNDKKDEKN>, IBufferMessage
{
	private static readonly MessageParser<LFPNDKKDEKN> _parser = new MessageParser<LFPNDKKDEKN>(() => new LFPNDKKDEKN());

	private UnknownFieldSet _unknownFields;

	public const int NDAHPKNFCLBFieldNumber = 1;

	private AGJNFOCANCM nDAHPKNFCLB_;

	public const int AFMAIGAFCEHFieldNumber = 2;

	private NGLKDCCLFGB aFMAIGAFCEH_;

	public const int CHBLEDMCNMHFieldNumber = 3;

	private FHIHLCIILAM cHBLEDMCNMH_;

	public const int FDPEHDOFCIGFieldNumber = 4;

	private CCGMLKGIDGC fDPEHDOFCIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LFPNDKKDEKN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LFPNDKKDEKNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGJNFOCANCM NDAHPKNFCLB
	{
		get
		{
			return nDAHPKNFCLB_;
		}
		set
		{
			nDAHPKNFCLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGLKDCCLFGB AFMAIGAFCEH
	{
		get
		{
			return aFMAIGAFCEH_;
		}
		set
		{
			aFMAIGAFCEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHIHLCIILAM CHBLEDMCNMH
	{
		get
		{
			return cHBLEDMCNMH_;
		}
		set
		{
			cHBLEDMCNMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGMLKGIDGC FDPEHDOFCIG
	{
		get
		{
			return fDPEHDOFCIG_;
		}
		set
		{
			fDPEHDOFCIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFPNDKKDEKN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFPNDKKDEKN(LFPNDKKDEKN other)
		: this()
	{
		nDAHPKNFCLB_ = ((other.nDAHPKNFCLB_ != null) ? other.nDAHPKNFCLB_.Clone() : null);
		aFMAIGAFCEH_ = ((other.aFMAIGAFCEH_ != null) ? other.aFMAIGAFCEH_.Clone() : null);
		cHBLEDMCNMH_ = ((other.cHBLEDMCNMH_ != null) ? other.cHBLEDMCNMH_.Clone() : null);
		fDPEHDOFCIG_ = ((other.fDPEHDOFCIG_ != null) ? other.fDPEHDOFCIG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFPNDKKDEKN Clone()
	{
		return new LFPNDKKDEKN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LFPNDKKDEKN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LFPNDKKDEKN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NDAHPKNFCLB, other.NDAHPKNFCLB))
		{
			return false;
		}
		if (!object.Equals(AFMAIGAFCEH, other.AFMAIGAFCEH))
		{
			return false;
		}
		if (!object.Equals(CHBLEDMCNMH, other.CHBLEDMCNMH))
		{
			return false;
		}
		if (!object.Equals(FDPEHDOFCIG, other.FDPEHDOFCIG))
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
		if (nDAHPKNFCLB_ != null)
		{
			num ^= NDAHPKNFCLB.GetHashCode();
		}
		if (aFMAIGAFCEH_ != null)
		{
			num ^= AFMAIGAFCEH.GetHashCode();
		}
		if (cHBLEDMCNMH_ != null)
		{
			num ^= CHBLEDMCNMH.GetHashCode();
		}
		if (fDPEHDOFCIG_ != null)
		{
			num ^= FDPEHDOFCIG.GetHashCode();
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
		if (nDAHPKNFCLB_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(NDAHPKNFCLB);
		}
		if (aFMAIGAFCEH_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AFMAIGAFCEH);
		}
		if (cHBLEDMCNMH_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CHBLEDMCNMH);
		}
		if (fDPEHDOFCIG_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FDPEHDOFCIG);
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
		if (nDAHPKNFCLB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDAHPKNFCLB);
		}
		if (aFMAIGAFCEH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFMAIGAFCEH);
		}
		if (cHBLEDMCNMH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CHBLEDMCNMH);
		}
		if (fDPEHDOFCIG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FDPEHDOFCIG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LFPNDKKDEKN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nDAHPKNFCLB_ != null)
		{
			if (nDAHPKNFCLB_ == null)
			{
				NDAHPKNFCLB = new AGJNFOCANCM();
			}
			NDAHPKNFCLB.MergeFrom(other.NDAHPKNFCLB);
		}
		if (other.aFMAIGAFCEH_ != null)
		{
			if (aFMAIGAFCEH_ == null)
			{
				AFMAIGAFCEH = new NGLKDCCLFGB();
			}
			AFMAIGAFCEH.MergeFrom(other.AFMAIGAFCEH);
		}
		if (other.cHBLEDMCNMH_ != null)
		{
			if (cHBLEDMCNMH_ == null)
			{
				CHBLEDMCNMH = new FHIHLCIILAM();
			}
			CHBLEDMCNMH.MergeFrom(other.CHBLEDMCNMH);
		}
		if (other.fDPEHDOFCIG_ != null)
		{
			if (fDPEHDOFCIG_ == null)
			{
				FDPEHDOFCIG = new CCGMLKGIDGC();
			}
			FDPEHDOFCIG.MergeFrom(other.FDPEHDOFCIG);
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
				if (nDAHPKNFCLB_ == null)
				{
					NDAHPKNFCLB = new AGJNFOCANCM();
				}
				input.ReadMessage(NDAHPKNFCLB);
				break;
			case 18u:
				if (aFMAIGAFCEH_ == null)
				{
					AFMAIGAFCEH = new NGLKDCCLFGB();
				}
				input.ReadMessage(AFMAIGAFCEH);
				break;
			case 26u:
				if (cHBLEDMCNMH_ == null)
				{
					CHBLEDMCNMH = new FHIHLCIILAM();
				}
				input.ReadMessage(CHBLEDMCNMH);
				break;
			case 34u:
				if (fDPEHDOFCIG_ == null)
				{
					FDPEHDOFCIG = new CCGMLKGIDGC();
				}
				input.ReadMessage(FDPEHDOFCIG);
				break;
			}
		}
	}
}
