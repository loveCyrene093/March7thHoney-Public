using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GEAPPKGNLJG : IMessage<GEAPPKGNLJG>, IMessage, IEquatable<GEAPPKGNLJG>, IDeepCloneable<GEAPPKGNLJG>, IBufferMessage
{
	private static readonly MessageParser<GEAPPKGNLJG> _parser = new MessageParser<GEAPPKGNLJG>(() => new GEAPPKGNLJG());

	private UnknownFieldSet _unknownFields;

	public const int PPPHLHADCPJFieldNumber = 1;

	private HMJGADLIONA pPPHLHADCPJ_;

	public const int MODDIBHCPPDFieldNumber = 3;

	private NMHKDLJPGIL mODDIBHCPPD_;

	public const int MJDMNDIEKHKFieldNumber = 5;

	private MotionInfo mJDMNDIEKHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GEAPPKGNLJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GEAPPKGNLJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GEAPPKGNLJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEAPPKGNLJG(GEAPPKGNLJG other)
		: this()
	{
		pPPHLHADCPJ_ = ((other.pPPHLHADCPJ_ != null) ? other.pPPHLHADCPJ_.Clone() : null);
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		mJDMNDIEKHK_ = ((other.mJDMNDIEKHK_ != null) ? other.mJDMNDIEKHK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEAPPKGNLJG Clone()
	{
		return new GEAPPKGNLJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GEAPPKGNLJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GEAPPKGNLJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PPPHLHADCPJ, other.PPPHLHADCPJ))
		{
			return false;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
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
		if (pPPHLHADCPJ_ != null)
		{
			num ^= PPPHLHADCPJ.GetHashCode();
		}
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
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
		if (pPPHLHADCPJ_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PPPHLHADCPJ);
		}
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (mJDMNDIEKHK_ != null)
		{
			output.WriteRawTag(42);
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
		if (pPPHLHADCPJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPPHLHADCPJ);
		}
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
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
	public void MergeFrom(GEAPPKGNLJG other)
	{
		if (other == null)
		{
			return;
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
			case 10u:
				if (pPPHLHADCPJ_ == null)
				{
					PPPHLHADCPJ = new HMJGADLIONA();
				}
				input.ReadMessage(PPPHLHADCPJ);
				break;
			case 26u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new NMHKDLJPGIL();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 42u:
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
