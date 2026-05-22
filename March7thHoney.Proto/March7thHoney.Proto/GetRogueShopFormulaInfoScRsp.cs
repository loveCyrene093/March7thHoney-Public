using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueShopFormulaInfoScRsp : IMessage<GetRogueShopFormulaInfoScRsp>, IMessage, IEquatable<GetRogueShopFormulaInfoScRsp>, IDeepCloneable<GetRogueShopFormulaInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueShopFormulaInfoScRsp> _parser = new MessageParser<GetRogueShopFormulaInfoScRsp>(() => new GetRogueShopFormulaInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ECJCCKFEFEJFieldNumber = 5;

	private GENOHIJHCDG eCJCCKFEFEJ_;

	public const int NEDPNFDHIGFFieldNumber = 9;

	private int nEDPNFDHIGF_;

	public const int CAFBAKFBNINFieldNumber = 10;

	private int cAFBAKFBNIN_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int AKOCOALDEHCFieldNumber = 14;

	private ItemCostData aKOCOALDEHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueShopFormulaInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueShopFormulaInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GENOHIJHCDG ECJCCKFEFEJ
	{
		get
		{
			return eCJCCKFEFEJ_;
		}
		set
		{
			eCJCCKFEFEJ_ = value;
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
	public GetRogueShopFormulaInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopFormulaInfoScRsp(GetRogueShopFormulaInfoScRsp other)
		: this()
	{
		eCJCCKFEFEJ_ = ((other.eCJCCKFEFEJ_ != null) ? other.eCJCCKFEFEJ_.Clone() : null);
		nEDPNFDHIGF_ = other.nEDPNFDHIGF_;
		cAFBAKFBNIN_ = other.cAFBAKFBNIN_;
		retcode_ = other.retcode_;
		aKOCOALDEHC_ = ((other.aKOCOALDEHC_ != null) ? other.aKOCOALDEHC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopFormulaInfoScRsp Clone()
	{
		return new GetRogueShopFormulaInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueShopFormulaInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueShopFormulaInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ECJCCKFEFEJ, other.ECJCCKFEFEJ))
		{
			return false;
		}
		if (NEDPNFDHIGF != other.NEDPNFDHIGF)
		{
			return false;
		}
		if (CAFBAKFBNIN != other.CAFBAKFBNIN)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(AKOCOALDEHC, other.AKOCOALDEHC))
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
		if (eCJCCKFEFEJ_ != null)
		{
			num ^= ECJCCKFEFEJ.GetHashCode();
		}
		if (NEDPNFDHIGF != 0)
		{
			num ^= NEDPNFDHIGF.GetHashCode();
		}
		if (CAFBAKFBNIN != 0)
		{
			num ^= CAFBAKFBNIN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (aKOCOALDEHC_ != null)
		{
			num ^= AKOCOALDEHC.GetHashCode();
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
		if (eCJCCKFEFEJ_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ECJCCKFEFEJ);
		}
		if (NEDPNFDHIGF != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(NEDPNFDHIGF);
		}
		if (CAFBAKFBNIN != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CAFBAKFBNIN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (aKOCOALDEHC_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AKOCOALDEHC);
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
		if (eCJCCKFEFEJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECJCCKFEFEJ);
		}
		if (NEDPNFDHIGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NEDPNFDHIGF);
		}
		if (CAFBAKFBNIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CAFBAKFBNIN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (aKOCOALDEHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AKOCOALDEHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueShopFormulaInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eCJCCKFEFEJ_ != null)
		{
			if (eCJCCKFEFEJ_ == null)
			{
				ECJCCKFEFEJ = new GENOHIJHCDG();
			}
			ECJCCKFEFEJ.MergeFrom(other.ECJCCKFEFEJ);
		}
		if (other.NEDPNFDHIGF != 0)
		{
			NEDPNFDHIGF = other.NEDPNFDHIGF;
		}
		if (other.CAFBAKFBNIN != 0)
		{
			CAFBAKFBNIN = other.CAFBAKFBNIN;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.aKOCOALDEHC_ != null)
		{
			if (aKOCOALDEHC_ == null)
			{
				AKOCOALDEHC = new ItemCostData();
			}
			AKOCOALDEHC.MergeFrom(other.AKOCOALDEHC);
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
			case 42u:
				if (eCJCCKFEFEJ_ == null)
				{
					ECJCCKFEFEJ = new GENOHIJHCDG();
				}
				input.ReadMessage(ECJCCKFEFEJ);
				break;
			case 72u:
				NEDPNFDHIGF = input.ReadInt32();
				break;
			case 80u:
				CAFBAKFBNIN = input.ReadInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (aKOCOALDEHC_ == null)
				{
					AKOCOALDEHC = new ItemCostData();
				}
				input.ReadMessage(AKOCOALDEHC);
				break;
			}
		}
	}
}
