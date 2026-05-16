using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SettleHipplenWorkScRsp : IMessage<SettleHipplenWorkScRsp>, IMessage, IEquatable<SettleHipplenWorkScRsp>, IDeepCloneable<SettleHipplenWorkScRsp>, IBufferMessage
{
	public enum NPBHJGIEDHLOneofCase
	{
		None = 0,
		EDGOIAODJLH = 2,
		BJGDFMJDJMH = 14
	}

	private static readonly MessageParser<SettleHipplenWorkScRsp> _parser = new MessageParser<SettleHipplenWorkScRsp>(() => new SettleHipplenWorkScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LJJAJGFIGNMFieldNumber = 3;

	private DGKNDMAHMAP lJJAJGFIGNM_;

	public const int GHPINELGNNEFieldNumber = 7;

	private static readonly FieldCodec<IAMLOJCIKIH> _repeated_gHPINELGNNE_codec = FieldCodec.ForMessage(58u, IAMLOJCIKIH.Parser);

	private readonly RepeatedField<IAMLOJCIKIH> gHPINELGNNE_ = new RepeatedField<IAMLOJCIKIH>();

	public const int CLKAILDCPJCFieldNumber = 12;

	private static readonly FieldCodec<EKOIHOMFMDE> _repeated_cLKAILDCPJC_codec = FieldCodec.ForMessage(98u, EKOIHOMFMDE.Parser);

	private readonly RepeatedField<EKOIHOMFMDE> cLKAILDCPJC_ = new RepeatedField<EKOIHOMFMDE>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	public const int EDGOIAODJLHFieldNumber = 2;

	public const int BJGDFMJDJMHFieldNumber = 14;

	private object nPBHJGIEDHL_;

	private NPBHJGIEDHLOneofCase nPBHJGIEDHLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SettleHipplenWorkScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SettleHipplenWorkScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP LJJAJGFIGNM
	{
		get
		{
			return lJJAJGFIGNM_;
		}
		set
		{
			lJJAJGFIGNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IAMLOJCIKIH> GHPINELGNNE => gHPINELGNNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EKOIHOMFMDE> CLKAILDCPJC => cLKAILDCPJC_;

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
	public EOKOFFPBJME EDGOIAODJLH
	{
		get
		{
			if (nPBHJGIEDHLCase_ != NPBHJGIEDHLOneofCase.EDGOIAODJLH)
			{
				return null;
			}
			return (EOKOFFPBJME)nPBHJGIEDHL_;
		}
		set
		{
			nPBHJGIEDHL_ = value;
			nPBHJGIEDHLCase_ = ((value != null) ? NPBHJGIEDHLOneofCase.EDGOIAODJLH : NPBHJGIEDHLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OECPLDABABL BJGDFMJDJMH
	{
		get
		{
			if (nPBHJGIEDHLCase_ != NPBHJGIEDHLOneofCase.BJGDFMJDJMH)
			{
				return null;
			}
			return (OECPLDABABL)nPBHJGIEDHL_;
		}
		set
		{
			nPBHJGIEDHL_ = value;
			nPBHJGIEDHLCase_ = ((value != null) ? NPBHJGIEDHLOneofCase.BJGDFMJDJMH : NPBHJGIEDHLOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPBHJGIEDHLOneofCase NPBHJGIEDHLCase => nPBHJGIEDHLCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleHipplenWorkScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleHipplenWorkScRsp(SettleHipplenWorkScRsp other)
		: this()
	{
		lJJAJGFIGNM_ = ((other.lJJAJGFIGNM_ != null) ? other.lJJAJGFIGNM_.Clone() : null);
		gHPINELGNNE_ = other.gHPINELGNNE_.Clone();
		cLKAILDCPJC_ = other.cLKAILDCPJC_.Clone();
		retcode_ = other.retcode_;
		switch (other.NPBHJGIEDHLCase)
		{
		case NPBHJGIEDHLOneofCase.EDGOIAODJLH:
			EDGOIAODJLH = other.EDGOIAODJLH.Clone();
			break;
		case NPBHJGIEDHLOneofCase.BJGDFMJDJMH:
			BJGDFMJDJMH = other.BJGDFMJDJMH.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleHipplenWorkScRsp Clone()
	{
		return new SettleHipplenWorkScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNPBHJGIEDHL()
	{
		nPBHJGIEDHLCase_ = NPBHJGIEDHLOneofCase.None;
		nPBHJGIEDHL_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SettleHipplenWorkScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SettleHipplenWorkScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LJJAJGFIGNM, other.LJJAJGFIGNM))
		{
			return false;
		}
		if (!gHPINELGNNE_.Equals(other.gHPINELGNNE_))
		{
			return false;
		}
		if (!cLKAILDCPJC_.Equals(other.cLKAILDCPJC_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EDGOIAODJLH, other.EDGOIAODJLH))
		{
			return false;
		}
		if (!object.Equals(BJGDFMJDJMH, other.BJGDFMJDJMH))
		{
			return false;
		}
		if (NPBHJGIEDHLCase != other.NPBHJGIEDHLCase)
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
		if (lJJAJGFIGNM_ != null)
		{
			num ^= LJJAJGFIGNM.GetHashCode();
		}
		num ^= gHPINELGNNE_.GetHashCode();
		num ^= cLKAILDCPJC_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.EDGOIAODJLH)
		{
			num ^= EDGOIAODJLH.GetHashCode();
		}
		if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.BJGDFMJDJMH)
		{
			num ^= BJGDFMJDJMH.GetHashCode();
		}
		num ^= (int)nPBHJGIEDHLCase_;
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
		if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.EDGOIAODJLH)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EDGOIAODJLH);
		}
		if (lJJAJGFIGNM_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LJJAJGFIGNM);
		}
		gHPINELGNNE_.WriteTo(ref output, _repeated_gHPINELGNNE_codec);
		cLKAILDCPJC_.WriteTo(ref output, _repeated_cLKAILDCPJC_codec);
		if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.BJGDFMJDJMH)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BJGDFMJDJMH);
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
		if (lJJAJGFIGNM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJJAJGFIGNM);
		}
		num += gHPINELGNNE_.CalculateSize(_repeated_gHPINELGNNE_codec);
		num += cLKAILDCPJC_.CalculateSize(_repeated_cLKAILDCPJC_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.EDGOIAODJLH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDGOIAODJLH);
		}
		if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.BJGDFMJDJMH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BJGDFMJDJMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SettleHipplenWorkScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lJJAJGFIGNM_ != null)
		{
			if (lJJAJGFIGNM_ == null)
			{
				LJJAJGFIGNM = new DGKNDMAHMAP();
			}
			LJJAJGFIGNM.MergeFrom(other.LJJAJGFIGNM);
		}
		gHPINELGNNE_.Add(other.gHPINELGNNE_);
		cLKAILDCPJC_.Add(other.cLKAILDCPJC_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		switch (other.NPBHJGIEDHLCase)
		{
		case NPBHJGIEDHLOneofCase.EDGOIAODJLH:
			if (EDGOIAODJLH == null)
			{
				EDGOIAODJLH = new EOKOFFPBJME();
			}
			EDGOIAODJLH.MergeFrom(other.EDGOIAODJLH);
			break;
		case NPBHJGIEDHLOneofCase.BJGDFMJDJMH:
			if (BJGDFMJDJMH == null)
			{
				BJGDFMJDJMH = new OECPLDABABL();
			}
			BJGDFMJDJMH.MergeFrom(other.BJGDFMJDJMH);
			break;
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
			{
				EOKOFFPBJME eOKOFFPBJME = new EOKOFFPBJME();
				if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.EDGOIAODJLH)
				{
					eOKOFFPBJME.MergeFrom(EDGOIAODJLH);
				}
				input.ReadMessage(eOKOFFPBJME);
				EDGOIAODJLH = eOKOFFPBJME;
				break;
			}
			case 26u:
				if (lJJAJGFIGNM_ == null)
				{
					LJJAJGFIGNM = new DGKNDMAHMAP();
				}
				input.ReadMessage(LJJAJGFIGNM);
				break;
			case 58u:
				gHPINELGNNE_.AddEntriesFrom(ref input, _repeated_gHPINELGNNE_codec);
				break;
			case 98u:
				cLKAILDCPJC_.AddEntriesFrom(ref input, _repeated_cLKAILDCPJC_codec);
				break;
			case 114u:
			{
				OECPLDABABL oECPLDABABL = new OECPLDABABL();
				if (nPBHJGIEDHLCase_ == NPBHJGIEDHLOneofCase.BJGDFMJDJMH)
				{
					oECPLDABABL.MergeFrom(BJGDFMJDJMH);
				}
				input.ReadMessage(oECPLDABABL);
				BJGDFMJDJMH = oECPLDABABL;
				break;
			}
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
