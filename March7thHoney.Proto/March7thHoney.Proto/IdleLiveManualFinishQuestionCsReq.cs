using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveManualFinishQuestionCsReq : IMessage<IdleLiveManualFinishQuestionCsReq>, IMessage, IEquatable<IdleLiveManualFinishQuestionCsReq>, IDeepCloneable<IdleLiveManualFinishQuestionCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveManualFinishQuestionCsReq> _parser = new MessageParser<IdleLiveManualFinishQuestionCsReq>(() => new IdleLiveManualFinishQuestionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KOEDCMICKNJFieldNumber = 3;

	private uint kOEDCMICKNJ_;

	public const int OFOCDHEPMOIFieldNumber = 7;

	private bool oFOCDHEPMOI_;

	public const int CBOJNKCBEDHFieldNumber = 12;

	private uint cBOJNKCBEDH_;

	public const int MLDBDNCCJDDFieldNumber = 15;

	private uint mLDBDNCCJDD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveManualFinishQuestionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveManualFinishQuestionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public IdleLiveManualFinishQuestionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveManualFinishQuestionCsReq(IdleLiveManualFinishQuestionCsReq other)
		: this()
	{
		kOEDCMICKNJ_ = other.kOEDCMICKNJ_;
		oFOCDHEPMOI_ = other.oFOCDHEPMOI_;
		cBOJNKCBEDH_ = other.cBOJNKCBEDH_;
		mLDBDNCCJDD_ = other.mLDBDNCCJDD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveManualFinishQuestionCsReq Clone()
	{
		return new IdleLiveManualFinishQuestionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveManualFinishQuestionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveManualFinishQuestionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KOEDCMICKNJ != other.KOEDCMICKNJ)
		{
			return false;
		}
		if (OFOCDHEPMOI != other.OFOCDHEPMOI)
		{
			return false;
		}
		if (CBOJNKCBEDH != other.CBOJNKCBEDH)
		{
			return false;
		}
		if (MLDBDNCCJDD != other.MLDBDNCCJDD)
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
		if (KOEDCMICKNJ != 0)
		{
			num ^= KOEDCMICKNJ.GetHashCode();
		}
		if (OFOCDHEPMOI)
		{
			num ^= OFOCDHEPMOI.GetHashCode();
		}
		if (CBOJNKCBEDH != 0)
		{
			num ^= CBOJNKCBEDH.GetHashCode();
		}
		if (MLDBDNCCJDD != 0)
		{
			num ^= MLDBDNCCJDD.GetHashCode();
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
		if (KOEDCMICKNJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KOEDCMICKNJ);
		}
		if (OFOCDHEPMOI)
		{
			output.WriteRawTag(56);
			output.WriteBool(OFOCDHEPMOI);
		}
		if (CBOJNKCBEDH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CBOJNKCBEDH);
		}
		if (MLDBDNCCJDD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MLDBDNCCJDD);
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
		if (KOEDCMICKNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOEDCMICKNJ);
		}
		if (OFOCDHEPMOI)
		{
			num += 2;
		}
		if (CBOJNKCBEDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CBOJNKCBEDH);
		}
		if (MLDBDNCCJDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLDBDNCCJDD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveManualFinishQuestionCsReq other)
	{
		if (other != null)
		{
			if (other.KOEDCMICKNJ != 0)
			{
				KOEDCMICKNJ = other.KOEDCMICKNJ;
			}
			if (other.OFOCDHEPMOI)
			{
				OFOCDHEPMOI = other.OFOCDHEPMOI;
			}
			if (other.CBOJNKCBEDH != 0)
			{
				CBOJNKCBEDH = other.CBOJNKCBEDH;
			}
			if (other.MLDBDNCCJDD != 0)
			{
				MLDBDNCCJDD = other.MLDBDNCCJDD;
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
			case 24u:
				KOEDCMICKNJ = input.ReadUInt32();
				break;
			case 56u:
				OFOCDHEPMOI = input.ReadBool();
				break;
			case 96u:
				CBOJNKCBEDH = input.ReadUInt32();
				break;
			case 120u:
				MLDBDNCCJDD = input.ReadUInt32();
				break;
			}
		}
	}
}
