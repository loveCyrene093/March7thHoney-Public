using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DoGachaScRsp : IMessage<DoGachaScRsp>, IMessage, IEquatable<DoGachaScRsp>, IDeepCloneable<DoGachaScRsp>, IBufferMessage
{
	private static readonly MessageParser<DoGachaScRsp> _parser = new MessageParser<DoGachaScRsp>(() => new DoGachaScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GachaIdFieldNumber = 2;

	private uint gachaId_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int OKFNNHNLBOOFieldNumber = 5;

	private uint oKFNNHNLBOO_;

	public const int EHKFPMJCEMIFieldNumber = 8;

	private uint eHKFPMJCEMI_;

	public const int NJJKICNOFCLFieldNumber = 9;

	private uint nJJKICNOFCL_;

	public const int GachaNumFieldNumber = 10;

	private uint gachaNum_;

	public const int GachaItemListFieldNumber = 11;

	private static readonly FieldCodec<GachaItem> _repeated_gachaItemList_codec = FieldCodec.ForMessage(90u, GachaItem.Parser);

	private readonly RepeatedField<GachaItem> gachaItemList_ = new RepeatedField<GachaItem>();

	public const int CeilingNumFieldNumber = 13;

	private uint ceilingNum_;

	public const int FJIBOAGDNDGFieldNumber = 14;

	private uint fJIBOAGDNDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DoGachaScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DoGachaScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
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
	public uint OKFNNHNLBOO
	{
		get
		{
			return oKFNNHNLBOO_;
		}
		set
		{
			oKFNNHNLBOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHKFPMJCEMI
	{
		get
		{
			return eHKFPMJCEMI_;
		}
		set
		{
			eHKFPMJCEMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJJKICNOFCL
	{
		get
		{
			return nJJKICNOFCL_;
		}
		set
		{
			nJJKICNOFCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaNum
	{
		get
		{
			return gachaNum_;
		}
		set
		{
			gachaNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaItem> GachaItemList => gachaItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CeilingNum
	{
		get
		{
			return ceilingNum_;
		}
		set
		{
			ceilingNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJIBOAGDNDG
	{
		get
		{
			return fJIBOAGDNDG_;
		}
		set
		{
			fJIBOAGDNDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaScRsp(DoGachaScRsp other)
		: this()
	{
		gachaId_ = other.gachaId_;
		retcode_ = other.retcode_;
		oKFNNHNLBOO_ = other.oKFNNHNLBOO_;
		eHKFPMJCEMI_ = other.eHKFPMJCEMI_;
		nJJKICNOFCL_ = other.nJJKICNOFCL_;
		gachaNum_ = other.gachaNum_;
		gachaItemList_ = other.gachaItemList_.Clone();
		ceilingNum_ = other.ceilingNum_;
		fJIBOAGDNDG_ = other.fJIBOAGDNDG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaScRsp Clone()
	{
		return new DoGachaScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DoGachaScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DoGachaScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OKFNNHNLBOO != other.OKFNNHNLBOO)
		{
			return false;
		}
		if (EHKFPMJCEMI != other.EHKFPMJCEMI)
		{
			return false;
		}
		if (NJJKICNOFCL != other.NJJKICNOFCL)
		{
			return false;
		}
		if (GachaNum != other.GachaNum)
		{
			return false;
		}
		if (!gachaItemList_.Equals(other.gachaItemList_))
		{
			return false;
		}
		if (CeilingNum != other.CeilingNum)
		{
			return false;
		}
		if (FJIBOAGDNDG != other.FJIBOAGDNDG)
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
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OKFNNHNLBOO != 0)
		{
			num ^= OKFNNHNLBOO.GetHashCode();
		}
		if (EHKFPMJCEMI != 0)
		{
			num ^= EHKFPMJCEMI.GetHashCode();
		}
		if (NJJKICNOFCL != 0)
		{
			num ^= NJJKICNOFCL.GetHashCode();
		}
		if (GachaNum != 0)
		{
			num ^= GachaNum.GetHashCode();
		}
		num ^= gachaItemList_.GetHashCode();
		if (CeilingNum != 0)
		{
			num ^= CeilingNum.GetHashCode();
		}
		if (FJIBOAGDNDG != 0)
		{
			num ^= FJIBOAGDNDG.GetHashCode();
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
		if (GachaId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GachaId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (OKFNNHNLBOO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OKFNNHNLBOO);
		}
		if (EHKFPMJCEMI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EHKFPMJCEMI);
		}
		if (NJJKICNOFCL != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NJJKICNOFCL);
		}
		if (GachaNum != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GachaNum);
		}
		gachaItemList_.WriteTo(ref output, _repeated_gachaItemList_codec);
		if (CeilingNum != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CeilingNum);
		}
		if (FJIBOAGDNDG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FJIBOAGDNDG);
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
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OKFNNHNLBOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKFNNHNLBOO);
		}
		if (EHKFPMJCEMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHKFPMJCEMI);
		}
		if (NJJKICNOFCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJJKICNOFCL);
		}
		if (GachaNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaNum);
		}
		num += gachaItemList_.CalculateSize(_repeated_gachaItemList_codec);
		if (CeilingNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CeilingNum);
		}
		if (FJIBOAGDNDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJIBOAGDNDG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DoGachaScRsp other)
	{
		if (other != null)
		{
			if (other.GachaId != 0)
			{
				GachaId = other.GachaId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.OKFNNHNLBOO != 0)
			{
				OKFNNHNLBOO = other.OKFNNHNLBOO;
			}
			if (other.EHKFPMJCEMI != 0)
			{
				EHKFPMJCEMI = other.EHKFPMJCEMI;
			}
			if (other.NJJKICNOFCL != 0)
			{
				NJJKICNOFCL = other.NJJKICNOFCL;
			}
			if (other.GachaNum != 0)
			{
				GachaNum = other.GachaNum;
			}
			gachaItemList_.Add(other.gachaItemList_);
			if (other.CeilingNum != 0)
			{
				CeilingNum = other.CeilingNum;
			}
			if (other.FJIBOAGDNDG != 0)
			{
				FJIBOAGDNDG = other.FJIBOAGDNDG;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				GachaId = input.ReadUInt32();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				OKFNNHNLBOO = input.ReadUInt32();
				break;
			case 64u:
				EHKFPMJCEMI = input.ReadUInt32();
				break;
			case 72u:
				NJJKICNOFCL = input.ReadUInt32();
				break;
			case 80u:
				GachaNum = input.ReadUInt32();
				break;
			case 90u:
				gachaItemList_.AddEntriesFrom(ref input, _repeated_gachaItemList_codec);
				break;
			case 104u:
				CeilingNum = input.ReadUInt32();
				break;
			case 112u:
				FJIBOAGDNDG = input.ReadUInt32();
				break;
			}
		}
	}
}
