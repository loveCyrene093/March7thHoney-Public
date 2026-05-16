using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFIHIBFBAJH : IMessage<KFIHIBFBAJH>, IMessage, IEquatable<KFIHIBFBAJH>, IDeepCloneable<KFIHIBFBAJH>, IBufferMessage
{
	private static readonly MessageParser<KFIHIBFBAJH> _parser = new MessageParser<KFIHIBFBAJH>(() => new KFIHIBFBAJH());

	private UnknownFieldSet _unknownFields;

	public const int PJNFFBKCGEMFieldNumber = 4;

	private uint pJNFFBKCGEM_;

	public const int PPPHLHADCPJFieldNumber = 7;

	private HMJGADLIONA pPPHLHADCPJ_;

	public const int MODDIBHCPPDFieldNumber = 9;

	private NMHKDLJPGIL mODDIBHCPPD_;

	public const int FBOGMBOKPHJFieldNumber = 11;

	private IPFAGFAPCCD fBOGMBOKPHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFIHIBFBAJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFIHIBFBAJHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJNFFBKCGEM
	{
		get
		{
			return pJNFFBKCGEM_;
		}
		set
		{
			pJNFFBKCGEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGADLIONA PPPHLHADCPJ
	{
		get
		{
			return pPPHLHADCPJ_;
		}
		set
		{
			pPPHLHADCPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMHKDLJPGIL MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPFAGFAPCCD FBOGMBOKPHJ
	{
		get
		{
			return fBOGMBOKPHJ_;
		}
		set
		{
			fBOGMBOKPHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFIHIBFBAJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFIHIBFBAJH(KFIHIBFBAJH other)
		: this()
	{
		pJNFFBKCGEM_ = other.pJNFFBKCGEM_;
		pPPHLHADCPJ_ = ((other.pPPHLHADCPJ_ != null) ? other.pPPHLHADCPJ_.Clone() : null);
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		fBOGMBOKPHJ_ = other.fBOGMBOKPHJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFIHIBFBAJH Clone()
	{
		return new KFIHIBFBAJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFIHIBFBAJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFIHIBFBAJH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJNFFBKCGEM != other.PJNFFBKCGEM)
		{
			return false;
		}
		if (!object.Equals(PPPHLHADCPJ, other.PPPHLHADCPJ))
		{
			return false;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
		{
			return false;
		}
		if (FBOGMBOKPHJ != other.FBOGMBOKPHJ)
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
		if (PJNFFBKCGEM != 0)
		{
			num ^= PJNFFBKCGEM.GetHashCode();
		}
		if (pPPHLHADCPJ_ != null)
		{
			num ^= PPPHLHADCPJ.GetHashCode();
		}
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
		}
		if (FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			num ^= FBOGMBOKPHJ.GetHashCode();
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
		if (PJNFFBKCGEM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PJNFFBKCGEM);
		}
		if (pPPHLHADCPJ_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PPPHLHADCPJ);
		}
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)FBOGMBOKPHJ);
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
		if (PJNFFBKCGEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJNFFBKCGEM);
		}
		if (pPPHLHADCPJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPPHLHADCPJ);
		}
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FBOGMBOKPHJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFIHIBFBAJH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PJNFFBKCGEM != 0)
		{
			PJNFFBKCGEM = other.PJNFFBKCGEM;
		}
		if (other.pPPHLHADCPJ_ != null)
		{
			if (pPPHLHADCPJ_ == null)
			{
				PPPHLHADCPJ = new HMJGADLIONA();
			}
			PPPHLHADCPJ.MergeFrom(other.PPPHLHADCPJ);
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new NMHKDLJPGIL();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
		}
		if (other.FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			FBOGMBOKPHJ = other.FBOGMBOKPHJ;
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
			case 32u:
				PJNFFBKCGEM = input.ReadUInt32();
				break;
			case 58u:
				if (pPPHLHADCPJ_ == null)
				{
					PPPHLHADCPJ = new HMJGADLIONA();
				}
				input.ReadMessage(PPPHLHADCPJ);
				break;
			case 74u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new NMHKDLJPGIL();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 88u:
				FBOGMBOKPHJ = (IPFAGFAPCCD)input.ReadEnum();
				break;
			}
		}
	}
}
