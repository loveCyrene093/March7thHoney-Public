using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueShopBuffInfoScRsp : IMessage<GetRogueShopBuffInfoScRsp>, IMessage, IEquatable<GetRogueShopBuffInfoScRsp>, IDeepCloneable<GetRogueShopBuffInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueShopBuffInfoScRsp> _parser = new MessageParser<GetRogueShopBuffInfoScRsp>(() => new GetRogueShopBuffInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CAFBAKFBNINFieldNumber = 3;

	private int cAFBAKFBNIN_;

	public const int AKOCOALDEHCFieldNumber = 4;

	private ItemCostData aKOCOALDEHC_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int NEDPNFDHIGFFieldNumber = 11;

	private int nEDPNFDHIGF_;

	public const int HKGKNEKKJHBFieldNumber = 14;

	private PHMBJKMKMDK hKGKNEKKJHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueShopBuffInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueShopBuffInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PHMBJKMKMDK HKGKNEKKJHB
	{
		get
		{
			return hKGKNEKKJHB_;
		}
		set
		{
			hKGKNEKKJHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopBuffInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopBuffInfoScRsp(GetRogueShopBuffInfoScRsp other)
		: this()
	{
		cAFBAKFBNIN_ = other.cAFBAKFBNIN_;
		aKOCOALDEHC_ = ((other.aKOCOALDEHC_ != null) ? other.aKOCOALDEHC_.Clone() : null);
		retcode_ = other.retcode_;
		nEDPNFDHIGF_ = other.nEDPNFDHIGF_;
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopBuffInfoScRsp Clone()
	{
		return new GetRogueShopBuffInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueShopBuffInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueShopBuffInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CAFBAKFBNIN != other.CAFBAKFBNIN)
		{
			return false;
		}
		if (!object.Equals(AKOCOALDEHC, other.AKOCOALDEHC))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (NEDPNFDHIGF != other.NEDPNFDHIGF)
		{
			return false;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
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
		if (CAFBAKFBNIN != 0)
		{
			num ^= CAFBAKFBNIN.GetHashCode();
		}
		if (aKOCOALDEHC_ != null)
		{
			num ^= AKOCOALDEHC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (NEDPNFDHIGF != 0)
		{
			num ^= NEDPNFDHIGF.GetHashCode();
		}
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
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
		if (CAFBAKFBNIN != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CAFBAKFBNIN);
		}
		if (aKOCOALDEHC_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AKOCOALDEHC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (NEDPNFDHIGF != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(NEDPNFDHIGF);
		}
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HKGKNEKKJHB);
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
		if (CAFBAKFBNIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CAFBAKFBNIN);
		}
		if (aKOCOALDEHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AKOCOALDEHC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (NEDPNFDHIGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NEDPNFDHIGF);
		}
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueShopBuffInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CAFBAKFBNIN != 0)
		{
			CAFBAKFBNIN = other.CAFBAKFBNIN;
		}
		if (other.aKOCOALDEHC_ != null)
		{
			if (aKOCOALDEHC_ == null)
			{
				AKOCOALDEHC = new ItemCostData();
			}
			AKOCOALDEHC.MergeFrom(other.AKOCOALDEHC);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.NEDPNFDHIGF != 0)
		{
			NEDPNFDHIGF = other.NEDPNFDHIGF;
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new PHMBJKMKMDK();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
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
			case 24u:
				CAFBAKFBNIN = input.ReadInt32();
				break;
			case 34u:
				if (aKOCOALDEHC_ == null)
				{
					AKOCOALDEHC = new ItemCostData();
				}
				input.ReadMessage(AKOCOALDEHC);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				NEDPNFDHIGF = input.ReadInt32();
				break;
			case 114u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new PHMBJKMKMDK();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			}
		}
	}
}
