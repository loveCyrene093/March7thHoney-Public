using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NHFOGDPBOHN : IMessage<NHFOGDPBOHN>, IMessage, IEquatable<NHFOGDPBOHN>, IDeepCloneable<NHFOGDPBOHN>, IBufferMessage
{
	private static readonly MessageParser<NHFOGDPBOHN> _parser = new MessageParser<NHFOGDPBOHN>(() => new NHFOGDPBOHN());

	private UnknownFieldSet _unknownFields;

	public const int NFFABMJOODEFieldNumber = 2;

	private KMLCENLAGMN nFFABMJOODE_;

	public const int OutsideRelicListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_outsideRelicList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> outsideRelicList_ = new RepeatedField<uint>();

	public const int InsideRelicListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_insideRelicList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> insideRelicList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NHFOGDPBOHN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NHFOGDPBOHNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMLCENLAGMN NFFABMJOODE
	{
		get
		{
			return nFFABMJOODE_;
		}
		set
		{
			nFFABMJOODE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OutsideRelicList => outsideRelicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> InsideRelicList => insideRelicList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFOGDPBOHN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFOGDPBOHN(NHFOGDPBOHN other)
		: this()
	{
		nFFABMJOODE_ = other.nFFABMJOODE_;
		outsideRelicList_ = other.outsideRelicList_.Clone();
		insideRelicList_ = other.insideRelicList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFOGDPBOHN Clone()
	{
		return new NHFOGDPBOHN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NHFOGDPBOHN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NHFOGDPBOHN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NFFABMJOODE != other.NFFABMJOODE)
		{
			return false;
		}
		if (!outsideRelicList_.Equals(other.outsideRelicList_))
		{
			return false;
		}
		if (!insideRelicList_.Equals(other.insideRelicList_))
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
		if (NFFABMJOODE != KMLCENLAGMN.Pcpdhelpkem)
		{
			num ^= NFFABMJOODE.GetHashCode();
		}
		num ^= outsideRelicList_.GetHashCode();
		num ^= insideRelicList_.GetHashCode();
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
		if (NFFABMJOODE != KMLCENLAGMN.Pcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)NFFABMJOODE);
		}
		outsideRelicList_.WriteTo(ref output, _repeated_outsideRelicList_codec);
		insideRelicList_.WriteTo(ref output, _repeated_insideRelicList_codec);
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
		if (NFFABMJOODE != KMLCENLAGMN.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NFFABMJOODE);
		}
		num += outsideRelicList_.CalculateSize(_repeated_outsideRelicList_codec);
		num += insideRelicList_.CalculateSize(_repeated_insideRelicList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NHFOGDPBOHN other)
	{
		if (other != null)
		{
			if (other.NFFABMJOODE != KMLCENLAGMN.Pcpdhelpkem)
			{
				NFFABMJOODE = other.NFFABMJOODE;
			}
			outsideRelicList_.Add(other.outsideRelicList_);
			insideRelicList_.Add(other.insideRelicList_);
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
				NFFABMJOODE = (KMLCENLAGMN)input.ReadEnum();
				break;
			case 48u:
			case 50u:
				outsideRelicList_.AddEntriesFrom(ref input, _repeated_outsideRelicList_codec);
				break;
			case 88u:
			case 90u:
				insideRelicList_.AddEntriesFrom(ref input, _repeated_insideRelicList_codec);
				break;
			}
		}
	}
}
