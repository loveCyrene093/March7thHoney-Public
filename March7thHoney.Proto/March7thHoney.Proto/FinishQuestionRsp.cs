using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishQuestionRsp : IMessage<FinishQuestionRsp>, IMessage, IEquatable<FinishQuestionRsp>, IDeepCloneable<FinishQuestionRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishQuestionRsp> _parser = new MessageParser<FinishQuestionRsp>(() => new FinishQuestionRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int KOEDCMICKNJFieldNumber = 7;

	private uint kOEDCMICKNJ_;

	public const int MLDBDNCCJDDFieldNumber = 11;

	private uint mLDBDNCCJDD_;

	public const int CBOJNKCBEDHFieldNumber = 13;

	private uint cBOJNKCBEDH_;

	public const int OFOCDHEPMOIFieldNumber = 15;

	private bool oFOCDHEPMOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishQuestionRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishQuestionRspReflection.Descriptor.MessageTypes[0];

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
	public uint KOEDCMICKNJ
	{
		get
		{
			return kOEDCMICKNJ_;
		}
		set
		{
			kOEDCMICKNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLDBDNCCJDD
	{
		get
		{
			return mLDBDNCCJDD_;
		}
		set
		{
			mLDBDNCCJDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CBOJNKCBEDH
	{
		get
		{
			return cBOJNKCBEDH_;
		}
		set
		{
			cBOJNKCBEDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OFOCDHEPMOI
	{
		get
		{
			return oFOCDHEPMOI_;
		}
		set
		{
			oFOCDHEPMOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishQuestionRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishQuestionRsp(FinishQuestionRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		kOEDCMICKNJ_ = other.kOEDCMICKNJ_;
		mLDBDNCCJDD_ = other.mLDBDNCCJDD_;
		cBOJNKCBEDH_ = other.cBOJNKCBEDH_;
		oFOCDHEPMOI_ = other.oFOCDHEPMOI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishQuestionRsp Clone()
	{
		return new FinishQuestionRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishQuestionRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishQuestionRsp other)
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
		if (KOEDCMICKNJ != other.KOEDCMICKNJ)
		{
			return false;
		}
		if (MLDBDNCCJDD != other.MLDBDNCCJDD)
		{
			return false;
		}
		if (CBOJNKCBEDH != other.CBOJNKCBEDH)
		{
			return false;
		}
		if (OFOCDHEPMOI != other.OFOCDHEPMOI)
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
		if (KOEDCMICKNJ != 0)
		{
			num ^= KOEDCMICKNJ.GetHashCode();
		}
		if (MLDBDNCCJDD != 0)
		{
			num ^= MLDBDNCCJDD.GetHashCode();
		}
		if (CBOJNKCBEDH != 0)
		{
			num ^= CBOJNKCBEDH.GetHashCode();
		}
		if (OFOCDHEPMOI)
		{
			num ^= OFOCDHEPMOI.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (KOEDCMICKNJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KOEDCMICKNJ);
		}
		if (MLDBDNCCJDD != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MLDBDNCCJDD);
		}
		if (CBOJNKCBEDH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CBOJNKCBEDH);
		}
		if (OFOCDHEPMOI)
		{
			output.WriteRawTag(120);
			output.WriteBool(OFOCDHEPMOI);
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
		if (KOEDCMICKNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOEDCMICKNJ);
		}
		if (MLDBDNCCJDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLDBDNCCJDD);
		}
		if (CBOJNKCBEDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBOJNKCBEDH);
		}
		if (OFOCDHEPMOI)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishQuestionRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.KOEDCMICKNJ != 0)
			{
				KOEDCMICKNJ = other.KOEDCMICKNJ;
			}
			if (other.MLDBDNCCJDD != 0)
			{
				MLDBDNCCJDD = other.MLDBDNCCJDD;
			}
			if (other.CBOJNKCBEDH != 0)
			{
				CBOJNKCBEDH = other.CBOJNKCBEDH;
			}
			if (other.OFOCDHEPMOI)
			{
				OFOCDHEPMOI = other.OFOCDHEPMOI;
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 56u:
				KOEDCMICKNJ = input.ReadUInt32();
				break;
			case 88u:
				MLDBDNCCJDD = input.ReadUInt32();
				break;
			case 104u:
				CBOJNKCBEDH = input.ReadUInt32();
				break;
			case 120u:
				OFOCDHEPMOI = input.ReadBool();
				break;
			}
		}
	}
}
