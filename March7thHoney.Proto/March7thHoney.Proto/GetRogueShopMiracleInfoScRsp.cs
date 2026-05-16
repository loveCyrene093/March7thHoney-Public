using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueShopMiracleInfoScRsp : IMessage<GetRogueShopMiracleInfoScRsp>, IMessage, IEquatable<GetRogueShopMiracleInfoScRsp>, IDeepCloneable<GetRogueShopMiracleInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueShopMiracleInfoScRsp> _parser = new MessageParser<GetRogueShopMiracleInfoScRsp>(() => new GetRogueShopMiracleInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AKOCOALDEHCFieldNumber = 2;

	private ItemCostData aKOCOALDEHC_;

	public const int CAFBAKFBNINFieldNumber = 3;

	private int cAFBAKFBNIN_;

	public const int FEILNIKNPCBFieldNumber = 13;

	private IEMKPMMJLLE fEILNIKNPCB_;

	public const int NEDPNFDHIGFFieldNumber = 14;

	private int nEDPNFDHIGF_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueShopMiracleInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueShopMiracleInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData AKOCOALDEHC
	{
		get
		{
			return aKOCOALDEHC_;
		}
		set
		{
			aKOCOALDEHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CAFBAKFBNIN
	{
		get
		{
			return cAFBAKFBNIN_;
		}
		set
		{
			cAFBAKFBNIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMKPMMJLLE FEILNIKNPCB
	{
		get
		{
			return fEILNIKNPCB_;
		}
		set
		{
			fEILNIKNPCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NEDPNFDHIGF
	{
		get
		{
			return nEDPNFDHIGF_;
		}
		set
		{
			nEDPNFDHIGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopMiracleInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopMiracleInfoScRsp(GetRogueShopMiracleInfoScRsp other)
		: this()
	{
		aKOCOALDEHC_ = ((other.aKOCOALDEHC_ != null) ? other.aKOCOALDEHC_.Clone() : null);
		cAFBAKFBNIN_ = other.cAFBAKFBNIN_;
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		nEDPNFDHIGF_ = other.nEDPNFDHIGF_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopMiracleInfoScRsp Clone()
	{
		return new GetRogueShopMiracleInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueShopMiracleInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueShopMiracleInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AKOCOALDEHC, other.AKOCOALDEHC))
		{
			return false;
		}
		if (CAFBAKFBNIN != other.CAFBAKFBNIN)
		{
			return false;
		}
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
		{
			return false;
		}
		if (NEDPNFDHIGF != other.NEDPNFDHIGF)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (aKOCOALDEHC_ != null)
		{
			num ^= AKOCOALDEHC.GetHashCode();
		}
		if (CAFBAKFBNIN != 0)
		{
			num ^= CAFBAKFBNIN.GetHashCode();
		}
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
		}
		if (NEDPNFDHIGF != 0)
		{
			num ^= NEDPNFDHIGF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (aKOCOALDEHC_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AKOCOALDEHC);
		}
		if (CAFBAKFBNIN != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CAFBAKFBNIN);
		}
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(FEILNIKNPCB);
		}
		if (NEDPNFDHIGF != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(NEDPNFDHIGF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (aKOCOALDEHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AKOCOALDEHC);
		}
		if (CAFBAKFBNIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CAFBAKFBNIN);
		}
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (NEDPNFDHIGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NEDPNFDHIGF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueShopMiracleInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aKOCOALDEHC_ != null)
		{
			if (aKOCOALDEHC_ == null)
			{
				AKOCOALDEHC = new ItemCostData();
			}
			AKOCOALDEHC.MergeFrom(other.AKOCOALDEHC);
		}
		if (other.CAFBAKFBNIN != 0)
		{
			CAFBAKFBNIN = other.CAFBAKFBNIN;
		}
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new IEMKPMMJLLE();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
		}
		if (other.NEDPNFDHIGF != 0)
		{
			NEDPNFDHIGF = other.NEDPNFDHIGF;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
				if (aKOCOALDEHC_ == null)
				{
					AKOCOALDEHC = new ItemCostData();
				}
				input.ReadMessage(AKOCOALDEHC);
				break;
			case 24u:
				CAFBAKFBNIN = input.ReadInt32();
				break;
			case 106u:
				if (fEILNIKNPCB_ == null)
				{
					FEILNIKNPCB = new IEMKPMMJLLE();
				}
				input.ReadMessage(FEILNIKNPCB);
				break;
			case 112u:
				NEDPNFDHIGF = input.ReadInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
