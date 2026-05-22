using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MFKKGOCBACJ : IMessage<MFKKGOCBACJ>, IMessage, IEquatable<MFKKGOCBACJ>, IDeepCloneable<MFKKGOCBACJ>, IBufferMessage
{
	private static readonly MessageParser<MFKKGOCBACJ> _parser = new MessageParser<MFKKGOCBACJ>(() => new MFKKGOCBACJ());

	private UnknownFieldSet _unknownFields;

	public const int PJMLJPAPIIKFieldNumber = 2;

	private uint pJMLJPAPIIK_;

	public const int FBOGMBOKPHJFieldNumber = 3;

	private IPFAGFAPCCD fBOGMBOKPHJ_;

	public const int PJNFFBKCGEMFieldNumber = 6;

	private uint pJNFFBKCGEM_;

	public const int MJDMNDIEKHKFieldNumber = 9;

	private MotionInfo mJDMNDIEKHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MFKKGOCBACJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MFKKGOCBACJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJMLJPAPIIK
	{
		get
		{
			return pJMLJPAPIIK_;
		}
		set
		{
			pJMLJPAPIIK_ = value;
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
	public MotionInfo MJDMNDIEKHK
	{
		get
		{
			return mJDMNDIEKHK_;
		}
		set
		{
			mJDMNDIEKHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFKKGOCBACJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFKKGOCBACJ(MFKKGOCBACJ other)
		: this()
	{
		pJMLJPAPIIK_ = other.pJMLJPAPIIK_;
		fBOGMBOKPHJ_ = other.fBOGMBOKPHJ_;
		pJNFFBKCGEM_ = other.pJNFFBKCGEM_;
		mJDMNDIEKHK_ = ((other.mJDMNDIEKHK_ != null) ? other.mJDMNDIEKHK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFKKGOCBACJ Clone()
	{
		return new MFKKGOCBACJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MFKKGOCBACJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MFKKGOCBACJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJMLJPAPIIK != other.PJMLJPAPIIK)
		{
			return false;
		}
		if (FBOGMBOKPHJ != other.FBOGMBOKPHJ)
		{
			return false;
		}
		if (PJNFFBKCGEM != other.PJNFFBKCGEM)
		{
			return false;
		}
		if (!object.Equals(MJDMNDIEKHK, other.MJDMNDIEKHK))
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
		if (PJMLJPAPIIK != 0)
		{
			num ^= PJMLJPAPIIK.GetHashCode();
		}
		if (FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			num ^= FBOGMBOKPHJ.GetHashCode();
		}
		if (PJNFFBKCGEM != 0)
		{
			num ^= PJNFFBKCGEM.GetHashCode();
		}
		if (mJDMNDIEKHK_ != null)
		{
			num ^= MJDMNDIEKHK.GetHashCode();
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
		if (PJMLJPAPIIK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PJMLJPAPIIK);
		}
		if (FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)FBOGMBOKPHJ);
		}
		if (PJNFFBKCGEM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PJNFFBKCGEM);
		}
		if (mJDMNDIEKHK_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MJDMNDIEKHK);
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
		if (PJMLJPAPIIK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJMLJPAPIIK);
		}
		if (FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FBOGMBOKPHJ);
		}
		if (PJNFFBKCGEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJNFFBKCGEM);
		}
		if (mJDMNDIEKHK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MJDMNDIEKHK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MFKKGOCBACJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PJMLJPAPIIK != 0)
		{
			PJMLJPAPIIK = other.PJMLJPAPIIK;
		}
		if (other.FBOGMBOKPHJ != IPFAGFAPCCD.Pcpdhelpkem)
		{
			FBOGMBOKPHJ = other.FBOGMBOKPHJ;
		}
		if (other.PJNFFBKCGEM != 0)
		{
			PJNFFBKCGEM = other.PJNFFBKCGEM;
		}
		if (other.mJDMNDIEKHK_ != null)
		{
			if (mJDMNDIEKHK_ == null)
			{
				MJDMNDIEKHK = new MotionInfo();
			}
			MJDMNDIEKHK.MergeFrom(other.MJDMNDIEKHK);
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
			case 16u:
				PJMLJPAPIIK = input.ReadUInt32();
				break;
			case 24u:
				FBOGMBOKPHJ = (IPFAGFAPCCD)input.ReadEnum();
				break;
			case 48u:
				PJNFFBKCGEM = input.ReadUInt32();
				break;
			case 74u:
				if (mJDMNDIEKHK_ == null)
				{
					MJDMNDIEKHK = new MotionInfo();
				}
				input.ReadMessage(MJDMNDIEKHK);
				break;
			}
		}
	}
}
