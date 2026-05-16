using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveReplaceTeamCsReq : IMessage<IdleLiveReplaceTeamCsReq>, IMessage, IEquatable<IdleLiveReplaceTeamCsReq>, IDeepCloneable<IdleLiveReplaceTeamCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveReplaceTeamCsReq> _parser = new MessageParser<IdleLiveReplaceTeamCsReq>(() => new IdleLiveReplaceTeamCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IFPABHCDKFLFieldNumber = 7;

	private uint iFPABHCDKFL_;

	public const int OICEJIMEONGFieldNumber = 9;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_oICEJIMEONG_codec = FieldCodec.ForMessage(74u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> oICEJIMEONG_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveReplaceTeamCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveReplaceTeamCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IFPABHCDKFL
	{
		get
		{
			return iFPABHCDKFL_;
		}
		set
		{
			iFPABHCDKFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> OICEJIMEONG => oICEJIMEONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveReplaceTeamCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveReplaceTeamCsReq(IdleLiveReplaceTeamCsReq other)
		: this()
	{
		iFPABHCDKFL_ = other.iFPABHCDKFL_;
		oICEJIMEONG_ = other.oICEJIMEONG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveReplaceTeamCsReq Clone()
	{
		return new IdleLiveReplaceTeamCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveReplaceTeamCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveReplaceTeamCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IFPABHCDKFL != other.IFPABHCDKFL)
		{
			return false;
		}
		if (!oICEJIMEONG_.Equals(other.oICEJIMEONG_))
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
		if (IFPABHCDKFL != 0)
		{
			num ^= IFPABHCDKFL.GetHashCode();
		}
		num ^= oICEJIMEONG_.GetHashCode();
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
		if (IFPABHCDKFL != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IFPABHCDKFL);
		}
		oICEJIMEONG_.WriteTo(ref output, _repeated_oICEJIMEONG_codec);
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
		if (IFPABHCDKFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IFPABHCDKFL);
		}
		num += oICEJIMEONG_.CalculateSize(_repeated_oICEJIMEONG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveReplaceTeamCsReq other)
	{
		if (other != null)
		{
			if (other.IFPABHCDKFL != 0)
			{
				IFPABHCDKFL = other.IFPABHCDKFL;
			}
			oICEJIMEONG_.Add(other.oICEJIMEONG_);
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
			case 56u:
				IFPABHCDKFL = input.ReadUInt32();
				break;
			case 74u:
				oICEJIMEONG_.AddEntriesFrom(ref input, _repeated_oICEJIMEONG_codec);
				break;
			}
		}
	}
}
