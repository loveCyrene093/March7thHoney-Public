using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FKPMOKOJNHP : IMessage<FKPMOKOJNHP>, IMessage, IEquatable<FKPMOKOJNHP>, IDeepCloneable<FKPMOKOJNHP>, IBufferMessage
{
	private static readonly MessageParser<FKPMOKOJNHP> _parser = new MessageParser<FKPMOKOJNHP>(() => new FKPMOKOJNHP());

	private UnknownFieldSet _unknownFields;

	public const int ADGDMDNMCIKFieldNumber = 2;

	private LNLMPKALPEF aDGDMDNMCIK_;

	public const int MAONLHBKOFKFieldNumber = 3;

	private uint mAONLHBKOFK_;

	public const int BILLHIPOKEPFieldNumber = 6;

	private OFPGJKEDKEB bILLHIPOKEP_;

	public const int MBHAHNEJGACFieldNumber = 10;

	private AJNICOHFJGC mBHAHNEJGAC_;

	public const int NJFAMMMDDIKFieldNumber = 11;

	private MEGIHBEMOAB nJFAMMMDDIK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FKPMOKOJNHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FKPMOKOJNHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNLMPKALPEF ADGDMDNMCIK
	{
		get
		{
			return aDGDMDNMCIK_;
		}
		set
		{
			aDGDMDNMCIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAONLHBKOFK
	{
		get
		{
			return mAONLHBKOFK_;
		}
		set
		{
			mAONLHBKOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFPGJKEDKEB BILLHIPOKEP
	{
		get
		{
			return bILLHIPOKEP_;
		}
		set
		{
			bILLHIPOKEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJNICOHFJGC MBHAHNEJGAC
	{
		get
		{
			return mBHAHNEJGAC_;
		}
		set
		{
			mBHAHNEJGAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEGIHBEMOAB NJFAMMMDDIK
	{
		get
		{
			return nJFAMMMDDIK_;
		}
		set
		{
			nJFAMMMDDIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKPMOKOJNHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKPMOKOJNHP(FKPMOKOJNHP other)
		: this()
	{
		aDGDMDNMCIK_ = ((other.aDGDMDNMCIK_ != null) ? other.aDGDMDNMCIK_.Clone() : null);
		mAONLHBKOFK_ = other.mAONLHBKOFK_;
		bILLHIPOKEP_ = ((other.bILLHIPOKEP_ != null) ? other.bILLHIPOKEP_.Clone() : null);
		mBHAHNEJGAC_ = ((other.mBHAHNEJGAC_ != null) ? other.mBHAHNEJGAC_.Clone() : null);
		nJFAMMMDDIK_ = ((other.nJFAMMMDDIK_ != null) ? other.nJFAMMMDDIK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKPMOKOJNHP Clone()
	{
		return new FKPMOKOJNHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FKPMOKOJNHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FKPMOKOJNHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ADGDMDNMCIK, other.ADGDMDNMCIK))
		{
			return false;
		}
		if (MAONLHBKOFK != other.MAONLHBKOFK)
		{
			return false;
		}
		if (!object.Equals(BILLHIPOKEP, other.BILLHIPOKEP))
		{
			return false;
		}
		if (!object.Equals(MBHAHNEJGAC, other.MBHAHNEJGAC))
		{
			return false;
		}
		if (!object.Equals(NJFAMMMDDIK, other.NJFAMMMDDIK))
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
		if (aDGDMDNMCIK_ != null)
		{
			num ^= ADGDMDNMCIK.GetHashCode();
		}
		if (MAONLHBKOFK != 0)
		{
			num ^= MAONLHBKOFK.GetHashCode();
		}
		if (bILLHIPOKEP_ != null)
		{
			num ^= BILLHIPOKEP.GetHashCode();
		}
		if (mBHAHNEJGAC_ != null)
		{
			num ^= MBHAHNEJGAC.GetHashCode();
		}
		if (nJFAMMMDDIK_ != null)
		{
			num ^= NJFAMMMDDIK.GetHashCode();
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
		if (aDGDMDNMCIK_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ADGDMDNMCIK);
		}
		if (MAONLHBKOFK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MAONLHBKOFK);
		}
		if (bILLHIPOKEP_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BILLHIPOKEP);
		}
		if (mBHAHNEJGAC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(MBHAHNEJGAC);
		}
		if (nJFAMMMDDIK_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(NJFAMMMDDIK);
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
		if (aDGDMDNMCIK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ADGDMDNMCIK);
		}
		if (MAONLHBKOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAONLHBKOFK);
		}
		if (bILLHIPOKEP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BILLHIPOKEP);
		}
		if (mBHAHNEJGAC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBHAHNEJGAC);
		}
		if (nJFAMMMDDIK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NJFAMMMDDIK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FKPMOKOJNHP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aDGDMDNMCIK_ != null)
		{
			if (aDGDMDNMCIK_ == null)
			{
				ADGDMDNMCIK = new LNLMPKALPEF();
			}
			ADGDMDNMCIK.MergeFrom(other.ADGDMDNMCIK);
		}
		if (other.MAONLHBKOFK != 0)
		{
			MAONLHBKOFK = other.MAONLHBKOFK;
		}
		if (other.bILLHIPOKEP_ != null)
		{
			if (bILLHIPOKEP_ == null)
			{
				BILLHIPOKEP = new OFPGJKEDKEB();
			}
			BILLHIPOKEP.MergeFrom(other.BILLHIPOKEP);
		}
		if (other.mBHAHNEJGAC_ != null)
		{
			if (mBHAHNEJGAC_ == null)
			{
				MBHAHNEJGAC = new AJNICOHFJGC();
			}
			MBHAHNEJGAC.MergeFrom(other.MBHAHNEJGAC);
		}
		if (other.nJFAMMMDDIK_ != null)
		{
			if (nJFAMMMDDIK_ == null)
			{
				NJFAMMMDDIK = new MEGIHBEMOAB();
			}
			NJFAMMMDDIK.MergeFrom(other.NJFAMMMDDIK);
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
			case 18u:
				if (aDGDMDNMCIK_ == null)
				{
					ADGDMDNMCIK = new LNLMPKALPEF();
				}
				input.ReadMessage(ADGDMDNMCIK);
				break;
			case 24u:
				MAONLHBKOFK = input.ReadUInt32();
				break;
			case 50u:
				if (bILLHIPOKEP_ == null)
				{
					BILLHIPOKEP = new OFPGJKEDKEB();
				}
				input.ReadMessage(BILLHIPOKEP);
				break;
			case 82u:
				if (mBHAHNEJGAC_ == null)
				{
					MBHAHNEJGAC = new AJNICOHFJGC();
				}
				input.ReadMessage(MBHAHNEJGAC);
				break;
			case 90u:
				if (nJFAMMMDDIK_ == null)
				{
					NJFAMMMDDIK = new MEGIHBEMOAB();
				}
				input.ReadMessage(NJFAMMMDDIK);
				break;
			}
		}
	}
}
