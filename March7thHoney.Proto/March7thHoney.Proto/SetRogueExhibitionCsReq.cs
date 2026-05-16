using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetRogueExhibitionCsReq : IMessage<SetRogueExhibitionCsReq>, IMessage, IEquatable<SetRogueExhibitionCsReq>, IDeepCloneable<SetRogueExhibitionCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetRogueExhibitionCsReq> _parser = new MessageParser<SetRogueExhibitionCsReq>(() => new SetRogueExhibitionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MGPNBMFJCDAFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_mGPNBMFJCDA_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> mGPNBMFJCDA_ = new RepeatedField<uint>();

	public const int EDMCDIFHFBAFieldNumber = 2;

	private static readonly FieldCodec<AGLNLHOBDKI> _repeated_eDMCDIFHFBA_codec = FieldCodec.ForEnum(18u, (AGLNLHOBDKI x) => (int)x, (int x) => (AGLNLHOBDKI)x);

	private readonly RepeatedField<AGLNLHOBDKI> eDMCDIFHFBA_ = new RepeatedField<AGLNLHOBDKI>();

	public const int AKECJCPOLCPFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aKECJCPOLCP_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aKECJCPOLCP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetRogueExhibitionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetRogueExhibitionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MGPNBMFJCDA => mGPNBMFJCDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AGLNLHOBDKI> EDMCDIFHFBA => eDMCDIFHFBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AKECJCPOLCP => aKECJCPOLCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueExhibitionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueExhibitionCsReq(SetRogueExhibitionCsReq other)
		: this()
	{
		mGPNBMFJCDA_ = other.mGPNBMFJCDA_.Clone();
		eDMCDIFHFBA_ = other.eDMCDIFHFBA_.Clone();
		aKECJCPOLCP_ = other.aKECJCPOLCP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueExhibitionCsReq Clone()
	{
		return new SetRogueExhibitionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetRogueExhibitionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetRogueExhibitionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mGPNBMFJCDA_.Equals(other.mGPNBMFJCDA_))
		{
			return false;
		}
		if (!eDMCDIFHFBA_.Equals(other.eDMCDIFHFBA_))
		{
			return false;
		}
		if (!aKECJCPOLCP_.Equals(other.aKECJCPOLCP_))
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
		num ^= mGPNBMFJCDA_.GetHashCode();
		num ^= eDMCDIFHFBA_.GetHashCode();
		num ^= aKECJCPOLCP_.GetHashCode();
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
		mGPNBMFJCDA_.WriteTo(ref output, _repeated_mGPNBMFJCDA_codec);
		eDMCDIFHFBA_.WriteTo(ref output, _repeated_eDMCDIFHFBA_codec);
		aKECJCPOLCP_.WriteTo(ref output, _repeated_aKECJCPOLCP_codec);
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
		num += mGPNBMFJCDA_.CalculateSize(_repeated_mGPNBMFJCDA_codec);
		num += eDMCDIFHFBA_.CalculateSize(_repeated_eDMCDIFHFBA_codec);
		num += aKECJCPOLCP_.CalculateSize(_repeated_aKECJCPOLCP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetRogueExhibitionCsReq other)
	{
		if (other != null)
		{
			mGPNBMFJCDA_.Add(other.mGPNBMFJCDA_);
			eDMCDIFHFBA_.Add(other.eDMCDIFHFBA_);
			aKECJCPOLCP_.Add(other.aKECJCPOLCP_);
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
			case 8u:
			case 10u:
				mGPNBMFJCDA_.AddEntriesFrom(ref input, _repeated_mGPNBMFJCDA_codec);
				break;
			case 16u:
			case 18u:
				eDMCDIFHFBA_.AddEntriesFrom(ref input, _repeated_eDMCDIFHFBA_codec);
				break;
			case 24u:
			case 26u:
				aKECJCPOLCP_.AddEntriesFrom(ref input, _repeated_aKECJCPOLCP_codec);
				break;
			}
		}
	}
}
