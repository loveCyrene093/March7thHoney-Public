using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetOrigamiPropInfoCsReq : IMessage<GetOrigamiPropInfoCsReq>, IMessage, IEquatable<GetOrigamiPropInfoCsReq>, IDeepCloneable<GetOrigamiPropInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetOrigamiPropInfoCsReq> _parser = new MessageParser<GetOrigamiPropInfoCsReq>(() => new GetOrigamiPropInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MELNPBKAABIFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_mELNPBKAABI_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> mELNPBKAABI_ = new RepeatedField<uint>();

	public const int ContentIdFieldNumber = 3;

	private uint contentId_;

	public const int GFGFLIHCCODFieldNumber = 6;

	private uint gFGFLIHCCOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetOrigamiPropInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetOrigamiPropInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MELNPBKAABI => mELNPBKAABI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFGFLIHCCOD
	{
		get
		{
			return gFGFLIHCCOD_;
		}
		set
		{
			gFGFLIHCCOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetOrigamiPropInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetOrigamiPropInfoCsReq(GetOrigamiPropInfoCsReq other)
		: this()
	{
		mELNPBKAABI_ = other.mELNPBKAABI_.Clone();
		contentId_ = other.contentId_;
		gFGFLIHCCOD_ = other.gFGFLIHCCOD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetOrigamiPropInfoCsReq Clone()
	{
		return new GetOrigamiPropInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetOrigamiPropInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetOrigamiPropInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mELNPBKAABI_.Equals(other.mELNPBKAABI_))
		{
			return false;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (GFGFLIHCCOD != other.GFGFLIHCCOD)
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
		num ^= mELNPBKAABI_.GetHashCode();
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (GFGFLIHCCOD != 0)
		{
			num ^= GFGFLIHCCOD.GetHashCode();
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
		mELNPBKAABI_.WriteTo(ref output, _repeated_mELNPBKAABI_codec);
		if (ContentId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ContentId);
		}
		if (GFGFLIHCCOD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GFGFLIHCCOD);
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
		num += mELNPBKAABI_.CalculateSize(_repeated_mELNPBKAABI_codec);
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (GFGFLIHCCOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFGFLIHCCOD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetOrigamiPropInfoCsReq other)
	{
		if (other != null)
		{
			mELNPBKAABI_.Add(other.mELNPBKAABI_);
			if (other.ContentId != 0)
			{
				ContentId = other.ContentId;
			}
			if (other.GFGFLIHCCOD != 0)
			{
				GFGFLIHCCOD = other.GFGFLIHCCOD;
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
			case 8u:
			case 10u:
				mELNPBKAABI_.AddEntriesFrom(ref input, _repeated_mELNPBKAABI_codec);
				break;
			case 24u:
				ContentId = input.ReadUInt32();
				break;
			case 48u:
				GFGFLIHCCOD = input.ReadUInt32();
				break;
			}
		}
	}
}
