using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KAIELJPMGHL : IMessage<KAIELJPMGHL>, IMessage, IEquatable<KAIELJPMGHL>, IDeepCloneable<KAIELJPMGHL>, IBufferMessage
{
	private static readonly MessageParser<KAIELJPMGHL> _parser = new MessageParser<KAIELJPMGHL>(() => new KAIELJPMGHL());

	private UnknownFieldSet _unknownFields;

	public const int NGEHILEENKCFieldNumber = 2;

	private uint nGEHILEENKC_;

	public const int JJOOHOADJMAFieldNumber = 3;

	private uint jJOOHOADJMA_;

	public const int PPPHLHADCPJFieldNumber = 4;

	private HMJGADLIONA pPPHLHADCPJ_;

	public const int UuidFieldNumber = 6;

	private string uuid_ = "";

	public const int MODDIBHCPPDFieldNumber = 14;

	private NMHKDLJPGIL mODDIBHCPPD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KAIELJPMGHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KAIELJPMGHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGEHILEENKC
	{
		get
		{
			return nGEHILEENKC_;
		}
		set
		{
			nGEHILEENKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJOOHOADJMA
	{
		get
		{
			return jJOOHOADJMA_;
		}
		set
		{
			jJOOHOADJMA_ = value;
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
	public string Uuid
	{
		get
		{
			return uuid_;
		}
		set
		{
			uuid_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public KAIELJPMGHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAIELJPMGHL(KAIELJPMGHL other)
		: this()
	{
		nGEHILEENKC_ = other.nGEHILEENKC_;
		jJOOHOADJMA_ = other.jJOOHOADJMA_;
		pPPHLHADCPJ_ = ((other.pPPHLHADCPJ_ != null) ? other.pPPHLHADCPJ_.Clone() : null);
		uuid_ = other.uuid_;
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAIELJPMGHL Clone()
	{
		return new KAIELJPMGHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KAIELJPMGHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KAIELJPMGHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NGEHILEENKC != other.NGEHILEENKC)
		{
			return false;
		}
		if (JJOOHOADJMA != other.JJOOHOADJMA)
		{
			return false;
		}
		if (!object.Equals(PPPHLHADCPJ, other.PPPHLHADCPJ))
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
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
		if (NGEHILEENKC != 0)
		{
			num ^= NGEHILEENKC.GetHashCode();
		}
		if (JJOOHOADJMA != 0)
		{
			num ^= JJOOHOADJMA.GetHashCode();
		}
		if (pPPHLHADCPJ_ != null)
		{
			num ^= PPPHLHADCPJ.GetHashCode();
		}
		if (Uuid.Length != 0)
		{
			num ^= Uuid.GetHashCode();
		}
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
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
		if (NGEHILEENKC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NGEHILEENKC);
		}
		if (JJOOHOADJMA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JJOOHOADJMA);
		}
		if (pPPHLHADCPJ_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PPPHLHADCPJ);
		}
		if (Uuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Uuid);
		}
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(MODDIBHCPPD);
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
		if (NGEHILEENKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGEHILEENKC);
		}
		if (JJOOHOADJMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJOOHOADJMA);
		}
		if (pPPHLHADCPJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPPHLHADCPJ);
		}
		if (Uuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uuid);
		}
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KAIELJPMGHL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NGEHILEENKC != 0)
		{
			NGEHILEENKC = other.NGEHILEENKC;
		}
		if (other.JJOOHOADJMA != 0)
		{
			JJOOHOADJMA = other.JJOOHOADJMA;
		}
		if (other.pPPHLHADCPJ_ != null)
		{
			if (pPPHLHADCPJ_ == null)
			{
				PPPHLHADCPJ = new HMJGADLIONA();
			}
			PPPHLHADCPJ.MergeFrom(other.PPPHLHADCPJ);
		}
		if (other.Uuid.Length != 0)
		{
			Uuid = other.Uuid;
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new NMHKDLJPGIL();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
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
				NGEHILEENKC = input.ReadUInt32();
				break;
			case 24u:
				JJOOHOADJMA = input.ReadUInt32();
				break;
			case 34u:
				if (pPPHLHADCPJ_ == null)
				{
					PPPHLHADCPJ = new HMJGADLIONA();
				}
				input.ReadMessage(PPPHLHADCPJ);
				break;
			case 50u:
				Uuid = input.ReadString();
				break;
			case 114u:
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new NMHKDLJPGIL();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			}
		}
	}
}
