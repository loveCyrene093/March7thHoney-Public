using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NLPPCFGFFDE : IMessage<NLPPCFGFFDE>, IMessage, IEquatable<NLPPCFGFFDE>, IDeepCloneable<NLPPCFGFFDE>, IBufferMessage
{
	private static readonly MessageParser<NLPPCFGFFDE> _parser = new MessageParser<NLPPCFGFFDE>(() => new NLPPCFGFFDE());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 6;

	private uint areaId_;

	public const int PanelIdFieldNumber = 9;

	private uint panelId_;

	public const int BHILBIJCDOEFieldNumber = 10;

	private OFBNFNFGDFJ bHILBIJCDOE_;

	public const int BNOCEPKMPGKFieldNumber = 14;

	private DGDHBAGEOOI bNOCEPKMPGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NLPPCFGFFDE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NLPPCFGFFDEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFBNFNFGDFJ BHILBIJCDOE
	{
		get
		{
			return bHILBIJCDOE_;
		}
		set
		{
			bHILBIJCDOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGDHBAGEOOI BNOCEPKMPGK
	{
		get
		{
			return bNOCEPKMPGK_;
		}
		set
		{
			bNOCEPKMPGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPCFGFFDE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPCFGFFDE(NLPPCFGFFDE other)
		: this()
	{
		areaId_ = other.areaId_;
		panelId_ = other.panelId_;
		bHILBIJCDOE_ = ((other.bHILBIJCDOE_ != null) ? other.bHILBIJCDOE_.Clone() : null);
		bNOCEPKMPGK_ = ((other.bNOCEPKMPGK_ != null) ? other.bNOCEPKMPGK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPCFGFFDE Clone()
	{
		return new NLPPCFGFFDE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NLPPCFGFFDE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NLPPCFGFFDE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (!object.Equals(BHILBIJCDOE, other.BHILBIJCDOE))
		{
			return false;
		}
		if (!object.Equals(BNOCEPKMPGK, other.BNOCEPKMPGK))
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (bHILBIJCDOE_ != null)
		{
			num ^= BHILBIJCDOE.GetHashCode();
		}
		if (bNOCEPKMPGK_ != null)
		{
			num ^= BNOCEPKMPGK.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AreaId);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PanelId);
		}
		if (bHILBIJCDOE_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(BHILBIJCDOE);
		}
		if (bNOCEPKMPGK_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BNOCEPKMPGK);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (bHILBIJCDOE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BHILBIJCDOE);
		}
		if (bNOCEPKMPGK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNOCEPKMPGK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NLPPCFGFFDE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
		}
		if (other.PanelId != 0)
		{
			PanelId = other.PanelId;
		}
		if (other.bHILBIJCDOE_ != null)
		{
			if (bHILBIJCDOE_ == null)
			{
				BHILBIJCDOE = new OFBNFNFGDFJ();
			}
			BHILBIJCDOE.MergeFrom(other.BHILBIJCDOE);
		}
		if (other.bNOCEPKMPGK_ != null)
		{
			if (bNOCEPKMPGK_ == null)
			{
				BNOCEPKMPGK = new DGDHBAGEOOI();
			}
			BNOCEPKMPGK.MergeFrom(other.BNOCEPKMPGK);
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
			case 48u:
				AreaId = input.ReadUInt32();
				break;
			case 72u:
				PanelId = input.ReadUInt32();
				break;
			case 82u:
				if (bHILBIJCDOE_ == null)
				{
					BHILBIJCDOE = new OFBNFNFGDFJ();
				}
				input.ReadMessage(BHILBIJCDOE);
				break;
			case 114u:
				if (bNOCEPKMPGK_ == null)
				{
					BNOCEPKMPGK = new DGDHBAGEOOI();
				}
				input.ReadMessage(BNOCEPKMPGK);
				break;
			}
		}
	}
}
