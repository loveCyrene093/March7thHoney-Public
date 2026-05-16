using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetElfRestaurantDataScRsp : IMessage<GetElfRestaurantDataScRsp>, IMessage, IEquatable<GetElfRestaurantDataScRsp>, IDeepCloneable<GetElfRestaurantDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetElfRestaurantDataScRsp> _parser = new MessageParser<GetElfRestaurantDataScRsp>(() => new GetElfRestaurantDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int LIBKPMMGGLJFieldNumber = 3;

	private AFOECDHJPII lIBKPMMGGLJ_;

	public const int BNJBFPCDAFEFieldNumber = 7;

	private BCNJMGCEGAA bNJBFPCDAFE_;

	public const int OCGNOACLJAJFieldNumber = 8;

	private NCPCAIKAJGD oCGNOACLJAJ_;

	public const int DCIDLIFMNLAFieldNumber = 11;

	private BBCLLNPDIAH dCIDLIFMNLA_;

	public const int KIIINGJLEHGFieldNumber = 12;

	private MFLDHBJNEOO kIIINGJLEHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetElfRestaurantDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetElfRestaurantDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AFOECDHJPII LIBKPMMGGLJ
	{
		get
		{
			return lIBKPMMGGLJ_;
		}
		set
		{
			lIBKPMMGGLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCNJMGCEGAA BNJBFPCDAFE
	{
		get
		{
			return bNJBFPCDAFE_;
		}
		set
		{
			bNJBFPCDAFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCPCAIKAJGD OCGNOACLJAJ
	{
		get
		{
			return oCGNOACLJAJ_;
		}
		set
		{
			oCGNOACLJAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBCLLNPDIAH DCIDLIFMNLA
	{
		get
		{
			return dCIDLIFMNLA_;
		}
		set
		{
			dCIDLIFMNLA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFLDHBJNEOO KIIINGJLEHG
	{
		get
		{
			return kIIINGJLEHG_;
		}
		set
		{
			kIIINGJLEHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetElfRestaurantDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetElfRestaurantDataScRsp(GetElfRestaurantDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		lIBKPMMGGLJ_ = ((other.lIBKPMMGGLJ_ != null) ? other.lIBKPMMGGLJ_.Clone() : null);
		bNJBFPCDAFE_ = ((other.bNJBFPCDAFE_ != null) ? other.bNJBFPCDAFE_.Clone() : null);
		oCGNOACLJAJ_ = ((other.oCGNOACLJAJ_ != null) ? other.oCGNOACLJAJ_.Clone() : null);
		dCIDLIFMNLA_ = ((other.dCIDLIFMNLA_ != null) ? other.dCIDLIFMNLA_.Clone() : null);
		kIIINGJLEHG_ = ((other.kIIINGJLEHG_ != null) ? other.kIIINGJLEHG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetElfRestaurantDataScRsp Clone()
	{
		return new GetElfRestaurantDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetElfRestaurantDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetElfRestaurantDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(LIBKPMMGGLJ, other.LIBKPMMGGLJ))
		{
			return false;
		}
		if (!object.Equals(BNJBFPCDAFE, other.BNJBFPCDAFE))
		{
			return false;
		}
		if (!object.Equals(OCGNOACLJAJ, other.OCGNOACLJAJ))
		{
			return false;
		}
		if (!object.Equals(DCIDLIFMNLA, other.DCIDLIFMNLA))
		{
			return false;
		}
		if (!object.Equals(KIIINGJLEHG, other.KIIINGJLEHG))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (lIBKPMMGGLJ_ != null)
		{
			num ^= LIBKPMMGGLJ.GetHashCode();
		}
		if (bNJBFPCDAFE_ != null)
		{
			num ^= BNJBFPCDAFE.GetHashCode();
		}
		if (oCGNOACLJAJ_ != null)
		{
			num ^= OCGNOACLJAJ.GetHashCode();
		}
		if (dCIDLIFMNLA_ != null)
		{
			num ^= DCIDLIFMNLA.GetHashCode();
		}
		if (kIIINGJLEHG_ != null)
		{
			num ^= KIIINGJLEHG.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (lIBKPMMGGLJ_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LIBKPMMGGLJ);
		}
		if (bNJBFPCDAFE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BNJBFPCDAFE);
		}
		if (oCGNOACLJAJ_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(OCGNOACLJAJ);
		}
		if (dCIDLIFMNLA_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DCIDLIFMNLA);
		}
		if (kIIINGJLEHG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(KIIINGJLEHG);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (lIBKPMMGGLJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LIBKPMMGGLJ);
		}
		if (bNJBFPCDAFE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNJBFPCDAFE);
		}
		if (oCGNOACLJAJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OCGNOACLJAJ);
		}
		if (dCIDLIFMNLA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCIDLIFMNLA);
		}
		if (kIIINGJLEHG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KIIINGJLEHG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetElfRestaurantDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.lIBKPMMGGLJ_ != null)
		{
			if (lIBKPMMGGLJ_ == null)
			{
				LIBKPMMGGLJ = new AFOECDHJPII();
			}
			LIBKPMMGGLJ.MergeFrom(other.LIBKPMMGGLJ);
		}
		if (other.bNJBFPCDAFE_ != null)
		{
			if (bNJBFPCDAFE_ == null)
			{
				BNJBFPCDAFE = new BCNJMGCEGAA();
			}
			BNJBFPCDAFE.MergeFrom(other.BNJBFPCDAFE);
		}
		if (other.oCGNOACLJAJ_ != null)
		{
			if (oCGNOACLJAJ_ == null)
			{
				OCGNOACLJAJ = new NCPCAIKAJGD();
			}
			OCGNOACLJAJ.MergeFrom(other.OCGNOACLJAJ);
		}
		if (other.dCIDLIFMNLA_ != null)
		{
			if (dCIDLIFMNLA_ == null)
			{
				DCIDLIFMNLA = new BBCLLNPDIAH();
			}
			DCIDLIFMNLA.MergeFrom(other.DCIDLIFMNLA);
		}
		if (other.kIIINGJLEHG_ != null)
		{
			if (kIIINGJLEHG_ == null)
			{
				KIIINGJLEHG = new MFLDHBJNEOO();
			}
			KIIINGJLEHG.MergeFrom(other.KIIINGJLEHG);
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
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (lIBKPMMGGLJ_ == null)
				{
					LIBKPMMGGLJ = new AFOECDHJPII();
				}
				input.ReadMessage(LIBKPMMGGLJ);
				break;
			case 58u:
				if (bNJBFPCDAFE_ == null)
				{
					BNJBFPCDAFE = new BCNJMGCEGAA();
				}
				input.ReadMessage(BNJBFPCDAFE);
				break;
			case 66u:
				if (oCGNOACLJAJ_ == null)
				{
					OCGNOACLJAJ = new NCPCAIKAJGD();
				}
				input.ReadMessage(OCGNOACLJAJ);
				break;
			case 90u:
				if (dCIDLIFMNLA_ == null)
				{
					DCIDLIFMNLA = new BBCLLNPDIAH();
				}
				input.ReadMessage(DCIDLIFMNLA);
				break;
			case 98u:
				if (kIIINGJLEHG_ == null)
				{
					KIIINGJLEHG = new MFLDHBJNEOO();
				}
				input.ReadMessage(KIIINGJLEHG);
				break;
			}
		}
	}
}
