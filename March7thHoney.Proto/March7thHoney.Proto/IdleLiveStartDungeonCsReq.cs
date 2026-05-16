using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveStartDungeonCsReq : IMessage<IdleLiveStartDungeonCsReq>, IMessage, IEquatable<IdleLiveStartDungeonCsReq>, IDeepCloneable<IdleLiveStartDungeonCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveStartDungeonCsReq> _parser = new MessageParser<IdleLiveStartDungeonCsReq>(() => new IdleLiveStartDungeonCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CPOMNGJDBCLFieldNumber = 3;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_cPOMNGJDBCL_codec = FieldCodec.ForMessage(26u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> cPOMNGJDBCL_ = new RepeatedField<GKDEKJKOIJN>();

	public const int CPMGHJFAIABFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_cPMGHJFAIAB_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> cPMGHJFAIAB_ = new RepeatedField<uint>();

	public const int OICEJIMEONGFieldNumber = 14;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_oICEJIMEONG_codec = FieldCodec.ForMessage(114u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> oICEJIMEONG_ = new RepeatedField<GKDEKJKOIJN>();

	public const int TargetSideFieldNumber = 15;

	private uint targetSide_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveStartDungeonCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveStartDungeonCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> CPOMNGJDBCL => cPOMNGJDBCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CPMGHJFAIAB => cPMGHJFAIAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> OICEJIMEONG => oICEJIMEONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveStartDungeonCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveStartDungeonCsReq(IdleLiveStartDungeonCsReq other)
		: this()
	{
		cPOMNGJDBCL_ = other.cPOMNGJDBCL_.Clone();
		cPMGHJFAIAB_ = other.cPMGHJFAIAB_.Clone();
		oICEJIMEONG_ = other.oICEJIMEONG_.Clone();
		targetSide_ = other.targetSide_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveStartDungeonCsReq Clone()
	{
		return new IdleLiveStartDungeonCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveStartDungeonCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveStartDungeonCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cPOMNGJDBCL_.Equals(other.cPOMNGJDBCL_))
		{
			return false;
		}
		if (!cPMGHJFAIAB_.Equals(other.cPMGHJFAIAB_))
		{
			return false;
		}
		if (!oICEJIMEONG_.Equals(other.oICEJIMEONG_))
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
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
		num ^= cPOMNGJDBCL_.GetHashCode();
		num ^= cPMGHJFAIAB_.GetHashCode();
		num ^= oICEJIMEONG_.GetHashCode();
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
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
		cPOMNGJDBCL_.WriteTo(ref output, _repeated_cPOMNGJDBCL_codec);
		cPMGHJFAIAB_.WriteTo(ref output, _repeated_cPMGHJFAIAB_codec);
		oICEJIMEONG_.WriteTo(ref output, _repeated_oICEJIMEONG_codec);
		if (TargetSide != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(TargetSide);
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
		num += cPOMNGJDBCL_.CalculateSize(_repeated_cPOMNGJDBCL_codec);
		num += cPMGHJFAIAB_.CalculateSize(_repeated_cPMGHJFAIAB_codec);
		num += oICEJIMEONG_.CalculateSize(_repeated_oICEJIMEONG_codec);
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveStartDungeonCsReq other)
	{
		if (other != null)
		{
			cPOMNGJDBCL_.Add(other.cPOMNGJDBCL_);
			cPMGHJFAIAB_.Add(other.cPMGHJFAIAB_);
			oICEJIMEONG_.Add(other.oICEJIMEONG_);
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
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
			case 26u:
				cPOMNGJDBCL_.AddEntriesFrom(ref input, _repeated_cPOMNGJDBCL_codec);
				break;
			case 72u:
			case 74u:
				cPMGHJFAIAB_.AddEntriesFrom(ref input, _repeated_cPMGHJFAIAB_codec);
				break;
			case 114u:
				oICEJIMEONG_.AddEntriesFrom(ref input, _repeated_oICEJIMEONG_codec);
				break;
			case 120u:
				TargetSide = input.ReadUInt32();
				break;
			}
		}
	}
}
