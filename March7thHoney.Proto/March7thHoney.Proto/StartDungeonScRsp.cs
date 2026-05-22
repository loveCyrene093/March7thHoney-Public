using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartDungeonScRsp : IMessage<StartDungeonScRsp>, IMessage, IEquatable<StartDungeonScRsp>, IDeepCloneable<StartDungeonScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartDungeonScRsp> _parser = new MessageParser<StartDungeonScRsp>(() => new StartDungeonScRsp());

	private UnknownFieldSet _unknownFields;

	public const int TargetSideFieldNumber = 3;

	private uint targetSide_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int LBCIKPEFAIPFieldNumber = 8;

	private static readonly FieldCodec<PDPALPDALDG> _repeated_lBCIKPEFAIP_codec = FieldCodec.ForMessage(66u, PDPALPDALDG.Parser);

	private readonly RepeatedField<PDPALPDALDG> lBCIKPEFAIP_ = new RepeatedField<PDPALPDALDG>();

	public const int OICEJIMEONGFieldNumber = 10;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_oICEJIMEONG_codec = FieldCodec.ForMessage(82u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> oICEJIMEONG_ = new RepeatedField<GKDEKJKOIJN>();

	public const int CPOMNGJDBCLFieldNumber = 11;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_cPOMNGJDBCL_codec = FieldCodec.ForMessage(90u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> cPOMNGJDBCL_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartDungeonScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartDungeonScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<PDPALPDALDG> LBCIKPEFAIP => lBCIKPEFAIP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> OICEJIMEONG => oICEJIMEONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> CPOMNGJDBCL => cPOMNGJDBCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartDungeonScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartDungeonScRsp(StartDungeonScRsp other)
		: this()
	{
		targetSide_ = other.targetSide_;
		retcode_ = other.retcode_;
		lBCIKPEFAIP_ = other.lBCIKPEFAIP_.Clone();
		oICEJIMEONG_ = other.oICEJIMEONG_.Clone();
		cPOMNGJDBCL_ = other.cPOMNGJDBCL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartDungeonScRsp Clone()
	{
		return new StartDungeonScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartDungeonScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartDungeonScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!lBCIKPEFAIP_.Equals(other.lBCIKPEFAIP_))
		{
			return false;
		}
		if (!oICEJIMEONG_.Equals(other.oICEJIMEONG_))
		{
			return false;
		}
		if (!cPOMNGJDBCL_.Equals(other.cPOMNGJDBCL_))
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
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= lBCIKPEFAIP_.GetHashCode();
		num ^= oICEJIMEONG_.GetHashCode();
		num ^= cPOMNGJDBCL_.GetHashCode();
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
		if (TargetSide != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TargetSide);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		lBCIKPEFAIP_.WriteTo(ref output, _repeated_lBCIKPEFAIP_codec);
		oICEJIMEONG_.WriteTo(ref output, _repeated_oICEJIMEONG_codec);
		cPOMNGJDBCL_.WriteTo(ref output, _repeated_cPOMNGJDBCL_codec);
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
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += lBCIKPEFAIP_.CalculateSize(_repeated_lBCIKPEFAIP_codec);
		num += oICEJIMEONG_.CalculateSize(_repeated_oICEJIMEONG_codec);
		num += cPOMNGJDBCL_.CalculateSize(_repeated_cPOMNGJDBCL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartDungeonScRsp other)
	{
		if (other != null)
		{
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			lBCIKPEFAIP_.Add(other.lBCIKPEFAIP_);
			oICEJIMEONG_.Add(other.oICEJIMEONG_);
			cPOMNGJDBCL_.Add(other.cPOMNGJDBCL_);
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
				TargetSide = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				lBCIKPEFAIP_.AddEntriesFrom(ref input, _repeated_lBCIKPEFAIP_codec);
				break;
			case 82u:
				oICEJIMEONG_.AddEntriesFrom(ref input, _repeated_oICEJIMEONG_codec);
				break;
			case 90u:
				cPOMNGJDBCL_.AddEntriesFrom(ref input, _repeated_cPOMNGJDBCL_codec);
				break;
			}
		}
	}
}
