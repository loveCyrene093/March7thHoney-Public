using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartNodeBattleScRsp : IMessage<StartNodeBattleScRsp>, IMessage, IEquatable<StartNodeBattleScRsp>, IDeepCloneable<StartNodeBattleScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartNodeBattleScRsp> _parser = new MessageParser<StartNodeBattleScRsp>(() => new StartNodeBattleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GIHHBJMAGOCFieldNumber = 5;

	private uint gIHHBJMAGOC_;

	public const int OICEJIMEONGFieldNumber = 7;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_oICEJIMEONG_codec = FieldCodec.ForMessage(58u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> oICEJIMEONG_ = new RepeatedField<GKDEKJKOIJN>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartNodeBattleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartNodeBattleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIHHBJMAGOC
	{
		get
		{
			return gIHHBJMAGOC_;
		}
		set
		{
			gIHHBJMAGOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> OICEJIMEONG => oICEJIMEONG_;

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
	public StartNodeBattleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartNodeBattleScRsp(StartNodeBattleScRsp other)
		: this()
	{
		gIHHBJMAGOC_ = other.gIHHBJMAGOC_;
		oICEJIMEONG_ = other.oICEJIMEONG_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartNodeBattleScRsp Clone()
	{
		return new StartNodeBattleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartNodeBattleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartNodeBattleScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GIHHBJMAGOC != other.GIHHBJMAGOC)
		{
			return false;
		}
		if (!oICEJIMEONG_.Equals(other.oICEJIMEONG_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (GIHHBJMAGOC != 0)
		{
			num ^= GIHHBJMAGOC.GetHashCode();
		}
		num ^= oICEJIMEONG_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (GIHHBJMAGOC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GIHHBJMAGOC);
		}
		oICEJIMEONG_.WriteTo(ref output, _repeated_oICEJIMEONG_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		if (GIHHBJMAGOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIHHBJMAGOC);
		}
		num += oICEJIMEONG_.CalculateSize(_repeated_oICEJIMEONG_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartNodeBattleScRsp other)
	{
		if (other != null)
		{
			if (other.GIHHBJMAGOC != 0)
			{
				GIHHBJMAGOC = other.GIHHBJMAGOC;
			}
			oICEJIMEONG_.Add(other.oICEJIMEONG_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				GIHHBJMAGOC = input.ReadUInt32();
				break;
			case 58u:
				oICEJIMEONG_.AddEntriesFrom(ref input, _repeated_oICEJIMEONG_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
