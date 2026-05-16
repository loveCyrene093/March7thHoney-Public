using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KGABJENCFDC : IMessage<KGABJENCFDC>, IMessage, IEquatable<KGABJENCFDC>, IDeepCloneable<KGABJENCFDC>, IBufferMessage
{
	private static readonly MessageParser<KGABJENCFDC> _parser = new MessageParser<KGABJENCFDC>(() => new KGABJENCFDC());

	private UnknownFieldSet _unknownFields;

	public const int MAEFNEBLIJMFieldNumber = 1;

	private OAMOHFJKCAA mAEFNEBLIJM_;

	public const int FHDPEMCABIEFieldNumber = 2;

	private uint fHDPEMCABIE_;

	public const int PendingActionFieldNumber = 4;

	private EPPJHNIHAFL pendingAction_;

	public const int EHNEEMCKIBKFieldNumber = 8;

	private uint eHNEEMCKIBK_;

	public const int MDILDJMPNGHFieldNumber = 11;

	private string mDILDJMPNGH_ = "";

	public const int BNODOMPMCBEFieldNumber = 12;

	private uint bNODOMPMCBE_;

	public const int LOIDOGEENOBFieldNumber = 14;

	private uint lOIDOGEENOB_;

	public const int IMIBFEHPDDIFieldNumber = 15;

	private EDIKJLBEAEA iMIBFEHPDDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KGABJENCFDC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KGABJENCFDCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMOHFJKCAA MAEFNEBLIJM
	{
		get
		{
			return mAEFNEBLIJM_;
		}
		set
		{
			mAEFNEBLIJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHDPEMCABIE
	{
		get
		{
			return fHDPEMCABIE_;
		}
		set
		{
			fHDPEMCABIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPPJHNIHAFL PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHNEEMCKIBK
	{
		get
		{
			return eHNEEMCKIBK_;
		}
		set
		{
			eHNEEMCKIBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MDILDJMPNGH
	{
		get
		{
			return mDILDJMPNGH_;
		}
		set
		{
			mDILDJMPNGH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNODOMPMCBE
	{
		get
		{
			return bNODOMPMCBE_;
		}
		set
		{
			bNODOMPMCBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIDOGEENOB
	{
		get
		{
			return lOIDOGEENOB_;
		}
		set
		{
			lOIDOGEENOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDIKJLBEAEA IMIBFEHPDDI
	{
		get
		{
			return iMIBFEHPDDI_;
		}
		set
		{
			iMIBFEHPDDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGABJENCFDC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGABJENCFDC(KGABJENCFDC other)
		: this()
	{
		mAEFNEBLIJM_ = ((other.mAEFNEBLIJM_ != null) ? other.mAEFNEBLIJM_.Clone() : null);
		fHDPEMCABIE_ = other.fHDPEMCABIE_;
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		eHNEEMCKIBK_ = other.eHNEEMCKIBK_;
		mDILDJMPNGH_ = other.mDILDJMPNGH_;
		bNODOMPMCBE_ = other.bNODOMPMCBE_;
		lOIDOGEENOB_ = other.lOIDOGEENOB_;
		iMIBFEHPDDI_ = ((other.iMIBFEHPDDI_ != null) ? other.iMIBFEHPDDI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGABJENCFDC Clone()
	{
		return new KGABJENCFDC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KGABJENCFDC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KGABJENCFDC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MAEFNEBLIJM, other.MAEFNEBLIJM))
		{
			return false;
		}
		if (FHDPEMCABIE != other.FHDPEMCABIE)
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (EHNEEMCKIBK != other.EHNEEMCKIBK)
		{
			return false;
		}
		if (MDILDJMPNGH != other.MDILDJMPNGH)
		{
			return false;
		}
		if (BNODOMPMCBE != other.BNODOMPMCBE)
		{
			return false;
		}
		if (LOIDOGEENOB != other.LOIDOGEENOB)
		{
			return false;
		}
		if (!object.Equals(IMIBFEHPDDI, other.IMIBFEHPDDI))
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
		if (mAEFNEBLIJM_ != null)
		{
			num ^= MAEFNEBLIJM.GetHashCode();
		}
		if (FHDPEMCABIE != 0)
		{
			num ^= FHDPEMCABIE.GetHashCode();
		}
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (EHNEEMCKIBK != 0)
		{
			num ^= EHNEEMCKIBK.GetHashCode();
		}
		if (MDILDJMPNGH.Length != 0)
		{
			num ^= MDILDJMPNGH.GetHashCode();
		}
		if (BNODOMPMCBE != 0)
		{
			num ^= BNODOMPMCBE.GetHashCode();
		}
		if (LOIDOGEENOB != 0)
		{
			num ^= LOIDOGEENOB.GetHashCode();
		}
		if (iMIBFEHPDDI_ != null)
		{
			num ^= IMIBFEHPDDI.GetHashCode();
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
		if (mAEFNEBLIJM_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MAEFNEBLIJM);
		}
		if (FHDPEMCABIE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FHDPEMCABIE);
		}
		if (pendingAction_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PendingAction);
		}
		if (EHNEEMCKIBK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EHNEEMCKIBK);
		}
		if (MDILDJMPNGH.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(MDILDJMPNGH);
		}
		if (BNODOMPMCBE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BNODOMPMCBE);
		}
		if (LOIDOGEENOB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LOIDOGEENOB);
		}
		if (iMIBFEHPDDI_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(IMIBFEHPDDI);
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
		if (mAEFNEBLIJM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAEFNEBLIJM);
		}
		if (FHDPEMCABIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHDPEMCABIE);
		}
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (EHNEEMCKIBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHNEEMCKIBK);
		}
		if (MDILDJMPNGH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MDILDJMPNGH);
		}
		if (BNODOMPMCBE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNODOMPMCBE);
		}
		if (LOIDOGEENOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIDOGEENOB);
		}
		if (iMIBFEHPDDI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMIBFEHPDDI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KGABJENCFDC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mAEFNEBLIJM_ != null)
		{
			if (mAEFNEBLIJM_ == null)
			{
				MAEFNEBLIJM = new OAMOHFJKCAA();
			}
			MAEFNEBLIJM.MergeFrom(other.MAEFNEBLIJM);
		}
		if (other.FHDPEMCABIE != 0)
		{
			FHDPEMCABIE = other.FHDPEMCABIE;
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new EPPJHNIHAFL();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		if (other.EHNEEMCKIBK != 0)
		{
			EHNEEMCKIBK = other.EHNEEMCKIBK;
		}
		if (other.MDILDJMPNGH.Length != 0)
		{
			MDILDJMPNGH = other.MDILDJMPNGH;
		}
		if (other.BNODOMPMCBE != 0)
		{
			BNODOMPMCBE = other.BNODOMPMCBE;
		}
		if (other.LOIDOGEENOB != 0)
		{
			LOIDOGEENOB = other.LOIDOGEENOB;
		}
		if (other.iMIBFEHPDDI_ != null)
		{
			if (iMIBFEHPDDI_ == null)
			{
				IMIBFEHPDDI = new EDIKJLBEAEA();
			}
			IMIBFEHPDDI.MergeFrom(other.IMIBFEHPDDI);
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
				if (mAEFNEBLIJM_ == null)
				{
					MAEFNEBLIJM = new OAMOHFJKCAA();
				}
				input.ReadMessage(MAEFNEBLIJM);
				break;
			case 16u:
				FHDPEMCABIE = input.ReadUInt32();
				break;
			case 34u:
				if (pendingAction_ == null)
				{
					PendingAction = new EPPJHNIHAFL();
				}
				input.ReadMessage(PendingAction);
				break;
			case 64u:
				EHNEEMCKIBK = input.ReadUInt32();
				break;
			case 90u:
				MDILDJMPNGH = input.ReadString();
				break;
			case 96u:
				BNODOMPMCBE = input.ReadUInt32();
				break;
			case 112u:
				LOIDOGEENOB = input.ReadUInt32();
				break;
			case 122u:
				if (iMIBFEHPDDI_ == null)
				{
					IMIBFEHPDDI = new EDIKJLBEAEA();
				}
				input.ReadMessage(IMIBFEHPDDI);
				break;
			}
		}
	}
}
